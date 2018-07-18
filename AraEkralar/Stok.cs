#define CASIO
using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for Stok.
	/// </summary>
	///
	public class Stok : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Button button_0;
		private System.Windows.Forms.Button button_1;

#if CASIO

        private Button button_3;
      private Button button_6;
      private Button button_2;
      private Button button_4;
      private Button button_5;
        private Button button_7;
        private Button button1;
		
#endif

		//public Engine Utility.Engine;
		public Stok()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(26, 251);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(193, 23);
            this.button_0.TabIndex = 8;
            this.button_0.Text = "ÇIK(0)";
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            this.button_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(26, 2);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(193, 24);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "ÜRETİM GİRİŞİ(1)";
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            this.button_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(26, 61);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(193, 24);
            this.button_3.TabIndex = 9;
            this.button_3.Text = "MONTAJ(3)";
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            this.button_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(26, 151);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(193, 24);
            this.button_6.TabIndex = 10;
            this.button_6.Text = "TİCARİ ÜRÜN PAKET(6)";
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            this.button_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(26, 31);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(193, 24);
            this.button_2.TabIndex = 11;
            this.button_2.Text = "SERİLER ARASI TRANSFER(2)";
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            this.button_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(26, 91);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(193, 24);
            this.button_4.TabIndex = 12;
            this.button_4.Text = "KAVİS(4)";
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            this.button_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(26, 121);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(193, 24);
            this.button_5.TabIndex = 13;
            this.button_5.Text = "PALET TRANSFER(5)";
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            this.button_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(26, 181);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(193, 24);
            this.button_7.TabIndex = 14;
            this.button_7.Text = "MONTAJ SAYIM(7)";
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            this.button_7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mmmm);
            this.button_7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 24);
            this.button1.TabIndex = 15;
            this.button1.Text = "PAKETLEME(8)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
            // 
            // Stok
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_1);
            this.Name = "Stok";
            this.Text = "Ambalaj";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stok_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
            this.ResumeLayout(false);

		}
		#endregion

		private void Stok_Load(object sender, System.EventArgs e)
		{
			//button_8.Enabled = Utility.Engine.SayimAcik();

            Utility.Engine.KullaniciyaGoreModulAc(this);
                        
		}

		private void button_0_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void button_6_Click(object sender, System.EventArgs e)
		{
         TicUrunPaket t = new TicUrunPaket();
         t.ShowDialog();
		}

		private void button_8_Click(object sender, System.EventArgs e)
		{
			
		}

		private void button_2_Click(object sender, System.EventArgs e)
		{
         SerilerArasiTransfer t = new SerilerArasiTransfer();
         t.ShowDialog();       
		}

		private void button_1_Click(object sender, System.EventArgs e)
        {
            UretimGirisi giris = new UretimGirisi();
            giris.ShowDialog();               

		}

        private void button_5_Click(object sender, System.EventArgs e)
        {            
            KUretimGiris u = new KUretimGiris();
            u.ShowDialog();
        }

      private void button_3_Click(object sender, EventArgs e)
      {
         MontajIslemleri mler = new MontajIslemleri();
         mler.ShowDialog();
      }

        private void mmmm(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 48 && button_0.Visible)
                button_0_Click(null, null);
            if (e.KeyValue == 49 && button_1.Visible)
                button_1_Click(null, null);
            if (e.KeyValue == 50 && button_2.Visible)
                button_2_Click(null, null);
            if (e.KeyValue == 51 && button_3.Visible)
                button_3_Click(null, null);
            if (e.KeyValue == 52 && button_4.Visible)
                button_4_Click(null, null);
            if (e.KeyValue == 53 && button_5.Visible)
                button_5_Click(null, null);
             if (e.KeyValue == 54 && button_6.Visible)
                button_6_Click(null, null);
            if (e.KeyValue == 55 && button_7.Visible)
                button_7_Click(null, null);
            if (e.KeyValue == 56 && button1.Visible)
                button1_Click(null, null);

            //if (e.KeyValue == 56 && button_8.Visible)
            //    button_8_Click(null, null);
            // if (e.KeyValue == 57 && button_3.Visible)
            //    button_9_Click(null, null);
            // if (e.KeyValue == 58 && button_3.Visible)
            //    button_10_Click(null, null);

        }

        private void button_4_Click(object sender, EventArgs e)
        {
            KavisLe k = new KavisLe();
            k.ShowDialog();
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            Ekle ek = new Ekle();
            ek.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pakeleme_2 paket = new pakeleme_2();
            paket.Show();
        }

        private void Stok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D9)
            {
                Utility.HELPME.Show("Stok");
            }
        }                         
	}
}
