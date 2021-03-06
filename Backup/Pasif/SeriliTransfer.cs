using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for SeriliTransfer.
	/// </summary>
	public class SeriliTransfer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBoxBelgeNo;
		private System.Windows.Forms.Button buttonBelgeNoSec;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader COLUMN_Barkod;
		private System.Windows.Forms.ColumnHeader COLUMN_StokAdi;
		private System.Windows.Forms.ColumnHeader COLUMN_StokKodu;
		private System.Windows.Forms.ColumnHeader COLUMN_Miktar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxCikanDepo;
		private System.Windows.Forms.TextBox textBoxGirenDepo;
		private System.Windows.Forms.Button buttonCikanDepoSec;
		private System.Windows.Forms.Button buttonGirenDepoSec;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader COLUMN_Birim;
		private System.Windows.Forms.TextBox textBoxBarkod;
		private System.Windows.Forms.Button buttonBarkodEkle;
		private System.Windows.Forms.Panel panel2;
		//public Engine Utility.Engine;
		public System.Threading.ThreadStart ts;
		public System.Threading.Thread th;		
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItemKaydet;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9; 
		public bool continuescanner;
		private System.Windows.Forms.ColumnHeader COLUMN_GirenDepo;
		private System.Windows.Forms.ColumnHeader COLUMN_CikanDepo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxAciklama1;
		private System.Windows.Forms.TextBox textBoxAciklama2;
		private System.Windows.Forms.TextBox textBoxCariAdi;
		private System.Windows.Forms.TextBox textBoxCariKodu;
		private System.Windows.Forms.TextBox textBoxHareketKodu;
		private System.Windows.Forms.TextBox textBoxOzelKod;
		private System.Windows.Forms.Button buttonAciklama1Sil;
		private System.Windows.Forms.Button buttonAciklama2Sil;
		private System.Windows.Forms.Button buttonCariAdiSil;
		private System.Windows.Forms.Button buttonCariKoduSil;
		private System.Windows.Forms.Button buttonCariKoduSec;
		private System.Windows.Forms.Button buttonCariAdiSec;
		private System.Windows.Forms.Button buttonOzelKodSec;
		private System.Windows.Forms.Button buttonHareketKoduSec;
		private System.Windows.Forms.Button buttonHareketKoduSil;
		private System.Windows.Forms.Button buttonOzelKodSil;
		private System.Windows.Forms.Button buttonTamam;
		private System.Windows.Forms.Panel panelUst;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxIrsaliyeNo;
		private System.Windows.Forms.Button buttonIrsaliyeSec;
		private System.Windows.Forms.Button buttonIrsaliyeSil;
		private System.Windows.Forms.CheckBox checkBoxSeri;
		public StokTransferEkBilgi stek;
		private enum Ekranlar{Ust,Detay};
	
		public void MyScanner()
		{
			
		}
			

			
		public SeriliTransfer()
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
         this.label1 = new System.Windows.Forms.Label();
         this.textBoxBelgeNo = new System.Windows.Forms.TextBox();
         this.buttonBelgeNoSec = new System.Windows.Forms.Button();
         this.listView1 = new System.Windows.Forms.ListView();
         this.COLUMN_Barkod = new System.Windows.Forms.ColumnHeader();
         this.COLUMN_StokKodu = new System.Windows.Forms.ColumnHeader();
         this.COLUMN_StokAdi = new System.Windows.Forms.ColumnHeader();
         this.COLUMN_Birim = new System.Windows.Forms.ColumnHeader();
         this.COLUMN_Miktar = new System.Windows.Forms.ColumnHeader();
         this.COLUMN_GirenDepo = new System.Windows.Forms.ColumnHeader();
         this.COLUMN_CikanDepo = new System.Windows.Forms.ColumnHeader();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.textBoxCikanDepo = new System.Windows.Forms.TextBox();
         this.textBoxGirenDepo = new System.Windows.Forms.TextBox();
         this.buttonCikanDepoSec = new System.Windows.Forms.Button();
         this.buttonGirenDepoSec = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.textBoxBarkod = new System.Windows.Forms.TextBox();
         this.buttonBarkodEkle = new System.Windows.Forms.Button();
         this.panel2 = new System.Windows.Forms.Panel();
         this.checkBoxSeri = new System.Windows.Forms.CheckBox();
         this.mainMenu1 = new System.Windows.Forms.MainMenu();
         this.menuItem3 = new System.Windows.Forms.MenuItem();
         this.menuItem1 = new System.Windows.Forms.MenuItem();
         this.menuItem2 = new System.Windows.Forms.MenuItem();
         this.menuItem9 = new System.Windows.Forms.MenuItem();
         this.menuItem4 = new System.Windows.Forms.MenuItem();
         this.menuItem5 = new System.Windows.Forms.MenuItem();
         this.menuItem7 = new System.Windows.Forms.MenuItem();
         this.menuItem8 = new System.Windows.Forms.MenuItem();
         this.menuItemKaydet = new System.Windows.Forms.MenuItem();
         this.menuItem6 = new System.Windows.Forms.MenuItem();
         this.panelUst = new System.Windows.Forms.Panel();
         this.buttonTamam = new System.Windows.Forms.Button();
         this.textBoxHareketKodu = new System.Windows.Forms.TextBox();
         this.textBoxAciklama1 = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.buttonAciklama1Sil = new System.Windows.Forms.Button();
         this.label6 = new System.Windows.Forms.Label();
         this.textBoxAciklama2 = new System.Windows.Forms.TextBox();
         this.buttonAciklama2Sil = new System.Windows.Forms.Button();
         this.textBoxCariAdi = new System.Windows.Forms.TextBox();
         this.buttonCariAdiSil = new System.Windows.Forms.Button();
         this.label7 = new System.Windows.Forms.Label();
         this.buttonCariKoduSil = new System.Windows.Forms.Button();
         this.textBoxCariKodu = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.buttonCariAdiSec = new System.Windows.Forms.Button();
         this.label9 = new System.Windows.Forms.Label();
         this.buttonHareketKoduSec = new System.Windows.Forms.Button();
         this.buttonHareketKoduSil = new System.Windows.Forms.Button();
         this.label10 = new System.Windows.Forms.Label();
         this.buttonOzelKodSil = new System.Windows.Forms.Button();
         this.textBoxOzelKod = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.textBoxIrsaliyeNo = new System.Windows.Forms.TextBox();
         this.buttonIrsaliyeSec = new System.Windows.Forms.Button();
         this.buttonIrsaliyeSil = new System.Windows.Forms.Button();
         this.buttonCariKoduSec = new System.Windows.Forms.Button();
         this.buttonOzelKodSec = new System.Windows.Forms.Button();
         this.panel2.SuspendLayout();
         this.panelUst.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(0, 10);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(56, 16);
         this.label1.Text = "Belge No:";
         // 
         // textBoxBelgeNo
         // 
         this.textBoxBelgeNo.BackColor = System.Drawing.Color.Salmon;
         this.textBoxBelgeNo.Location = new System.Drawing.Point(64, 8);
         this.textBoxBelgeNo.Name = "textBoxBelgeNo";
         this.textBoxBelgeNo.Size = new System.Drawing.Size(101, 23);
         this.textBoxBelgeNo.TabIndex = 4;
         this.textBoxBelgeNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBelgeNo_KeyDown);
         this.textBoxBelgeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelgeNo_KeyPress);
         // 
         // buttonBelgeNoSec
         // 
         this.buttonBelgeNoSec.Location = new System.Drawing.Point(160, 8);
         this.buttonBelgeNoSec.Name = "buttonBelgeNoSec";
         this.buttonBelgeNoSec.Size = new System.Drawing.Size(35, 20);
         this.buttonBelgeNoSec.TabIndex = 6;
         this.buttonBelgeNoSec.Text = "...";
         this.buttonBelgeNoSec.Click += new System.EventHandler(this.buttonBelgeNoSec_Click);
         // 
         // listView1
         // 
         this.listView1.Columns.Add(this.COLUMN_Barkod);
         this.listView1.Columns.Add(this.COLUMN_StokKodu);
         this.listView1.Columns.Add(this.COLUMN_StokAdi);
         this.listView1.Columns.Add(this.COLUMN_Birim);
         this.listView1.Columns.Add(this.COLUMN_Miktar);
         this.listView1.Columns.Add(this.COLUMN_GirenDepo);
         this.listView1.Columns.Add(this.COLUMN_CikanDepo);
         this.listView1.FullRowSelect = true;
         this.listView1.Location = new System.Drawing.Point(0, 48);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(235, 224);
         this.listView1.TabIndex = 1;
         this.listView1.View = System.Windows.Forms.View.Details;
         // 
         // COLUMN_Barkod
         // 
         this.COLUMN_Barkod.Text = "Barkod";
         this.COLUMN_Barkod.Width = 100;
         // 
         // COLUMN_StokKodu
         // 
         this.COLUMN_StokKodu.Text = "StokKodu";
         this.COLUMN_StokKodu.Width = 80;
         // 
         // COLUMN_StokAdi
         // 
         this.COLUMN_StokAdi.Text = "StokAdi";
         this.COLUMN_StokAdi.Width = 100;
         // 
         // COLUMN_Birim
         // 
         this.COLUMN_Birim.Text = "Birim";
         this.COLUMN_Birim.Width = 10;
         // 
         // COLUMN_Miktar
         // 
         this.COLUMN_Miktar.Text = "Miktar";
         this.COLUMN_Miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.COLUMN_Miktar.Width = 40;
         // 
         // COLUMN_GirenDepo
         // 
         this.COLUMN_GirenDepo.Text = "GirenDepo";
         this.COLUMN_GirenDepo.Width = 60;
         // 
         // COLUMN_CikanDepo
         // 
         this.COLUMN_CikanDepo.Text = "CikanDepo";
         this.COLUMN_CikanDepo.Width = 60;
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(0, 30);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(72, 16);
         this.label2.Text = "Çikan Depo:";
         // 
         // label3
         // 
         this.label3.Location = new System.Drawing.Point(0, 50);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(72, 16);
         this.label3.Text = "Giren Depo:";
         // 
         // textBoxCikanDepo
         // 
         this.textBoxCikanDepo.BackColor = System.Drawing.Color.Yellow;
         this.textBoxCikanDepo.Location = new System.Drawing.Point(64, 28);
         this.textBoxCikanDepo.Name = "textBoxCikanDepo";
         this.textBoxCikanDepo.Size = new System.Drawing.Size(101, 23);
         this.textBoxCikanDepo.TabIndex = 3;
         this.textBoxCikanDepo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelgeNo_KeyPress);
         // 
         // textBoxGirenDepo
         // 
         this.textBoxGirenDepo.BackColor = System.Drawing.Color.Yellow;
         this.textBoxGirenDepo.Location = new System.Drawing.Point(64, 48);
         this.textBoxGirenDepo.Name = "textBoxGirenDepo";
         this.textBoxGirenDepo.Size = new System.Drawing.Size(101, 23);
         this.textBoxGirenDepo.TabIndex = 5;
         this.textBoxGirenDepo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelgeNo_KeyPress);
         // 
         // buttonCikanDepoSec
         // 
         this.buttonCikanDepoSec.Location = new System.Drawing.Point(160, 28);
         this.buttonCikanDepoSec.Name = "buttonCikanDepoSec";
         this.buttonCikanDepoSec.Size = new System.Drawing.Size(35, 20);
         this.buttonCikanDepoSec.TabIndex = 10;
         this.buttonCikanDepoSec.Text = "...";
         this.buttonCikanDepoSec.Click += new System.EventHandler(this.buttonCikanDepoSec_Click);
         // 
         // buttonGirenDepoSec
         // 
         this.buttonGirenDepoSec.Location = new System.Drawing.Point(160, 48);
         this.buttonGirenDepoSec.Name = "buttonGirenDepoSec";
         this.buttonGirenDepoSec.Size = new System.Drawing.Size(35, 20);
         this.buttonGirenDepoSec.TabIndex = 11;
         this.buttonGirenDepoSec.Text = "...";
         this.buttonGirenDepoSec.Click += new System.EventHandler(this.buttonGirenDepoSec_Click);
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(195, 28);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(24, 20);
         this.button3.TabIndex = 12;
         this.button3.Text = "X";
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(195, 48);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(24, 20);
         this.button4.TabIndex = 13;
         this.button4.Text = "X";
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // textBoxBarkod
         // 
         this.textBoxBarkod.AcceptsReturn = true;
         this.textBoxBarkod.AcceptsTab = true;
         this.textBoxBarkod.BackColor = System.Drawing.Color.Yellow;
         this.textBoxBarkod.Location = new System.Drawing.Point(64, 4);
         this.textBoxBarkod.Name = "textBoxBarkod";
         this.textBoxBarkod.Size = new System.Drawing.Size(128, 23);
         this.textBoxBarkod.TabIndex = 0;
         this.textBoxBarkod.TextChanged += new System.EventHandler(this.textBoxBarkod_TextChanged);
         this.textBoxBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBarkod_KeyUp);
         // 
         // buttonBarkodEkle
         // 
         this.buttonBarkodEkle.Location = new System.Drawing.Point(198, 4);
         this.buttonBarkodEkle.Name = "buttonBarkodEkle";
         this.buttonBarkodEkle.Size = new System.Drawing.Size(32, 20);
         this.buttonBarkodEkle.TabIndex = 1;
         this.buttonBarkodEkle.Text = "+++";
         this.buttonBarkodEkle.Click += new System.EventHandler(this.buttonBarkodEkle_Click);
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.Gainsboro;
         this.panel2.Controls.Add(this.textBoxBarkod);
         this.panel2.Controls.Add(this.buttonBarkodEkle);
         this.panel2.Controls.Add(this.checkBoxSeri);
         this.panel2.Location = new System.Drawing.Point(0, 24);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(234, 29);
         // 
         // checkBoxSeri
         // 
         this.checkBoxSeri.Checked = true;
         this.checkBoxSeri.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBoxSeri.Enabled = false;
         this.checkBoxSeri.Location = new System.Drawing.Point(8, 6);
         this.checkBoxSeri.Name = "checkBoxSeri";
         this.checkBoxSeri.Size = new System.Drawing.Size(56, 20);
         this.checkBoxSeri.TabIndex = 2;
         this.checkBoxSeri.Text = "Seri";
         this.checkBoxSeri.CheckStateChanged += new System.EventHandler(this.checkBoxSeri_CheckStateChanged);
         // 
         // mainMenu1
         // 
         this.mainMenu1.MenuItems.Add(this.menuItem3);
         this.mainMenu1.MenuItems.Add(this.menuItem4);
         this.mainMenu1.MenuItems.Add(this.menuItemKaydet);
         this.mainMenu1.MenuItems.Add(this.menuItem6);
         // 
         // menuItem3
         // 
         this.menuItem3.MenuItems.Add(this.menuItem1);
         this.menuItem3.MenuItems.Add(this.menuItem2);
         this.menuItem3.MenuItems.Add(this.menuItem9);
         this.menuItem3.Text = "Üst";
         this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
         // 
         // menuItem1
         // 
         this.menuItem1.Text = "Yeni";
         this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click_2);
         // 
         // menuItem2
         // 
         this.menuItem2.Text = "Kopyala";
         this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click_1);
         // 
         // menuItem9
         // 
         this.menuItem9.Text = "Ek Bilgiler";
         this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
         // 
         // menuItem4
         // 
         this.menuItem4.MenuItems.Add(this.menuItem5);
         this.menuItem4.MenuItems.Add(this.menuItem7);
         this.menuItem4.MenuItems.Add(this.menuItem8);
         this.menuItem4.Text = "Detay";
         // 
         // menuItem5
         // 
         this.menuItem5.Text = "Sil";
         this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
         // 
         // menuItem7
         // 
         this.menuItem7.Text = "Tümünü Sil";
         this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
         // 
         // menuItem8
         // 
         this.menuItem8.Text = "Bilgi";
         this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
         // 
         // menuItemKaydet
         // 
         this.menuItemKaydet.Text = "Kaydet";
         this.menuItemKaydet.Click += new System.EventHandler(this.menuItemKaydet_Click);
         // 
         // menuItem6
         // 
         this.menuItem6.Text = "Çikiş";
         this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
         // 
         // panelUst
         // 
         this.panelUst.Controls.Add(this.buttonTamam);
         this.panelUst.Controls.Add(this.textBoxHareketKodu);
         this.panelUst.Controls.Add(this.textBoxAciklama1);
         this.panelUst.Controls.Add(this.textBoxCikanDepo);
         this.panelUst.Controls.Add(this.textBoxBelgeNo);
         this.panelUst.Controls.Add(this.textBoxGirenDepo);
         this.panelUst.Controls.Add(this.buttonBelgeNoSec);
         this.panelUst.Controls.Add(this.label2);
         this.panelUst.Controls.Add(this.label1);
         this.panelUst.Controls.Add(this.label3);
         this.panelUst.Controls.Add(this.buttonCikanDepoSec);
         this.panelUst.Controls.Add(this.buttonGirenDepoSec);
         this.panelUst.Controls.Add(this.button3);
         this.panelUst.Controls.Add(this.button4);
         this.panelUst.Controls.Add(this.label5);
         this.panelUst.Controls.Add(this.buttonAciklama1Sil);
         this.panelUst.Controls.Add(this.label6);
         this.panelUst.Controls.Add(this.textBoxAciklama2);
         this.panelUst.Controls.Add(this.buttonAciklama2Sil);
         this.panelUst.Controls.Add(this.textBoxCariAdi);
         this.panelUst.Controls.Add(this.buttonCariAdiSil);
         this.panelUst.Controls.Add(this.label7);
         this.panelUst.Controls.Add(this.buttonCariKoduSil);
         this.panelUst.Controls.Add(this.textBoxCariKodu);
         this.panelUst.Controls.Add(this.label8);
         this.panelUst.Controls.Add(this.buttonCariAdiSec);
         this.panelUst.Controls.Add(this.label9);
         this.panelUst.Controls.Add(this.buttonHareketKoduSec);
         this.panelUst.Controls.Add(this.buttonHareketKoduSil);
         this.panelUst.Controls.Add(this.label10);
         this.panelUst.Controls.Add(this.buttonOzelKodSil);
         this.panelUst.Controls.Add(this.textBoxOzelKod);
         this.panelUst.Controls.Add(this.label4);
         this.panelUst.Controls.Add(this.textBoxIrsaliyeNo);
         this.panelUst.Controls.Add(this.buttonIrsaliyeSec);
         this.panelUst.Controls.Add(this.buttonIrsaliyeSil);
         this.panelUst.Controls.Add(this.buttonCariKoduSec);
         this.panelUst.Controls.Add(this.buttonOzelKodSec);
         this.panelUst.Location = new System.Drawing.Point(248, 24);
         this.panelUst.Name = "panelUst";
         this.panelUst.Size = new System.Drawing.Size(234, 288);
         // 
         // buttonTamam
         // 
         this.buttonTamam.Location = new System.Drawing.Point(165, 225);
         this.buttonTamam.Name = "buttonTamam";
         this.buttonTamam.Size = new System.Drawing.Size(54, 24);
         this.buttonTamam.TabIndex = 0;
         this.buttonTamam.Text = "TAMAM";
         this.buttonTamam.Click += new System.EventHandler(this.buttonTamam_Click);
         // 
         // textBoxHareketKodu
         // 
         this.textBoxHareketKodu.BackColor = System.Drawing.Color.Salmon;
         this.textBoxHareketKodu.Location = new System.Drawing.Point(64, 185);
         this.textBoxHareketKodu.Name = "textBoxHareketKodu";
         this.textBoxHareketKodu.Size = new System.Drawing.Size(101, 23);
         this.textBoxHareketKodu.TabIndex = 1;
         this.textBoxHareketKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelgeNo_KeyPress);
         // 
         // textBoxAciklama1
         // 
         this.textBoxAciklama1.BackColor = System.Drawing.Color.White;
         this.textBoxAciklama1.Location = new System.Drawing.Point(64, 70);
         this.textBoxAciklama1.Name = "textBoxAciklama1";
         this.textBoxAciklama1.Size = new System.Drawing.Size(130, 23);
         this.textBoxAciklama1.TabIndex = 2;
         // 
         // label5
         // 
         this.label5.Location = new System.Drawing.Point(0, 70);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(64, 16);
         this.label5.Text = "Aciklama1";
         // 
         // buttonAciklama1Sil
         // 
         this.buttonAciklama1Sil.Location = new System.Drawing.Point(195, 70);
         this.buttonAciklama1Sil.Name = "buttonAciklama1Sil";
         this.buttonAciklama1Sil.Size = new System.Drawing.Size(24, 20);
         this.buttonAciklama1Sil.TabIndex = 15;
         this.buttonAciklama1Sil.Text = "X";
         this.buttonAciklama1Sil.Click += new System.EventHandler(this.buttonAciklama1Sil_Click_1);
         // 
         // label6
         // 
         this.label6.Location = new System.Drawing.Point(0, 92);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(64, 16);
         this.label6.Text = "Aciklama1";
         // 
         // textBoxAciklama2
         // 
         this.textBoxAciklama2.BackColor = System.Drawing.Color.White;
         this.textBoxAciklama2.Location = new System.Drawing.Point(64, 90);
         this.textBoxAciklama2.Name = "textBoxAciklama2";
         this.textBoxAciklama2.Size = new System.Drawing.Size(130, 23);
         this.textBoxAciklama2.TabIndex = 17;
         // 
         // buttonAciklama2Sil
         // 
         this.buttonAciklama2Sil.Location = new System.Drawing.Point(195, 90);
         this.buttonAciklama2Sil.Name = "buttonAciklama2Sil";
         this.buttonAciklama2Sil.Size = new System.Drawing.Size(24, 20);
         this.buttonAciklama2Sil.TabIndex = 18;
         this.buttonAciklama2Sil.Text = "X";
         this.buttonAciklama2Sil.Click += new System.EventHandler(this.buttonAciklama2Sil_Click);
         // 
         // textBoxCariAdi
         // 
         this.textBoxCariAdi.BackColor = System.Drawing.Color.PaleTurquoise;
         this.textBoxCariAdi.Location = new System.Drawing.Point(64, 138);
         this.textBoxCariAdi.Name = "textBoxCariAdi";
         this.textBoxCariAdi.Size = new System.Drawing.Size(101, 23);
         this.textBoxCariAdi.TabIndex = 19;
         this.textBoxCariAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelgeNo_KeyPress);
         // 
         // buttonCariAdiSil
         // 
         this.buttonCariAdiSil.Location = new System.Drawing.Point(195, 138);
         this.buttonCariAdiSil.Name = "buttonCariAdiSil";
         this.buttonCariAdiSil.Size = new System.Drawing.Size(24, 20);
         this.buttonCariAdiSil.TabIndex = 20;
         this.buttonCariAdiSil.Text = "X";
         this.buttonCariAdiSil.Click += new System.EventHandler(this.buttonCariKoduSil_Click);
         // 
         // label7
         // 
         this.label7.Location = new System.Drawing.Point(0, 143);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(64, 16);
         this.label7.Text = "Cari Adi";
         // 
         // buttonCariKoduSil
         // 
         this.buttonCariKoduSil.Location = new System.Drawing.Point(195, 118);
         this.buttonCariKoduSil.Name = "buttonCariKoduSil";
         this.buttonCariKoduSil.Size = new System.Drawing.Size(24, 20);
         this.buttonCariKoduSil.TabIndex = 22;
         this.buttonCariKoduSil.Text = "X";
         this.buttonCariKoduSil.Click += new System.EventHandler(this.buttonCariKoduSil_Click);
         // 
         // textBoxCariKodu
         // 
         this.textBoxCariKodu.BackColor = System.Drawing.Color.PaleTurquoise;
         this.textBoxCariKodu.Location = new System.Drawing.Point(64, 117);
         this.textBoxCariKodu.Name = "textBoxCariKodu";
         this.textBoxCariKodu.Size = new System.Drawing.Size(101, 23);
         this.textBoxCariKodu.TabIndex = 23;
         this.textBoxCariKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelgeNo_KeyPress);
         // 
         // label8
         // 
         this.label8.Location = new System.Drawing.Point(0, 118);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(64, 16);
         this.label8.Text = "Cari Kodu";
         // 
         // buttonCariAdiSec
         // 
         this.buttonCariAdiSec.Location = new System.Drawing.Point(160, 138);
         this.buttonCariAdiSec.Name = "buttonCariAdiSec";
         this.buttonCariAdiSec.Size = new System.Drawing.Size(35, 20);
         this.buttonCariAdiSec.TabIndex = 25;
         this.buttonCariAdiSec.Text = "...";
         this.buttonCariAdiSec.Click += new System.EventHandler(this.buttonCariKoduSec_Click);
         // 
         // label9
         // 
         this.label9.Location = new System.Drawing.Point(0, 187);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(80, 16);
         this.label9.Text = "Hareket Kod";
         // 
         // buttonHareketKoduSec
         // 
         this.buttonHareketKoduSec.Location = new System.Drawing.Point(160, 185);
         this.buttonHareketKoduSec.Name = "buttonHareketKoduSec";
         this.buttonHareketKoduSec.Size = new System.Drawing.Size(35, 20);
         this.buttonHareketKoduSec.TabIndex = 27;
         this.buttonHareketKoduSec.Text = "...";
         this.buttonHareketKoduSec.Click += new System.EventHandler(this.buttonHareketKoduSec_Click);
         // 
         // buttonHareketKoduSil
         // 
         this.buttonHareketKoduSil.Location = new System.Drawing.Point(195, 185);
         this.buttonHareketKoduSil.Name = "buttonHareketKoduSil";
         this.buttonHareketKoduSil.Size = new System.Drawing.Size(24, 20);
         this.buttonHareketKoduSil.TabIndex = 28;
         this.buttonHareketKoduSil.Text = "X";
         this.buttonHareketKoduSil.Click += new System.EventHandler(this.buttonHareketKoduSil_Click);
         // 
         // label10
         // 
         this.label10.Location = new System.Drawing.Point(8, 207);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(56, 16);
         this.label10.Text = "Ozel Kod";
         // 
         // buttonOzelKodSil
         // 
         this.buttonOzelKodSil.Location = new System.Drawing.Point(195, 205);
         this.buttonOzelKodSil.Name = "buttonOzelKodSil";
         this.buttonOzelKodSil.Size = new System.Drawing.Size(24, 20);
         this.buttonOzelKodSil.TabIndex = 30;
         this.buttonOzelKodSil.Text = "X";
         this.buttonOzelKodSil.Click += new System.EventHandler(this.buttonHareketKoduSil_Click);
         // 
         // textBoxOzelKod
         // 
         this.textBoxOzelKod.BackColor = System.Drawing.Color.Salmon;
         this.textBoxOzelKod.Location = new System.Drawing.Point(64, 205);
         this.textBoxOzelKod.Name = "textBoxOzelKod";
         this.textBoxOzelKod.Size = new System.Drawing.Size(101, 23);
         this.textBoxOzelKod.TabIndex = 31;
         this.textBoxOzelKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelgeNo_KeyPress);
         // 
         // label4
         // 
         this.label4.Location = new System.Drawing.Point(0, 165);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(64, 16);
         this.label4.Text = "Irsaliye No";
         // 
         // textBoxIrsaliyeNo
         // 
         this.textBoxIrsaliyeNo.BackColor = System.Drawing.Color.White;
         this.textBoxIrsaliyeNo.Location = new System.Drawing.Point(64, 165);
         this.textBoxIrsaliyeNo.Name = "textBoxIrsaliyeNo";
         this.textBoxIrsaliyeNo.Size = new System.Drawing.Size(101, 23);
         this.textBoxIrsaliyeNo.TabIndex = 33;
         // 
         // buttonIrsaliyeSec
         // 
         this.buttonIrsaliyeSec.Location = new System.Drawing.Point(160, 165);
         this.buttonIrsaliyeSec.Name = "buttonIrsaliyeSec";
         this.buttonIrsaliyeSec.Size = new System.Drawing.Size(35, 20);
         this.buttonIrsaliyeSec.TabIndex = 34;
         this.buttonIrsaliyeSec.Text = "...";
         this.buttonIrsaliyeSec.Click += new System.EventHandler(this.buttonIrsaliyeSec_Click);
         // 
         // buttonIrsaliyeSil
         // 
         this.buttonIrsaliyeSil.Location = new System.Drawing.Point(195, 165);
         this.buttonIrsaliyeSil.Name = "buttonIrsaliyeSil";
         this.buttonIrsaliyeSil.Size = new System.Drawing.Size(24, 20);
         this.buttonIrsaliyeSil.TabIndex = 35;
         this.buttonIrsaliyeSil.Text = "X";
         this.buttonIrsaliyeSil.Click += new System.EventHandler(this.buttonIrsaliyeSil_Click);
         // 
         // buttonCariKoduSec
         // 
         this.buttonCariKoduSec.Location = new System.Drawing.Point(160, 118);
         this.buttonCariKoduSec.Name = "buttonCariKoduSec";
         this.buttonCariKoduSec.Size = new System.Drawing.Size(35, 20);
         this.buttonCariKoduSec.TabIndex = 36;
         this.buttonCariKoduSec.Text = "...";
         this.buttonCariKoduSec.Click += new System.EventHandler(this.buttonCariKoduSec_Click);
         // 
         // buttonOzelKodSec
         // 
         this.buttonOzelKodSec.Location = new System.Drawing.Point(160, 205);
         this.buttonOzelKodSec.Name = "buttonOzelKodSec";
         this.buttonOzelKodSec.Size = new System.Drawing.Size(35, 20);
         this.buttonOzelKodSec.TabIndex = 37;
         this.buttonOzelKodSec.Text = "...";
         this.buttonOzelKodSec.Click += new System.EventHandler(this.buttonHareketKoduSec_Click);
         // 
         // SeriliTransfer
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.ClientSize = new System.Drawing.Size(638, 455);
         this.ControlBox = false;
         this.Controls.Add(this.panelUst);
         this.Controls.Add(this.listView1);
         this.Controls.Add(this.panel2);
         this.Menu = this.mainMenu1;
         this.Name = "SeriliTransfer";
         this.Text = "Serili Stok Transferi";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.SeriliTransfer_Load);
         this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SeriliTransfer_KeyUp);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SeriliTransfer_KeyDown);
         this.panel2.ResumeLayout(false);
         this.panelUst.ResumeLayout(false);
         this.ResumeLayout(false);

		}
		#endregion
		private bool ListeyeBak(string seri)
		{
			try
			{
				if(listView1.Items.Count < 1)return false;

				for(int i = 0;i <listView1.Items.Count;i++)
				{
					if(listView1.Items[i].SubItems[0].Text.Equals(seri))return true;
				}
				return false;
			}
			catch
			{
				return false;
			}
		}
		private void Okunanlar()
		{
			Utility.Engine.sql = string.Format(@"SELECT Seri,StokKodu, StokAdi, Birim, Miktar, GirenDepo, CikanDepo
FROM         terminal_girisi
WHERE     (Islem = 'Serili Stok Transferi') AND (Kullanici = '{0}') AND  (FLAG = 'H') ",Utility.Engine.KullaniciID);
			Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
		}

		private void Ekran(Ekranlar ekr)
		{
			if(ekr == Ekranlar.Ust)
			{
				panelUst.Location = new Point(0,24);
				panelUst.Visible = true;
				panelUst.BringToFront();
			}
			else
			{
				panelUst.Visible = false;
				textBoxBarkod.Focus();
				return;
			}
		}
		private void SeriliTransfer_Load(object sender, System.EventArgs e)
		{
			#region START SCANNER AS A SCAN WEDGE
//			continuescanner=true;
//			ts=new System.Threading.ThreadStart(MyScanner);
//			th=new System.Threading.Thread(ts);
//			th.Start();
			#endregion

			Ekran(Ekranlar.Ust);
//			stek.Utility.Engine=Utility.Engine;
//			Utility.Engine.sql="SELECT HareketKodu FROM hareket_tanim ORDER BY HareketKodu";
//			Utility.Engine.dat.ComboDoldur(Utility.Engine.sql,stek.comboBoxHareketTipi);
			Okunanlar();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			textBoxBelgeNo.Text="";
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			textBoxCikanDepo.Text="";
			textBoxCikanDepo.BackColor=Color.White;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			textBoxGirenDepo.Text="";
		}

		private void buttonBelgeNoSec_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
			s.sql="SELECT BelgeNo,CikanDepo,GirenDepo,KullaniciID,Tarih,Saat FROM stok_hareket_ust";
			s.sql_where= " WHERE HareketTipi='Serili Stok Transferi' ";
			s.sql_orderby=" ORDER BY Tarih DESC,Saat DESC";
			s.tablename="stok_hareket_ust";
			
			s.ShowDialog();
			if(s.dr!=null)
			{
				textBoxBelgeNo.Text=s.dr["BelgeNo"].ToString();
				textBoxCikanDepo.Text=s.dr["CikanDepo"].ToString();
				textBoxGirenDepo.Text=s.dr["GirenDepo"].ToString();

				Utility.Engine.sql="SELECT Aciklama1,Aciklama2,IrsaliyeNo,IrsaliyeTarih,HareketKodu,CariKod FROM stok_hareket_ust WHERE stok_hareket_ust.BelgeNo='";
				Utility.Engine.sql+=textBoxBelgeNo.Text;
				Utility.Engine.sql+="'";

				System.Data.IDataReader rd=Utility.Engine.dat.TSelect(Utility.Engine.sql);
				if(rd!=null && rd.Read())
				{
					stek.textBoxAciklama1.Text=rd.GetValue(rd.GetOrdinal("Aciklama1")).ToString();
					
					stek.textBoxAciklama2.Text=rd.GetValue(rd.GetOrdinal("Aciklama2")).ToString();
					
					if(rd.IsDBNull(rd.GetOrdinal("IrsaliyeNo")))
						stek.textBoxIrsaliyeNo.Text="";
					else
						stek.textBoxIrsaliyeNo.Text=rd.GetValue(rd.GetOrdinal("IrsaliyeNo")).ToString();
					string tarih;

					if(rd.IsDBNull(rd.GetOrdinal("IrsaliyeTarih")))
						tarih="2005-01-01";
					else
						tarih=rd.GetValue(rd.GetOrdinal("IrsaliyeTarih")).ToString();
					//stek.m_picker1.Value=Convert.ToDateTime(tarih);

					if(rd.IsDBNull(rd.GetOrdinal("HareketKodu")))
						stek.comboBoxHareketTipi.SelectedIndex=-1;
					else
					{
						stek.comboBoxHareketTipi.SelectedIndex=-1;
						string hareketkodu=rd.GetValue(rd.GetOrdinal("HareketKodu")).ToString();
						for(int i=0;i<stek.comboBoxHareketTipi.Items.Count;i++)
						{
							if(hareketkodu==stek.comboBoxHareketTipi.Items[i].ToString())
							{
								stek.comboBoxHareketTipi.SelectedIndex=i;
								break;
							}	
						}
					}

					if(rd.IsDBNull(rd.GetOrdinal("CariKod")))
						stek.textBoxCariKod.Text="";
					else
						stek.textBoxCariKod.Text=rd.GetValue(rd.GetOrdinal("CariKod")).ToString();
				}
				else
				{
					stek.textBoxAciklama2.Text=stek.textBoxAciklama1.Text="";
				}
				if(rd!=null)
					rd.Close();

				listView1.Items.Clear();
				
				Utility.Engine.sql="SELECT shd.BelgeNo,shd.StokKodu,stu.StokAdi,shd.Birim,shd.Miktar,shd.SeriliBarkod FROM stok_hareket_detay shd,stok_tanim_ust stu WHERE shd.StokKodu=stu.StokKodu AND shd.BelgeNo='";
				Utility.Engine.sql+=textBoxBelgeNo.Text;
				Utility.Engine.sql+="'";

				rd=Utility.Engine.dat.TSelect(Utility.Engine.sql);
				while(rd!=null && rd.Read())
				{
					ListViewItem li=new ListViewItem(rd.GetValue(rd.GetOrdinal("SeriliBarkod")).ToString());
					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("StokKodu")).ToString());
					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("StokAdi")).ToString());
					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("Birim")).ToString());
					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("Miktar")).ToString());
					listView1.Items.Add(li);
				}
				if(rd!=null)
					rd.Close();

				menuItemKaydet.Enabled=false;

				#region Stok Dönüşüm deposu ise

				Utility.Engine.sql="SELECT StokDonusumDeposu FROM depo_tanim WHERE DepoKodu='";
				Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxCikanDepo.Text);
				Utility.Engine.sql+="'";

				if(Utility.Engine.dat.TSelectScalar(Utility.Engine.sql)=="E")
				{
					textBoxCikanDepo.BackColor=Color.Turquoise;
				}
				else
				{
					textBoxCikanDepo.BackColor=Color.White;
				}

				#endregion
			}

//			Sec s=new Sec();
//			s.sql="SELECT BelgeNo,CikanDepo,GirenDepo,KullaniciID,Tarih,Saat FROM stok_hareket_ust";
//			s.sql_where = " WHERE HareketTipi='Serili Stok Transferi' ";
//			s.sql_orderby=" ORDER BY Tarih DESC,Saat DESC";
//			s.tablename="stok_hareket_ust";
//			
//			s.ShowDialog();
//			if(s.dr!=null)
//			{
//				textBoxBelgeNo.Text=s.dr["BelgeNo"].ToString();
//				textBoxCikanDepo.Text=s.dr["CikanDepo"].ToString();
//				textBoxGirenDepo.Text=s.dr["GirenDepo"].ToString();
//
//				listView1.Items.Clear();
//				
//				Utility.Engine.sql="SELECT shd.BelgeNo,shd.StokKodu,stu.StokAdi,shd.Birim,shd.Miktar,shd.SeriliBarkod FROM stok_hareket_detay shd,stok_tanim_ust stu WHERE shd.StokKodu=stu.StokKodu AND shd.BelgeNo='";
//				Utility.Engine.sql+=textBoxBelgeNo.Text;
//				Utility.Engine.sql+="'";
//
//				System.Data.IDataReader rd=Utility.Engine.dat.TSelect(Utility.Engine.sql);
//				while(rd!=null && rd.Read())
//				{
//					ListViewItem li=new ListViewItem(rd.GetValue(rd.GetOrdinal("SeriliBarkod")).ToString());
//					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("StokKodu")).ToString());
//					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("StokAdi")).ToString());
//					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("Birim")).ToString());
//					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("Miktar")).ToString());
//					listView1.Items.Add(li);
//				}
//				if(rd!=null)
//					rd.Close();
//
//				buttonKaydet.Enabled=false;
//			}
		}

		private void buttonCikanDepoSec_Click(object sender, System.EventArgs e)
		{
			DepoSecimOzel oz = new DepoSecimOzel();
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxCikanDepo.Text = oz.DepoKodu;
				Utility.Engine.sql = "SELECT Eksi FROM depo_tanim  WHERE (DepoKodu = N'";
				Utility.Engine.sql += textBoxCikanDepo.Text;
				Utility.Engine.sql += "')";
				if(Utility.Engine.dat.TSelectScalar(Utility.Engine.sql) == "E")
					Utility.Engine.EksiStokOlmasin = false;
			}
//			SecTree st=new SecTree();
//			st.Utility.Engine=Utility.Engine;
//			st.sql="SELECT UstDepoKodu,DepoKodu FROM depo_tanim";
//			st.ShowDialog();
//
//			if(listView1.Items.Count>0)
//			{
//				if(MessageBox.Show("Daha önce eklenen barkodlar silinecek.\nOnay veriyor musunuz?","Uyari",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)!=DialogResult.OK)
//					return;
//				listView1.Items.Clear();
//			}
//
//			if(st.selected!="")
//				textBoxCikanDepo.Text=st.selected;
//
//			#region Stok Dönüşüm deposu ise
//
//			Utility.Engine.sql="SELECT StokDonusumDeposu FROM depo_tanim WHERE DepoKodu='";
//			Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxCikanDepo.Text);
//			Utility.Engine.sql+="'";
//
//			if(Utility.Engine.dat.TSelectScalar(Utility.Engine.sql)=="E")
//			{
//				textBoxCikanDepo.BackColor=Color.Turquoise;
//			}
//			else
//			{
//				textBoxCikanDepo.BackColor=Color.White;
//			}
//
//			#endregion
		}

		private void buttonGirenDepoSec_Click(object sender, System.EventArgs e)
		{
			DepoSecimOzel oz = new DepoSecimOzel();
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxGirenDepo.Text = oz.DepoKodu;
			}
//			SecTree st=new SecTree();
//			st.Utility.Engine=Utility.Engine;
//			st.sql="SELECT UstDepoKodu,DepoKodu FROM depo_tanim";
//			st.ShowDialog();
//			if(st.selected!="")
//				textBoxGirenDepo.Text=st.selected;
		}

		private void buttonCik_Click(object sender, System.EventArgs e)
		{
			
		}

		private void buttonBarkodEkle_Click(object sender, System.EventArgs e)
		{
			if(checkBoxSeri.Checked)
				BarkodEkle();
		}

		private void textBoxBarkod_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				if(textBoxBarkod.Text.Length > 8)
					BarkodEkle();
				//else PaletEkle();
			}
		}

		private void SeriliTransfer_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Up))
			{
				if(listView1.SelectedIndices.Count>0 && listView1.SelectedIndices[0]>0)
				{
					listView1.Items[listView1.SelectedIndices[0]].Selected=false;
					listView1.Items[listView1.SelectedIndices[0]-1].Selected=true;
				}
				return;
			}

			if(e.KeyCode.Equals(Keys.Down))
			{
				if(listView1.SelectedIndices.Count>0 && listView1.SelectedIndices[0]<listView1.Items.Count-1)
				{
					listView1.Items[listView1.SelectedIndices[0]].Selected=false;
					listView1.Items[listView1.SelectedIndices[0]+1].Selected=true;
				}
				return;
			}	
		}

		private void SeriliTransfer_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue==220)
			{
				textBoxBarkod.Text="";
				textBoxBarkod.Focus();
				return;
			}
		}

		private void textBoxBelgeNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			SeriliTransfer_KeyDown(sender,e);
		}

		private void textBoxBarkod_TextChanged(object sender, System.EventArgs e)
		{
			textBoxBarkod.Text=textBoxBarkod.Text.Replace("|","");
		}

		public void BarkodEkle()
		{
			string StokKodu,StokAdi,Birim,Miktar;

			if(textBoxHareketKodu.Text.Equals(""))
			{
				Utility.Engine.Hata("Hareket Kodu Secilmelidir!");
				Ekran(Ekranlar.Ust);
				return;
			}

			if(textBoxBarkod.Text.Length<2)
				return;
			if(menuItemKaydet.Enabled!=true)
				return;

			textBoxBarkod.Text = textBoxBarkod.Text.ToUpper();

			try
			{
				for(int i=0;i<listView1.Items.Count;i++)
				{
						if(listView1.Items[i].Text==textBoxBarkod.Text)
						{
							MessageBox.Show(textBoxBarkod.Text + " Numarali Barkod Listeye Ekli.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
							textBoxBarkod.Text="";
							textBoxBarkod.Focus();
							return;
						}
				}
			}
			catch(ArgumentOutOfRangeException ar)
			{
				MessageBox.Show(ar.Message);
			}

			Utility.Engine.sql="SELECT serili_barkodlar.SeriliBarkod,serili_barkodlar.StokKodu,stok_tanim_ust.StokAdi,serili_barkodlar.Birim,serili_barkodlar.Miktar from serili_barkodlar LEFT OUTER JOIN stok_tanim_ust ON serili_barkodlar.StokKodu=stok_tanim_ust.StokKodu WHERE SeriliBarkod='";
			Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxBarkod.Text).ToUpper();
			Utility.Engine.sql+="'";

			string str;
			System.Data.IDataReader rd=Utility.Engine.dat.TSelect(Utility.Engine.sql);
			if(rd!=null && rd.Read()==false)
			{
				MessageBox.Show(textBoxBarkod.Text + " numarali barkod serili barkodlar tablosunda bulunamadi","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxBarkod.SelectAll();
				textBoxBarkod.Focus();
				if(rd!=null)
					rd.Close();
				return;
			}

			StokKodu=rd.GetValue(rd.GetOrdinal("StokKodu")).ToString();
			StokAdi=rd.GetValue(rd.GetOrdinal("StokAdi")).ToString();
			Birim=rd.GetValue(rd.GetOrdinal("Birim")).ToString();
			Miktar=rd.GetValue(rd.GetOrdinal("Miktar")).ToString();
			if(rd!=null)
				rd.Close();

			//			if(textBoxCikanDepo.Text.Length>0)
			//			{
			//				Utility.Engine.sql="SELECT SeriliBarkod from depo_mevcut WHERE SeriliBarkod='";
			//				Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxBarkod.Text);
			//				Utility.Engine.sql+="'";
			//
			//				if((str=Utility.Engine.dat.TSelectScalar(Utility.Engine.sql))==null || str.Length<1)
			//				{
			//					MessageBox.Show(textBoxBarkod.Text + " Numarali Barkod " + textBoxCikanDepo.Text + " Deposunda Bulunamadi","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
			//					textBoxBarkod.SelectAll();
			//					textBoxBarkod.Focus();
			//					return;
			//				}
			//			}



			Utility.Engine.sql = "SELECT DepoKodu from depo_mevcut WHERE SeriliBarkod='";
			Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxBarkod.Text).ToUpper();
			Utility.Engine.sql += "' And DepoKodu = '";
			Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxCikanDepo.Text);
			Utility.Engine.sql += "'";

			if ((str = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql)) == null || str.Length < 1)
			{
				MessageBox.Show(textBoxBarkod.Text + " Numarali Barkod Kaydi " + Utility.Engine.SqlTemizle(textBoxCikanDepo.Text) + " Deposunda Bulunamadi->" + str, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
				textBoxBarkod.SelectAll();
				textBoxBarkod.Focus();
				return;
			}

			Utility.Engine.sql =
				string.Format(@"IF NOT EXISTS(SELECT * FROM terminal_girisi WHERE Islem = 'Serili Stok Transferi' AND Kullanici = '{5}' AND StokKodu = '{1}' AND Seri = '{7}' AND FLAG = 'H') BEGIN INSERT INTO terminal_girisi (Seri, Barkod, StokKodu, StokAdi, Birim, Miktar, GirenDepo, CikanDepo, BelgeNo, Kullanici, Islem, Ozel)
VALUES     ('{7}','{0}','{1}','{2}','{3}','{4}','{9}','{8}','','{5}','Serili Stok Transferi','{6}') SELECT 'OK' END ELSE BEGIN SELECT 'ZATEN EKLENMIS' END",
				Utility.Engine.SqlTemizle(StokKodu),
				StokKodu,
				StokAdi,
				Birim,
				Miktar,
				Utility.Engine.KullaniciID,
				Utility.Engine.SqlTemizle(textBoxIrsaliyeNo.Text),
				Utility.Engine.SqlTemizle(textBoxBarkod.Text),
				Utility.Engine.SqlTemizle(textBoxCikanDepo.Text),
				Utility.Engine.SqlTemizle(textBoxGirenDepo.Text));

			if(Utility.Engine.dat.TSelectScalar(Utility.Engine.sql) != "OK")
			{
				MessageBox.Show(string.Format("KAYDEDiLEMEDi DAHA ÖNCE EKLENMiş ÜRÜN EKLENEMEZ!"),"DIKKAT!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxBarkod.Text = "";
				textBoxBarkod.Focus();
				return;
			}

			ListViewItem li=new ListViewItem(textBoxBarkod.Text);
			li.SubItems.Add(StokKodu);
			li.SubItems.Add(StokAdi);
			li.SubItems.Add(Birim);
			li.SubItems.Add(Miktar);
			li.SubItems.Add(Utility.Engine.SqlTemizle(textBoxGirenDepo.Text));
			li.SubItems.Add(Utility.Engine.SqlTemizle(textBoxCikanDepo.Text));
			listView1.Items.Add(li);
         textBoxBarkod.BackColor = Color.Yellow;
			textBoxBarkod.Text="";
			textBoxBarkod.Focus();
			return;
		}

		private void PaletEkle()
		{
			try
			{
				if(textBoxBarkod.Text.Length < 2)
				{
					textBoxBarkod.Text = "";
					textBoxBarkod.Focus();
					return;
				}

				try
				{
					int o = Convert.ToInt32(textBoxBarkod.Text.Trim());
				}
				catch
				{
					textBoxBarkod.Text = "";
					textBoxBarkod.Focus();
					return;
				}

				Utility.Engine.sql = "EXEC dbo.PaletBulSerili ";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxBarkod.Text);
				Utility.Engine.sql += ",'";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxCikanDepo.Text);
				Utility.Engine.sql += "'";

				DataTable seriler = new DataTable();

				Utility.Engine.dat.TableDoldur(Utility.Engine.sql,ref seriler);

				if(seriler != null && seriler.Rows.Count > 0)
				{
					for(int i = 0;i<seriler.Rows.Count;i++)
					{
						if(!ListeyeBak(seriler.Rows[i]["SeriliBarkod"].ToString()))
						{
							Utility.Engine.sql =
								string.Format(@"IF NOT EXISTS(SELECT * FROM terminal_girisi WHERE Islem = 'Serili Stok Transferi' AND Kullanici = '{5}' AND StokKodu = '{1}' AND Seri = '{7}' AND FLAG = 'H') BEGIN INSERT INTO terminal_girisi (Seri, Barkod, StokKodu, StokAdi, Birim, Miktar, GirenDepo, CikanDepo, BelgeNo, Kullanici, Islem, Ozel)
VALUES     ('{7}','{0}','{1}','{2}','{3}','{4}','{9}','{8}','','{5}','Serili Stok Transferi','{6}') SELECT 'OK' END ELSE BEGIN SELECT 'ZATEN EKLENMIS' END",
								seriler.Rows[i]["StokKodu"].ToString(),
								seriler.Rows[i]["StokKodu"].ToString(),
								seriler.Rows[i]["StokAdi"].ToString(),
								seriler.Rows[i]["Birim"].ToString(),
								seriler.Rows[i]["Miktar"].ToString(),
								Utility.Engine.KullaniciID,
								Utility.Engine.SqlTemizle(textBoxIrsaliyeNo.Text),
								seriler.Rows[i]["SeriliBarkod"].ToString(),
								Utility.Engine.SqlTemizle(textBoxGirenDepo.Text),
								Utility.Engine.SqlTemizle(textBoxCikanDepo.Text));

							if(Utility.Engine.dat.TSelectScalar(Utility.Engine.sql) != "OK")
							{
								MessageBox.Show(string.Format("KAYDEDiLEMEDi DAHA ÖNCE EKLENMiş ÜRÜN EKLENEMEZ!"),"DIKKAT!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
								textBoxBarkod.Text = "";
								textBoxBarkod.Focus();
								return;
							}

							ListViewItem li=new ListViewItem(seriler.Rows[i]["SeriliBarkod"].ToString());
							li.SubItems.Add(seriler.Rows[i]["StokKodu"].ToString());
							li.SubItems.Add(seriler.Rows[i]["StokAdi"].ToString());
							li.SubItems.Add(seriler.Rows[i]["Birim"].ToString());
							li.SubItems.Add(seriler.Rows[i]["Miktar"].ToString());
							li.SubItems.Add(Utility.Engine.SqlTemizle(textBoxGirenDepo.Text));
							li.SubItems.Add(Utility.Engine.SqlTemizle(textBoxCikanDepo.Text));
							listView1.Items.Add(li);
                     textBoxBarkod.BackColor = Color.Salmon;
							textBoxBarkod.Text="";
							textBoxBarkod.Focus();
							return;
						}
					}
				}
				else
				{
					Utility.Engine.Hata("Palette Hic Seri Bulunamadi!");
				}

				textBoxBarkod.Text = "";
				textBoxBarkod.Focus();
				return;
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Palet Sorgulanamadi:" + exc.Message);
				textBoxBarkod.Text = "";
				textBoxBarkod.Focus();
				return;
			}
		}
		private void buttonAciklama1Sil_Click(object sender, System.EventArgs e)
		{
			stek.textBoxAciklama1.Text="";
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count<1)
			{
				MessageBox.Show("Seçili Satir Yok","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}
			if(MessageBox.Show(listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text + " Numarali Barkod Listeden Çikarilacak!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
				return;

			int inxx = listView1.SelectedIndices[0];

			Utility.Engine.sql = string.Format(@"DELETE FROM  terminal_girisi WHERE     (Islem = 'Serili Stok Transferi') AND (Kullanici = '{0}') AND (FLAG = 'H') AND (StokKodu = '{1}') AND (Seri = '{2}')",
				Utility.Engine.KullaniciID,
				listView1.Items[inxx].SubItems[0].Text,
				listView1.Items[inxx].SubItems[1].Text);

			if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
			{
				MessageBox.Show("Gecici Kayitlar Temizlenirken Hata Olustu!!\n" + Utility.Engine.dat.STR_HataMesaji,"DIKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxBarkod.Focus();
				return;
			}

			listView1.Items.RemoveAt(inxx);
			textBoxBarkod.Text = "";
			textBoxBarkod.Focus();
			return;
			

		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Listedeki Tüm Barkodlar Silinecek!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
				return;

			Utility.Engine.sql = string.Format(@"DELETE FROM  terminal_girisi WHERE     (Islem = 'Serili Stok Transferi') AND (Kullanici = '{0}') AND (FLAG = 'H') ",Utility.Engine.KullaniciID);

			if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
			{
				MessageBox.Show("Gecici Kayitlar Temizlenirken Hata Olustu!!\n" + Utility.Engine.dat.STR_HataMesaji,"DIKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxBarkod.Text = "";
				textBoxBarkod.Focus();
				return;
			}

			Temizle();
			textBoxBarkod.Text = "";
			textBoxBarkod.Focus();
			return;
		}

		private void menuItem1_Click_2(object sender, System.EventArgs e)
		{
			if(textBoxBelgeNo.Text.Length < 1 && listView1.Items.Count>0)
			{
				if(MessageBox.Show("Yapilan işlem Kaydedilmemiş\nKaydetmeden istiyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)!=DialogResult.OK)
					return;
			}
			Temizle();
		}
		private void Temizle()
		{
			textBoxCikanDepo.Text="";
			textBoxGirenDepo.Text="";
			textBoxAciklama1.Text = "";
			textBoxAciklama2.Text = "";
			listView1.Items.Clear();
			textBoxIrsaliyeNo.Text="";
			textBoxBelgeNo.Text = "";
			textBoxCariAdi.Text = "";
			textBoxCariKodu.Text = "";
			textBoxHareketKodu.Text = "";
			textBoxOzelKod.Text = "";
			menuItemKaydet.Enabled=true;
			textBoxCikanDepo.BackColor=Color.White;
			textBoxBarkod.Text = "";
			textBoxBarkod.Focus();
			return;
		}
		private void menuItem2_Click_1(object sender, System.EventArgs e)
		{
			if(textBoxBelgeNo.Text=="")
				return;
			textBoxBelgeNo.Text="";
			textBoxCikanDepo.Text="";
			textBoxGirenDepo.Text="";
			menuItemKaydet.Enabled=true;
		}

		private void menuItemKaydet_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Yapilan işlemler kaydedilecek!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
				return;

			if(textBoxHareketKodu.Text.Equals(""))
			{
				MessageBox.Show("Hareket Kodunu Secmelisiniz!!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				stek.ShowDialog();
				return;
			}
			if(textBoxCikanDepo.Text == textBoxGirenDepo.Text)
			{
				MessageBox.Show("Ayni Depoda Hareket Yapilamaz!!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxCikanDepo.Focus();
				return;
			}

			AmbarPC.Fis f=new AmbarPC.Fis();
			f.IrsaliyeNo = textBoxIrsaliyeNo.Text;
			f.HareketTipi = "Serili Stok Transferi";
			f.CariKod = textBoxCariKodu.Text;
			f.SiparisIliski = false;
			f.HareketKodu = Utility.Engine.SqlTemizle(textBoxHareketKodu.Text);
			f.HareketOzel = Utility.Engine.SqlTemizle(textBoxOzelKod.Text);

			f.GirenDepo = textBoxGirenDepo.Text;
			f.KullaniciID = Utility.Engine.KullaniciID;
			f.Tarih = DateTime.Now.ToString("yyyy-MM-dd");
			f.Saat = DateTime.Now.ToString("HH:mm:ss");
			f.Aciklama1 = Utility.Engine.SqlTemizle(textBoxAciklama1.Text);
			f.Aciklama2 = Utility.Engine.SqlTemizle(textBoxAciklama2.Text);
			f.IrsaliyeTarih = DateTime.Now.ToString("yyyy-MM-dd");
			f.HareketOzel = textBoxOzelKod.Text;

			for(int i=0;i<listView1.Items.Count;i++)
			{
				if(listView1.Items[i].SubItems[4].Text=="")
					continue;
				try
				{
					if(Convert.ToDouble(listView1.Items[i].SubItems[4].Text,Utility.Engine.nfi)<=0)
					{
						MessageBox.Show("Negatif/Hatali stok miktari!\nStok miktari pozitif olmalidir.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
						return;
					}
				}
				catch(Exception)
				{
					MessageBox.Show("Negatif/Hatali stok miktari!\nStok miktari pozitif olmalidir.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
					return;
				}

				System.Data.DataRow row=f.detaylar.NewRow();
				row["StokKodu"]=listView1.Items[i].SubItems[1].Text;
				row["Birim"]=listView1.Items[i].SubItems[3].Text;
				row["Miktar"]=listView1.Items[i].SubItems[4].Text;
				row["SeriliBarkod"]=listView1.Items[i].SubItems[0].Text;
				row["GirenDepo"] = Utility.Engine.SqlTemizle(textBoxGirenDepo.Text);
				row["CikanDepo"] = listView1.Items[i].SubItems[6].Text;
				row["Durum"] = "*"; 
				f.detaylar.Rows.Add(row);
			}

			if(f.FisKaydet()==false)
			{
				MessageBox.Show(f.HataMesaji,"BiR HATA OLUşTU",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}

			Utility.Engine.sql = 
				string.Format(@"UPDATE terminal_girisi SET GirenDepo = '{0}',BelgeNo = '{1}',FLAG = 'E' WHERE   (Islem = 'Serili Stok Transferi') AND (Kullanici = '{2}') AND (FLAG = 'H')",
				textBoxGirenDepo.Text,
				f.BelgeNo.ToString(),
				Utility.Engine.KullaniciID);

			if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
			{
				MessageBox.Show("Gecici Kayitlar Guncellenirken Hata Olustu Kayitlari Kontrol Edin","Dikkat!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
			}

			textBoxBelgeNo.Text=f.BelgeNo.ToString();
			if(Utility.Engine.mesajlar)
            MessageBox.Show("işlem Tamamlandi " + f.BelgeNo.ToString() + " nolu Fis Kaydedildi.","işLEM SONUCU",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
			menuItemKaydet.Enabled=false;
			Temizle();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			if(menuItemKaydet.Enabled==true && listView1.Items.Count>0)
			{
				if(MessageBox.Show("Yapilan işlemler kaydedilmedi\nÇikmak için onay veriniz","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)!=DialogResult.OK)
					return;
			}
			Close();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			Yardim yar=new Yardim();
			yar.Text="Bilgi";
			yar.label1.Text="Toplam Kalem Sayisi=" + listView1.Items.Count.ToString() + "\n";
			yar.ShowDialog();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			Ekran(Ekranlar.Ust);
			//stek.ShowDialog();
		}

		private void checkBoxSeri_CheckStateChanged(object sender, System.EventArgs e)
		{
			if(checkBoxSeri.Checked)
			{
				textBoxBarkod.BackColor = Color.Yellow;
				textBoxBarkod.Focus();
				return;
			}
			else
			{
				textBoxBarkod.BackColor = Color.Salmon;
				textBoxBarkod.Focus();
				return;
			}
		}

		private void buttonTamam_Click(object sender, System.EventArgs e)
		{
			Ekran(Ekranlar.Detay);
		}

		private void textBoxBelgeNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void buttonHareketKoduSec_Click(object sender, System.EventArgs e)
		{
			buttonGirenDepoSec.Enabled = true;
			buttonCikanDepoSec.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;

			Sec s=new Sec();
			s.sql="select HareketKodu,HareketAdi,isnull(OzelKod,'') AS OzelKod,isnull(VarGirisDeposu,'') AS VarGirisDeposu,isnull(VarCikisDeposu,'') AS VarCikisDeposu from hareket_tanim (nolock) ";
			s.sql_orderby=" order by HareketKodu ";
			s.tablename="hareket_tanim";
			
			s.ShowDialog();
			if(s.dr!=null)
			{
				textBoxHareketKodu.Text=s.dr["HareketKodu"].ToString();
				textBoxOzelKod.Text = s.dr["OzelKod"].ToString();
				if(!s.dr["VarGirisDeposu"].ToString().Equals(""))
				{
					textBoxGirenDepo.Text = s.dr["VarGirisDeposu"].ToString();
					buttonGirenDepoSec.Enabled = false;
					button4.Enabled = false;
				}
				else
				{
					buttonGirenDepoSec.Enabled = true;
					button4.Enabled = true;
				}
				if(!s.dr["VarCikisDeposu"].ToString().Equals(""))
				{
					textBoxCikanDepo.Text = s.dr["VarCikisDeposu"].ToString();
					buttonCikanDepoSec.Enabled = false;
					button3.Enabled = false;
				}
				else
				{
					buttonCikanDepoSec.Enabled = true;
					button3.Enabled = true;
				}
			}
			else
			{
				textBoxHareketKodu.Text = "";
				textBoxOzelKod.Text = "";
			}
		}

		private void buttonHareketKoduSil_Click(object sender, System.EventArgs e)
		{
			textBoxHareketKodu.Text = "";
			textBoxOzelKod.Text = "";
		}

		private void buttonIrsaliyeSil_Click(object sender, System.EventArgs e)
		{
			textBoxIrsaliyeNo.Text = "";
		}

		private void buttonIrsaliyeSec_Click(object sender, System.EventArgs e)
		{
		
		}

		private void buttonAciklama1Sil_Click_1(object sender, System.EventArgs e)
		{
			textBoxAciklama1.Text = "";
			textBoxAciklama1.Focus();
			return;
		}

		private void buttonAciklama2Sil_Click(object sender, System.EventArgs e)
		{
			textBoxAciklama2.Text = "";
			textBoxAciklama2.Focus();
			return;
		}

		private void buttonCariKoduSec_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
			s.sql="select CariKodu,CariAdi from cari_tanim (nolock) ";
			s.sql_orderby=" order by CariKodu ";
			s.tablename="cari_tanim";
			
			s.ShowDialog();
			if(s.dr!=null)
			{
				textBoxCariKodu.Text=s.dr["CariKodu"].ToString();
				textBoxCariAdi.Text = s.dr["CariAdi"].ToString();
			}
		}

		private void buttonCariKoduSil_Click(object sender, System.EventArgs e)
		{
			textBoxCariKodu.Text = "";
			textBoxCariAdi.Text = "";
		}
	}
}
