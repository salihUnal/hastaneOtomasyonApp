namespace StokYonetimi
{
    partial class frm_Evrak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Evrak));
            this.btnSira = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.dtETarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnMusteriKod = new DevExpress.XtraEditors.ButtonEdit();
            this.btnMusteriUnvani = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grdEvrak = new DevExpress.XtraGrid.GridControl();
            this.grdEvrakView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtYekun = new DevExpress.XtraEditors.TextEdit();
            this.txtKdv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtAraToplam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.btnSatirSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdresNo = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnSira.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtETarih.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtETarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMusteriKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMusteriUnvani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvrak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvrakView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYekun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAraToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdresNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSira
            // 
            this.btnSira.EnterMoveNextControl = true;
            this.btnSira.Location = new System.Drawing.Point(90, 12);
            this.btnSira.Name = "btnSira";
            this.btnSira.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSira.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnSira.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F10))});
            this.btnSira.Properties.Mask.EditMask = "f0";
            this.btnSira.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.btnSira.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSira.Size = new System.Drawing.Size(102, 20);
            this.btnSira.TabIndex = 0;
            this.btnSira.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSira_ButtonClick);
            this.btnSira.Enter += new System.EventHandler(this.btnSira_Enter);
            this.btnSira.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSira_KeyPress);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(13, 14);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(48, 14);
            this.labelControl14.TabIndex = 54;
            this.labelControl14.Text = "Evrak No";
            // 
            // dtETarih
            // 
            this.dtETarih.EditValue = null;
            this.dtETarih.EnterMoveNextControl = true;
            this.dtETarih.Location = new System.Drawing.Point(279, 12);
            this.dtETarih.Name = "dtETarih";
            this.dtETarih.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PapayaWhip;
            this.dtETarih.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtETarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F10))});
            this.dtETarih.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtETarih.Size = new System.Drawing.Size(100, 20);
            this.dtETarih.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(231, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 14);
            this.labelControl1.TabIndex = 63;
            this.labelControl1.Text = "Tarih";
            // 
            // btnMusteriKod
            // 
            this.btnMusteriKod.EnterMoveNextControl = true;
            this.btnMusteriKod.Location = new System.Drawing.Point(90, 38);
            this.btnMusteriKod.Name = "btnMusteriKod";
            this.btnMusteriKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnMusteriKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnMusteriKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F10))});
            this.btnMusteriKod.Size = new System.Drawing.Size(289, 20);
            this.btnMusteriKod.TabIndex = 2;
            this.btnMusteriKod.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnMusteriKod_ButtonClick);
            this.btnMusteriKod.Validating += new System.ComponentModel.CancelEventHandler(this.btnMusteriKod_Validating);
            // 
            // btnMusteriUnvani
            // 
            this.btnMusteriUnvani.EnterMoveNextControl = true;
            this.btnMusteriUnvani.Location = new System.Drawing.Point(90, 64);
            this.btnMusteriUnvani.Name = "btnMusteriUnvani";
            this.btnMusteriUnvani.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnMusteriUnvani.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnMusteriUnvani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F10))});
            this.btnMusteriUnvani.Size = new System.Drawing.Size(289, 20);
            this.btnMusteriUnvani.TabIndex = 3;
            this.btnMusteriUnvani.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnMusteriUnvani_ButtonClick);
            this.btnMusteriUnvani.Validating += new System.ComponentModel.CancelEventHandler(this.btnMusteriUnvani_Validating);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 40);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 14);
            this.labelControl5.TabIndex = 67;
            this.labelControl5.Text = "Müşteri Kodu";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 66;
            this.labelControl4.Text = "Müşteri Adı";
            // 
            // grdEvrak
            // 
            this.grdEvrak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEvrak.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdEvrak.Enabled = false;
            this.grdEvrak.Location = new System.Drawing.Point(10, 116);
            this.grdEvrak.MainView = this.grdEvrakView;
            this.grdEvrak.Name = "grdEvrak";
            this.grdEvrak.Size = new System.Drawing.Size(650, 189);
            this.grdEvrak.TabIndex = 5;
            this.grdEvrak.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdEvrakView});
            this.grdEvrak.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEvrak_EditorKeyDown);
            // 
            // grdEvrakView
            // 
            this.grdEvrakView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdEvrakView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdEvrakView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.grdEvrakView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdEvrakView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdEvrakView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdEvrakView.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.grdEvrakView.Appearance.Empty.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdEvrakView.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdEvrakView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.EvenRow.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.EvenRow.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdEvrakView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdEvrakView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.grdEvrakView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdEvrakView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.grdEvrakView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.grdEvrakView.Appearance.FixedLine.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grdEvrakView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.grdEvrakView.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.grdEvrakView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdEvrakView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdEvrakView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdEvrakView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdEvrakView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdEvrakView.Appearance.GroupButton.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdEvrakView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdEvrakView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdEvrakView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grdEvrakView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdEvrakView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdEvrakView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.grdEvrakView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.grdEvrakView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.grdEvrakView.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.grdEvrakView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdEvrakView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdEvrakView.Appearance.HorzLine.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdEvrakView.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdEvrakView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.OddRow.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.OddRow.Options.UseBorderColor = true;
            this.grdEvrakView.Appearance.OddRow.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.grdEvrakView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.grdEvrakView.Appearance.Preview.Options.UseFont = true;
            this.grdEvrakView.Appearance.Preview.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdEvrakView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grdEvrakView.Appearance.Row.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.Row.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdEvrakView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.grdEvrakView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.grdEvrakView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdEvrakView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdEvrakView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grdEvrakView.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grdEvrakView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdEvrakView.Appearance.VertLine.Options.UseBackColor = true;
            this.grdEvrakView.GridControl = this.grdEvrak;
            this.grdEvrakView.Name = "grdEvrakView";
            this.grdEvrakView.OptionsCustomization.AllowFilter = false;
            this.grdEvrakView.OptionsCustomization.AllowGroup = false;
            this.grdEvrakView.OptionsFilter.AllowFilterEditor = false;
            this.grdEvrakView.OptionsLayout.Columns.AddNewColumns = false;
            this.grdEvrakView.OptionsMenu.EnableColumnMenu = false;
            this.grdEvrakView.OptionsMenu.EnableFooterMenu = false;
            this.grdEvrakView.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdEvrakView.OptionsNavigation.AutoFocusNewRow = true;
            this.grdEvrakView.OptionsNavigation.EnterMoveNextColumn = true;
            this.grdEvrakView.OptionsView.ColumnAutoWidth = false;
            this.grdEvrakView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdEvrakView.OptionsView.EnableAppearanceOddRow = true;
            this.grdEvrakView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdEvrakView.OptionsView.ShowGroupPanel = false;
            this.grdEvrakView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdEvrakView_FocusedRowChanged);
            this.grdEvrakView.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.grdEvrakView_FocusedColumnChanged);
            // 
            // txtYekun
            // 
            this.txtYekun.EditValue = "";
            this.txtYekun.EnterMoveNextControl = true;
            this.txtYekun.Location = new System.Drawing.Point(508, 363);
            this.txtYekun.Name = "txtYekun";
            this.txtYekun.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtYekun.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtYekun.Properties.DisplayFormat.FormatString = "n2";
            this.txtYekun.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtYekun.Properties.EditFormat.FormatString = "n2";
            this.txtYekun.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtYekun.Properties.Mask.EditMask = "n2";
            this.txtYekun.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtYekun.Properties.ReadOnly = true;
            this.txtYekun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtYekun.Size = new System.Drawing.Size(150, 20);
            this.txtYekun.TabIndex = 97;
            this.txtYekun.TabStop = false;
            // 
            // txtKdv
            // 
            this.txtKdv.EditValue = "";
            this.txtKdv.EnterMoveNextControl = true;
            this.txtKdv.Location = new System.Drawing.Point(508, 337);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtKdv.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKdv.Properties.DisplayFormat.FormatString = "n2";
            this.txtKdv.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKdv.Properties.EditFormat.FormatString = "n2";
            this.txtKdv.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKdv.Properties.Mask.EditMask = "n2";
            this.txtKdv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKdv.Properties.ReadOnly = true;
            this.txtKdv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKdv.Size = new System.Drawing.Size(150, 20);
            this.txtKdv.TabIndex = 96;
            this.txtKdv.TabStop = false;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(440, 365);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(35, 14);
            this.labelControl18.TabIndex = 95;
            this.labelControl18.Text = "Yekün";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(440, 339);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(23, 14);
            this.labelControl17.TabIndex = 94;
            this.labelControl17.Text = "KDV";
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.EditValue = "";
            this.txtAraToplam.EnterMoveNextControl = true;
            this.txtAraToplam.Location = new System.Drawing.Point(508, 311);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtAraToplam.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAraToplam.Properties.DisplayFormat.FormatString = "n2";
            this.txtAraToplam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAraToplam.Properties.EditFormat.FormatString = "n2";
            this.txtAraToplam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAraToplam.Properties.Mask.EditMask = "n2";
            this.txtAraToplam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAraToplam.Properties.ReadOnly = true;
            this.txtAraToplam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAraToplam.Size = new System.Drawing.Size(150, 20);
            this.txtAraToplam.TabIndex = 92;
            this.txtAraToplam.TabStop = false;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(440, 313);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(62, 14);
            this.labelControl13.TabIndex = 93;
            this.labelControl13.Text = "Ara Toplam";
            // 
            // btnSatirSil
            // 
            this.btnSatirSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSatirSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSatirSil.Image")));
            this.btnSatirSil.Location = new System.Drawing.Point(13, 358);
            this.btnSatirSil.Name = "btnSatirSil";
            this.btnSatirSil.Size = new System.Drawing.Size(100, 25);
            this.btnSatirSil.TabIndex = 100;
            this.btnSatirSil.TabStop = false;
            this.btnSatirSil.Text = "SATIR SİL(&Q)";
            this.btnSatirSil.Click += new System.EventHandler(this.btnSatirSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(119, 358);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 25);
            this.btnSil.TabIndex = 99;
            this.btnSil.TabStop = false;
            this.btnSil.Text = "Sİ&L";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(225, 358);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 25);
            this.btnKaydet.TabIndex = 98;
            this.btnKaydet.TabStop = false;
            this.btnKaydet.Text = "&SAKLA";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAdresNo
            // 
            this.btnAdresNo.EditValue = "0";
            this.btnAdresNo.EnterMoveNextControl = true;
            this.btnAdresNo.Location = new System.Drawing.Point(90, 90);
            this.btnAdresNo.Name = "btnAdresNo";
            this.btnAdresNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAdresNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnAdresNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F10))});
            this.btnAdresNo.Properties.Mask.EditMask = "f0";
            this.btnAdresNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.btnAdresNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdresNo.Size = new System.Drawing.Size(102, 20);
            this.btnAdresNo.TabIndex = 4;
            this.btnAdresNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAdresNo_ButtonClick);
            this.btnAdresNo.Validating += new System.ComponentModel.CancelEventHandler(this.btnAdresNo_Validating);
            this.btnAdresNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAdresNo_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 14);
            this.labelControl2.TabIndex = 102;
            this.labelControl2.Text = "Adres No";
            // 
            // frm_Evrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 395);
            this.Controls.Add(this.btnAdresNo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnSatirSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtYekun);
            this.Controls.Add(this.txtKdv);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.txtAraToplam);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.grdEvrak);
            this.Controls.Add(this.btnMusteriKod);
            this.Controls.Add(this.btnMusteriUnvani);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dtETarih);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSira);
            this.Controls.Add(this.labelControl14);
            this.Name = "frm_Evrak";
            this.Text = "frm_Evrak";
            this.Load += new System.EventHandler(this.frm_Evrak_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_Evrak_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.btnSira.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtETarih.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtETarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMusteriKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMusteriUnvani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvrak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvrakView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYekun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAraToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdresNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.ButtonEdit btnSira;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.DateEdit dtETarih;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.ButtonEdit btnMusteriKod;
        public DevExpress.XtraEditors.ButtonEdit btnMusteriUnvani;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl grdEvrak;
        private DevExpress.XtraGrid.Views.Grid.GridView grdEvrakView;
        private DevExpress.XtraEditors.TextEdit txtYekun;
        private DevExpress.XtraEditors.TextEdit txtKdv;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtAraToplam;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton btnSatirSil;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        public DevExpress.XtraEditors.ButtonEdit btnAdresNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}