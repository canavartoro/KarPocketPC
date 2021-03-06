using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for SevkEmriDetay.
	/// </summary>
    public class SevkEmriDetay : System.Windows.Forms.Form
    {
        //public Engine Utility.Engine;
        
        public string sevkno = "";
        public string carikod = "";
        public string sipno = "";

        private long belge_no=0;
        private int hareket_id = 0;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Panel panelBul;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Panel panelStokDetay;
        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonyildiz;
        private System.Windows.Forms.Panel panelraporlar;
        private Button button25;
        private Label label2;
        private DataGridTableStyle dataGridTableStyle1;
        private DataGridTextBoxColumn dataGridTextBoxColumn1;
        private DataGridTextBoxColumn dataGridTextBoxColumn2;
        private DataGridTextBoxColumn dataGridTextBoxColumn3;
        private DataGridTextBoxColumn dataGridTextBoxColumn4;
        private DataGridTextBoxColumn dataGridTextBoxColumn5;
        private Button button7;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button3;
        private Button button6;
        private Button button5;
        private Label label1;
        private Label label3;
        private Label label8;
        private Label labelbelge_no;
        private Label labelsevk_no;
        private Label label_top_adet;
        private Label labeltop_seri;
        private Label label9;
        private ListView listView2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Button button4;
        private ColumnHeader columnHeader14;
        private Button button8;
        private Button button9;
        private TextBox textBox1;
        private TextBox txtIstenen;
        private Label label7;
        private TextBox txtOkunan;
        private Label label10;
        private TextBox txtKalan;
        private Label label11;
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private MenuItem menuItem6;
        private MenuItem menuItem7;
        private Label label4;

        public SevkEmriDetay()
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

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SevkEmriDetay));
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button20 = new System.Windows.Forms.Button();
            this.panelBul = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panelStokDetay = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.buttonyildiz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelraporlar = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.labelbelge_no = new System.Windows.Forms.Label();
            this.labelsevk_no = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_top_adet = new System.Windows.Forms.Label();
            this.labeltop_seri = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtIstenen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOkunan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.panelBul.SuspendLayout();
            this.panelStokDetay.SuspendLayout();
            this.panelraporlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(186, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "M";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.BackColor = System.Drawing.Color.Yellow;
            this.textBoxBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBoxBarkod.Location = new System.Drawing.Point(38, 1);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(125, 21);
            this.textBoxBarkod.TabIndex = 7;
            this.textBoxBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBarkod_KeyUp);
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader6);
            this.listView1.Columns.Add(this.columnHeader7);
            this.listView1.Columns.Add(this.columnHeader13);
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.Columns.Add(this.columnHeader4);
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(1, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 195);
            this.listView1.TabIndex = 9;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "StokKodu";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "StokAdi";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Miktar";
            this.columnHeader13.Width = 70;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Okunan";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kalan";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MNO";
            this.columnHeader3.Width = 5;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DNO";
            this.columnHeader4.Width = 5;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(6, 444);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 26);
            this.button20.TabIndex = 13;
            this.button20.Text = "bul";
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // panelBul
            // 
            this.panelBul.Controls.Add(this.button8);
            this.panelBul.Controls.Add(this.button21);
            this.panelBul.Controls.Add(this.dataGrid1);
            this.panelBul.Controls.Add(this.label2);
            this.panelBul.Location = new System.Drawing.Point(248, 0);
            this.panelBul.Name = "panelBul";
            this.panelBul.Size = new System.Drawing.Size(240, 283);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(8, 260);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 21);
            this.button8.TabIndex = 3;
            this.button8.Text = "Çik";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(165, 258);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(72, 21);
            this.button21.TabIndex = 0;
            this.button21.Text = "tamam";
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(0, 19);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.Size = new System.Drawing.Size(240, 238);
            this.dataGrid1.TabIndex = 1;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Hareket Kodu";
            this.dataGridTextBoxColumn1.MappingName = "HareketKodu";
            this.dataGridTextBoxColumn1.Width = 100;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Hareket Adi";
            this.dataGridTextBoxColumn2.MappingName = "HareketAdi";
            this.dataGridTextBoxColumn2.Width = 100;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Giren Depo";
            this.dataGridTextBoxColumn3.MappingName = "VarGirisDeposu";
            this.dataGridTextBoxColumn3.Width = 100;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Çikan Depo";
            this.dataGridTextBoxColumn4.MappingName = "VarCikisDeposu";
            this.dataGridTextBoxColumn4.Width = 100;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "id";
            this.dataGridTextBoxColumn5.MappingName = "id";
            this.dataGridTextBoxColumn5.Width = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(70, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 12);
            this.label2.Text = "Hareket Seçiniz";
            // 
            // panelStokDetay
            // 
            this.panelStokDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelStokDetay.Controls.Add(this.textBox1);
            this.panelStokDetay.Controls.Add(this.label4);
            this.panelStokDetay.Controls.Add(this.button9);
            this.panelStokDetay.Controls.Add(this.button5);
            this.panelStokDetay.Controls.Add(this.textBoxMiktar);
            this.panelStokDetay.Controls.Add(this.buttonyildiz);
            this.panelStokDetay.Controls.Add(this.label6);
            this.panelStokDetay.Location = new System.Drawing.Point(277, 352);
            this.panelStokDetay.Name = "panelStokDetay";
            this.panelStokDetay.Size = new System.Drawing.Size(205, 118);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBox1.Location = new System.Drawing.Point(53, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 21);
            this.textBox1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(1, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.Text = "Depo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(33, 83);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 27);
            this.button9.TabIndex = 17;
            this.button9.Text = "ekle";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(114, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 27);
            this.button5.TabIndex = 15;
            this.button5.Text = "çik";
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.BackColor = System.Drawing.Color.Yellow;
            this.textBoxMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.textBoxMiktar.Location = new System.Drawing.Point(52, 19);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(128, 21);
            this.textBoxMiktar.TabIndex = 3;
            // 
            // buttonyildiz
            // 
            this.buttonyildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonyildiz.Location = new System.Drawing.Point(180, 19);
            this.buttonyildiz.Name = "buttonyildiz";
            this.buttonyildiz.Size = new System.Drawing.Size(16, 21);
            this.buttonyildiz.TabIndex = 13;
            this.buttonyildiz.Text = "*";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(2, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.Text = "Miktar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelraporlar
            // 
            this.panelraporlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelraporlar.Controls.Add(this.button4);
            this.panelraporlar.Controls.Add(this.listView2);
            this.panelraporlar.Controls.Add(this.labelbelge_no);
            this.panelraporlar.Controls.Add(this.labelsevk_no);
            this.panelraporlar.Controls.Add(this.label9);
            this.panelraporlar.Controls.Add(this.label8);
            this.panelraporlar.Controls.Add(this.label3);
            this.panelraporlar.Controls.Add(this.label1);
            this.panelraporlar.Controls.Add(this.label_top_adet);
            this.panelraporlar.Controls.Add(this.labeltop_seri);
            this.panelraporlar.Location = new System.Drawing.Point(494, 0);
            this.panelraporlar.Name = "panelraporlar";
            this.panelraporlar.Size = new System.Drawing.Size(240, 286);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(218, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 20);
            this.button4.TabIndex = 44;
            this.button4.Text = ">";
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView2.Columns.Add(this.columnHeader5);
            this.listView2.Columns.Add(this.columnHeader14);
            this.listView2.Columns.Add(this.columnHeader12);
            this.listView2.Columns.Add(this.columnHeader8);
            this.listView2.Columns.Add(this.columnHeader9);
            this.listView2.Columns.Add(this.columnHeader10);
            this.listView2.Columns.Add(this.columnHeader11);
            this.listView2.Location = new System.Drawing.Point(1, 21);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(238, 230);
            this.listView2.TabIndex = 39;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Seri";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "StokKodu";
            this.columnHeader14.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "StokAdi";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "AnaBirim";
            this.columnHeader8.Width = 60;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Miktar1";
            this.columnHeader9.Width = 60;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "AmbalajBirim";
            this.columnHeader10.Width = 60;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Miktar2";
            this.columnHeader11.Width = 60;
            // 
            // labelbelge_no
            // 
            this.labelbelge_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelbelge_no.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelbelge_no.ForeColor = System.Drawing.Color.Maroon;
            this.labelbelge_no.Location = new System.Drawing.Point(178, 3);
            this.labelbelge_no.Name = "labelbelge_no";
            this.labelbelge_no.Size = new System.Drawing.Size(61, 15);
            this.labelbelge_no.Text = "675548";
            this.labelbelge_no.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelsevk_no
            // 
            this.labelsevk_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelsevk_no.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelsevk_no.ForeColor = System.Drawing.Color.Maroon;
            this.labelsevk_no.Location = new System.Drawing.Point(53, 3);
            this.labelsevk_no.Name = "labelsevk_no";
            this.labelsevk_no.Size = new System.Drawing.Size(76, 14);
            this.labelsevk_no.Text = "exp00000";
            this.labelsevk_no.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(131, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.Text = "BelgeNo";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(2, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 14);
            this.label8.Text = "Sevk No.:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(127, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.Text = "Top. Adet\\Metre";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 14);
            this.label1.Text = "Top. Okutulan Seri";
            // 
            // label_top_adet
            // 
            this.label_top_adet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_top_adet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label_top_adet.ForeColor = System.Drawing.Color.Maroon;
            this.label_top_adet.Location = new System.Drawing.Point(147, 265);
            this.label_top_adet.Name = "label_top_adet";
            this.label_top_adet.Size = new System.Drawing.Size(66, 17);
            this.label_top_adet.Text = "0";
            this.label_top_adet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labeltop_seri
            // 
            this.labeltop_seri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labeltop_seri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labeltop_seri.ForeColor = System.Drawing.Color.Maroon;
            this.labeltop_seri.Location = new System.Drawing.Point(30, 266);
            this.labeltop_seri.Name = "labeltop_seri";
            this.labeltop_seri.Size = new System.Drawing.Size(66, 17);
            this.labeltop_seri.Text = "0";
            this.labeltop_seri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(1, 1);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(37, 21);
            this.button25.TabIndex = 15;
            this.button25.Text = "depo";
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(1152, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(16, 16);
            this.button7.TabIndex = 21;
            this.button7.Text = "x";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 21);
            this.button3.TabIndex = 27;
            this.button3.Text = ">";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(214, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 21);
            this.button6.TabIndex = 33;
            this.button6.Text = "X";
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIstenen
            // 
            this.txtIstenen.BackColor = System.Drawing.Color.Yellow;
            this.txtIstenen.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtIstenen.Location = new System.Drawing.Point(48, 223);
            this.txtIstenen.Name = "txtIstenen";
            this.txtIstenen.ReadOnly = true;
            this.txtIstenen.Size = new System.Drawing.Size(194, 18);
            this.txtIstenen.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(2, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.Text = "istenen";
            // 
            // txtOkunan
            // 
            this.txtOkunan.BackColor = System.Drawing.Color.LightGreen;
            this.txtOkunan.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtOkunan.Location = new System.Drawing.Point(48, 241);
            this.txtOkunan.Name = "txtOkunan";
            this.txtOkunan.ReadOnly = true;
            this.txtOkunan.Size = new System.Drawing.Size(194, 18);
            this.txtOkunan.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label10.Location = new System.Drawing.Point(4, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.Text = "Okunan";
            // 
            // txtKalan
            // 
            this.txtKalan.BackColor = System.Drawing.Color.Salmon;
            this.txtKalan.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtKalan.Location = new System.Drawing.Point(48, 258);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.ReadOnly = true;
            this.txtKalan.Size = new System.Drawing.Size(194, 18);
            this.txtKalan.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label11.Location = new System.Drawing.Point(4, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.Text = "Kalan";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItem1);
            this.contextMenu1.MenuItems.Add(this.menuItem2);
            this.contextMenu1.MenuItems.Add(this.menuItem3);
            this.contextMenu1.MenuItems.Add(this.menuItem4);
            this.contextMenu1.MenuItems.Add(this.menuItem6);
            this.contextMenu1.MenuItems.Add(this.menuItem7);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Depo Stok";
            this.menuItem1.Click += new System.EventHandler(this.button10_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Seri Sorgulama";
            this.menuItem2.Click += new System.EventHandler(this.button12_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Palet Transfer";
            this.menuItem3.Click += new System.EventHandler(this.button11_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Detaylar";
            this.menuItem4.Click += new System.EventHandler(this.button19_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Stok Miktari Sor";
            this.menuItem6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "Sevk iptal";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // SevkEmriDetay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKalan);
            this.Controls.Add(this.txtOkunan);
            this.Controls.Add(this.txtIstenen);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.panelraporlar);
            this.Controls.Add(this.panelStokDetay);
            this.Controls.Add(this.panelBul);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxBarkod);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SevkEmriDetay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SevkEmriDetay_Load);
            this.panelBul.ResumeLayout(false);
            this.panelStokDetay.ResumeLayout(false);
            this.panelraporlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void SevkEmriDetay_Load(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                this.Text = this.sevkno;
                
                panelBul.Location = new Point(1, 1);
                panelBul.BringToFront();

                Utility.Engine.sql = @" select  HareketKodu,HareketAdi,VarGirisDeposu,VarCikisDeposu,id
from hareket_tanim 
where SiparisIliski=N'E'
order by id
";
                DataTable dtx = Utility.Engine.dat.TableDon(Utility.Engine.sql);
                
                dataGrid1.DataSource = dtx;

                if (sevkno.StartsWith("EXP"))
                {
                    for (int i = 0; i < dtx.Rows.Count; i++)
                    {
                        if (dtx.Rows[i][0].Equals("SATIŞ-YURT DIŞI"))
                        {
                            dataGrid1.Focus();
                            dataGrid1.Select(i);
                            button21_Click(null, null);
                            return;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dtx.Rows.Count; i++)
                    {
                        if (dtx.Rows[i][0].Equals("SATIŞ-YURT İÇİ"))
                        {
                            dataGrid1.Focus();
                            dataGrid1.Select(i);
                            button21_Click(null, null);
                            return;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("SUNUCUDAN BiLGiLER YÜKLENiRKEN HATA:" + ex.Message, "DiKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }

            
            Cursor.Current = Cursors.Default;
            textBoxBarkod.Focus();
            Application.DoEvents();
        }  
            
        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
                 
        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {                                
                if (listView1.Items.Count > 0)
                {
                    if (listView1.SelectedIndices.Count > 0)
                    {
                        textBoxBarkod.Text = listView1.Items[this.listView1.SelectedIndices[0]].SubItems[0].Text.Trim();
                        DataTable df = Utility.Engine.dat.TableDon(@"  exec SevkBilgi N'" + sevkno + "',N'" + textBoxBarkod.Text + "'  ");

                        txtIstenen.Text = "Istenen:" + df.Rows[0]["Istenen"].ToString() + " " + df.Rows[0]["Birim"].ToString();

                        txtIstenen.Text += ";" + df.Rows[0]["Istenen1"].ToString() + " " + df.Rows[0]["Birim1"].ToString();

                        txtOkunan.Text = "Okunan;" + df.Rows[0]["Okunan"].ToString() + " " + df.Rows[0]["Birim"].ToString();

                        txtOkunan.Text += ";" + df.Rows[0]["Okunan1"].ToString() + " " + df.Rows[0]["Birim1"].ToString();

                        txtKalan.Text = "Kalan;" + df.Rows[0]["Kalan"].ToString() + " " + df.Rows[0]["Birim"].ToString();

                        txtKalan.Text += ";" + df.Rows[0]["Kalan1"].ToString() + " " + df.Rows[0]["Birim1"].ToString();

                        /*
                         exec SevkBilgi N'""',N'""'
                         */
                    }
                }
            }
            catch
            {
                ;
            }
        }

        private void button21_Click(object sender, System.EventArgs e)
        {
            int indx=0;

            indx=dataGrid1.CurrentRowIndex;

            if ( indx< 0)
            {
                MessageBox.Show("Sevk işlemi için Bir Hareket Seçmelisiniz");
                return;
            }

            string secilen="";

            try
            {
                secilen = dataGrid1[indx, 4].ToString();

                hareket_id = int.Parse(secilen);
            }
            catch { hareket_id = 0; }


            if (hareket_id==0)
            {
                MessageBox.Show("Sevk işlemi için Bir Hareket Seçmelisiniz");
                return;
            }


            Utility.Engine.sql = @" exec  [dbo].[fast_dispatch]  ";
            Utility.Engine.sql += @" N'',N'" + sevkno + "',N'" + carikod + "',N'',N'" + Utility.Engine.KullaniciID + "',N'" + Utility.Engine.CihazID + "',N'" + hareket_id.ToString() + "',N'',N'5'";

            string snc="";

            snc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();

            if (snc == "0")
                MessageBox.Show("Bu Sevk Emrine Ayit BelgeNo Alinamadi");

            try
            {
                belge_no = long.Parse(snc);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }

            panelBul.Location = new Point(256, 0);

            Application.DoEvents();

            Cursor.Current = Cursors.WaitCursor;
            yenile();
            Cursor.Current = Cursors.Default;

            textBoxBarkod.Focus();

        }                                                      
                        
        private void button2_Click(object sender, System.EventArgs e)
        {
            textBoxBarkod.Text = "";
            contextMenu1.Show(button2, new Point(2, 2));                    
        }

        private void textBoxBarkod_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gonder();
            }
        }

        private void gonder()
        {                      
            string ss="";
            ss= textBoxBarkod.Text.Trim().Replace("\n\r","").Replace("\r\n","")
            .Replace("\r","").Replace("\n","\r");
            
            textBoxBarkod.Text=ss;

            if ( ss== "") return;

            double  k_miktar=0;
            string str = "";

            textBoxMiktar.Text="";

            Cursor.Current = Cursors.WaitCursor;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                str = listView1.Items[i].SubItems[0].Text.Trim();

                if (str == ss)
                {
                    panelStokDetay.Location = new Point(16, 105);
                    panelStokDetay.BringToFront();
                    textBoxMiktar.Text = "";
                    mktr = true;
                    Cursor.Current = Cursors.Default;
                    return;
                }
            }
                                    
            string sm = textBoxMiktar.Text.Trim().PadLeft(1, '0');

            try
            {
                k_miktar = double.Parse(sm);
            }
            catch { MessageBox.Show("Miktar Alani Hatali"); }

            Utility.Engine.sql = @"exec sevk.DetayliSevk N'" + ss + "',N'" + sevkno + "',N'" + carikod + "'";
            Utility.Engine.sql += @",N'" + belge_no + "',N'" + Utility.Engine.KullaniciID + "',N'" + Utility.Engine.CihazID + "',N'" + hareket_id.ToString() + "',N'" + sm + "',N'0'";

            string snc = "";

            snc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();

            //Utility.Dikkat(Utility.Engine.sql);
            //Utility.Engine.SqlYaz("murat.sql");

            if (snc != "1")
                MessageBox.Show("Sunucu hatasi:" + snc,"Sonuc");

            textBoxBarkod.Text = "";

            textBoxBarkod.Focus();

            yenile();

            Cursor.Current = Cursors.Default;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            gonder();           
        }      

        private void textBoxBelgeNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void button18_Click(object sender, System.EventArgs e)
        {
          
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            gonder();
            panelStokDetay.Location = new Point(497, 7);
        }    
      
        private void button5_Click(object sender, EventArgs e)
        {
            panelStokDetay.Location = new Point(752, 16);
        }

        private void yenile()
        {
            try
            {
                Utility.Engine.sql = string.Format(@"
                dbo.sevkdetay N'{0}'
                ", sevkno);

                Utility.Engine.dat.ListDoldur2(ref listView1, Utility.Engine.sql);
               
                Cursor.Current = Cursors.Default;
            }
            catch (Exception exc)
            {
                Cursor.Current = Cursors.Default;
                Utility.Engine.Hata("Siparis Detaylari Cekilemedi:" + exc.Message);
                return;
            }
        }    

        private void button25_Click(object sender, EventArgs e)
        {            
            DepoSecimOzel oz = new DepoSecimOzel();
            if (oz.ShowDialog() == DialogResult.OK)
            {
                if (oz.DepoKodu.Trim() != "")
                {
                    if (mktr)
                    {
                        textBox1.Text = oz.DepoKodu;
                    }
                    else
                    {
                        textBoxBarkod.Text = oz.DepoKodu;
                    }
                }
            }
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            if (dataGrid1.CurrentRowIndex < 0) return;

            dataGrid1.Select(dataGrid1.CurrentRowIndex);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            gonder();
        }


        bool mktr = false;

        private void button6_Click(object sender, EventArgs e)
        {
            //
            panelStokDetay.Location = new Point(16, 105);
            panelStokDetay.BringToFront();
            textBoxMiktar.Text = "";
            mktr = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panelStokDetay.Location = new Point(497, 7);
            mktr = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panelraporlar.Location = new Point(0,0);
            panelraporlar.BringToFront();
            labelsevk_no.Text = sevkno;
            labelbelge_no.Text = belge_no.ToString();            
            labeltop_seri.Text=listView2.Items.Count.ToString();

            Utility.Engine.dat.ListDoldur2(ref listView2, @"
select
 d.SeriliBarkod,
 d.StokKodu,d.Birim as [AnaBirimi],
 d.Miktar,b.Birim as [AmbalajBirimi],
 b.Miktar
 from stok_hareket_detay d inner join stok_tanim_detay b  
on b.StokKodu=d.StokKodu  and b.SiraNo=2 
where d.BelgeNo=N'" + belge_no.ToString() + "' and len(d.SeriliBarkod)>0    ");


            Utility.Engine.sayList(listView2, 4);

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panelraporlar.Location=new Point(494,0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            string ss = "";
            ss = textBoxBarkod.Text.Trim().Replace("\n\r", "").Replace("\r\n", "")
            .Replace("\r", "").Replace("\n", "\r");

            textBoxBarkod.Text = ss;

            if (ss == "") return;

            Cursor.Current = Cursors.WaitCursor;

            double k_miktar = 0;
                                    
            string sm = textBoxMiktar.Text.Trim().PadLeft(1, '0');

            try
            {
                k_miktar = double.Parse(sm);
            }
            catch { MessageBox.Show("Miktar Alani Hatali"); }

            Utility.Engine.sql = @"exec [dbo].[fast_dispatch] N'" 
                + ss + "',N'" 
                + sevkno + "',N'" 
                + carikod + "'";

            Utility.Engine.sql += @",N'"
                + belge_no + "',N'"
                + Utility.Engine.KullaniciID + "',N'"
                + textBox1.Text.Trim() + "',N'"
                + hareket_id.ToString() + "',N'"
                + sm + "',N'0'";

            string snc = "";

            snc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();

            if (snc != "1")
                MessageBox.Show(snc);

            textBoxBarkod.Text = "";

            textBoxBarkod.Focus();

            panelStokDetay.Location = new Point(497, 7);
            mktr = false;

            yenile();

            Cursor.Current = Cursors.Default;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DepoStok dps = new DepoStok();
            dps.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KUretimGiris u = new KUretimGiris();
            u.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (SeriIzleForm ser = new SeriIzleForm())
            {
                ser.ShowDialog();
            }
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            using (sek_iptal ip = new sek_iptal())
            {
                ip.ShowDialog();
            }
        }        
    }
}
