namespace AmbarPPC
{
    partial class FormHammadde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHammadde));
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
            this.txtHAd = new System.Windows.Forms.TextBox();
            this.txtHKod = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSicil = new System.Windows.Forms.TextBox();
            this.textTSicil = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.buttonEkle = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.Text = "İstasyon Kodu";
            // 
            // buttonIstasyon
            // 
            this.buttonIstasyon.Location = new System.Drawing.Point(196, 74);
            this.buttonIstasyon.Name = "buttonIstasyon";
            this.buttonIstasyon.Size = new System.Drawing.Size(39, 23);
            this.buttonIstasyon.TabIndex = 7;
            this.buttonIstasyon.Text = "Bul";
            this.buttonIstasyon.Click += new System.EventHandler(this.buttonIstasyon_Click);
            // 
            // txtTAd
            // 
            this.txtTAd.Location = new System.Drawing.Point(3, 100);
            this.txtTAd.Name = "txtTAd";
            this.txtTAd.ReadOnly = true;
            this.txtTAd.Size = new System.Drawing.Size(232, 23);
            this.txtTAd.TabIndex = 6;
            this.txtTAd.TabStop = false;
            // 
            // txtTKod
            // 
            this.txtTKod.Location = new System.Drawing.Point(118, 74);
            this.txtTKod.Name = "txtTKod";
            this.txtTKod.Size = new System.Drawing.Size(77, 23);
            this.txtTKod.TabIndex = 4;
            this.txtTKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTKod_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.Text = "Stok Kodu";
            // 
            // txtHAd
            // 
            this.txtHAd.Location = new System.Drawing.Point(3, 153);
            this.txtHAd.Name = "txtHAd";
            this.txtHAd.ReadOnly = true;
            this.txtHAd.Size = new System.Drawing.Size(232, 23);
            this.txtHAd.TabIndex = 9;
            this.txtHAd.TabStop = false;
            // 
            // txtHKod
            // 
            this.txtHKod.BackColor = System.Drawing.Color.Yellow;
            this.txtHKod.Location = new System.Drawing.Point(102, 127);
            this.txtHKod.Name = "txtHKod";
            this.txtHKod.Size = new System.Drawing.Size(133, 23);
            this.txtHKod.TabIndex = 10;
            this.txtHKod.TabStop = false;
            this.txtHKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHKod_KeyPress);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 26);
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
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.Text = "Sicil No";
            // 
            // txtSicil
            // 
            this.txtSicil.Location = new System.Drawing.Point(125, 25);
            this.txtSicil.Name = "txtSicil";
            this.txtSicil.Size = new System.Drawing.Size(113, 23);
            this.txtSicil.TabIndex = 32;
            this.txtSicil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSicil_KeyPress);
            // 
            // textTSicil
            // 
            this.textTSicil.Location = new System.Drawing.Point(6, 50);
            this.textTSicil.Name = "textTSicil";
            this.textTSicil.ReadOnly = true;
            this.textTSicil.Size = new System.Drawing.Size(232, 23);
            this.textTSicil.TabIndex = 39;
            this.textTSicil.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader6);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(5, 182);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(230, 93);
            this.listView1.TabIndex = 45;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stok Kodu";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Miktar";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stok Adi";
            this.columnHeader2.Width = 135;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.buttonEkle.Location = new System.Drawing.Point(71, 127);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(25, 23);
            this.buttonEkle.TabIndex = 51;
            this.buttonEkle.Text = "+";
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // FormHammadde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(238, 291);
            this.ControlBox = false;
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textTSicil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSicil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHAd);
            this.Controls.Add(this.txtHKod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIstasyon);
            this.Controls.Add(this.txtTAd);
            this.Controls.Add(this.txtTKod);
            this.Controls.Add(this.toolBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHammadde";
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
        private System.Windows.Forms.TextBox txtHAd;
        private System.Windows.Forms.TextBox txtHKod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSicil;
        private System.Windows.Forms.TextBox textTSicil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonEkle;
    }
}