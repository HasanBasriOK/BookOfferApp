using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace BookOfferApp
{
    public partial class frmAdminPanel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {

        }


        //kullanıcı listesi formunu açıyor frmUserList
        private void btnUserManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType()==typeof(frmUserList))
                {
                    form.BringToFront();
                    return;
                }
            }



            frmUserList frm = new frmUserList();
            frm.MdiParent = this;
            frm.Show();
        }


        //frmBookList formunu ekrana patlatıyor
        private void btnBookManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmBookList))
                {
                    form.BringToFront();
                    return;
                }
            }

            frmBookList frm = new frmBookList();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}