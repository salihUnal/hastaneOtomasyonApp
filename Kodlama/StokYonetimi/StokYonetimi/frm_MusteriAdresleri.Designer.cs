namespace StokYonetimi
{
    partial class frm_MusteriAdresleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MusteriAdresleri));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Yeni = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Cadde = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdListe = new DevExpress.XtraGrid.GridControl();
            this.grdViewListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Sokak = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Ilce = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Il = new DevExpress.XtraEditors.TextEdit();
            this.spn_AdresNo = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Telefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_MusteriKodu = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cadde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sokak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spn_AdresNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MusteriKodu.Properties)).BeginInit();
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
            // txt_Cadde
            // 
            this.txt_Cadde.EnterMoveNextControl = true;
            this.txt_Cadde.Location = new System.Drawing.Point(89, 100);
            this.txt_Cadde.Name = "txt_Cadde";
            this.txt_Cadde.Properties.MaxLength = 50;
            this.txt_Cadde.Size = new System.Drawing.Size(432, 20);
            this.txt_Cadde.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Cadde";
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
            this.grdListe.Location = new System.Drawing.Point(0, 230);
            this.grdListe.MainView = this.grdViewListe;
            this.grdListe.Name = "grdListe";
            this.grdListe.Size = new System.Drawing.Size(533, 169);
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
            this.labelControl3.Location = new System.Drawing.Point(12, 181);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "İl";
            // 
            // txt_Sokak
            // 
            this.txt_Sokak.EnterMoveNextControl = true;
            this.txt_Sokak.Location = new System.Drawing.Point(89, 126);
            this.txt_Sokak.Name = "txt_Sokak";
            this.txt_Sokak.Properties.MaxLength = 50;
            this.txt_Sokak.Size = new System.Drawing.Size(432, 20);
            this.txt_Sokak.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Sokak";
            // 
            // txt_Ilce
            // 
            this.txt_Ilce.EnterMoveNextControl = true;
            this.txt_Ilce.Location = new System.Drawing.Point(89, 152);
            this.txt_Ilce.Name = "txt_Ilce";
            this.txt_Ilce.Properties.MaxLength = 50;
            this.txt_Ilce.Size = new System.Drawing.Size(432, 20);
            this.txt_Ilce.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 155);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(17, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "İlçe";
            // 
            // txt_Il
            // 
            this.txt_Il.EnterMoveNextControl = true;
            this.txt_Il.Location = new System.Drawing.Point(89, 178);
            this.txt_Il.Name = "txt_Il";
            this.txt_Il.Properties.Mask.EditMask = "d";
            this.txt_Il.Properties.MaxLength = 50;
            this.txt_Il.Size = new System.Drawing.Size(432, 20);
            this.txt_Il.TabIndex = 5;
            // 
            // spn_AdresNo
            // 
            this.spn_AdresNo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spn_AdresNo.EnterMoveNextControl = true;
            this.spn_AdresNo.Location = new System.Drawing.Point(89, 74);
            this.spn_AdresNo.Name = "spn_AdresNo";
            this.spn_AdresNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spn_AdresNo.Properties.Mask.EditMask = "n0";
            this.spn_AdresNo.Size = new System.Drawing.Size(75, 20);
            this.spn_AdresNo.TabIndex = 1;
            this.spn_AdresNo.Validating += new System.ComponentModel.CancelEventHandler(this.spn_AdresNo_Validating);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 77);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Adres No";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.EnterMoveNextControl = true;
            this.txt_Telefon.Location = new System.Drawing.Point(89, 204);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Properties.Mask.EditMask = "d";
            this.txt_Telefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Telefon.Properties.MaxLength = 50;
            this.txt_Telefon.Size = new System.Drawing.Size(432, 20);
            this.txt_Telefon.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 207);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 13);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Telefon";
            // 
            // btn_MusteriKodu
            // 
            this.btn_MusteriKodu.EnterMoveNextControl = true;
            this.btn_MusteriKodu.Location = new System.Drawing.Point(89, 48);
            this.btn_MusteriKodu.Name = "btn_MusteriKodu";
            this.btn_MusteriKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_MusteriKodu.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btn_MusteriKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F10))});
            this.btn_MusteriKodu.Size = new System.Drawing.Size(432, 20);
            this.btn_MusteriKodu.TabIndex = 0;
            this.btn_MusteriKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_MusteriKodu_ButtonClick);
            this.btn_MusteriKodu.Validating += new System.ComponentModel.CancelEventHandler(this.btn_MusteriKodu_Validating);
            // 
            // frm_MusteriAdresleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 398);
            this.Controls.Add(this.btn_MusteriKodu);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.spn_AdresNo);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_Il);
            this.Controls.Add(this.txt_Ilce);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_Sokak);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grdListe);
            this.Controls.Add(this.txt_Cadde);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_MusteriAdresleri";
            this.Text = "MÜŞTERİ ADRESLERİ";
            this.Load += new System.EventHandler(this.frm_Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cadde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sokak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spn_AdresNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MusteriKodu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_Yeni;
        private DevExpress.XtraEditors.TextEdit txt_Cadde;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdListe;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewListe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Sokak;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Ilce;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Il;
        private DevExpress.XtraEditors.SpinEdit spn_AdresNo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_Telefon;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.ButtonEdit btn_MusteriKodu;
    }
}