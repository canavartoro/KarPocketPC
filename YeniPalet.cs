using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for YeniPalet.
	/// </summary>
	public class YeniPalet : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxDepo;
		private System.Windows.Forms.Button buttonDepo;
		private System.Windows.Forms.Button buttonDepoSil;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.TextBox textBoxSeriliBarkod;
		private System.Windows.Forms.Button buttonSeriliBarkod;
		private System.Windows.Forms.Button buttonSeriliBarkodSil;
		private System.Windows.Forms.Button buttonYeniPalet;
		private System.Windows.Forms.ComboBox comboBoxEkleSil;
		private System.Windows.Forms.Panel panelCari;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCari;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxCariAdi;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxMarka;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxMarkaAdi;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxStokKodu;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxStokAdi;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxBirim;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.NumericUpDown numericUpDownMiktar;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.TextBox textBoxBarkod;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;

		//public Engine Utility.Engine;
	
		public YeniPalet()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(YeniPalet));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxSeriliBarkod = new System.Windows.Forms.TextBox();
			this.buttonSeriliBarkod = new System.Windows.Forms.Button();
			this.buttonSeriliBarkodSil = new System.Windows.Forms.Button();
			this.buttonYeniPalet = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxDepo = new System.Windows.Forms.TextBox();
			this.buttonDepo = new System.Windows.Forms.Button();
			this.buttonDepoSil = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.comboBoxEkleSil = new System.Windows.Forms.ComboBox();
			this.panelCari = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxCari = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxCariAdi = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxMarka = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxMarkaAdi = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxStokKodu = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxStokAdi = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxBirim = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.numericUpDownMiktar = new System.Windows.Forms.NumericUpDown();
			this.button11 = new System.Windows.Forms.Button();
			this.textBoxBarkod = new System.Windows.Forms.TextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.textBoxStokKodu);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.textBoxStokAdi);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.textBoxBirim);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.buttonYeniPalet);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBoxCariAdi);
			this.panel1.Controls.Add(this.textBoxCari);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.buttonDepoSil);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBoxDepo);
			this.panel1.Controls.Add(this.buttonDepo);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.textBoxMarkaAdi);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.textBoxMarka);
			this.panel1.Controls.Add(this.numericUpDownMiktar);
			this.panel1.Controls.Add(this.button11);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Size = new System.Drawing.Size(224, 272);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.Text = "Seri Bar.";
			// 
			// textBoxSeriliBarkod
			// 
			this.textBoxSeriliBarkod.BackColor = System.Drawing.Color.Salmon;
			this.textBoxSeriliBarkod.Location = new System.Drawing.Point(64, 72);
			this.textBoxSeriliBarkod.Text = "";
			this.textBoxSeriliBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSeriliBarkod_KeyPress);
			// 
			// buttonSeriliBarkod
			// 
			this.buttonSeriliBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonSeriliBarkod.Location = new System.Drawing.Point(160, 72);
			this.buttonSeriliBarkod.Size = new System.Drawing.Size(32, 20);
			this.buttonSeriliBarkod.Text = ">>";
			this.buttonSeriliBarkod.Click += new System.EventHandler(this.buttonSeriliBarkod_Click);
			// 
			// buttonSeriliBarkodSil
			// 
			this.buttonSeriliBarkodSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonSeriliBarkodSil.Location = new System.Drawing.Point(192, 72);
			this.buttonSeriliBarkodSil.Size = new System.Drawing.Size(32, 20);
			this.buttonSeriliBarkodSil.Text = "X";
			this.buttonSeriliBarkodSil.Click += new System.EventHandler(this.buttonSeriliBarkodSil_Click);
			// 
			// buttonYeniPalet
			// 
			this.buttonYeniPalet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonYeniPalet.Location = new System.Drawing.Point(120, 224);
			this.buttonYeniPalet.Size = new System.Drawing.Size(96, 32);
			this.buttonYeniPalet.Text = "KAYDET";
			this.buttonYeniPalet.Click += new System.EventHandler(this.buttonYeniPalet_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.Text = "Depo";
			// 
			// textBoxDepo
			// 
			this.textBoxDepo.BackColor = System.Drawing.Color.White;
			this.textBoxDepo.Location = new System.Drawing.Point(56, 8);
			this.textBoxDepo.ReadOnly = true;
			this.textBoxDepo.Size = new System.Drawing.Size(96, 20);
			this.textBoxDepo.Text = "";
			this.textBoxDepo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAtaKasa_KeyPress);
			// 
			// buttonDepo
			// 
			this.buttonDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonDepo.Location = new System.Drawing.Point(152, 8);
			this.buttonDepo.Size = new System.Drawing.Size(32, 20);
			this.buttonDepo.Text = "...";
			this.buttonDepo.Click += new System.EventHandler(this.buttonDepo_Click);
			// 
			// buttonDepoSil
			// 
			this.buttonDepoSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonDepoSil.Location = new System.Drawing.Point(184, 8);
			this.buttonDepoSil.Size = new System.Drawing.Size(32, 20);
			this.buttonDepoSil.Text = "X";
			this.buttonDepoSil.Click += new System.EventHandler(this.buttonDepoSil_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.Add(this.columnHeader1);
			this.listView1.Columns.Add(this.columnHeader2);
			this.listView1.Columns.Add(this.columnHeader3);
			this.listView1.Columns.Add(this.columnHeader4);
			this.listView1.Columns.Add(this.columnHeader5);
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(584, 176);
			this.listView1.Size = new System.Drawing.Size(224, 208);
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "SeriliBarkod";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "StokAdi";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "StokKodu";
			this.columnHeader3.Width = 60;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Birim";
			this.columnHeader4.Width = 60;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Miktar";
			this.columnHeader5.Width = 60;
			// 
			// comboBoxEkleSil
			// 
			this.comboBoxEkleSil.Items.Add("EKLE");
			this.comboBoxEkleSil.Items.Add("SIL");
			this.comboBoxEkleSil.Location = new System.Drawing.Point(672, 72);
			this.comboBoxEkleSil.Size = new System.Drawing.Size(64, 21);
			this.comboBoxEkleSil.SelectedIndexChanged += new System.EventHandler(this.comboBoxEkleSil_SelectedIndexChanged);
			// 
			// panelCari
			// 
			this.panelCari.BackColor = System.Drawing.Color.Silver;
			this.panelCari.Controls.Add(this.button3);
			this.panelCari.Controls.Add(this.button4);
			this.panelCari.Controls.Add(this.label6);
			this.panelCari.Controls.Add(this.label3);
			this.panelCari.Controls.Add(this.textBoxSeriliBarkod);
			this.panelCari.Controls.Add(this.buttonSeriliBarkod);
			this.panelCari.Controls.Add(this.buttonSeriliBarkodSil);
			this.panelCari.Controls.Add(this.numericUpDown1);
			this.panelCari.Controls.Add(this.label1);
			this.panelCari.Location = new System.Drawing.Point(232, 8);
			this.panelCari.Size = new System.Drawing.Size(224, 272);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(184, 104);
			this.button1.Size = new System.Drawing.Size(32, 20);
			this.button1.Text = "X";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(152, 104);
			this.button2.Size = new System.Drawing.Size(32, 20);
			this.button2.Text = "..";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 104);
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.Text = "Cari";
			// 
			// textBoxCari
			// 
			this.textBoxCari.BackColor = System.Drawing.Color.White;
			this.textBoxCari.Location = new System.Drawing.Point(56, 104);
			this.textBoxCari.ReadOnly = true;
			this.textBoxCari.Size = new System.Drawing.Size(96, 20);
			this.textBoxCari.Text = "";
			this.textBoxCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAtaKasa_KeyPress);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(8, 168);
			this.button3.Size = new System.Drawing.Size(208, 40);
			this.button3.Text = "TAMAM";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button4.Location = new System.Drawing.Point(8, 216);
			this.button4.Size = new System.Drawing.Size(208, 40);
			this.button4.Text = "VAZGEC";
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 128);
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.Text = "Adi";
			// 
			// textBoxCariAdi
			// 
			this.textBoxCariAdi.BackColor = System.Drawing.Color.White;
			this.textBoxCariAdi.Location = new System.Drawing.Point(56, 128);
			this.textBoxCariAdi.ReadOnly = true;
			this.textBoxCariAdi.Size = new System.Drawing.Size(160, 20);
			this.textBoxCariAdi.Text = "";
			this.textBoxCariAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAtaKasa_KeyPress);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(16, 8);
			this.label6.Size = new System.Drawing.Size(200, 16);
			this.label6.Text = "Cari Kodu";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBoxMarka
			// 
			this.textBoxMarka.BackColor = System.Drawing.Color.White;
			this.textBoxMarka.Location = new System.Drawing.Point(56, 152);
			this.textBoxMarka.ReadOnly = true;
			this.textBoxMarka.Size = new System.Drawing.Size(96, 20);
			this.textBoxMarka.Text = "";
			this.textBoxMarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAtaKasa_KeyPress);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button5.Location = new System.Drawing.Point(152, 152);
			this.button5.Size = new System.Drawing.Size(32, 20);
			this.button5.Text = "...";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button6.Location = new System.Drawing.Point(184, 152);
			this.button6.Size = new System.Drawing.Size(32, 20);
			this.button6.Text = "X";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 144);
			this.label7.Size = new System.Drawing.Size(40, 16);
			this.label7.Text = "Marka";
			// 
			// textBoxMarkaAdi
			// 
			this.textBoxMarkaAdi.BackColor = System.Drawing.Color.White;
			this.textBoxMarkaAdi.Location = new System.Drawing.Point(56, 176);
			this.textBoxMarkaAdi.ReadOnly = true;
			this.textBoxMarkaAdi.Size = new System.Drawing.Size(160, 20);
			this.textBoxMarkaAdi.Text = "";
			this.textBoxMarkaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAtaKasa_KeyPress);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 168);
			this.label8.Size = new System.Drawing.Size(40, 16);
			this.label8.Text = "Marka";
			// 
			// textBoxStokKodu
			// 
			this.textBoxStokKodu.BackColor = System.Drawing.Color.White;
			this.textBoxStokKodu.Location = new System.Drawing.Point(56, 32);
			this.textBoxStokKodu.ReadOnly = true;
			this.textBoxStokKodu.Size = new System.Drawing.Size(96, 20);
			this.textBoxStokKodu.Text = "";
			this.textBoxStokKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAtaKasa_KeyPress);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(0, 32);
			this.label9.Size = new System.Drawing.Size(56, 16);
			this.label9.Text = "StokKodu";
			// 
			// textBoxStokAdi
			// 
			this.textBoxStokAdi.BackColor = System.Drawing.Color.White;
			this.textBoxStokAdi.Location = new System.Drawing.Point(56, 56);
			this.textBoxStokAdi.ReadOnly = true;
			this.textBoxStokAdi.Size = new System.Drawing.Size(160, 20);
			this.textBoxStokAdi.Text = "";
			this.textBoxStokAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAtaKasa_KeyPress);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(0, 56);
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.Text = "StokAdi";
			// 
			// textBoxBirim
			// 
			this.textBoxBirim.BackColor = System.Drawing.Color.White;
			this.textBoxBirim.Location = new System.Drawing.Point(56, 80);
			this.textBoxBirim.ReadOnly = true;
			this.textBoxBirim.Size = new System.Drawing.Size(72, 20);
			this.textBoxBirim.Text = "";
			this.textBoxBirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAtaKasa_KeyPress);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(0, 80);
			this.label11.Size = new System.Drawing.Size(56, 16);
			this.label11.Text = "Birim/Mik";
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button7.Location = new System.Drawing.Point(152, 32);
			this.button7.Size = new System.Drawing.Size(32, 20);
			this.button7.Text = "..";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button8.Location = new System.Drawing.Point(184, 32);
			this.button8.Size = new System.Drawing.Size(32, 20);
			this.button8.Text = "X";
			// 
			// numericUpDownMiktar
			// 
			this.numericUpDownMiktar.Location = new System.Drawing.Point(128, 80);
			this.numericUpDownMiktar.Maximum = new System.Decimal(new int[] {
																				2500,
																				0,
																				0,
																				0});
			this.numericUpDownMiktar.Minimum = new System.Decimal(new int[] {
																				1,
																				0,
																				0,
																				0});
			this.numericUpDownMiktar.Size = new System.Drawing.Size(88, 20);
			this.numericUpDownMiktar.Value = new System.Decimal(new int[] {
																			  1,
																			  0,
																			  0,
																			  0});
			// 
			// button11
			// 
			this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button11.Location = new System.Drawing.Point(16, 224);
			this.button11.Size = new System.Drawing.Size(96, 32);
			this.button11.Text = "ATAKASA";
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// textBoxBarkod
			// 
			this.textBoxBarkod.BackColor = System.Drawing.Color.White;
			this.textBoxBarkod.Location = new System.Drawing.Point(432, 376);
			this.textBoxBarkod.ReadOnly = true;
			this.textBoxBarkod.Size = new System.Drawing.Size(96, 20);
			this.textBoxBarkod.Text = "";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Enabled = false;
			this.numericUpDown1.Location = new System.Drawing.Point(64, 104);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   2500,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Size = new System.Drawing.Size(96, 20);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 104);
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.Text = "Seri Mik";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(56, 200);
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(160, 20);
			this.textBox1.Text = "";
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAtaKasa_KeyPress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			// 
			// YeniPalet
			// 
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(808, 448);
			this.Controls.Add(this.textBoxBarkod);
			this.Controls.Add(this.panelCari);
			this.Controls.Add(this.comboBoxEkleSil);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Text = "Yeni Palet Islemleri";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.YeniPalet_Load);

		}
		#endregion
		private void Temizle()
		{
			foreach(Control c in panel1.Controls)
			{
				if(c.GetType().ToString() == "System.Windows.Forms.TextBox")
				{
					TextBox t = (TextBox)c;
					t.Text = "";
				}
			}

			textBoxDepo.Text = "";
			textBoxSeriliBarkod.Text = "";
			listView1.Items.Clear();
			return;
		}
		private void Detaylar()
		{
			try
			{
				listView1.Items.Clear();
				IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);
				if(dr != null)
				{
					while(dr.Read())
					{
						ListViewItem item = new ListViewItem();
						item.Text = dr.GetValue(0).ToString();
						item.SubItems.Add(dr.GetValue(2).ToString());
						item.SubItems.Add(dr.GetValue(1).ToString());
						item.SubItems.Add(dr.GetValue(3).ToString());
						item.SubItems.Add(dr.GetValue(4).ToString());
						listView1.Items.Add(item);
					}

					if(dr != null)dr.Close();
				}
				if(dr != null)
					dr.Close();
				this.Text = "Yeni Palet Islemleri " + listView1.Items.Count.ToString();
				return;
			}
			catch
			{
				return;
			}
		}
		private void button4_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Detaylar(bool show)
		{
			panelCari.Location = new Point(8, 8);
			panelCari.BringToFront();
			panelCari.Visible = show;
			return;
		}

		private void buttonYeniPalet_Click(object sender, System.EventArgs e)
		{
			if(textBoxDepo.Text.Length < 1)
			{
				Utility.Engine.Hata("Depo Kodu Bos Olamaz!");
				return;
			}

			if(textBoxStokKodu.Text.Length < 1)
			{
				Utility.Engine.Hata("Stok Kodu Bos Olamaz!");
				return;
			}

			if(textBoxBirim.Text.Length < 1)
			{
				Utility.Engine.Hata("Stok Birimi Bos Olamaz!");
				return;
			}

			if(MessageBox.Show("Yapilan Islemler Kaydedilecek Onayliyormusunuz?","Dikkat!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.No)return;

			#region olandan al
			if(textBoxSeriliBarkod.Text.Length > 0)
			{
				if(numericUpDownMiktar.Value >= numericUpDown1.Value)
				{
					Utility.Engine.Hata("Bolunen Palet Miktari Asilamaz!");
					return;
				}

				string seri = "",seri2 = "";

				try
				{
					seri = Utility.Engine.dat.TSelectScalar("exec dbo.SeriAl2");
				}
				catch (Exception ex)
				{
					Utility.Engine.Hata("Sistemden Seri Cekilemedi.");
					return;
				}

				if (seri.Length < 7)
				{
					Utility.Engine.Hata("Seri Baslangicinda Hata Var.");
					return;
				}

				seri2 = Utility.Engine.SqlTemizle(textBoxStokKodu.Text).Trim() + seri;

				Utility.Engine.sql = "INSERT INTO serili_barkodlar (SeriliBarkod, StokKodu, Birim, Miktar, Tarih, Saat, KullaniciID, IsEmri, Aktarildi, PaletID, OzelKod, CariKodu, AtaKasa ) ";
				Utility.Engine.sql += " VALUES ('";
				Utility.Engine.sql += seri2.ToUpper(); Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxStokKodu.Text); Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxBirim.Text); Utility.Engine.sql += "','";
				Utility.Engine.sql += Convert.ToInt32(numericUpDownMiktar.Value).ToString(); Utility.Engine.sql += "',GETDATE(),'";
				Utility.Engine.sql += DateTime.Now.ToString("HH:mm"); Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.KullaniciID; Utility.Engine.sql += "','','H',";
				Utility.Engine.sql += "0";
				Utility.Engine.sql += ",'";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxMarka.Text);
				Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxCari.Text);
				Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxSeriliBarkod.Text).ToUpper();
				Utility.Engine.sql += ",";
				Utility.Engine.sql += Convert.ToInt32(numericUpDownMiktar.Value).ToString();
				Utility.Engine.sql += "')";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit Hatasi<Serili Barkod>:" + Utility.Engine.dat.STR_HataMesaji);
					return;
				}

				Utility.Engine.sql = "INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod,IslemTarihi) VALUES('";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxDepo.Text);
				Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxStokKodu.Text) + "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxBirim.Text) + "','";
				Utility.Engine.sql += Convert.ToInt32(numericUpDownMiktar.Value).ToString() +"','";
				Utility.Engine.sql += seri2.ToUpper() + "',GETDATE())";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit Hatasi<Depo Mevcut>:" + Utility.Engine.dat.STR_HataMesaji);
					return;
				}

				Utility.Engine.sql = "UPDATE serili_barkodlar SET Miktar = Miktar - ";
				Utility.Engine.sql += Convert.ToInt32(numericUpDownMiktar.Value).ToString();
				Utility.Engine.sql += " WHERE SeriliBarkod = '";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxSeriliBarkod.Text).ToUpper();
				Utility.Engine.sql += "' ";
				Utility.Engine.sql += " ; UPDATE depo_mevcut SET Miktar = Miktar - ";
				Utility.Engine.sql += Convert.ToInt32(numericUpDownMiktar.Value).ToString();
				Utility.Engine.sql += " WHERE SeriliBarkod = '";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxSeriliBarkod.Text).ToUpper();
				Utility.Engine.sql += "' ";


				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Seriler Guncellenemedi! Serileri Kontrol Edin!!");
					return;
				}


				Utility.Engine.Tamam(seri2 + "` Islem Tamamlandi.");
				textBox1.Text = seri2;
			}
			#endregion

			
			

				#region yeni uret a.qoy
			else
			{
				string seri = "",seri2 = "";

				try
				{
					seri = Utility.Engine.dat.TSelectScalar("exec dbo.SeriAl2");
				}
				catch (Exception ex)
				{
					Utility.Engine.Hata("Sistemden Seri Cekilemedi.");
					return;
				}

				if (seri.Length < 7)
				{
					Utility.Engine.Hata("Seri Baslangicinda Hata Var.");
					return;
				}

				seri2 = Utility.Engine.SqlTemizle(textBoxStokKodu.Text).Trim() + seri;

				Utility.Engine.sql = "INSERT INTO serili_barkodlar (SeriliBarkod, StokKodu, Birim, Miktar, Tarih, Saat, KullaniciID, IsEmri, Aktarildi, PaletID, OzelKod, CariKodu, AtaKasa ) ";
				Utility.Engine.sql += " VALUES ('";
				Utility.Engine.sql += seri2.ToUpper(); Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxStokKodu.Text); Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxBirim.Text); Utility.Engine.sql += "','";
				Utility.Engine.sql += Convert.ToInt32(numericUpDownMiktar.Value).ToString(); Utility.Engine.sql += "',GETDATE(),'";
				Utility.Engine.sql += DateTime.Now.ToString("HH:mm"); Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.KullaniciID; Utility.Engine.sql += "','','H',";
				Utility.Engine.sql += "0";
				Utility.Engine.sql += ",'";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxMarka.Text);
				Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxCari.Text);
				Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxSeriliBarkod.Text).ToUpper();
				Utility.Engine.sql += ",";
				Utility.Engine.sql += Convert.ToInt32(numericUpDownMiktar.Value).ToString();
				Utility.Engine.sql += "')";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit Hatasi:" + Utility.Engine.dat.STR_HataMesaji);
					return;
				}

				Utility.Engine.sql = "INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod,IslemTarihi) VALUES('";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxDepo.Text);
				Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxStokKodu.Text) + "','";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxBirim.Text) + "','";
				Utility.Engine.sql += Convert.ToInt32(numericUpDownMiktar.Value).ToString() +"','";
				Utility.Engine.sql += seri2.ToUpper() + "',GETDATE())";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit Hatasi<Depo Mevcut>:" + Utility.Engine.dat.STR_HataMesaji);
					return;
				}

				AmbarPC.Fis fis = new AmbarPC.Fis();
				fis.Aciklama1 = "Uretim Girisi ";
				fis.GirenDepo = "GIRIS";
				fis.HareketKodu = "URETIM GIRIS";
				fis.HareketOzel = "";
				fis.HareketTipi = "Serili Stok Transferi";
				fis.CariKod = textBoxCari.Text;
				fis.Tarih = DateTime.Now.ToString("yyyy-MM-dd");
				fis.Saat = DateTime.Now.ToString("HH:mm");
				fis.HareketKodu = "URETIM GIRIS";
				
				if(!fis.MalKabul(Utility.Engine.SqlTemizle(seri2),Utility.Engine.SqlTemizle(textBoxDepo.Text)))
				{
					Utility.Engine.Hata("Mal Kabul Fisi Kaydedilemedi:" + fis.HataMesaji);
					buttonOK_Click(null,null);
					return;
				}

				MessageBox.Show(fis.BelgeNo.ToString() + " nolu Fis Kaydedildi=" + seri2,"Tamam",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
				return;

				Utility.Engine.Tamam(seri2 + "` Islem Tamamlandi.");
				textBox1.Text = seri2;
			}
			#endregion

		}

		private void textBoxSeriliBarkod_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			try
			{
				if(e.KeyChar == 13)
				{
					Detaylar(false);
					Utility.Engine.sql = string.Format("EXEC dbo.YeniPaletSeriBul '{0}'",Utility.Engine.SqlTemizle(textBoxSeriliBarkod.Text).Trim());

					IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);

					string stok = "" , stokadi = "",miktar = "",depo = "";

					if(dr != null && dr.Read())
					{
						if (dr["StokKodu"] != DBNull.Value)
						{
							stok = dr["StokKodu"].ToString();
							textBoxStokKodu.Text = dr["StokKodu"].ToString();
						}

						if (dr["StokAdi"] != DBNull.Value)
						{
							stokadi = dr["StokAdi"].ToString();
							textBoxStokAdi.Text = dr["StokAdi"].ToString();
						}

						if (dr["Miktar"] != DBNull.Value)
						{
							miktar = dr["Miktar"].ToString();
						}

						if (dr["DepoKodu"] != DBNull.Value)
						{
							depo = dr["DepoKodu"].ToString();
							textBoxDepo.Text = depo;
						}

						if (dr["Birim"] != DBNull.Value)
						{
							textBoxBirim.Text = dr["Birim"].ToString();
						}

						if (dr["CariKodu"] != DBNull.Value)
						{
							textBoxCari.Text = dr["CariKodu"].ToString();
						}

						if (dr["CariAdi"] != DBNull.Value)
						{
							textBoxCariAdi.Text = dr["CariAdi"].ToString();
						}

						if (dr["MarkaKodu"] != DBNull.Value)
						{
							textBoxMarka.Text = dr["MarkaKodu"].ToString();
						}

						if (dr["MarkaAdi"] != DBNull.Value)
						{
							textBoxMarkaAdi.Text = dr["MarkaAdi"].ToString();
						}

						if(dr != null)dr.Close();

						if(stok.Equals("hata"))
						{
							Utility.Engine.Hata(stokadi);
							textBoxSeriliBarkod.Text = "";
							textBoxSeriliBarkod.Focus();
							return;
						}
						else
						{
							try
							{
								numericUpDownMiktar.Maximum = Decimal.Parse(miktar.Trim());
								numericUpDown1.Value = Decimal.Parse(miktar.Trim());
								textBoxStokKodu.Text = stok;
								textBoxStokAdi.Text = stokadi;
							}
							catch(Exception exc)
							{
								Utility.Engine.Hata("Stok Birim Miktarinda Hata:" + miktar);
								textBoxSeriliBarkod.Text = "";
								textBoxSeriliBarkod.Focus();
								return;
							}
						}
					}
					if(dr != null)dr.Close();
				}
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Genel Hata:" + exc.Message);
				return;
			}
		}

		private void textBoxBarkod_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
				try
				{
					if(textBoxBarkod.Text.Length < 1)
					{
						Temizle();
						Utility.Engine.Hata("Palet Barkodunu Okutun!");
						textBoxBarkod.Text = "";
						textBoxBarkod.Focus();
						return;
					}

					listView1.Items.Clear();

					Utility.Engine.sql = string.Format("EXEC dbo.PaletBul {0}",textBoxBarkod.Text);

					IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);

					if(dr != null && dr.Read())
					{
						textBoxBarkod.Text = dr.GetValue(0).ToString();
						textBoxDepo.Text = dr.GetValue(1).ToString();

						if(textBoxDepo.Text.Equals("GIRIS-MONTAJ DEPO"))
						{
							if(dr != null)dr.Close();
							Utility.Engine.Hata("Montaj Depodaki Palet Kullanilamaz!");
							Temizle();
							textBoxBarkod.Text = "";
							textBoxBarkod.Focus();
							return;
						}

						if(dr != null)dr.Close();

						if(textBoxBarkod.Text.Length > 0)
							Detaylar();
					}
					else
					{
						this.Text = "Yeni Palet Islemleri " + listView1.Items.Count.ToString();
						if(dr != null)dr.Close();
						Temizle();
						Utility.Engine.Hata("Palet Sistemde Tanimli Degil");
						textBoxBarkod.Text = "";
						textBoxBarkod.Focus();
						return;
					}
					if(dr != null)
						dr.Close();

					textBoxSeriliBarkod.Focus();
					textBoxSeriliBarkod.SelectAll();
					return;


				}
				catch(Exception exc)
				{
					Temizle();
					Utility.Engine.Hata("Palet Sorgulanirken Hata:" + exc.Message);
					textBoxBarkod.Text = "";
					textBoxBarkod.Focus();
					return;
				}
			}
		}

		private void buttonDepo_Click(object sender, System.EventArgs e)
		{
			DepoSecimOzel oz = new DepoSecimOzel();
			oz.Rapor = false;
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxDepo.Text = oz.DepoKodu;
			}
		}

		private void buttonDepoSil_Click(object sender, System.EventArgs e)
		{
			this.Text = "Yeni Palet Islemleri " + listView1.Items.Count.ToString();
			textBoxDepo.Text = "";
			textBoxDepo.Focus();
			return;
		}

		private void buttonSeriliBarkodSil_Click(object sender, System.EventArgs e)
		{
			numericUpDown1.Value = 0;
			numericUpDownMiktar.Maximum = 2500;
			textBoxSeriliBarkod.Text = "";
			textBoxSeriliBarkod.Focus();
			return;
		}

		private void buttonBarkodSil_Click(object sender, System.EventArgs e)
		{
			this.Text = "Yeni Palet Islemleri " + listView1.Items.Count.ToString();
			textBoxBarkod.Text = "";
			textBoxBarkod.Focus();
			return;
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			textBoxBarkod_KeyPress(textBoxBarkod,new System.Windows.Forms.KeyPressEventArgs((char)13));
			textBoxSeriliBarkod.Focus();
			textBoxSeriliBarkod.SelectAll();
			return;
		}

		private void buttonSeriliBarkod_Click(object sender, System.EventArgs e)
		{
			textBoxSeriliBarkod_KeyPress(textBoxSeriliBarkod,new KeyPressEventArgs((char)13));
		}

		private void YeniPalet_Load(object sender, System.EventArgs e)
		{
			comboBoxEkleSil.SelectedIndex = 0;
			textBoxBarkod.Focus();
			return;
		}

		private void buttonMenu_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(listView1.Items.Count > 0 && listView1.SelectedIndices.Count > 0)
				{
					string seri = listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;

					if(MessageBox.Show(seri + " nolu Seri Paletten Cikartilacak!","Dikkat!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.No)return;

					Utility.Engine.sql = "UPDATE serili_barkodlar SET PaletID = NULL WHERE SeriliBarkod = '" + seri + "' ; UPDATE depo_mevcut SET DepoKodu = 'GIRIS' WHERE SeriliBarkod = '" + seri + "' ";

					if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
					{
						Utility.Engine.Hata("Kayit Hatasi:" + Utility.Engine.dat.STR_HataMesaji);
						return;
					}

					listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
					textBoxSeriliBarkod.Focus();
					return;

				}
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Seri Cikartilirken Genel Hata:" + exc.Message);
				return;
			}
		}

		private void comboBoxEkleSil_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			textBoxSeriliBarkod.Focus();
			return;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
            s.sql = "SELECT CariKodu,CariAdi FROM cari_tanim (NOLOCK)";
			s.sql_orderby=" ORDER BY CariKodu";
			s.tablename="cari_tanim";
			
			s.ShowDialog();
			if(s.dr!=null)
			{
				textBoxCari.Text=s.dr["CariKodu"].ToString();
				textBoxCariAdi.Text = s.dr["CariAdi"].ToString();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			textBoxCari.Text = "";
			textBoxCariAdi.Text = "";
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Detaylar(false);
			return;
			if(textBoxDepo.Text.Equals(""))
			{
				Utility.Engine.Hata("Depo Kodu Bos Olamaz!");
				return;
			}

			if(MessageBox.Show(textBoxDepo.Text + " Deposunda Palet Olusturulsunmu?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.No)return;

			Utility.Engine.sql = string.Format("INSERT INTO palet_tanim (DepoKodu,CariKodu,KullaniciID,CihazID) VALUES ('{0}','{1}','{2}','{3}') SELECT @@IDENTITY",Utility.Engine.SqlTemizle(textBoxDepo.Text),Utility.Engine.SqlTemizle(textBoxCari.Text),Utility.Engine.KullaniciID,Utility.Engine.CihazID);

			int don = 0;

			try
			{
				don = Convert.ToInt32((int)Utility.Engine.dat.TCount(Utility.Engine.sql));
			}
			catch(Exception ex)
			{
				Utility.Engine.Hata("Sunucu Sorgulanirken Hata:" + Utility.Engine.dat.STR_HataMesaji);
				return;
			}

			if(don < 1)
			{
				Utility.Engine.Hata("Palet Olusturulamadi.");
				return;
			}
			textBoxDepo.Text = "";
			textBoxSeriliBarkod.Text = "";
			textBoxBarkod.Text = don.ToString();
			textBoxBarkod_KeyPress(textBoxBarkod,new System.Windows.Forms.KeyPressEventArgs((char)13));
			return;
		}

		private void button4_Click_1(object sender, System.EventArgs e)
		{
			numericUpDown1.Value = 0;
			numericUpDownMiktar.Maximum = 2500;
			textBoxSeriliBarkod.Text = "";
			panelCari.Visible = false;
			textBoxBarkod.Focus();
			return;
		}

		private void textBoxAtaKasa_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			OzelSecim oz = new OzelSecim();
			oz.str_ad = "stok_tanim_ust.StokAdi";
			oz.str_kod = "stok_tanim_ust.StokKodu";
			oz.str_ozel = "stok_tanim_detay.Birim";
			oz.tablo = "stok_tanim_ust INNER JOIN stok_tanim_detay ON stok_tanim_ust.StokKodu = stok_tanim_detay.StokKodu ";
			oz.order_by = " stok_tanim_ust.StokAdi ";
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxStokKodu.Text = oz.kod;
				textBoxStokAdi.Text = oz.ad;
				textBoxBirim.Text = oz.ozel;
				numericUpDownMiktar.Value = 1;
			}
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
			s.sql="select MarkaKodu,MarkaAdi from marka_tanim (nolock) ";
			s.sql_orderby=" ORDER BY MarkaAdi";
			s.tablename="marka_tanim";
			
			s.ShowDialog();
			if(s.dr!=null)
			{
				textBoxMarka.Text=s.dr["MarkaKodu"].ToString();
				textBoxMarkaAdi.Text = s.dr["MarkaAdi"].ToString();
			}
		}

		private void button11_Click(object sender, System.EventArgs e)
		{
//			if(textBoxStokKodu.Text.Length < 1)
//			{
//				Utility.Engine.Hata("Stok Kodu Secin!");
//				return;
//			}
			Detaylar(true);
			textBoxSeriliBarkod.Focus();
			return;
		}

	}
}
