using BookOfferApp.Classes;
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
    public partial class frmBookOffer : Form
    {
        public frmBookOffer()
        {
            InitializeComponent();
            FillBooks();
        }

        private Bitmap GetImage(string url)
        {
            System.Net.WebRequest request =System.Net.WebRequest.Create(url);
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream =response.GetResponseStream();
            Bitmap bitmap2 = new Bitmap(responseStream);
            return bitmap2;
        }


        private void FillBooks()
        {
            RepositoryItemPictureEdit pictureColumn = new RepositoryItemPictureEdit();
            gridControl1.RepositoryItems.Add(pictureColumn);
            gridView1.Columns["Image"].ColumnEdit = pictureColumn;
            gridView1.RowHeight = 100;


            List<Book> books = Book.BookOffer(Program.CurrentUserId);
            foreach (var book in books)
            {
                book.Image = GetImage(book.ImageUrlS);
            }
            gridControl1.DataSource = books;
        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmReadBook frm = new frmReadBook();
            frm.ShowDialog();
        }
    }
}
