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
	public class KUretimGiris : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxBarkod;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonBarkodSil;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.TextBox textBoxSeriliBarkod;
		private System.Windows.Forms.Button buttonSeriliBarkod;
		private System.Windows.Forms.Button buttonSeriliBarkodSil;
		private System.Windows.Forms.Button buttonYeniPalet;
        private System.Windows.Forms.ComboBox comboBoxEkleSil;
        private TextBox textDepo;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button5;
        private Label label5;
        private TextBox textBoxCariAdi;
        private Label label4;
        private Button button4;
        private Button button3;
        private TextBox textBoxCari;
        private Label label2;
        private Button button2;
        private Button button1;
        private ProgressBar progressBar1;
        private Panel panelCari;

		//public Engine Utility.Engine;
	
		public KUretimGiris()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KUretimGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxEkleSil = new System.Windows.Forms.ComboBox();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonBarkodSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textDepo = new System.Windows.Forms.TextBox();
            this.textBoxSeriliBarkod = new System.Windows.Forms.TextBox();
            this.buttonSeriliBarkod = new System.Windows.Forms.Button();
            this.buttonSeriliBarkodSil = new System.Windows.Forms.Button();
            this.buttonYeniPalet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCariAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCari = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panelCari.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.comboBoxEkleSil);
            this.panel1.Controls.Add(this.textBoxBarkod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonBarkodSil);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textDepo);
            this.panel1.Controls.Add(this.textBoxSeriliBarkod);
            this.panel1.Controls.Add(this.buttonSeriliBarkod);
            this.panel1.Controls.Add(this.buttonSeriliBarkodSil);
            this.panel1.Controls.Add(this.buttonYeniPalet);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 64);
            // 
            // comboBoxEkleSil
            // 
            this.comboBoxEkleSil.Enabled = false;
            this.comboBoxEkleSil.Items.Add("EKLE");
            this.comboBoxEkleSil.Items.Add("SIL");
            this.comboBoxEkleSil.Location = new System.Drawing.Point(154, 39);
            this.comboBoxEkleSil.Name = "comboBoxEkleSil";
            this.comboBoxEkleSil.Size = new System.Drawing.Size(64, 23);
            this.comboBoxEkleSil.TabIndex = 0;
            this.comboBoxEkleSil.SelectedIndexChanged += new System.EventHandler(this.comboBoxEkleSil_SelectedIndexChanged);
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.BackColor = System.Drawing.Color.Yellow;
            this.textBoxBarkod.Location = new System.Drawing.Point(56, 0);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(100, 23);
            this.textBoxBarkod.TabIndex = 1;
            this.textBoxBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkod_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.Text = "Palet";
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonOK.Location = new System.Drawing.Point(154, 0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(30, 19);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = ">>";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonBarkodSil
            // 
            this.buttonBarkodSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonBarkodSil.Location = new System.Drawing.Point(184, 0);
            this.buttonBarkodSil.Name = "buttonBarkodSil";
            this.buttonBarkodSil.Size = new System.Drawing.Size(32, 19);
            this.buttonBarkodSil.TabIndex = 4;
            this.buttonBarkodSil.Text = "X";
            this.buttonBarkodSil.Click += new System.EventHandler(this.buttonBarkodSil_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.Text = "Seri Bar.";
            // 
            // textDepo
            // 
            this.textDepo.BackColor = System.Drawing.Color.Salmon;
            this.textDepo.Location = new System.Drawing.Point(56, 41);
            this.textDepo.Name = "textDepo";
            this.textDepo.Size = new System.Drawing.Size(100, 23);
            this.textDepo.TabIndex = 6;
            this.textDepo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSeriliBarkod_KeyPress);
            // 
            // textBoxSeriliBarkod
            // 
            this.textBoxSeriliBarkod.BackColor = System.Drawing.Color.Salmon;
            this.textBoxSeriliBarkod.Location = new System.Drawing.Point(56, 20);
            this.textBoxSeriliBarkod.Name = "textBoxSeriliBarkod";
            this.textBoxSeriliBarkod.Size = new System.Drawing.Size(100, 23);
            this.textBoxSeriliBarkod.TabIndex = 6;
            this.textBoxSeriliBarkod.TextChanged += new System.EventHandler(this.textBoxSeriliBarkod_TextChanged);
            this.textBoxSeriliBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSeriliBarkod_KeyPress);
            // 
            // buttonSeriliBarkod
            // 
            this.buttonSeriliBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSeriliBarkod.Location = new System.Drawing.Point(154, 19);
            this.buttonSeriliBarkod.Name = "buttonSeriliBarkod";
            this.buttonSeriliBarkod.Size = new System.Drawing.Size(30, 20);
            this.buttonSeriliBarkod.TabIndex = 7;
            this.buttonSeriliBarkod.Text = "D";
            this.buttonSeriliBarkod.Click += new System.EventHandler(this.buttonSeriliBarkod_Click);
            // 
            // buttonSeriliBarkodSil
            // 
            this.buttonSeriliBarkodSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSeriliBarkodSil.Location = new System.Drawing.Point(184, 19);
            this.buttonSeriliBarkodSil.Name = "buttonSeriliBarkodSil";
            this.buttonSeriliBarkodSil.Size = new System.Drawing.Size(32, 20);
            this.buttonSeriliBarkodSil.TabIndex = 8;
            this.buttonSeriliBarkodSil.Text = "X";
            this.buttonSeriliBarkodSil.Click += new System.EventHandler(this.buttonSeriliBarkodSil_Click);
            // 
            // buttonYeniPalet
            // 
            this.buttonYeniPalet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonYeniPalet.Location = new System.Drawing.Point(0, 41);
            this.buttonYeniPalet.Name = "buttonYeniPalet";
            this.buttonYeniPalet.Size = new System.Drawing.Size(57, 20);
            this.buttonYeniPalet.TabIndex = 9;
            this.buttonYeniPalet.Text = "DEPO";
            this.buttonYeniPalet.Click += new System.EventHandler(this.buttonYeniPalet_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.Columns.Add(this.columnHeader4);
            this.listView1.Columns.Add(this.columnHeader5);
            this.listView1.Columns.Add(this.columnHeader6);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(1, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(233, 213);
            this.listView1.TabIndex = 1;
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
            // columnHeader6
            // 
            this.columnHeader6.Text = "DepoKodu";
            this.columnHeader6.Width = 60;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(516, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 20);
            this.button5.TabIndex = 10;
            this.button5.Text = "KAYDET";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 16);
            this.label5.Text = "Cari Kodu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxCariAdi
            // 
            this.textBoxCariAdi.BackColor = System.Drawing.Color.White;
            this.textBoxCariAdi.Location = new System.Drawing.Point(56, 72);
            this.textBoxCariAdi.Name = "textBoxCariAdi";
            this.textBoxCariAdi.ReadOnly = true;
            this.textBoxCariAdi.Size = new System.Drawing.Size(160, 23);
            this.textBoxCariAdi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.Text = "Adi";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(8, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "VAZGEC";
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(8, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "OLUSTUR";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxCari
            // 
            this.textBoxCari.BackColor = System.Drawing.Color.White;
            this.textBoxCari.Location = new System.Drawing.Point(56, 48);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.ReadOnly = true;
            this.textBoxCari.Size = new System.Drawing.Size(100, 23);
            this.textBoxCari.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.Text = "Kodu";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(152, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "..";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(184, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.Silver;
            this.panelCari.Controls.Add(this.button1);
            this.panelCari.Controls.Add(this.button2);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Controls.Add(this.textBoxCari);
            this.panelCari.Controls.Add(this.button3);
            this.panelCari.Controls.Add(this.button4);
            this.panelCari.Controls.Add(this.label4);
            this.panelCari.Controls.Add(this.textBoxCariAdi);
            this.panelCari.Controls.Add(this.label5);
            this.panelCari.Location = new System.Drawing.Point(412, 167);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(224, 272);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 60);
            this.progressBar1.Visible = false;
            // 
            // KUretimGiris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KUretimGiris";
            this.Text = "Palet Transfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YeniPalet_Load);
            this.panel1.ResumeLayout(false);
            this.panelCari.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
		private void Detaylar()
		{
			try
			{
            Utility.Engine.sql = string.Format(@"SELECT d.SeriliBarkod,s.StokAdi,d.StokKodu,d.Birim,d.Miktar FROM dbo.depo_mevcut d (NOLOCK) LEFT OUTER JOIN dbo.stok_tanim_ust s (NOLOCK) ON d.StokKodu = s.StokKodu WHERE ( d.PaletID = N'{0}' )", Utility.Engine.SqlTemizle(textBoxBarkod.Text.ToUpper()));
            Utility.Engine.dat.ListDoldur(ref listView1, Utility.Engine.sql);
			}
			catch(Exception except)
			{
            Utility.Engine.Hata("Palet Detaylari Sorgulanamadi:" + except.Message);
            return;
			}
		}
		private void button4_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void buttonYeniPalet_Click(object sender, System.EventArgs e)
		{
         if (textBoxBarkod.Text == "") return;
         DepoSecimOzel oz = new DepoSecimOzel();
         oz.Rapor = true;
         if (oz.ShowDialog() == DialogResult.OK)
         {
            string gdepo = oz.DepoKodu;
            if (!Utility.Engine.Sor(Utility.Engine.SqlTemizle(textBoxBarkod.Text).ToUpper() + "' nolu Palet " + gdepo + " deposuna Transfer Edilecek Onayliyormusunuz?")) return;

            try
            {
                Utility.Engine.sql = string.Format("EXEC dbo.PaletSevk N'{0}',N'{1}',N'{2}',N'{3}'",
               Utility.Engine.SqlTemizle(textBoxBarkod.Text).ToUpper(),
               gdepo,Utility.Engine.KullaniciID,Utility.Engine.CihazID);
            DataTable dtx = new DataTable();
            Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dtx);

            if (dtx != null && dtx.Rows.Count > 0)
            {
               if (dtx.Rows[0][1].ToString() == "HATA")
               {
                  Utility.Engine.Hata(dtx.Rows[0][0].ToString());
                  textBoxBarkod.Focus();
                  textBoxBarkod.SelectAll();
                  return;
               }
               else
               {
                  Utility.Engine.Tamam("işlem Tamamlandi.");
                  listView1.Items.Clear();
                  textBoxBarkod.Text = "";
                  textBoxSeriliBarkod.Text = "";
                  textDepo.Text = "";
                  textBoxBarkod.Focus();
                  return;
               }
            }
            }
            catch (Exception exc)
            {
               Utility.Engine.Hata("Genel Hata:" + exc.Message);
            }
            Utility.Engine.Hata("Sunucu Yanit Vermedi!");
            listView1.Items.Clear();
            textBoxBarkod.Text = "";
            textBoxSeriliBarkod.Text = "";
            textDepo.Text = "";
            textBoxBarkod.Focus();
            return;
         }

         //panelCari.Location = new Point(8, 8);
         //panelCari.BringToFront();
         //panelCari.Visible = true;
         //return;
         /*
             
      
             
      */

         //if(MessageBox.Show("Palet Olusturulsunmu?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.No)return;

         //Utility.Engine.sql = string.Format("INSERT INTO palet_tanim (DepoKodu,KullaniciID,CihazID) VALUES ('GIRIS-MONTAJ DEPO','{0}','{1}') SELECT @@IDENTITY",Utility.Engine.KullaniciID,Utility.Engine.CihazID);

         //int don = 0;

         //try
         //{
         //   don = Convert.ToInt32((int)Utility.Engine.dat.TCount(Utility.Engine.sql));
         //}
         //catch(Exception ex)
         //{
         //   Utility.Engine.Hata("Sunucu Sorgulanirken Hata:" + Utility.Engine.dat.STR_HataMesaji);
         //   return;
         //}

         //if(don < 1)
         //{
         //   Utility.Engine.Hata("Palet Olusturulamadi.");
         //   return;
         //}
         //textBoxSeriliBarkod.Text = "";
         //textBoxBarkod.Text = don.ToString();
         //textBoxBarkod_KeyPress(textBoxBarkod,new System.Windows.Forms.KeyPressEventArgs((char)13));
         //return;
		}

		private void textBoxSeriliBarkod_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

            string barokd = "";
            string depo = "";
            string ddepo = "";

            barokd = textBoxBarkod.Text.Trim().Replace("\r\n", "")
            .Replace("\n\r", "").Replace("\n", "").Replace("\r", "");

            depo=textBoxSeriliBarkod.Text.Trim().Replace("\r\n", "")
            .Replace("\n\r", "").Replace("\n", "").Replace("\r", "");

            ddepo = textDepo.Text.Trim().Replace("\r\n", "")
            .Replace("\n\r", "").Replace("\n", "").Replace("\r", "");


			try
			{
				if(e.KeyChar == 13 || e.KeyChar==17)
				{
					if(depo=="")
					{
						Utility.Engine.Hata("Seri Barkodu Okutun");
						textBoxSeriliBarkod.Focus();
						return;
					}
					if(comboBoxEkleSil.SelectedItem == null)
					{
						Utility.Engine.Hata("Seri Islemi Secin <EKLE> <SIL>");
						comboBoxEkleSil.Focus();
						return;
					}
               if (barokd == "")
               {
                  Utility.Engine.Hata("Palet Barkodu Okutun!");
                  textBoxBarkod.Focus();
                  return;
               }

               double dib = 0;
               int r = 0;

               depo = Utility.Engine.SqlTemizle(depo).ToUpper();

               Utility.Engine.sql = string.Format("EXEC sevk.PaletTransfer N'{0}', N'{1}', N'{2}', N'{3}'",
                  Utility.Engine.SqlTemizle(barokd.ToUpper()),
                  Utility.Engine.SqlTemizle(depo).ToUpper(),
                  ddepo, Utility.Engine.KullaniciID);

               DataTable dt = new DataTable();
               Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
               if (dt != null && dt.Rows.Count > 0)
               {
                   try
                   {
                       if (dt.Rows.Count > 0)
                       {
                           if (dt.Rows[0][0].ToString().Trim().Equals("HATA"))
                           {
                               MessageBox.Show(dt.Rows[0][1].ToString().Trim(), "Sununcu  Bir Hata Bildirdi");
                               return;
                           }
                       }
                   }
                   catch { }

                   r = dt.Rows.Count;
                   progressBar1.Value = 0;
                   progressBar1.Maximum = r;
                   progressBar1.Visible = true;
                   progressBar1.BringToFront();
                   Application.DoEvents();
                   listView1.Items.Clear();
                   try
                   {
                       for (int i = 0; i < dt.Rows.Count; i++)
                       {
                           ListViewItem item = new ListViewItem();
                           item.Text = dt.Rows[i][0].ToString();
                           item.SubItems.Add(dt.Rows[i][1].ToString());
                           item.SubItems.Add(dt.Rows[i][2].ToString());
                           item.SubItems.Add(dt.Rows[i][3].ToString());
                           item.SubItems.Add(dt.Rows[i][4].ToString());
                           item.SubItems.Add(dt.Rows[i][5].ToString());
                           listView1.Items.Add(item);
                           try { dib += Convert.ToDouble(dt.Rows[i][6].ToString()); }
                           catch { ;}
                           progressBar1.Value = i;
                           Application.DoEvents();
                       }
                   }
                   catch (Exception exc)
                   {
                       MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
                   }

                   progressBar1.Visible = false;
                   progressBar1.Value = 0;
               }
               //Utility.Engine.dat.ListDoldur(ref listView1, Utility.Engine.sql);



               this.Text = r.ToString() + " Amb. - " + dib.ToString("##.###") + " Adet/Metre";

               /*DataSet das = Utility.Engine.dat.DataSetDon(Utility.Engine.sql);

               if (das == null)
               {
                   MessageBox.Show("Sunucu Hata Bildirdi", Utility.Engine.dat.Fault);
                   return;
               }

               if (das.Tables.Count < 1)
               {
                   MessageBox.Show("Sunucu Hata Bildirdi", Utility.Engine.dat.Fault);
                   return;
               }

               if ( das.Tables[0].Rows.Count < 1)
               {
                   MessageBox.Show("Sunucu Hata Bildirdi", Utility.Engine.dat.Fault);
                   return;
               }

               try
               {
                   if (das.Tables[0].Rows.Count > 0)
                   {
                       if (das.Tables[0].Rows[0][0].ToString().Trim() == "-1")
                       {
                           MessageBox.Show(das.Tables[0].Rows[0][0].ToString().Trim(), "Sununcu  Bir Hata Bildirdi");
                           return;
                       }
                   }
               }
               catch { }


               Utility.Engine.dat.tabledenListDoldur1(das.Tables[0], listView1);

               try
               {
                   Text = das.Tables[1].Rows[0][1].ToString() + " Amb. " + das.Tables[1].Rows[0][0].ToString() + " Adet/Metre";  
               }
               catch (Exception exc)
               {
                   MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
               }*/


               //this.Text = dtx.Rows.Count.ToString();

					textBoxSeriliBarkod.Text = "";
					textBoxSeriliBarkod.Focus();
					return;
				}
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Genel Hata:" + exc.Message);
			}
		}

		

		private void buttonDepo_Click(object sender, System.EventArgs e)
		{
		}

		private void buttonDepoSil_Click(object sender, System.EventArgs e)
		{
		}

		private void buttonSeriliBarkodSil_Click(object sender, System.EventArgs e)
		{
            //textBoxSeriliBarkod.Text = "";
            //textBoxSeriliBarkod.Focus();
            //return;
		}

		private void buttonBarkodSil_Click(object sender, System.EventArgs e)
		{
			textBoxBarkod.Text = "";
			textBoxBarkod.Focus();
         textBoxSeriliBarkod.Text = "";
         listView1.Items.Clear();
         textDepo.Text = "";
         this.Text = "Palet Transfer";
         textBoxBarkod.Focus();
			return;
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
            string snc = "";

            snc = textBoxBarkod.Text.Trim().Replace("\r\n", "")
            .Replace("\n\r", "").Replace("\n", "").Replace("\r", "");



            getir(snc);
			
		}

        private void buttonSeriliBarkod_Click(object sender, System.EventArgs e)
        {
            //textBoxSeriliBarkod_KeyPress(textBoxSeriliBarkod,new KeyPressEventArgs((char)13));

            DepoSecimOzel oz = new DepoSecimOzel();
            oz.Rapor = true;
            if (oz.ShowDialog() == DialogResult.OK)
            {
                textBoxSeriliBarkod.Text = oz.DepoKodu;
            }

        }

		private void YeniPalet_Load(object sender, System.EventArgs e)
		{
			comboBoxEkleSil.SelectedIndex = 0;
			textBoxBarkod.Focus();
			return;
		}

		
		private void button3_Click(object sender, System.EventArgs e)
		{
            string snc = "";

            snc = textBoxBarkod.Text.Trim().Replace("\r\n", "")
            .Replace("\n\r", "").Replace("\n", "").Replace("\r", "");


			Utility.Engine.sql = string.Format("INSERT INTO palet_tanim (DepoKodu,CariKodu,KullaniciID,CihazID) VALUES ('GIRIS-MONTAJ DEPO','{0}','{1}','{2}') SELECT @@IDENTITY",Utility.Engine.SqlTemizle(textBoxCari.Text),Utility.Engine.KullaniciID,Utility.Engine.CihazID);

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
			textBoxSeriliBarkod.Text = "";
			textBoxBarkod.Text = don.ToString();
            getir(snc);
			panelCari.Visible = false;
			return;
		}

		private void button4_Click_1(object sender, System.EventArgs e)
		{
			panelCari.Visible = false;
			textBoxBarkod.Focus();
			return;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			textBoxCari.Text = "";
			textBoxCariAdi.Text = "";
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
			s.sql="SELECT TOP 10 CariKodu,CariAdi FROM cari_tanim (NOLOCK) ";
			s.sql_orderby=" ORDER BY CariKodu";
			s.tablename="cari_tanim";

			s.ShowDialog();
			if(s.dr!=null)
			{
				textBoxCari.Text=s.dr["CariKodu"].ToString();
				textBoxCariAdi.Text = s.dr["CariAdi"].ToString();
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(listView1.Items.Count < 1) {Utility.Engine.Hata("Bos Belge Kaydedilemez!");return;}

				if(MessageBox.Show("Yapilan Islemler Kaydedilecek Onayliyormusunuz?","Dikkat!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.No)return;

				AmbarPC.Fis f = new AmbarPC.Fis();
				f.Aciklama1 = "Uretim Girisi ";				
				f.GirenDepo = "GIRIS";
				f.HareketKodu = "";
				f.HareketOzel = "";
				f.HareketTipi = "Serili Stok Transferi";
            f.CariKod = "";
				f.Tarih = DateTime.Now.ToString("yyyy-MM-dd");
				f.Saat = DateTime.Now.ToString("HH:mm");
				f.HareketKodu = "URETIM GIRIS";
            f.PaletID = Utility.Engine.SqlTemizle(textBoxBarkod.Text).ToUpper();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
               if (listView1.Items[i].SubItems[4].Text == "")
                  continue;
               try
               {
                  if (Convert.ToDouble(listView1.Items[i].SubItems[4].Text, Utility.Engine.nfi) <= 0)
                  {
                     MessageBox.Show("Negatif/Hatali stok miktari!\nStok miktari pozitif olmalidir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                     return;
                  }
               }
               catch (Exception)
               {
                  MessageBox.Show("Negatif/Hatali stok miktari!\nStok miktari pozitif olmalidir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                  return;
               }

               System.Data.DataRow row = f.detaylar.NewRow();
               row["StokKodu"] = listView1.Items[i].SubItems[2].Text;
               row["Birim"] = listView1.Items[i].SubItems[3].Text;
               row["Miktar"] = listView1.Items[i].SubItems[4].Text;
               row["SeriliBarkod"] = listView1.Items[i].SubItems[0].Text;
               row["GirenDepo"] = "GIRIS";
               row["CikanDepo"] = "ARA DEPO";
               row["Durum"] = "*";
               f.detaylar.Rows.Add(row);
            }

            if (f.FisKaydet() == false)
            {
               MessageBox.Show(f.HataMesaji, "BiR HATA OLUşTU", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
               return;
            }

            Utility.Engine.sql = string.Format("UPDATE dbo.palet_tanim SET DepoKodu = N'GIRIS' WHERE ( PaletID = N'{0}')", Utility.Engine.SqlTemizle(textBoxBarkod.Text));
            if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
            {
               Utility.Engine.Hata("Palet Deposu Güncellenemedi!");
            }

				MessageBox.Show(f.BelgeNo.ToString() + " nolu Fis Kaydedildi","Tamam",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
				textBoxBarkod.Text = "";
				listView1.Items.Clear();
				textBoxCari.Text = "";
				textBoxCariAdi.Text = "";
				textBoxBarkod.Focus();
				return;
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Fis Kaydedilirken Hata:" + exc.Message);
				return;
			}
		}

		private void comboBoxEkleSil_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			textBoxSeriliBarkod.Focus();
			return;
		}

        private void textBoxSeriliBarkod_TextChanged(object sender, EventArgs e)
        {

        }        

        private void getir(string str)
        {                                   
            try
            {
                listView1.Items.Clear();

                if (str.Length < 1)
                {
                    Utility.Engine.Hata("Palet Barkodunu Okutun!");
                    textBoxBarkod.Text = "";
                    textBoxBarkod.Focus();
                    return;
                }

                string pdepo = Utility.Engine.dat.TSelectScalar(string.Format(@"SELECT sevk.PaletDepoBul(N'{0}')", Utility.Engine.SqlTemizle(str).ToUpper()));

                if (pdepo == null || pdepo.Length < 1)
                {
                    Utility.Engine.Hata("Palet Tanimsiz Yada Kapali Kontrol Edin!");
                    textBoxBarkod.Text = "";
                    textBoxBarkod.Focus();
                    return;
                }

                textDepo.Text = pdepo;
                double dib = 0;
                int r = 0;

                Utility.Engine.sql = string.Format("EXEC sevk.PaletTransfer N'{0}'", str.ToUpper());
                DataTable dt = new DataTable();
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    r = dt.Rows.Count;
                    progressBar1.Value = 0;
                    progressBar1.Maximum = r;
                    progressBar1.Visible = true;
                    progressBar1.BringToFront();
                    Application.DoEvents();
                    
                    try
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dt.Rows[i][0].ToString();
                            item.SubItems.Add(dt.Rows[i][1].ToString());
                            item.SubItems.Add(dt.Rows[i][2].ToString());
                            item.SubItems.Add(dt.Rows[i][3].ToString());
                            item.SubItems.Add(dt.Rows[i][4].ToString());
                            item.SubItems.Add(dt.Rows[i][5].ToString());
                            listView1.Items.Add(item);
                            try { dib += Convert.ToDouble(dt.Rows[i][6].ToString()); }
                            catch { ;}
                            progressBar1.Value = i;
                            Application.DoEvents();
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
                    }

                    progressBar1.Visible = false;
                    progressBar1.Value = 0;
                }
                //Utility.Engine.dat.ListDoldur(ref listView1, Utility.Engine.sql);



                this.Text = r.ToString() + " Satir - " + dib.ToString("##.###") + " Adet/Metre";
                textBoxBarkod.Text = Utility.Engine.SqlTemizle(textBoxBarkod.Text).ToUpper();

                textBoxSeriliBarkod.Text = "";
                textBoxSeriliBarkod.Focus();
                return;


            }
            catch (Exception exc)
            {
                Utility.Engine.Hata("Palet Sorgulanirken Hata:" + exc.Message);
                textBoxBarkod.Text = "";
                textBoxBarkod.Focus();
                return;
            }
        }

        private void textBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            string snc = "";

            snc = textBoxBarkod.Text.Trim().Replace("\r\n", "")
            .Replace("\n\r", "").Replace("\n", "").Replace("\r", "");

            if (e.KeyChar == 13 || e.KeyChar==17)
            {
                getir(snc);
            }
        }

	}
}
