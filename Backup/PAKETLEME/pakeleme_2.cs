using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace AmbarPPC
{
    public partial class pakeleme_2 : Form
    {
        public pakeleme_2()
        {
            InitializeComponent();
        }

        string PersonelKodu = "";


        private void pakeleme_2_sinemalarda_Load(object sender, EventArgs e)
        {

            //0  ana birim   1  ambalaj

            //comboBox1.Items.Add("Ana Birim");
            //comboBox1.Items.Add("Ambalaj Birimi");

            textkasaseri.Enabled = false;
            textpaletno.Enabled = false;
            textpaketseri.Enabled = false;

            textkasaseri.Text = "";
            textpaletno.Text = "";
            textpaketseri.Text = "";


            Personel();

            AcikOp();

            if (Utility.Engine.OpNo != "0")
            {
                //Utility.Engine.sql = @"exec paketleme N'',N'',N'',N'" + labelopno.Text.Trim() + "',N'',N'',N'',N'3'";

                Utility.Engine.sql = string.Format(@"SELECT TOP 1000 d.SeriliBarkod AS [Seri], s.IsEmri AS [iş Emri], d.StokKodu AS [Stok Kodu], t.StokAdi AS [Stok Adi] FROM  dbo.depo_mevcut d WITH (NOLOCK) LEFT OUTER JOIN dbo.stok_tanim_ust t WITH (NOLOCK) ON d.StokKodu = t.StokKodu  LEFT OUTER JOIN dbo.serili_barkodlar s WITH (NOLOCK)	ON d.SeriliBarkod = s.SeriliBarkod WHERE s.UKayitNo = {0} ", labelopno.Text.Trim());

                try
                {
                    DataTable dty = null;
                    dty = Utility.Engine.dat.TableDon(Utility.Engine.sql);
                    dty.TableName = "palet";
                    dataGrid1.DataSource = dty;
                    label11.Text = dty.Rows.Count.ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Özel Bir Durum Oluştu", ex.Message);
                }

                textkasaseri.Enabled =
                textpaletno.Enabled =
                textpaketseri.Enabled = true;

            }

            if (Utility.Engine.PaletNo != "")
            {
                textpaletno.Text = Utility.Engine.PaletNo;
            }

            textpaletno.Focus();

        }

        private void Personel()
        {
            string snc = "";
            
            //Utility.Engine.sql = string.Format(@" exec paketleme N'',N'',N'" + Utility.Engine.KullaniciID + "',N'',N'',N'',N'',N'-1' ");

            Utility.Engine.sql = string.Format("SELECT s.KOD FROM tanimlamalar t WITH (NOLOCK) LEFT OUTER JOIN SPERSONEL s WITH (NOLOCK) ON t.TanimValue = s.KOD WHERE t.TanimID = N'{0}'", Utility.Engine.KullaniciID);
            
            snc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();


            if (snc == "-1")
            {
                MessageBox.Show("Kullanici Kodu Bulunamadi işlem Devam Edemez");
                this.Close();
            }
            else
                PersonelKodu = snc;

        }

        private void AcikOp()
        {
            try
            {
                //Utility.Engine.sql = string.Format(@" exec paketleme N'',N'',N'" + PersonelKodu + "',N'',N'',N'',N'',N'-2' ");

                Utility.Engine.sql = string.Format(@"SELECT TOP 1 ISNULL(o.ID,N'0') FROM dbo.isemri_operasyon o WITH (NOLOCK) LEFT OUTER JOIN dbo.isemri_iscilik i WITH (NOLOCK) ON i.UKayitNo = o.ID  WHERE ( o.BitTarih IS NULL) AND (i.PersonelKodu = N'{0}') ORDER BY o.BasTarih DESC", PersonelKodu);


                string snc = "";

                snc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();

                try { double.Parse(snc); }
                catch { snc = "0"; }

                labelopno.Text = snc;

                if (labelopno.Text == "0")
                    button6.Text = "Op.Baş";
                else
                {
                    button6.Text = "Op.Bit";
                }

                Utility.Engine.OpNo = labelopno.Text.Trim();
            }
            catch (Exception ex)
            {
                Utility.Engine.Hata(ex.Message + " Kullanici Kodu Belirlenirken Hata");
                Close();
                return;
            }
        }

        private void textpaletno_GotFocus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Gold;
        }

        private void textpaletno_LostFocus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
        }

        private void panel(bool g)
        {
            if (g)
            {
                panelduzelt.Location = new Point(2, 2);

                foreach (Control c in panelduzelt.Controls)
                {
                    if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        c.Text = "";
                    }
                }

                if (textkasaseri.Text.Trim() != "")
                {
                    lblKasadakalan.Text = Utility.Engine.dat.TSelectScalar("select Miktar from depo_mevcut where SeriliBarkod=N'" + textkasaseri.Text.Trim() + "'").Trim();
                }


                panelduzelt.BringToFront();
            }
            else
            {
                panelduzelt.Location = new Point(380, 2);
            }
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGrid1.Select(dataGrid1.CurrentRowIndex);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textpaletno.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textkasaseri.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textpaketseri.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel(true);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string snc = "";

            if (button6.Text.Trim() == "Op.Baş")
            {

                if (System.IO.File.Exists(@"\paket.ini"))
                {
                    System.IO.File.Delete(@"\paket.ini");
                }

                //Utility.Engine.sql = @" exec erp.paketleme N'',N'',N'" + PersonelKodu + "',N'',N'',N'',N'',N'5' ";

                Utility.Engine.sql = string.Format("EXECUTE erp.PakOpBaslat N'{0}'", PersonelKodu);

                snc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);

                try
                {
                    long l = long.Parse(snc);
                }
                catch
                {
                    MessageBox.Show(snc);
                    return;
                }

                labelopno.Text = snc;

                textkasaseri.Enabled =
                textpaletno.Enabled =
                textpaketseri.Enabled = true;

                button6.Text = "Op.Bit";
            }
            else
            {

                //Utility.Engine.sql = @" exec erp.paketleme N'',N'',N'',N'" + labelopno.Text.Trim() + "',N'',N'',N'',N'6' ";
                Utility.Engine.sql = string.Format("EXECUTE erp.PakOpBitir {0}", labelopno.Text.Trim());
                snc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);

                try
                {
                    long l = long.Parse(snc);
                    textkasaseri.Enabled =
                textpaletno.Enabled =
                textpaketseri.Enabled = false;
                }
                catch
                {
                    Utility.Hata("Sunucu yanit vermedi:" + snc);
                    //MessageBox.Show(snc);
                    return;
                }

                labelopno.Text = "0";
                button6.Text = "Op.Baş";
            }
        }

        private void pakeleme_2_sinemalarda_Closing(object sender, CancelEventArgs e)
        {
            Utility.Engine.OpNo = labelopno.Text.Trim();
            Utility.Engine.PaletNo = textpaletno.Text.Trim();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel(false);
        }

        private void palet_bul()
        {

            /*Utility.Engine.sql = @"exec erp.paketleme N'',N'',N'',N'" + labelopno.Text.Trim() + "',N'"
                                                      + Utility.Engine.alantemizleSql(textpaletno) + "',N'',N'',N'1'";*/

            Utility.Engine.sql = string.Format("EXECUTE erp.PaketPaletBul N'{0}', {1}", Utility.Engine.alantemizleSql(textpaletno), labelopno.Text.Trim());

            DataTable dtx = null;

            dtx = Utility.Engine.dat.TableDon(Utility.Engine.sql);


            if (dtx == null)
            {
                MessageBox.Show("Sunucu Hata Bildirdi", Utility.Engine.dat.Fault);
                return;
            }

            if (dtx.Columns.Count < 1)
            {
                MessageBox.Show("Sunucu HAta Bildirdi", Utility.Engine.dat.Fault);
                return;
            }

            try
            {
                if (dtx.Rows.Count > 0)
                {
                    if (dtx.Rows[0][0].ToString().Trim() == "-1")
                    {
                        MessageBox.Show(dtx.Rows[0][1].ToString().Trim(), "Sununcu  Bir Hata Bildirdi");
                        return;
                    }
                }
            }
            catch { ;}

            dtx.TableName = "palet";
            dataGrid1.DataSource = dtx;
            textkasaseri.Focus();
        }

        private void kasa_bul()
        {
            string ss = "";

            ss = textkasaseri.Text.Trim();

            textkasaseri.Text = "";

            if (ss == "") return;

            //Utility.Engine.sql = @"exec erp.paketleme N'',N'',N'',N'',N'',N'" + ss + "',N'',N'2'";

            Utility.Engine.sql = string.Format("SELECT ISNULL(SeriliBarkod,N'') FROM dbo.serili_barkodlar WITH (NOLOCK) WHERE ( SeriliBarkod = N'{0}' ) /*AND ( Aktarildi = 'E' )*/ ", ss);

            string sncx = "";

            sncx = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);

            if (sncx == "")
            {
                MessageBox.Show("Kasa Sistemde Bulunamadi..!");
                textkasaseri.Text = "";
                return;
            }

            Utility.Engine.sql = string.Format("UPDATE dbo.serili_barkodlar SET Aktarildi = N'E' WHERE SeriliBarkod = N'{0}'", sncx);

            if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
            {
                MessageBox.Show("Kasa bilgisi güncellenemedi..!" + Utility.Engine.dat.STR_HataMesaji);
                textkasaseri.Text = "";
                return;
            }

            textkasaseri.Text = sncx;
            textpaketseri.Focus();
            textpaketseri.Text = "";
        }

        private void seri_ekle()
        {
            //Utility.Engine.sql = " exec erp.paketleme ";
            //Utility.Engine.sql += "N'0',";
            //Utility.Engine.sql += "N'0',";
            //Utility.Engine.sql += "N'" + Utility.Engine.KullaniciID + "',";
            //Utility.Engine.sql += "N'" + labelopno.Text.Trim() + "',";
            //Utility.Engine.sql += "N'" + textpaletno.Text.Trim() + "',";
            //Utility.Engine.sql += "N'" + textkasaseri.Text.Trim() + "',";
            //Utility.Engine.sql += "N'" + textpaketseri.Text.Trim() + "',";
            //Utility.Engine.sql += "N'7'";

            Utility.Engine.sql = string.Format("EXECUTE erp.PakSeriEkleYeni N'{0}', {1}, N'{2}', N'{3}', N'{4}'",
                Utility.Engine.KullaniciID, labelopno.Text.Trim(), textpaletno.Text.Trim(), textkasaseri.Text.Trim(), textpaketseri.Text.Trim());

            DataTable dtx = null;

            dtx = Utility.Engine.dat.TableDon(Utility.Engine.sql);


            if (dtx == null)
            {
                Utility.Hata("Sunucu:" + Utility.Engine.dat.Fault);
                //MessageBox.Show("Sunucu HAta Bildirdi", Utility.Engine.dat.Fault);
                return;
            }

            if (dtx.Rows.Count < 1)
            {
                Utility.Hata("Sunucu:" + Utility.Engine.dat.Fault);
                //MessageBox.Show("Sunucu HAta Bildirdi", Utility.Engine.dat.Fault);
                return;
            }

            try
            {
                if (dtx.Rows[0][0].ToString().Trim() == "-1")
                {
                    Utility.Hata("Sunucu:" + dtx.Rows[0][1].ToString().Trim());
                    //MessageBox.Show(dtx.Rows[0][1].ToString().Trim(), "Sununcu  Bir Hata Bildirdi");
                    return;
                }
                else if (dtx.Rows[0][0].ToString().Trim() == "-2")
                {
                    panel(true);
                    return;
                }
            }
            catch { ; }

            dtx.TableName = "palet";
            dataGrid1.DataSource = dtx;

            label11.Text = dtx.Rows.Count.ToString();
            textpaketseri.Text = "";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            double depodaneklenen = 0;
            double gercekmiktar = 0;
            double kasadandepoya = 0;
            string seri = "";
            int islem = 0;

            try { depodaneklenen = double.Parse(textDepodanKasaaEklennen.Text.Trim().PadLeft(1, '0')); }
            catch { depodaneklenen = 0; }
            try { gercekmiktar = double.Parse(textGercekMiktar.Text.Trim().PadLeft(1, '0')); }
            catch { gercekmiktar = 0; }
            try { kasadandepoya = double.Parse(textBoxKasadanDEpoya.Text.Trim().PadLeft(1, '0')); }
            catch { kasadandepoya = 0; }

            seri = textDuzeltSeri.Text.Trim();


            if (seri == "")
            {
                islem = 71;
            }
            else
                islem = 72;


            string srr = "";

            srr = textDuzeltSeri.Text.Trim();

            if (srr.Length > 13)
            {
                MessageBox.Show("Seri Alanina Düzgün Veri Girişi Yapilmamiş karakter sayisi fazla  " + srr.Length.ToString());
                textpaketseri.Text = "";
            }

            Utility.Engine.sql = " exec erp.paketleme ";
            Utility.Engine.sql += "N'" + depodaneklenen + "',";
            Utility.Engine.sql += "N'" + gercekmiktar + "',";
            Utility.Engine.sql += "N'" + kasadandepoya + "',";
            Utility.Engine.sql += "N'" + labelopno.Text.Trim() + "',";
            Utility.Engine.sql += "N'" + textpaletno.Text.Trim() + "',";
            Utility.Engine.sql += "N'" + textkasaseri.Text.Trim() + "',";
            Utility.Engine.sql += "N'" + srr + "',";
            Utility.Engine.sql += "N'" + islem + "'";

            
            DataTable dtx = null;

            dtx = Utility.Engine.dat.TableDon(Utility.Engine.sql);


            if (dtx == null)
            {
                MessageBox.Show(Utility.Engine.dat.Fault, "Sunucu Hata Bildirdi");                
                return;
            }

            if (dtx.Rows.Count < 1)
            {
                MessageBox.Show(Utility.Engine.dat.Fault, "Sunucu Hata Bildirdi");
                return;
            }

            try
            {
                if (dtx.Rows[0][0].ToString().Trim() == "-1")
                {
                    MessageBox.Show("Sununcu  Bir Hata Bildirdi", dtx.Rows[0][1].ToString().Trim());                    
                    return;
                }
            }
            catch { ; }



            dtx.TableName = "palet";
            dataGrid1.DataSource = dtx;

            panel(false);

            label11.Text = dtx.Rows.Count.ToString();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textpaletno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                palet_bul();
            }
        }

        private void textkasaseri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kasa_bul();
            }
        }

        private void textpaketseri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 17)
            {
                seri_ekle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            palet_bul();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            kasa_bul();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seri_ekle();
        }

        private void textBoxKasadanDEpoya_LostFocus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
        }

        private void textBoxKasadanDEpoya_GotFocus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Gold;
        }

        private void textDepodanKasaaEklennen_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ss = "";

            if (e.KeyChar == 13 || e.KeyChar == 17)
            {
                TextBox t = (TextBox)sender;

                ss = t.Text.Trim().Replace("\r", "").Replace("\n", "").Replace("\n\r", "")
                .Replace("\r\n", "").Replace("\t", "").Replace("\n", "");

                if (ss != "")
                    t.Text = ss;

                if (t.Name.Trim() == "textDuzeltSeri")
                {
                    button11_Click(null, null);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                if (!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            { textBox1.Enabled = true; textBox1.Text = ""; }
            else
            {
                textBox1.Enabled = false; textBox1.Text = "";
            }
        }

        private void pakeleme_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D9)
            {
                if (Utility.HELPME != null)
                {
                    //Utility.HELPME["pakeleme_2"].show();
                }
            }
        }
    }
}