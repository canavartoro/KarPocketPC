using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for SerisizTransfer.
	/// </summary>
	public class SerisizTransfer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader COLUMN_StokKodu;
		private System.Windows.Forms.ColumnHeader COLUMN_StokAdi;
		private System.Windows.Forms.ColumnHeader COLUMN_Birim;
		private System.Windows.Forms.ColumnHeader COLUMN_Miktar;
		private System.Windows.Forms.TabPage tabPage1;
		public Engine en;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItemUst;
		private System.Windows.Forms.MenuItem menuItemKaydet;
		private System.Windows.Forms.MenuItem menuItem8;
		public Point clickpos;
		private System.Windows.Forms.ColumnHeader COLUMN_GirenDepo;
		private System.Windows.Forms.ColumnHeader COLUMN_CikanDepo;
		private System.Windows.Forms.Panel panelUst;
		private System.Windows.Forms.Button buttonTamam;
		private System.Windows.Forms.TextBox textBoxHareketKodu;
		private System.Windows.Forms.TextBox textBoxAciklama1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonAciklama1Sil;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxAciklama2;
		private System.Windows.Forms.Button buttonAciklama2Sil;
		private System.Windows.Forms.TextBox textBoxCariAdi;
		private System.Windows.Forms.Button buttonCariAdiSil;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button buttonCariKoduSil;
		private System.Windows.Forms.TextBox textBoxCariKodu;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button buttonCariAdiSec;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button buttonHareketKoduSec;
		private System.Windows.Forms.Button buttonHareketKoduSil;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button buttonOzelKodSil;
		private System.Windows.Forms.TextBox textBoxOzelKod;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBoxIrsaliyeNo;
		private System.Windows.Forms.Button buttonIrsaliyeSec;
		private System.Windows.Forms.Button buttonIrsaliyeSil;
		private System.Windows.Forms.Button buttonCariKoduSec;
		private System.Windows.Forms.Button buttonOzelKodSec;
		private System.Windows.Forms.TextBox textBoxCikanDepo;
		private System.Windows.Forms.TextBox textBoxBelgeNo;
		private System.Windows.Forms.TextBox textBoxGirenDepo;
		private System.Windows.Forms.Button buttonCikanDepoSec;
		private System.Windows.Forms.Button buttonGirenDepoSec;
		private System.Windows.Forms.Button buttonCikanDepoSil;
		private System.Windows.Forms.Button buttonGirenDepoSil;
		public StokTransferEkBilgi stek;
		private enum Ekranlar{Ust,Detay};
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
				return;
			}
		}
		public SerisizTransfer()
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.COLUMN_StokKodu = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_StokAdi = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_Birim = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_Miktar = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_GirenDepo = new System.Windows.Forms.ColumnHeader();
            this.COLUMN_CikanDepo = new System.Windows.Forms.ColumnHeader();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemUst = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemKaydet = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.panelUst = new System.Windows.Forms.Panel();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.textBoxHareketKodu = new System.Windows.Forms.TextBox();
            this.textBoxAciklama1 = new System.Windows.Forms.TextBox();
            this.textBoxCikanDepo = new System.Windows.Forms.TextBox();
            this.textBoxBelgeNo = new System.Windows.Forms.TextBox();
            this.textBoxGirenDepo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCikanDepoSec = new System.Windows.Forms.Button();
            this.buttonGirenDepoSec = new System.Windows.Forms.Button();
            this.buttonCikanDepoSil = new System.Windows.Forms.Button();
            this.buttonGirenDepoSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAciklama1Sil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAciklama2 = new System.Windows.Forms.TextBox();
            this.buttonAciklama2Sil = new System.Windows.Forms.Button();
            this.textBoxCariAdi = new System.Windows.Forms.TextBox();
            this.buttonCariAdiSil = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCariKoduSil = new System.Windows.Forms.Button();
            this.textBoxCariKodu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonCariAdiSec = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonHareketKoduSec = new System.Windows.Forms.Button();
            this.buttonHareketKoduSil = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonOzelKodSil = new System.Windows.Forms.Button();
            this.textBoxOzelKod = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIrsaliyeNo = new System.Windows.Forms.TextBox();
            this.buttonIrsaliyeSec = new System.Windows.Forms.Button();
            this.buttonIrsaliyeSil = new System.Windows.Forms.Button();
            this.buttonCariKoduSec = new System.Windows.Forms.Button();
            this.buttonOzelKodSec = new System.Windows.Forms.Button();
            this.panelUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.COLUMN_StokKodu);
            this.listView1.Columns.Add(this.COLUMN_StokAdi);
            this.listView1.Columns.Add(this.COLUMN_Birim);
            this.listView1.Columns.Add(this.COLUMN_Miktar);
            this.listView1.Columns.Add(this.COLUMN_GirenDepo);
            this.listView1.Columns.Add(this.COLUMN_CikanDepo);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(234, 264);
            this.listView1.TabIndex = 1;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
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
            // COLUMN_Birim
            // 
            this.COLUMN_Birim.Text = "Birim";
            this.COLUMN_Birim.Width = 40;
            // 
            // COLUMN_Miktar
            // 
            this.COLUMN_Miktar.Text = "Miktar";
            this.COLUMN_Miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.COLUMN_Miktar.Width = 50;
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(232, 270);
            this.tabPage1.Text = "Stok Böl";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemUst);
            this.mainMenu1.MenuItems.Add(this.menuItem4);
            this.mainMenu1.MenuItems.Add(this.menuItemKaydet);
            this.mainMenu1.MenuItems.Add(this.menuItem9);
            // 
            // menuItemUst
            // 
            this.menuItemUst.MenuItems.Add(this.menuItem2);
            this.menuItemUst.MenuItems.Add(this.menuItem3);
            this.menuItemUst.MenuItems.Add(this.menuItem8);
            this.menuItemUst.Text = "Üst";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Yeni";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click_1);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Kopyala";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click_1);
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "Ek Bilgiler";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.MenuItems.Add(this.menuItem5);
            this.menuItem4.MenuItems.Add(this.menuItem6);
            this.menuItem4.MenuItems.Add(this.menuItem7);
            this.menuItem4.MenuItems.Add(this.menuItem1);
            this.menuItem4.Text = "Detay";
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Ekle";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Sil";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "Tümünü Sil";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Bilgi";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click_1);
            // 
            // menuItemKaydet
            // 
            this.menuItemKaydet.Text = "Kaydet";
            this.menuItemKaydet.Click += new System.EventHandler(this.menuItemKaydet_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Text = "Çýkýþ";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.buttonTamam);
            this.panelUst.Controls.Add(this.textBoxHareketKodu);
            this.panelUst.Controls.Add(this.textBoxAciklama1);
            this.panelUst.Controls.Add(this.textBoxCikanDepo);
            this.panelUst.Controls.Add(this.textBoxBelgeNo);
            this.panelUst.Controls.Add(this.textBoxGirenDepo);
            this.panelUst.Controls.Add(this.button1);
            this.panelUst.Controls.Add(this.label4);
            this.panelUst.Controls.Add(this.label5);
            this.panelUst.Controls.Add(this.label6);
            this.panelUst.Controls.Add(this.buttonCikanDepoSec);
            this.panelUst.Controls.Add(this.buttonGirenDepoSec);
            this.panelUst.Controls.Add(this.buttonCikanDepoSil);
            this.panelUst.Controls.Add(this.buttonGirenDepoSil);
            this.panelUst.Controls.Add(this.label7);
            this.panelUst.Controls.Add(this.buttonAciklama1Sil);
            this.panelUst.Controls.Add(this.label8);
            this.panelUst.Controls.Add(this.textBoxAciklama2);
            this.panelUst.Controls.Add(this.buttonAciklama2Sil);
            this.panelUst.Controls.Add(this.textBoxCariAdi);
            this.panelUst.Controls.Add(this.buttonCariAdiSil);
            this.panelUst.Controls.Add(this.label9);
            this.panelUst.Controls.Add(this.buttonCariKoduSil);
            this.panelUst.Controls.Add(this.textBoxCariKodu);
            this.panelUst.Controls.Add(this.label10);
            this.panelUst.Controls.Add(this.buttonCariAdiSec);
            this.panelUst.Controls.Add(this.label11);
            this.panelUst.Controls.Add(this.buttonHareketKoduSec);
            this.panelUst.Controls.Add(this.buttonHareketKoduSil);
            this.panelUst.Controls.Add(this.label12);
            this.panelUst.Controls.Add(this.buttonOzelKodSil);
            this.panelUst.Controls.Add(this.textBoxOzelKod);
            this.panelUst.Controls.Add(this.label13);
            this.panelUst.Controls.Add(this.textBoxIrsaliyeNo);
            this.panelUst.Controls.Add(this.buttonIrsaliyeSec);
            this.panelUst.Controls.Add(this.buttonIrsaliyeSil);
            this.panelUst.Controls.Add(this.buttonCariKoduSec);
            this.panelUst.Controls.Add(this.buttonOzelKodSec);
            this.panelUst.Location = new System.Drawing.Point(264, 24);
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
            // textBoxCikanDepo
            // 
            this.textBoxCikanDepo.BackColor = System.Drawing.Color.Yellow;
            this.textBoxCikanDepo.Location = new System.Drawing.Point(64, 28);
            this.textBoxCikanDepo.Name = "textBoxCikanDepo";
            this.textBoxCikanDepo.Size = new System.Drawing.Size(101, 23);
            this.textBoxCikanDepo.TabIndex = 3;
            this.textBoxCikanDepo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelgeNo_KeyPress);
            // 
            // textBoxBelgeNo
            // 
            this.textBoxBelgeNo.BackColor = System.Drawing.Color.Salmon;
            this.textBoxBelgeNo.Location = new System.Drawing.Point(64, 8);
            this.textBoxBelgeNo.Name = "textBoxBelgeNo";
            this.textBoxBelgeNo.Size = new System.Drawing.Size(101, 23);
            this.textBoxBelgeNo.TabIndex = 4;
            this.textBoxBelgeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelgeNo_KeyPress);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.Text = "Çýkan Depo:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.Text = "Belge No:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.Text = "Giren Depo:";
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
            // buttonCikanDepoSil
            // 
            this.buttonCikanDepoSil.Location = new System.Drawing.Point(195, 28);
            this.buttonCikanDepoSil.Name = "buttonCikanDepoSil";
            this.buttonCikanDepoSil.Size = new System.Drawing.Size(24, 20);
            this.buttonCikanDepoSil.TabIndex = 12;
            this.buttonCikanDepoSil.Text = "X";
            this.buttonCikanDepoSil.Click += new System.EventHandler(this.buttonCikanDepoSil_Click);
            // 
            // buttonGirenDepoSil
            // 
            this.buttonGirenDepoSil.Location = new System.Drawing.Point(195, 48);
            this.buttonGirenDepoSil.Name = "buttonGirenDepoSil";
            this.buttonGirenDepoSil.Size = new System.Drawing.Size(24, 20);
            this.buttonGirenDepoSil.TabIndex = 13;
            this.buttonGirenDepoSil.Text = "X";
            this.buttonGirenDepoSil.Click += new System.EventHandler(this.buttonGirenDepoSil_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.Text = "Aciklama1";
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
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.Text = "Aciklama1";
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
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.Text = "Cari Adi";
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
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.Text = "Cari Kodu";
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
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.Text = "Hareket Kod";
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
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(8, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.Text = "Ozel Kod";
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
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.Text = "Irsaliye No";
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
            // 
            // buttonIrsaliyeSil
            // 
            this.buttonIrsaliyeSil.Location = new System.Drawing.Point(195, 165);
            this.buttonIrsaliyeSil.Name = "buttonIrsaliyeSil";
            this.buttonIrsaliyeSil.Size = new System.Drawing.Size(24, 20);
            this.buttonIrsaliyeSil.TabIndex = 35;
            this.buttonIrsaliyeSil.Text = "X";
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
            // SerisizTransfer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.ControlBox = false;
            this.Controls.Add(this.panelUst);
            this.Controls.Add(this.listView1);
            this.Menu = this.mainMenu1;
            this.Name = "SerisizTransfer";
            this.Text = "Serisiz Transfer Ekraný";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SerisizTransfer_Load);
            this.panelUst.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
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
			return;
		}
		private void Okunanlar()
		{
			en.sql = string.Format(@"SELECT StokKodu, StokAdi, Birim, SUM(Miktar) AS miktar,GirenDepo, CikanDepo
FROM         terminal_girisi
WHERE     (Islem = 'Serisiz Stok Transferi') AND (Kullanici = '{0}') AND  (FLAG = 'H') 
GROUP BY StokKodu, StokAdi, Birim, GirenDepo, CikanDepo",en.KullaniciID);
			en.dat.ListDoldur(ref listView1,en.sql);
		}

		private void buttonCik_Click(object sender, System.EventArgs e)
		{
			
		}

		private void buttonBelgeNoSec_Click(object sender, System.EventArgs e)
		{
			System.Data.IDataReader rd=null;

			Sec s=new Sec();
			s.sql="SELECT BelgeNo,CikanDepo,GirenDepo,KullaniciID,Tarih,Saat,Aciklama1,Aciklama2 FROM stok_hareket_ust";
			s.sql_where= " WHERE HareketTipi='Serisiz Stok Transferi'  ";
			s.sql_orderby=" ORDER BY Tarih DESC";
			s.tablename="stok_hareket_ust";
			s.en=en;
			s.ShowDialog();
			if(s.dr!=null)
			{
				textBoxBelgeNo.Text=s.dr["BelgeNo"].ToString();
				textBoxCikanDepo.Text=s.dr["CikanDepo"].ToString();
				textBoxGirenDepo.Text=s.dr["GirenDepo"].ToString();

				en.sql="SELECT Aciklama1,Aciklama2,IrsaliyeNo,IrsaliyeTarih,HareketKodu,CariKod FROM stok_hareket_ust WHERE stok_hareket_ust.BelgeNo='";
				en.sql+=textBoxBelgeNo.Text;
				en.sql+="'";

				rd=en.dat.TSelect(en.sql);
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
					////stek.m_picker1.Value=Convert.ToDateTime(tarih);

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
				
				en.sql="SELECT shd.BelgeNo,shd.StokKodu,stu.StokAdi,shd.Birim,shd.Miktar FROM stok_hareket_detay shd,stok_tanim_ust stu WHERE shd.StokKodu=stu.StokKodu AND shd.BelgeNo='";
				en.sql+=textBoxBelgeNo.Text;
				en.sql+="'";

				rd=en.dat.TSelect(en.sql);
				while(rd!=null && rd.Read())
				{
					ListViewItem li=new ListViewItem(rd.GetValue(rd.GetOrdinal("StokKodu")).ToString());
					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("StokAdi")).ToString());
					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("Birim")).ToString());
					li.SubItems.Add(rd.GetValue(rd.GetOrdinal("Miktar")).ToString());
					listView1.Items.Add(li);
				}
				if(rd!=null)
					rd.Close();
				menuItemKaydet.Enabled=false;
			}

			#region Stok Dönüþüm deposu ise

			/*en.sql="SELECT StokDonusumDeposu FROM depo_tanim WHERE DepoKodu='";
			en.sql+=en.SqlTemizle(textBoxCikanDepo.Text);
			en.sql+="'";

			if(en.dat.TSelectScalar(en.sql)=="E")
			{
				textBoxCikanDepo.BackColor=Color.Turquoise;
			}
			else
			{
				textBoxCikanDepo.BackColor=Color.White;
			}*/

			#endregion
		}

		private void buttonYeniBelgeNo_Click(object sender, System.EventArgs e)
		{
			
		}

		private void buttonCikanDepoSec_Click(object sender, System.EventArgs e)
		{
			textBoxCikanDepo.Text = "";
			DepoSecimOzel oz = new DepoSecimOzel();
			oz.en = en;
			oz.Iade = stek.iade;
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxCikanDepo.Text = oz.DepoKodu;
				en.sql = "SELECT Eksi FROM depo_tanim  WHERE (DepoKodu = N'";
				en.sql += textBoxCikanDepo.Text;
				en.sql += "') ";

				

				en.EksiStokOlmasin = (en.dat.TSelectScalar(en.sql) == "H");
			}
//			SecTree st=new SecTree();
//			st.en=en;
//			st.sql="SELECT UstDepoKodu,DepoKodu FROM depo_tanim";
//			st.ShowDialog();
//			if(st.selected!="")
//				textBoxCikanDepo.Text=st.selected;

			#region Stok Dönüþüm deposu ise

			/*en.sql="SELECT StokDonusumDeposu FROM depo_tanim WHERE DepoKodu='";
			en.sql+=en.SqlTemizle(textBoxCikanDepo.Text);
			en.sql+="'";

			if(en.dat.TSelectScalar(en.sql)=="E")
			{
				textBoxCikanDepo.BackColor=Color.Turquoise;
			}
			else
			{
				textBoxCikanDepo.BackColor=Color.White;
			}*/

			#endregion
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			textBoxCikanDepo.Text="";
			textBoxCikanDepo.BackColor=Color.White;
		}

		private void buttonGirenDepoSec_Click(object sender, System.EventArgs e)
		{
			textBoxGirenDepo.Text = "";
			DepoSecimOzel oz = new DepoSecimOzel();
			oz.en = en;
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxGirenDepo.Text = oz.DepoKodu;
			}
//			SecTree st=new SecTree();
//			st.en=en;
//			st.sql="SELECT UstDepoKodu,DepoKodu FROM depo_tanim";
//			st.ShowDialog();
//			if(st.selected!="")
//				textBoxGirenDepo.Text=st.selected;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			textBoxGirenDepo.Text="";
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			SerisizStokSec sc=new SerisizStokSec();
			sc.en=en;
			sc.mainlist=listView1;
			sc.ShowDialog();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count<1)
			{
				MessageBox.Show("Seçili Satýr Yok","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}
			if(MessageBox.Show(listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text + " Numaralý Stok Listeden Çýkarýlacak!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
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
			Ekran(Ekranlar.Ust);
			Okunanlar();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			SerisizStokSec sc=new SerisizStokSec();
			sc.en=en;
			sc.mainlist=listView1;
			sc.ShowDialog();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			if(textBoxCikanDepo.Text == "")
			{
				MessageBox.Show("EKSÝ STOK KONTROLÜ VAR ÇIKAN DEPO SEÇÝLMELÝDÝR!!","DÝKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxCikanDepo.Focus();
				return;
			}
			if(textBoxHareketKodu.Text.Equals(""))
			{
				MessageBox.Show("HAREKET KODU SEÇÝLMEDEN ÝÞLEME DEVAM EDÝLEMEZ!!","DÝKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				stek.ShowDialog();
				return;
			}

			SerisizStokSec sc=new SerisizStokSec();
			sc.en=en;
			sc.siparisIliski = false;
			sc.CikanDepo = en.SqlTemizle(textBoxCikanDepo.Text);
			sc.mainlist = listView1;
			sc.ShowDialog();
			Okunanlar();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count<1)
			{
				MessageBox.Show("Seçili Satýr Yok","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}
			if(MessageBox.Show(listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text + " Numaralý Stok Listeden Çýkarýlacak!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
				return;

			en.sql = string.Format(@"DELETE FROM  terminal_girisi WHERE     (Islem = 'Serisiz Stok Transferi') AND (Kullanici = '{0}') AND (FLAG = 'H') AND (StokKodu = '{1}')",en.KullaniciID,listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text);

			if(!en.dat.TInsert(en.sql))
			{
				MessageBox.Show("Gecici Kayitlar Temizlenirken Hata Olustu!!\n" + en.dat.STR_HataMesaji,"DIKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}
			
			listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Listedeki Tüm Barkodlar Silinecek!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
				return;

			en.sql = string.Format(@"DELETE FROM  terminal_girisi WHERE     (Islem = 'Serisiz Stok Transferi') AND (Kullanici = '{0}') AND (FLAG = 'H') ",en.KullaniciID);

			if(!en.dat.TInsert(en.sql))
			{
				MessageBox.Show("Gecici Kayitlar Temizlenirken Hata Olustu!!\n" + en.dat.STR_HataMesaji,"DIKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}
			
			listView1.Items.Clear();
		}

		private void menuItem2_Click_1(object sender, System.EventArgs e)
		{
			if(menuItemKaydet.Enabled==true && listView1.Items.Count>0)
			{
				if(MessageBox.Show("Yapýlan Ýþlem Kaydedilmemiþ\nKaydetmeden Ýstiyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)!=DialogResult.OK)
					return;
			}
			Temizle();
		}

		private void menuItem3_Click_1(object sender, System.EventArgs e)
		{
			if(textBoxBelgeNo.Text=="")
				return;
			textBoxBelgeNo.Text="";
			textBoxCikanDepo.Text="";
			textBoxGirenDepo.Text="";
			menuItemKaydet.Enabled=true;
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			if(menuItemKaydet.Enabled==true && listView1.Items.Count>0)
			{
				if(MessageBox.Show("Yapýlan iþlemler kaydedilmedi\nÇýkmak için onay veriniz","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)!=DialogResult.OK)
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
			yar.label1.Text="Toplam Kalem Sayýsý=" + listView1.Items.Count.ToString() + "\n";
			yar.ShowDialog();
		}

		private void menuItemKaydet_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Yapýlan Islemler Kaydedilecek!\nOnay Veriyor musunuz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
				return;

			if(textBoxHareketKodu.Text.Equals(""))
			{
				MessageBox.Show("Hareket Kodunu Secmelisiniz!!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				Ekran(Ekranlar.Ust);
				return;
			}

			if(textBoxGirenDepo.Text.Equals(""))
			{
				en.Hata("Giren Depo Bos Birakilamaz!");
				Ekran(Ekranlar.Ust);
				return;
			}

			if(textBoxHareketKodu.Text.Equals(""))
			{
				en.Hata("Hareket Kodu Bos Birakilamaz!");
				Ekran(Ekranlar.Ust);
				return;
			}

			if(textBoxCikanDepo.Text == textBoxGirenDepo.Text)
			{
				MessageBox.Show("Ayni Depoda Hareket Yapilamaz!!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				Ekran(Ekranlar.Ust);
				return;
			}

			AmbarPC.Fis f=new AmbarPC.Fis();
			f.en=en;
			f.IrsaliyeNo = en.SqlTemizle(textBoxIrsaliyeNo.Text);
			f.IrsaliyeTarih = DateTime.Now.ToString("yyyy-MM-dd");
			f.CariKod = en.SqlTemizle(textBoxCariKodu.Text);
			f.HareketTipi = "Serisiz Stok Transferi";
			f.HareketKodu = textBoxHareketKodu.Text;
			f.KullaniciID = en.KullaniciID;
			f.Tarih = DateTime.Now.ToString("yyyy-MM-dd");
			f.Saat = DateTime.Now.ToString("HH:mm:ss");
			f.Aciklama1 = en.SqlTemizle(textBoxAciklama1.Text);
			f.Aciklama2 = en.SqlTemizle(textBoxAciklama2.Text);
			f.GirenDepo = en.SqlTemizle(textBoxGirenDepo.Text);

			for(int i=0;i<listView1.Items.Count;i++)
			{
				if(listView1.Items[i].SubItems[3].Text=="")
					continue;
				try
				{
					if(Convert.ToDouble(listView1.Items[i].SubItems[3].Text,en.nfi)<=0)
					{
						MessageBox.Show("Negatif/Hatalý stok miktarý!\nStok miktarý pozitif olmalýdýr.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
						return;
					}
				}
				catch(Exception)
				{
					MessageBox.Show("Negatif/Hatalý stok miktarý!\nStok miktarý pozitif olmalýdýr.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
					return;
				}

				System.Data.DataRow row=f.detaylar.NewRow();
				row["StokKodu"]=listView1.Items[i].SubItems[0].Text;
				row["Birim"]=listView1.Items[i].SubItems[2].Text;
				row["Miktar"]=listView1.Items[i].SubItems[3].Text;
				row["SeriliBarkod"]="";
				row["GirenDepo"] = textBoxGirenDepo.Text;
				row["CikanDepo"] = listView1.Items[i].SubItems[5].Text;
                row["Durum"] = "*"; 
				f.detaylar.Rows.Add(row);
			}

			if(f.FisKaydet()==false)
			{
				MessageBox.Show("Fis Kaydedilemedi:" + f.HataMesaji,"BÝR HATA OLUÞTU",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}

			en.sql = 
				string.Format(@"UPDATE terminal_girisi SET GirenDepo = '{0}',BelgeNo = '{1}',FLAG = 'E' WHERE   (Islem = 'Serisiz Stok Transferi') AND (Kullanici = '{2}') AND (FLAG = 'H')",
				textBoxGirenDepo.Text,
				f.BelgeNo.ToString(),
				en.KullaniciID);

			if(!en.dat.TInsert(en.sql))
			{
				MessageBox.Show("Gecici Kayitlar Guncellenirken Hata Olustu Kayitlari Kontrol Edin","Dikkat!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
			}
			
            if(en.mesajlar)
			MessageBox.Show("Ýþlem Tamamlandý. " + f.BelgeNo.ToString() + " nolu Fis Kaydedildi","Ýþlem Sonucu",MessageBoxButtons.OK,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);

			Temizle();


		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			Ekran(Ekranlar.Ust);
		}

		private void buttonCikanDepoSil_Click(object sender, System.EventArgs e)
		{
			textBoxCikanDepo.Text = "";
		}

		private void buttonGirenDepoSil_Click(object sender, System.EventArgs e)
		{
			textBoxGirenDepo.Text = "";
		}

		private void buttonAciklama1Sil_Click_1(object sender, System.EventArgs e)
		{
			textBoxAciklama1.Text = "";
			textBoxAciklama1.Focus();
			return;
		}

		private void buttonAciklama2Sil_Click(object sender, System.EventArgs e)
		{
			textBoxAciklama1.Text = "";
			textBoxAciklama1.Focus();
			return;
		}

		private void buttonCariKoduSec_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
			s.sql="select CariKodu,CariAdi from cari_tanim (nolock) ";
			s.sql_orderby=" order by CariKodu ";
			s.tablename="cari_tanim";
			s.en=en;
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

		private void buttonTamam_Click(object sender, System.EventArgs e)
		{
			Ekran(Ekranlar.Detay);
		}

		private void buttonHareketKoduSec_Click(object sender, System.EventArgs e)
		{
			buttonGirenDepoSec.Enabled = true;
			buttonCikanDepoSec.Enabled = true;
			buttonCikanDepoSil.Enabled = true;
			buttonGirenDepoSil.Enabled = true;

			Sec s=new Sec();
			s.sql="select HareketKodu,HareketAdi,isnull(OzelKod,'') AS OzelKod,isnull(VarGirisDeposu,'') AS VarGirisDeposu,isnull(VarCikisDeposu,'') AS VarCikisDeposu from hareket_tanim (nolock) ";
			s.sql_orderby=" order by HareketKodu ";
			s.tablename="hareket_tanim";
			s.en=en;
			s.ShowDialog();
			if(s.dr!=null)
			{
				textBoxHareketKodu.Text=s.dr["HareketKodu"].ToString();
				textBoxOzelKod.Text = s.dr["OzelKod"].ToString();
				if(!s.dr["VarGirisDeposu"].ToString().Equals(""))
				{
					textBoxGirenDepo.Text = s.dr["VarGirisDeposu"].ToString();
					buttonGirenDepoSec.Enabled = false;
					buttonGirenDepoSil.Enabled = false;
				}
				else
				{
					textBoxGirenDepo.Text = "";
					buttonGirenDepoSec.Enabled = true;
					buttonGirenDepoSil.Enabled = true;
				}
				if(!s.dr["VarCikisDeposu"].ToString().Equals(""))
				{
					textBoxCikanDepo.Text = s.dr["VarCikisDeposu"].ToString();
					buttonCikanDepoSec.Enabled = false;
					buttonCikanDepoSil.Enabled = false;
				}
				else
				{
					textBoxCikanDepo.Text = "";
					buttonCikanDepoSec.Enabled = true;
					buttonCikanDepoSil.Enabled = true;
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

		private void textBoxBelgeNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			e.Handled = true;
		}
	}
}
