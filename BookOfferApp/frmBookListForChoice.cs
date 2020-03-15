using BookOfferApp.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOfferApp
{
    public partial class frmBookListForChoice : Form
    {
        int _startIndex = 1;
        int _endIndex = 10;

        public frmBookListForChoice()
        {
            InitializeComponent();
            FillBooks(_startIndex,_endIndex);
            GetBestBooks();
            GetPopularBooks();
            GetNewestBooks();
        }

        private Bitmap GetImage(string url)
        {
            System.Net.WebRequest request =
      System.Net.WebRequest.Create(
      url);
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream =
                response.GetResponseStream();
            Bitmap bitmap2 = new Bitmap(responseStream);
            return bitmap2;
        }

        private void FillBooks(int startIndex,int endIndex)
        {
            RepositoryItemPictureEdit pictureColumn = new RepositoryItemPictureEdit();
            gcBooks.RepositoryItems.Add(pictureColumn);
            gvBooks.Columns["Image"].ColumnEdit = pictureColumn;
            gvBooks.RowHeight = 100;

           var books = Book.GetObjectsWithIndex(startIndex,endIndex);
            foreach (var book in books)
            {
                book.Image =GetImage(book.ImageUrlS);
            }

            gcBooks.DataSource = books;
        }

        private void GetBestBooks()
        {
            RepositoryItemPictureEdit pictureColumn = new RepositoryItemPictureEdit();
            gcBooks.RepositoryItems.Add(pictureColumn);
            gvBooks.Columns["Image"].ColumnEdit = pictureColumn;
            gvBooks.RowHeight = 200;

            List<Book> books = Book.GetBestBooks();
            foreach (var book in books)
            {
                book.Image = GetImage(book.ImageUrlS);
            }
            gcBestBooks.DataSource = books;
        }


        private void GetNewestBooks()
        {
            RepositoryItemPictureEdit pictureColumn = new RepositoryItemPictureEdit();
            gcBooks.RepositoryItems.Add(pictureColumn);
            gvBooks.Columns["Image"].ColumnEdit = pictureColumn;
            gvBooks.RowHeight = 200;

            List<Book> books = Book.GetNewestBooks();
            foreach (var book in books)
            {
                book.Image = GetImage(book.ImageUrlS);
            }
            gcNewBooks.DataSource = books;
        }


        private void GetPopularBooks()
        {
            RepositoryItemPictureEdit pictureColumn = new RepositoryItemPictureEdit();
            gcBooks.RepositoryItems.Add(pictureColumn);
            gvBooks.Columns["Image"].ColumnEdit = pictureColumn;
            gvBooks.RowHeight = 200;

            List<Book> books = Book.GetPopularBooks();
            foreach (var book in books)
            {
                book.Image = GetImage(book.ImageUrlS);
            }
            gcPopularBooks.DataSource = books;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            _startIndex += 10;
            _endIndex += 10;

            FillBooks(_startIndex, _endIndex);
        }


        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (_startIndex==1)
            {
                XtraMessageBox.Show("Şu an ilk sayfadasınız","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _startIndex -= 10;
            _endIndex -= 10;

            FillBooks(_startIndex, _endIndex);
        }

        private void OpenReadBookPage()
        {
            frmReadBook frm = new frmReadBook();
            frm.ShowDialog();
        }


        private void gvBestBooks_DoubleClick(object sender, EventArgs e)
        {
            OpenReadBookPage();
        }

        private void gvPopularBooks_DoubleClick(object sender, EventArgs e)
        {
            OpenReadBookPage();
        }

        private void gvNewBooks_DoubleClick(object sender, EventArgs e)
        {
            OpenReadBookPage();
        }

        private void gvBooks_DoubleClick(object sender, EventArgs e)
        {
            OpenReadBookPage();
        }
    }
}
