using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokYonetimi
{
    public class BMusteriler
    {
        public List<Musteriler> GetAll()
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            List<Musteriler> liste = new List<Musteriler>();
            try
            {
                liste = (from t in db.Musterilers select t).ToList<Musteriler>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return liste;
        }

        public Musteriler Get(string kodu)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            Musteriler kayit = db.Musterilers.SingleOrDefault(S => S.MusteriKodu == kodu);
            return kayit;
        }

        public Musteriler Get(int kayitNo)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            Musteriler kayit = db.Musterilers.SingleOrDefault(S => S.MusteriKayitNo == kayitNo);
            return kayit;
        }

        public void Save(Musteriler kayit)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                db.Musterilers.InsertOnSubmit(kayit);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Update(Musteriler kayit)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                db.Musterilers.Attach(kayit, true);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Delete(Musteriler kayit)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                Musteriler sKayit = db.Musterilers.SingleOrDefault(S => S.MusteriKodu == kayit.MusteriKodu);

                if (sKayit != null)
                {
                    db.Musterilers.DeleteOnSubmit(sKayit);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Musteriler aramaPenceresi()
        {
            frm_Arama arama = new frm_Arama();
            Musteriler sKayit = null;
            SqlDb db = new SqlDb(cls_settings.connectionString);
            arama.grdListe.DataSource = GetAll();
            for (int i = 0; i < arama.grdvListe.Columns.Count; i++)
            {
                arama.grdvListe.Columns[i].Visible = false;
            }

            arama.grdvListe.Columns["MusteriKodu"].Visible = true;
            arama.grdvListe.Columns["MusteriUnvani"].Visible = true;

            arama.grdvListe.Columns["MusteriKodu"].Caption = "MÜŞTERİ KODU";
            arama.grdvListe.Columns["MusteriUnvani"].Caption = "MÜŞTERİ ÜNVANI";


            arama.Text = "MÜŞTERİ LİSTESİ";
            if (arama.ShowDialog() == DialogResult.OK)
            {
                sKayit = Get(arama.kayitNo);
            }
            return sKayit;
        }
    }
}
