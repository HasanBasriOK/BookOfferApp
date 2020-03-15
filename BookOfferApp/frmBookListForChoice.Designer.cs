namespace BookOfferApp
{
    partial class frmBookListForChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookListForChoice));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcBestBooks = new DevExpress.XtraGrid.GridControl();
            this.gvBestBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmBookTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmBookAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPublisher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcPopularBooks = new DevExpress.XtraGrid.GridControl();
            this.gvPopularBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcNewBooks = new DevExpress.XtraGrid.GridControl();
            this.gvNewBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gcBooks = new DevExpress.XtraGrid.GridControl();
            this.gvBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBookTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBookAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBackward = new DevExpress.XtraEditors.SimpleButton();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBestBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBestBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPopularBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPopularBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcBestBooks);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(481, 218);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "En iyi Kitaplar";
            // 
            // gcBestBooks
            // 
            this.gcBestBooks.Location = new System.Drawing.Point(5, 24);
            this.gcBestBooks.MainView = this.gvBestBooks;
            this.gcBestBooks.Name = "gcBestBooks";
            this.gcBestBooks.Size = new System.Drawing.Size(471, 189);
            this.gcBestBooks.TabIndex = 0;
            this.gcBestBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBestBooks});
            // 
            // gvBestBooks
            // 
            this.gvBestBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmBookTitle,
            this.clmBookAuthor,
            this.clmPublisher,
            this.clmImage});
            this.gvBestBooks.GridControl = this.gcBestBooks;
            this.gvBestBooks.Name = "gvBestBooks";
            this.gvBestBooks.OptionsBehavior.Editable = false;
            this.gvBestBooks.OptionsView.RowAutoHeight = true;
            this.gvBestBooks.OptionsView.ShowGroupPanel = false;
            this.gvBestBooks.DoubleClick += new System.EventHandler(this.gvBestBooks_DoubleClick);
            // 
            // clmBookTitle
            // 
            this.clmBookTitle.Caption = "Kitap Adı";
            this.clmBookTitle.FieldName = "BookTitle";
            this.clmBookTitle.Name = "clmBookTitle";
            this.clmBookTitle.Visible = true;
            this.clmBookTitle.VisibleIndex = 0;
            // 
            // clmBookAuthor
            // 
            this.clmBookAuthor.Caption = "Yazar";
            this.clmBookAuthor.FieldName = "BookAuthor";
            this.clmBookAuthor.Name = "clmBookAuthor";
            this.clmBookAuthor.Visible = true;
            this.clmBookAuthor.VisibleIndex = 1;
            // 
            // clmPublisher
            // 
            this.clmPublisher.Caption = "Yayınevi";
            this.clmPublisher.FieldName = "Publisher";
            this.clmPublisher.Name = "clmPublisher";
            this.clmPublisher.Visible = true;
            this.clmPublisher.VisibleIndex = 2;
            // 
            // clmImage
            // 
            this.clmImage.Caption = "Resim";
            this.clmImage.FieldName = "Image";
            this.clmImage.Name = "clmImage";
            this.clmImage.Visible = true;
            this.clmImage.VisibleIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcPopularBooks);
            this.groupControl2.Location = new System.Drawing.Point(499, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(497, 218);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Popüler Kitaplar";
            // 
            // gcPopularBooks
            // 
            this.gcPopularBooks.Location = new System.Drawing.Point(5, 24);
            this.gcPopularBooks.MainView = this.gvPopularBooks;
            this.gcPopularBooks.Name = "gcPopularBooks";
            this.gcPopularBooks.Size = new System.Drawing.Size(487, 189);
            this.gcPopularBooks.TabIndex = 0;
            this.gcPopularBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPopularBooks});
            // 
            // gvPopularBooks
            // 
            this.gvPopularBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvPopularBooks.GridControl = this.gcPopularBooks;
            this.gvPopularBooks.Name = "gvPopularBooks";
            this.gvPopularBooks.OptionsBehavior.Editable = false;
            this.gvPopularBooks.OptionsView.RowAutoHeight = true;
            this.gvPopularBooks.OptionsView.ShowGroupPanel = false;
            this.gvPopularBooks.DoubleClick += new System.EventHandler(this.gvPopularBooks_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Kitap Adı";
            this.gridColumn1.FieldName = "BookTitle";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Yazar";
            this.gridColumn2.FieldName = "BookAuthor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Yayınevi";
            this.gridColumn3.FieldName = "Publisher";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Resim";
            this.gridColumn4.FieldName = "Image";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gcNewBooks);
            this.groupControl3.Location = new System.Drawing.Point(1002, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(489, 218);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Yeni Kitaplar";
            // 
            // gcNewBooks
            // 
            this.gcNewBooks.Location = new System.Drawing.Point(5, 24);
            this.gcNewBooks.MainView = this.gvNewBooks;
            this.gcNewBooks.Name = "gcNewBooks";
            this.gcNewBooks.Size = new System.Drawing.Size(479, 189);
            this.gcNewBooks.TabIndex = 0;
            this.gcNewBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNewBooks});
            // 
            // gvNewBooks
            // 
            this.gvNewBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gvNewBooks.GridControl = this.gcNewBooks;
            this.gvNewBooks.Name = "gvNewBooks";
            this.gvNewBooks.OptionsBehavior.Editable = false;
            this.gvNewBooks.OptionsView.RowAutoHeight = true;
            this.gvNewBooks.OptionsView.ShowGroupPanel = false;
            this.gvNewBooks.DoubleClick += new System.EventHandler(this.gvNewBooks_DoubleClick);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "KitapAdı";
            this.gridColumn5.FieldName = "BookTitle";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Yazar";
            this.gridColumn6.FieldName = "BookAuthor";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Yayınevi";
            this.gridColumn7.FieldName = "Publisher";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Resim";
            this.gridColumn8.FieldName = "Image";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gcBooks);
            this.groupControl4.Location = new System.Drawing.Point(12, 236);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1479, 543);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Kitaplar";
            // 
            // gcBooks
            // 
            this.gcBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBooks.Location = new System.Drawing.Point(2, 21);
            this.gcBooks.MainView = this.gvBooks;
            this.gcBooks.Name = "gcBooks";
            this.gcBooks.Size = new System.Drawing.Size(1475, 520);
            this.gcBooks.TabIndex = 0;
            this.gcBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBooks});
            // 
            // gvBooks
            // 
            this.gvBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcISBN,
            this.gcBookTitle,
            this.gcBookAuthor,
            this.gcImage});
            this.gvBooks.GridControl = this.gcBooks;
            this.gvBooks.Name = "gvBooks";
            this.gvBooks.OptionsBehavior.Editable = false;
            this.gvBooks.OptionsView.RowAutoHeight = true;
            this.gvBooks.OptionsView.ShowGroupPanel = false;
            this.gvBooks.DoubleClick += new System.EventHandler(this.gvBooks_DoubleClick);
            // 
            // gcISBN
            // 
            this.gcISBN.Caption = "ISBN";
            this.gcISBN.FieldName = "ISBN";
            this.gcISBN.Name = "gcISBN";
            this.gcISBN.Visible = true;
            this.gcISBN.VisibleIndex = 0;
            // 
            // gcBookTitle
            // 
            this.gcBookTitle.Caption = "Kitap Adı";
            this.gcBookTitle.FieldName = "BookTitle";
            this.gcBookTitle.Name = "gcBookTitle";
            this.gcBookTitle.Visible = true;
            this.gcBookTitle.VisibleIndex = 1;
            // 
            // gcBookAuthor
            // 
            this.gcBookAuthor.Caption = "Yazar";
            this.gcBookAuthor.FieldName = "BookAuthor";
            this.gcBookAuthor.Name = "gcBookAuthor";
            this.gcBookAuthor.Visible = true;
            this.gcBookAuthor.VisibleIndex = 2;
            // 
            // gcImage
            // 
            this.gcImage.Caption = "Resim";
            this.gcImage.FieldName = "Image";
            this.gcImage.Name = "gcImage";
            this.gcImage.Visible = true;
            this.gcImage.VisibleIndex = 3;
            // 
            // btnBackward
            // 
            this.btnBackward.Image = ((System.Drawing.Image)(resources.GetObject("btnBackward.Image")));
            this.btnBackward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBackward.Location = new System.Drawing.Point(1317, 785);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(75, 46);
            this.btnBackward.TabIndex = 2;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnForward.Location = new System.Drawing.Point(1398, 785);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 46);
            this.btnForward.TabIndex = 3;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // frmBookListForChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 848);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmBookListForChoice";
            this.Text = "Kitaplar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBestBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBestBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPopularBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPopularBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gcBestBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBestBooks;
        private DevExpress.XtraGrid.GridControl gcPopularBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPopularBooks;
        private DevExpress.XtraGrid.GridControl gcNewBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNewBooks;
        private DevExpress.XtraGrid.GridControl gcBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBooks;
        private DevExpress.XtraGrid.Columns.GridColumn gcISBN;
        private DevExpress.XtraGrid.Columns.GridColumn gcBookTitle;
        private DevExpress.XtraGrid.Columns.GridColumn gcBookAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn gcImage;
        private DevExpress.XtraEditors.SimpleButton btnBackward;
        private DevExpress.XtraEditors.SimpleButton btnForward;
        private DevExpress.XtraGrid.Columns.GridColumn clmBookTitle;
        private DevExpress.XtraGrid.Columns.GridColumn clmBookAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn clmPublisher;
        private DevExpress.XtraGrid.Columns.GridColumn clmImage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}