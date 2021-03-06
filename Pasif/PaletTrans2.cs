using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class PaletTrans2 : Form
    {
        public PaletTrans2()
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
                    //if ( != textDepo.Text)
                    //{
                    //    Utility.Engine.Hata("Ata Kasa Depo Bilgisi Ve Kasa Depo Bilgisi Farkli Transfer Edilemez!");
                    //    textBoxKasa.Focus();
                    //    textBoxKasa.SelectAll();
                    //    return;
                    //}
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
                if (!Utility.Engine.Sor("Yapilan işlemler Kaydedilsinmi?")) return;


                if (textMiktar.Text.Trim() == "")
                    MessageBox.Show("Miktar Alanini Boş Birakmayin","Dikkat..!");

                int i = Convert.ToInt32(textMiktar.Text.PadLeft(1, '0'));

                Utility.Engine.sql = string.Format("EXEC dbo.KasaDuzeltme N'{0}',N'{1}','{2}',N'{3}',{4}",
                    Utility.Engine.SqlTemizle(textBoxKasa.Text),
                   i.ToString(),
                   Utility.Engine.KullaniciKod,
                   Utility.Engine.CihazID,
                   "1");

                label1.Text = i.ToString() + " __ " + Utility.Engine.sql;

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
                    Utility.Engine.Hata("Sunucu Yanit Vermedi!! ___" + Utility.Engine.dat.Fault);
                    Temizle();
                    return;
                }
                Temizle();
                Utility.Engine.Tamam("işlem Tamamlandi!");
                textBoxKasa.Focus();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Temizle()
        {
            textDepo.Text = "";
            textKMiktar.Text =
            textMiktar.Text =        
            textBoxKasa.Text = "";
            textKasaBirim.Text = "";
            textKasaStokAdi.Text = "";
            textKasaStokKodu.Text = "";
            textBoxKasa.Focus();
            return;
        }

        private void PaletTrans2_Load(object sender, EventArgs e)
        {
            textBoxKasa.Focus();
            textBoxKasa.SelectAll();

        }
    }
}