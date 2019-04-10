using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokYonetimi
{
    public class BStokFiyatlari
    {
        public List<StokFiyatlari> GetAll()
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            List<StokFiyatlari> liste = new List<StokFiyatlari>();
            try
            {
                liste = (from t in db.StokFiyatlaris select t).ToList<StokFiyatlari>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return liste;
        }

        public List<StokFiyatlari> GetAll(string stok)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            List<StokFiyatlari> liste = new List<StokFiyatlari>();
            try
            {
                liste = (from t in db.StokFiyatlaris where t.StokFiyatStokKodu == stok select t).ToList<StokFiyatlari>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return liste;
        }

        public StokFiyatlari Get(string kodu, int no)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            StokFiyatlari kayit = db.StokFiyatlaris.SingleOrDefault(S => S.StokFiyatStokKodu == kodu && S.StokFiyatNo == no);
            return kayit;
        }

        public StokFiyatlari Get(int kayitNo)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            StokFiyatlari kayit = db.StokFiyatlaris.SingleOrDefault(S => S.StokFiyatKayitNo == kayitNo);
            return kayit;
        }

        public void Save(StokFiyatlari kayit)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            try
            {
                db.StokFiyatlaris.InsertOnSubmit(kayit);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Update(StokFiyatlari kayit)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            try
            {
                db.StokFiyatlaris.Attach(kayit, true);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Delete(StokFiyatlari kayit)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            try
            {
                StokFiyatlari sKayit = db.StokFiyatlaris.SingleOrDefault(S => S.StokFiyatStokKodu == kayit.StokFiyatStokKodu && S.StokFiyatNo == kayit.StokFiyatNo);

                if (sKayit != null)
                {
                    db.StokFiyatlaris.DeleteOnSubmit(sKayit);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public StokFiyatlari aramaPenceresi(string stok)
        {
            frm_Arama arama = new frm_Arama();
            StokFiyatlari sKayit = null;
            SqlDb db = new SqlDb(cls_settings.connectionString);
            arama.grdListe.DataSource = GetAll(stok);
            for (int i = 0; i < arama.grdvListe.Columns.Count; i++)
            {
                arama.grdvListe.Columns[i].Visible = false;
            }

            arama.grdvListe.Columns["StokFiyatStokKodu"].Visible = true;
            arama.grdvListe.Columns["StokFiyatFiyati"].Visible = true;

            arama.grdvListe.Columns["StokFiyatStokKodu"].Caption = "STOK KODU";
            arama.grdvListe.Columns["StokFiyatFiyati"].Caption = "FİYATI";


            arama.Text = "STOK FİYAT LİSTESİ";
            if (arama.ShowDialog() == DialogResult.OK)
            {
                sKayit = Get(arama.kayitNo);
            }
            return sKayit;
        }

        public int SonSiraGetir(string stok)
        {
            int sira = 1;
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                var kayit = (from tbl in db.StokFiyatlaris
                             where tbl.StokFiyatStokKodu == stok
                             orderby tbl.StokFiyatNo descending
                             select tbl).Take(1);
                foreach (StokFiyatlari kay in kayit)
                {
                    sira = Convert.ToInt32(kay.StokFiyatNo) + 1;
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
