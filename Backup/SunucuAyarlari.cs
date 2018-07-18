using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for SunucuAyarlari.
	/// </summary>
	public class SunucuAyarlari : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonCik;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox textBoxSunucuIP;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.TextBox textBoxKullanici;
		private System.Windows.Forms.TextBox textBoxParola;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button buttonKaydet;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		
		public string STR_ProgramDizini;
	
		public SunucuAyarlari()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			STR_ProgramDizini="";

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
			this.buttonCik = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.textBoxSunucuIP = new System.Windows.Forms.TextBox();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.buttonKaydet = new System.Windows.Forms.Button();
			this.textBoxKullanici = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxParola = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			// 
			// buttonCik
			// 
			this.buttonCik.Location = new System.Drawing.Point(144, 160);
			this.buttonCik.Size = new System.Drawing.Size(72, 32);
			this.buttonCik.Text = "Çik";
			this.buttonCik.Click += new System.EventHandler(this.buttonCik_Click);
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(24, 29);
			this.label.Size = new System.Drawing.Size(24, 16);
			this.label.Text = "IP:";
			this.label.ParentChanged += new System.EventHandler(this.label_ParentChanged);
			// 
			// textBoxSunucuIP
			// 
			this.textBoxSunucuIP.Location = new System.Drawing.Point(96, 27);
			this.textBoxSunucuIP.Size = new System.Drawing.Size(96, 20);
			this.textBoxSunucuIP.Text = "";
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(96, 48);
			this.textBoxPort.Size = new System.Drawing.Size(96, 20);
			this.textBoxPort.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 50);
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.Text = "Port:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(64, 16);
			this.panel1.Size = new System.Drawing.Size(160, 1);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 10);
			this.label2.Size = new System.Drawing.Size(48, 14);
			this.label2.Text = "Sunucu";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(8, 16);
			this.panel2.Size = new System.Drawing.Size(8, 1);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.Location = new System.Drawing.Point(8, 16);
			this.panel3.Size = new System.Drawing.Size(1, 128);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Black;
			this.panel4.Location = new System.Drawing.Point(8, 144);
			this.panel4.Size = new System.Drawing.Size(216, 1);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.Location = new System.Drawing.Point(224, 16);
			this.panel5.Size = new System.Drawing.Size(1, 128);
			// 
			// buttonKaydet
			// 
			this.buttonKaydet.Location = new System.Drawing.Point(24, 160);
			this.buttonKaydet.Size = new System.Drawing.Size(72, 32);
			this.buttonKaydet.Text = "Kaydet";
			this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
			// 
			// textBoxKullanici
			// 
			this.textBoxKullanici.Location = new System.Drawing.Point(96, 80);
			this.textBoxKullanici.Size = new System.Drawing.Size(96, 20);
			this.textBoxKullanici.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 82);
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.Text = "Kullanici:";
			// 
			// textBoxParola
			// 
			this.textBoxParola.Location = new System.Drawing.Point(96, 104);
			this.textBoxParola.PasswordChar = '*';
			this.textBoxParola.Size = new System.Drawing.Size(96, 20);
			this.textBoxParola.Text = "";
			this.textBoxParola.TextChanged += new System.EventHandler(this.textBoxParola_TextChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 106);
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.Text = "Parola:";
			// 
			// SunucuAyarlari
			// 
			this.ClientSize = new System.Drawing.Size(234, 296);
			this.ControlBox = false;
			this.Controls.Add(this.textBoxParola);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxKullanici);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonKaydet);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBoxPort);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxSunucuIP);
			this.Controls.Add(this.label);
			this.Controls.Add(this.buttonCik);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Text = "Sunucu   Ayarlari";
			this.Load += new System.EventHandler(this.SunucuAyarlari_Load);

		}
		#endregion

		private void label_ParentChanged(object sender, System.EventArgs e)
		{
		
		}

		private void SunucuAyarlari_Load(object sender, System.EventArgs e)
		{
			try
			{
                System.IO.StreamReader sr = new System.IO.StreamReader(@"\\srv002\pay\config.ini");
				textBoxSunucuIP.Text=sr.ReadLine();
				textBoxPort.Text=sr.ReadLine();
				textBoxKullanici.Text=sr.ReadLine();
				textBoxParola.Text=sr.ReadLine();
				sr.Close();
			}
			catch(Exception)
			{
			}
		}

		private void buttonKaydet_Click(object sender, System.EventArgs e)
		{
			System.IO.StreamWriter sw=null;

			try
			{
                sw = new System.IO.StreamWriter(@"\\srv002\pay\config.ini", false);
				sw.WriteLine(textBoxSunucuIP.Text);
				sw.WriteLine(textBoxPort.Text);
				sw.WriteLine(textBoxKullanici.Text);
				sw.WriteLine(textBoxParola.Text);
				sw.Close();
			}
			catch(Exception)
			{
				if(sw!=null)
					sw.Close();
			}
			this.DialogResult=DialogResult.OK;
			Close();
		}

		private void buttonCik_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
			Close();
		}

		private void textBoxParola_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
