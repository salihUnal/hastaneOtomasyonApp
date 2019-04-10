using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokYonetimi
{
    public class BStoklar
    {     

        public List<Stoklar> GetAll()
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            List<Stoklar> liste = new List<Stoklar>();
            try
            {
                liste = (from t in db.Stoklars select t).ToList<Stoklar>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return liste;
        }

        public Stoklar Get(string kodu)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            Stoklar kayit = db.Stoklars.SingleOrDefault(S => S.StokKodu == kodu);
            return kayit;
        }

        public Stoklar Get(int kayitNo)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            Stoklar kayit = db.Stoklars.SingleOrDefault(S => S.StokKayitNo == kayitNo);
            return kayit;
        }

        public void Save(Stoklar kayit)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                db.Stoklars.InsertOnSubmit(kayit);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Update(Stoklar kayit)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                db.Stoklars.Attach(kayit, true); 
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Delete(Stoklar kayit)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                Stoklar sKayit = db.Stoklars.SingleOrDefault(S => S.StokKodu == kayit.StokKodu);

                if (sKayit != null)
                {
                    db.Stoklars.DeleteOnSubmit(sKayit);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }

        public Stoklar aramaPenceresi()
        {
            frm_Arama arama = new frm_Arama();
            Stoklar sKayit = null;
            SqlDb db = new SqlDb(cls_settings.connectionString);
            arama.grdListe.DataSource = GetAll();
            for (int i = 0; i < arama.grdvListe.Columns.Count; i++)
            {
                arama.grdvListe.Columns[i].Visible = false;
            }

            arama.grdvListe.Columns["StokKodu"].Visible = true;
            arama.grdvListe.Columns["StokAdi"].Visible = true;

            arama.grdvListe.Columns["StokKodu"].Caption = "STOK KODU";
            arama.grdvListe.Columns["StokAdi"].Caption = "STOK ADI";


            arama.Text = "STOK LİSTESİ";
            if (arama.ShowDialog() == DialogResult.OK)
            {
                sKayit = Get(arama.kayitNo);
            }
            return sKayit;
        }
    }
}
