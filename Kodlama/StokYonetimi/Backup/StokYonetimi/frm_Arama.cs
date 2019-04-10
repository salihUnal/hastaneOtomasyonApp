using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace StokYonetimi
{
    public partial class frm_Arama : Form
    {
        public frm_Arama()
        {
            InitializeComponent();
        }

        public int kayitNo;

        private void frmArama_Load(object sender, EventArgs e)
        {
            lblDurum.Text = "Kayıt sayısı : " + grdvListe.RowCount.ToString();

        }

        private void frmArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Escape)))
                this.Close();
        }

        private void grdvListe_DoubleClick(object sender, EventArgs e)
        {
            if (grdvListe.SelectedRowsCount > 0 && grdvListe.FocusedValue != null)
            {
                kayitNo = Convert.ToInt32(grdvListe.GetFocusedRowCellValue(grdvListe.Columns[0]));

                this.DialogResult = DialogResult.OK;
            }
        }

        private void grdvListe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter)) && grdvListe.FocusedValue != null)
            {
                kayitNo = Convert.ToInt32(grdvListe.GetFocusedRowCellValue(grdvListe.Columns[0]));
                this.DialogResult = DialogResult.OK;
            }
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Escape)))
                this.Close();
        }


    }
}
