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
	public class PaletTransfer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textAMiktar;
		private System.Windows.Forms.Button buttonDepo;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonBarkodSil;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBoxAtaKasa;
		private System.Windows.Forms.TextBox textAtaStokKodu;
		private System.Windows.Forms.TextBox textAtaStokAdi;
		private System.Windows.Forms.TextBox textAtaBirim;
		private System.Windows.Forms.TextBox textKasaBirim;
		private System.Windows.Forms.TextBox textKasaStokAdi;
		private System.Windows.Forms.TextBox textBoxKasa;
		private System.Windows.Forms.TextBox textKasaStokKodu;
      private TextBox textDepo;
      private Label label11;
      private ComboBox comboBoxEkleSil;
      private TextBox textMiktar;
      private TextBox textKMiktar;

		//public Engine Utility.Engine;
	
		public PaletTransfer()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletTransfer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxEkleSil = new System.Windows.Forms.ComboBox();
            this.textBoxAtaKasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textMiktar = new System.Windows.Forms.TextBox();
            this.textKMiktar = new System.Windows.Forms.TextBox();
            this.textAMiktar = new System.Windows.Forms.TextBox();
            this.buttonBarkodSil = new System.Windows.Forms.Button();
            this.textAtaStokKodu = new System.Windows.Forms.TextBox();
            this.textDepo = new System.Windows.Forms.TextBox();
            this.textAtaStokAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textAtaBirim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textKasaBirim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textKasaStokAdi = new System.Windows.Forms.TextBox();
            this.textBoxKasa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textKasaStokKodu = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDepo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.comboBoxEkleSil);
            this.panel1.Controls.Add(this.textBoxAtaKasa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.textMiktar);
            this.panel1.Controls.Add(this.textKMiktar);
            this.panel1.Controls.Add(this.textAMiktar);
            this.panel1.Controls.Add(this.buttonBarkodSil);
            this.panel1.Controls.Add(this.textAtaStokKodu);
            this.panel1.Controls.Add(this.textDepo);
            this.panel1.Controls.Add(this.textAtaStokAdi);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textAtaBirim);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textKasaBirim);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textKasaStokAdi);
            this.panel1.Controls.Add(this.textBoxKasa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textKasaStokKodu);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 272);
            // 
            // comboBoxEkleSil
            // 
            this.comboBoxEkleSil.Items.Add("EKLE");
            this.comboBoxEkleSil.Items.Add("SIL");
            this.comboBoxEkleSil.Location = new System.Drawing.Point(136, 217);
            this.comboBoxEkleSil.Name = "comboBoxEkleSil";
            this.comboBoxEkleSil.Size = new System.Drawing.Size(80, 23);
            this.comboBoxEkleSil.TabIndex = 5;
            // 
            // textBoxAtaKasa
            // 
            this.textBoxAtaKasa.BackColor = System.Drawing.Color.Yellow;
            this.textBoxAtaKasa.Location = new System.Drawing.Point(56, 0);
            this.textBoxAtaKasa.Name = "textBoxAtaKasa";
            this.textBoxAtaKasa.Size = new System.Drawing.Size(100, 23);
            this.textBoxAtaKasa.TabIndex = 0;
            this.textBoxAtaKasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkod_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.Text = "AtaKasa";
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonOK.Location = new System.Drawing.Point(152, 0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(32, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = ">>";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textMiktar
            // 
            this.textMiktar.Location = new System.Drawing.Point(56, 217);
            this.textMiktar.Name = "textMiktar";
            this.textMiktar.Size = new System.Drawing.Size(80, 23);
            this.textMiktar.TabIndex = 4;
            // 
            // textKMiktar
            // 
            this.textKMiktar.Location = new System.Drawing.Point(136, 192);
            this.textKMiktar.Name = "textKMiktar";
            this.textKMiktar.Size = new System.Drawing.Size(80, 23);
            this.textKMiktar.TabIndex = 4;
            // 
            // textAMiktar
            // 
            this.textAMiktar.Location = new System.Drawing.Point(136, 72);
            this.textAMiktar.Name = "textAMiktar";
            this.textAMiktar.Size = new System.Drawing.Size(80, 23);
            this.textAMiktar.TabIndex = 4;
            // 
            // buttonBarkodSil
            // 
            this.buttonBarkodSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonBarkodSil.Location = new System.Drawing.Point(184, 0);
            this.buttonBarkodSil.Name = "buttonBarkodSil";
            this.buttonBarkodSil.Size = new System.Drawing.Size(32, 23);
            this.buttonBarkodSil.TabIndex = 3;
            this.buttonBarkodSil.Text = "X";
            this.buttonBarkodSil.Click += new System.EventHandler(this.buttonBarkodSil_Click);
            // 
            // textAtaStokKodu
            // 
            this.textAtaStokKodu.BackColor = System.Drawing.Color.Yellow;
            this.textAtaStokKodu.Location = new System.Drawing.Point(56, 24);
            this.textAtaStokKodu.Name = "textAtaStokKodu";
            this.textAtaStokKodu.Size = new System.Drawing.Size(160, 23);
            this.textAtaStokKodu.TabIndex = 5;
            // 
            // textDepo
            // 
            this.textDepo.BackColor = System.Drawing.Color.Yellow;
            this.textDepo.Location = new System.Drawing.Point(56, 95);
            this.textDepo.Name = "textDepo";
            this.textDepo.Size = new System.Drawing.Size(160, 23);
            this.textDepo.TabIndex = 6;
            // 
            // textAtaStokAdi
            // 
            this.textAtaStokAdi.BackColor = System.Drawing.Color.Yellow;
            this.textAtaStokAdi.Location = new System.Drawing.Point(56, 48);
            this.textAtaStokAdi.Name = "textAtaStokAdi";
            this.textAtaStokAdi.Size = new System.Drawing.Size(160, 23);
            this.textAtaStokAdi.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(8, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.Text = "Depo";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.Text = "StokKodu";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.Text = "StokAdi";
            // 
            // textAtaBirim
            // 
            this.textAtaBirim.BackColor = System.Drawing.Color.Yellow;
            this.textAtaBirim.Location = new System.Drawing.Point(56, 72);
            this.textAtaBirim.Name = "textAtaBirim";
            this.textAtaBirim.Size = new System.Drawing.Size(80, 23);
            this.textAtaBirim.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(2, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.Text = "Birim";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.Text = "StokKodu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(184, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textKasaBirim
            // 
            this.textKasaBirim.BackColor = System.Drawing.Color.Salmon;
            this.textKasaBirim.Location = new System.Drawing.Point(56, 192);
            this.textKasaBirim.Name = "textKasaBirim";
            this.textKasaBirim.Size = new System.Drawing.Size(80, 23);
            this.textKasaBirim.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.Text = "Birim";
            // 
            // textKasaStokAdi
            // 
            this.textKasaStokAdi.BackColor = System.Drawing.Color.Salmon;
            this.textKasaStokAdi.Location = new System.Drawing.Point(56, 168);
            this.textKasaStokAdi.Name = "textKasaStokAdi";
            this.textKasaStokAdi.Size = new System.Drawing.Size(160, 23);
            this.textKasaStokAdi.TabIndex = 15;
            // 
            // textBoxKasa
            // 
            this.textBoxKasa.BackColor = System.Drawing.Color.Salmon;
            this.textBoxKasa.Location = new System.Drawing.Point(56, 120);
            this.textBoxKasa.Name = "textBoxKasa";
            this.textBoxKasa.Size = new System.Drawing.Size(100, 23);
            this.textBoxKasa.TabIndex = 17;
            this.textBoxKasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKasa_KeyPress);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.Text = "StokAdi";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.Text = "Kasa";
            // 
            // textKasaStokKodu
            // 
            this.textKasaStokKodu.BackColor = System.Drawing.Color.Salmon;
            this.textKasaStokKodu.Location = new System.Drawing.Point(56, 144);
            this.textKasaStokKodu.Name = "textKasaStokKodu";
            this.textKasaStokKodu.Size = new System.Drawing.Size(160, 23);
            this.textKasaStokKodu.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(152, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = ">>";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.Text = "Miktar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 27);
            this.button3.TabIndex = 24;
            this.button3.Text = "KAYDET";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 27);
            this.button4.TabIndex = 25;
            this.button4.Text = "ÇIK";
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(472, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.Text = "Depo";
            // 
            // buttonDepo
            // 
            this.buttonDepo.Enabled = false;
            this.buttonDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonDepo.Location = new System.Drawing.Point(616, 120);
            this.buttonDepo.Name = "buttonDepo";
            this.buttonDepo.Size = new System.Drawing.Size(64, 20);
            this.buttonDepo.TabIndex = 2;
            this.buttonDepo.Text = "Depo Sec";
            this.buttonDepo.Click += new System.EventHandler(this.buttonDepo_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.Columns.Add(this.columnHeader4);
            this.listView1.Columns.Add(this.columnHeader5);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(384, 184);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 232);
            this.listView1.TabIndex = 0;
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
            // PaletTransfer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDepo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaletTransfer";
            this.Text = "PaletTransfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YeniPalet_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void Temizle()
		{
         textKMiktar.Text = 
         textMiktar.Text = 
         textAMiktar.Text = "";
         textDepo.Text = "";
			textAtaBirim.Text = "";
			textBoxAtaKasa.Text = "";
			textAtaStokKodu.Text = "";
			textAtaStokAdi.Text = "";
			textAMiktar.Text = "";
			textBoxKasa.Text = "";
			textKasaBirim.Text = "";
			textKasaStokAdi.Text = "";
			textKasaStokKodu.Text = "";
         textBoxAtaKasa.Focus();
			return;
		}
		private void Detaylar()
		{
			
		}
		private void button4_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void buttonYeniPalet_Click(object sender, System.EventArgs e)
		{
			
		}

		private void textBoxBarkod_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
				buttonOK_Click(null,null);
			}
		}

		private void buttonDepo_Click(object sender, System.EventArgs e)
		{
			
		}

		private void buttonDepoSil_Click(object sender, System.EventArgs e)
		{
			textAMiktar.Text = "";
			textAMiktar.Focus();
			return;
		}

		private void buttonBarkodSil_Click(object sender, System.EventArgs e)
		{
			Temizle();
			return;
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			try
			{
            Utility.Engine.sql = string.Format("EXEC dbo.KasaBulKasaTransfer N'{0}'", Utility.Engine.SqlTemizle(textBoxAtaKasa.Text));

            DataTable dtx = new DataTable();

            Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dtx);

            if (dtx != null && dtx.Rows.Count > 0)
            {
               Temizle();
               textBoxAtaKasa.Text = dtx.Rows[0]["SeriliBarkod"].ToString();
               textAtaStokKodu.Text = dtx.Rows[0]["StokKodu"].ToString();
               textAtaStokAdi.Text = dtx.Rows[0]["StokAdi"].ToString();
               textAtaBirim.Text = dtx.Rows[0]["Birim"].ToString();
               textDepo.Text = dtx.Rows[0]["DepoKodu"].ToString();
               textMiktar.Text = 
               textAMiktar.Text = Convert.ToDecimal(dtx.Rows[0]["Miktar"].ToString()).ToString();
               textBoxKasa.Focus();
               return;
            }
            else
            {
               Temizle();
               Utility.Engine.Hata("Seri Bilgisi Sistemde Bulunamadi!");
               textBoxAtaKasa.Focus();
               return;
            }
				
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Seri Sorgulanamadi.:" + exc.Message);
				textBoxAtaKasa.Focus();
				return;
			}
		}

		private void buttonSeriliBarkod_Click(object sender, System.EventArgs e)
		{
		
		}

		private void YeniPalet_Load(object sender, System.EventArgs e)
		{
         comboBoxEkleSil.SelectedIndex = 0;
			textBoxAtaKasa.Focus();
		}

		private void button4_Click_1(object sender, System.EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			textKMiktar.Text = "";
			textBoxKasa.Text = "";
			textKasaStokAdi.Text = "";
			textKasaStokKodu.Text = "";
			textKasaBirim.Text = "";
			textBoxKasa.Focus();
			return;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(textBoxAtaKasa.Text.Length < 1)
				{
					Utility.Engine.Hata("Once Ata Kasayi Okutun!");
					textBoxAtaKasa.Text = "";
					textBoxAtaKasa.Focus();
					return;
				}
            Utility.Engine.sql = string.Format("EXEC dbo.KasaBulKasaTransfer N'{0}'", Utility.Engine.SqlTemizle(textBoxKasa.Text));

                //ilkinin iş emri vardaiya personel = olursa aktara bilsin
                
            DataTable dtx = new DataTable();

            Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dtx);

            if (dtx != null && dtx.Rows.Count > 0)
            {
               if (dtx.Rows[0]["DepoKodu"].ToString() != textDepo.Text)
               {
                  Utility.Engine.Hata("Ata Kasa Depo Bilgisi Ve Kasa Depo Bilgisi Farkli Transfer Edilemez!");
                  textBoxKasa.Focus();
                  textBoxKasa.SelectAll();
                  return;
               }
               comboBoxEkleSil.SelectedIndex = 0;
               textBoxKasa.Text = dtx.Rows[0]["SeriliBarkod"].ToString();
               textKasaStokKodu.Text = dtx.Rows[0]["StokKodu"].ToString();
               textKasaStokAdi.Text = dtx.Rows[0]["StokAdi"].ToString();
               textKasaBirim.Text = dtx.Rows[0]["Birim"].ToString();
               textKMiktar.Text = Convert.ToDecimal(dtx.Rows[0]["Miktar"].ToString()).ToString();
               textMiktar.Focus();
               return;
            }
            else
            {
               Temizle();
               Utility.Engine.Hata("Seri Bilgisi Sistemde Bulunamadi!");
               textBoxKasa.Focus();
               textBoxKasa.SelectAll();
               return;
            }
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Seri Sorgulanamadi.");
            textBoxKasa.Focus();
            textBoxKasa.SelectAll();
            return;
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{
            if (!Utility.Engine.Sor("Yapilan işlemler Kaydedilsinmi?")) return;

            if(textBoxAtaKasa.Text.Length < 1)
				{
					Utility.Engine.Hata("Ata Kasayi Okutun!");
					textBoxAtaKasa.Focus();
					return;
				}

				if(textKasaStokKodu.Text.Length > 0 && textAtaStokKodu.Text != textKasaStokKodu.Text)
				{
					Utility.Engine.Hata("Kasa Stok Koduyla AtaKasa Stok Kodu Farkli Birleştiremezsiniz!!!");
					return;
				}

            if (textKasaBirim.Text.Length > 0 && textAtaBirim.Text != textKasaBirim.Text)
				{
					Utility.Engine.Hata("Kasa Birimi ve AtaKasa Birimi Farkli Birleştiremezsiniz!!!");
					return;
				}

            if (textAtaStokKodu.Text == "" || textAtaBirim.Text == "")
            {
               Utility.Engine.Hata("Ata Kasayi Okutun!");
               textBoxAtaKasa.Focus();
               return;
            }

            Utility.Engine.sql = string.Format("EXEC dbo.KasalarArasiTransfer N'{0}',N'{1}','{2}',N'{3}',N'{4}','{5}'",
               Utility.Engine.SqlTemizle(textBoxAtaKasa.Text),
               Utility.Engine.SqlTemizle(textBoxKasa.Text),
               Convert.ToInt32(textMiktar.Text).ToString(),
               Utility.Engine.KullaniciKod,
               Utility.Engine.CihazID,
               comboBoxEkleSil.SelectedIndex.ToString());

				DataTable sonuc = new DataTable();
				Utility.Engine.dat.TableDoldur(Utility.Engine.sql,ref sonuc);

				if(sonuc != null && sonuc.Rows.Count > 0)
				{
					if(sonuc.Rows[0][0].ToString().ToUpper() != "OK")
					{
						Utility.Engine.Hata(sonuc.Rows[0][0].ToString().ToUpper());
						Temizle();
						return;
					}
				}
				else
				{
					Utility.Engine.Hata("Sunucu Yanit Vermedi!!");
					Temizle();
					return;
				}
            Temizle();
            Utility.Engine.Tamam("işlem Tamamlandi!");
            textBoxAtaKasa.Focus();
            return;
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Genel Hata:" + exc.Message);
				return;
			}
		}

		private void textBoxKasa_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
                if (Karsilastir(textBoxAtaKasa.Text, textBoxKasa.Text).Trim() != "1")
                {

                    MessageBox.Show("BU KASALAR BiRLEşTiRiLEMEZ (VARDIYA VEYA işEMRi FARKLI)","Dikkat...!");
                    return;
                }

				button2_Click(null,null);
			}
		}

        private string Karsilastir(string seri1,string seri2)
        {
            Utility.Engine.sql = @"exec  dbo.TransKontrol  N'" + seri1.Trim() + "',N'" + seri2.Trim() + "'";

            return Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);
        }

      private void comboBoxEkleSil_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

	}
}
