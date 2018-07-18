namespace AmbarPPC
{
    partial class FormDurus
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
            this.txtTKod = new System.Windows.Forms.TextBox();
            this.txtTAd = new System.Windows.Forms.TextBox();
            this.buttonIstasyon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDKod = new System.Windows.Forms.TextBox();
            this.txtDAd = new System.Windows.Forms.TextBox();
            this.buttonDurus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBag = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.butCikis = new System.Windows.Forms.Button();
            this.butSil = new System.Windows.Forms.Button();
            this.butBitir = new System.Windows.Forms.Button();
            this.butBaslat = new System.Windows.Forms.Button();
            this.butDuzelt = new System.Windows.Forms.Button();
            this.textBas = new System.Windows.Forms.TextBox();
            this.textBit = new System.Windows.Forms.TextBox();
            this.checkBitis = new System.Windows.Forms.CheckBox();
            this.panelDuruslar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.panelDuruslar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTKod
            // 
            this.txtTKod.Location = new System.Drawing.Point(108, 37);
            this.txtTKod.Name = "txtTKod";
            this.txtTKod.Size = new System.Drawing.Size(86, 23);
            this.txtTKod.TabIndex = 1;
            this.txtTKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTKod_KeyPress);
            // 
            // txtTAd
            // 
            this.txtTAd.Location = new System.Drawing.Point(0, 66);
            this.txtTAd.Name = "txtTAd";
            this.txtTAd.ReadOnly = true;
            this.txtTAd.Size = new System.Drawing.Size(232, 23);
            this.txtTAd.TabIndex = 2;
            this.txtTAd.TabStop = false;
            // 
            // buttonIstasyon
            // 
            this.buttonIstasyon.Location = new System.Drawing.Point(193, 37);
            this.buttonIstasyon.Name = "buttonIstasyon";
            this.buttonIstasyon.Size = new System.Drawing.Size(39, 23);
            this.buttonIstasyon.TabIndex = 3;
            this.buttonIstasyon.Text = "Bul";
            this.buttonIstasyon.Click += new System.EventHandler(this.buttonIstasyon_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.Text = "İstasyon Kodu";
            // 
            // txtDKod
            // 
            this.txtDKod.BackColor = System.Drawing.Color.Yellow;
            this.txtDKod.Location = new System.Drawing.Point(108, 95);
            this.txtDKod.Name = "txtDKod";
            this.txtDKod.Size = new System.Drawing.Size(86, 23);
            this.txtDKod.TabIndex = 2;
            this.txtDKod.TabStop = false;
            this.txtDKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDKod_KeyPress);
            // 
            // txtDAd
            // 
            this.txtDAd.Location = new System.Drawing.Point(0, 124);
            this.txtDAd.Name = "txtDAd";
            this.txtDAd.ReadOnly = true;
            this.txtDAd.Size = new System.Drawing.Size(232, 23);
            this.txtDAd.TabIndex = 2;
            this.txtDAd.TabStop = false;
            // 
            // buttonDurus
            // 
            this.buttonDurus.Location = new System.Drawing.Point(193, 95);
            this.buttonDurus.Name = "buttonDurus";
            this.buttonDurus.Size = new System.Drawing.Size(39, 23);
            this.buttonDurus.TabIndex = 3;
            this.buttonDurus.Text = "Bul";
            this.buttonDurus.Click += new System.EventHandler(this.buttonDurus_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.Text = "Duruş Kodu";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.Text = "Başlangıç";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.Text = "Bitiş";
            // 
            // chkBag
            // 
            this.chkBag.Location = new System.Drawing.Point(75, 272);
            this.chkBag.Name = "chkBag";
            this.chkBag.Size = new System.Drawing.Size(160, 20);
            this.chkBag.TabIndex = 17;
            this.chkBag.Text = "İş Emrinden Bağımsız";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.Text = "Duruş Süre";
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(75, 213);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(157, 23);
            this.txtSure.TabIndex = 23;
            // 
            // butCikis
            // 
            this.butCikis.Location = new System.Drawing.Point(193, 0);
            this.butCikis.Name = "butCikis";
            this.butCikis.Size = new System.Drawing.Size(45, 20);
            this.butCikis.TabIndex = 30;
            this.butCikis.Text = "ÇIKIŞ";
            this.butCikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // butSil
            // 
            this.butSil.Location = new System.Drawing.Point(157, 0);
            this.butSil.Name = "butSil";
            this.butSil.Size = new System.Drawing.Size(35, 20);
            this.butSil.TabIndex = 30;
            this.butSil.Text = "X";
            this.butSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // butBitir
            // 
            this.butBitir.Location = new System.Drawing.Point(112, 0);
            this.butBitir.Name = "butBitir";
            this.butBitir.Size = new System.Drawing.Size(44, 20);
            this.butBitir.TabIndex = 30;
            this.butBitir.Text = "BİTİR";
            this.butBitir.Click += new System.EventHandler(this.button3_Click);
            // 
            // butBaslat
            // 
            this.butBaslat.Location = new System.Drawing.Point(0, 0);
            this.butBaslat.Name = "butBaslat";
            this.butBaslat.Size = new System.Drawing.Size(55, 20);
            this.butBaslat.TabIndex = 30;
            this.butBaslat.Text = "BAŞLAT";
            this.butBaslat.Click += new System.EventHandler(this.button4_Click);
            // 
            // butDuzelt
            // 
            this.butDuzelt.Location = new System.Drawing.Point(56, 0);
            this.butDuzelt.Name = "butDuzelt";
            this.butDuzelt.Size = new System.Drawing.Size(55, 20);
            this.butDuzelt.TabIndex = 30;
            this.butDuzelt.Text = "DÜZELT";
            this.butDuzelt.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBas
            // 
            this.textBas.BackColor = System.Drawing.Color.Salmon;
            this.textBas.Location = new System.Drawing.Point(75, 153);
            this.textBas.Name = "textBas";
            this.textBas.Size = new System.Drawing.Size(58, 23);
            this.textBas.TabIndex = 31;
            this.textBas.TabStop = false;
            this.textBas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBas_KeyPress);
            // 
            // textBit
            // 
            this.textBit.BackColor = System.Drawing.Color.Salmon;
            this.textBit.Location = new System.Drawing.Point(75, 182);
            this.textBit.Name = "textBit";
            this.textBit.Size = new System.Drawing.Size(58, 23);
            this.textBit.TabIndex = 31;
            this.textBit.TabStop = false;
            this.textBit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBas_KeyPress);
            // 
            // checkBitis
            // 
            this.checkBitis.Checked = true;
            this.checkBitis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBitis.Location = new System.Drawing.Point(135, 182);
            this.checkBitis.Name = "checkBitis";
            this.checkBitis.Size = new System.Drawing.Size(100, 20);
            this.checkBitis.TabIndex = 37;
            this.checkBitis.Text = "Bitiş";
            this.checkBitis.CheckStateChanged += new System.EventHandler(this.checkBitis_CheckStateChanged);
            // 
            // panelDuruslar
            // 
            this.panelDuruslar.BackColor = System.Drawing.Color.White;
            this.panelDuruslar.Controls.Add(this.button3);
            this.panelDuruslar.Controls.Add(this.button2);
            this.panelDuruslar.Controls.Add(this.button1);
            this.panelDuruslar.Controls.Add(this.listView1);
            this.panelDuruslar.Location = new System.Drawing.Point(384, 134);
            this.panelDuruslar.Name = "panelDuruslar";
            this.panelDuruslar.Size = new System.Drawing.Size(232, 200);
            this.panelDuruslar.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 20);
            this.button3.TabIndex = 31;
            this.button3.Text = "TÜMÜNÜ SİL";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 20);
            this.button2.TabIndex = 31;
            this.button2.Text = "SİL";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 20);
            this.button1.TabIndex = 31;
            this.button1.Text = "KAPAT";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.Columns.Add(this.columnHeader4);
            this.listView1.Columns.Add(this.columnHeader5);
            this.listView1.Columns.Add(this.columnHeader6);
            this.listView1.Location = new System.Drawing.Point(3, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(226, 175);
            this.listView1.TabIndex = 0;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kod";
            this.columnHeader1.Width = 60;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Baş";
            this.columnHeader2.Width = 60;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bit";
            this.columnHeader3.Width = 60;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Süre";
            this.columnHeader4.Width = 60;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ad";
            this.columnHeader5.Width = 60;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "id";
            this.columnHeader6.Width = 0;
            // 
            // FormDurus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 422);
            this.ControlBox = false;
            this.Controls.Add(this.panelDuruslar);
            this.Controls.Add(this.checkBitis);
            this.Controls.Add(this.textBit);
            this.Controls.Add(this.textBas);
            this.Controls.Add(this.butBaslat);
            this.Controls.Add(this.butDuzelt);
            this.Controls.Add(this.butBitir);
            this.Controls.Add(this.butSil);
            this.Controls.Add(this.butCikis);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkBag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDurus);
            this.Controls.Add(this.buttonIstasyon);
            this.Controls.Add(this.txtDAd);
            this.Controls.Add(this.txtDKod);
            this.Controls.Add(this.txtTAd);
            this.Controls.Add(this.txtTKod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDurus";
            this.Text = "İş Emri Duruş";
            this.Load += new System.EventHandler(this.FormDurus_Load);
            this.panelDuruslar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTKod;
        private System.Windows.Forms.TextBox txtTAd;
        private System.Windows.Forms.Button buttonIstasyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDKod;
        private System.Windows.Forms.TextBox txtDAd;
        private System.Windows.Forms.Button buttonDurus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Button butCikis;
        private System.Windows.Forms.Button butSil;
        private System.Windows.Forms.Button butBitir;
        private System.Windows.Forms.Button butBaslat;
        private System.Windows.Forms.Button butDuzelt;
        private System.Windows.Forms.TextBox textBas;
        private System.Windows.Forms.TextBox textBit;
        private System.Windows.Forms.CheckBox checkBitis;
        private System.Windows.Forms.Panel panelDuruslar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}