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
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            //veritabanından kitapları dolduruyor form ilk açıldığında
            InitializeComponent();
            FillBooks();
        }

        //gride kitapları dolduruyor
        private void FillBooks()
        {
            //veritabanından kitapları alıyor
            gcBooks.DataSource = Book.GetObjects();
            gcBooks.RefreshDataSource();
            //grid üzerindeki dataları reflesh ediyor.mesela kitapları lkisteledim sonra sil e bastım mevcut bir liste vardı onun üğzerine yeniden oluşlturuyor
            gcBooks.Refresh();
        }

        //yeni butonuna tıkladığımızda frmBookDetail formuna gidiyor
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmBookDetail frm = new frmBookDetail();
            frm.ShowDialog();
        }

        //düzenle butonuna tıkladığıomızda 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //gridde seçtiği satırı seçilensatıra atıyort
            int[] selectedRows = gridView1.GetSelectedRows();
            //eğer hiçbir şey seçmemişse hata mesajı döndürüyor
            if (selectedRows.Length == 0)
            {
                XtraMessageBox.Show("Düzenlemek istediğiniz satırı seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //seçilen satırı book değişkenine atıyor sonra düzenlenmek üzere detail sayfasına seçilen satırı gönderiyor
            var book = gridView1.GetRow(selectedRows[0]) as Book;
            frmBookDetail frm = new frmBookDetail(book);
            frm.ShowDialog();
        }


        //sil butonuna basılınca
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //gridde seçtiği satırı seçilensatıra atıyort
            int[] selectedRows = gridView1.GetSelectedRows();
            // eğer hiçbir şey seçmemişse hata mesajı döndürüyor
            if (selectedRows.Length == 0)
            {
                XtraMessageBox.Show("Düzenlemek istediğiniz satırı seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //seçilen kitabı book değişkenine atıyor
            var book = gridView1.GetRow(selectedRows[0]) as Book;

            //silmek için emin misiniz eğer evet e basılmış ise siliyor
            if (XtraMessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    Book.Delete(book.BookId);
                    XtraMessageBox.Show("İşleminiz başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //sildikten sonra günce4l listeyi dolduruyoruz
                    FillBooks();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("İşleminiz gerçekleştirilirken hata oluştu : "+ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
