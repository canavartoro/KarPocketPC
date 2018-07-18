using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
   public partial class StokD : Form
   {
      public StokD()
      {
         InitializeComponent();
      }


      private void button_1_Click(object sender, EventArgs e)
      {
       
      }

      private void button_2_Click(object sender, EventArgs e)
      {
         SeriliTransfer st = new SeriliTransfer();
         st.ShowDialog();
      }

      private void button_3_Click(object sender, EventArgs e)
      {
         AmbarSayim say = new AmbarSayim();
         say.ShowDialog();
      }

      private void button_4_Click(object sender, EventArgs e)
      {
         DepoStok ds = new DepoStok();
         ds.ShowDialog();
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
            button_3_Click(null, null);
         }
         else if (e.KeyValue == 52)
         {
            button_4_Click(null, null);
         }
      }

      private void StokD_Load(object sender, EventArgs e)
      {
         Utility.Engine.KullaniciyaGoreModulAc(this);
      }
     
   }
}