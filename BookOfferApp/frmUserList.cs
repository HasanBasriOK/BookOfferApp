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
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            //constructor da veritabanındaki kullanıcıları dolduruyor
            InitializeComponent();
            //listeleme işlemi
            FillUsers();
        }
        
        //veritabanındaki kullanıcıları dolduruyor
        private void FillUsers()
        {
            //veritabanındaki bütün kullanıcıları alıyoruz
            gcUsers.DataSource = User.GetObjects();
            //gride bastığım verileri yenile
            gcUsers.RefreshDataSource();
            gcUsers.Refresh();
        }

        //yeni butonuna basında frmUserDetail formuna yönlendiriyor
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUserDetail frm = new frmUserDetail();
            frm.ShowDialog();
        }


        //düzenle butonuna basınca
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //gridde seçilen satırı alır
            int[] selectedRows = gridView1.GetSelectedRows();

            //eğer herhangi bir seçim yapmamış ise hata mesajı
            if (selectedRows.Length==0)
            {
                XtraMessageBox.Show("Düzenlemek istediğiniz satırı seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //admin seçim yaptıysa seçtiği kullanıcıyı alıyorum ve frmUserDetail sayfasına düzenlenmek üzere gönderiyorum
            var user = gridView1.GetRow(selectedRows[0]) as User;
            frmUserDetail frm = new frmUserDetail(user);
            frm.ShowDialog();
        }

        //de4lete butonuna bastığımdea 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //adminin seçtiği satırı alıyor
            int[] selectedRows = gridView1.GetSelectedRows();
            //eğer herhanghi bir satır seçmemiş ise hata veriyıor
            if (selectedRows.Length == 0)
            {
                XtraMessageBox.Show("Düzenlemek istediğiniz satırı seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //seçili satırı user değişkenine atıyor. Veritabanına silmek üzere göndermekı için
            var user = gridView1.GetRow(selectedRows[0]) as User;


            //seçili kaydı silmek istediğinden emin misin; yani messagebox da yes butonuna bastı ise sil, noya basarsa hiçbir şey yapmıyor
            if(XtraMessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                try
                {
                    User.Delete(user.UserId);
                    XtraMessageBox.Show("İşleminiz başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillUsers();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("İşleminiz gerçekleştirilirken hata oluştu :"+ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
