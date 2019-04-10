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
    public partial class frm_StokFiyatlari : Form
    {
        public frm_StokFiyatlari()
        {
            InitializeComponent();
        }

        StokFiyatlari kayit;
        BStokFiyatlari cls = new BStokFiyatlari();
        BStoklar clsStok = new BStoklar();

        private void frm_StokFiyatlari_Load(object sender, EventArgs e)
        {
            KayitlariGetir();
            Grid_Ayarla();
            Yeni_Kayit();
        }

        
        void KayitlariGetir()
        {            
            List<StokFiyatlari> kayitListe = new List<StokFiyatlari>();
            kayitListe = cls.GetAll();
            grdListe.DataSource = kayitListe;
        }

        private void Grid_Ayarla()
        {
            grdViewListe.Columns["StokFiyatKayitNo"].Visible = false;                        

            grdViewListe.Columns["StokFiyatStokKodu"].Visible = true;
            grdViewListe.Columns["StokFiyatStokKodu"].VisibleIndex = 1;
            grdViewListe.Columns["StokFiyatStokKodu"].Caption = "KODU";
            grdViewListe.Columns["StokFiyatStokKodu"].Width = 100;

            grdViewListe.Columns["StokFiyatNo"].Visible = true;
            grdViewListe.Columns["StokFiyatNo"].VisibleIndex = 1;
            grdViewListe.Columns["StokFiyatNo"].Caption = "NO";
            grdViewListe.Columns["StokFiyatNo"].Width = 150;

            grdViewListe.Columns["StokFiyatFiyati"].Visible = true;
            grdViewListe.Columns["StokFiyatFiyati"].VisibleIndex = 2;
            grdViewListe.Columns["StokFiyatFiyati"].Caption = "FİYATI";
            grdViewListe.Columns["StokFiyatFiyati"].Width = 150;

            grdViewListe.OptionsBehavior.Editable = false;
        }

        private void btn_Yeni_Click(object sender, EventArgs e)
        {
            Yeni_Kayit();
        }

        private void Yeni_Kayit()
        {
            kayit = null;

            btn_StokKodu.Text = "";            
            spn_FiyatNo.Value = 0;
            spn_Fiyat.Value = 0;

            btn_StokKodu.Properties.ReadOnly = false;
            spn_FiyatNo.Properties.ReadOnly = false;
            spn_Fiyat.Properties.ReadOnly = false;
            btn_StokKodu.Focus();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (btn_StokKodu.Text == "")
            {
                MessageBox.Show("Stok Kodu Giriniz !");
                btn_StokKodu.Focus();
                return;
            }

            if (spn_FiyatNo.Value  == 0)
            {
                MessageBox.Show("Fiyat No Giriniz !");
                spn_FiyatNo.Focus();
                return;
            } 

            if (kayit == null)
            {
                StokFiyatlari tKayit = cls.Get(btn_StokKodu.Text, Convert.ToInt32(spn_FiyatNo.Value));
                if (tKayit != null)
                {
                    MessageBox.Show("Girmiş olduğunuz koda ait bir kayıt var.");
                    return;
                }

                kayit = new StokFiyatlari();
                kayit.StokFiyatStokKodu = btn_StokKodu.Text;
                kayit.StokFiyatNo = Convert.ToInt32(spn_FiyatNo.Value);
                kayit.StokFiyatFiyati = Convert.ToDouble(spn_Fiyat.Value);

                cls.Save(kayit);
            }
            else
            {                
                kayit.StokFiyatFiyati = Convert.ToDouble(spn_Fiyat.Value);

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
                kayit= (StokFiyatlari)grdViewListe.GetRow(grdViewListe.FocusedRowHandle);
                if (kayit != null)
                {
                    btn_StokKodu.Text = kayit.StokFiyatStokKodu;                    
                    spn_FiyatNo.Value = Convert.ToInt32(kayit.StokFiyatNo);
                    spn_Fiyat.Value = Convert.ToInt32(kayit.StokFiyatFiyati);
                    btn_StokKodu.Properties.ReadOnly = true;
                    spn_FiyatNo.Properties.ReadOnly = true;
                    spn_Fiyat.SelectAll();
                    spn_Fiyat.Focus();
                }
            }
        }

        private void btn_StokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Stoklar stok = clsStok.aramaPenceresi();
            if (stok != null)
            {
                btn_StokKodu.Text = stok.StokKodu;
                spn_FiyatNo.Value = cls.SonSiraGetir(btn_StokKodu.Text);
            } 
        }

        private void btn_StokKodu_Validating(object sender, CancelEventArgs e)
        {
            Stoklar stok = clsStok.Get(btn_StokKodu.Text);
            if (stok != null)
            {
                btn_StokKodu.Text = stok.StokKodu;

            }
            else
            {
                btn_StokKodu.Text = "";
            }
        }

        private void spn_FiyatNo_Validating(object sender, CancelEventArgs e)
        {
            kayit = cls.Get(btn_StokKodu.Text, Convert.ToInt32(spn_FiyatNo.Value));
            if (kayit != null)
            {
                btn_StokKodu.Text = kayit.StokFiyatStokKodu;
                spn_FiyatNo.Value = Convert.ToInt32(kayit.StokFiyatNo);
                spn_Fiyat.Value = Convert.ToInt32(kayit.StokFiyatFiyati);
                btn_StokKodu.Properties.ReadOnly = true;
                spn_FiyatNo.Properties.ReadOnly = true;
                spn_Fiyat.SelectAll();
                spn_Fiyat.Focus();
            }
        }

        
        
    }
}
