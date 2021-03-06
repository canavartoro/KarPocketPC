using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for StokSec.
	/// </summary>
	public class SerisizStokSec : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxStokBarkodu;
		private System.Windows.Forms.TextBox textBoxStokKodu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxStokAdi;
		private System.Windows.Forms.TextBox textBoxStokAdi2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonStokBarkodSil;
		private System.Windows.Forms.Button buttonStokAdi2Sil;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader COLUMN_StokKodu;
		private System.Windows.Forms.ColumnHeader COLUMN_StokAdi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxBirim;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxMiktar;
		private System.Windows.Forms.Button buttonEkle;
		private System.Windows.Forms.Button buttonCik;
		private System.Windows.Forms.Button buttonStokKoduSil;
		private System.Windows.Forms.ColumnHeader COLUMN_StokAdi2;
		private System.Windows.Forms.ColumnHeader COLUMN_Diger1;
		private System.Windows.Forms.ColumnHeader COLUMN_Diger2;
		//public Engine Utility.Engine;
		private System.Windows.Forms.Panel panel2;
		public ListView mainlist;
		public string siparisNo = "";
		public bool siparisIliski = false;
		public bool sayim = false;
		public string CikanDepo = "";
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonyildiz;
		public string DonemKodu = "";
		//240; 328
	
		public SerisizStokSec()
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStokBarkodu = new System.Windows.Forms.TextBox();
            this.textBoxStokKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStokAdi = new System.Windows.Forms.TextBox();
            this.textBoxStokAdi2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStokAdi2Sil = new System.Windows.Forms.Button();
            this.buttonStokKoduSil = new System.Windows.Forms.Button();
            this.buttonStokBarkodSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.COLUMN_StokKodu = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_StokAdi = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_StokAdi2 = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_Diger1 = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_Diger2 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBirim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonCik = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonyildiz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.Text = "Stok Barkodu:";
            // 
            // textBoxStokBarkodu
            // 
            this.textBoxStokBarkodu.BackColor = System.Drawing.Color.Yellow;
            this.textBoxStokBarkodu.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxStokBarkodu.Location = new System.Drawing.Point(88, 8);
            this.textBoxStokBarkodu.Name = "textBoxStokBarkodu";
            this.textBoxStokBarkodu.Size = new System.Drawing.Size(112, 23);
            this.textBoxStokBarkodu.TabIndex = 10;
            this.textBoxStokBarkodu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStokBarkodu_KeyUp);
            this.textBoxStokBarkodu.TextChanged += new System.EventHandler(this.textBoxStokBarkodu_TextChanged);
            // 
            // textBoxStokKodu
            // 
            this.textBoxStokKodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxStokKodu.Location = new System.Drawing.Point(88, 27);
            this.textBoxStokKodu.Name = "textBoxStokKodu";
            this.textBoxStokKodu.Size = new System.Drawing.Size(112, 23);
            this.textBoxStokKodu.TabIndex = 4;
            this.textBoxStokKodu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStokKodu_KeyUp);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.Text = "Stok Kodu:";
            // 
            // textBoxStokAdi
            // 
            this.textBoxStokAdi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxStokAdi.Location = new System.Drawing.Point(0, 48);
            this.textBoxStokAdi.Name = "textBoxStokAdi";
            this.textBoxStokAdi.Size = new System.Drawing.Size(232, 23);
            this.textBoxStokAdi.TabIndex = 5;
            this.textBoxStokAdi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStokAdi_KeyUp);
            // 
            // textBoxStokAdi2
            // 
            this.textBoxStokAdi2.Location = new System.Drawing.Point(88, 69);
            this.textBoxStokAdi2.Name = "textBoxStokAdi2";
            this.textBoxStokAdi2.Size = new System.Drawing.Size(112, 23);
            this.textBoxStokAdi2.TabIndex = 6;
            this.textBoxStokAdi2.Visible = false;
            this.textBoxStokAdi2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStokAdi2_KeyUp);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.Text = "Stok Adi 2:";
            this.label4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.buttonStokAdi2Sil);
            this.panel1.Controls.Add(this.buttonStokKoduSil);
            this.panel1.Controls.Add(this.buttonStokBarkodSil);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxStokKodu);
            this.panel1.Controls.Add(this.textBoxStokAdi);
            this.panel1.Controls.Add(this.textBoxStokAdi2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxStokBarkodu);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 72);
            // 
            // buttonStokAdi2Sil
            // 
            this.buttonStokAdi2Sil.Location = new System.Drawing.Point(201, 71);
            this.buttonStokAdi2Sil.Name = "buttonStokAdi2Sil";
            this.buttonStokAdi2Sil.Size = new System.Drawing.Size(28, 21);
            this.buttonStokAdi2Sil.TabIndex = 0;
            this.buttonStokAdi2Sil.Text = "X";
            this.buttonStokAdi2Sil.Visible = false;
            this.buttonStokAdi2Sil.Click += new System.EventHandler(this.buttonStokAdi2Sil_Click);
            // 
            // buttonStokKoduSil
            // 
            this.buttonStokKoduSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonStokKoduSil.Location = new System.Drawing.Point(216, 28);
            this.buttonStokKoduSil.Name = "buttonStokKoduSil";
            this.buttonStokKoduSil.Size = new System.Drawing.Size(16, 21);
            this.buttonStokKoduSil.TabIndex = 1;
            this.buttonStokKoduSil.Text = ">>";
            this.buttonStokKoduSil.Click += new System.EventHandler(this.buttonStokKoduSil_Click);
            // 
            // buttonStokBarkodSil
            // 
            this.buttonStokBarkodSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonStokBarkodSil.Location = new System.Drawing.Point(216, 8);
            this.buttonStokBarkodSil.Name = "buttonStokBarkodSil";
            this.buttonStokBarkodSil.Size = new System.Drawing.Size(16, 21);
            this.buttonStokBarkodSil.TabIndex = 2;
            this.buttonStokBarkodSil.Text = "X";
            this.buttonStokBarkodSil.Click += new System.EventHandler(this.buttonStokBarkodSil_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(200, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "T";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(200, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(16, 21);
            this.button2.TabIndex = 11;
            this.button2.Text = "T";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.COLUMN_StokKodu);
            this.listView1.Columns.Add(this.COLUMN_StokAdi);
            this.listView1.Columns.Add(this.COLUMN_StokAdi2);
            this.listView1.Columns.Add(this.COLUMN_Diger1);
            this.listView1.Columns.Add(this.COLUMN_Diger2);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(235, 128);
            this.listView1.TabIndex = 1;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // COLUMN_StokKodu
            // 
            this.COLUMN_StokKodu.Text = "StokKodu";
            this.COLUMN_StokKodu.Width = 80;
            // 
            // COLUMN_StokAdi
            // 
            this.COLUMN_StokAdi.Text = "StokAdi";
            this.COLUMN_StokAdi.Width = 150;
            // 
            // COLUMN_StokAdi2
            // 
            this.COLUMN_StokAdi2.Text = "Stok Adi2";
            this.COLUMN_StokAdi2.Width = 40;
            // 
            // COLUMN_Diger1
            // 
            this.COLUMN_Diger1.Text = "Diger 1";
            this.COLUMN_Diger1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.COLUMN_Diger1.Width = 50;
            // 
            // COLUMN_Diger2
            // 
            this.COLUMN_Diger2.Text = "Diger 2";
            this.COLUMN_Diger2.Width = 60;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.Text = "Birim:";
            // 
            // comboBoxBirim
            // 
            this.comboBoxBirim.Location = new System.Drawing.Point(32, 0);
            this.comboBoxBirim.Name = "comboBoxBirim";
            this.comboBoxBirim.Size = new System.Drawing.Size(72, 23);
            this.comboBoxBirim.TabIndex = 1;
            this.comboBoxBirim.SelectedIndexChanged += new System.EventHandler(this.comboBoxBirim_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(104, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.Text = "Mkt:";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.BackColor = System.Drawing.Color.Orange;
            this.textBoxMiktar.Location = new System.Drawing.Point(136, 0);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(72, 23);
            this.textBoxMiktar.TabIndex = 4;
            this.textBoxMiktar.WordWrap = false;
            this.textBoxMiktar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMiktar_KeyDown);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(152, 24);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(80, 32);
            this.buttonEkle.TabIndex = 5;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonCik
            // 
            this.buttonCik.Location = new System.Drawing.Point(8, 24);
            this.buttonCik.Name = "buttonCik";
            this.buttonCik.Size = new System.Drawing.Size(88, 32);
            this.buttonCik.TabIndex = 6;
            this.buttonCik.Text = "ÇIK";
            this.buttonCik.Click += new System.EventHandler(this.buttonCik_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.buttonyildiz);
            this.panel2.Controls.Add(this.comboBoxBirim);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxMiktar);
            this.panel2.Controls.Add(this.buttonEkle);
            this.panel2.Controls.Add(this.buttonCik);
            this.panel2.Location = new System.Drawing.Point(0, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 64);
            // 
            // buttonyildiz
            // 
            this.buttonyildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonyildiz.Location = new System.Drawing.Point(208, 0);
            this.buttonyildiz.Name = "buttonyildiz";
            this.buttonyildiz.Size = new System.Drawing.Size(24, 22);
            this.buttonyildiz.TabIndex = 0;
            this.buttonyildiz.Text = "*";
            this.buttonyildiz.Click += new System.EventHandler(this.buttonyildiz_Click);
            // 
            // SerisizStokSec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "SerisizStokSec";
            this.Text = "Serisiz Stok Seçimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SerisizStokSec_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void buttonStokBarkodSil_Click(object sender, System.EventArgs e)
		{
			temizle();
		}

		private void buttonStokKoduSil_Click(object sender, System.EventArgs e)
		{
			OzelSecim oz = new OzelSecim();
			oz.str_ad = "StokAdi";
			oz.str_kod = "StokKodu";
			oz.str_ozel = "StokAdi2";
			oz.tablo = "stok_tanim_ust";
			oz.order_by = "StokKodu";
			oz.str_ozel = "' ' AS OZEL";
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxStokKodu.Text = oz.kod;
				textBoxStokAdi.Text = oz.ad;
				textBoxStokKodu_KeyUp((object)textBoxStokKodu,new System.Windows.Forms.KeyEventArgs(System.Windows.Forms.Keys.Enter));
			}
//			Sec s=new Sec();
//			
//			s.sql="SELECT StokKodu,StokAdi,StokAdi2,Diger1,Diger2 FROM stok_tanim_ust ";
//			s.tablename="StokTanimlari";
//			
//			if(s.ShowDialog()!=DialogResult.OK)
//				return;
//
//			if(s.dr["StokKodu"]!=DBNull.Value)
//			{
//				textBoxStokKodu.Text=s.dr["StokKodu"].ToString();
//			}
//			if(s.dr["StokAdi"]!=DBNull.Value)
//			{
//				textBoxStokAdi.Text = s.dr["StokAdi"].ToString();
//			}
//			Application.DoEvents();
		}

		private void buttonStokAdiSil_Click(object sender, System.EventArgs e)
		{
			textBoxStokAdi.Text="";
			textBoxStokKodu.Text = "";
			textBoxMiktar.Text = "";
			textBoxStokKodu.Focus();
			return;
		}

		private void buttonStokAdi2Sil_Click(object sender, System.EventArgs e)
		{
			textBoxStokAdi2.Text="";
			textBoxStokAdi2.Focus();
		}

		private void buttonCik_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void SerisizStokSec_Load(object sender, System.EventArgs e)
		{
			textBoxStokBarkodu.Focus();
			return;
		}

		private void textBoxStokBarkodu_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				/*Utility.Engine.sql=@"SELECT stok_tanim_ust.StokKodu,stok_tanim_ust.StokAdi,stok_tanim_ust.StokAdi2,stok_tanim_ust.Diger1,stok_tanim_ust.Diger2 FROM stok_tanim_ust 
						INNER JOIN stok_barkod ON stok_tanim_ust.StokKodu=stok_barkod.StokKodu";
				Utility.Engine.sql+=" WHERE stok_barkod.Barkod LIKE '%";
				Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxStokBarkodu.Text.Trim()).Replace("|","");;
				Utility.Engine.sql+="%'";
				refresh();*/

				Utility.Engine.sql = string.Format(@"SELECT TOP 20 stok_tanim_ust.StokKodu,stok_tanim_ust.StokAdi FROM stok_tanim_ust 
INNER JOIN stok_barkod ON stok_tanim_ust.StokKodu=stok_barkod.StokKodu
WHERE stok_barkod.Barkod like '%{0}%'  ",Utility.Engine.SqlTemizle(textBoxStokBarkodu.Text.Trim()));

				System.Data.IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);
				if(dr != null && dr.Read())
				{
					if(!dr.IsDBNull(0))
						textBoxStokKodu.Text = dr.GetValue(0).ToString();
					if(!dr.IsDBNull(1))
						textBoxStokAdi.Text = dr.GetValue(1).ToString();

					if(dr != null)
						dr.Close();
					dr = null;

					if(textBoxStokBarkodu.Text != "" && textBoxStokAdi.Text != "")
						textBoxStokKodu_KeyUp((object)textBoxStokKodu,new System.Windows.Forms.KeyEventArgs(System.Windows.Forms.Keys.Enter));
				}

			}
		}
		public void refresh()
		{
			comboBoxBirim.Items.Clear();
			Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
			if(listView1.Items.Count==1)
				listView1.Items[0].Selected=true;	
		}

		private void temizle()
		{
			textBoxStokBarkodu.Text="";
			textBoxStokKodu.Text = "";
			textBoxStokAdi.Text = "";
			textBoxMiktar.Text = "";
			listView1.Items.Clear();
			comboBoxBirim.Items.Clear();
			textBoxStokBarkodu.Focus();
		}
		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count<1)
				return;
			if(listView1.SelectedIndices[0]<0)
				return;

			comboBoxBirim.Items.Clear();

			Utility.Engine.sql="SELECT Birim,Miktar,AnaBirim From stok_tanim_detay WHERE StokKodu='";
			Utility.Engine.sql+=listView1.Items[listView1.SelectedIndices[0]].Text;
			Utility.Engine.sql+="'";

			System.Data.IDataReader rd=Utility.Engine.dat.TSelect(Utility.Engine.sql);

			int row,anabirim=0;
			while(rd!=null && rd.Read())
			{
				row=comboBoxBirim.Items.Add(rd.GetValue(rd.GetOrdinal("Birim")).ToString());

				if(rd.GetValue(rd.GetOrdinal("AnaBirim")).ToString()=="E")
					anabirim=row;
			}
			if(comboBoxBirim.Items.Count>0)
				comboBoxBirim.SelectedIndex=anabirim;

			if(rd!=null)
				rd.Close();
		}

		private void textBoxStokKodu_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				Utility.Engine.sql="SELECT TOP 20 StokKodu,StokAdi,StokAdi2,Diger1,Diger2 From stok_tanim_ust ";
				Utility.Engine.sql+=" WHERE StokKodu LIKE '";
				Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxStokKodu.Text).Replace("|","");
				Utility.Engine.sql += "'";
				refresh();
			}
		}

		private void buttonEkle_Click(object sender, System.EventArgs e)
		{
			EkleYeni();
		}

		private void comboBoxBirim_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			textBoxMiktar.SelectAll();
			textBoxMiktar.Focus();
		}

		private void textBoxMiktar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyData==Keys.Enter)
			{
				buttonEkle_Click(null,null);
			}
		}
		private void EkleYeni()
		{
			string stokkodu,stokadi,birim,miktar;
			double i_miktar = 0;

			if(listView1.Items.Count<1)
			{
				return;
			}
			if(listView1.SelectedIndices.Count<1)
			{
				return;
			}

			if(comboBoxBirim.Items.Count<1)
			{
				MessageBox.Show("Birimi olmayan stok işlem göremez!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxStokBarkodu.Text = "";
				textBoxMiktar.Text = "";
				textBoxStokKodu.Text = "";
				textBoxStokBarkodu.Focus();
				return;
			}

			if(textBoxMiktar.Text.Length<1)
			{
				MessageBox.Show("Miktar girilmemiş!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxMiktar.Focus();
				return;
			}

			try
			{
				int endex = textBoxMiktar.Text.IndexOf("*");

				if (endex >= 0)
				{
					double koli = 0, koliadet = 0;
					koli = Convert.ToDouble(textBoxMiktar.Text.Substring(0, endex));
					koliadet = Convert.ToDouble(textBoxMiktar.Text.Substring(endex + 1, textBoxMiktar.Text.Length - (endex + 1)));
					i_miktar = koli * koliadet;
				}
				else
				{ 
					i_miktar = Convert.ToDouble(textBoxMiktar.Text);
				}

				if(i_miktar<=0)
				{
					MessageBox.Show("Miktar girişi hatali!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
					textBoxMiktar.SelectAll();
					textBoxMiktar.Focus();
					return;
				}
			}
			catch(Exception)
			{
				MessageBox.Show("Miktar girişi hatali!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxMiktar.SelectAll();
				textBoxMiktar.Focus();
				return;
			}

			stokkodu=listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
			stokadi=listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text;
			birim=comboBoxBirim.Items[comboBoxBirim.SelectedIndex].ToString();
			miktar=textBoxMiktar.Text;

			if(stokkodu == "" || stokadi == "" || birim == "" || miktar == "")
			{
				MessageBox.Show(string.Format("Bilgiler Hatali Yada Eksik Tekrar Deneyin!\nStok:{0},Adi:{1},Birim:{2},Miktar:{3}",stokkodu,stokadi,birim,miktar),"DIKKAT!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				temizle();
				textBoxStokBarkodu.Focus();
				return;
			}

			#region depo&stok
			if(sayim == false && Utility.Engine.EksiStokOlmasin)
			{
				if(Utility.Engine.dat.TCount("select count(*) from depo_tanim (nolock) where DepoKodu = '" + CikanDepo + "' and Eksi = 'E'") < 1)
				{
					Utility.Engine.sql = "SELECT Miktar FROM depo_mevcut WHERE DepoKodu = '";
					Utility.Engine.sql += CikanDepo;
					Utility.Engine.sql += "' AND StokKodu = '";
					Utility.Engine.sql += stokkodu;
					Utility.Engine.sql += "' AND Birim = '";
					Utility.Engine.sql += birim;
					Utility.Engine.sql += "' ORDER BY Miktar DESC";
				

					double mky = Convert.ToDouble(Utility.Engine.dat.TCount(Utility.Engine.sql));

					if (mky < i_miktar)
					{
						MessageBox.Show(CikanDepo + "` DEPOSUNDA \"" + stokkodu + "\" MiKTARI YETERSiZ!", "DiKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
						temizle();
						textBoxStokBarkodu.Focus();
						return;
					}
				}
			}
			#endregion
			
			#region siparis&miktar
			if(siparisIliski)
			{
				Utility.Engine.sql = "SELECT TOP 1 SiparisMiktari - SevkMiktari AS Miktar FROM siparisler ";
				Utility.Engine.sql += " WHERE     (SiparisMiktari - SevkMiktari > 0) AND SiparisNo = '";
				Utility.Engine.sql += siparisNo;
				Utility.Engine.sql += "' AND StokKodu = '";
				Utility.Engine.sql += stokkodu;
				Utility.Engine.sql += "'";

				if (Utility.Engine.dat.TCount(Utility.Engine.sql) < i_miktar)
				{
					MessageBox.Show("SIPARIS MIKTARI ASILDI YADA LISTEDE OLMAYAN URUN \n<FAZLA SEVK>!!", "DIKKAT!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
					temizle();
					textBoxStokBarkodu.Focus();
					return;
				}
			}
			#endregion

			
			if(sayim)
			{
				#region sayim
				for(int i=0;i<mainlist.Items.Count;i++)
				{
					if(mainlist.Items[i].SubItems[0].Text == stokkodu && mainlist.Items[i].SubItems[4].Text.Equals(""))
					{
						Utility.Engine.sql = "UPDATE ambar_sayim SET ";
						Utility.Engine.sql += "Miktar = " + i_miktar.ToString();
						Utility.Engine.sql += ",CTarih = GETDATE(),KullaniciID = '" + Utility.Engine.KullaniciID;
						Utility.Engine.sql += "',CihazID = '" + Utility.Engine.CihazID + "'";
						Utility.Engine.sql += string.Format(" WHERE Donem = '{0}' AND StokKodu = '{1}' AND Birim = '{2}' AND RafKodu = '{3}' AND SeriliBarkod = '' ",
							DonemKodu,stokkodu,birim,CikanDepo);
						if(Utility.Engine.dat.TInsert(Utility.Engine.sql))
						{
							mainlist.Items[i].SubItems[3].Text = i_miktar.ToString();
							Utility.Engine.KlavyeAc(false);
							//Utility.Engine.WinApi.TPlaySound(Utility.Engine.STR_ProgramDizini + "\\islem.wav");
						}
						else
						{
							Utility.Engine.Hata("Kayit Hatasi:" + Utility.Engine.dat.STR_HataMesaji);
						}
						temizle();
						textBoxStokBarkodu.Focus();
						return;
					}
				}

				Utility.Engine.sql = "INSERT INTO ambar_sayim (Donem, StokKodu, Birim, Miktar, DepoKodu, RafKodu, SeriliBarkod, KullaniciID, CihazID) VALUES ('";
				Utility.Engine.sql += DonemKodu;
				Utility.Engine.sql += "','";
				Utility.Engine.sql += stokkodu;
				Utility.Engine.sql += "','";
				Utility.Engine.sql += birim;
				Utility.Engine.sql += "','";
				Utility.Engine.sql += miktar;
				Utility.Engine.sql += "','','";
				Utility.Engine.sql += CikanDepo;
				Utility.Engine.sql += "','','";
				Utility.Engine.sql += Utility.Engine.KullaniciID;
				Utility.Engine.sql += "','";
				Utility.Engine.sql += Utility.Engine.CihazID;
				Utility.Engine.sql += "')";

				if(Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{

					ListViewItem li = new ListViewItem();
					li.Text = stokkodu;
					li.SubItems.Add(stokadi);
					li.SubItems.Add(birim);
					li.SubItems.Add(i_miktar.ToString());
					li.SubItems.Add("");
					mainlist.Items.Add(li);

					Utility.Engine.KlavyeAc(false);
					//Utility.Engine.WinApi.TPlaySound(Utility.Engine.STR_ProgramDizini + "\\islem.wav");
				}
				else
				{
					Utility.Engine.Hata("Kayit Hatasi:" + Utility.Engine.dat.STR_HataMesaji);
				}

				temizle();
				textBoxStokBarkodu.Focus();
				return;
				#endregion
			}
			else
			{

				Utility.Engine.sql = "IF NOT EXISTS(SELECT * FROM terminal_girisi WHERE Islem = 'Serisiz Stok Transferi' AND Kullanici = '";
				Utility.Engine.sql += Utility.Engine.KullaniciID;
				Utility.Engine.sql += "' AND StokKodu = '";
				Utility.Engine.sql += stokkodu;
				Utility.Engine.sql += "' AND CikanDepo = '";
				Utility.Engine.sql += CikanDepo;
				Utility.Engine.sql += "'  AND FLAG = 'H' AND Birim = '";
				Utility.Engine.sql += birim;
				Utility.Engine.sql += "') BEGIN INSERT INTO terminal_girisi (Seri, Barkod, StokKodu, StokAdi, Birim, Miktar, GirenDepo, CikanDepo, BelgeNo, Kullanici, Islem, Ozel) VALUES     ('','','";
				Utility.Engine.sql += stokkodu;
				Utility.Engine.sql += "','";
				Utility.Engine.sql += stokadi;
				Utility.Engine.sql += "','";
				Utility.Engine.sql += birim;
				Utility.Engine.sql += "','";
				Utility.Engine.sql += miktar;
				Utility.Engine.sql += "','','";
				Utility.Engine.sql += CikanDepo;
				Utility.Engine.sql += "','','";
				Utility.Engine.sql += Utility.Engine.KullaniciID;
				Utility.Engine.sql += "','Serisiz Stok Transferi','') ; SELECT 'OK' RETURN END ELSE BEGIN SELECT 'YOK' END";

				if(Utility.Engine.dat.TSelectScalar(Utility.Engine.sql) != "OK")
				{
					MessageBox.Show(string.Format("KAYDEDiLEMEDi DAHA ÖNCE EKLENMiş ÜRÜN EKLENEMEZ!"),"DIKKAT!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
					temizle();
					textBoxStokBarkodu.Focus();
					return;
				}

				ListViewItem item = new ListViewItem();
				item.Text = stokkodu;
				item.SubItems.Add(stokadi);
				item.SubItems.Add(birim);
				item.SubItems.Add(miktar);
				item.SubItems.Add("");
				item.SubItems.Add(CikanDepo);
				mainlist.Items.Add(item);
			}
			
			Utility.Engine.KlavyeAc(false);
			//Utility.Engine.WinApi.TPlaySound(Utility.Engine.STR_ProgramDizini + "\\islem.wav");
			temizle();
			textBoxStokBarkodu.Focus();
			return;
		}

		private void Ekle()
		{
			string stokkodu,stokadi,birim,miktar;

			if(listView1.Items.Count<1)
			{
				return;
			}
			if(listView1.SelectedIndices.Count<1)
			{
				return;
			}

			if(comboBoxBirim.Items.Count<1)
			{
				MessageBox.Show("Birimi olmayan stok işlem göremez!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}

			if(textBoxMiktar.Text.Length<1)
			{
				MessageBox.Show("Miktar girilmemiş!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxMiktar.Focus();
				return;
			}

			try
			{
				if(Convert.ToDouble(textBoxMiktar.Text)<=0)
				{
					MessageBox.Show("Miktar girişi hatali!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
					textBoxMiktar.SelectAll();
					textBoxMiktar.Focus();
					return;
				}
			}
			catch(Exception)
			{
				MessageBox.Show("Miktar girişi hatali!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxMiktar.SelectAll();
				textBoxMiktar.Focus();
				return;
			}

			stokkodu=listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
			stokadi=listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text;
			birim=comboBoxBirim.Items[comboBoxBirim.SelectedIndex].ToString();
			miktar=textBoxMiktar.Text;

			
			
			for(int i=0;i<mainlist.Items.Count;i++)
			{
				if(mainlist.Items[i].SubItems[0].Text==stokkodu)
				{
					if(mainlist.Items[i].SubItems[2].Text==birim)
					{
						miktar=mainlist.Items[i].SubItems[3].Text;
						mainlist.Items[i].SubItems[3].Text=Convert.ToString(Convert.ToDouble(mainlist.Items[i].SubItems[3].Text) + Convert.ToDouble(textBoxMiktar.Text));

						Utility.Engine.KlavyeAc(false);
						//Utility.Engine.WinApi.TPlaySound(Utility.Engine.STR_ProgramDizini + "\\islem.wav");
						textBoxMiktar.Text="";
						textBoxMiktar.Focus();

						return;
					}
				}
			}

			ListViewItem li=new ListViewItem(stokkodu);
			li.SubItems.Add(stokadi);
			li.SubItems.Add(birim);
			li.SubItems.Add(miktar);

			mainlist.Items.Add(li);
			
			Utility.Engine.KlavyeAc(false);
			//Utility.Engine.WinApi.TPlaySound(Utility.Engine.STR_ProgramDizini + "\\islem.wav");
			textBoxMiktar.Text="";
			textBoxMiktar.Focus();
		}

		private void textBoxStokAdi_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				Utility.Engine.sql="SELECT StokKodu,StokAdi,StokAdi2,Diger1,Diger2 From stok_tanim_ust ";
				Utility.Engine.sql+=" WHERE StokAdi LIKE '%";
				Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxStokAdi.Text).Replace("|","");;
				Utility.Engine.sql+="%'";
				refresh();
			}
		}

		private void textBoxStokAdi2_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				Utility.Engine.sql="SELECT StokKodu,StokAdi,StokAdi2,Diger1,Diger2 From stok_tanim_ust ";
				Utility.Engine.sql+=" WHERE StokAdi2 LIKE '%";
				Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxStokAdi2.Text).Replace("|","");;
				Utility.Engine.sql+="%'";
				refresh();
			}
		}

		private void listView1_ItemActivate(object sender, System.EventArgs e)
		{
			listView1_SelectedIndexChanged(sender,e);
		}

		private void textBoxStokBarkodu_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBoxStokBarkodu.Text;
			if(t.ShowDialog()==DialogResult.OK)
			{
				textBoxStokBarkodu.Text = t.textBox1.Text;
				textBoxStokBarkodu_KeyUp(null,new KeyEventArgs(Keys.Enter));
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBoxStokKodu.Text;
			if(t.ShowDialog()==DialogResult.OK)
			{
				textBoxStokKodu.Text = t.textBox1.Text;
				textBoxStokKodu_KeyUp(null,new KeyEventArgs(Keys.Enter));
			}
		}

		private void buttonyildiz_Click(object sender, System.EventArgs e)
		{
			textBoxMiktar.Focus();
			if(textBoxMiktar.Text.IndexOf("*") == -1)textBoxMiktar.Text += "*";
			textBoxMiktar.SelectionStart = textBoxMiktar.Text.Length;
		}
	}
}
