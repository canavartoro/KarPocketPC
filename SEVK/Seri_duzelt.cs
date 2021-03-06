using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
   public partial class Seri_duzelt : Form
   {
      public Seri_duzelt()
      {
         InitializeComponent();
      }

      bool seribilgileri = false;
      string seri = "";

      private void KavisIcin_Load(object sender, EventArgs e)
      {
         SeriliBarkod.Focus();
      }

      private void textMontajMiktar_TextChanged(object sender, EventArgs e)
      {
         double m = 0;

         try
         {
            m = double.Parse(textMontajMiktar.Text.Trim().Replace(",", "."));
         }
         catch
         {
            m = 0;
         }


         if (m > 0 && seribilgileri)
         { buttonKaydet.Enabled = true; return; }
         else
         { buttonKaydet.Enabled = false; return; }
      }

      private void textMontajMiktar_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar))
         {
            if (!char.IsNumber(e.KeyChar))
            {
               e.Handled = true;
            }
         }
      }

      private void button3_Click(object sender, EventArgs e)
      {

      }

      private void button4_Click(object sender, EventArgs e)
      {
         this.Close();
      }



      private void buttonPalet_Click(object sender, EventArgs e)
      {

         seri = SeriliBarkod.Text.Trim().ToUpper();

         if (seri == "") return;

         Utility.Engine.sql = @"
                     select top 1 r.*,s.StokAdi, d.Miktar2 as AmbalajIcMiktar  
                     from  serili_barkodlar r WITH (NOLOCK) inner join stok_tanim_ust s WITH (NOLOCK)
                     on s.StokKodu=r.StokKodu 
					 inner join stok_tanim_detay d WITH(NOLOCK) ON d.StokKodu = r.StokKodu and d.Birim= r.Birim
                     where SeriliBarkod=N'" + seri+"'  order by IDS   ";

         DataTable dt = Utility.Engine.dat.TableDon(Utility.Engine.sql);

         if (dt == null || dt.Rows.Count < 1) return;


         for (int i = 0; i < dt.Columns.Count; i++)
         {
            foreach (Control c in this.Controls)
            {
               if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
               {
                  TextBox t = (TextBox)c;

                  if (t.Name == dt.Columns[i].ColumnName)
                  {
                     t.Text = dt.Rows[0][i].ToString().Trim();
                  }
               }
            }
            Utility.Engine.dat.ComboDoldur("select Birim from stok_tanim_detay (NOLOCK) where StokKodu=N'" + StokKodu.Text.Trim() + "'", comboBox1);
            labelambalajici.Text = dt.Rows[0]["AmbalajIcMiktar"].ToString().Trim();
         }

         if (
            SeriliBarkod.Text.Trim() == "" ||
            StokKodu.Text.Trim() == "" ||
            StokAdi.Text.Trim() == "" ||
            Birim.Text.Trim() == "" ||
            Miktar.Text.Trim() == ""
            )
         {
            seribilgileri = false;
         }
         else
         {
            seribilgileri = true;
            textMontajMiktar.Focus();
         }
      }

      private void textKasaNo_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == 13)
         {
            buttonPalet_Click(null, null);
         }
      }

      private void buttonKaydet_Click(object sender, EventArgs e)
      {
          if (comboBox1.Text == "")
          {
              MessageBox.Show("Birim Boş Geçilemez..!");
              return;
          }

          Utility.Engine.sql = @"exec [dbo].[seri_duzelt] N'" + seri + "',N'" + comboBox1.Text + "'," + textMontajMiktar.Text.Trim() + ", N'" + Utility.Engine.KullaniciKod + "'";

         DataTable dt = Utility.Engine.dat.TableDon(Utility.Engine.sql);

         if (dt == null || dt.Rows.Count < 1)
         {
            MessageBox.Show("Sunucun Yanit Vermedi..:" + Utility.Engine.dat.Fault, "Dikkat..!");
            return;
         }

         string str = dt.Rows[0][0].ToString().Trim();

         if (str != "OK")
         {
            MessageBox.Show("Sunucun Hata Bildirdi..:" + str + " __" + Utility.Engine.dat.Fault, "Dikkat..!");
            return;
         }

         Utility.Engine.Tamam("işlemler Tamamlandi..");

         Temizle();

      }

      private void Temizle()
      {
         foreach (Control c in this.Controls)
         {
            if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
               c.Text = "";
            }
         }
         buttonKaydet.Enabled = false;
      }

      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (StokKodu.Text != "")
         {
             labelambalajici.Text = Utility.Engine.dat.TSelectScalar("select Miktar2 from stok_tanim_detay (NOLOCK) where StokKodu=N'" + StokKodu.Text.Trim() + "' and Birim='" + comboBox1.Text + "'");
         }
      }


   }
}