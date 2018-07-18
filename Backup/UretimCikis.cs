using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for UretimCikis.
	/// </summary>
	public class UretimCikis : System.Windows.Forms.Form
	{
		public UretimCikis()
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBoxBarkod = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonBarkodSil = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBoxStokKodu = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxStokAdi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxBirim = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxAtaKasa = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxMiktar = new System.Windows.Forms.TextBox();
			this.textBoxOzelKod = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxDepo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panelDetay = new System.Windows.Forms.Panel();
			this.textBoxAciklama2 = new System.Windows.Forms.TextBox();
			this.textBoxAciklama1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.textBoxDepoKodu = new System.Windows.Forms.TextBox();
			// 
			// listView1
			// 
			this.listView1.Columns.Add(this.columnHeader1);
			this.listView1.Columns.Add(this.columnHeader2);
			this.listView1.Columns.Add(this.columnHeader3);
			this.listView1.Columns.Add(this.columnHeader4);
			this.listView1.Columns.Add(this.columnHeader5);
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(328, 304);
			this.listView1.Size = new System.Drawing.Size(224, 208);
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
			this.panel1.Controls.Add(this.textBoxDepoKodu);
			this.panel1.Controls.Add(this.textBoxBarkod);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.buttonOK);
			this.panel1.Controls.Add(this.buttonBarkodSil);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.textBoxStokKodu);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBoxStokAdi);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.textBoxBirim);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.textBoxAtaKasa);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.textBoxMiktar);
			this.panel1.Controls.Add(this.textBoxOzelKod);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.textBoxDepo);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Size = new System.Drawing.Size(224, 272);
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
			this.label1.Text = "Barkod";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.Text = "Depo";
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
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(120, 224);
			this.button1.Size = new System.Drawing.Size(88, 32);
			this.button1.Text = "KAYDET";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(24, 224);
			this.button2.Size = new System.Drawing.Size(88, 32);
			this.button2.Text = "DETAY";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBoxStokKodu
			// 
			this.textBoxStokKodu.BackColor = System.Drawing.Color.White;
			this.textBoxStokKodu.Location = new System.Drawing.Point(56, 48);
			this.textBoxStokKodu.ReadOnly = true;
			this.textBoxStokKodu.Size = new System.Drawing.Size(160, 20);
			this.textBoxStokKodu.Text = "";
			this.textBoxStokKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStokKodu_KeyPress);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(0, 48);
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.Text = "StokKodu";
			// 
			// textBoxStokAdi
			// 
			this.textBoxStokAdi.BackColor = System.Drawing.Color.White;
			this.textBoxStokAdi.Location = new System.Drawing.Point(56, 72);
			this.textBoxStokAdi.ReadOnly = true;
			this.textBoxStokAdi.Size = new System.Drawing.Size(160, 20);
			this.textBoxStokAdi.Text = "";
			this.textBoxStokAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStokKodu_KeyPress);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(0, 72);
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.Text = "StokAdi";
			// 
			// textBoxBirim
			// 
			this.textBoxBirim.BackColor = System.Drawing.Color.White;
			this.textBoxBirim.Location = new System.Drawing.Point(56, 96);
			this.textBoxBirim.ReadOnly = true;
			this.textBoxBirim.Size = new System.Drawing.Size(72, 20);
			this.textBoxBirim.Text = "";
			this.textBoxBirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStokKodu_KeyPress);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(0, 96);
			this.label8.Size = new System.Drawing.Size(56, 16);
			this.label8.Text = "Birim/Mik";
			// 
			// textBoxAtaKasa
			// 
			this.textBoxAtaKasa.BackColor = System.Drawing.Color.White;
			this.textBoxAtaKasa.Location = new System.Drawing.Point(56, 120);
			this.textBoxAtaKasa.ReadOnly = true;
			this.textBoxAtaKasa.Size = new System.Drawing.Size(160, 20);
			this.textBoxAtaKasa.Text = "";
			this.textBoxAtaKasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStokKodu_KeyPress);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(0, 120);
			this.label9.Size = new System.Drawing.Size(56, 16);
			this.label9.Text = "AtaKasa";
			// 
			// textBoxMiktar
			// 
			this.textBoxMiktar.BackColor = System.Drawing.Color.White;
			this.textBoxMiktar.Location = new System.Drawing.Point(128, 96);
			this.textBoxMiktar.ReadOnly = true;
			this.textBoxMiktar.Size = new System.Drawing.Size(88, 20);
			this.textBoxMiktar.Text = "";
			this.textBoxMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStokKodu_KeyPress);
			// 
			// textBoxOzelKod
			// 
			this.textBoxOzelKod.BackColor = System.Drawing.Color.White;
			this.textBoxOzelKod.Location = new System.Drawing.Point(56, 144);
			this.textBoxOzelKod.ReadOnly = true;
			this.textBoxOzelKod.Size = new System.Drawing.Size(160, 20);
			this.textBoxOzelKod.Text = "";
			this.textBoxOzelKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStokKodu_KeyPress);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(0, 144);
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.Text = "Marka";
			// 
			// textBoxDepo
			// 
			this.textBoxDepo.BackColor = System.Drawing.Color.White;
			this.textBoxDepo.Location = new System.Drawing.Point(56, 168);
			this.textBoxDepo.ReadOnly = true;
			this.textBoxDepo.Size = new System.Drawing.Size(160, 20);
			this.textBoxDepo.Text = "";
			this.textBoxDepo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStokKodu_KeyPress);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(0, 168);
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.Text = "Depo";
			// 
			// panelDetay
			// 
			this.panelDetay.BackColor = System.Drawing.Color.Silver;
			this.panelDetay.Controls.Add(this.textBoxAciklama2);
			this.panelDetay.Controls.Add(this.textBoxAciklama1);
			this.panelDetay.Controls.Add(this.label3);
			this.panelDetay.Controls.Add(this.button4);
			this.panelDetay.Controls.Add(this.button5);
			this.panelDetay.Controls.Add(this.label4);
			this.panelDetay.Controls.Add(this.button3);
			this.panelDetay.Location = new System.Drawing.Point(232, 8);
			this.panelDetay.Size = new System.Drawing.Size(224, 272);
			// 
			// textBoxAciklama2
			// 
			this.textBoxAciklama2.BackColor = System.Drawing.Color.White;
			this.textBoxAciklama2.Location = new System.Drawing.Point(64, 56);
			this.textBoxAciklama2.Size = new System.Drawing.Size(120, 20);
			this.textBoxAciklama2.Text = "";
			// 
			// textBoxAciklama1
			// 
			this.textBoxAciklama1.BackColor = System.Drawing.Color.White;
			this.textBoxAciklama1.Location = new System.Drawing.Point(64, 24);
			this.textBoxAciklama1.Size = new System.Drawing.Size(120, 20);
			this.textBoxAciklama1.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.Text = "Aciklama1";
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button4.Location = new System.Drawing.Point(184, 24);
			this.button4.Size = new System.Drawing.Size(32, 20);
			this.button4.Text = "X";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button5.Location = new System.Drawing.Point(184, 56);
			this.button5.Size = new System.Drawing.Size(32, 20);
			this.button5.Text = "X";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 56);
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.Text = "Aciklama2";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(8, 216);
			this.button3.Size = new System.Drawing.Size(208, 32);
			this.button3.Text = "TAMAM";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button6.Location = new System.Drawing.Point(152, 24);
			this.button6.Size = new System.Drawing.Size(32, 20);
			this.button6.Text = "..";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button7.Location = new System.Drawing.Point(184, 24);
			this.button7.Size = new System.Drawing.Size(32, 20);
			this.button7.Text = "X";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// textBoxDepoKodu
			// 
			this.textBoxDepoKodu.BackColor = System.Drawing.Color.Salmon;
			this.textBoxDepoKodu.Location = new System.Drawing.Point(56, 24);
			this.textBoxDepoKodu.Text = "";
			// 
			// UretimCikis
			// 
			this.BackColor = System.Drawing.Color.Azure;
			this.Controls.Add(this.panelDetay);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Text = "Serili Transfer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.UretimCikis_Load);

		}
		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxBarkod;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonBarkodSil;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panelDetay;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxAciklama1;
		private System.Windows.Forms.TextBox textBoxAciklama2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBoxDepo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxStokKodu;
		private System.Windows.Forms.TextBox textBoxStokAdi;
		private System.Windows.Forms.TextBox textBoxBirim;
		private System.Windows.Forms.TextBox textBoxAtaKasa;
		private System.Windows.Forms.TextBox textBoxMiktar;
		private System.Windows.Forms.TextBox textBoxOzelKod;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox textBoxDepoKodu;

		//public Engine Utility.Engine;
		private void Temizle()
		{
			textBoxDepoKodu.Text = "";
			textBoxAciklama1.Text = "";
			textBoxAciklama2.Text = "";
			textBoxDepo.Text = "";
			textBoxBarkod.Text = "";
			textBoxBirim.Text = "";
			textBoxMiktar.Text = "";
			textBoxOzelKod.Text = "";
			textBoxStokAdi.Text = "";
			textBoxStokKodu.Text = "";
			textBoxAtaKasa.Text = "";
			listView1.Items.Clear();
			this.Text = "URETIM CIKIS " + listView1.Items.Count.ToString();
			textBoxBarkod.Focus();
			return;
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
				this.Text = "URETIM CIKIS " + listView1.Items.Count.ToString();
				return;
			}
			catch
			{
				return;
			}
		}

		private void UretimCikis_Load(object sender, System.EventArgs e)
		{
			try
			{
//				Utility.Engine.sql = "SELECT DepoKodu FROM depo_tanim WHERE UstDepoKodu = 'GIRIS' ORDER BY DepoKodu ";
//				Utility.Engine.dat.ComboDoldur(Utility.Engine.sql,comboBox1);
				textBoxBarkod.Focus();
				return;
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Genel Hata:" + exc.Message);
				return;
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			textBoxAciklama1.Text = "";
			textBoxAciklama1.Focus();
			return;
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			textBoxAciklama2.Text = "";
			textBoxAciklama2.Focus();
			return;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			panelDetay.Location = new Point(8,8);
			panelDetay.Visible = true;
			panelDetay.BringToFront();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			panelDetay.Visible = false;
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			textBoxBarkod_KeyPress(textBoxBarkod,new System.Windows.Forms.KeyPressEventArgs((char)13));
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

					Utility.Engine.sql = string.Format("EXEC dbo.UretimeCikisSeriBul '{0}'",textBoxBarkod.Text.ToUpper());

					IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);

					string stok = "" , stokadi = "",birim = "",miktar = "",marka = "",depo = "",atakasa = "",seri = "";

					if(dr != null && dr.Read())
					{
						if (dr["DepoKodu"] != DBNull.Value)
						{
							depo = dr["DepoKodu"].ToString();
						}

						if (dr["StokKodu"] != DBNull.Value)
						{
							stok = dr["StokKodu"].ToString();
						}

						if (dr["MarkaAdi"] != DBNull.Value)
						{
							marka = dr["MarkaAdi"].ToString();
						}

						if (dr["StokAdi"] != DBNull.Value)
						{
							stokadi = dr["StokAdi"].ToString();
						}

						if (dr["Birim"] != DBNull.Value)
						{
							birim = dr["Birim"].ToString();
						}

						if (dr["AtaKasa"] != DBNull.Value)
						{
							atakasa = dr["AtaKasa"].ToString();
						}

						if (dr["SeriliBarkod"] != DBNull.Value)
						{
							seri = dr["SeriliBarkod"].ToString();
						}

						if (dr["Miktar"] != DBNull.Value)
						{
							miktar = dr["Miktar"].ToString();
						}
						

						if(dr != null)dr.Close();

						if(stok.Equals("hata"))
						{
							Utility.Engine.Hata("*"+stokadi);
							textBoxBarkod.Text = "";
							textBoxBarkod.Focus();
							return;
						}
						else
						{
							textBoxDepo.Text = depo;
							textBoxBirim.Text = birim;
							textBoxMiktar.Text = miktar;
							textBoxOzelKod.Text = marka;
							textBoxStokKodu.Text = stok;
							textBoxStokAdi.Text = stokadi;
							textBoxAtaKasa.Text = atakasa;
							textBoxBarkod.Text = seri;
							textBoxBarkod.Focus();
							return;
						}

					}
					else
					{
						this.Text = "URETIM CIKIS " + listView1.Items.Count.ToString();
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
					textBoxBarkod.SelectAll();
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

		private void buttonBarkodSil_Click(object sender, System.EventArgs e)
		{
			Temizle();
			textBoxBarkod.Text = "";
			textBoxBarkod.Focus();
			return;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
//				if(listView1.Items.Count < 1)
//				{
//					Utility.Engine.Hata("Bos Belge Kaydedilemez!");
//					return;
//				}
				if(textBoxBarkod.Text.Length < 7)
				{
					Utility.Engine.Hata("Seri Barkodu Utility.Engine Az 7 Karekter Olabilir!");
					textBoxBarkod.Focus();
					return;
				}
				if(textBoxDepoKodu.Text.Length < 1)
				{
					Utility.Engine.Hata("Giren Depo Kodu Bos Olamaz!");
					textBoxDepoKodu.Focus();
					return;
				}
				if(textBoxDepo.Text.Equals(""))
				{
					Utility.Engine.Hata("Cikan Depo Bos Olamaz!");
					return;
				}

				if(MessageBox.Show("Yapilan Islemler Kaydedilecek Onayliyormusunuz?","Dikkat!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.No)return;

				AmbarPC.Fis f = new AmbarPC.Fis();
				
				f.Aciklama1 = Utility.Engine.SqlTemizle(textBoxAciklama1.Text);
				f.Aciklama2 = Utility.Engine.SqlTemizle(textBoxAciklama2.Text);
				f.HareketTipi = "Serili Stok Transferi";
				f.GirenDepo = Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
				f.CikanDepo = textBoxDepo.Text;
				f.HareketKodu = "TRANSFER";

				if(!f.UretimCikis(textBoxBarkod.Text))
				{
					Utility.Engine.Hata("Uretim Cikis Fisi Kaydedilemedi:" + f.HataMesaji);
					return;
				}

				MessageBox.Show(f.BelgeNo.ToString() + " nolu Fis Kaydedildi","Tamam",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
				listView1.Items.Clear();
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

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxStokKodu_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			DepoSecimOzel oz = new DepoSecimOzel();
			oz.Rapor = false;
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxDepoKodu.Text = oz.DepoKodu;
			}
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			textBoxDepoKodu.Text = "";
		}
	}
}
