namespace StokYonetimi
{
    partial class frm_Arama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Arama));
            this.grdListe = new DevExpress.XtraGrid.GridControl();
            this.grdvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListe)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdListe
            // 
            this.grdListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListe.Location = new System.Drawing.Point(0, 0);
            this.grdListe.MainView = this.grdvListe;
            this.grdListe.Name = "grdListe";
            this.grdListe.Size = new System.Drawing.Size(384, 340);
            this.grdListe.TabIndex = 0;
            this.grdListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListe});
            // 
            // grdvListe
            // 
            this.grdvListe.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdvListe.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdvListe.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.grdvListe.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grdvListe.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grdvListe.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grdvListe.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdvListe.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdvListe.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grdvListe.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grdvListe.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grdvListe.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdvListe.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.grdvListe.Appearance.Empty.Options.UseBackColor = true;
            this.grdvListe.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdvListe.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdvListe.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdvListe.Appearance.EvenRow.Options.UseBorderColor = true;
            this.grdvListe.Appearance.EvenRow.Options.UseForeColor = true;
            this.grdvListe.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdvListe.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdvListe.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.grdvListe.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grdvListe.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grdvListe.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grdvListe.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdvListe.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.grdvListe.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grdvListe.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grdvListe.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.grdvListe.Appearance.FixedLine.Options.UseBackColor = true;
            this.grdvListe.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grdvListe.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdvListe.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grdvListe.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.grdvListe.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.grdvListe.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdvListe.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdvListe.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.grdvListe.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdvListe.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdvListe.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdvListe.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdvListe.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdvListe.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdvListe.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdvListe.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdvListe.Appearance.GroupButton.Options.UseBackColor = true;
            this.grdvListe.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grdvListe.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdvListe.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdvListe.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdvListe.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grdvListe.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grdvListe.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdvListe.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grdvListe.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdvListe.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdvListe.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdvListe.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.grdvListe.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdvListe.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grdvListe.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdvListe.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.grdvListe.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.grdvListe.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdvListe.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdvListe.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdvListe.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.grdvListe.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.grdvListe.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdvListe.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdvListe.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.grdvListe.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grdvListe.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdvListe.Appearance.HorzLine.Options.UseBackColor = true;
            this.grdvListe.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdvListe.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdvListe.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.OddRow.Options.UseBackColor = true;
            this.grdvListe.Appearance.OddRow.Options.UseBorderColor = true;
            this.grdvListe.Appearance.OddRow.Options.UseForeColor = true;
            this.grdvListe.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.grdvListe.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.grdvListe.Appearance.Preview.Options.UseFont = true;
            this.grdvListe.Appearance.Preview.Options.UseForeColor = true;
            this.grdvListe.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdvListe.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grdvListe.Appearance.Row.Options.UseBackColor = true;
            this.grdvListe.Appearance.Row.Options.UseForeColor = true;
            this.grdvListe.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grdvListe.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.grdvListe.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grdvListe.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.grdvListe.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdvListe.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdvListe.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdvListe.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grdvListe.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grdvListe.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.grdvListe.Appearance.VertLine.Options.UseBackColor = true;
            this.grdvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdvListe.GridControl = this.grdListe;
            this.grdvListe.Name = "grdvListe";
            this.grdvListe.OptionsBehavior.AllowIncrementalSearch = true;
            this.grdvListe.OptionsBehavior.Editable = false;
            this.grdvListe.OptionsCustomization.AllowGroup = false;
            this.grdvListe.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdvListe.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdvListe.OptionsView.EnableAppearanceEvenRow = true;
            this.grdvListe.OptionsView.EnableAppearanceOddRow = true;
            this.grdvListe.OptionsView.ShowAutoFilterRow = true;
            this.grdvListe.OptionsView.ShowFooter = true;
            this.grdvListe.OptionsView.ShowGroupPanel = false;
            this.grdvListe.PaintStyleName = "Office2003";
            this.grdvListe.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.grdvListe.DoubleClick += new System.EventHandler(this.grdvListe_DoubleClick);
            this.grdvListe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdvListe_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDurum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDurum
            // 
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 17);
            // 
            // frm_Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.grdListe);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_Arama";
            this.Text = "F10 Penceresi";
            this.Load += new System.EventHandler(this.frmArama_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmArama_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListe)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraGrid.GridControl grdListe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDurum;
        public DevExpress.XtraGrid.Views.Grid.GridView grdvListe;
    }
}