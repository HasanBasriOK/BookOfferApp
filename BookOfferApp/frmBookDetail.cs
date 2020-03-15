using BookOfferApp.Classes;
using DevExpress.XtraEditors;
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
    //yeni kitap ve düzenle dediğimizde de bunu oluşturuyoruz tek fasrk düzenle dediğimizde do9lu geliyor diğerinde boş
    public partial class frmBookDetail : Form
    {
        //kitap nesnesi oluşturuyorux
        Book _book;

        //yeni oluşturacağımız zaman bu constructor u çağırıyoruz
        public frmBookDetail()
        {
            InitializeComponent();
        }

        //düzenle butonuna bastığımız zmanada bunu çağırıyoruz. Hangi kitabı frmBookList ten gönderdiysem o kitabı parametre olarak alıyorum.
        public frmBookDetail(Book book)
        {
            InitializeComponent();
            //kaydet botununda parametre olarak book u almadığımız için yukarıda _book a eşitliyoruz
            _book = book;


            //txt leri düzenlemek mistediğim kitaba göre dolduruyorum
            txtBookAuthor.Text = _book.BookAuthor;
            txtBookTitle.Text = _book.BookTitle;
            txtImageUrlL.Text = _book.ImageUrlL;
            txtImageUrlM.Text = _book.ImageUrlM;
            txtImageUrlS.Text = _book.ImageUrlS;
            txtISBN.Text = _book.ISBN;
            txtPublisher.Text = _book.Publisher;
            spnYearOfPublication.EditValue = _book.YearOfPublication;
        }

        //kaydet butonuna bastığımızda 
        private void btnSave_Click(object sender, EventArgs e)
        {
            //boş vgeri var mı diye kontrol ediyoruz hata mesajı döndürüyoruz
            if (string.IsNullOrEmpty(txtBookAuthor.Text) || string.IsNullOrEmpty(txtBookTitle.Text) || string.IsNullOrEmpty(txtImageUrlL.Text) || string.IsNullOrEmpty(txtImageUrlM.Text) || string.IsNullOrEmpty(txtImageUrlS.Text) || string.IsNullOrEmpty(txtISBN.Text) || string.IsNullOrEmpty(txtPublisher.Text) || spnYearOfPublication.EditValue==null || Convert.ToInt32(spnYearOfPublication.EditValue)==0)
            {
                XtraMessageBox.Show("Bütün alanların dolu olduğundan emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //düzenleye basılmamış demektir yeni bir kitap oluşlturmak istiyor demektir.
            if (_book==null)
            {
                //ısbn bilgisi unick tir bu daha önce kayıt edilmiş mi diye kontrol ediliyor hata mesajı
                if (Book.IsExist(txtISBN.Text))
                {
                    XtraMessageBox.Show("Girmiş olduğunuz ISBN numarası sistemde daha önce kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //kitap nesnesi oluşturuluyor.formdan verileri alınıp kitap nesnesi dolduruluyor
                var book = new Book();
                book.BookAuthor = txtBookAuthor.Text;
                book.BookTitle = txtBookTitle.Text;
                book.ImageUrlL = txtImageUrlL.Text;
                book.ImageUrlM = txtImageUrlM.Text;
                book.ImageUrlS = txtImageUrlS.Text;
                book.ISBN = txtISBN.Text;
                book.Publisher = txtPublisher.Text;
                book.YearOfPublication = Convert.ToInt32(spnYearOfPublication.EditValue);

                try
                {//bu verileri veritabanına kaydediyor
                    Book.Insert(book);
                    XtraMessageBox.Show("İşleminiz başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("İşleminiz gerçekleştirilirken hata oluştu :" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //eğer book nesnesi doluysa adam güncelle butonuna basmış demektir
            else
            {
                _book.BookAuthor = txtBookAuthor.Text;
                _book.BookTitle = txtBookTitle.Text;
                _book.ImageUrlL = txtImageUrlL.Text;
                _book.ImageUrlM = txtImageUrlM.Text;
                _book.ImageUrlS = txtImageUrlS.Text;
                _book.ISBN = txtISBN.Text;
                _book.Publisher = txtPublisher.Text;
                _book.YearOfPublication = Convert.ToInt32(spnYearOfPublication.EditValue);

                try
                {
                    //değerleri alıp kaydı güncelliyor
                    Book.Update(_book);
                    XtraMessageBox.Show("İşleminiz başarıyla gerçekleşmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("İşleminiz gerçekleştirilirken hata oluştu :"+ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
