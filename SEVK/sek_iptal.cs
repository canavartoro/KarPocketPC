using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PocketPC.AraEkralar;

namespace AmbarPPC
{
    public partial class sek_iptal : Form
    {
        DataTable dt = new DataTable();
        public string _Seri ="";
        string _BosPalet = "";
        bool hataVar = false;
        public bool bolunmusSeriIptal = false;
        string sevkEmri = "";
        DataTable dtBolunmusSeriler = new DataTable();

        public sek_iptal()
        {
            InitializeComponent();
        }

        private void sek_iptal_Load(object sender, EventArgs e)
        {
            label3.Text = bolunmusSeriIptal ? "Kaynak Seri:" : "Palet:";
            label1.Text = bolunmusSeriIptal ? "Hedef Seri:" : "Seri|Palet:";
            if (bolunmusSeriIptal)
            {
                MiktarSor sevkEmriSor = new MiktarSor();
                sevkEmriSor.Text = "Sevk Emri Gir";
                if (sevkEmriSor.ShowDialog() != DialogResult.OK)
                {
                    this.Close();
                    return;
                }
                sevkEmri = sevkEmriSor.metin;
                BolunmusSeriGetir();
                button6.Visible = false;
            }
            textBoxPalet.Focus();
        }

        private void BolunmusSeriGetir()
        {
            try
            {
                if (string.IsNullOrEmpty(sevkEmri))
                {
                    Utility.Hata("Sevk emri boş bırakılamaz! ");
                    sek_iptal_Load(null, null);
                    return;
                }
                string sorgu = string.Format("SELECT Detay.SeriliBarkod, Detay.StokKodu, seri.Miktar from stok_hareket_detay Detay (NOLOCK) INNER JOIN stok_hareket_ust ust (NOLOCK) ON ust.BelgeNo = Detay.BelgeNo INNER JOIN serili_barkodlar seri (NOLOCK) ON seri.SeriliBarkod = Detay.SeriliBarkod INNER JOIN kasa_transfer kasa (NOLOCK) ON kasa.Kasa = Detay.SeriliBarkod INNER JOIN stok_tanim_detay stok (NOLOCK) ON stok.StokKodu = seri.StokKodu AND stok.Birim = seri.Birim where Ust.IrsaliyeNo ='{0}'  /*AND PaletID ='' */ AND stok.AnaBirim = 'E' GROUP BY detay.StokKodu, Detay.PaletID, Detay.SeriliBarkod, seri.Miktar ORDER BY Detay.SeriliBarkod ", sevkEmri);
                dtBolunmusSeriler = Utility.Engine.dat.TableDon(sorgu);
                if (dtBolunmusSeriler.Rows.Count <= 0)
                {
                    Utility.Hata("Bu sevk emrine ait bölünmüş ve sevk edilmiş seri bulunamadı.");
                    sek_iptal_Load(null, null);
                    return;
                }
                dataGrid1.DataSource = dtBolunmusSeriler;
                GridAc();
            }
            catch (Exception ex)
            {
                Utility.Hata(ex.ToString());
            }
        }

        public void GridAc()
        {
            if (dataGrid1.VisibleRowCount > 0)
            {
                panel1.Location = new Point(10, 10);
                panel1.Visible = true;
                panel1.BringToFront();
            }
        }

        public void GridKapat() { panel1.Visible = false; }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPalet.Text = "";
            if (bolunmusSeriIptal)
                BolunmusSeriGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control();
        }

        void control()
        {
            DataTable dt = new DataTable();
            string kontrolSql = "";
            try
            {
                kontrolSql = @"select count(*) from palet_tanim (NOLOCK) where PaletID='" + textBoxSeri.Text.Trim() + "'";

                #region Seri Iptal
                if (Utility.Engine.dat.TCount(kontrolSql) <= 0)
                {
                    _Seri = textBoxSeri.Text.Trim();
                    SeriIptal();
                } 
                #endregion

                #region Palet Iptal Yeni
                else
                {
                    if (Utility.Sor("Palet bazında iptal yapılacaktır. Onaylıyor musunuz?"))
                    {
                        PaletIptal();
                    }
                    else
                    {
                        textBoxPalet.Text = "";
                        textBoxSeri.Text = "";
                        listView1.Items.Clear();
                        textBoxPalet.Focus();
                    }
                } 
                #endregion


            }
            catch (Exception)
            {
                Utility.Hata("Palet İptal de hata oluştu.");
                return;
            }
        }

        void secim()
        {

            try
            {
                panel1.Location=new Point(10,10);

                /*Utility.Engine.sql = @"
                            select  0  GMiktar,Birim,Miktar ,d.CariKod,d.IrsaliyeNo,d.BelgeNo,kt.ids
                                from kasa_transfer  kt  inner  join  stok_hareket_ust d
                                    on d.BelgeNo=kt.BelgeNo
                                        where AtaKasa=N'" + textBoxSeri.Text.Trim() + "' ";*/

                Utility.Engine.sql =
                    string.Format(@" select  
	GelenMiktar as GMiktar,
	Birim,
	Kalan as Miktar ,
	d.CariKod,
	d.IrsaliyeNo,
	d.BelgeNo,
	kt.ids,
	kt.Kasa
from kasa_transfer  kt (nolock) inner  join  stok_hareket_ust d (nolock) on d.BelgeNo=kt.BelgeNo
where AtaKasa=N'{0}'", _Seri);

                DataTable dt = Utility.Engine.dat.TableDon(Utility.Engine.sql);
                dt.TableName = "kasa";
                dataGrid1.DataSource = dt;
                panel1.Visible = true;
                panel1.BringToFront();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
            
            

        }

        void basla()
        {
            try
            {

                Utility.Engine.alantemizle(textBoxPalet);
                Utility.Engine.alantemizle(textBoxSeri);

                string Plt = "";
                string seri = "";
                string sonuc = "";

                Plt = _BosPalet;
                seri = _Seri;

                DataTable dtx = null;

                dtx = Utility.Engine.dat.TableDon("exec dbo.sevk_iptal2 N'" + seri + "',N'" + Plt + "',N'" + Utility.Engine.KullaniciKod + "'");

                textBoxSeri.Text = "";

                if (dtx == null)
                {
                    hataVar = true;
                    return;
                }

                if (dtx.Rows.Count < 1)
                {
                    hataVar = true;
                    return;
                }

                sonuc = dtx.Rows[0][0].ToString();

                int bak = sonuc.IndexOf("Hata");

                if (bak > -1)
                {
                    MessageBox.Show(sonuc);
                    hataVar = true;
                    return;
                }

                for (int i = 0; i < dtx.Rows.Count; i++)
                {
                    ListViewItem row = new ListViewItem();
                    row.Text = dtx.Rows[i][0].ToString();
                    for (int c = 1; c < dtx.Columns.Count; c++)
                    {
                        row.SubItems.Add(dtx.Rows[i][c].ToString());
                    }
                    listView1.Items.Add(row);
                }

                labelSatir.Text = listView1.Items.Count.ToString();
                this.Text = listView1.Items.Count.ToString();
                textBoxSeri.Focus();
                hataVar = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SeriIptal() 
        {
            try
            {
                //17.12.2015 tarihinde düzenlendi.Uğur Özcan
                string sorgu = string.Format("select COUNT(*)  from kasa_transfer kasa(NOLOCK) INNER JOIN serili_barkodlar seri(NOLOCK) on seri.SeriliBarkod = kasa.Kasa INNER JOIN stok_tanim_detay stok ON stok.StokKodu = seri.StokKodu AND stok.Birim = seri.Birim where Kasa=N'{0}' AND stok.AnaBirim = 'E'", _Seri);
                Utility.Engine.sql = sorgu;// @"  select COUNT(*)  from kasa_transfer (NOLOCK) where Kasa=N'" + _Seri + "'  ";

                    if (Utility.Engine.dat.TCount(Utility.Engine.sql) > 0)
                    {
                        Utility.Hata("Bu seri için iptal işlemi Bölünmüş serileri iptal ekranındann yapılmalıdır.");
                        //secim(); 
                        return;
                    }
                    else
                    { basla(); }
            }
            catch (Exception)
            {
            }
        }

        public void PaletIptal() 
        {

            string doluPalet = textBoxSeri.Text.Trim();
            string bosPalet = textBoxPalet.Text.Trim();
            DataTable dtx = null;

            dtx = Utility.Engine.dat.TableDon("exec [DP2007].[sevk].[SevkIptalPaletYeni] N'" + bosPalet + "', N'" + doluPalet + "' ,N'" + Utility.Engine.KullaniciKod + "'");

            textBoxSeri.Text = "";

            if (dtx == null)
            {
                return;
            }

            if (dtx.Rows.Count < 1)
            {
                return;
            }

            string sonuc = dtx.Rows[0][0].ToString().ToUpper();

            int bak = sonuc.IndexOf("HATA");

            if (bak > -1)
            {
                MessageBox.Show(sonuc);
                return;
            }

            for (int i = 0; i < dtx.Rows.Count; i++)
            {
                ListViewItem row = new ListViewItem();
                row.Text = dtx.Rows[i][0].ToString();
                for (int c = 1; c < dtx.Columns.Count; c++)
                {
                    row.SubItems.Add(dtx.Rows[i][c].ToString());
                }
                listView1.Items.Add(row);
            }

            labelSatir.Text = listView1.Items.Count.ToString();
            this.Text = listView1.Items.Count.ToString();
            textBoxSeri.Text = "";
            textBoxPalet.Text = "";
            textBoxPalet.Focus();

            #region İptal
            //#region Paler İçerik Kontrol
            //string srg = "SELECT   detay.SeriliBarkod as SERI ";
            //srg += " FROM   stok_hareket_detay detay (NOLOCK)";
            //srg += " LEFT OUTER JOIN  stok_hareket_ust ust (NOLOCK) ON ust.BelgeNo= detay.BelgeNo "; 
            //srg += " WHERE ust.Aciklama1=N'SEVKIYAT' AND detay.CikanDepo=N'SEVKIYAT GIRIS' AND detay.PaletID ='" ;
            //srg += doluPalet + "' ";
            //srg += " ORDER BY ust.Tarih DESC ";
            //#endregion

            //Utility.Engine.dat.TableDoldur(srg, ref dtx);


            //foreach (DataRow item in dtx.Rows)
            //{
            //    _Seri = item["SERI"].ToString();

            //    SeriIptal();
            //    if (hataVar)
            //        break;
            //}
            //if (!hataVar)
            //{
            //    //Utility.Engine.dat.TInsert("commit transaction PaletIptal");
            //    textBoxPalet.Text = "";
            //    textBoxSeri.Text = "";
            //    hataVar = false;
            //    textBoxPalet.Focus();
            //}
            //else
            //{
            //    //Utility.Engine.dat.TInsert("rollback transaction PaletIptal");
            //    textBoxSeri.Text = "";
            //    textBoxPalet.Text = "";
            //    listView1.Items.Clear();
            //    textBoxPalet.Focus();
            //    hataVar = false;
            //    return;
            //} 
            #endregion

        }

        private void textBoxSeri_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Bekleyiniz bekle = new Bekleyiniz();
                    Cursor.Current = Cursors.WaitCursor;
                    bekle.TopMost = true;
                    bekle.Show();
                    if (bolunmusSeriIptal)
                    {
                        bolunmusSeriSevkIptal();
                        GridAc();
                    }
                    else
                    {
                        _BosPalet = textBoxPalet.Text.Trim();
                        control();
                    }
                    bekle.Close();
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void bolunmusSeriSevkIptal()
        {
            try
            {

                Utility.Engine.alantemizle(textBoxPalet);
                Utility.Engine.alantemizle(textBoxSeri);

                string kaynakSeri = "";
                string hedefSeri = "";
                string sonuc = "";

                kaynakSeri = textBoxPalet.Text;
                hedefSeri = textBoxSeri.Text;

                DataTable dtx = null;

                dtx = Utility.Engine.dat.TableDon(string.Format("exec sevk.BolunmusSeriSevkIptal N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", kaynakSeri, hedefSeri, Utility.Engine.KullaniciKod,Utility.Engine.CihazID,sevkEmri));

                textBoxPalet.Text = "";
                textBoxSeri.Text = "";
                sonuc = dtx.Rows[0][0].ToString();
                if (dtx == null || dtx.Rows.Count < 1 || sonuc.IndexOf("Hata") > -1 || sonuc.IndexOf("!") > -1)
                {
                    MessageBox.Show(sonuc);
                    hataVar = true;
                    return;
                }

                for (int i = 0; i < dtx.Rows.Count; i++)
                {
                    ListViewItem row = new ListViewItem();
                    row.Text = dtx.Rows[i][0].ToString();
                    for (int c = 1; c < dtx.Columns.Count; c++)
                    {
                        row.SubItems.Add(dtx.Rows[i][c].ToString());
                    }
                    listView1.Items.Add(row);
                }

                labelSatir.Text = listView1.Items.Count.ToString();
                this.Text = listView1.Items.Count.ToString();

                BolunmusSeriGetir();

                hataVar = false;
            }
            catch (Exception ex)
            {
                Utility.Hata(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxSeri.Text = "";
        }

        private void textBoxPalet_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyValue == 13 || e.KeyValue == 17)
            {
                button4_Click(null, null);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPalet.Text.Trim() == "") return;

                string asd = "EXEC sevk.SevkIptalPalet N'";
                asd += textBoxPalet.Text;
                asd += "', N'";
                asd += Utility.Engine.KullaniciKod;
                asd += "'";

                Utility.Engine.sql = asd;

                string xreturn = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);
                if (string.IsNullOrEmpty(xreturn) || !xreturn.Equals("OK"))
                {
                    Utility.Hata(xreturn);
                    textBoxPalet.Text = "";
                    textBoxSeri.Text = "";
                    listView1.Items.Clear();
                    textBoxPalet.Focus();
                    return;
                }
                else
                {
                    textBoxSeri.Focus();
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(368,216);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt =(DataTable)dataGrid1.DataSource;

            if (dt != null)
            {
                MiktarSor mk = new MiktarSor();
                if (mk.ShowDialog() != DialogResult.OK)
                    return;
                int gmiktar = (int)mk.miktar;

                try
                {
                    Utility.Engine.dat.TInsert("begin transaction xx5");

                    try { textBoxSeri.Text = dataGrid1[dataGrid1.CurrentRowIndex, 7].ToString(); }
                    catch (Exception ee) { Utility.WriteTrace(ee.Message); }

                    string xsal = "update  kasa_transfer  set  GelenMiktar = isnull(GelenMiktar,0) + N'" + gmiktar.ToString() + "'  where ids=N'" + dataGrid1[dataGrid1.CurrentRowIndex, 6].ToString() + "'";

                    if (!Utility.Engine.dat.TInsert(xsal))
                    {
                        Utility.Engine.dat.TInsert("rollback transaction xx5");
                        MessageBox.Show("Gelen Miktarlar Kayit Edilirken Hata Oluştu..!  <" + Utility.Engine.dat.STR_HataMesaji + ">");
                        return;
                    }

                    Utility.Engine.dat.TInsert("commit transaction xx5");
                }
                catch (Exception exc)
                {
                    Utility.Engine.dat.TInsert("rollback transaction xx5");
                    MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
                }

                panel1.Location = new Point(368, 216);

                basla();

            }
        }

        private void dataGrid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBoxPalet.Text = dataGrid1[dataGrid1.CurrentCell.RowNumber, 0].ToString();
                GridKapat();
            }
            catch (Exception ex)
            {
                Utility.Hata(ex.ToString());
            }
        }

        private void textBoxPalet_LostFocus(object sender, EventArgs e)
        {
            try
            {
                button4_Click(null, null);
            }
            catch (Exception ex)
            {
                
                Utility.Hata(ex.ToString());
            }
        }
    }
}