namespace BookOfferApp
{
    partial class frmReadBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReadBook));
            this.txtPageText = new System.Windows.Forms.RichTextBox();
            this.btnBackward = new DevExpress.XtraEditors.SimpleButton();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtPageText
            // 
            this.txtPageText.Location = new System.Drawing.Point(12, 12);
            this.txtPageText.Name = "txtPageText";
            this.txtPageText.Size = new System.Drawing.Size(484, 416);
            this.txtPageText.TabIndex = 0;
            this.txtPageText.Text = "";
            // 
            // btnBackward
            // 
            this.btnBackward.Image = ((System.Drawing.Image)(resources.GetObject("btnBackward.Image")));
            this.btnBackward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBackward.Location = new System.Drawing.Point(342, 434);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(75, 35);
            this.btnBackward.TabIndex = 1;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnForward.Location = new System.Drawing.Point(423, 434);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 35);
            this.btnForward.TabIndex = 1;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // frmReadBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 481);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.txtPageText);
            this.Name = "frmReadBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Oku";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPageText;
        private DevExpress.XtraEditors.SimpleButton btnBackward;
        private DevExpress.XtraEditors.SimpleButton btnForward;
    }
}