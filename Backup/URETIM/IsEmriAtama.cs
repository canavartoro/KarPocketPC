using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class IsEmriAtama : Form
    {
        private AdamIstasyon SecilenIstasyon;
        private SPersonel SecilenPersonel;

        private bool _personelata = false;
        public bool PersonelAta
        {
            get { return _personelata; }
            set { _personelata = value; }
        }

        public IsEmriAtama()
        {
            InitializeComponent();
        }

        private void IsEmri()
        {
            try
            {
                string isx = Utility.Engine.SqlTemizle(textIsEmri.Text).ToUpper();
                string sx = string.Format("SELECT * FROM dbo.AdamIsEmri WITH (NOLOCK) WHERE ( IstasyonKodu = N'{0}' ) AND ( IsEmri = N'{1}' )", labelIstasyonKod.Text, textIsEmri.Text);
                DataTable dtx = new DataTable();
                if (Utility.Engine.dat.TableDoldur(sx, ref dtx) && dtx != null && dtx.Rows.Count > 0)
                {
                    textIsEmri.Text = dtx.Rows[0][0].ToString();
                    labelStokKodu.Text = dtx.Rows[0][1].ToString();
                    labelStokAdi.Text = dtx.Rows[0][2].ToString();
                    labelIsMiktar.Text = dtx.Rows[0][3].ToString();
                    labelOperasyonKodu.Text = dtx.Rows[0][4].ToString();
                    labelOperasyonAdi.Text = dtx.Rows[0][5].ToString();
                    labelBirimAgirlik.Text = dtx.Rows[0][7].ToString();
                    labelMinAgirlik.Text = dtx.Rows[0][8].ToString();
                    labelMaxAgirlik.Text = dtx.Rows[0][9].ToString();

                    comboBirim.DataSource = null;
                    comboBirim.Text = "";

                    Utility.Engine.sql = string.Format("SELECT Birim, Miktar2, CASE WHEN SiraNo = 2 THEN 0 ELSE 1 END AS XX FROM dbo.stok_tanim_detay WITH (NOLOCK) WHERE Birim <> '' AND StokKodu = N'{0}' GROUP BY Birim, Miktar2,SiraNo ORDER BY XX, Birim",
                        labelStokKodu.Text);
                    DataTable dtbirim = new DataTable();
                    if (Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dtbirim) && dtbirim != null && dtbirim.Rows.Count > 0)
                    {
                        comboBirim.DataSource = dtbirim;
                        comboBirim.DisplayMember = "Birim";
                        comboBirim.ValueMember = "Miktar2";
                        comboBirim.SelectedIndex = 0;
                    }

                    buttonIsAta.Enabled = true;
                }
                else
                {
                    buttonIsAta.Enabled = false;
                    Utility.Hata(string.Format("{0} İş emri bilgisi bulunamadı!", isx));
                    textIsEmri.Focus();
                    return;
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void SPersonel()
        {
            try
            {
                string val = string.Empty, val2 = string.Empty;

                if (!string.IsNullOrEmpty(textPSicil.Text))
                    val = string.Format(" AND KOD LIKE N'{0}%'", Utility.Engine.SqlTemizle(textPSicil.Text));

                if (!string.IsNullOrEmpty(textPAdi.Text))
                    val2 = string.Format(" AND AD LIKE N'{0}%'", Utility.Engine.SqlTemizle(textPAdi.Text));

                textPSicil.Text = textPAdi.Text = string.Empty;

                string x = string.Format("SELECT * FROM dbo.SPERSONEL WITH (NOLOCK) WHERE ( 1 = 1 ) {0} {1} ORDER BY AD, SOYAD", val, val2);
                DataTable dtx = new DataTable();
                if (Utility.Engine.dat.TableDoldur(x, ref dtx) && dtx != null && dtx.Rows.Count > 0)
                {
                    dtx.TableName = "SPERSONEL";
                    dataGrid2.DataSource = dtx;

                    if (dtx != null && dtx.Rows.Count == 1)
                    {
                        dataGrid2.Focus();
                        dataGrid2.Select(0);
                        button8_Click(null, null);
                        button10_Click(null, null);
                    }
                }
                else
                {
                    Utility.Hata(string.Format("Personel bilgisi bulunamadı!"));
                    return;
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void Personeller()
        {
            try
            {
                if (SecilenIstasyon == false)
                    return;                
                
                DataTable dtx = new DataTable();
                string x = string.Format(@"SELECT P.KOD, P.AD + N' ' + P.SOYAD AS ISIM FROM dbo.isemri_operasyon O WITH (NOLOCK) INNER JOIN dbo.isemri_iscilik I WITH (NOLOCK)
ON O.ID = I.UKayitNo AND O.IstasyonKodu = N'{0}' INNER JOIN dbo.SPERSONEL P WITH (NOLOCK) ON I.PersonelKodu = P.KOD
WHERE O.BitTarih IS NULL ORDER BY ISIM", SecilenIstasyon.IstasyonKodu);
                Utility.Engine.dat.ListDoldur(ref listView1, x);
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void IsEmriAtama_Load(object sender, EventArgs e)
        {
            panelIstasyon.Location = new Point(0, 0);
            panelIstasyon.BringToFront();
            panelIstasyon.Visible = true;
            DataTable dtbirim = new DataTable();
            if (Utility.Engine.dat.TableDoldur("SELECT Birim, Miktar2 FROM dbo.stok_tanim_detay WITH (NOLOCK) WHERE Birim <> '' GROUP BY Birim, Miktar2 ORDER BY Birim", ref dtbirim) && dtbirim != null && dtbirim.Rows.Count > 0)
            {
                comboBirim.DataSource = dtbirim;
                comboBirim.DisplayMember = "Birim";
                comboBirim.ValueMember = "Miktar2";
                labelBirim.Text = "";
                comboBirim.SelectedIndex = 0;
            }
            Istasyonlar();            
            SPersonel();
            textTKod.Focus();
            return;
        }

        private void Istasyonlar()
        {
            string val = string.Empty;

            if (!string.IsNullOrEmpty(textTKod.Text))
                val = string.Format(" AND IstasyonKodu LIKE N'{0}%' ", Utility.Engine.SqlTemizle(textTKod.Text));

            textTKod.Text = string.Empty;

            string x = string.Format("SELECT * FROM dbo.AdamIstasyon WITH (NOLOCK) WHERE ( 1 = 1 ) {0} ORDER BY IstasyonKodu, IstasyonAdi", val);
            DataTable data = new DataTable();
            if (Utility.Engine.dat.TableDoldur(x, ref data) == false || data == null || data.Rows.Count < 1)
            {
                Utility.Hata("Otomasyon sisteminde tanımlı istasyon bilgisi yok!");
                Close();
            }

            data.TableName = "STEZGAH";
            dataGrid1.DataSource = data;

            if (data != null && data.Rows.Count == 1)
            {
                dataGrid1.Select(0);
                button1_Click(null, null);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGrid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(dataGrid1.VisibleRowCount > 0 && dataGrid1.CurrentRowIndex >= 0 && !dataGrid1.IsSelected(dataGrid1.CurrentRowIndex))
			    {
				    dataGrid1.Select(dataGrid1.CurrentRowIndex);
			    }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (/*dataGrid1.VisibleRowCount > 0 && */dataGrid1.CurrentRowIndex >= 0 /*&& !dataGrid1.IsSelected(dataGrid1.CurrentRowIndex)*/)
                {
                    int row = dataGrid1.CurrentRowIndex;
                    DataTable source = (DataTable)dataGrid1.DataSource;
                    SecilenIstasyon = new AdamIstasyon();
                    SecilenIstasyon.IstasyonKodu = source.Rows[row]["IstasyonKodu"].ToString();
                    SecilenIstasyon.IstasyonAdi = source.Rows[row]["IstasyonAdi"].ToString();
                    SecilenIstasyon.PCIP = source.Rows[row]["PCIP"].ToString();
                    SecilenIstasyon.ModulAdi = source.Rows[row]["ModulAdi"].ToString();
                    SecilenIstasyon.PortAdi = source.Rows[row]["PortAdi"].ToString();
                    SecilenIstasyon.GrupKodu = source.Rows[row]["GrupKodu"].ToString();

                    try
                    {
                        SecilenIstasyon.UKayitNo = Convert.ToInt64(source.Rows[row]["UKayitNo"]);
                    }
                    catch
                    {
                        SecilenIstasyon.UKayitNo = 0;
                    }

                    if (SecilenIstasyon)
                    {
                        if (_personelata)
                        {
                            button5_Click(null, null);
                        }
                        else
                        {
                            panelIstasyon.Visible = false;
                            labelIstasyonKod.Text = SecilenIstasyon.IstasyonKodu;
                            labelTitle.Text =
                            labelIstasyonAd.Text = SecilenIstasyon.IstasyonAdi;
                            panelIslemSec.Location = new Point(0, 0);
                            panelIslemSec.BringToFront();
                            panelIslemSec.Visible = true;
                        }
                    }
                    else
                    {
                        labelIstasyonKod.Text = "";
                        labelIstasyonAd.Text = "";
                        SecilenIstasyon.Dispose();
                        return;
                    }
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void buttonIsBul_Click(object sender, EventArgs e)
        {
            try
            {
                OzelSecim oz = new OzelSecim();
                oz.str_ad = "StokKodu";
                oz.str_kod = "IsEmri";
                oz.str_ozel = "StokAdi";
                oz.tablo = string.Format("dbo.AdamIsEmri WITH (NOLOCK) WHERE ( IstasyonKodu = N'{0}' ) ", SecilenIstasyon.IstasyonKodu);                
                oz.order_by = " IsEmri, StokAdi ";
                if (oz.ShowDialog() == DialogResult.OK)
                {
                    textIsEmri.Text = oz.kod;
                    IsEmri();
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void textIsEmri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                IsEmri();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (SecilenIstasyon)
            {
                panelIslemSec.Visible = false;
                panelIsEmriBul.Location = new Point(0, 0);
                panelIsEmriBul.BringToFront();
                panelIsEmriBul.Visible = true;
            }
        }

        private void dataGrid1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGrid1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGrid1.VisibleRowCount > 0 && dataGrid1.CurrentRowIndex >= 0 && !dataGrid1.IsSelected(dataGrid1.CurrentRowIndex))
                {
                    dataGrid1.Select(dataGrid1.CurrentRowIndex);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void labelTitle_ParentChanged(object sender, EventArgs e)
        {

        }

        private void buttonIsAta_Click(object sender, EventArgs e)
        {
            try
            {
                if (textIsEmri.Text.Length < 1)
                {
                    Utility.Hata("İş emri seçilmedi!");
                    return;
                }

                if (comboBirim.SelectedItem == null)
                {
                    Utility.Hata("Birim seçin!");
                    return;
                }

                Database ist = new Database(
                    string.Format(@"packet size=4096;integrated security=false;data source={0};persist security info=False;initial catalog=pprboru;User ID=sa;Password=1234;Connect Timeout=50;",
                    SecilenIstasyon.PCIP));
                
                ist.BeginTransaction();

                Utility.Engine.sql = string.Format("EXECUTE dbo.IsEmriAta N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', '{8}', '{9}', '{10}', '{11}', {12}",
                    SecilenIstasyon.IstasyonKodu, 
                    SecilenIstasyon.IstasyonAdi, 
                    textIsEmri.Text, 
                    labelStokKodu.Text,
                    labelStokAdi.Text, 
                    comboBirim.Text,
                    labelOperasyonKodu.Text, 
                    labelOperasyonAdi.Text, 
                    labelIsMiktar.Text,
                    labelBirimAgirlik.Text,
                    labelMinAgirlik.Text, 
                    labelMaxAgirlik.Text,                      
                    SecilenIstasyon.UKayitNo);
                DataTable dtResponse = new DataTable();
                DataTable dtResponse2 = new DataTable();
                if (ist.TableDoldur(Utility.Engine.sql, ref dtResponse) && dtResponse != null && dtResponse.Rows.Count > 0)
                {
                    string str_durum = dtResponse.Rows[0][0].ToString();
                    string str_mesaj = dtResponse.Rows[0][1].ToString();
                    if (!str_durum.Equals("OK"))
                    {
                        ist.RollbackTransaction();
                        Utility.Hata("İş emri atama işlemi tamamlanamadı sunucu hata bildirdi!" + str_mesaj);
                        return;
                    }

                    if (Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dtResponse) && dtResponse != null && dtResponse.Rows.Count > 0)
                    {
                        str_durum = dtResponse.Rows[0][0].ToString();
                        str_mesaj = dtResponse.Rows[0][1].ToString();
                        if (!str_durum.Equals("OK"))
                        {
                            ist.RollbackTransaction();
                            Utility.Hata("İş emri atama işlemi tamamlanamadı sunucu hata bildirdi!" + str_mesaj);
                            return;
                        }
                    }

                    ist.CommitTransaction();

                    textIsEmri.Text = "";
                    labelStokKodu.Text = "";
                    labelStokAdi.Text = "";
                    labelOperasyonKodu.Text = "";
                    labelOperasyonAdi.Text = "";
                    labelIsMiktar.Text = "";
                    labelBirim.Text = "";
                    labelMinAgirlik.Text = "";
                    labelMaxAgirlik.Text = "";
                    labelBirimAgirlik.Text = "";
                    comboBirim.DataSource = null;
                    comboBirim.Text = "";
                    panelIsEmriBul.Visible = false;
                    panelIslemSec.Visible = true;
                    panelIslemSec.BringToFront();
                    return;
                }
                else
                {
                    Utility.Hata("İş emri atama işlemi tamamlanamadı sunucu yanıt vermiyor!" + ist.STR_HataMesaji);
                    return;
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("İş emri ataması sırasında hata:" + exc.Message);
            }
        }

        private void labelStokKodu_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBirim.SelectedItem != null && comboBirim.SelectedValue != null)
                {
                    labelBirim.Text = comboBirim.SelectedValue.ToString();
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message);
            }
        }

        private void labelStokAdi_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelIsEmriBul.Visible = 
            panelIslemSec.Visible =
            panelIstasyon.Visible = false;
            panelPersonel.Location = new Point(0, 0);
            panelPersonel.BringToFront();
            panelPersonel.Visible = true;            
            Personeller();
            textPAdi.Visible = textPSicil.Visible = true;
            textPSicil.Focus();
        }

        private void dataGrid2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textPAdi.Visible = textPSicil.Visible = false;
                if (dataGrid2.VisibleRowCount > 0 && dataGrid2.CurrentRowIndex >= 0 && !dataGrid2.IsSelected(dataGrid2.CurrentRowIndex))
                {
                    dataGrid2.Select(dataGrid2.CurrentRowIndex);
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void dataGrid2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGrid2.VisibleRowCount > 0 && dataGrid2.CurrentRowIndex >= 0 && !dataGrid2.IsSelected(dataGrid2.CurrentRowIndex))
                {
                    dataGrid2.Select(dataGrid2.CurrentRowIndex);
                    textPAdi.Visible = textPSicil.Visible = true;
                    textPSicil.Focus();
                    return;
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (/*dataGrid1.VisibleRowCount > 0 && */dataGrid2.CurrentRowIndex >= 0 /*&& !dataGrid1.IsSelected(dataGrid1.CurrentRowIndex)*/)
                {
                    int row = dataGrid2.CurrentRowIndex;
                    DataTable source = (DataTable)dataGrid2.DataSource;
                    SecilenPersonel = new SPersonel();
                    SecilenPersonel.KOD = source.Rows[row]["KOD"].ToString();
                    SecilenPersonel.AD = source.Rows[row]["AD"].ToString();
                    SecilenPersonel.SOYAD = source.Rows[row]["SOYAD"].ToString();

                    if (!string.IsNullOrEmpty(SecilenPersonel.KOD))
                    {
                        label1Personel.Text = string.Format("[{0}] {1} {2}", SecilenPersonel.KOD, SecilenPersonel.AD, SecilenPersonel.SOYAD);
                        labelPersonel.Text = SecilenPersonel.KOD;
                        panelPersAta.Location = new Point(0, 0);
                        panelPersAta.Visible = true;
                        panelPersAta.BringToFront();
                    }
                    else
                    {
                        labelIstasyonKod.Text = "";
                        labelIstasyonAd.Text = "";
                        SecilenIstasyon.Dispose();
                        return;
                    }
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelPersAta.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelPersonel.Text == "" || labelPersonel.Text.Equals("____________________"))
                {
                    Utility.Hata("Personel seçilmedi!");
                    return;
                }

                if (SecilenIstasyon == false)
                {
                    Utility.Hata("İstasyon seçin!");
                    return;
                }

                DataTable dtx = new DataTable();
                if (Utility.Engine.dat.TableDoldur(string.Format("EXEC dbo.PersAta N'{0}', N'{1}'",
                    SecilenPersonel.KOD, SecilenIstasyon.IstasyonKodu),ref dtx) && dtx != null && dtx.Rows.Count > 0)
                {
                    if (Convert.ToInt32(dtx.Rows[0][0]) < 1)
                    {
                        Utility.Hata("Sunucu hata bildirdi:" + dtx.Rows[0][1].ToString());
                    }
                }
                else
                {
                    Utility.Hata("Sunucu yanıt vermedi!" + Utility.Engine.dat.Fault);                    
                }

                labelPersonel.Text = "";
                label1Personel.Text = "";
                SecilenPersonel = new SPersonel();
                panelPersAta.Visible = false;
                Personeller();                

            }
            catch (Exception exc)
            {
                Utility.Hata("İş emri ataması sırasında hata:" + exc.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (SecilenIstasyon)
                {
                    Utility.Engine.sql = string.Format("EXEC dbo.TermIstasyonAcilis N'{0}'",
                   SecilenIstasyon.IstasyonKodu);

                    string kayit = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);
                    long ikayit = 0;
                    try
                    {
                        ikayit = Convert.ToInt64(kayit);
                    }
                    catch
                    {
                        Utility.Hata(kayit + "1");
                        return;
                    }

                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void textPSicil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                textPAdi.Visible = textPSicil.Visible = false;
                SPersonel();
                return;
            }
        }

        private void textTKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Istasyonlar();
            }
        }
    }

    public struct AdamIstasyon : IDisposable
    {
        public string IstasyonKodu, IstasyonAdi, PCIP, ModulAdi, PortAdi, GrupKodu;
        public long UKayitNo;

        public static implicit operator bool(AdamIstasyon ist)
        {
            return (string.IsNullOrEmpty(ist.IstasyonKodu) == false && string.IsNullOrEmpty(ist.PCIP) == false);
        }

        public void Dispose()
        {
            IstasyonKodu = string.Empty; 
            IstasyonAdi = string.Empty; 
            PCIP = string.Empty; 
            ModulAdi = string.Empty; 
            PortAdi = string.Empty;
            GrupKodu = string.Empty;
        }
    }

    public struct SPersonel : IDisposable
    {
        public string KOD, AD, SOYAD;

        #region IDisposable Members

        public void Dispose()
        {
            KOD = string.Empty;
            AD = string.Empty;
            SOYAD = string.Empty;
        }

        #endregion
    }


}