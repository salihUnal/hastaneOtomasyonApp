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
    public partial class frm_Musteriler : Form
    {
        public frm_Musteriler()
        {
            InitializeComponent();
        }

        Musteriler kayit;
        BMusteriler cls = new BMusteriler();

        private void frm_Musteriler_Load(object sender, EventArgs e)
        {
            KayitlariGetir();
            Grid_Ayarla();
            Yeni_Kayit();
        }

        void KayitlariGetir()
        {
            List<Musteriler> kayitListe = new List<Musteriler>();
            kayitListe = cls.GetAll();
            grdListe.DataSource = kayitListe;
        }

        private void Grid_Ayarla()
        {
            grdViewListe.Columns["MusteriKayitNo"].Visible = false;
            grdViewListe.Columns["MusteriVergiDairesi"].Visible = false;
            grdViewListe.Columns["MusteriVergiNo"].Visible = false;

            grdViewListe.Columns["MusteriKodu"].Visible = true;
            grdViewListe.Columns["MusteriKodu"].VisibleIndex = 1;
            grdViewListe.Columns["MusteriKodu"].Caption = "KODU";
            grdViewListe.Columns["MusteriKodu"].Width = 100;

            grdViewListe.Columns["MusteriUnvani"].Visible = true;
            grdViewListe.Columns["MusteriUnvani"].VisibleIndex = 1;
            grdViewListe.Columns["MusteriUnvani"].Caption = "ADI";
            grdViewListe.Columns["MusteriUnvani"].Width = 150;

            grdViewListe.Columns["MusteriYetkilisi"].Visible = true;
            grdViewListe.Columns["MusteriYetkilisi"].VisibleIndex = 2;
            grdViewListe.Columns["MusteriYetkilisi"].Caption = "YETKİLİSİ";
            grdViewListe.Columns["MusteriYetkilisi"].Width = 150;

            grdViewListe.OptionsBehavior.Editable = false;
        }

        private void btn_Yeni_Click(object sender, EventArgs e)
        {
            Yeni_Kayit();
        }

        private void Yeni_Kayit()
        {
            kayit = null;

            txt_MusteriKodu.Text = "";
            txt_MusteriAdi.Text = "";
            txt_MusteriYetkilisi.Text = "";
            txt_VergiD.Text = "";
            txt_VergiN.Text  = "";

            txt_MusteriKodu.Properties.ReadOnly = false;
            txt_MusteriAdi.Properties.ReadOnly = false;
            txt_MusteriYetkilisi.Properties.ReadOnly = false;
            txt_VergiD.Properties.ReadOnly = false;
            txt_VergiN.Properties.ReadOnly = false;
            txt_MusteriKodu.Focus();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_MusteriKodu.Text == "")
            {
                MessageBox.Show("Müşteri Kodu Giriniz !");
                txt_MusteriKodu.Focus();
                return;
            }

            

            if (kayit == null)
            {
                Musteriler tKayit = cls.Get(txt_MusteriKodu.Text);
                if (tKayit != null)
                {
                    MessageBox.Show("Girmiş olduğunuz koda ait bir kayıt var.");
                    return;
                }

                kayit = new Musteriler();
                kayit.MusteriKodu  = txt_MusteriKodu.Text;
                kayit.MusteriUnvani = txt_MusteriAdi.Text;
                kayit.MusteriYetkilisi = txt_MusteriYetkilisi.Text;
                kayit.MusteriVergiDairesi = txt_VergiD.Text;
                kayit.MusteriVergiNo = txt_VergiN.Text;

                cls.Save(kayit);
            }
            else
            {
                kayit.MusteriUnvani = txt_MusteriAdi.Text;
                kayit.MusteriYetkilisi = txt_MusteriYetkilisi.Text;
                kayit.MusteriVergiDairesi = txt_VergiD.Text;
                kayit.MusteriVergiNo = txt_VergiN.Text;

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
                kayit= (Musteriler)grdViewListe.GetRow(grdViewListe.FocusedRowHandle);
                if (kayit != null)
                {
                    txt_MusteriKodu.Text = kayit.MusteriKodu;
                    txt_MusteriAdi.Text = kayit.MusteriUnvani;
                    txt_MusteriYetkilisi.Text = kayit.MusteriYetkilisi;
                    txt_VergiD.Text = kayit.MusteriVergiDairesi;
                    txt_VergiN.Text = kayit.MusteriVergiNo;

                    txt_MusteriKodu.Properties.ReadOnly = true;
                    txt_MusteriAdi.SelectAll();
                    txt_MusteriAdi.Focus();
                }
            }
        }

        
        
    }
}
