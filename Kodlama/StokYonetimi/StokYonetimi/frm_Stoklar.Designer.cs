namespace StokYonetimi
{
    partial class frm_Stoklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Stoklar));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Yeni = new DevExpress.XtraEditors.SimpleButton();
            this.txt_StokAdi = new DevExpress.XtraEditors.TextEdit();
            this.txt_StokKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdListe = new DevExpress.XtraGrid.GridControl();
            this.grdViewListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.spn_VergiOrani = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spn_VergiOrani.Properties)).BeginInit();
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
            // txt_StokAdi
            // 
            this.txt_StokAdi.EnterMoveNextControl = true;
            this.txt_StokAdi.Location = new System.Drawing.Point(77, 74);
            this.txt_StokAdi.Name = "txt_StokAdi";
            this.txt_StokAdi.Properties.MaxLength = 50;
            this.txt_StokAdi.Size = new System.Drawing.Size(444, 20);
            this.txt_StokAdi.TabIndex = 1;
            // 
            // txt_StokKodu
            // 
            this.txt_StokKodu.EnterMoveNextControl = true;
            this.txt_StokKodu.Location = new System.Drawing.Point(77, 48);
            this.txt_StokKodu.Name = "txt_StokKodu";
            this.txt_StokKodu.Properties.MaxLength = 25;
            this.txt_StokKodu.Size = new System.Drawing.Size(444, 20);
            this.txt_StokKodu.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Stok Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // grdListe
            // 
            this.grdListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdListe.Location = new System.Drawing.Point(0, 126);
            this.grdListe.MainView = this.grdViewListe;
            this.grdListe.Name = "grdListe";
            this.grdListe.Size = new System.Drawing.Size(533, 163);
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
            this.labelControl3.Location = new System.Drawing.Point(12, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Vergi Oranı";
            // 
            // spn_VergiOrani
            // 
            this.spn_VergiOrani.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spn_VergiOrani.Location = new System.Drawing.Point(77, 100);
            this.spn_VergiOrani.Name = "spn_VergiOrani";
            this.spn_VergiOrani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spn_VergiOrani.Properties.Mask.EditMask = "n0";
            this.spn_VergiOrani.Size = new System.Drawing.Size(75, 20);
            this.spn_VergiOrani.TabIndex = 2;
            // 
            // frm_Stoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 288);
            this.Controls.Add(this.spn_VergiOrani);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grdListe);
            this.Controls.Add(this.txt_StokAdi);
            this.Controls.Add(this.txt_StokKodu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_Stoklar";
            this.Text = "STOKLAR";
            this.Load += new System.EventHandler(this.frm_Stoklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_StokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spn_VergiOrani.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_Yeni;
        private DevExpress.XtraEditors.TextEdit txt_StokAdi;
        private DevExpress.XtraEditors.TextEdit txt_StokKodu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdListe;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewListe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spn_VergiOrani;
    }
}