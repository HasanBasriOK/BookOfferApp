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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //giriş yap butonuna bastığı zaman bu olay çalışıyor
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //kullanıcı adı veya şifre boş mu diye kontrol ediyoruz. Boş ise birinden biri hata mesajı ekrana patlatıyor.
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                XtraMessageBox.Show("Kullanıcı adı ve şifre bilgileri boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //txt ye girilen değerleri değişkene atıyoruz.
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //Kişinin girdiği kullanıcı adı ve şifreyi alıp onu veritabanında böyle bir kullanıcı adı ve şifresi var mı diye sorguluyorum ve user değişkenine atıyorum.
            //User classı ve GetUser metodunu ben oluşturdum.
            //User  classının iğçerisinde metod ve propertiesler var.
            //Properties veritabanında ne kolon varsa onların değişkenlerinin oluşturuyordu.
            var user= User.GetUser(username, password);

            //eğer kullanıcı yoksa kullanıcıyı veritabanında bulamammışım. Hata mesajı patlatıyoruz.
            if (user==null)
            {
                XtraMessageBox.Show("Girmiş olduğunuz bilgilere ait kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //kullanıcı ismini ve şifresinin veritabanıneda bulduysam;
            else
            {
                //veritabanından çektiğim kullanıcının id sini program.cs deki değişkene atıyorum
                Program.CurrentUserId = user.UserId;
                //ku kişi admin mi yoksa normal kullanıcı mı diye bakıyorum.
                //eğer kullanıcı adı admin ise admindir.
                if (username.ToLower()=="admin")
                {
                    //admin ise admin panel formunu açıyorum
                    frmAdminPanel frm = new frmAdminPanel();
                    //showdialog arkadaki forma herhangi bir müdahalede bulunamamasını sağlıyor
                    frm.ShowDialog();
                }

                //admin değilse normal menu ekranını açıyorum
                else
                {
                    frmMain frm = new frmMain();
                    frm.ShowDialog();
                }
            }
        }


        //uye olo butonuna basınca da uye ol ekranını açıyorum
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frm = new frmSignUp();
            frm.ShowDialog();
        }
    }
}
