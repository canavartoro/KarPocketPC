using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
   public partial class URETIM : Form
   {
      public URETIM()
      {
         InitializeComponent();
      }

      private void URETIM_Load(object sender, EventArgs e)
      {
         Utility.Engine.KullaniciyaGoreModulAc(this);
      }

      private void button_0_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void button_1_Click(object sender, EventArgs e)
      {
         UretimGirisi giris = new UretimGirisi();
         
         giris.ShowDialog();
      }

      private void button_2_Click(object sender, EventArgs e)
      {
         KUretimGiris u = new KUretimGiris();
       
         u.ShowDialog();
      }

      private void mmm(object sender, KeyEventArgs e)
      {
         if (e.KeyValue == 48)
         {
            button_0_Click(null, null);
         }
         else if (e.KeyValue == 49)
         {
            button_1_Click(null, null);
         }
         else if (e.KeyValue == 50)
         {
            button_2_Click(null, null);
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         KavisIcin k = new KavisIcin();         
         k.ShowDialog();
      }

       private void button2_Click(object sender, EventArgs e)
       {
           UretimGirisi giris = new UretimGirisi();
           giris.UretimUpdate = true;
          
           giris.ShowDialog();
       }

       private void buttonDurus_Click(object sender, EventArgs e)
       {
           FormDurus dur = new FormDurus();
           dur.ShowDialog();
       }

       private void button3_Click(object sender, EventArgs e)
       {
           FormFire fir = new FormFire();
           fir.ShowDialog();
       }

       private void button4_Click(object sender, EventArgs e)
       {
           IsEmriAtama isata = new IsEmriAtama();
           isata.ShowDialog();
       }

       private void button5_Click(object sender, EventArgs e)
       {
           PersonelAtama ata = new PersonelAtama();
           ata.ShowDialog();
       }

       private void button6_Click(object sender, EventArgs e)
       {
           KavisIcin k = new KavisIcin();
           k.Text = "Genel Üretim";
           k.ShowDialog();
       }

       private void button7_Click(object sender, EventArgs e)
       {
           FormHammadde Hm = new FormHammadde();
           Hm.ShowDialog();
       }

       private void button8_Click(object sender, EventArgs e)
       {
           PersonelDevir Dvr = new PersonelDevir();
           Dvr.ShowDialog();
       }
   }
}