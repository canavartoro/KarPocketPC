using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
   public partial class MontajIslemleri : Form
   {
      public MontajIslemleri()
      {
         InitializeComponent();
      }




      private void MontajIslemleri_Load(object sender, EventArgs e)
      {
         Utility.Engine.KullaniciyaGoreModulAc(this);
      }

      private void mmmm(object sender, KeyEventArgs e)
      {
           if (e.KeyValue == 48 && button_0.Visible)
                button_0_Click(null, null);
            if (e.KeyValue == 49 && button_8.Visible)
                button_8_Click(null, null);
             if (e.KeyValue == 50 && button_9.Visible)
                button_9_Click(null, null);
      }

      private void button_0_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void button_8_Click(object sender, EventArgs e)
      {
         KasaAktarma k = new KasaAktarma();
         
         k.ShowDialog();
      }

      private void button_9_Click(object sender, EventArgs e)
      {
         MontajYap my = new MontajYap();
         my.ShowDialog();
      }

      
   }
}