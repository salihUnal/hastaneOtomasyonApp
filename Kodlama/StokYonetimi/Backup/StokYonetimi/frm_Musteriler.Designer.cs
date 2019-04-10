namespace StokYonetimi
{
    partial class frm_Musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Musteriler));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Yeni = new DevExpress.XtraEditors.SimpleButton();
            this.txt_MusteriAdi = new DevExpress.XtraEditors.TextEdit();
            this.txt_MusteriKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdListe = new DevExpress.XtraGrid.GridControl();
            this.grdViewListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MusteriYetkilisi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_VergiD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_VergiN = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MusteriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MusteriKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MusteriYetkilisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VergiD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VergiN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Sil);
            this.panelControl1.Controls.Add(this.btn_Kaydet);
            this.panelControl1.Controls.Add(this.btn_Yeni);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(533, 42);
            this.panelControl1.TabIndex = 8;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.Image")));
            this.btn_Sil.Location = new System.Drawing.Point(152, 2);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 38);
            this.btn_Sil.TabIndex = 5;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.Image")));
            this.btn_Kaydet.Location = new System.Drawing.Point(77, 2);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 38);
            this.btn_Kaydet.TabIndex = 3;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Yeni
            // 
            this.btn_Yeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Yeni.Image = ((System.Drawing.Image)(resources.GetObject("btn_Yeni.Image")));
            this.btn_Yeni.Location = new System.Drawing.Point(2, 2);
            this.btn_Yeni.Name = "btn_Yeni";
            this.btn_Yeni.Size = new System.Drawing.Size(75, 38);
            this.btn_Yeni.TabIndex = 4;
            this.btn_Yeni.Text = "YENİ";
            this.btn_Yeni.Click += new System.EventHandler(this.btn_Yeni_Click);
            // 
            // txt_MusteriAdi
            // 
            this.txt_MusteriAdi.EnterMoveNextControl = true;
            this.txt_MusteriAdi.Location = new System.Drawing.Point(89, 74);
            this.txt_MusteriAdi.Name = "txt_MusteriAdi";
            this.txt_MusteriAdi.Properties.MaxLength = 50;
            this.txt_MusteriAdi.Size = new System.Drawing.Size(432, 20);
            this.txt_MusteriAdi.TabIndex = 1;
            // 
            // txt_MusteriKodu
            // 
            this.txt_MusteriKodu.EnterMoveNextControl = true;
            this.txt_MusteriKodu.Location = new System.Drawing.Point(89, 48);
            this.txt_MusteriKodu.Name = "txt_MusteriKodu";
            this.txt_MusteriKodu.Properties.MaxLength = 25;
            this.txt_MusteriKodu.Size = new System.Drawing.Size(432, 20);
            this.txt_MusteriKodu.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Müşteri Ünvanı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Müşteri Kodu";
            // 
            // grdListe
            // 
            this.grdListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdListe.Location = new System.Drawing.Point(0, 178);
            this.grdListe.MainView = this.grdViewListe;
            this.grdListe.Name = "grdListe";
            this.grdListe.Size = new System.Drawing.Size(533, 201);
            this.grdListe.TabIndex = 13;
            this.grdListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewListe});
            // 
            // grdViewListe
            // 
            this.grdViewListe.GridControl = this.grdListe;
            this.grdViewListe.Name = "grdViewListe";
            this.grdViewListe.OptionsView.ShowGroupPanel = false;
            this.grdViewListe.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewListe_FocusedRowChanged);
            this.grdViewListe.Click += new System.EventHandler(this.grdViewListe_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 155);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Vergi No";
            // 
            // txt_MusteriYetkilisi
            // 
            this.txt_MusteriYetkilisi.EnterMoveNextControl = true;
            this.txt_MusteriYetkilisi.Location = new System.Drawing.Point(89, 100);
            this.txt_MusteriYetkilisi.Name = "txt_MusteriYetkilisi";
            this.txt_MusteriYetkilisi.Properties.MaxLength = 50;
            this.txt_MusteriYetkilisi.Size = new System.Drawing.Size(432, 20);
            this.txt_MusteriYetkilisi.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Müşteri Yetkilisi";
            // 
            // txt_VergiD
            // 
            this.txt_VergiD.EnterMoveNextControl = true;
            this.txt_VergiD.Location = new System.Drawing.Point(89, 126);
            this.txt_VergiD.Name = "txt_VergiD";
            this.txt_VergiD.Properties.MaxLength = 50;
            this.txt_VergiD.Size = new System.Drawing.Size(432, 20);
            this.txt_VergiD.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 129);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Vergi Dairesi";
            // 
            // txt_VergiN
            // 
            this.txt_VergiN.EnterMoveNextControl = true;
            this.txt_VergiN.Location = new System.Drawing.Point(89, 152);
            this.txt_VergiN.Name = "txt_VergiN";
            this.txt_VergiN.Properties.Mask.EditMask = "d";
            this.txt_VergiN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_VergiN.Properties.MaxLength = 50;
            this.txt_VergiN.Size = new System.Drawing.Size(432, 20);
            this.txt_VergiN.TabIndex = 4;
            // 
            // frm_Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 378);
            this.Controls.Add(this.txt_VergiN);
            this.Controls.Add(this.txt_VergiD);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_MusteriYetkilisi);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grdListe);
            this.Controls.Add(this.txt_MusteriAdi);
            this.Controls.Add(this.txt_MusteriKodu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_Musteriler";
            this.Text = "MÜŞTERİLER";
            this.Load += new System.EventHandler(this.frm_Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MusteriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MusteriKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MusteriYetkilisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VergiD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VergiN.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_Yeni;
        private DevExpress.XtraEditors.TextEdit txt_MusteriAdi;
        private DevExpress.XtraEditors.TextEdit txt_MusteriKodu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdListe;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewListe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_MusteriYetkilisi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_VergiD;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_VergiN;
    }
}