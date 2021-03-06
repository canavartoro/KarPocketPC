using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class PaletTrans1 : Form
    {
        public PaletTrans1()
        {
            InitializeComponent();
        }

        private void textBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.Engine.sql = string.Format("EXEC dbo.KasaBulKasaTransfer N'{0}'", Utility.Engine.SqlTemizle(textBoxAtaKasa.Text));

                DataTable dtx = new DataTable();

                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dtx);

                if (dtx != null && dtx.Rows.Count > 0)
                {
                    Temizle();
                    textBoxAtaKasa.Text = dtx.Rows[0]["SeriliBarkod"].ToString();
                    textAtaStokKodu.Text = dtx.Rows[0]["StokKodu"].ToString();
                    textAtaStokAdi.Text = dtx.Rows[0]["StokAdi"].ToString();
                    textAtaBirim.Text = dtx.Rows[0]["Birim"].ToString();
                    textDepo.Text = dtx.Rows[0]["DepoKodu"].ToString();
                    textAMiktar.Text = Convert.ToDecimal(dtx.Rows[0]["Miktar"].ToString()).ToString();
                    textMiktar.Text = ""; 
                    textBoxAtaKasa.Focus();
                    return;
                }
                else
                {
                    Temizle();
                    Utility.Engine.Hata("Seri Bilgisi Sistemde Bulunamadi!");
                    textBoxAtaKasa.Focus();
                    return;
                }

            }
            catch (Exception exc)
            {
                Utility.Engine.Hata("Seri Sorgulanamadi.:" + exc.Message);
                textBoxAtaKasa.Focus();
                return;
            }
        }

        private void buttonBarkodSil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKasa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.Engine.Sor("Yapilan işlemler Kaydedilsinmi?")) return;

                if (textBoxAtaKasa.Text.Length < 1)
                {
                    Utility.Engine.Hata("Ata Kasayi Okutun!");
                    textBoxAtaKasa.Focus();
                    return;
                }


                int i = Convert.ToInt32(textMiktar.Text.Trim());
            

                if (textAtaStokKodu.Text == "" || textAtaBirim.Text == "")
                {
                    Utility.Engine.Hata("Ata Kasayi Okutun!");
                    textBoxAtaKasa.Focus();
                    return;
                }

                Utility.Engine.sql = string.Format("EXEC dbo.KasaDuzeltme N'{0}',N'{1}','{2}',N'{3}',{4}",
                   Utility.Engine.SqlTemizle(textBoxAtaKasa.Text),
                  i.ToString(),
                  Utility.Engine.KullaniciKod,
                  Utility.Engine.CihazID,
                  "0");

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
                textBoxAtaKasa.Focus();
                return;
            }
            catch (Exception exc)
            {
                Utility.Engine.Hata("Genel Hata:" + exc.Message);
                return;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxAtaKasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonOK_Click(null, null);
                textAMiktar.Focus();
                textAMiktar.SelectAll();
            }
        }

        private void Temizle()
        {
           
            textMiktar.Text =
            textAMiktar.Text = "";
            textDepo.Text = "";
            textAtaBirim.Text = "";
            textBoxAtaKasa.Text = "";
            textAtaStokKodu.Text = "";
            textAtaStokAdi.Text = "";
            textAMiktar.Text = "";            
            textBoxAtaKasa.Focus();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBarkodSil_Click_1(object sender, EventArgs e)
        {
            Temizle();
            return;
        }

        private void PaletTrans1_Load(object sender, EventArgs e)
        {
            textBoxAtaKasa.Focus();
            textBoxAtaKasa.SelectAll();
        }  
    }
}