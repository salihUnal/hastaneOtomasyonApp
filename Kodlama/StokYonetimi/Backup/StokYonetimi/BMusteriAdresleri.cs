using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokYonetimi
{
    public class BMusteriAdresleri
    {
        public List<MusteriAdresleri> GetAll()
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            List<MusteriAdresleri> liste = new List<MusteriAdresleri>();
            try
            {
                liste = (from t in db.MusteriAdresleris select t).ToList<MusteriAdresleri>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return liste;
        }

        public List<MusteriAdresleri> GetAll(string musteri)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            List<MusteriAdresleri> liste = new List<MusteriAdresleri>();
            try
            {
                liste = (from t in db.MusteriAdresleris where t.MusteriAdresMusteriKodu == musteri select t).ToList<MusteriAdresleri>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return liste;
        }

        public MusteriAdresleri Get(string kodu, int no)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            MusteriAdresleri kayit = db.MusteriAdresleris.SingleOrDefault(S => S.MusteriAdresMusteriKodu == kodu && S.MusteriAdresNo == no);
            return kayit;
        }

        public MusteriAdresleri Get(int kayitNo)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            MusteriAdresleri kayit = db.MusteriAdresleris.SingleOrDefault(S => S.MusteriAdresKayitNo == kayitNo);
            return kayit;
        }

        public void Save(MusteriAdresleri kayit)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            try
            {
                db.MusteriAdresleris.InsertOnSubmit(kayit);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Update(MusteriAdresleri kayit)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            try
            {
                db.MusteriAdresleris.Attach(kayit, true);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Delete(MusteriAdresleri kayit)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            try
            {
                MusteriAdresleri sKayit = db.MusteriAdresleris.SingleOrDefault(S => S.MusteriAdresMusteriKodu == kayit.MusteriAdresMusteriKodu && S.MusteriAdresNo == kayit.MusteriAdresNo);

                if (sKayit != null)
                {
                    db.MusteriAdresleris.DeleteOnSubmit(sKayit);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public MusteriAdresleri aramaPenceresi(string musteri)
        {
            frm_Arama arama = new frm_Arama();
            MusteriAdresleri sKayit = null;
            SqlDb db = new SqlDb(cls_settings.connectionString);
            arama.grdListe.DataSource = GetAll(musteri);
            for (int i = 0; i < arama.grdvListe.Columns.Count; i++)
            {
                arama.grdvListe.Columns[i].Visible = false;
            }

            arama.grdvListe.Columns["MusteriAdresMusteriKodu"].Visible = true;
            arama.grdvListe.Columns["MusteriAdresCadde"].Visible = true;

            arama.grdvListe.Columns["MusteriAdresMusteriKodu"].Caption = "MÜŞTERİ KODU";
            arama.grdvListe.Columns["MusteriAdresCadde"].Caption = "CADDE";

            arama.Text = "MÜŞTERİ ADRES LİSTESİ";
            if (arama.ShowDialog() == DialogResult.OK)
            {
                sKayit = Get(arama.kayitNo);
            }
            return sKayit;
        }

        public int SonSiraGetir(string musteri)
        {
            int sira = 1;
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                var kayit = (from tbl in db.MusteriAdresleris
                             where tbl.MusteriAdresMusteriKodu == musteri
                             orderby tbl.MusteriAdresNo descending
                             select tbl).Take(1);
                foreach (MusteriAdresleri kay in kayit)
                {
                    sira = Convert.ToInt32(kay.MusteriAdresNo) + 1;
                }

                return sira;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return sira;
            }

        }
    }
}
