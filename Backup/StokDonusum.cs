using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for StokDonusum.
	/// </summary>
	public class StokDonusum : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panelCari;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCari;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxCariAdi;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonDepo;
		private System.Windows.Forms.Button buttonDepoSil;
		private System.Windows.Forms.TextBox textBoxDepo;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxBarkod;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonBarkodSil;
		private System.Windows.Forms.Button buttonYeniPalet;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxMarka;
		private System.Windows.Forms.TextBox textBoxStokAdi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxStok;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button buttonDonustur;
		private System.Windows.Forms.Button buttonTamam;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxMarkaAdi;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button3;
		//public Engine Utility.Engine;
	
		public StokDonusum()
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
			this.panelCari = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxCari = new System.Windows.Forms.TextBox();
			this.buttonDonustur = new System.Windows.Forms.Button();
			this.buttonTamam = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxCariAdi = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonDepo = new System.Windows.Forms.Button();
			this.buttonDepoSil = new System.Windows.Forms.Button();
			this.textBoxDepo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxMarka = new System.Windows.Forms.TextBox();
			this.textBoxStokAdi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxStok = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.textBoxMarkaAdi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBoxBarkod = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonBarkodSil = new System.Windows.Forms.Button();
			this.buttonYeniPalet = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			// 
			// panelCari
			// 
			this.panelCari.BackColor = System.Drawing.Color.Silver;
			this.panelCari.Controls.Add(this.button1);
			this.panelCari.Controls.Add(this.button2);
			this.panelCari.Controls.Add(this.label4);
			this.panelCari.Controls.Add(this.textBoxCari);
			this.panelCari.Controls.Add(this.buttonDonustur);
			this.panelCari.Controls.Add(this.buttonTamam);
			this.panelCari.Controls.Add(this.label5);
			this.panelCari.Controls.Add(this.textBoxCariAdi);
			this.panelCari.Controls.Add(this.label6);
			this.panelCari.Controls.Add(this.buttonDepo);
			this.panelCari.Controls.Add(this.buttonDepoSil);
			this.panelCari.Controls.Add(this.textBoxDepo);
			this.panelCari.Controls.Add(this.label2);
			this.panelCari.Controls.Add(this.button5);
			this.panelCari.Controls.Add(this.button6);
			this.panelCari.Controls.Add(this.label3);
			this.panelCari.Controls.Add(this.textBoxMarka);
			this.panelCari.Controls.Add(this.textBoxStokAdi);
			this.panelCari.Controls.Add(this.label7);
			this.panelCari.Controls.Add(this.textBoxStok);
			this.panelCari.Controls.Add(this.label8);
			this.panelCari.Controls.Add(this.button7);
			this.panelCari.Controls.Add(this.button8);
			this.panelCari.Controls.Add(this.textBoxMarkaAdi);
			this.panelCari.Controls.Add(this.label9);
			this.panelCari.Location = new System.Drawing.Point(392, 24);
			this.panelCari.Size = new System.Drawing.Size(224, 272);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(184, 40);
			this.button1.Size = new System.Drawing.Size(32, 20);
			this.button1.Text = "X";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(152, 40);
			this.button2.Size = new System.Drawing.Size(32, 20);
			this.button2.Text = "..";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 40);
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.Text = "Cari Kodu";
			// 
			// textBoxCari
			// 
			this.textBoxCari.BackColor = System.Drawing.Color.White;
			this.textBoxCari.Location = new System.Drawing.Point(56, 40);
			this.textBoxCari.ReadOnly = true;
			this.textBoxCari.Text = "";
			this.textBoxCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCari_KeyPress);
			// 
			// buttonDonustur
			// 
			this.buttonDonustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonDonustur.Location = new System.Drawing.Point(8, 208);
			this.buttonDonustur.Size = new System.Drawing.Size(208, 24);
			this.buttonDonustur.Text = "DONUSTUR";
			this.buttonDonustur.Click += new System.EventHandler(this.buttonDonustur_Click);
			// 
			// buttonTamam
			// 
			this.buttonTamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonTamam.Location = new System.Drawing.Point(8, 232);
			this.buttonTamam.Size = new System.Drawing.Size(208, 24);
			this.buttonTamam.Text = "TAMAM";
			this.buttonTamam.Click += new System.EventHandler(this.buttonTamam_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 64);
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.Text = "Adi";
			// 
			// textBoxCariAdi
			// 
			this.textBoxCariAdi.BackColor = System.Drawing.Color.White;
			this.textBoxCariAdi.Location = new System.Drawing.Point(56, 64);
			this.textBoxCariAdi.ReadOnly = true;
			this.textBoxCariAdi.Size = new System.Drawing.Size(160, 20);
			this.textBoxCariAdi.Text = "";
			this.textBoxCariAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCari_KeyPress);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(16, 8);
			this.label6.Size = new System.Drawing.Size(200, 16);
			this.label6.Text = "Cari Kodu";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// buttonDepo
			// 
			this.buttonDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonDepo.Location = new System.Drawing.Point(152, 136);
			this.buttonDepo.Size = new System.Drawing.Size(32, 20);
			this.buttonDepo.Text = "...";
			this.buttonDepo.Click += new System.EventHandler(this.buttonDepo_Click);
			// 
			// buttonDepoSil
			// 
			this.buttonDepoSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonDepoSil.Location = new System.Drawing.Point(184, 136);
			this.buttonDepoSil.Size = new System.Drawing.Size(32, 20);
			this.buttonDepoSil.Text = "X";
			this.buttonDepoSil.Click += new System.EventHandler(this.buttonDepoSil_Click);
			// 
			// textBoxDepo
			// 
			this.textBoxDepo.BackColor = System.Drawing.Color.White;
			this.textBoxDepo.Location = new System.Drawing.Point(56, 136);
			this.textBoxDepo.ReadOnly = true;
			this.textBoxDepo.Size = new System.Drawing.Size(104, 20);
			this.textBoxDepo.Text = "";
			this.textBoxDepo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCari_KeyPress);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 136);
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.Text = "Depo";
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button5.Location = new System.Drawing.Point(184, 160);
			this.button5.Size = new System.Drawing.Size(32, 20);
			this.button5.Text = "X";
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button6.Location = new System.Drawing.Point(152, 160);
			this.button6.Size = new System.Drawing.Size(32, 20);
			this.button6.Text = "...";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 160);
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.Text = "Marka";
			// 
			// textBoxMarka
			// 
			this.textBoxMarka.BackColor = System.Drawing.Color.White;
			this.textBoxMarka.Location = new System.Drawing.Point(56, 160);
			this.textBoxMarka.ReadOnly = true;
			this.textBoxMarka.Size = new System.Drawing.Size(104, 20);
			this.textBoxMarka.Text = "";
			this.textBoxMarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCari_KeyPress);
			// 
			// textBoxStokAdi
			// 
			this.textBoxStokAdi.BackColor = System.Drawing.Color.White;
			this.textBoxStokAdi.Location = new System.Drawing.Point(56, 112);
			this.textBoxStokAdi.ReadOnly = true;
			this.textBoxStokAdi.Size = new System.Drawing.Size(160, 20);
			this.textBoxStokAdi.Text = "";
			this.textBoxStokAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCari_KeyPress);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 112);
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.Text = "Adi";
			// 
			// textBoxStok
			// 
			this.textBoxStok.BackColor = System.Drawing.Color.White;
			this.textBoxStok.Location = new System.Drawing.Point(56, 88);
			this.textBoxStok.ReadOnly = true;
			this.textBoxStok.Text = "";
			this.textBoxStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCari_KeyPress);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 88);
			this.label8.Size = new System.Drawing.Size(48, 16);
			this.label8.Text = "Stok";
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button7.Location = new System.Drawing.Point(152, 88);
			this.button7.Size = new System.Drawing.Size(32, 20);
			this.button7.Text = "..";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button8.Location = new System.Drawing.Point(184, 88);
			this.button8.Size = new System.Drawing.Size(32, 20);
			this.button8.Text = "X";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// textBoxMarkaAdi
			// 
			this.textBoxMarkaAdi.BackColor = System.Drawing.Color.White;
			this.textBoxMarkaAdi.Location = new System.Drawing.Point(56, 184);
			this.textBoxMarkaAdi.ReadOnly = true;
			this.textBoxMarkaAdi.Size = new System.Drawing.Size(160, 20);
			this.textBoxMarkaAdi.Text = "";
			this.textBoxMarkaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCari_KeyPress);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 184);
			this.label9.Size = new System.Drawing.Size(48, 16);
			this.label9.Text = "Adi";
			// 
			// listView1
			// 
			this.listView1.Columns.Add(this.columnHeader1);
			this.listView1.Columns.Add(this.columnHeader2);
			this.listView1.Columns.Add(this.columnHeader3);
			this.listView1.Columns.Add(this.columnHeader4);
			this.listView1.Columns.Add(this.columnHeader5);
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(8, 48);
			this.listView1.Size = new System.Drawing.Size(224, 232);
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.textBoxBarkod);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonOK);
			this.panel1.Controls.Add(this.buttonBarkodSil);
			this.panel1.Controls.Add(this.buttonYeniPalet);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Size = new System.Drawing.Size(224, 40);
			// 
			// textBoxBarkod
			// 
			this.textBoxBarkod.BackColor = System.Drawing.Color.Yellow;
			this.textBoxBarkod.Location = new System.Drawing.Point(56, 0);
			this.textBoxBarkod.Text = "";
			this.textBoxBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkod_KeyPress);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 0);
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.Text = "Palet";
			// 
			// buttonOK
			// 
			this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonOK.Location = new System.Drawing.Point(152, 0);
			this.buttonOK.Size = new System.Drawing.Size(32, 20);
			this.buttonOK.Text = ">>";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonBarkodSil
			// 
			this.buttonBarkodSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonBarkodSil.Location = new System.Drawing.Point(184, 0);
			this.buttonBarkodSil.Size = new System.Drawing.Size(32, 20);
			this.buttonBarkodSil.Text = "X";
			this.buttonBarkodSil.Click += new System.EventHandler(this.buttonBarkodSil_Click);
			// 
			// buttonYeniPalet
			// 
			this.buttonYeniPalet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.buttonYeniPalet.Location = new System.Drawing.Point(0, 20);
			this.buttonYeniPalet.Size = new System.Drawing.Size(156, 20);
			this.buttonYeniPalet.Text = "DETAYLAR";
			this.buttonYeniPalet.Click += new System.EventHandler(this.buttonYeniPalet_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(156, 20);
			this.button3.Size = new System.Drawing.Size(60, 20);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			// 
			// StokDonusum
			// 
			this.BackColor = System.Drawing.Color.Azure;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panelCari);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Text = "StokDonusum";
			this.Load += new System.EventHandler(this.StokDonusum_Load);

		}
		#endregion

		private void StokDonusum_Load(object sender, System.EventArgs e)
		{
			textBoxBarkod.Focus();
			return;
		}

		private void buttonYeniPalet_Click(object sender, System.EventArgs e)
		{
			panelCari.Location = new Point(8, 8);
			panelCari.BringToFront();
			panelCari.Visible = true;
			return;
		}

		private void buttonTamam_Click(object sender, System.EventArgs e)
		{
			panelCari.Visible = false;
			textBoxBarkod.Focus();
			return;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
			s.sql="SELECT TOP 10 CariKodu,CariAdi FROM cari_tanim";
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

		private void button7_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
			s.sql="SELECT TOP 150 StokKodu,StokAdi FROM stok_tanim_ust";
			s.sql_orderby=" ORDER BY StokKodu";
			s.tablename="StokTanimlari";
			
			s.ShowDialog();
			if(s.dr!=null)
			{
				textBoxStok.Text=s.dr["StokKodu"].ToString();
				textBoxStokAdi.Text = s.dr["StokAdi"].ToString();
			}
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			textBoxStok.Text = "";
			textBoxStokAdi.Text = "";
		}

		private void buttonDepo_Click(object sender, System.EventArgs e)
		{
			DepoSecimOzel oz = new DepoSecimOzel();
			
			oz.Rapor = true;
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxDepo.Text = oz.DepoKodu;
			}
		}

		private void buttonDepoSil_Click(object sender, System.EventArgs e)
		{
			textBoxDepo.Text = "";
		}

		private void button6_Click(object sender, System.EventArgs e)
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

		private void buttonDonustur_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(textBoxDepo.Text.Equals(""))
				{
					Utility.Engine.Hata("Palet Deposu Bos Olamaz!");
					return;
				}

				if(listView1.Items.Count < 1)
				{
					Utility.Engine.Hata("Bos Belge Kaydedilemez!");
					return;
				}

				if(MessageBox.Show("Yapilan Islemler Kaydedilecek Onayliyormusunuz?","Dikkat!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.No)return;

				Utility.Engine.sql = string.Format("EXEC dbo.HizliDonusum {0},'{1}','{2}','{3}','{4}'",
					Utility.Engine.SqlTemizle(textBoxBarkod.Text),
					Utility.Engine.SqlTemizle(textBoxDepo.Text),
					Utility.Engine.SqlTemizle(textBoxStok.Text),
					Utility.Engine.SqlTemizle(textBoxCari.Text),
					Utility.Engine.SqlTemizle(textBoxMarka.Text));

				IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);

				if(dr != null && dr.Read())
				{
					string drm = dr.GetValue(1).ToString();
					string msg = dr.GetValue(0).ToString();
					if(dr != null)dr.Close();
					if(!drm.Equals("ok"))
					{
						Utility.Engine.Hata(msg);
					}
					else 
					{
						try
						{
							AmbarPC.Fis f = new AmbarPC.Fis();
							
							f.Aciklama1 = "Stok Donusumu Yapildi ";
							f.Aciklama2 = Utility.Engine.SqlTemizle(textBoxStok.Text);
							f.HareketTipi = "Serili Stok Transferi";
							f.GirenDepo = Utility.Engine.SqlTemizle(textBoxDepo.Text);
							f.CikanDepo = Utility.Engine.SqlTemizle(textBoxDepo.Text);
							f.HareketKodu = "MAMUL ETIKET";
							f.CariKod = Utility.Engine.SqlTemizle(textBoxCari.Text);

							if(!f.MaulEtiket(textBoxBarkod.Text,Utility.Engine.SqlTemizle(textBoxMarka.Text),Utility.Engine.SqlTemizle(textBoxStok.Text)))
							{
								Utility.Engine.Hata("Stok Donusum Kayit Hatasi:" + f.HataMesaji);
								return;
							}

							MessageBox.Show(f.BelgeNo.ToString() + " nolu Fis Kaydedildi","Tamam",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
				
							Temizle();
							textBoxBarkod.Focus();
							return;
						}
						catch(Exception exc)
						{
							Utility.Engine.Hata("Genel Hata:" + exc.Message);
							return;
						}
					}
				}
				else
				{
					if(dr != null)dr.Close();
					Utility.Engine.Hata("Hata Olustu!");
				}
				if(dr != null)dr.Close();
				Temizle();
				textBoxBarkod.Focus();
				return;


			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Genel Hata:" + exc.Message);
				textBoxBarkod.Focus();
				return;
			}
		}

		private void textBoxCari_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void buttonBarkodSil_Click(object sender, System.EventArgs e)
		{
			textBoxBarkod.Text = "";
			textBoxBarkod.Focus();
			return;
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
						this.Text = "Hizli Donusum " + listView1.Items.Count.ToString();
						if(dr != null)dr.Close();
						Temizle();
						Utility.Engine.Hata("Palet Sistemde Tanimli Degil");
						textBoxBarkod.Text = "";
						textBoxBarkod.Focus();
						return;
					}
					if(dr != null)
						dr.Close();

					textBoxBarkod.Focus();
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
		private void Detaylar()
		{
			try
			{
				Utility.Engine.sql = string.Format("EXEC dbo.PaletDetaylari {0}",textBoxBarkod.Text);
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
				this.Text = "Hizli Donusum " + listView1.Items.Count.ToString();
				return;
			}
			catch
			{
				return;
			}
		}
		private void Temizle()
		{
			textBoxDepo.Text = "";
			textBoxBarkod.Text = "";
			textBoxCari.Text = "";
			textBoxCariAdi.Text = "";
			textBoxStok.Text = "";
			textBoxStokAdi.Text = "";
			textBoxMarka.Text = "";
			textBoxMarkaAdi.Text = "";
			listView1.Items.Clear();
			textBoxBarkod.Focus();
			return;
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			textBoxBarkod_KeyPress(textBoxBarkod,new System.Windows.Forms.KeyPressEventArgs((char)13));
			return;
		}
	}
}
