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
using BookOfferApp.Classes;

namespace BookOfferApp
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

            var scoredInPast = BookScore.IsUserScoredInPast(Program.CurrentUserId);
            if (!scoredInPast)
            {
                ribbonPageGroup1.Visible = false;
                ribbonPageGroup3.Visible = false;

                frmBookScore frm = new frmBookScore();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnReadBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = null;
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBookListForChoice))
                {
                    frm = item;
                }
            }


            if (frm == null)
            {
                frm = new frmBookListForChoice();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                frm.BringToFront();
        }

        private void btnScoreBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = null;
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType()==typeof(frmBookScore))
                {
                    frm = item;
                }
            }

            if (frm==null)
            {
                frm = new frmBookScore();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                frm.BringToFront();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var scoredInPast = BookScore.IsUserScoredInPast(Program.CurrentUserId);

            if (scoredInPast)
            {
                ribbonPageGroup1.Visible = true;
                ribbonPageGroup3.Visible = true;
            }
            else
            {
                ribbonPageGroup3.Visible = false;
                ribbonPageGroup1.Visible = false;
            }
        }


        private void btnOfferBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = null;
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBookOffer))
                {
                    frm = item;
                }
            }

            if (frm == null)
            {
                frm = new frmBookOffer();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                frm.BringToFront();

        }
    }
}