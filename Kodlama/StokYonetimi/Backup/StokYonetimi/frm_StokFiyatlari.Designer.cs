namespace StokYonetimi
{
    partial class frm_StokFiyatlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StokFiyatlari));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Yeni = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdListe = new DevExpress.XtraGrid.GridControl();
            this.grdViewListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.spn_FiyatNo = new DevExpress.XtraEditors.SpinEdit();
            this.spn_Fiyat = new DevExpress.XtraEditors.SpinEdit();
            this.btn_StokKodu = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spn_FiyatNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spn_Fiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_StokKodu.Properties)).BeginInit();
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
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Fiyatı";
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
            this.grdListe.Size = new System.Drawing.Size(533, 180);
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
            this.labelControl3.Location = new System.Drawing.Point(12, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Fiyat No";
            // 
            // spn_FiyatNo
            // 
            this.spn_FiyatNo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spn_FiyatNo.EnterMoveNextControl = true;
            this.spn_FiyatNo.Location = new System.Drawing.Point(77, 74);
            this.spn_FiyatNo.Name = "spn_FiyatNo";
            this.spn_FiyatNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spn_FiyatNo.Properties.Mask.EditMask = "n0";
            this.spn_FiyatNo.Size = new System.Drawing.Size(75, 20);
            this.spn_FiyatNo.TabIndex = 1;
            this.spn_FiyatNo.Validating += new System.ComponentModel.CancelEventHandler(this.spn_FiyatNo_Validating);
            // 
            // spn_Fiyat
            // 
            this.spn_Fiyat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spn_Fiyat.EnterMoveNextControl = true;
            this.spn_Fiyat.Location = new System.Drawing.Point(77, 100);
            this.spn_Fiyat.Name = "spn_Fiyat";
            this.spn_Fiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spn_Fiyat.Properties.Mask.EditMask = "n";
            this.spn_Fiyat.Size = new System.Drawing.Size(75, 20);
            this.spn_Fiyat.TabIndex = 2;
            // 
            // btn_StokKodu
            // 
            this.btn_StokKodu.EnterMoveNextControl = true;
            this.btn_StokKodu.Location = new System.Drawing.Point(77, 48);
            this.btn_StokKodu.Name = "btn_StokKodu";
            this.btn_StokKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_StokKodu.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btn_StokKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F10))});
            this.btn_StokKodu.Size = new System.Drawing.Size(444, 20);
            this.btn_StokKodu.TabIndex = 0;
            this.btn_StokKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_StokKodu_ButtonClick);
            this.btn_StokKodu.Validating += new System.ComponentModel.CancelEventHandler(this.btn_StokKodu_Validating);
            // 
            // frm_StokFiyatlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 305);
            this.Controls.Add(this.btn_StokKodu);
            this.Controls.Add(this.spn_Fiyat);
            this.Controls.Add(this.spn_FiyatNo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grdListe);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_StokFiyatlari";
            this.Text = "STOK FİYATLARI";
            this.Load += new System.EventHandler(this.frm_StokFiyatlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spn_FiyatNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spn_Fiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_StokKodu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_Yeni;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdListe;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewListe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spn_FiyatNo;
        private DevExpress.XtraEditors.SpinEdit spn_Fiyat;
        public DevExpress.XtraEditors.ButtonEdit btn_StokKodu;
    }
}