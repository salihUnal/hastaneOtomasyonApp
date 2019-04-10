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
    public partial class frm_Evrak : Form
    {
        public frm_Evrak()
        {
            InitializeComponent();
        }

        BStokGC cls = new BStokGC();
        BMusteriler clsMusteri = new BMusteriler();
        BMusteriAdresleri clsMusteriAdres = new BMusteriAdresleri();
        BStoklar clsStok = new BStoklar();
        BStokFiyatlari clsStokFiyat = new BStokFiyatlari();

        public int _GirisCikis = 0;

        bool siraOnay = false;
        bool tabloOnay = false;
        bool disardan = false;
        bool yeniEvrak = true;

        List<StokGC> EvrakKayit = null;

        private void frm_Evrak_Load(object sender, EventArgs e)
        {
            if (_GirisCikis == 0)
            {
                this.Text = "GİRİŞ EVRAKI";
            }
            else
            {
                this.Text = "ÇIKIŞ EVRAKI";
            }

            KontrolKilit_fl(false);
            dtETarih.DateTime = DateTime.Now.Date;
            GridDoldur(0, _GirisCikis);
            btnSira.Focus();
        }

        void KontrolKilit_fl(bool kilit)
        {
            dtETarih.Enabled = kilit;
            btnMusteriKod.Enabled = kilit;
            btnMusteriUnvani.Enabled = kilit;
            btnAdresNo.Enabled = kilit;
        }

        void GridDoldur(int sira, int evraktip)
        {
            EvrakKayit = new List<StokGC>();
            grdEvrak.DataSource = EvrakKayit;

            grdEvrak.RefreshDataSource();
            StokGC kayit = cls.EvrakSatirGetir(sira, evraktip, 0);
            if (kayit != null)
            {
                tabloOnay = true;
                yeniEvrak = false;
                dtETarih.DateTime = Convert.ToDateTime(kayit.StokGCTarih);
                btnMusteriKod.Text = kayit.StokGCMusteriKodu;
                Musteriler musteri = clsMusteri.Get(kayit.StokGCMusteriKodu);
                if (musteri != null)
                {
                    btnMusteriUnvani.Text = musteri.MusteriUnvani;
                }
                btnAdresNo.Text = kayit.StokGCMusteriAdresNo.ToString();
            }

            EvrakKayit = cls.EvrakGetir(sira, evraktip);
            grdEvrak.DataSource = EvrakKayit;

            for (int i = 0; i < grdEvrakView.Columns.Count; i++)
            {
                grdEvrakView.Columns[i].Visible = false;
            }


            grdEvrakView.Columns["StokGCStokKodu"].Caption = "Stok Kodu";
            grdEvrakView.Columns["StokGCStokKodu"].Visible = true;
            grdEvrakView.Columns["StokGCStokKodu"].Width = 150;
            DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit StokKodColumn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            StokKodColumn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(StokKodColumn_ButtonClick);
            StokKodColumn.Validating += new CancelEventHandler(StokKodColumn_Validating);
            grdEvrakView.Columns["StokGCStokKodu"].ColumnEdit = StokKodColumn;
            grdEvrakView.Columns["StokGCStokKodu"].ColumnEdit.Validating += new CancelEventHandler(StokKodColumn_Validating);

            grdEvrakView.Columns["StokGCStokMiktari"].Caption = "Miktar";
            grdEvrakView.Columns["StokGCStokMiktari"].Visible = true;
            grdEvrakView.Columns["StokGCStokMiktari"].Width = 150;
            DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spnMiktar = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            spnMiktar.NullText = "0";
            spnMiktar.MinValue = 0;
            grdEvrakView.Columns["StokGCStokMiktari"].ColumnEdit = spnMiktar;
            grdEvrakView.Columns["StokGCStokMiktari"].ColumnEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            grdEvrakView.Columns["StokGCStokMiktari"].ColumnEdit.DisplayFormat.FormatString = "n2";


            grdEvrakView.Columns["StokGCStokFiyati"].Caption = "Birim Fiyat";
            grdEvrakView.Columns["StokGCStokFiyati"].Visible = true;
            grdEvrakView.Columns["StokGCStokFiyati"].Width = 150;
            grdEvrakView.Columns["StokGCStokFiyati"].ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            grdEvrakView.Columns["StokGCStokFiyati"].ColumnEdit.NullText = "0";
            grdEvrakView.Columns["StokGCStokFiyati"].ColumnEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            grdEvrakView.Columns["StokGCStokFiyati"].ColumnEdit.DisplayFormat.FormatString = "n2";
            grdEvrakView.Columns["StokGCStokFiyati"].ColumnEdit.ReadOnly = true;
            grdEvrakView.Columns["StokGCStokFiyati"].ColumnEdit = StokKodColumn;

            grdEvrakView.Columns["StokGCStokTutar"].Caption = "Tutar";
            grdEvrakView.Columns["StokGCStokTutar"].Visible = true;
            grdEvrakView.Columns["StokGCStokTutar"].Width = 150;
            grdEvrakView.Columns["StokGCStokTutar"].ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            grdEvrakView.Columns["StokGCStokTutar"].ColumnEdit.NullText = "0";
            grdEvrakView.Columns["StokGCStokTutar"].ColumnEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            grdEvrakView.Columns["StokGCStokTutar"].ColumnEdit.DisplayFormat.FormatString = "n2";
            grdEvrakView.Columns["StokGCStokTutar"].ColumnEdit.ReadOnly = true;


            grdEvrakView.Columns["StokGCStokKodu"].VisibleIndex = 0;
            grdEvrakView.Columns["StokGCStokMiktari"].VisibleIndex = 1;
            grdEvrakView.Columns["StokGCStokFiyati"].VisibleIndex = 2;
            grdEvrakView.Columns["StokGCStokTutar"].VisibleIndex = 3;

            grdEvrak.RefreshDataSource();



            TutarHesapla();
        }

        void StokKodColumn_Validating(object sender, CancelEventArgs e)
        {
            if (grdEvrakView.FocusedColumn.FieldName == "StokGCStokKodu")
            {

                Stoklar stok = clsStok.Get(((DevExpress.XtraEditors.ButtonEdit)(sender)).Text);
                if (stok != null)
                {
                    EvrakKayit[grdEvrakView.FocusedRowHandle].StokGCStokKodu = stok.StokKodu;
                }
                else
                {
                    ((DevExpress.XtraEditors.ButtonEdit)(sender)).Text = "";
                    e.Cancel = true;
                }
            }

        }

        void StokKodColumn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        void StokColumnEdit_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void grdEvrak_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    if (grdEvrakView.FocusedRowHandle == 0 && grdEvrakView.FocusedColumn.FieldName == "StokGCStokKodu")
                    {
                        KontrolKilit_fl(true);
                        btnAdresNo.Focus();
                        grdEvrak.Enabled = false;
                    }
                }
            }

            if (e.KeyCode == Keys.F10)
            {
                if (grdEvrakView.FocusedColumn.FieldName == "StokGCStokKodu")
                {
                    Stoklar stok = clsStok.aramaPenceresi();
                    if (stok != null)
                    {
                        EvrakKayit[grdEvrakView.FocusedRowHandle].StokGCStokKodu = stok.StokKodu;
                        grdEvrak.RefreshDataSource();
                    }
                }
                else if (grdEvrakView.FocusedColumn.FieldName == "StokGCStokFiyati")
                {
                    StokFiyatlari stokF = clsStokFiyat.aramaPenceresi(EvrakKayit[grdEvrakView.FocusedRowHandle].StokGCStokKodu);
                    if (stokF != null)
                    {
                        EvrakKayit[grdEvrakView.FocusedRowHandle].StokGCStokFiyatNo = stokF.StokFiyatNo;
                        EvrakKayit[grdEvrakView.FocusedRowHandle].StokGCStokFiyati = stokF.StokFiyatFiyati;
                        grdEvrak.RefreshDataSource();
                    }
                }
            }
        }

        private void grdEvrakView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == grdEvrakView.RowCount - 2 || grdEvrakView.RowCount <= 1)
            {
                StokGC kayit = new StokGC();
                kayit.StokGCTipi = _GirisCikis;
                kayit.StokGCEvrakNo = Convert.ToInt32(btnSira.Text);
                kayit.StokGCTarih = dtETarih.DateTime.Date;
                kayit.StokGCMusteriKodu = btnMusteriKod.Text;
                kayit.StokGCMusteriAdresNo = Convert.ToInt32(btnAdresNo.Text);
                kayit.StokGCSatirNo = grdEvrakView.RowCount - 1;

                EvrakKayit.Add(kayit);
                grdEvrak.DataSource = EvrakKayit;
                grdEvrak.RefreshDataSource();
            }
        }

        void TutarHesapla()
        {
            if (EvrakKayit != null)
            {
                double araToplam = 0;
                double Kdv = 0;
                double ToplamTutar = 0;

                foreach (var satir in EvrakKayit)
                {
                    araToplam += Convert.ToDouble(satir.StokGCStokTutar);
                    Kdv += Convert.ToDouble(satir.StokGCStokVergi);
                }

                txtAraToplam.Text = string.Format("{0:n2}", araToplam);
                txtKdv.Text = string.Format("{0:n2}", Kdv);
                ToplamTutar = araToplam + Kdv;
                txtYekun.Text = string.Format("{0:n2}", ToplamTutar);

            }
        }

        private void btnSira_Enter(object sender, EventArgs e)
        {
            btnSira.Text = cls.SonSiraGetir(_GirisCikis).ToString();
        }

        private void btnSira_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Convert.ToInt32(btnSira.Text) > 0)
                {
                    KontrolKilit_fl(true);
                    btnSira.Enabled = false;
                    GridDoldur(Convert.ToInt32(btnSira.Text), _GirisCikis);
                    if (tabloOnay)
                    {
                        grdEvrak.Enabled = true;
                        grdEvrak.Focus();
                        KontrolKilit_fl(false);
                    }
                    else
                        dtETarih.Focus();
                }
                else
                {
                    MessageBox.Show("Sıfırdan büyük sayı girmelisiniz...", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMusteriKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Musteriler musteri = clsMusteri.aramaPenceresi();
            if (musteri != null)
            {
                btnMusteriKod.Text = musteri.MusteriKodu;
                btnMusteriUnvani.Text = musteri.MusteriUnvani;
            }
        }

        private void btnMusteriUnvani_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Musteriler musteri = clsMusteri.aramaPenceresi();
            if (musteri != null)
            {
                btnMusteriKod.Text = musteri.MusteriKodu;
                btnMusteriUnvani.Text = musteri.MusteriUnvani;
            }
        }

        private void btnAdresNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MusteriAdresleri musteriA = clsMusteriAdres.aramaPenceresi(btnMusteriKod.Text);
            if (musteriA != null)
            {
                btnAdresNo.Text = musteriA.MusteriAdresNo.ToString();
            }
        }

        private void btnMusteriKod_Validating(object sender, CancelEventArgs e)
        {
            Musteriler musteri = clsMusteri.Get(btnMusteriKod.Text);
            if (musteri != null)
            {
                btnMusteriKod.Text = musteri.MusteriKodu;
                btnMusteriUnvani.Text = musteri.MusteriUnvani;
            }
            else
            {
                btnMusteriKod.Text = "";
                btnMusteriUnvani.Text = "";
            }
        }

        private void btnMusteriUnvani_Validating(object sender, CancelEventArgs e)
        {
            Musteriler musteri = clsMusteri.Get(btnMusteriKod.Text);
            if (musteri != null)
            {
                btnMusteriKod.Text = musteri.MusteriKodu;
                btnMusteriUnvani.Text = musteri.MusteriUnvani;
            }
            else
            {
                btnMusteriKod.Text = "";
                btnMusteriUnvani.Text = "";
            }
        }

        private void btnAdresNo_Validating(object sender, CancelEventArgs e)
        {
            MusteriAdresleri musteriA = clsMusteriAdres.Get(btnMusteriKod.Text, Convert.ToInt32(btnAdresNo.Text));
            if (musteriA != null)
            {
                btnAdresNo.Text = musteriA.MusteriAdresNo.ToString();
            }
            else
            {
                btnAdresNo.Text = "0";
            }
        }

        private void btnAdresNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (btnMusteriKod.Text != "")
                {
                    grdEvrak.Enabled = true;
                    grdEvrak.Focus();
                    KontrolKilit_fl(false);
                    SendKeys.Send("{TAB}");
                    SendKeys.Send("{ENTER}");
                }
                else
                {
                    MessageBox.Show("Müşteri seçilmelidir.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void grdEvrakView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (e.PrevFocusedColumn != null)
            {
                if (e.PrevFocusedColumn.VisibleIndex > 0)
                {
                    MiktarTutarHesapla(grdEvrakView.FocusedRowHandle, e.PrevFocusedColumn.VisibleIndex);
                }
            }
        }

        void MiktarTutarHesapla(int row, int col)
        {
            if (col == 1)
            {
                EvrakKayit[row].StokGCStokTutar = EvrakKayit[row].StokGCStokMiktari * EvrakKayit[row].StokGCStokFiyati;
            }
            else if (col == 2)
            {
                EvrakKayit[row].StokGCStokTutar = EvrakKayit[row].StokGCStokMiktari * EvrakKayit[row].StokGCStokFiyati;
            }
            else if (col == 3)
            {
                if (EvrakKayit[row].StokGCStokMiktari != 0)
                {
                    EvrakKayit[row].StokGCStokFiyati = EvrakKayit[row].StokGCStokTutar / EvrakKayit[row].StokGCStokMiktari;
                }
                else
                {
                    EvrakKayit[row].StokGCStokFiyati = 0;
                }
            }

            Stoklar stok = clsStok.Get(EvrakKayit[row].StokGCStokKodu);
            if (stok != null)
            {
                EvrakKayit[row].StokGCStokVergi = (EvrakKayit[row].StokGCStokTutar * stok.VergiOrani) / 100;
            }

            TutarHesapla();
            grdEvrak.RefreshDataSource();
        }

        private void btnSatirSil_Click(object sender, EventArgs e)
        {
            if (grdEvrakView.FocusedRowHandle >= 0)
            {
                EvrakKayit.Remove((StokGC)grdEvrakView.GetRow(grdEvrakView.FocusedRowHandle));
                grdEvrak.RefreshDataSource();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Evrağı silmek istediğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cls.EvrakSil(Convert.ToInt32(btnSira.Text), _GirisCikis);
                this.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Evrağı kayıt etmek istediğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cls.EvrakKaydetList(Convert.ToInt32(btnSira.Text), _GirisCikis, EvrakKayit);
                this.Close();
            }
        }

        private void btnSira_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            StokGC kayit = cls.aramaPenceresi(_GirisCikis);
            if (kayit != null)
            {
                btnSira.Text = kayit.StokGCEvrakNo.ToString();
            }
        }

        private void frm_Evrak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Escape)))
            {
                if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }


    }
}
