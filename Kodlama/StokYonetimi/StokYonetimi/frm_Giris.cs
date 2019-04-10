using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokYonetimi
{
    public partial class frm_Giris : Form
    {
        public frm_Giris()
        {
            InitializeComponent();
        }

        private void frm_Giris_Load(object sender, EventArgs e)
        {
            if (!cls_settings.SettingsOku())
            {
                Close();
            }
        }

        private void btn_Stoklar_Click(object sender, EventArgs e)
        {
            frm_Stoklar frm = new frm_Stoklar();
            frm.ShowDialog();
        }

        private void btn_StokFiyatlari_Click(object sender, EventArgs e)
        {
            frm_StokFiyatlari frm = new frm_StokFiyatlari();
            frm.ShowDialog();
        }

        private void btn_Musteriler_Click(object sender, EventArgs e)
        {
            frm_Musteriler frm = new frm_Musteriler();
            frm.ShowDialog();
        }

        private void btn_MusteriAdresleri_Click(object sender, EventArgs e)
        {
            frm_MusteriAdresleri frm = new frm_MusteriAdresleri();
            frm.ShowDialog();
        }

        private void btn_StokGiris_Click(object sender, EventArgs e)
        {
            frm_Evrak frm = new frm_Evrak();
            frm._GirisCikis = 0;
            frm.ShowDialog();
        }

        private void btn_StokCikis_Click(object sender, EventArgs e)
        {
            frm_Evrak frm = new frm_Evrak();
            frm._GirisCikis = 1;
            frm.ShowDialog();
        }
    }
}
