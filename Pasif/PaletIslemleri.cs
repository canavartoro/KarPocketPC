#define CASIO
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for PaletIslemleri.
	/// </summary>
	public class PaletIslemleri : System.Windows.Forms.Form
	{
#if CASIO
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
#endif

		private System.Windows.Forms.Button button_0;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button_1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button_2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.PictureBox pictureBox8;
        private Button button_3;
        private Button button_5;
        private PictureBox pictureBox4;
        private Button button_4;
        private PictureBox pictureBox9;
        private Button button_6;
        private PictureBox pictureBox10;
        private Button button_7;
        private PictureBox pictureBox11;
		

		//public Engine Utility.Engine;
	
		public PaletIslemleri()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletIslemleri));
            this.button_0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button_4 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.button_6 = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.button_7 = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(56, 256);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(168, 24);
            this.button_0.TabIndex = 3;
            this.button_0.Text = "ÇIK (0)";
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            this.button_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 24);
            this.button1.TabIndex = 8;
            this.button1.TabStop = false;
            this.button1.Text = "YENI PALET (1)";
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(43, 14);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(186, 24);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "Seriler Arasi Aktarma(1)";
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            this.button_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(427, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 24);
            this.button3.TabIndex = 10;
            this.button3.TabStop = false;
            this.button3.Text = "HIZLI TRANSFER (4)";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(43, 44);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(186, 24);
            this.button_2.TabIndex = 1;
            this.button_2.Text = "Palet Transfer(2)";
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            this.button_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(427, 320);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 24);
            this.button6.TabIndex = 12;
            this.button6.TabStop = false;
            this.button6.Text = "MAMUL ETIKET (5)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(379, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 44);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(379, 320);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(8, 256);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(427, 352);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 24);
            this.button7.TabIndex = 13;
            this.button7.TabStop = false;
            this.button7.Text = "STOK DONUSUM (6)";
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(8, 74);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(43, 74);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(186, 24);
            this.button_3.TabIndex = 2;
            this.button_3.Text = "Boş Palet Transfer(3)";
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            this.button_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(43, 134);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(186, 24);
            this.button_5.TabIndex = 16;
            this.button_5.Text = "Kasadan Çikartma(5)";
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            this.button_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 134);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(43, 104);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(186, 24);
            this.button_4.TabIndex = 19;
            this.button_4.Text = "Kasaya Ekleme(4)";
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            this.button_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(8, 104);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 24);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(43, 164);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(186, 24);
            this.button_6.TabIndex = 32;
            this.button_6.Text = "Kasadan Depoya Çikiş(6)";
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            this.button_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(8, 164);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 24);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(43, 194);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(186, 24);
            this.button_7.TabIndex = 31;
            this.button_7.Text = "Depodan Kasaya Ekle(7)";
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            this.button_7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(8, 194);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 24);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // PaletIslemleri
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaletIslemleri";
            this.Text = "PaletIslemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaletIslemleri_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void button_0_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			YeniPalet p = new YeniPalet();
			p.ShowDialog();
		}

		private void button_2_Click(object sender, System.EventArgs e)
		{
			KUretimGiris u = new KUretimGiris();
			u.ShowDialog();
		}

		private void button_1_Click(object sender, System.EventArgs e)
		{
			SerilerArasiTransfer t = new SerilerArasiTransfer();
			t.ShowDialog();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			UretimCikis c = new UretimCikis();
			c.ShowDialog();
		}

		

		private void button7_Click(object sender, System.EventArgs e)
		{
			StokDonusum sd = new StokDonusum();
			sd.ShowDialog();
		}

        private void PaletIslemleri_Load(object sender, EventArgs e)
        {
            Utility.Engine.KullaniciyaGoreModulAc(this);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            BosPaletTrans bt = new BosPaletTrans();
            bt.ShowDialog();
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            PaletTrans2 p2 = new PaletTrans2();
            p2.ShowDialog();
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            PaletTrans1 p1 = new PaletTrans1();
            p1.ShowDialog();
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            KasadanDepoya kd = new KasadanDepoya();
            kd.ShowDialog();
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            
            KasadanDepoyacik kd = new KasadanDepoyacik();
            kd.ShowDialog();
        }

        private void mmm(object sender, KeyEventArgs e)
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
        }      
	}
}
