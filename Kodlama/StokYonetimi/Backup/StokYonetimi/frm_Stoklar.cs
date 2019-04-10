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
    public partial class frm_Stoklar : Form
    {
        public frm_Stoklar()
        {
            InitializeComponent();
        }

        Stoklar kayit;
        BStoklar cls = new BStoklar();

        private void frm_Stoklar_Load(object sender, EventArgs e)
        {
            KayitlariGetir();
            Grid_Ayarla();
            Yeni_Kayit();
        }

        void KayitlariGetir()
        {            
            List<Stoklar> kayitListe = new List<Stoklar>();
            kayitListe = cls.GetAll();
            grdListe.DataSource = kayitListe;
        }

        private void Grid_Ayarla()
        {
            grdViewListe.Columns["StokKayitNo"].Visible = false;

            grdViewListe.Columns["StokKodu"].Visible = true;
            grdViewListe.Columns["StokKodu"].VisibleIndex = 1;
            grdViewListe.Columns["StokKodu"].Caption = "KODU";
            grdViewListe.Columns["StokKodu"].Width = 100;

            grdViewListe.Columns["StokAdi"].Visible = true;
            grdViewListe.Columns["StokAdi"].VisibleIndex = 1;
            grdViewListe.Columns["StokAdi"].Caption = "ADI";
            grdViewListe.Columns["StokAdi"].Width = 150;

            grdViewListe.Columns["VergiOrani"].Visible = true;
            grdViewListe.Columns["VergiOrani"].VisibleIndex = 2;
            grdViewListe.Columns["VergiOrani"].Caption = "VERGİ";
            grdViewListe.Columns["VergiOrani"].Width = 150;

            grdViewListe.OptionsBehavior.Editable = false;
        }

        private void btn_Yeni_Click(object sender, EventArgs e)
        {
            Yeni_Kayit();
        }

        private void Yeni_Kayit()
        {
            kayit = null;

            txt_StokKodu.Text = "";
            txt_StokAdi.Text = "";
            spn_VergiOrani.Value = 0;

            txt_StokKodu.Properties.ReadOnly = false;
            txt_StokAdi.Properties.ReadOnly = false;
            spn_VergiOrani.Properties.ReadOnly = false;
            txt_StokKodu.Focus();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_StokKodu.Text == "")
            {
                MessageBox.Show("Stok Kodu Giriniz !");
                txt_StokKodu.Focus();
                return;
            }

            

            if (kayit == null)
            {
                Stoklar tKayit = cls.Get(txt_StokKodu.Text);
                if (tKayit != null)
                {
                    MessageBox.Show("Girmiş olduğunuz koda ait bir kayıt var.");
                    return;
                }

                kayit = new Stoklar();
                kayit.StokKodu = txt_StokKodu.Text;
                kayit.StokAdi = txt_StokAdi.Text;
                kayit.VergiOrani = Convert.ToDouble(spn_VergiOrani.Value);

                cls.Save(kayit);
            }
            else
            {
                kayit.StokAdi = txt_StokAdi.Text;
                kayit.VergiOrani = Convert.ToDouble(spn_VergiOrani.Value);

                cls.Update(kayit);
            }

            KayitlariGetir();
            Yeni_Kayit();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (kayit == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz.");
                return;
            }

            DialogResult dr = MessageBox.Show("Seçili kayıt silinsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                cls.Delete(kayit);
                KayitlariGetir();
                Yeni_Kayit();
            }
        }

        private void grdViewListe_Click(object sender, EventArgs e)
        {
            SeciliKayitDetay_Getir();
        }

        private void grdViewListe_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SeciliKayitDetay_Getir();
        }

        private void SeciliKayitDetay_Getir()
        {
            if (grdViewListe.FocusedRowHandle > -1)
            {
                kayit= (Stoklar)grdViewListe.GetRow(grdViewListe.FocusedRowHandle);
                if (kayit != null)
                {
                    txt_StokKodu.Text = kayit.StokKodu;
                    txt_StokAdi.Text = kayit.StokAdi;
                    spn_VergiOrani.Value = Convert.ToInt32(kayit.VergiOrani);
                    txt_StokKodu.Properties.ReadOnly = true;
                    spn_VergiOrani.SelectAll();
                    spn_VergiOrani.Focus();
                }
            }
        }
        
    }
}
