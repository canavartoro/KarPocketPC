using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
   public partial class Sevkiyat : Form
   {
      public Sevkiyat()
      {
         InitializeComponent();
      }


      private void Sevkiyat_Load(object sender, EventArgs e)
      {
         Utility.Engine.KullaniciyaGoreModulAc(this);
      }

      private void button_1_Click(object sender, EventArgs e)
      {
         KUretimGiris u = new KUretimGiris();
         
         u.ShowDialog();
      }

      private void button_2_Click(object sender, EventArgs e)
      {
         SevkEmri se = new SevkEmri();
        
         se.ShowDialog();
      }

      private void button_0_Click(object sender, EventArgs e)
      {
         this.Close();
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
        else if (e.KeyValue == 51)
        {
            button1_Click(null, null);
        }
      }

       private void button1_Click(object sender, EventArgs e)
       {

           try
           {
               sek_iptal sss = new sek_iptal();
               

               sss.ShowDialog();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
   
           
       }

       private void button2_Click(object sender, EventArgs e)
       {
           MalHazirla se = new MalHazirla();
           se.ShowDialog();
       }

       private void button3_Click(object sender, EventArgs e)
       {
           Seri_duzelt sd = new Seri_duzelt();
           sd.ShowDialog();
       }

       private void btnBolunmusSevkIptal_Click(object sender, EventArgs e)
       {
           try
           {
               sek_iptal sss = new sek_iptal();
               sss.bolunmusSeriIptal = true;
               sss.ShowDialog();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
   
       }

       private void Stok_KeyDown(object sender, KeyEventArgs e)
       {

       }

       private void btnSerilerArasiTransfer_Click(object sender, EventArgs e)
       {
           try
           {
               SerilerArasiTransfer t = new SerilerArasiTransfer();
               t.ShowDialog();
           }
           catch (Exception)
           {
           }
       }
      
  
   }
}