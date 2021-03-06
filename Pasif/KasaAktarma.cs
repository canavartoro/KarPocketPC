using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
   public partial class KasaAktarma : Form
   {
      public KasaAktarma()
      {
         InitializeComponent();
      }



      private void KasaAktarma_Load(object sender, EventArgs e)
      {
         textBoxKasa.Focus();
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
               textYeniKasa.Focus();
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

         if (textBoxKasa.Text.Trim() == "" || textYeniKasa.Text.Trim() == "")
         {
            MessageBox.Show("Kasa Biligileri Tam Dðil", "Dikkat..!");
            return;
         }

         if (!Utility.Engine.dat.TInsert(@"exec dbo.MKasaAktarma N'" + textBoxKasa.Text.Trim() + "',N'" + textYeniKasa.Text.Trim() + "'"))
         { MessageBox.Show("Sunucu Hata Bildirdi..:" + Utility.Engine.dat.Fault, "Dikkat..!"); return; }

         Temizle();

      }

      private void textBoxKasa_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == 13)
         {
            button2_Click(null, null);
            textYeniKasa.Focus();
            textYeniKasa.SelectAll();
         }
      }

      private void Temizle()
      {
         textKMiktar.Text =
         textYeniKasa.Text =
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
     
   }
}