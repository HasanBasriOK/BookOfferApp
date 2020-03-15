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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        //kaydet butonuna tıkladığımızda;
        private void btnSave_Click(object sender, EventArgs e)
        {
            //kullanıcıdan aldığımız verilerden herhangi biri boş mu diye bakılır
            //boşl ise hata mesajı patlatılır.
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtLocation.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPasswordAgain.Text) || string.IsNullOrEmpty(txtUsername.Text) || spnAge.EditValue==null || Convert.ToInt32( spnAge.EditValue)==0)
            {
                XtraMessageBox.Show("Bütün bilgilerin dolu olduğuna emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //bu kullaqnıcı adı daha önce kullanılmış mı diye bakılır
            //eğer daha önce bu kullanıcı adı kullanılmış ise adqam bu kullanıcı adını alamaz.
            //isExist : var mı
            if (User.IsExist(txtUsername.Text))
            {
                XtraMessageBox.Show("Girmiş olduğunuz kullanıcı adı sistemde mevcuttur lütfen başka bir kullanıcı adı girin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //2 defa parola istedik girdiği iki parola da uyuşuyor mu diye kontrol eder
            //trim ile de başındaki ve sonundaki boşlukları görmezden gelir, ortadakilere bakmaz.
            if (txtPassword.Text.Trim()!=txtPasswordAgain.Text.Trim())
            {
                XtraMessageBox.Show("Girmiş olduğunuz şifreler uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            //adamın girmiği bilgiler ile kullanıcı nesnesi oluşturuyoruz.
            try
            {
                var user = new User();
                //spinedit ile bu şekilde alınıyor
                user.Age = Convert.ToInt32(spnAge.EditValue);
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.Location = txtLocation.Text;
                user.Password = txtPassword.Text;
                user.Username = txtUsername.Text;

                //girilen verileri veritabanına kayıt ediyoruz
                User.Insert(user);
                //kayıt işleminin gerçekleştiğin3e dair bilgi verilir.
                XtraMessageBox.Show("İşleminiz başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType()==typeof(frmLogin))
                        form.BringToFront();
                }
                this.Close();
            }

            //hata alındıysa hata mesajı veriliyor.Ben kodda herhangi bir hata yaptıysam bir şeyleri göçzden kaçırdıysam.
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata Mesajı :"+ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //locationda(adreste) rakam yazmasın diye keyPress event tında yani tuşa tıklandığında
        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bu bir kontrol tuşu değil ise yani alt ctrl vb ve sayi ise yaz yoksa yazma. Girdiğin karakteri eline al yani bunu kullanabilirsin de.
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
