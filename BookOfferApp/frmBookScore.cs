using BookOfferApp.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOfferApp
{
    public partial class frmBookScore : Form
    {
        //sayfa değiştirirken kaç ile kaç arasındaki kitapları alacağımı belirliyorum.
        int _startIndex = 1;
        int _endIndex = 10;

        //formun constructor u
        public frmBookScore()
        {
            //form açılır açılmaz kitapları doldur diyoruz.
            InitializeComponent();
            FillBooks(_startIndex, _endIndex);
        }

        //url den resmi indirip geri döndüren metod
        private Bitmap GetImage(string url)
        {
            //otomatik linke istek gönderiyor
            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            //ve cevap olarak dönen resmi
            System.Net.WebResponse response = request.GetResponse();
            //resmin stream halini alıyor
            System.IO.Stream responseStream =response.GetResponseStream();
            //görsele dönüştürüyor
            Bitmap bitmap2 = new Bitmap(responseStream);
            //elde ettiğimiz resmi geri döndürüyor
            return bitmap2;
        }

        //Kitapları grid e dolduran method 
        private void FillBooks(int startIndex, int endIndex)
        {
            //devexpres in gridinde resim gösterebilmek için 4 satırlık koda ihtiyacım var
            RepositoryItemPictureEdit pictureColumn = new RepositoryItemPictureEdit();
            gcBooks.RepositoryItems.Add(pictureColumn);
            gvBooks.Columns["Image"].ColumnEdit = pictureColumn;
            gvBooks.RowHeight = 100;


            //veritabanındaki 1-10 arasındaki kitapları çekiyorum
            List<Book> books = Book.GetObjectsWithIndex(startIndex, endIndex);
            foreach (var book in books)
            {
                //resmin bize url si verilmiş biz de bu url den resmi indiriyoruz ve kullanıcıya gösteriyoruz
                book.Image = GetImage(book.ImageUrlS);
            }

            //aldığın verilerle grid i doldur.
            gcBooks.DataSource = books;
        }

        //ileri butonu
        private void btnForward_Click(object sender, EventArgs e)
        {
            //indexleri 10 arttırarak birsonraki on kitabı listeler
            _startIndex += 10;
            _endIndex += 10;

            //sonra elde edilen yeni indexlerle kitaplar fveritabanından çekilip grid e aktarılır
            FillBooks(_startIndex, _endIndex);
        }


        //indexleri azaltıryor
        private void btnBackward_Click(object sender, EventArgs e)
        {
            //1. sayfadaysan daha geriğye gitmemen için uyarı veriyor
            if (_startIndex == 1)
            {
                XtraMessageBox.Show("Şu an ilk sayfadasınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _startIndex -= 10;
            _endIndex -= 10;

            FillBooks(_startIndex, _endIndex);
        }


        //gridte seçtiğin satır değişince buraya geliyor
        private void gvBooks_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //kullanıcının seçtiği satır değiştikçe eğer seçtiği kitap daha önce puanlanmış ise onu puan kısmına yazıyoruz.Puanlanmamışsa sıfır yazıyoruz
            //gridde seçtiğim satırı book değişkenine atar
            var book = gvBooks.GetFocusedRow() as Book;

            //eğer book nesnem boş değil ise kişi bu satırı gerçekten seçmiştir
            if (book!=null)
            {
                //bu kişi bu kitabı8 daha önce puanlamış mı diye kontrol ediyorum
                var scoreItem = BookScore.GetObject(book.BookId, Program.CurrentUserId);
                int score = scoreItem != null ? scoreItem.Score : default(int);
                //puanlamış ise spin e yazıyoruz
                spnScore.EditValue = score;
            }
        }


        //puanı kaydetme işlemini gerçekleştiriyoruz.
        private void btnScore_Click(object sender, EventArgs e)
        {
            //herhangi bir kitap seçilmeden kaydet'e basılmış ise hata veriyoruz
            if (gvBooks.GetFocusedRow()==null)
            {
                XtraMessageBox.Show("Puanlamak istediğiniz kitabı seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //girilen puan 1 ile 10 arasında değilse hata veriyoruz.
            if (Convert.ToInt32(spnScore.EditValue)>10 || Convert.ToInt32(spnScore.EditValue)<0)
            {
                XtraMessageBox.Show("Puan 1 ile 10 arasında olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            //seçilen kitabı book nesnesine atıyoruz
            var book = gvBooks.GetFocusedRow() as Book;
            //veritabanından bu kitabın daha önce puanlanıp puanlanmadığına bakıyoruz
            BookScore bookScore = BookScore.GetObject(book.BookId,Program.CurrentUserId);

            //daha önce hiç puanlama yapılmamış ise veritabanbına kayıt ediyoruz.
            if (bookScore==null)
            {
                //adamı9n seçtiği kitap id, adamın girdiği score ve kullanıcı da programa girerken benim id mi almıştı
                bookScore = new BookScore();
                bookScore.BookId = book.BookId;
                bookScore.Score = Convert.ToInt32( spnScore.EditValue);
                bookScore.UserId = Program.CurrentUserId;

                //bunları veritabanına ekliyoruz
                BookScore.Insert(bookScore);
            }
            else//daha önce puanlanmış-update yapılacak
            {
                //eğer daha önce bir puan vermiş ise güncelleme işlemi gerçekleştiriyoruz
                bookScore.Score = Convert.ToInt32( spnScore.EditValue);
                BookScore.Update(bookScore);
            }

            //sonra da bilgi mesajı veriyoruz.
            XtraMessageBox.Show("İşleminiz başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
