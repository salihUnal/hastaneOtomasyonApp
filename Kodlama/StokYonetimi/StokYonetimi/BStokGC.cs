using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokYonetimi
{
    public class BStokGC
    {
        public StokGC EvrakSatirGetir(int sira, int evraktip, int satir)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                StokGC kayit = db.StokGCs.SingleOrDefault(S => S.StokGCEvrakNo == sira && S.StokGCTipi == evraktip && S.StokGCSatirNo == satir);
                return kayit;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public StokGC EvrakSatirGetir(int kayitNo)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                StokGC kayit = db.StokGCs.SingleOrDefault(S => S.StokGCKayitNo == kayitNo );
                return kayit;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<StokGC> EvrakGetir(int sira, int evraktip)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                List<StokGC> kayit = (from tbl in db.StokGCs
                                      where tbl.StokGCEvrakNo == sira && tbl.StokGCTipi == evraktip
                                      orderby tbl.StokGCSatirNo ascending
                                      select tbl).ToList<StokGC>();
                return kayit;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public int SonSiraGetir(int evraktip)
        {
            int sira = 1;
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                var kayit = (from tbl in db.StokGCs
                             where tbl.StokGCTipi == evraktip
                             orderby tbl.StokGCEvrakNo descending
                             select tbl).Take(1);
                foreach (StokGC kay in kayit)
                {
                    sira = Convert.ToInt32(kay.StokGCEvrakNo) + 1;
                }

                return sira;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return sira;
            }
 
        }

        public void EvrakSil(int sira, int evraktip)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                var kayit = (from tbl in db.StokGCs
                             where tbl.StokGCTipi == evraktip && tbl.StokGCEvrakNo == sira
                             select tbl);
                db.StokGCs.DeleteAllOnSubmit(kayit);
                db.SubmitChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        public void SatirSil(int kayitNo)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                var kayit = (from tbl in db.StokGCs
                             where tbl.StokGCKayitNo == kayitNo
                             select tbl);
                db.StokGCs.DeleteAllOnSubmit(kayit);
                db.SubmitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EvrakKaydetList(int sira, int evraktip,List<StokGC> Gelenkayitlar)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);
                List<StokGC> orjKayitlar = EvrakGetir(sira, evraktip);

                foreach (StokGC kayitOrjSil in orjKayitlar)
                {
                    bool sil = true;
                    int RecNo = 0;
                    foreach (StokGC kayitGlnSil in Gelenkayitlar)
                    {
                        if (kayitOrjSil.StokGCKayitNo == kayitGlnSil.StokGCKayitNo)
                        {
                            sil = false;
                        }
                        if (sil)
                        {
                            RecNo = kayitOrjSil.StokGCKayitNo;
                        }
                    }
                    if (sil)
                    {
                        SatirSil(RecNo);
                    }
                }

                int satirNo = 0;
                foreach (StokGC kayitGlnKayit in Gelenkayitlar)
                {
                    if (kayitGlnKayit.StokGCStokKodu != "" && kayitGlnKayit.StokGCStokKodu != null)
                    {
                        kayitGlnKayit.StokGCSatirNo = satirNo;
                        EvrakKaydet(kayitGlnKayit);
                        satirNo += 1;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EvrakKaydet(StokGC Gelenkayit)
        {
            try
            {
                SqlDb db = new SqlDb(cls_settings.connectionString);

                if (Gelenkayit.StokGCKayitNo > 0)
                {
                    db.StokGCs.Attach(Gelenkayit, true);
                }
                else
                {
                    db.StokGCs.InsertOnSubmit(Gelenkayit);
                }
                db.SubmitChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<StokGC> GetAll(int evraktip)
        {
            SqlDb db = new SqlDb(cls_settings.connectionString);
            List<StokGC> liste = new List<StokGC>();
            try
            {
                liste = (from t in db.StokGCs where t.StokGCSatirNo == 0 && t.StokGCTipi == evraktip select t).ToList<StokGC>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return liste;
        }

        public StokGC aramaPenceresi(int evraktip)
        {
            frm_Arama arama = new frm_Arama();
            StokGC sKayit = null;
            SqlDb db = new SqlDb(cls_settings.connectionString);
            arama.grdListe.DataSource = GetAll(evraktip);
            for (int i = 0; i < arama.grdvListe.Columns.Count; i++)
            {
                arama.grdvListe.Columns[i].Visible = false;
            }

            arama.grdvListe.Columns["StokGCTarih"].Visible = true;
            arama.grdvListe.Columns["StokGCEvrakNo"].Visible = true;
            arama.grdvListe.Columns["StokGCMusteriKodu"].Visible = true;

            arama.grdvListe.Columns["StokGCTarih"].Caption = "TARİH";
            arama.grdvListe.Columns["StokGCEvrakNo"].Caption = "EVRAK NO";
            arama.grdvListe.Columns["StokGCMusteriKodu"].Caption = "MÜŞTERİ KODU";

            arama.Text = "EVRAK LİSTESİ";
            if (arama.ShowDialog() == DialogResult.OK)
            {
                sKayit = EvrakSatirGetir(arama.kayitNo);
            }
            return sKayit;
        }
    }
}
