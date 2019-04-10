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
    public partial class frm_MusteriAdresleri : Form
    {
        public frm_MusteriAdresleri()
        {
            InitializeComponent();
        }

        MusteriAdresleri kayit;
        BMusteriAdresleri cls = new BMusteriAdresleri();
        BMusteriler clsMusteri = new BMusteriler();

        private void frm_Musteriler_Load(object sender, EventArgs e)
        {
            KayitlariGetir();
            Grid_Ayarla();
            Yeni_Kayit();
        }

        void KayitlariGetir()
        {
            List<MusteriAdresleri> kayitListe = new List<MusteriAdresleri>();
            kayitListe = cls.GetAll();
            grdListe.DataSource = kayitListe;
        }

        private void Grid_Ayarla()
        {
            grdViewListe.Columns["MusteriAdresKayitNo"].Visible = false;
            grdViewListe.Columns["MusteriAdresCadde"].Visible = false;
            grdViewListe.Columns["MusteriAdresSokak"].Visible = false;
            grdViewListe.Columns["MusteriAdresTelefon"].Visible = false;

            grdViewListe.Columns["MusteriAdresMusteriKodu"].Visible = true;
            grdViewListe.Columns["MusteriAdresMusteriKodu"].VisibleIndex = 1;
            grdViewListe.Columns["MusteriAdresMusteriKodu"].Caption = "KODU";
            grdViewListe.Columns["MusteriAdresMusteriKodu"].Width = 100;

            grdViewListe.Columns["MusteriAdresNo"].Visible = true;
            grdViewListe.Columns["MusteriAdresNo"].VisibleIndex = 1;
            grdViewListe.Columns["MusteriAdresNo"].Caption = "NO";
            grdViewListe.Columns["MusteriAdresNo"].Width = 150;

            grdViewListe.Columns["MusteriAdresIlce"].Visible = true;
            grdViewListe.Columns["MusteriAdresIlce"].VisibleIndex = 2;
            grdViewListe.Columns["MusteriAdresIlce"].Caption = "İLÇE";
            grdViewListe.Columns["MusteriAdresIlce"].Width = 150;

            grdViewListe.Columns["MusteriAdresIl"].Visible = true;
            grdViewListe.Columns["MusteriAdresIl"].VisibleIndex = 3;
            grdViewListe.Columns["MusteriAdresIl"].Caption = "İL";
            grdViewListe.Columns["MusteriAdresIl"].Width = 150;

            grdViewListe.OptionsBehavior.Editable = false;
        }

        private void btn_Yeni_Click(object sender, EventArgs e)
        {
            Yeni_Kayit();
        }

        private void Yeni_Kayit()
        {
            kayit = null;

            btn_MusteriKodu.Text = "";
            spn_AdresNo.Value = 0;
            txt_Cadde.Text = "";
            txt_Sokak.Text = "";
            txt_Ilce.Text = "";
            txt_Il.Text  = "";
            txt_Telefon.Text = "";

            btn_MusteriKodu.Properties.ReadOnly = false;
            spn_AdresNo.Properties.ReadOnly = false;
            txt_Cadde.Properties.ReadOnly = false;
            txt_Sokak.Properties.ReadOnly = false;
            txt_Ilce.Properties.ReadOnly = false;
            txt_Il.Properties.ReadOnly = false;
            txt_Telefon.Properties.ReadOnly = false;
            btn_MusteriKodu.Focus();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (btn_MusteriKodu.Text == "")
            {
                MessageBox.Show("Müşteri Kodu Giriniz !");
                btn_MusteriKodu.Focus();
                return;
            }

            if (spn_AdresNo.Value == 0)
            {
                MessageBox.Show("Adres No Giriniz !");
                spn_AdresNo.Focus();
                return;
            } 

            if (kayit == null)
            {
                MusteriAdresleri tKayit = cls.Get(btn_MusteriKodu.Text, Convert.ToInt32(spn_AdresNo.Value));
                if (tKayit != null)
                {
                    MessageBox.Show("Girmiş olduğunuz koda ait bir kayıt var.");
                    return;
                }

                kayit = new MusteriAdresleri();
                kayit.MusteriAdresMusteriKodu  = btn_MusteriKodu.Text;
                kayit.MusteriAdresNo = Convert.ToInt32(spn_AdresNo.Value);
                kayit.MusteriAdresCadde = txt_Cadde.Text;
                kayit.MusteriAdresSokak  = txt_Sokak.Text;
                kayit.MusteriAdresIlce  = txt_Ilce.Text;
                kayit.MusteriAdresIl  = txt_Il.Text;
                kayit.MusteriAdresTelefon = txt_Telefon.Text;

                cls.Save(kayit);
            }
            else
            {
                kayit.MusteriAdresCadde = txt_Cadde.Text;
                kayit.MusteriAdresSokak = txt_Sokak.Text;
                kayit.MusteriAdresIlce = txt_Ilce.Text;
                kayit.MusteriAdresIl = txt_Il.Text;
                kayit.MusteriAdresTelefon = txt_Telefon.Text;

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
                kayit = (MusteriAdresleri)grdViewListe.GetRow(grdViewListe.FocusedRowHandle);
                if (kayit != null)
                {
                    btn_MusteriKodu.Text = kayit.MusteriAdresMusteriKodu ;
                    spn_AdresNo.Value = Convert.ToInt32(kayit.MusteriAdresNo);
                    txt_Cadde.Text = kayit.MusteriAdresCadde ;
                    txt_Sokak.Text = kayit.MusteriAdresSokak ;
                    txt_Ilce.Text = kayit.MusteriAdresIlce ;
                    txt_Il.Text = kayit.MusteriAdresIl ;
                    txt_Telefon.Text = kayit.MusteriAdresTelefon ;

                    btn_MusteriKodu.Properties.ReadOnly = true;
                    spn_AdresNo.Properties.ReadOnly = true;
                    txt_Cadde.SelectAll();
                    txt_Cadde.Focus();
                }
            }
        }

        private void btn_MusteriKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Musteriler musteri = clsMusteri.aramaPenceresi();
            if (musteri != null)
            {
                btn_MusteriKodu.Text = musteri.MusteriKodu;
                spn_AdresNo.Value = cls.SonSiraGetir(btn_MusteriKodu.Text);
            }            
        }

        private void btn_MusteriKodu_Validating(object sender, CancelEventArgs e)
        {
            Musteriler musteri = clsMusteri.Get(btn_MusteriKodu.Text);
            if (musteri != null)
            {
                btn_MusteriKodu.Text = musteri.MusteriKodu;

            }
            else
            {
                btn_MusteriKodu.Text = "";
            }
        }

        private void spn_AdresNo_Validating(object sender, CancelEventArgs e)
        {
            kayit = cls.Get(btn_MusteriKodu.Text, Convert.ToInt32(spn_AdresNo.Value));
            if (kayit != null)
            {
                btn_MusteriKodu.Text = kayit.MusteriAdresMusteriKodu;
                spn_AdresNo.Value = Convert.ToInt32(kayit.MusteriAdresNo);
                txt_Cadde.Text = kayit.MusteriAdresCadde;
                txt_Sokak.Text = kayit.MusteriAdresSokak;
                txt_Ilce.Text = kayit.MusteriAdresIlce;
                txt_Il.Text = kayit.MusteriAdresIl;
                txt_Telefon.Text = kayit.MusteriAdresTelefon;

                btn_MusteriKodu.Properties.ReadOnly = true;
                spn_AdresNo.Properties.ReadOnly = true;
                txt_Cadde.SelectAll();
                txt_Cadde.Focus();
            }

        }        
        
    }
}
