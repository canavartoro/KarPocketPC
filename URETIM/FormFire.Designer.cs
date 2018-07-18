namespace AmbarPPC
{
    partial class FormFire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFire));
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIstasyon = new System.Windows.Forms.Button();
            this.txtTAd = new System.Windows.Forms.TextBox();
            this.txtTKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDurus = new System.Windows.Forms.Button();
            this.txtHAd = new System.Windows.Forms.TextBox();
            this.txtHKod = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.textMiktar = new System.Windows.Forms.TextBox();
            this.textTopFire = new System.Windows.Forms.TextBox();
            this.textBoxBirim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTopBirim = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.Add(this.toolBarButton1);
            this.toolBar1.Buttons.Add(this.toolBarButton2);
            this.toolBar1.Buttons.Add(this.toolBarButton3);
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.ToolTipText = "Kapat";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.ToolTipText = "Kaydet";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.ToolTipText = "Sil";
            this.imageList1.Images.Clear();
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.Text = "İstasyon Kodu";
            // 
            // buttonIstasyon
            // 
            this.buttonIstasyon.Location = new System.Drawing.Point(194, 30);
            this.buttonIstasyon.Name = "buttonIstasyon";
            this.buttonIstasyon.Size = new System.Drawing.Size(39, 23);
            this.buttonIstasyon.TabIndex = 7;
            this.buttonIstasyon.Text = "Bul";
            this.buttonIstasyon.Click += new System.EventHandler(this.buttonIstasyon_Click);
            // 
            // txtTAd
            // 
            this.txtTAd.Location = new System.Drawing.Point(1, 59);
            this.txtTAd.Name = "txtTAd";
            this.txtTAd.ReadOnly = true;
            this.txtTAd.Size = new System.Drawing.Size(232, 23);
            this.txtTAd.TabIndex = 6;
            this.txtTAd.TabStop = false;
            // 
            // txtTKod
            // 
            this.txtTKod.Location = new System.Drawing.Point(118, 30);
            this.txtTKod.Name = "txtTKod";
            this.txtTKod.Size = new System.Drawing.Size(77, 23);
            this.txtTKod.TabIndex = 4;
            this.txtTKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTKod_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.Text = "Hurda Kodu";
            // 
            // buttonDurus
            // 
            this.buttonDurus.Location = new System.Drawing.Point(194, 88);
            this.buttonDurus.Name = "buttonDurus";
            this.buttonDurus.Size = new System.Drawing.Size(39, 23);
            this.buttonDurus.TabIndex = 11;
            this.buttonDurus.Text = "Bul";
            this.buttonDurus.Click += new System.EventHandler(this.buttonDurus_Click);
            // 
            // txtHAd
            // 
            this.txtHAd.Location = new System.Drawing.Point(1, 117);
            this.txtHAd.Name = "txtHAd";
            this.txtHAd.ReadOnly = true;
            this.txtHAd.Size = new System.Drawing.Size(232, 23);
            this.txtHAd.TabIndex = 9;
            this.txtHAd.TabStop = false;
            // 
            // txtHKod
            // 
            this.txtHKod.BackColor = System.Drawing.Color.Yellow;
            this.txtHKod.Location = new System.Drawing.Point(118, 88);
            this.txtHKod.Name = "txtHKod";
            this.txtHKod.Size = new System.Drawing.Size(77, 23);
            this.txtHKod.TabIndex = 10;
            this.txtHKod.TabStop = false;
            this.txtHKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHKod_KeyPress);
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 146);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(230, 82);
            this.listView1.TabIndex = 13;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stok Kodu";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stok Adi";
            this.columnHeader2.Width = 135;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.Text = "Hurda Miktar:";
            // 
            // textMiktar
            // 
            this.textMiktar.BackColor = System.Drawing.Color.Yellow;
            this.textMiktar.Location = new System.Drawing.Point(102, 231);
            this.textMiktar.Name = "textMiktar";
            this.textMiktar.Size = new System.Drawing.Size(83, 23);
            this.textMiktar.TabIndex = 16;
            this.textMiktar.TabStop = false;
            this.textMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMiktar_KeyPress);
            // 
            // textTopFire
            // 
            this.textTopFire.BackColor = System.Drawing.Color.Gold;
            this.textTopFire.Location = new System.Drawing.Point(102, 256);
            this.textTopFire.Name = "textTopFire";
            this.textTopFire.ReadOnly = true;
            this.textTopFire.Size = new System.Drawing.Size(83, 23);
            this.textTopFire.TabIndex = 17;
            this.textTopFire.TabStop = false;
            // 
            // textBoxBirim
            // 
            this.textBoxBirim.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxBirim.Location = new System.Drawing.Point(188, 231);
            this.textBoxBirim.Name = "textBoxBirim";
            this.textBoxBirim.ReadOnly = true;
            this.textBoxBirim.Size = new System.Drawing.Size(45, 23);
            this.textBoxBirim.TabIndex = 22;
            this.textBoxBirim.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.Text = "Top. H.Miktar :";
            // 
            // textBoxTopBirim
            // 
            this.textBoxTopBirim.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxTopBirim.Location = new System.Drawing.Point(188, 257);
            this.textBoxTopBirim.Name = "textBoxTopBirim";
            this.textBoxTopBirim.ReadOnly = true;
            this.textBoxTopBirim.Size = new System.Drawing.Size(45, 23);
            this.textBoxTopBirim.TabIndex = 25;
            this.textBoxTopBirim.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 124);
            this.panel1.Visible = false;
            // 
            // listView2
            // 
            this.listView2.Columns.Add(this.columnHeader3);
            this.listView2.Columns.Add(this.columnHeader4);
            this.listView2.Columns.Add(this.columnHeader5);
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(230, 98);
            this.listView2.TabIndex = 14;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 3;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "HurdaNedeni";
            this.columnHeader4.Width = 143;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Miktar";
            this.columnHeader5.Width = 80;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(140, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tamam";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "Seçileni Sil";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 26);
            // 
            // FormFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(238, 291);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTopBirim);
            this.Controls.Add(this.textBoxBirim);
            this.Controls.Add(this.textTopFire);
            this.Controls.Add(this.textMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDurus);
            this.Controls.Add(this.txtHAd);
            this.Controls.Add(this.txtHKod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIstasyon);
            this.Controls.Add(this.txtTAd);
            this.Controls.Add(this.txtTKod);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFire";
            this.Text = "FormFire";
            this.Load += new System.EventHandler(this.FormFire_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIstasyon;
        private System.Windows.Forms.TextBox txtTAd;
        private System.Windows.Forms.TextBox txtTKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDurus;
        private System.Windows.Forms.TextBox txtHAd;
        private System.Windows.Forms.TextBox txtHKod;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMiktar;
        private System.Windows.Forms.TextBox textTopFire;
        private System.Windows.Forms.TextBox textBoxBirim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTopBirim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
    }
}