using DevExpress.XtraEditors;
using iTextSharp.text.pdf;
//pdf okuma için nugetten indirdiğimiz kütüphane
using iTextSharp.text.pdf.parser;
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
    public partial class frmReadBook : Form
    {
        //
        PdfReader reader;
        int numberOfPages;
        int currentPage = 1;

        //adam formu açtı
        public frmReadBook()
        {
            InitializeComponent();
            //random sayı belirliyoruz.1-3 arasında 
            Random rnd = new Random();
            int book = rnd.Next(1, 3);

            //siz seçtiğimiz kitap ile pdf leri uyuşmaya bilir dediğiniz için ben de internetten 3 kitap indirdim aşağıdakiler de yolları
            string[] bookPaths = new string[] { "C:\\Users\\HBO\\Desktop\\books\\Bahtiyar Kürklü - Beyinsiz!.pdf", "C:\\Users\\HBO\\Desktop\\books\\Hadisler_deryası.pdf", "C:\\Users\\HBO\\Desktop\\books\\Paullina Simons - Tatyana ve Alexander.pdf" };


            //pdf reader a dizsinin random sayıda seçilen elemanını al diyoruz ve bunu pdf olarak okumaya başla diyoruz
            reader = new PdfReader(bookPaths[book]);
            //pdf in toplam sayfa say7ısını bildiriyoruz.
            numberOfPages = reader.NumberOfPages;

            //ekrandaki textbox a ilk sayfayı yaz diyoruz
            txtPageText.Text= PdfTextExtractor.GetTextFromPage(reader, 1);
        }


        //adam ileri butonuna bastığı zaman bir sonraki sayfayı yazdırıyoruz
        private void btnForward_Click(object sender, EventArgs e)
        {
            //kitap bitiyor
            if (currentPage+1>numberOfPages)
            {
                XtraMessageBox.Show("Kitap sona ermiştir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //mevcut sayfanın sayısı 1 arttırılır ve br sonraki sayfa açılmış olur
            currentPage += 1;
            txtPageText.Text= PdfTextExtractor.GetTextFromPage(reader, currentPage);
        }

        //önceki sayfa butonuna tıklanınca bu event çalışır
        private void btnBackward_Click(object sender, EventArgs e)
        {
            //burda kita başa dönüyor
            if (currentPage - 1 <1)
            {
                XtraMessageBox.Show("Kitap sona ermiştir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //mevcut sayfanın sayısı 1 azaltılır ve br önceki sayfa açılmış olur
            currentPage -= 1;
            //bu sayfayı oku ve textboıx a yaz
            txtPageText.Text = PdfTextExtractor.GetTextFromPage(reader, currentPage);

        }
    }
}
