using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for SerisizTransfer.
	/// </summary>
	public class AmbarSayim : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCikanDepoSec;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button buttonBelgeNoSec;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader COLUMN_StokKodu;
		private System.Windows.Forms.ColumnHeader COLUMN_StokAdi;
		private System.Windows.Forms.ColumnHeader COLUMN_Birim;
		private System.Windows.Forms.ColumnHeader COLUMN_Miktar;
		private System.Windows.Forms.TabPage tabPage1;
        ////public Engine Utility.Engine;
        public Point clickpos;
		private System.Windows.Forms.TextBox textBoxSayimDepo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBoxDonem;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBoxBARKOD;
        private System.Windows.Forms.ColumnHeader COLUMN_SeriliBarkod;
        private System.Windows.Forms.TextBox textBoxPalet;
        private System.Windows.Forms.Button button6;
        private ColumnHeader COLUMN_PaletID;
        private Label label3;
        private Button button7;
        private Button button8;
        private Label menuItem_Bilgi;
        private ColumnHeader COLUMN_DepoKodu;
        private ComboBox comboBox1;
        private Button button5;
        private Button button9;
        private Button buttonSeriSil;
		public StokTransferEkBilgi stek;
        string depo,palet;
     
	
		public AmbarSayim()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			stek=new StokTransferEkBilgi();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxSayimDepo = new System.Windows.Forms.TextBox();
            this.textBoxBARKOD = new System.Windows.Forms.TextBox();
            this.textBoxPalet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCikanDepoSec = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonBelgeNoSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDonem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.COLUMN_SeriliBarkod = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_StokKodu = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_StokAdi = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_Birim = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_Miktar = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_PaletID = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_DepoKodu = new System.Windows.Forms.ColumnHeader();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuItem_Bilgi = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonSeriSil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.textBoxSayimDepo);
            this.panel1.Controls.Add(this.textBoxBARKOD);
            this.panel1.Controls.Add(this.textBoxPalet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonCikanDepoSec);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonBelgeNoSec);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxDonem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(2, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 88);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.Add("ANABiRiM");
            this.comboBox1.Items.Add("AMBALAJ");
            this.comboBox1.Location = new System.Drawing.Point(4, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(2, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.Text = "PaletID";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(207, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 20);
            this.button6.TabIndex = 9;
            this.button6.Text = "X";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxSayimDepo
            // 
            this.textBoxSayimDepo.BackColor = System.Drawing.Color.White;
            this.textBoxSayimDepo.Location = new System.Drawing.Point(69, 26);
            this.textBoxSayimDepo.Name = "textBoxSayimDepo";
            this.textBoxSayimDepo.Size = new System.Drawing.Size(113, 23);
            this.textBoxSayimDepo.TabIndex = 0;
            this.textBoxSayimDepo.TextChanged += new System.EventHandler(this.textBoxSayimDepo_TextChanged);
            this.textBoxSayimDepo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSayimDepo_KeyUp);
            this.textBoxSayimDepo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSayimDepo_KeyPress);
            // 
            // textBoxBARKOD
            // 
            this.textBoxBARKOD.BackColor = System.Drawing.Color.Yellow;
            this.textBoxBARKOD.Location = new System.Drawing.Point(69, 67);
            this.textBoxBARKOD.Name = "textBoxBARKOD";
            this.textBoxBARKOD.Size = new System.Drawing.Size(114, 23);
            this.textBoxBARKOD.TabIndex = 8;
            this.textBoxBARKOD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBARKOD_KeyUp);
            this.textBoxBARKOD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBARKOD_KeyPress);
            // 
            // textBoxPalet
            // 
            this.textBoxPalet.BackColor = System.Drawing.Color.Salmon;
            this.textBoxPalet.Location = new System.Drawing.Point(69, 46);
            this.textBoxPalet.Name = "textBoxPalet";
            this.textBoxPalet.Size = new System.Drawing.Size(114, 23);
            this.textBoxPalet.TabIndex = 7;
            this.textBoxPalet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPalet_KeyUp);
            this.textBoxPalet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPalet_KeyPress_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.Text = "Depo:";
            // 
            // buttonCikanDepoSec
            // 
            this.buttonCikanDepoSec.Location = new System.Drawing.Point(183, 25);
            this.buttonCikanDepoSec.Name = "buttonCikanDepoSec";
            this.buttonCikanDepoSec.Size = new System.Drawing.Size(24, 20);
            this.buttonCikanDepoSec.TabIndex = 2;
            this.buttonCikanDepoSec.Text = "...";
            this.buttonCikanDepoSec.Click += new System.EventHandler(this.buttonCikanDepoSec_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 20);
            this.button3.TabIndex = 3;
            this.button3.Text = "X";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBelgeNoSec
            // 
            this.buttonBelgeNoSec.Location = new System.Drawing.Point(183, 3);
            this.buttonBelgeNoSec.Name = "buttonBelgeNoSec";
            this.buttonBelgeNoSec.Size = new System.Drawing.Size(24, 20);
            this.buttonBelgeNoSec.TabIndex = 4;
            this.buttonBelgeNoSec.Text = "...";
            this.buttonBelgeNoSec.Click += new System.EventHandler(this.buttonBelgeNoSec_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.Text = "Donem:";
            // 
            // comboBoxDonem
            // 
            this.comboBoxDonem.Location = new System.Drawing.Point(70, 2);
            this.comboBoxDonem.Name = "comboBoxDonem";
            this.comboBoxDonem.Size = new System.Drawing.Size(114, 23);
            this.comboBoxDonem.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 9;
            this.button2.Text = ">>";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(207, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 20);
            this.button4.TabIndex = 10;
            this.button4.Text = "X";
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.COLUMN_SeriliBarkod);
            this.listView1.Columns.Add(this.COLUMN_StokKodu);
            this.listView1.Columns.Add(this.COLUMN_StokAdi);
            this.listView1.Columns.Add(this.COLUMN_Birim);
            this.listView1.Columns.Add(this.COLUMN_Miktar);
            this.listView1.Columns.Add(this.COLUMN_PaletID);
            this.listView1.Columns.Add(this.COLUMN_DepoKodu);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(239, 212);
            this.listView1.TabIndex = 1;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // COLUMN_SeriliBarkod
            // 
            this.COLUMN_SeriliBarkod.Text = "SeriliBarkod";
            this.COLUMN_SeriliBarkod.Width = 100;
            // 
            // COLUMN_StokKodu
            // 
            this.COLUMN_StokKodu.Text = "StokKodu";
            this.COLUMN_StokKodu.Width = 100;
            // 
            // COLUMN_StokAdi
            // 
            this.COLUMN_StokAdi.Text = "StokAdi";
            this.COLUMN_StokAdi.Width = 170;
            // 
            // COLUMN_Birim
            // 
            this.COLUMN_Birim.Text = "Birim";
            this.COLUMN_Birim.Width = 50;
            // 
            // COLUMN_Miktar
            // 
            this.COLUMN_Miktar.Text = "Miktar";
            this.COLUMN_Miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.COLUMN_Miktar.Width = 50;
            // 
            // COLUMN_PaletID
            // 
            this.COLUMN_PaletID.Text = "PaletID";
            this.COLUMN_PaletID.Width = 70;
            // 
            // COLUMN_DepoKodu
            // 
            this.COLUMN_DepoKodu.Text = "DepoKodu";
            this.COLUMN_DepoKodu.Width = 80;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(232, 270);
            this.tabPage1.Text = "Stok Böl";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(191, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 18);
            this.button7.TabIndex = 11;
            this.button7.Text = "Çik";
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 18);
            this.button8.TabIndex = 12;
            this.button8.Text = "Kaydet";
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // menuItem_Bilgi
            // 
            this.menuItem_Bilgi.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.menuItem_Bilgi.Location = new System.Drawing.Point(150, 2);
            this.menuItem_Bilgi.Name = "menuItem_Bilgi";
            this.menuItem_Bilgi.Size = new System.Drawing.Size(38, 18);
            this.menuItem_Bilgi.Text = "0";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(63, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 18);
            this.button5.TabIndex = 14;
            this.button5.Text = "Sayim Düzelt";
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(0, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 20);
            this.button9.TabIndex = 17;
            this.button9.Text = "Sayım Yap";
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // buttonSeriSil
            // 
            this.buttonSeriSil.Location = new System.Drawing.Point(72, 2);
            this.buttonSeriSil.Name = "buttonSeriSil";
            this.buttonSeriSil.Size = new System.Drawing.Size(72, 20);
            this.buttonSeriSil.TabIndex = 20;
            this.buttonSeriSil.Text = "Seri Sil";
            this.buttonSeriSil.Click += new System.EventHandler(this.buttonSeriSil_Click);
            // 
            // AmbarSayim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSeriSil);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.menuItem_Bilgi);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AmbarSayim";
            this.Text = "Ambar Sayim Ekrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SerisizTransfer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void Detaylar()
		{
			try
			{
                Utility.Engine.sql = string.Format("EXEC dbo.PaletDetaylari {0}", textBoxPalet.Text);
				listView1.Items.Clear();
				IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);
				if(dr != null)
				{
					while(dr.Read())
					{
						ListViewItem item = new ListViewItem();
						item.Text = dr.GetValue(1).ToString();
						item.SubItems.Add(dr.GetValue(2).ToString());
						item.SubItems.Add(dr.GetValue(3).ToString());
						item.SubItems.Add(dr.GetValue(4).ToString());
						item.SubItems.Add(dr.GetValue(0).ToString());
						listView1.Items.Add(item);
					}

					if(dr != null)dr.Close();
				}
				if(dr != null)
					dr.Close();
				return;
			}
			catch
			{
				return;
			}
		}
		private void Donemler()
		{
			try
			{
				Utility.Engine.sql = "SELECT DonemKodu FROM donem_tanim WITH (NOLOCK) WHERE Durum = 'E' and Flag = 'H' ORDER BY DonemKodu";
				Utility.Engine.dat.ComboDoldur(Utility.Engine.sql,comboBoxDonem);

                if (comboBoxDonem.Items.Count > 0)
                    comboBoxDonem.SelectedIndex = 0;
			}
			catch
			{
			}
		}
		private void Okunanlar()
		{
			Utility.Engine.sql = string.Format(@"SELECT StokKodu, StokAdi, Birim, SUM(Miktar) AS miktar,GirenDepo, CikanDepo
FROM         terminal_girisi
WHERE     (Islem = 'Serisiz Stok Transferi') AND (Kullanici = '{0}') AND  (FLAG = 'H')
GROUP BY StokKodu, StokAdi, Birim, GirenDepo, CikanDepo",Utility.Engine.KullaniciID);
			Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
		}

        private void BarkodEkle()
        {
            if (textBoxBARKOD.Text.Length < 1)
            {
                textBoxBARKOD.Focus();
                textBoxBARKOD.SelectAll();
                return;
            }
            if (comboBoxDonem.SelectedItem == null)
            {
                Utility.Engine.Hata("Donem Kodu Secilmedi!");
                comboBoxDonem.Focus();
                return;
            }
            if (textBoxSayimDepo.Text.Length < 1)
            {
                Utility.Engine.Hata("Depo Kodu Secilmedi!");
                return;
            }

            double anabirimMilktar = 0;


            if (comboBox1.SelectedIndex == 0)
            {

                MiktarSor ms = new MiktarSor();
                if (ms.ShowDialog() == DialogResult.OK)
                {
                    anabirimMilktar = ms.miktar;
                }

            }





            Utility.Engine.sql = string.Format(

                @"EXEC [dbo].[sayimseri]  N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}'",
                Utility.Engine.Turkcele(textBoxBARKOD.Text).Trim().ToUpper().Replace("\r", "").Replace("\n", "").Replace("\r\n", ""),
                Utility.Engine.KullaniciKod,
                comboBoxDonem.SelectedItem.ToString(),
                Utility.Engine.SqlTemizle(textBoxSayimDepo.Text).Replace("\r", "").Replace("\n", "").Replace("\r\n", ""),
                Utility.Engine.CihazID,
                Utility.Engine.SqlTemizle(textBoxPalet.Text).Trim().Replace("\r", "").Replace("\n", "").Replace("\r\n", ""),
                comboBox1.SelectedIndex.ToString(),
                anabirimMilktar
                );


            DataTable dt = null;

           dt=Utility.Engine.dat.TableDon(Utility.Engine.sql);

            if (dt.Rows.Count < 1)
            {
                Utility.Engine.Hata("Sunucu Yanit Vermedi <" + Utility.Engine.dat.Fault + ">");
                menuItem_Bilgi.Text = listView1.Items.Count.ToString();
                Cursor.Current = Cursors.Default;
                textBoxBARKOD.Text = "";
                textBoxBARKOD.Focus();
                return;
            }

            string  snc="";

            snc=dt.Rows[0][0].ToString().Trim();

            if (snc=="-1")
            {
                Utility.Engine.Hata(dt.Rows[0][1].ToString().Trim());
                menuItem_Bilgi.Text = listView1.Items.Count.ToString();
                Cursor.Current = Cursors.Default;
                textBoxBARKOD.Text = "";
                textBoxBARKOD.Focus();
                return;
            }

            Utility.Engine.dat.tabledenListDoldur(dt, listView1);

            menuItem_Bilgi.Text = listView1.Items.Count.ToString();
            Cursor.Current = Cursors.Default;
            textBoxBARKOD.Text = "";
            textBoxBARKOD.Focus();
            return;

        }

		private void buttonCik_Click(object sender, System.EventArgs e)
		{
			
		}
	
        private void buttonYeniBelgeNo_Click(object sender, System.EventArgs e)
		{
			
		}

        private void Sayilanlar()
        {
            Utility.Engine.sql = string.Format(
            @"SELECT     
                ambar_sayim.SeriliBarkod,ambar_sayim.StokKodu, stok_tanim_ust.StokAdi, ambar_sayim.Birim, 
                ambar_sayim.Miktar,ambar_sayim.RafKodu as [PaletID] 
                FROM
                ambar_sayim INNER JOIN                 
                stok_tanim_ust ON ambar_sayim.StokKodu = stok_tanim_ust.StokKodu
                WHERE     
                (ambar_sayim.RafKodu = N'{0}') AND (ambar_sayim.Donem = N'{1}')"

            , Utility.Engine.SqlTemizle(textBoxSayimDepo.Text), comboBoxDonem.SelectedItem.ToString());

            Utility.Engine.dat.ListDoldur(ref listView1, Utility.Engine.sql);

            menuItem_Bilgi.Text = listView1.Items.Count.ToString();

        }

        private void Sayilanlar1(string snc)
        {
            Utility.Engine.sql = string.Format(
            @"SELECT     
                ambar_sayim.SeriliBarkod,ambar_sayim.StokKodu, stok_tanim_ust.StokAdi, ambar_sayim.Birim, 
                ambar_sayim.Miktar,ambar_sayim.RafKodu as [PaletID] 
                FROM
                ambar_sayim INNER JOIN                 
                stok_tanim_ust ON ambar_sayim.StokKodu = stok_tanim_ust.StokKodu
                WHERE     
                (ambar_sayim.RafKodu = N'{0}') AND (ambar_sayim.Donem = N'{1}')"

            , Utility.Engine.SqlTemizle(snc), comboBoxDonem.SelectedItem.ToString());

            Utility.Engine.dat.ListDoldur(ref listView1, Utility.Engine.sql);

            menuItem_Bilgi.Text = listView1.Items.Count.ToString();

        }

		private void buttonCikanDepoSec_Click(object sender, System.EventArgs e)
		{
			if(comboBoxDonem.SelectedItem == null)
			{
				Utility.Engine.Hata("Donem Kodu Secilmeli!");
				comboBoxDonem.Focus();
				return;
			}
			textBoxSayimDepo.Text = "";
			listView1.Items.Clear();
			DepoSecimOzel oz = new DepoSecimOzel();
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxSayimDepo.Text = oz.DepoKodu;
				try
				{
					Utility.Engine.sql = string.Format("SELECT COUNT(*) FROM depo_tanim (NOLOCK) WHERE Sayim = N'E' AND DepoKodu = N'{0}'",textBoxSayimDepo.Text);
					if(Utility.Engine.dat.TCount(Utility.Engine.sql) < 1)
					{
						MessageBox.Show("Raf Kilitli Sayim Yapilamaz!","HATA!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
						textBoxSayimDepo.Text = "";
						return;
					}
					else
					{
						Sayilanlar();
					}
				}
				catch(Exception exc)
				{
					MessageBox.Show("Hata:" + exc.Message);
				}
				textBoxBARKOD.Focus();
				return;
			}

		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			listView1.Items.Clear();
			textBoxSayimDepo.Text = "";
            textBoxPalet.Text = "";
			textBoxBARKOD.Focus();
			return;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			textBoxSayimDepo.Text="";
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			SerisizStokSec sc=new SerisizStokSec();
			sc.mainlist=listView1;
			sc.ShowDialog();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count<1)
			{
				MessageBox.Show("Seçili Satir Yok","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}
			if(MessageBox.Show(listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text + " Numarali Stok Listeden Çikarilacak!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
				return;

			listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Listedeki Tüm Barkodlar Silinecek!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
				return;

			listView1.Items.Clear();
		}

		private void buttonKaydet_Click(object sender, System.EventArgs e)
		{
		}

		private void buttonKopyala_Click(object sender, System.EventArgs e)
		{
			
		}

		private void listView1_ItemActivate(object sender, System.EventArgs e)
		{

		}

		private void SerisizTransfer_Load(object sender, System.EventArgs e)
		{
            //  1  ambalaj  0  anabirim

            if (comboBox1.Items.Count > 0)
            { comboBox1.SelectedIndex = 1; }
			
			this.Text = "Ambar Sayim Ekrani " + Utility.Engine.KullaniciID;
			Donemler();
			textBoxSayimDepo.Focus();
			return;
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			SerisizStokSec sc=new SerisizStokSec();
			sc.mainlist=listView1;
			sc.ShowDialog();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			if(comboBoxDonem.SelectedItem == null)
			{
				Utility.Engine.Hata("Donem Secilmedi!");
				comboBoxDonem.Focus();
				return;
			}
			if(textBoxSayimDepo.Text == "")
			{
				MessageBox.Show("SAYIM DEPOSUNU SEÇMELiSiNiZ!","DiKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxSayimDepo.Focus();
				return;
			}
			SerisizStokSec sc=new SerisizStokSec();
			sc.siparisIliski = false;
			sc.sayim = true;
			sc.DonemKodu = comboBoxDonem.SelectedItem.ToString();
			sc.siparisNo = stek.textBoxIrsaliyeNo.Text;
			sc.CikanDepo = textBoxSayimDepo.Text;
			sc.mainlist = listView1;
			sc.ShowDialog();
			menuItem_Bilgi.Text = listView1.Items.Count.ToString();
			this.Text = "Ambar Sayim Ekrani " + listView1.Items.Count.ToString();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			if(comboBoxDonem.SelectedItem == null)
			{Utility.Engine.Hata("Donem Secilmedi");return;}
			if(textBoxSayimDepo.Text.Equals(""))
			{Utility.Engine.Hata("Sayim Deposu Secilmedi");return;}
			if(listView1.SelectedIndices.Count<1)
			{
				MessageBox.Show("Seçili Satir Yok","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}
			if(MessageBox.Show(listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text + " Numarali Stok Listeden Çikarilacak!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
				return;
			
			Utility.Engine.sql = string.Format("DELETE FROM ambar_sayim WHERE SeriliBarkod = '{0}' AND StokKodu = '{1}' AND Donem = '{2}' AND RafKodu = '{3}' ",
				listView1.Items[listView1.SelectedIndices[0]].SubItems[4].Text,
				listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text,
				comboBoxDonem.SelectedItem.ToString(),textBoxSayimDepo.Text);
			if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
			{
				Utility.Engine.Hata("Kayit Hatasi Veri Silinemedi!");
				return;
			}

			listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
			menuItem_Bilgi.Text = listView1.Items.Count.ToString();
			
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			if(comboBoxDonem.SelectedItem == null)
			{Utility.Engine.Hata("Donem Secilmedi");return;}
			if(listView1.Items.Count < 1)
			{Utility.Engine.Hata("Listede Okutulmus Stok Yok");return;}
			if(textBoxSayimDepo.Text.Equals(""))
			{Utility.Engine.Hata("Sayim Deposu Secilmedi");return;}
			if(MessageBox.Show("Listedeki Tüm Stoklar Silinecek!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
				return;

			Utility.Engine.sql = string.Format("DELETE FROM ambar_sayim WHERE RafKodu = '{0}' AND Donem = '{1}' ",textBoxSayimDepo.Text,comboBoxDonem.SelectedItem.ToString());

			if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
			{
				Utility.Engine.Hata("Kayit Hatasi Veriler Silinemedi!");
				return;
			}
			listView1.Items.Clear();
			this.Text = "Ambar Sayim Ekrani " + listView1.Items.Count.ToString();
			menuItem_Bilgi.Text = listView1.Items.Count.ToString();
			textBoxBARKOD.Text = "";
			textBoxBARKOD.Focus();
			return;
		}

		private void menuItem2_Click_1(object sender, System.EventArgs e)
		{
			if( listView1.Items.Count>0)
			{
				if(MessageBox.Show("Yapilan işlem Kaydedilmemiş\nKaydetmeden istiyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)!=DialogResult.OK)
					return;
			}
			textBoxSayimDepo.Text="";
			stek.textBoxAciklama1.Text="";
			stek.textBoxAciklama2.Text="";
			listView1.Items.Clear();
		
			stek.comboBoxHareketTipi.SelectedIndex = -1;
			textBoxSayimDepo.BackColor=Color.White;
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			if(listView1.Items.Count>0)
			{
				if(MessageBox.Show("Yapilan işlemler kaydedilmedi\nÇikmak için onay veriniz","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)!=DialogResult.OK)
					return;
			}
			Close();
		}

		private void buttonAciklama1Sil_Click(object sender, System.EventArgs e)
		{
			stek.textBoxAciklama1.Text="";
		}

		private void menuItem1_Click_1(object sender, System.EventArgs e)
		{
			Yardim yar=new Yardim();
			yar.Text="Bilgi";
			yar.label1.Text="Toplam Kalem Sayisi=" + listView1.Items.Count.ToString() + "\n";
			yar.ShowDialog();
		}

		private void Kaydet()
		{
			try
			{
                if (listView1.Items.Count < 1)
                {
                    if (!Utility.Engine.Sor("ilgili Depodaki Stoklar Silinsinmi..?"))
                        return;
                }

				if(textBoxSayimDepo.Text.Equals(""))
				{
					Utility.Engine.Hata("Sayim Depo Bos Olamaz!");
					return;
				}

				if(MessageBox.Show("Yapilan Islemler Kaydedilsinmi?\nRaf Kilitlenecek.","Dikkat!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.No)return;

				Utility.Engine.sql = string.Format("UPDATE depo_tanim SET Sayim = 'H',SonSayimTarihi = GETDATE() WHERE DepoKodu = '{0}' ; ",textBoxSayimDepo.Text);

				Utility.Engine.sql += string.Format("UPDATE ambar_sayim SET Durum = 'E' WHERE Donem = '{0}' AND RafKodu = '{1}'",comboBoxDonem.SelectedItem.ToString(),textBoxSayimDepo.Text);


				if(Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					
					textBoxPalet.Text = "";
					Utility.Engine.Uyari("Raf Sayimi Kapatildi.");

                    Utility.Engine.sql = @"[dbo].[raf_sayimi_aktar] N'" + textBoxSayimDepo.Text.Trim() + "'";

                    string xsonuc = "";
                    xsonuc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();

                    if (xsonuc != "1")
                        Utility.Engine.Uyari(xsonuc);


					textBoxSayimDepo.Text = "";
					listView1.Items.Clear();
					textBoxBARKOD.Text = "";
                    menuItem_Bilgi.Text = listView1.Items.Count.ToString();
                    return;
				}
				else
				{
					Utility.Engine.Hata("Kayit Hatasi:" + Utility.Engine.dat.STR_HataMesaji);
				}
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Genel Hata:" + exc.Message);
                menuItem_Bilgi.Text = listView1.Items.Count.ToString();
                return;
			}
		}

		private void buttonBelgeNoSec_Click(object sender, System.EventArgs e)
		{
			Donemler();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			BarkodEkle();
		}

		private void button4_Click_1(object sender, System.EventArgs e)
		{
            listView1.Items.Clear();
            textBoxPalet.Text = "";
            textBoxBARKOD.Text = "";
			textBoxBARKOD.Focus();
			return;
		}
	
		private void button1_Click(object sender, System.EventArgs e)
		{
			comboBoxDonem.SelectedIndex = -1;
			comboBoxDonem.Text = "";
		}
	

		private void menuItem3_Click_1(object sender, System.EventArgs e)
		{
			if(listView1.Items.Count > 0)
			{
				Utility.Engine.Hata("Onceki Okutmalari Kaydedin!\nPalet Degistirilemez!");
				return;
			}
			

				if(textBoxSayimDepo.Text.Equals(""))
				{
					Utility.Engine.Hata("Sayim Depo Kodu Bos Olamaz!");
					return;
				}

				if(MessageBox.Show(textBoxSayimDepo.Text + " Deposunda Palet Olusturulsunmu?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.No)return;

				Cursor.Current = Cursors.WaitCursor;

				Utility.Engine.sql = string.Format("INSERT INTO palet_tanim (DepoKodu,CariKodu,KullaniciID,CihazID) VALUES ('{0}','{1}','{2}','{3}') SELECT @@IDENTITY",
                    Utility.Engine.SqlTemizle(textBoxSayimDepo.Text),"",Utility.Engine.KullaniciID,Utility.Engine.CihazID);

				int don = 0;

				try
				{
					don = Convert.ToInt32((int)Utility.Engine.dat.TCount(Utility.Engine.sql));
				}
				catch(Exception ex)
				{
					Cursor.Current = Cursors.Default;
					Utility.Engine.Hata("Sunucu Sorgulanirken Hata:" + Utility.Engine.dat.STR_HataMesaji);
					return;
				}

				if(don < 1)
				{
					Cursor.Current = Cursors.Default;
					Utility.Engine.Hata("Palet Olusturulamadi.");
					return;
				}

				textBoxPalet.Text = don.ToString();
			
			Cursor.Current = Cursors.Default;		
			textBoxBARKOD.Text = "";
			textBoxBARKOD.Focus();
			return;
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			textBoxPalet.Text = "";
			
			textBoxBARKOD.Focus();
			return;
		}

		private void menuItem2_Click_2(object sender, System.EventArgs e)
		{
			
			textBoxPalet.Focus();
			return;
		}

		private void textBoxPalet_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
            if (e.KeyChar == 13)
            {
                try
                {
                    if (textBoxPalet.Text.Length < 1)
                    {
                        Utility.Engine.Hata("Palet Barkodunu Okutun!");
                        textBoxPalet.Text = "";
                        textBoxPalet.Focus();
                        return;
                    }

                    listView1.Items.Clear();

                    Utility.Engine.sql = string.Format("EXEC dbo.PaletBul {0}", textBoxPalet.Text);

                    IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);

                    if (dr != null && dr.Read())
                    {
                        string depo = dr.GetValue(1).ToString();
                        string cari = dr.GetValue(2).ToString();
                        string cadi = dr.GetValue(3).ToString();

                        if (!textBoxSayimDepo.Text.Equals(depo))
                        {
                            if (dr != null) dr.Close();
                            Utility.Engine.Hata("Palet Deposu Farkli :" + depo);
                            textBoxPalet.Text = "";
                            textBoxPalet.Focus();
                            return;
                        }

                        if (dr != null) dr.Close();



                        if (textBoxPalet.Text.Length > 0)
                        {
                            Detaylar();
                        }
                    }
                    else
                    {
                        if (dr != null) dr.Close();
                        Utility.Engine.Hata("Palet Sistemde Tanimli Degil");
                        textBoxPalet.Text = "";
                        textBoxPalet.Focus();
                        return;
                    }
                    if (dr != null)
                        dr.Close();

                    textBoxPalet.SelectAll();
                    textBoxPalet.Focus();
                    return;
                }
                catch (Exception exc)
                {
                    Utility.Engine.Hata("Palet Sorgulanirken Genel Hata:" + exc.Message);
                    return;
                }
            }
		}
		
		private void button7_Click(object sender, System.EventArgs e)
		{
			
			textBoxBARKOD.Text = "";
			textBoxBARKOD.Focus();
			return;
		}

		private void textBoxCariAdi_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
			s.sql="SELECT TOP 10 CariKodu,CariAdi FROM cari_tanim (NOLOCK)";
			s.sql_orderby=" ORDER BY CariKodu";
			s.tablename="cari_tanim";
			
			s.ShowDialog();
			if(s.dr!=null)
			{

			}
		}
    
        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Kaydet();

//            menuItem_Bilgi.Text = listView1.Items.Count.ToString();
        }

        private void textBoxSayimDepo_KeyUp(object sender, KeyEventArgs e)
        {
//            string scn = "";

//            if (e.KeyCode == Keys.Enter)
//            {


//                scn = textBoxSayimDepo.Text.Trim().Replace("\r\n", "")
//                .Replace("\n", "").Replace("\r", "");

//                Utility.Engine.sql = string.Format(@" SELECT *  from [DP2007].[dbo].[depo_tanim] (NOLOCK) where DepoKodu = N'{0}'", scn);
//                if (Utility.Engine.dat.TCount(Utility.Engine.sql) <= 0)
//                {
//                    MessageBox.Show(scn+ " Tanimsiz");
//                    textBoxSayimDepo.Text = ""; scn = "";
//                    return;
//                }

//                textBoxPalet.Focus();

//                textBoxSayimDepo.Text = scn;


////                Sayilanlar1(scn);
//           }
        }

        private void textBoxPalet_KeyUp(object sender, KeyEventArgs e)
        {

//            string scn = "";

//            if (e.KeyCode == Keys.Enter)
//            {
//                if (textBoxSayimDepo.Text == "")
//                {
//                    MessageBox.Show(scn + " Depo Kodu Girilmemiş");
//                    textBoxPalet.Text = ""; scn = "";
//                    return;
//                }

//                scn = textBoxPalet.Text.Replace("\r\n", "");

//                Utility.Engine.sql = string.Format(@" SELECT *  from [DP2007].[dbo].[palet_tanim] (NOLOCK) where PaletID = N'{0}'", scn);
//                if (Utility.Engine.dat.TCount(Utility.Engine.sql) <= 0)
//                {
//                    MessageBox.Show(scn + " Palet Tanimsiz");
//                    textBoxPalet.Text = ""; scn = "";
//                    return;
//                }


//                DataTable dp = new DataTable();
//                Utility.Engine.sql = string.Format(@"                
//                SELECT 
//	a.SeriliBarkod
//	,a.StokKodu
//	,s.StokAdi
//    ,a.Birim
//    ,a.Miktar
//    ,a.DepoKodu as PaletID
//    ,a.RafKodu as DepoKodu     
//    from [DP2007].[dbo].[ambar_sayim] a, [DP2007].[dbo].[stok_tanim_ust] s
//    where a.StokKodu = s.StokKodu AND 
//                a.DepoKodu='{0}'", textBoxPalet.Text.Replace("\r\n", ""));
//                dp = Utility.Engine.dat.TableDon(Utility.Engine.sql);
//                if (dp.Rows.Count > 0)
//                {
//                    scn = textBoxPalet.Text.Replace("\r\n", "");
//                    MessageBox.Show("Bu palet daha önce sayılmış");
//                    listView1.Items.Clear();
//                    Utility.Engine.dat.tabledenListDoldur(dp, listView1);

//                    menuItem_Bilgi.Text = listView1.Items.Count.ToString();
//                    Cursor.Current = Cursors.Default;
//                    textBoxBARKOD.Text = "";
//                    textBoxBARKOD.Focus();
//                    textBoxPalet.Text = scn;
//                    return;


//                }
//                else
//                {
//                    Utility.Engine.sql = string.Format("select SeriliBarkod from depo_mevcut (NOLOCK) where PaletID = N'{0}'", textBoxPalet.Text.Replace("\r\n", ""));
//                    dp = Utility.Engine.dat.TableDon(Utility.Engine.sql);
//                    for (int i = 0; i < dp.Rows.Count; i++)
//                    {
//                        textBoxBARKOD.Text = dp.Rows[i][0].ToString();
//                        button2_Click(sender, e);
//                    }
//                }

//                scn = textBoxPalet.Text.Trim().Replace("\r\n", "")
//                .Replace("\n", "").Replace("\r", "");


//                textBoxBARKOD.Focus();

//                textBoxPalet.Text = scn;
//            }
        }

        private void textBoxBARKOD_KeyUp(object sender, KeyEventArgs e)
        {
            //if (textBoxSayimDepo.Text == "" || textBoxPalet.Text== "")
            //{
            //    MessageBox.Show( " Depo Kodu  veya Palet Girilmemiş");
            //    textBoxBARKOD.Text = ""; 
            //    return;
            //}


            //if (e.KeyCode == Keys.Enter)
            //{
            //    BarkodEkle();
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string snc = "";

            snc = textBoxSayimDepo.Text.Trim().Replace("\r\n", "")
                 .Replace("\n", "").Replace("\r", "");

            SayimDüzelt sd = new SayimDüzelt();
            sd.textBox1.Text = snc;
            if (sd.ShowDialog() == DialogResult.OK)
            {                
                Sayilanlar1(snc);
            }
        }

        private void textBoxSayimDepo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Utility.Engine.sql = string.Format("delete from ambar_sayim where DepoKodu='{0}'", textBoxPalet.Text.Replace("\r\n", ""));
            Utility.Engine.dat.TInsert(Utility.Engine.sql);
            listView1.Items.Clear();


        }

        private void buttonSeriSil_Click(object sender, EventArgs e)
        {
            int satir =Convert.ToInt32 (listView1.SelectedIndices[0].ToString());
            string seri = listView1.Items[satir].SubItems[0].Text;
            Utility.Engine.sql = string.Format("delete from ambar_sayim where DepoKodu='{0}' and SeriliBarkod='{1}'", textBoxPalet.Text.Replace("\r\n", ""),seri);
            Utility.Engine.dat.TInsert(Utility.Engine.sql);
            listView1.Items.Clear();
            Sayilanlar();
        }

        private void textBoxSayimDepo_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == 13 || e.KeyChar == 17)
            {
                textBoxSayimDepo.Text = textBoxSayimDepo.Text.Trim().Replace("\r\n", "").Replace("\n", "").Replace("\r", "");


                Utility.Engine.sql = string.Format(@" SELECT *  from [DP2007].[dbo].[depo_tanim] (NOLOCK) where DepoKodu = N'{0}'", textBoxSayimDepo.Text.Trim().Replace("\r\n", "").Replace("\n", "").Replace("\r", ""));
                if (Utility.Engine.dat.TCount(Utility.Engine.sql) <= 0)
                {
                    MessageBox.Show(depo + " Tanimsiz");
                    textBoxSayimDepo.Text = ""; depo = "";
                    return;
                }



                //textBoxSayimDepo.Text = scn;
                textBoxPalet.Focus();
            }
            else
            {
                depo = textBoxSayimDepo.Text.Trim().Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
            }
                //                Sayilanlar1(scn);
            
        }

        private void textBoxPalet_KeyPress_1(object sender, KeyPressEventArgs e)
        {




            if (e.KeyChar == 13 || e.KeyChar == 17)
            {
                textBoxPalet.Text = textBoxPalet.Text.Replace("\r\n", "").Replace("\n\r", "").Replace("\n", "").Replace("\r", "");
                if (depo == "")
                {
                    MessageBox.Show(palet + " Depo Kodu Girilmemiş");
                    return;
                }



                Utility.Engine.sql = string.Format(@" SELECT *  from [DP2007].[dbo].[palet_tanim] (NOLOCK) where PaletID = N'{0}'", textBoxPalet.Text.Trim().Replace("\r\n", "")
                .Replace("\n", "").Replace("\r", ""));
                if (Utility.Engine.dat.TCount(Utility.Engine.sql) <= 0)
                {
                    MessageBox.Show(textBoxPalet.Text.Trim().Replace("\r\n", "")
                .Replace("\n", "").Replace("\r", "") + " Palet Tanimsiz");
                    //textBoxPalet.Text = ""; scn = "";
                    return;
                }


                DataTable dp = new DataTable();
                Utility.Engine.sql = string.Format(@"                
                SELECT 
	a.SeriliBarkod
	,a.StokKodu
	,s.StokAdi
    ,a.Birim
    ,a.Miktar
    ,a.DepoKodu as PaletID
    ,a.RafKodu as DepoKodu     
    from [DP2007].[dbo].[ambar_sayim] a, [DP2007].[dbo].[stok_tanim_ust] s
    where a.StokKodu = s.StokKodu AND 
                a.DepoKodu='{0}'", textBoxPalet.Text.Replace("\r\n", ""));
                dp = Utility.Engine.dat.TableDon(Utility.Engine.sql);
                if (dp.Rows.Count > 0)
                {
                    palet = textBoxPalet.Text.Replace("\r\n", "");
                    MessageBox.Show("Bu palet daha önce sayılmış");
                    listView1.Items.Clear();
                    Utility.Engine.dat.tabledenListDoldur(dp, listView1);

                    menuItem_Bilgi.Text = listView1.Items.Count.ToString();
                    Cursor.Current = Cursors.Default;
                    textBoxBARKOD.Text = "";
                    textBoxBARKOD.Focus();
                    textBoxPalet.Text = palet;
                    return;


                }
                else
                {
                    Utility.Engine.sql = string.Format("select SeriliBarkod from depo_mevcut (NOLOCK) where PaletID = N'{0}'", textBoxPalet.Text.Replace("\r\n", ""));
                    dp = Utility.Engine.dat.TableDon(Utility.Engine.sql);
                    for (int i = 0; i < dp.Rows.Count; i++)
                    {
                        textBoxBARKOD.Text = dp.Rows[i][0].ToString();
                        button2_Click(sender, e);
                    }
                }

                palet = textBoxPalet.Text.Trim().Replace("\r\n", "")
                .Replace("\n", "").Replace("\r", "");




                //textBoxPalet.Text = scn;
                textBoxBARKOD.Focus();
            }
            else
            {
                depo = textBoxSayimDepo.Text.Trim().Replace("\r\n", "").Replace("\n", "").Replace("\r", "");

                palet = textBoxPalet.Text.Replace("\r\n", "").Replace("\n\r", "").Replace("\n", "").Replace("\r", "");
            }
        }

        private void textBoxBARKOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxSayimDepo.Text == "" || textBoxPalet.Text == "")
            {
                MessageBox.Show(" Depo Kodu  veya Palet Girilmemiş");
                textBoxBARKOD.Text = "";
                return;
            }


            if (e.KeyChar == 13 || e.KeyChar == 17)
            {
                BarkodEkle();
            }
        }            
	}
}

//91.188.226.98

//
