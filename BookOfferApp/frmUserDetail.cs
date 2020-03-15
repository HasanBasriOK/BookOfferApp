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
    public partial class frmUserDetail : Form
    {
        //user nesnesi oluşturuluyor 
        User _user;

        //yeni user için
        public frmUserDetail()
        {
            InitializeComponent();
        }

        //düzenlenecek user için 
        public frmUserDetail(User user)
        {
            //kaydet butonunda parametre almadığı için yukarıda global oluşturduğumuz değişkeni _user değişkenine atıyoruz ki kaydet olayında onu kullanabilelim.
            _user = user;
            InitializeComponent();
            //txt ye düzenlenecek kitabın bilgileri basılıyor.
            txtFirstName.Text = _user.FirstName;
            txtLastName.Text = _user.LastName;
            txtLocation.Text = _user.Location;
            txtPassword.Text = _user.Password;
            txtPasswordAgain.Text = _user.Password;
            txtUsername.Text = _user.Username;
            spnAge.EditValue = _user.Age;
        }

        //kaydet butonuna bastığımda;
        private void btnSave_Click(object sender, EventArgs e)
        {
            //verileri doldurup doldurmadığımıza bakılıp ona göre hata mesajı veriliyor
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtLocation.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPasswordAgain.Text) || string.IsNullOrEmpty(txtUsername.Text) || spnAge.EditValue == null || Convert.ToInt32(spnAge.EditValue) == 0)
            {
                XtraMessageBox.Show("Bütün bilgilerin dolu olduğuna emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //iki şifre ist6enmişti iki şifrenin eşitliği kontrol ediliyor ve şifrede bulunan başındaki ve sonundaki boşluklar görmezden geliniyor
            if (txtPassword.Text.Trim() != txtPasswordAgain.Text.Trim())
            {
                XtraMessageBox.Show("Girmiş olduğunuz şifreler uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //yeni kayıt
            if (_user==null)
            {
                //bu username yi daha önceden kullanan var mı var hat5a veriliyotr
                if (User.IsExist(txtUsername.Text))
                {
                    XtraMessageBox.Show("Girmiş olduğunuz kullanıcı adı sistemde mevcuttur lütfen başka bir kullanıcı adı girin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    //user nesnesi oluşturuluyotr
                    var user = new User();
                    //textbox lardan userın bilgileri alınıyor
                    user.Age = Convert.ToInt32(spnAge.EditValue);
                    user.FirstName = txtFirstName.Text;
                    user.LastName = txtLastName.Text;
                    user.Location = txtLocation.Text;
                    user.Password = txtPassword.Text;
                    user.Username = txtUsername.Text;

                    //veritabanına kayıt ediliyor
                    User.Insert(user);
                    //işleminiz gerçekleşti diyip bu formu kapatıyort
                    XtraMessageBox.Show("İşleminiz başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Hata Mesajı :" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //düzenleme
            else
            {
                try
                {
                    //bu seferde textboxlardaki verileri alıyoruz
                    _user.Age = Convert.ToInt32(spnAge.EditValue);
                    _user.FirstName = txtFirstName.Text;
                    _user.LastName = txtLastName.Text;
                    _user.Location = txtLocation.Text;
                    _user.Password = txtPassword.Text;
                    _user.Username = txtUsername.Text;

                    //veritabanında güncelliyoruz
                    User.Update(_user);
                    XtraMessageBox.Show("İşleminiz başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Hata Mesajı :" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //adres bilgisinde sayı girilmemesi içişn kontrol yapıyoruz
        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
