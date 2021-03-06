using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for DetayliSevk.
	/// </summary>
	public class DetayliSevk : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBoxBarkod;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelStokAdi;
		private System.Windows.Forms.TextBox textBoxMiktar;
		private System.Windows.Forms.Panel panelStokDetay;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label labelStokKodu;
		private System.Windows.Forms.Label labelBirim;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label labelSevkAdresi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Panel panelUstBilgi;
		private System.Windows.Forms.TextBox textBoxCikanDepo;
		private System.Windows.Forms.TextBox textBoxGirenDepo;
		private System.Windows.Forms.Label labelCari;
		private System.Windows.Forms.Label labelCariAdi;
		private System.Windows.Forms.TextBox textBoxAciklama1;
		private System.Windows.Forms.TextBox textBoxAciklama2;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBoxBelgeNo;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Panel panelBul;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label labelStokOneri;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Panel panelMiktar;
		private System.Windows.Forms.TextBox textBoxMiktar2;
		private System.Windows.Forms.Label labelDuzeltStok;
		private System.Windows.Forms.Label labelSatir;
		private System.Windows.Forms.CheckBox checkBoxAdet;
		private System.Windows.Forms.Label labelSMiktar;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label labelKalan;
		private System.Windows.Forms.CheckBox checkBoxSeri;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.TextBox textBoxHareket;
		private System.Windows.Forms.Label labelHareket;
		private System.Windows.Forms.Button buttonyildiz;
		public string AlisSatis = "Satis";
	
		public DetayliSevk()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		//public Engine Utility.Engine;
		public String SiparisNo = "",Cari = "",CariAdi,SevkAdresi="";//246; 296

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
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.labelSevkAdresi = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelStokDetay = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStokAdi = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelStokKodu = new System.Windows.Forms.Label();
            this.labelBirim = new System.Windows.Forms.Label();
            this.labelSMiktar = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelKalan = new System.Windows.Forms.Label();
            this.buttonyildiz = new System.Windows.Forms.Button();
            this.panelUstBilgi = new System.Windows.Forms.Panel();
            this.textBoxHareket = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCikanDepo = new System.Windows.Forms.TextBox();
            this.textBoxGirenDepo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCari = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelCariAdi = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxAciklama1 = new System.Windows.Forms.TextBox();
            this.textBoxAciklama2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxBelgeNo = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.labelHareket = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.panelBul = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.labelStokOneri = new System.Windows.Forms.Label();
            this.checkBoxAdet = new System.Windows.Forms.CheckBox();
            this.panelMiktar = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.labelDuzeltStok = new System.Windows.Forms.Label();
            this.textBoxMiktar2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSatir = new System.Windows.Forms.Label();
            this.checkBoxSeri = new System.Windows.Forms.CheckBox();
            this.panelStokDetay.SuspendLayout();
            this.panelUstBilgi.SuspendLayout();
            this.panelBul.SuspendLayout();
            this.panelMiktar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.Columns.Add(this.columnHeader4);
            this.listView1.Columns.Add(this.columnHeader5);
            this.listView1.Columns.Add(this.columnHeader6);
            this.listView1.Columns.Add(this.columnHeader7);
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 208);
            this.listView1.TabIndex = 8;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "StokKodu";
            this.columnHeader1.Width = 10;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "StokAdi";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Miktar";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ok";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kal";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Master";
            this.columnHeader6.Width = 10;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Detay";
            this.columnHeader7.Width = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "CIK (0)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.BackColor = System.Drawing.Color.Yellow;
            this.textBoxBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBoxBarkod.Location = new System.Drawing.Point(80, 0);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(112, 21);
            this.textBoxBarkod.TabIndex = 6;
            this.textBoxBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBarkod_KeyUp);
            // 
            // labelSevkAdresi
            // 
            this.labelSevkAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.labelSevkAdresi.ForeColor = System.Drawing.Color.Maroon;
            this.labelSevkAdresi.Location = new System.Drawing.Point(64, 72);
            this.labelSevkAdresi.Name = "labelSevkAdresi";
            this.labelSevkAdresi.Size = new System.Drawing.Size(176, 32);
            this.labelSevkAdresi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "T";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(216, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 22);
            this.button3.TabIndex = 9;
            this.button3.Text = ">>";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelStokDetay
            // 
            this.panelStokDetay.BackColor = System.Drawing.Color.Azure;
            this.panelStokDetay.Controls.Add(this.label3);
            this.panelStokDetay.Controls.Add(this.label4);
            this.panelStokDetay.Controls.Add(this.label5);
            this.panelStokDetay.Controls.Add(this.textBoxMiktar);
            this.panelStokDetay.Controls.Add(this.label6);
            this.panelStokDetay.Controls.Add(this.labelStokAdi);
            this.panelStokDetay.Controls.Add(this.button4);
            this.panelStokDetay.Controls.Add(this.button5);
            this.panelStokDetay.Controls.Add(this.labelStokKodu);
            this.panelStokDetay.Controls.Add(this.labelBirim);
            this.panelStokDetay.Controls.Add(this.labelSMiktar);
            this.panelStokDetay.Controls.Add(this.label18);
            this.panelStokDetay.Controls.Add(this.labelKalan);
            this.panelStokDetay.Controls.Add(this.buttonyildiz);
            this.panelStokDetay.Location = new System.Drawing.Point(784, 120);
            this.panelStokDetay.Name = "panelStokDetay";
            this.panelStokDetay.Size = new System.Drawing.Size(216, 208);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.Text = "Stok Kodu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.Text = "Stok Adi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(40, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.Text = "Birim";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.BackColor = System.Drawing.Color.Yellow;
            this.textBoxMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBoxMiktar.Location = new System.Drawing.Point(80, 112);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(104, 21);
            this.textBoxMiktar.TabIndex = 3;
            this.textBoxMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiktar_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(8, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.Text = "Miktar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelStokAdi
            // 
            this.labelStokAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.labelStokAdi.Location = new System.Drawing.Point(88, 32);
            this.labelStokAdi.Name = "labelStokAdi";
            this.labelStokAdi.Size = new System.Drawing.Size(120, 56);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "EKLE";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "IPTAL";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelStokKodu
            // 
            this.labelStokKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.labelStokKodu.ForeColor = System.Drawing.Color.DarkRed;
            this.labelStokKodu.Location = new System.Drawing.Point(88, 8);
            this.labelStokKodu.Name = "labelStokKodu";
            this.labelStokKodu.Size = new System.Drawing.Size(120, 20);
            // 
            // labelBirim
            // 
            this.labelBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.labelBirim.Location = new System.Drawing.Point(88, 88);
            this.labelBirim.Name = "labelBirim";
            this.labelBirim.Size = new System.Drawing.Size(112, 20);
            // 
            // labelSMiktar
            // 
            this.labelSMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.labelSMiktar.ForeColor = System.Drawing.Color.Red;
            this.labelSMiktar.Location = new System.Drawing.Point(64, 144);
            this.labelSMiktar.Name = "labelSMiktar";
            this.labelSMiktar.Size = new System.Drawing.Size(64, 16);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label18.Location = new System.Drawing.Point(8, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 20);
            this.label18.Text = "S.Miktar";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelKalan
            // 
            this.labelKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.labelKalan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelKalan.Location = new System.Drawing.Point(128, 144);
            this.labelKalan.Name = "labelKalan";
            this.labelKalan.Size = new System.Drawing.Size(80, 16);
            // 
            // buttonyildiz
            // 
            this.buttonyildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonyildiz.Location = new System.Drawing.Point(184, 112);
            this.buttonyildiz.Name = "buttonyildiz";
            this.buttonyildiz.Size = new System.Drawing.Size(16, 22);
            this.buttonyildiz.TabIndex = 13;
            this.buttonyildiz.Text = "*";
            this.buttonyildiz.Click += new System.EventHandler(this.buttonyildiz_Click);
            // 
            // panelUstBilgi
            // 
            this.panelUstBilgi.Controls.Add(this.textBoxHareket);
            this.panelUstBilgi.Controls.Add(this.label7);
            this.panelUstBilgi.Controls.Add(this.textBoxCikanDepo);
            this.panelUstBilgi.Controls.Add(this.textBoxGirenDepo);
            this.panelUstBilgi.Controls.Add(this.label8);
            this.panelUstBilgi.Controls.Add(this.button7);
            this.panelUstBilgi.Controls.Add(this.button8);
            this.panelUstBilgi.Controls.Add(this.button9);
            this.panelUstBilgi.Controls.Add(this.button10);
            this.panelUstBilgi.Controls.Add(this.labelSevkAdresi);
            this.panelUstBilgi.Controls.Add(this.label2);
            this.panelUstBilgi.Controls.Add(this.label9);
            this.panelUstBilgi.Controls.Add(this.labelCari);
            this.panelUstBilgi.Controls.Add(this.label11);
            this.panelUstBilgi.Controls.Add(this.labelCariAdi);
            this.panelUstBilgi.Controls.Add(this.label14);
            this.panelUstBilgi.Controls.Add(this.textBoxAciklama1);
            this.panelUstBilgi.Controls.Add(this.textBoxAciklama2);
            this.panelUstBilgi.Controls.Add(this.label13);
            this.panelUstBilgi.Controls.Add(this.button11);
            this.panelUstBilgi.Controls.Add(this.button12);
            this.panelUstBilgi.Controls.Add(this.button13);
            this.panelUstBilgi.Controls.Add(this.button14);
            this.panelUstBilgi.Controls.Add(this.button15);
            this.panelUstBilgi.Controls.Add(this.label15);
            this.panelUstBilgi.Controls.Add(this.textBoxBelgeNo);
            this.panelUstBilgi.Controls.Add(this.button16);
            this.panelUstBilgi.Controls.Add(this.button17);
            this.panelUstBilgi.Controls.Add(this.label10);
            this.panelUstBilgi.Controls.Add(this.button22);
            this.panelUstBilgi.Controls.Add(this.button24);
            this.panelUstBilgi.Controls.Add(this.labelHareket);
            this.panelUstBilgi.Location = new System.Drawing.Point(528, 8);
            this.panelUstBilgi.Name = "panelUstBilgi";
            this.panelUstBilgi.Size = new System.Drawing.Size(240, 272);
            // 
            // textBoxHareket
            // 
            this.textBoxHareket.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxHareket.Location = new System.Drawing.Point(64, 208);
            this.textBoxHareket.Name = "textBoxHareket";
            this.textBoxHareket.ReadOnly = true;
            this.textBoxHareket.Size = new System.Drawing.Size(144, 23);
            this.textBoxHareket.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(8, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.Text = "ÇikanDepo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCikanDepo
            // 
            this.textBoxCikanDepo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBoxCikanDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBoxCikanDepo.Location = new System.Drawing.Point(88, 24);
            this.textBoxCikanDepo.Name = "textBoxCikanDepo";
            this.textBoxCikanDepo.Size = new System.Drawing.Size(120, 21);
            this.textBoxCikanDepo.TabIndex = 2;
            this.textBoxCikanDepo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCikanDepo_KeyPress);
            // 
            // textBoxGirenDepo
            // 
            this.textBoxGirenDepo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBoxGirenDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBoxGirenDepo.Location = new System.Drawing.Point(88, 48);
            this.textBoxGirenDepo.Name = "textBoxGirenDepo";
            this.textBoxGirenDepo.Size = new System.Drawing.Size(120, 21);
            this.textBoxGirenDepo.TabIndex = 3;
            this.textBoxGirenDepo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCikanDepo_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label8.Location = new System.Drawing.Point(8, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.Text = "GirenDepo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(208, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(16, 22);
            this.button7.TabIndex = 5;
            this.button7.Text = ":";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(224, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(16, 22);
            this.button8.TabIndex = 6;
            this.button8.Text = "X";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(224, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(16, 22);
            this.button9.TabIndex = 7;
            this.button9.Text = "X";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(208, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(16, 22);
            this.button10.TabIndex = 8;
            this.button10.Text = ":";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.Text = "Sevk";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(8, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.Text = "Cari";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCari
            // 
            this.labelCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.labelCari.ForeColor = System.Drawing.Color.Maroon;
            this.labelCari.Location = new System.Drawing.Point(64, 104);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(176, 24);
            this.labelCari.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label11.Location = new System.Drawing.Point(8, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.Text = "CariAdi";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCariAdi
            // 
            this.labelCariAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.labelCariAdi.ForeColor = System.Drawing.Color.Maroon;
            this.labelCariAdi.Location = new System.Drawing.Point(64, 128);
            this.labelCariAdi.Name = "labelCariAdi";
            this.labelCariAdi.Size = new System.Drawing.Size(176, 32);
            this.labelCariAdi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label14.Location = new System.Drawing.Point(8, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.Text = "Aciklama";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxAciklama1
            // 
            this.textBoxAciklama1.BackColor = System.Drawing.Color.White;
            this.textBoxAciklama1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBoxAciklama1.Location = new System.Drawing.Point(64, 160);
            this.textBoxAciklama1.Name = "textBoxAciklama1";
            this.textBoxAciklama1.Size = new System.Drawing.Size(144, 21);
            this.textBoxAciklama1.TabIndex = 16;
            // 
            // textBoxAciklama2
            // 
            this.textBoxAciklama2.BackColor = System.Drawing.Color.White;
            this.textBoxAciklama2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBoxAciklama2.Location = new System.Drawing.Point(64, 184);
            this.textBoxAciklama2.Name = "textBoxAciklama2";
            this.textBoxAciklama2.Size = new System.Drawing.Size(144, 21);
            this.textBoxAciklama2.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label13.Location = new System.Drawing.Point(8, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.Text = "Aciklama";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(208, 160);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(16, 22);
            this.button11.TabIndex = 19;
            this.button11.Text = "T";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button12.Location = new System.Drawing.Point(224, 160);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(16, 22);
            this.button12.TabIndex = 20;
            this.button12.Text = "X";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(208, 184);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(16, 22);
            this.button13.TabIndex = 21;
            this.button13.Text = "T";
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button14.Location = new System.Drawing.Point(224, 184);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(16, 22);
            this.button14.TabIndex = 22;
            this.button14.Text = "X";
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button15.Location = new System.Drawing.Point(200, 232);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 24);
            this.button15.TabIndex = 23;
            this.button15.Text = ">>";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label15.Location = new System.Drawing.Point(8, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.Text = "BelgeNo";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxBelgeNo
            // 
            this.textBoxBelgeNo.BackColor = System.Drawing.Color.Orange;
            this.textBoxBelgeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBoxBelgeNo.Location = new System.Drawing.Point(88, 0);
            this.textBoxBelgeNo.Name = "textBoxBelgeNo";
            this.textBoxBelgeNo.Size = new System.Drawing.Size(120, 21);
            this.textBoxBelgeNo.TabIndex = 25;
            this.textBoxBelgeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelgeNo_KeyPress);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button16.Location = new System.Drawing.Point(224, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(16, 22);
            this.button16.TabIndex = 26;
            this.button16.Text = "X";
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(208, 0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(16, 22);
            this.button17.TabIndex = 27;
            this.button17.Text = ":";
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label10.Location = new System.Drawing.Point(0, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.Text = "Hareket";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button22.Location = new System.Drawing.Point(224, 207);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(16, 22);
            this.button22.TabIndex = 29;
            this.button22.Text = "X";
            this.button22.Click += new System.EventHandler(this.button22_Click_1);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(208, 207);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(16, 22);
            this.button24.TabIndex = 30;
            this.button24.Text = ":";
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // labelHareket
            // 
            this.labelHareket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.labelHareket.Location = new System.Drawing.Point(8, 232);
            this.labelHareket.Name = "labelHareket";
            this.labelHareket.Size = new System.Drawing.Size(192, 20);
            this.labelHareket.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 22);
            this.button6.TabIndex = 10;
            this.button6.Text = "<";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(144, 232);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(48, 32);
            this.button18.TabIndex = 11;
            this.button18.Text = "KAYDT";
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(88, 232);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(56, 32);
            this.button19.TabIndex = 12;
            this.button19.Text = "DET";
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(48, 232);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 32);
            this.button20.TabIndex = 13;
            this.button20.Text = "BUL";
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // panelBul
            // 
            this.panelBul.Controls.Add(this.button21);
            this.panelBul.Controls.Add(this.dataGrid1);
            this.panelBul.Controls.Add(this.labelStokOneri);
            this.panelBul.Controls.Add(this.checkBoxAdet);
            this.panelBul.Location = new System.Drawing.Point(264, 8);
            this.panelBul.Name = "panelBul";
            this.panelBul.Size = new System.Drawing.Size(240, 272);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(176, 240);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(64, 32);
            this.button21.TabIndex = 0;
            this.button21.Text = "TAMAM";
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(0, 8);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(240, 216);
            this.dataGrid1.TabIndex = 1;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.MappingName = "bul";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Depo Kodu";
            this.dataGridTextBoxColumn1.MappingName = "DepoKodu";
            this.dataGridTextBoxColumn1.NullText = "";
            this.dataGridTextBoxColumn1.Width = 120;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Birim";
            this.dataGridTextBoxColumn2.MappingName = "Birim";
            this.dataGridTextBoxColumn2.NullText = "";
            this.dataGridTextBoxColumn2.Width = 30;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Miktar";
            this.dataGridTextBoxColumn3.MappingName = "Miktar";
            this.dataGridTextBoxColumn3.NullText = "";
            this.dataGridTextBoxColumn3.Width = 100;
            // 
            // labelStokOneri
            // 
            this.labelStokOneri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.labelStokOneri.Location = new System.Drawing.Point(0, 224);
            this.labelStokOneri.Name = "labelStokOneri";
            this.labelStokOneri.Size = new System.Drawing.Size(176, 48);
            this.labelStokOneri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxAdet
            // 
            this.checkBoxAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.checkBoxAdet.Location = new System.Drawing.Point(176, 224);
            this.checkBoxAdet.Name = "checkBoxAdet";
            this.checkBoxAdet.Size = new System.Drawing.Size(64, 20);
            this.checkBoxAdet.TabIndex = 3;
            this.checkBoxAdet.Text = "Adet";
            // 
            // panelMiktar
            // 
            this.panelMiktar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelMiktar.Controls.Add(this.textBox1);
            this.panelMiktar.Controls.Add(this.listView2);
            this.panelMiktar.Controls.Add(this.labelDuzeltStok);
            this.panelMiktar.Controls.Add(this.textBoxMiktar2);
            this.panelMiktar.Controls.Add(this.label16);
            this.panelMiktar.Controls.Add(this.button23);
            this.panelMiktar.Controls.Add(this.label1);
            this.panelMiktar.Location = new System.Drawing.Point(304, 312);
            this.panelMiktar.Name = "panelMiktar";
            this.panelMiktar.Size = new System.Drawing.Size(240, 264);
            this.panelMiktar.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBox1.Location = new System.Drawing.Point(64, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // listView2
            // 
            this.listView2.Columns.Add(this.columnHeader8);
            this.listView2.Columns.Add(this.columnHeader9);
            this.listView2.Columns.Add(this.columnHeader10);
            this.listView2.Columns.Add(this.columnHeader11);
            this.listView2.Columns.Add(this.columnHeader12);
            this.listView2.FullRowSelect = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.Location = new System.Drawing.Point(0, 8);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(240, 224);
            this.listView2.TabIndex = 1;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SeriliBarkod";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "StokAdi";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "StokKodu";
            this.columnHeader10.Width = 60;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Birim";
            this.columnHeader11.Width = 60;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Miktar";
            this.columnHeader12.Width = 60;
            // 
            // labelDuzeltStok
            // 
            this.labelDuzeltStok.Location = new System.Drawing.Point(248, 168);
            this.labelDuzeltStok.Name = "labelDuzeltStok";
            this.labelDuzeltStok.Size = new System.Drawing.Size(100, 20);
            this.labelDuzeltStok.Visible = false;
            this.labelDuzeltStok.ParentChanged += new System.EventHandler(this.labelDuzeltStok_ParentChanged);
            // 
            // textBoxMiktar2
            // 
            this.textBoxMiktar2.BackColor = System.Drawing.Color.Yellow;
            this.textBoxMiktar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBoxMiktar2.Location = new System.Drawing.Point(256, 192);
            this.textBoxMiktar2.Name = "textBoxMiktar2";
            this.textBoxMiktar2.Size = new System.Drawing.Size(120, 21);
            this.textBoxMiktar2.TabIndex = 3;
            this.textBoxMiktar2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMiktar2_KeyUp);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label16.Location = new System.Drawing.Point(232, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.Text = "Miktar";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label16.Visible = false;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(184, 232);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(56, 24);
            this.button23.TabIndex = 5;
            this.button23.Text = "TAMAM";
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(8, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.Text = "Seri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSatir
            // 
            this.labelSatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.labelSatir.Location = new System.Drawing.Point(0, 240);
            this.labelSatir.Name = "labelSatir";
            this.labelSatir.Size = new System.Drawing.Size(48, 20);
            this.labelSatir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxSeri
            // 
            this.checkBoxSeri.Checked = true;
            this.checkBoxSeri.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSeri.Enabled = false;
            this.checkBoxSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.checkBoxSeri.Location = new System.Drawing.Point(24, 0);
            this.checkBoxSeri.Name = "checkBoxSeri";
            this.checkBoxSeri.Size = new System.Drawing.Size(56, 20);
            this.checkBoxSeri.TabIndex = 1;
            this.checkBoxSeri.Text = "Seri";
            this.checkBoxSeri.CheckStateChanged += new System.EventHandler(this.checkBoxSeri_CheckStateChanged);
            // 
            // DetayliSevk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.panelMiktar);
            this.Controls.Add(this.checkBoxSeri);
            this.Controls.Add(this.panelBul);
            this.Controls.Add(this.panelUstBilgi);
            this.Controls.Add(this.panelStokDetay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxBarkod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.labelSatir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetayliSevk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DetayliSevk_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DetayliSevk_KeyUp);
            this.panelStokDetay.ResumeLayout(false);
            this.panelUstBilgi.ResumeLayout(false);
            this.panelBul.ResumeLayout(false);
            this.panelMiktar.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void EtiketSeri()
		{
			try
			{
				if(textBoxBarkod.Text.Length < 7)
				{
					textBoxBarkod.Text = "";
					textBoxBarkod.Focus();
					return;
				}

				Utility.Engine.sql = string.Format("exec dbo.SeriBulSevk '{0}','{1}',{2}",
					Utility.Engine.SqlTemizle(textBoxBarkod.Text).ToUpper(),this.SiparisNo,
					Utility.Engine.SqlTemizle(textBoxBelgeNo.Text).ToUpper());

				System.Data.IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);

				string serilibarkod = "", stokkodu = "", paletid = "",mktr = "";

				if (dr != null && dr.Read())
				{
					if (dr["StokKodu"] != DBNull.Value)
					{
						stokkodu = dr["StokKodu"].ToString();
					}
					if (dr["SeriliBarkod"] != DBNull.Value)
					{
						serilibarkod = dr["SeriliBarkod"].ToString();
					}
					if (dr["Miktar"] != DBNull.Value)
					{
						mktr = dr["Miktar"].ToString();
					}
					if (dr["Palet"] != DBNull.Value)
					{
						paletid = dr["Palet"].ToString();
					}
					if (dr != null) dr.Close();
				}

				if (dr != null) dr.Close();

				if(stokkodu.Equals("hata"))
				{
					Utility.Engine.Hata(serilibarkod);
					textBoxBarkod.Focus();
					textBoxBarkod.SelectAll();
					return;
				}
				else
				{
					for(int i = 0;i<listView1.Items.Count;i++)
					{
						if(listView1.Items[i].SubItems[0].Text.Equals(stokkodu))
						{
							int okunan = 0,kalan = 0,mktar = 0;
							mktar = Convert.ToInt32(mktr.Trim());
							okunan = Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
							kalan = Convert.ToInt32(listView1.Items[i].SubItems[4].Text);
							listView1.Items[i].SubItems[3].Text = Convert.ToString(okunan + mktar);
							listView1.Items[i].SubItems[4].Text = Convert.ToString(kalan - mktar);
							//Utility.Engine.WinApi.TPlaySound(Utility.Engine.STR_ProgramDizini + "\\islem.wav");
							break;
						}
					}
				}

				textBoxBarkod.Text = "";
				textBoxBarkod.Focus();
				return;
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Seri Sorgulanirken Genel Hata:" + exc.Message);
				textBoxBarkod.Text = "";
				textBoxBarkod.Focus();
				return;
			}
		}
		private void PaletBarkod()
		{
			try
			{
				if(checkBoxSeri.Checked && textBoxBarkod.Text.Length < 7)
				{
					textBoxBarkod.Text = "";
					textBoxBarkod.Focus();
					return;
				}

				Utility.Engine.sql = string.Format("EXEC dbo.PaletSevk '{0}',{1},{2} ",
					this.SiparisNo,Utility.Engine.SqlTemizle(textBoxBarkod.Text),
					Utility.Engine.SqlTemizle(textBoxBelgeNo.Text));

				string son = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);

				if(!son.StartsWith("ok"))
				{
					Utility.Engine.Hata("Sunucu Hata Bildirdi:" + son);
					textBoxBarkod.Focus();
					textBoxBarkod.SelectAll();
					return;
				}
				else
				{
					//Utility.Engine.WinApi.TPlaySound(Utility.Engine.STR_ProgramDizini + "\\islem.wav");
					SiparisDetay();
					textBoxBarkod.Text = "";
					textBoxBarkod.Focus();
					return;
				}
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Palet Sorgulanamadi:" + exc.Message);
				textBoxBarkod.Text = "";
				textBoxBarkod.Focus();
				return;
			}
		}
		private void Duzelt()
		{
			if(labelDuzeltStok.Text != "")
			{
				Cursor.Current = Cursors.WaitCursor;

				double mikt = 0;
				try
				{
					mikt = Convert.ToDouble(textBoxMiktar2.Text);
				}
				catch(Exception ex)
				{
					Cursor.Current = Cursors.Default;
					textBoxMiktar2.SelectAll();
					textBoxMiktar2.Focus();
					return;
				}

				foreach(ListViewItem itim in listView1.Items)
				{
					if(itim.SubItems[0].Text == labelDuzeltStok.Text)
					{
						double istenen = Convert.ToDouble(itim.SubItems[2].Text.Trim());
						if(mikt > istenen)
						{
							Cursor.Current = Cursors.Default;
							MessageBox.Show("SiPARiş MiKTARI AşILDI <FAZLA SEVK>","HATA!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
							textBoxMiktar2.SelectAll();
							textBoxMiktar2.Focus();
							return;
						}

						if(!DepoStokKontrol(mikt,labelDuzeltStok.Text))
						{
							Cursor.Current = Cursors.Default;
							MessageBox.Show("DEPO STOK MiKTARI AşILDI <EKSi STOK>","HATA!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
							textBoxMiktar2.SelectAll();
							textBoxMiktar2.Focus();
							return;
						}

						itim.SubItems[3].Text = mikt.ToString();
						itim.SubItems[4].Text = Convert.ToString(istenen - mikt);
						break;
					}
				}

				if(mikt > 0)
				{
					Utility.Engine.sql = "UPDATE stok_hareket_detay SET Miktar = ";
					Utility.Engine.sql += textBoxMiktar2.Text;
					Utility.Engine.sql += " WHERE BelgeNo = ";
					Utility.Engine.sql += textBoxBelgeNo.Text;
					Utility.Engine.sql += " AND StokKodu = '";
					Utility.Engine.sql += labelDuzeltStok.Text;
					Utility.Engine.sql += "'";
					Utility.Engine.dat.TInsert(Utility.Engine.sql);
					MiktarDuzelt(false);
				}
				else
				{
					Utility.Engine.sql = "DELETE FROM stok_hareket_detay SET Miktar = ";
					Utility.Engine.sql += " WHERE BelgeNo = ";
					Utility.Engine.sql += textBoxBelgeNo.Text;
					Utility.Engine.sql += " AND StokKodu = '";
					Utility.Engine.sql += labelDuzeltStok.Text;
					Utility.Engine.sql += "'";
					Utility.Engine.dat.TInsert(Utility.Engine.sql);
					MiktarDuzelt(false);
				}
				Cursor.Current = Cursors.Default;
			}
		}

		private void MiktarDuzelt(bool gor)
		{
			if(gor)
			{
				Utility.Engine.sql = string.Format(@"SELECT     stok_hareket_detay.SeriliBarkod, stok_tanim_ust.StokAdi, stok_hareket_detay.StokKodu, stok_hareket_detay.Birim, stok_hareket_detay.Miktar
FROM         stok_hareket_ust WITH (NOLOCK) INNER JOIN
                      stok_hareket_detay WITH (NOLOCK) ON stok_hareket_ust.BelgeNo = stok_hareket_detay.BelgeNo INNER JOIN
                      stok_tanim_ust WITH (NOLOCK) ON stok_hareket_detay.StokKodu = stok_tanim_ust.StokKodu
WHERE     (stok_hareket_ust.IrsaliyeNo = N'{0}')
ORDER BY stok_hareket_detay.SeriliBarkod, stok_tanim_ust.StokAdi ", this.SiparisNo);

				try{Utility.Engine.dat.ListDoldur(ref listView2,Utility.Engine.sql);}
				catch{}
				this.Text = "Detaylar " + listView2.Items.Count.ToString();
			}
			else 
			{
				listView2.Items.Clear();
				this.Text = this.SiparisNo;
			}
			panelMiktar.Location = new Point(0, 0);
			panelMiktar.BringToFront();
			panelMiktar.Visible = gor;
		}
		private void DepoStokOneri(bool gor)
		{
			panelBul.Location = new Point(0,0);
			panelBul.BringToFront();
			panelBul.Visible = gor;
			if(gor && labelStokOneri.Text != "")
			{
				Cursor.Current = Cursors.WaitCursor;
				DataTable dat = new DataTable("bul");
				Utility.Engine.sql = @"SELECT DepoKodu, Birim, SUM(Miktar) AS Miktar FROM  depo_mevcut (NOLOCK) WHERE (DepoKodu NOT IN
                          (SELECT  AD FROM  haric_depo (NOLOCK))) AND (Miktar > 0) AND (StokKodu = N'";
				Utility.Engine.sql += listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
				Utility.Engine.sql += "')  GROUP BY DepoKodu, Birim, StokKodu ";

				if(checkBoxAdet.Checked)
					Utility.Engine.sql += " ORDER BY Miktar DESC ASC, DepoKodu ";
				else Utility.Engine.sql += " ORDER BY  Miktar DESC, DepoKodu ";


				Utility.Engine.dat.TableDoldur(Utility.Engine.sql,ref dat);
				dataGrid1.DataSource = dat;
				Cursor.Current = Cursors.Default;
			}else dataGrid1.DataSource = null;
		}
		private void UstBilgiGoster(bool gor)
		{
			panelUstBilgi.Location = new Point(0, 0);
			panelUstBilgi.Size = new Size(240, 270);
			panelUstBilgi.BringToFront();
			panelUstBilgi.Visible = gor;
		}

		private bool OkumaVarmi()
		{
			try
			{
				if(this.listView1.Items.Count < 1)return false;
				
				bool var = false;

				foreach(ListViewItem item in this.listView1.Items)
				{
					if(Convert.ToDouble(item.SubItems[3].Text.Trim()) > 0)
					{
						var = true;
						break;
					}
				}
				return var;
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("<Okuma> Genel Hata Olustu:" + exc.Message);return false;
			}
		}
		private void SiparisDetay()
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				Utility.Engine.sql = string.Format("EXEC dbo.BelgeNoAll N'{0}',N'{1}',N'{2}',N'{3}'",this.SiparisNo.Trim(),this.Cari.ToUpper(),Utility.Engine.KullaniciKod,Utility.Engine.CihazID);

				DataTable dat = new DataTable();
				Utility.Engine.dat.TableDoldur(Utility.Engine.sql,ref dat);

				if(dat != null && dat.Rows.Count > 0)
				{
					textBoxBelgeNo.Text = dat.Rows[0][0].ToString();
					textBoxAciklama1.Text = dat.Rows[0][1].ToString();
					textBoxAciklama2.Text = dat.Rows[0][2].ToString();
				}

                Utility.Engine.sql = " select StokKodu,StokAdi,SiparisMiktari-SevkMiktari as Istenen,dbo.Okunan(MasterNo,DetayNo) as Okunan,(SiparisMiktari-SevkMiktari) - dbo.Okunan(MasterNo,DetayNo) as Kalan,MasterNo,DetayNo from siparisler (NOLOCK)";
				Utility.Engine.sql += " where SiparisNo = '";
				Utility.Engine.sql += this.SiparisNo;
				Utility.Engine.sql += "' order by StokAdi ";
				Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
				Cursor.Current = Cursors.Default;
			}
			catch(Exception exc)
			{
				Cursor.Current = Cursors.Default;
				Utility.Engine.Hata("Siparis Detaylari Cekilemedi:" + exc.Message);
				return;
			}
		}
		private void DetayliSevk_Load(object sender, System.EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			
			try
			{
				panelStokDetay.Visible = false;
				this.Text = this.SiparisNo;
				this.labelCari.Text = this.Cari;
				this.labelCariAdi.Text = this.CariAdi;
				this.labelSevkAdresi.Text = this.SevkAdresi;

				SiparisDetay();

			}
			catch(Exception ex)
			{
				MessageBox.Show("SUNUCUDAN BiLGiLER YÜKLENiRKEN HATA:" + ex.Message,"DiKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
			}

			labelSatir.Text = listView1.Items.Count.ToString();
			Cursor.Current = Cursors.Default;
			UstBilgiGoster(true);
			textBoxBarkod.Focus();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBoxBarkod.Text;
			if(t.ShowDialog() == DialogResult.OK)
			{
				textBoxBarkod.Text = t.textBox1.Text;
			}
		}

		private void StokDetay()
		{
			string barkod = textBoxBarkod.Text.Trim().ToUpper();
			if(barkod == "" || barkod.Length < 12)
			{
				textBoxBarkod.Text = "";
				textBoxBarkod.Focus();
				return;
			}
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				Utility.Engine.sql = @" SELECT     stok_tanim_ust.StokKodu, stok_tanim_ust.StokAdi, stok_barkod.Birim, stok_barkod.Oran
FROM         stok_tanim_ust WITH (NOLOCK) INNER JOIN
                      stok_barkod WITH (NOLOCK) ON stok_tanim_ust.StokKodu = stok_barkod.StokKodu ";
				Utility.Engine.sql += string.Format(" WHERE     (stok_barkod.Barkod = N'{0}') ",barkod);

				IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);

				if(dr != null && dr.Read())
				{
					labelStokKodu.Text = dr.GetValue(0).ToString();
					labelStokAdi.Text = dr.GetValue(1).ToString();
					labelBirim.Text = dr.GetValue(2).ToString();
					textBoxMiktar.Text = dr.GetValue(3).ToString();
				}
				else
				{
					if(dr != null)dr.Close();
					textBoxBarkod.Text = "";
					textBoxBarkod.Focus();
					return;
				}

				if(dr != null)dr.Close();

				panelStokDetay.Location = new Point(16, 24);
				panelStokDetay.BringToFront();
				panelStokDetay.Visible = true;
				textBoxBarkod.Text = "";
				textBoxMiktar.SelectAll();
				textBoxMiktar.Focus();
				Cursor.Current = Cursors.Default;
				return;
			
			}
			catch(Exception ex)
			{
				MessageBox.Show("GENEL HATA :" + ex.Message);
				Cursor.Current = Cursors.Default;
				Kapat();
			}
		}

		private bool DepoStokKontrol(double miktar,string stokkod)
		{
			if(Utility.Engine.EksiStokOlmasin)
			{
                Utility.Engine.sql = "SELECT SUM(Miktar) as Miktar FROM depo_mevcut (NOLOCK) WHERE DepoKodu = '";
				Utility.Engine.sql += textBoxCikanDepo.Text;
				Utility.Engine.sql += "' AND StokKodu = '";
				Utility.Engine.sql += stokkod;
                Utility.Engine.sql += "' AND DepoKodu not in (select AD from haric_depo (NOLOCK)) AND Miktar > 0 AND SeriliBarkod = '' ";

				double mky = Convert.ToDouble((double)Utility.Engine.dat.TCount(Utility.Engine.sql));

				if (mky < miktar)
				{
					return false;
				}
				return true;
			}
			else return true;
		}
		private void UrunEkle()
		{
			if(listView1.Items.Count < 1 || labelStokKodu.Text == "" || textBoxMiktar.Text == "")
			{
				MessageBox.Show("BiLGiLER EKSiK işLEM YAPILAMAZ <KONTROL EDiN>!","DiKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				Kapat();return;
			}
			if( textBoxCikanDepo.Text == "")
			{
				MessageBox.Show("EKSi STOK KONTROLÜ VAR ÇIKAN DEPO SEÇiLMEDEN işLEM YAPILAMAZ <ÇIKAN DEPO>!","DiKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				Kapat();return;
			}

			Cursor.Current = Cursors.WaitCursor;

			bool listedevar = false;
			double sip_mitar = 0;
			double okunan = 0;
			double kalan = 0;
			double mik = 0;

			try
			{
				int endex = textBoxMiktar.Text.IndexOf("*");

				if (endex >= 0)
				{
					double koli = 0, koliadet = 0;
					koli = Convert.ToDouble(textBoxMiktar.Text.Substring(0, endex));
					koliadet = Convert.ToDouble(textBoxMiktar.Text.Substring(endex + 1, textBoxMiktar.Text.Length - (endex + 1)));
					mik = koli * koliadet;
				}
				else
				{ 
					mik = Convert.ToDouble(textBoxMiktar.Text);
				}
			}
			catch(Exception ee)
			{
				MessageBox.Show("MiKTARDA FORMAT HATASI <KONTROL EDiN>!","DiKKAT!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				textBoxMiktar.SelectAll();
				textBoxMiktar.Focus();
				Cursor.Current = Cursors.Default;
				return;
			}

			try
			{
				foreach(ListViewItem itim in listView1.Items)
				{
					if(itim.SubItems[0].Text == labelStokKodu.Text)
					{
						listedevar = true;
						sip_mitar = Convert.ToDouble(itim.SubItems[2].Text.Trim());
						okunan = Convert.ToDouble(itim.SubItems[3].Text.Trim());
						kalan = Convert.ToDouble(itim.SubItems[4].Text.Trim());
						//MessageBox.Show(string.Format("okunan:{0},mik:{1},smiktar:{2}",okunan.ToString(),mik.ToString(),sip_mitar.ToString()));

						if(okunan + mik > sip_mitar)
						{
							MessageBox.Show("SiPARiş MiKTARI AşILDI SEVK EDiLEMEZ<FAZLA SEVK>!","HATA!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
							textBoxMiktar.SelectAll();
							textBoxMiktar.Focus();
							Cursor.Current = Cursors.Default;
							return;
						}
						else
						{
							#region depo stok
							if(!DepoStokKontrol(mik,labelStokKodu.Text))
							{
								MessageBox.Show("DEPO STOK MiKTARI AşILDI SEVK EDiLEMEZ<EKSi STOK>!","HATA!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
								textBoxMiktar.SelectAll();
								textBoxMiktar.Focus();
								Cursor.Current = Cursors.Default;
								return;
							}
							#endregion

							#region hareket_detay

                            Utility.Engine.sql = "IF EXISTS (SELECT * FROM stok_hareket_detay (NOLOCK) WHERE BelgeNo = ";
							Utility.Engine.sql += textBoxBelgeNo.Text + " AND StokKodu = '";
							Utility.Engine.sql += labelStokKodu.Text + "' AND Birim = '";
							Utility.Engine.sql += labelBirim.Text + "' AND SeriliBarkod = '' ) ";
							Utility.Engine.sql += " BEGIN UPDATE stok_hareket_detay SET Miktar = Miktar + ";
							Utility.Engine.sql += mik.ToString() + " WHERE BelgeNo = ";
							Utility.Engine.sql += textBoxBelgeNo.Text + " AND StokKodu = '";
							Utility.Engine.sql += labelStokKodu.Text + "' AND Birim = '";
							Utility.Engine.sql += labelBirim.Text + "' AND SeriliBarkod = ''  END ELSE BEGIN ";

							Utility.Engine.sql += "INSERT INTO stok_hareket_detay(BelgeNo,StokKodu,Birim,Miktar,SeriliBarkod,GirenDepo,CikanDepo,MasterNo,DetayNo) VALUES('";
							Utility.Engine.sql += textBoxBelgeNo.Text + "','";
							Utility.Engine.sql += labelStokKodu.Text + "','";
							Utility.Engine.sql += labelBirim.Text + "','";
							Utility.Engine.sql += mik.ToString() + "','";
							Utility.Engine.sql += "','";
							Utility.Engine.sql += "CIKIS','";
							Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxCikanDepo.Text) + "','";
							Utility.Engine.sql += itim.SubItems[5].Text + "','";
							Utility.Engine.sql += itim.SubItems[6].Text + "') END ";

							Utility.Engine.dat.TInsert(Utility.Engine.sql);

							#endregion

							itim.SubItems[3].Text = Convert.ToString(okunan + mik);
							itim.SubItems[4].Text = Convert.ToString(kalan - mik);
						}

						break;
					}
				}

				if(!listedevar)
				{
					MessageBox.Show("SiPARiş LiSTESiNDE OLMAYAN ÜRÜN SEVK EDiLEMEZ<HATALI SEVK>!","HATA!!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
					textBoxMiktar.SelectAll();
					textBoxMiktar.Focus();
					Cursor.Current = Cursors.Default;
					return;
				}


			}
			catch(Exception ex)
			{
			}

			Kapat();
			Cursor.Current = Cursors.Default;
		}
		private void textBoxBarkod_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if(checkBoxSeri.Checked)
					EtiketSeri();
				else PaletBarkod();
				return;
			}
		}

		private void Kapat()
		{
			labelBirim.Text = "";
			labelStokAdi.Text = "";
			labelStokKodu.Text = "";
			textBoxMiktar.Text = "";
			panelStokDetay.Visible = false;
			textBoxBarkod.Text = "";
			textBoxBarkod.Focus();
			return;
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Kapat();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			UrunEkle();
		}

		private void button15_Click(object sender, System.EventArgs e)
		{
			if(textBoxBelgeNo.Text != "")
			{
				Utility.Engine.sql = "UPDATE stok_hareket_ust SET Aciklama1 = N'";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxAciklama1.Text);
				Utility.Engine.sql += "', Aciklama2 = N'";
				Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxAciklama2.Text);
				Utility.Engine.sql += "', HareketKodu = N'";
				Utility.Engine.sql += labelHareket.Text;
				Utility.Engine.sql += "' WHERE BelgeNo = '";
				Utility.Engine.sql += textBoxBelgeNo.Text;
				Utility.Engine.sql += "'";

				Utility.Engine.dat.TInsert(Utility.Engine.sql);
			}
			UstBilgiGoster(false);
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			UstBilgiGoster(true);
		}

		private void button11_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBoxAciklama1.Text;
			if(t.ShowDialog()==DialogResult.OK)
				textBoxAciklama1.Text = t.textBox1.Text;
		}

		private void button13_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBoxAciklama2.Text;
			if(t.ShowDialog()==DialogResult.OK)
				textBoxAciklama2.Text = t.textBox1.Text;
		}

		private void button12_Click(object sender, System.EventArgs e)
		{
			textBoxAciklama1.Text = "";
			textBoxAciklama1.Focus();
		}

		private void button14_Click(object sender, System.EventArgs e)
		{
			textBoxAciklama2.Text = "";
			textBoxAciklama2.Focus();
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			textBoxCikanDepo.Text = "";return;
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			textBoxGirenDepo.Text = "";return;
		}

		private void comboBoxHareket_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

//			try
//			{
//				if(comboBoxHareket.SelectedItem != null)
//				{
//					Utility.Engine.sql = string.Format("SELECT OzelKod,VarGirisDeposu,VarCikisDeposu FROM hareket_tanim  WHERE  (SiparisIliski = 'E') AND (HareketKodu = N'{0}')",comboBoxHareket.SelectedItem.ToString());
//
//					System.Data.IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);
//
//					if (dr != null && dr.Read())
//					{
//						if (dr["OzelKod"] != DBNull.Value)
//						{
//							labelHareket.Text = dr["OzelKod"].ToString();
//						}
//
//						if (dr["VarGirisDeposu"] != DBNull.Value)
//						{
//							textBoxGirenDepo.Text = dr["VarGirisDeposu"].ToString();
//							button10.Enabled = 
//							button9.Enabled = (dr["VarGirisDeposu"].ToString() == "");
//						}
//						else button10.Enabled = button9.Enabled = true;
//						if (dr["VarCikisDeposu"] != DBNull.Value)
//						{
//							textBoxCikanDepo.Text = dr["VarCikisDeposu"].ToString();
//							button7.Enabled = 
//							button8.Enabled = (dr["VarCikisDeposu"].ToString() == "");
//						}
//						else button7.Enabled = button8.Enabled = true;
//					}
//					if (dr != null) dr.Close();
//				}
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show("HAREKET ÖZEL KODU SUNUCUDAN SORGULANIRKEN HATA OLUşTU","DiKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
//				return;
//			}


			Cursor.Current = Cursors.Default;
		}

		private void textBoxCikanDepo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			textBoxCikanDepo.Text = "";
			DepoSecimOzel oz = new DepoSecimOzel();
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxCikanDepo.Text = oz.DepoKodu;
                Utility.Engine.sql = "SELECT Eksi FROM depo_tanim (NOLOCK) WHERE (DepoKodu = N'";
				Utility.Engine.sql += textBoxCikanDepo.Text;
				Utility.Engine.sql += "')";
				Utility.Engine.EksiStokOlmasin = (Utility.Engine.dat.TSelectScalar(Utility.Engine.sql) == "H");
			}
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			textBoxGirenDepo.Text = "";
			DepoSecimOzel oz = new DepoSecimOzel();
			oz.Rapor = true;
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxGirenDepo.Text = oz.DepoKodu;
			}
		}

		private void textBoxMiktar_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
				UrunEkle();return;
			}
//			if(!char.IsControl(e.KeyChar))
//			{
//				if(!char.IsNumber(e.KeyChar))e.Handled = true;
//				else if(e.KeyChar != '.')e.Handled = true;
//				else e.Handled = false;
//			}
		}

		private void textBoxBelgeNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void button16_Click(object sender, System.EventArgs e)
		{
			if(textBoxBelgeNo.Text != "" && MessageBox.Show(textBoxBelgeNo.Text + "` NOLU BELGE iPTAL EDiLECEK ONAYLIYORMUSUNUZ?","DiKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.OK)
			{
				Utility.Engine.sql = string.Format("DELETE FROM stok_hareket_detay WHERE BelgeNo = {0} ; DELETE FROM stok_hareket_ust WHERE BelgeNo = {0} ",textBoxBelgeNo.Text);
				Utility.Engine.dat.TInsert(Utility.Engine.sql);
				Close();
			}
		}

		private void button20_Click(object sender, System.EventArgs e)
		{
			if(listView1.Items.Count > 0 && listView1.SelectedIndices.Count > 0)
			{
				labelStokOneri.Text = listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text;
				DepoStokOneri(true);
			}
		}

		private void button21_Click(object sender, System.EventArgs e)
		{
			DepoStokOneri(false);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if(textBoxCikanDepo.Text.Equals(""))
			{
				Utility.Engine.Hata("Cikan Depoyu Secmelisiniz!");return;
			}
			string kod = "";
			try
			{
				if(listView1.Items.Count > 0 && listView1.SelectedIndices.Count > 0)
				{
					kod = listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
				}
			}
			catch
			{
			}

			OzelSecim oz = new OzelSecim();
			oz.str_ad = "stok_tanim_ust.StokAdi";
			oz.str_kod = "stok_tanim_ust.StokKodu";
			oz.str_ozel = "stok_tanim_detay.Birim";
			oz.tablo = "stok_tanim_ust INNER JOIN stok_tanim_detay ON stok_tanim_ust.StokKodu = stok_tanim_detay.StokKodu ";
			oz.order_by = " stok_tanim_ust.StokAdi ";
			oz.textBox_KOD.Text = kod.Trim();;
			if(oz.ShowDialog() == DialogResult.OK)
			{
				labelStokKodu.Text = oz.kod;
				labelStokAdi.Text = oz.ad;
				labelBirim.Text = oz.ozel;
				textBoxMiktar.Text = "1";
				
				panelStokDetay.Location = new Point(16, 24);
				panelStokDetay.BringToFront();
				panelStokDetay.Visible = true;
				textBoxBarkod.Text = "";
				textBoxMiktar.SelectAll();
				textBoxMiktar.Focus();
				return;
			}
		}

		private void button19_Click(object sender, System.EventArgs e)
		{
			MiktarDuzelt(true);
		}

		private void button23_Click(object sender, System.EventArgs e)
		{
			MiktarDuzelt(false);
		}

		private void button22_Click(object sender, System.EventArgs e)
		{
			Duzelt();
		}

		private void labelDuzeltStok_ParentChanged(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxMiktar2_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)Duzelt();
		}

		private void button18_Click(object sender, System.EventArgs e)
		{
			if(!this.OkumaVarmi())
			{
				Utility.Engine.Hata("Once Okuma Yapin!!");return;
			}

			if(listView1.Items.Count > 0 && MessageBox.Show("YAPILAN işLEMLER KAYDEDiLECEK ONAYLIYORMUSUNUZ?","DiKKAT!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				if(textBoxGirenDepo.Text == "" || textBoxCikanDepo.Text == textBoxGirenDepo.Text)
				{
					MessageBox.Show("GiREN DEPODA HATA!","HATA!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
					UstBilgiGoster(true);
					return;
				}

				if(textBoxHareket.Text.Equals(""))
				{
					Utility.Engine.Hata("Hareket Kodu Bos Birakilamaz!");
					UstBilgiGoster(true);
					return;
				}

				Utility.Engine.sql = string.Format("EXEC dbo.BelgeAktar {0},'{1}'",Utility.Engine.SqlTemizle(textBoxBelgeNo.Text),Utility.Engine.SqlTemizle(textBoxGirenDepo.Text));
				
				try
				{
					string msg = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);

					if(!msg.Equals("ok"))
					{
						Utility.Engine.Hata("Sunucu Hata Bildirdi:" + msg);
						return;
					}
					else
					{
						Utility.Engine.Tamam("Islem Tamamlandi");
						SiparisDetay();
					}
				}
				catch(Exception exc)
				{
					Utility.Engine.Hata("Kayit Hatasi:" + exc.Message);
					return;
				}

				#region iptal
//				bool hata = false;
//				DataTable dat = new DataTable();
//				Utility.Engine.sql = "SELECT StokKodu,Miktar,GirenDepo,CikanDepo,Birim FROM stok_hareket_detay WHERE BelgeNo = ";
//				Utility.Engine.sql += textBoxBelgeNo.Text;
//
//				Utility.Engine.dat.TableDoldur(Utility.Engine.sql,ref dat);
//
//				if(dat != null && dat.Rows.Count > 0)
//				{
//					#region red
//					for(int i = 0;i < dat.Rows.Count;i++)
//					{
//						Utility.Engine.sql = "IF EXISTS (SELECT * FROM depo_mevcut WHERE DepoKodu = N'";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(this.textBoxGirenDepo.Text);
//						Utility.Engine.sql += "' AND StokKodu = N'";
//						Utility.Engine.sql += dat.Rows[i][0].ToString();
//						Utility.Engine.sql += "') BEGIN UPDATE depo_mevcut SET Miktar = Miktar + ";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][1].ToString());
//						Utility.Engine.sql += " WHERE DepoKodu = N'";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(this.textBoxGirenDepo.Text);
//						Utility.Engine.sql += "' AND StokKodu = N'";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][0].ToString());
//						Utility.Engine.sql += "' UPDATE depo_mevcut SET Miktar = Miktar - ";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][1].ToString());
//						Utility.Engine.sql += " WHERE DepoKodu = N'";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][3].ToString());
//						Utility.Engine.sql += "' AND StokKodu = N'";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][0].ToString());
//						Utility.Engine.sql += "' END ELSE BEGIN INSERT INTO depo_mevcut (DepoKodu, StokKodu, Birim, Miktar, SeriliBarkod, IslemTarihi) VALUES ";
//						Utility.Engine.sql += "(N'";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(this.textBoxGirenDepo.Text);
//						Utility.Engine.sql += "',N'";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][0].ToString());
//						Utility.Engine.sql += "','";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][4].ToString());
//						Utility.Engine.sql += "',";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][1].ToString());
//						Utility.Engine.sql += ",'',GETDATE()) ; UPDATE depo_mevcut SET Miktar = Miktar - ";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][1].ToString());
//						Utility.Engine.sql += " WHERE DepoKodu = N'";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][3].ToString());
//						Utility.Engine.sql += "' AND StokKodu = N'";
//						Utility.Engine.sql += Utility.Engine.SqlTemizle(dat.Rows[i][0].ToString());
//						Utility.Engine.sql += "'  END ";
//
//						if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
//						{
//							hata = true;
//							break;
//						}
//					}
//					#endregion
//				}
//
//				if(!hata)
//				{
//					Utility.Engine.sql = " UPDATE stok_hareket_detay SET GirenDepo = '";
//					Utility.Engine.sql += Utility.Engine.SqlTemizle(this.textBoxGirenDepo.Text);
//					Utility.Engine.sql += "'  WHERE BelgeNo = ";
//					Utility.Engine.sql += Utility.Engine.SqlTemizle(this.textBoxBelgeNo.Text);
//					Utility.Engine.sql += " ; UPDATE stok_hareket_ust SET FLAG_C = 'E' WHERE BelgeNo = '";
//					Utility.Engine.sql += Utility.Engine.SqlTemizle(this.textBoxBelgeNo.Text);
//					Utility.Engine.sql += "'";
//
//					if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
//					{
//						Utility.Engine.Hata("Belge Aktarilamadi! Yoneticinize Bildirin Belge No:" + Utility.Engine.SqlTemizle(this.textBoxBelgeNo.Text));
//						Utility.Engine.Uyari(Utility.Engine.sql);
//						return;
//					}
//
//					MessageBox.Show("işlem Tamamlandi.\n" + Utility.Engine.SqlTemizle(this.textBoxBelgeNo.Text) + "` nolu Belge Kaydedildi.");
//					Close();
//				}
				#endregion
			}
		}

		private void comboBoxHareket_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
			try
			{
//				this.textBoxCikanDepo.Text = this.textBoxGirenDepo.Text = "";
//				this.labelHareket.Text = "";
//				this.button7.Enabled = this.button8.Enabled = true;
//				this.button9.Enabled = this.button10.Enabled = true;
//				if(comboBoxHareket.SelectedItem != null)
//				{
//					Utility.Engine.sql = string.Format("SELECT OzelKod,VarGirisDeposu,VarCikisDeposu FROM hareket_tanim  WHERE  (SiparisIliski = 'E') AND (HareketKodu = N'{0}')",comboBoxHareket.SelectedItem.ToString());
//
//					System.Data.IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);
//
//					if (dr != null && dr.Read())
//					{
//						if (dr["OzelKod"] != DBNull.Value)
//						{
//							labelHareket.Text = dr["OzelKod"].ToString();
//						}
//
//						if (dr["VarGirisDeposu"] != DBNull.Value)
//						{
//							textBoxGirenDepo.Text = dr["VarGirisDeposu"].ToString();
//							this.button9.Enabled = this.button10.Enabled = false;
//						}
//						if (dr["VarCikisDeposu"] != DBNull.Value)
//						{
//							this.textBoxCikanDepo.Text = dr["VarCikisDeposu"].ToString();
//							this.button7.Enabled = this.button8.Enabled = false;
//						}
//					}
//					if (dr != null) dr.Close();
//				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("HAREKET ÖZEL KODU SUNUCUDAN SORGULANIRKEN HATA OLUşTU","DiKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.labelSMiktar.Text = "0";
				this.labelKalan.Text = "0";
				if(listView1.Items.Count > 0)
				{
					if(listView1.SelectedIndices.Count > 0)
					{
						this.labelSMiktar.Text = this.listView1.Items[this.listView1.SelectedIndices[0]].SubItems[2].Text;
						this.labelKalan.Text = this.listView1.Items[this.listView1.SelectedIndices[0]].SubItems[4].Text;
					}
				}
			}
			catch
			{
			}
		}

		private void textBoxMiktar3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void buttonyildiz_Click(object sender, System.EventArgs e)
		{
			textBoxMiktar.Focus();
			if(textBoxMiktar.Text.IndexOf("*") == -1)textBoxMiktar.Text += "*";
			textBoxMiktar.SelectionStart = textBoxMiktar.Text.Length;
		}

		private void checkBoxSeri_CheckStateChanged(object sender, System.EventArgs e)
		{
			checkBoxSeri.Text = (checkBoxSeri.Checked) ? "Seri" : "Palet";
			textBoxBarkod.BackColor = (checkBoxSeri.Checked) ? Color.Yellow : Color.Salmon;
			textBoxBarkod.Focus();
			textBoxBarkod.SelectAll();
			return;
		}

		private void DetayliSevk_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.D0)Close();
		}

		private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			try
			{
				if(e.KeyChar == 13)
				{
					if(textBox1.Text.Length < 7)
					{
						textBox1.Text = "";
						textBox1.Focus();
						return;
					}
					Utility.Engine.sql = "EXEC dbo.SeriCikartSevk '";
					Utility.Engine.sql += Utility.Engine.SqlTemizle(textBox1.Text);
					Utility.Engine.sql += "',";
					Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxBelgeNo.Text);

					if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
					{
						Utility.Engine.Hata("Kayit Hatasi:" + Utility.Engine.dat.STR_HataMesaji);
						textBox1.Text = "";
						textBox1.Focus();
						return;
					}

					for(int i = 0;i< listView2.Items.Count; i++)
					{
						if(listView2.Items[i].SubItems[0].Text.Equals(Utility.Engine.SqlTemizle(textBox1.Text)))
						{
							listView2.Items.RemoveAt(i);
							break;
						}
					}

					this.Text = "Detaylar " + listView2.Items.Count.ToString();

					textBox1.Text = "";
					textBox1.Focus();
					return;
				}
			}
			catch(Exception exc)
			{
				Utility.Engine.Hata("Genel Hata:" + exc.Message);
				textBox1.Text = "";
				textBox1.Focus();
				return;
			}
		}

		private void button22_Click_1(object sender, System.EventArgs e)
		{
			textBoxHareket.Text = "";
			labelHareket.Text = "";
		}

		private void button24_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
            s.sql = "select HareketKodu,HareketAdi,OzelKod,VarGirisDeposu,VarCikisDeposu from hareket_tanim (NOLOCK)";
			s.sql_orderby=" order by HareketKodu";
			s.tablename="hareket_tanim";
			
			s.ShowDialog();
			if(s.dr!=null)
			{
				textBoxHareket.Text=s.dr["HareketKodu"].ToString();
				labelHareket.Text = s.dr["OzelKod"].ToString();

				if(!s.dr["VarCikisDeposu"].ToString().Equals(""))
				{
					textBoxCikanDepo.Text = s.dr["VarCikisDeposu"].ToString();
				}
				if(!s.dr["VarGirisDeposu"].ToString().Equals(""))
				{
					textBoxGirenDepo.Text = s.dr["VarGirisDeposu"].ToString();
				}

				button7.Enabled = (s.dr["VarCikisDeposu"].ToString().Equals(""));
				button10.Enabled = (s.dr["VarGirisDeposu"].ToString().Equals(""));
			}
		}

		private void button17_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
