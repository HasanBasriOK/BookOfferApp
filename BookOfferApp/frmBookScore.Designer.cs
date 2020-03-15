namespace BookOfferApp
{
    partial class frmBookScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookScore));
            this.gcBooks = new DevExpress.XtraGrid.GridControl();
            this.gvBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPublisher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnScore = new DevExpress.XtraEditors.SimpleButton();
            this.spnScore = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackward = new DevExpress.XtraEditors.SimpleButton();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnScore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBooks
            // 
            this.gcBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBooks.Location = new System.Drawing.Point(0, 0);
            this.gcBooks.MainView = this.gvBooks;
            this.gcBooks.Name = "gcBooks";
            this.gcBooks.Size = new System.Drawing.Size(1265, 539);
            this.gcBooks.TabIndex = 0;
            this.gcBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBooks});
            // 
            // gvBooks
            // 
            this.gvBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcName,
            this.gcAuthor,
            this.gcPublisher,
            this.gcImage});
            this.gvBooks.GridControl = this.gcBooks;
            this.gvBooks.Name = "gvBooks";
            this.gvBooks.OptionsBehavior.Editable = false;
            this.gvBooks.OptionsView.ShowAutoFilterRow = true;
            this.gvBooks.OptionsView.ShowGroupPanel = false;
            this.gvBooks.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvBooks_FocusedRowChanged);
            // 
            // gcName
            // 
            this.gcName.Caption = "Kitap Adı";
            this.gcName.FieldName = "BookTitle";
            this.gcName.Name = "gcName";
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 0;
            // 
            // gcAuthor
            // 
            this.gcAuthor.Caption = "Yazar";
            this.gcAuthor.FieldName = "BookAuthor";
            this.gcAuthor.Name = "gcAuthor";
            this.gcAuthor.Visible = true;
            this.gcAuthor.VisibleIndex = 1;
            // 
            // gcPublisher
            // 
            this.gcPublisher.Caption = "Yayınevi";
            this.gcPublisher.FieldName = "Publisher";
            this.gcPublisher.Name = "gcPublisher";
            this.gcPublisher.Visible = true;
            this.gcPublisher.VisibleIndex = 2;
            // 
            // gcImage
            // 
            this.gcImage.Caption = "Resim";
            this.gcImage.FieldName = "Image";
            this.gcImage.Name = "gcImage";
            this.gcImage.Visible = true;
            this.gcImage.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnScore);
            this.panelControl1.Controls.Add(this.spnScore);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnForward);
            this.panelControl1.Controls.Add(this.btnBackward);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 539);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1265, 70);
            this.panelControl1.TabIndex = 1;
            // 
            // btnScore
            // 
            this.btnScore.Image = ((System.Drawing.Image)(resources.GetObject("btnScore.Image")));
            this.btnScore.Location = new System.Drawing.Point(233, 17);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(118, 35);
            this.btnScore.TabIndex = 3;
            this.btnScore.Text = "Kaydet";
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // spnScore
            // 
            this.spnScore.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnScore.Location = new System.Drawing.Point(118, 25);
            this.spnScore.Name = "spnScore";
            this.spnScore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnScore.Size = new System.Drawing.Size(100, 20);
            this.spnScore.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puan(1 ile 10 arası)";
            // 
            // btnForward
            // 
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnForward.Location = new System.Drawing.Point(1188, 6);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(65, 52);
            this.btnForward.TabIndex = 0;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Image = ((System.Drawing.Image)(resources.GetObject("btnBackward.Image")));
            this.btnBackward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBackward.Location = new System.Drawing.Point(1117, 6);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(65, 52);
            this.btnBackward.TabIndex = 0;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(539, 72);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(100, 20);
            this.spinEdit1.TabIndex = 2;
            // 
            // frmBookScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 609);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.gcBooks);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmBookScore";
            this.Text = "Kitap Puanlama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnScore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBooks;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnForward;
        private DevExpress.XtraEditors.SimpleButton btnBackward;
        private DevExpress.XtraEditors.SimpleButton btnScore;
        private DevExpress.XtraEditors.SpinEdit spnScore;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcImage;
        private DevExpress.XtraGrid.Columns.GridColumn gcAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn gcPublisher;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
    }
}