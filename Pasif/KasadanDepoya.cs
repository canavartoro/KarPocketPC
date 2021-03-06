using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class KasadanDepoya : Form
    {
        public KasadanDepoya()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Temizle();
            return;
        }

        private void textBoxKasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button2_Click(null, null);
                textMiktar.Focus();
                textMiktar.SelectAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Utility.Engine.sql = string.Format("EXEC dbo.KasaBulKasaTransfer N'{0}'", Utility.Engine.SqlTemizle(textBoxKasa.Text));

                //ilkinin iş emri vardaiya personel = olursa aktara bilsin

                DataTable dtx = new DataTable();

                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dtx);

                if (dtx != null && dtx.Rows.Count > 0)
                {
                    
                    textDepo.Text = dtx.Rows[0]["DepoKodu"].ToString();
                    textBoxKasa.Text = dtx.Rows[0]["SeriliBarkod"].ToString();
                    textKasaStokKodu.Text = dtx.Rows[0]["StokKodu"].ToString();
                    textKasaStokAdi.Text = dtx.Rows[0]["StokAdi"].ToString();
                    textKasaBirim.Text = dtx.Rows[0]["Birim"].ToString();
                    textKMiktar.Text = Convert.ToDecimal(dtx.Rows[0]["Miktar"].ToString()).ToString();
                    textMiktar.Focus();
                    return;
                }
                else
                {
                    Temizle();
                    Utility.Engine.Hata("Seri Bilgisi Sistemde Bulunamadi!");
                    textBoxKasa.Focus();
                    textBoxKasa.SelectAll();
                    return;
                }
            }
            catch (Exception exc)
            {
                Utility.Engine.Hata("Seri Sorgulanamadi.");
                textBoxKasa.Focus();
                textBoxKasa.SelectAll();
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int mkt = 0;

                try
                {
                    mkt = Convert.ToInt32(textMiktar.Text.PadLeft(1, '0').Replace(",", ".").Trim());
                }
                catch { mkt = 0; }

                if (mkt == 0)
                {
                    Utility.Engine.Hata("Miktar Alninda Hata ..!");
                    return;
                }

                if (textBox1.Text.Trim() == "")
                {
                    Utility.Engine.Hata("Gireceði Depoyu Seçmelesiniz ..!");
                    return;
                }

                Utility.Engine.sql = string.Format("EXEC dbo.KasaDuzeltme N'{0}',N'{1}','{2}',N'{3}',{4},N'{5}',N'TRANSFER'",
                  Utility.Engine.SqlTemizle(textBoxKasa.Text),
                 mkt.ToString(),
                 Utility.Engine.KullaniciKod,
                 Utility.Engine.CihazID,
                 "0",Utility.Engine.SqlTemizle(textDepo.Text));

                DataTable sonuc = new DataTable();
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref sonuc);

                if (sonuc != null && sonuc.Rows.Count > 0)
                {
                    if (sonuc.Rows[0][0].ToString().ToUpper() != "OK")
                    {
                        Utility.Engine.Hata(sonuc.Rows[0][0].ToString().ToUpper());
                        Temizle();
                        return;
                    }
                }
                else
                {
                    Utility.Engine.Hata("Sunucu Yanit Vermedi!! __" + Utility.Engine.dat.Fault);
                    Temizle();
                    return;
                }
                Temizle();
                Utility.Engine.Tamam("işlem Tamamlandi!");
                textBoxKasa.Focus();
                return;
            }
            catch  (Exception  ex)
            {
                MessageBox.Show(ex.Message, "Genel Hata..!");
            }
        }
        private void Temizle()
        {
            textKMiktar.Text =
            textMiktar.Text =
            textBoxKasa.Text = "";
            textKasaBirim.Text = "";
            textKasaStokAdi.Text = "";
            textKasaStokKodu.Text = "";
            textBox1.Text = "AMBALAJ";
            textDepo.Text = "";
            textBoxKasa.Focus();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KasadanDepoya_Load(object sender, EventArgs e)
        {
            textBoxKasa.Focus();
            textBoxKasa.SelectAll();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {            
            DepoSecimOzel oz = new DepoSecimOzel();
            oz.Rapor = true;
            if (oz.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = oz.DepoKodu;
                textKMiktar.Focus();
                textKMiktar.SelectAll();
            }
        }

        private void textMiktar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}