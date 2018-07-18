namespace AmbarPPC
{
    partial class Paketleme
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
            this.buttonPalet = new System.Windows.Forms.Button();
            this.textPalet = new System.Windows.Forms.TextBox();
            this.buttonOperasyon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTPalet = new System.Windows.Forms.Button();
            this.buttonKasa = new System.Windows.Forms.Button();
            this.buttonTKasa = new System.Windows.Forms.Button();
            this.textKasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnSeriliBarkod = new System.Windows.Forms.ColumnHeader();
            this.columnIsEmri = new System.Windows.Forms.ColumnHeader();
            this.columnStokKodu = new System.Windows.Forms.ColumnHeader();
            this.columnStokAdi = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.textSeri = new System.Windows.Forms.TextBox();
            this.buttonSeri = new System.Windows.Forms.Button();
            this.buttonTSeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelUst = new System.Windows.Forms.Panel();
            this.labelUretimID = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.PnlSor = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSeri1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKasadakalan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDepodanEklenen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGercekMik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKala = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panelUst.SuspendLayout();
            this.PnlSor.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPalet
            // 
            this.buttonPalet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPalet.Location = new System.Drawing.Point(167, 0);
            this.buttonPalet.Name = "buttonPalet";
            this.buttonPalet.Size = new System.Drawing.Size(33, 23);
            this.buttonPalet.TabIndex = 2;
            this.buttonPalet.Text = ">>";
            this.buttonPalet.Click += new System.EventHandler(this.buttonPalet_Click);
            // 
            // textPalet
            // 
            this.textPalet.BackColor = System.Drawing.Color.Yellow;
            this.textPalet.Location = new System.Drawing.Point(49, 0);
            this.textPalet.Name = "textPalet";
            this.textPalet.Size = new System.Drawing.Size(119, 23);
            this.textPalet.TabIndex = 1;
            this.textPalet.TextChanged += new System.EventHandler(this.textPalet_TextChanged);
            this.textPalet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textPalet_KeyUp);
            this.textPalet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPalet_KeyPress);
            // 
            // buttonOperasyon
            // 
            this.buttonOperasyon.Location = new System.Drawing.Point(3, 261);
            this.buttonOperasyon.Name = "buttonOperasyon";
            this.buttonOperasyon.Size = new System.Drawing.Size(66, 31);
            this.buttonOperasyon.TabIndex = 12;
            this.buttonOperasyon.Text = "OP. BAÞ";
            this.buttonOperasyon.Click += new System.EventHandler(this.buttonOperasyon_Click);
            this.buttonOperasyon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonOperasyon_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.Text = "Palet";
            // 
            // buttonTPalet
            // 
            this.buttonTPalet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonTPalet.Location = new System.Drawing.Point(200, 0);
            this.buttonTPalet.Name = "buttonTPalet";
            this.buttonTPalet.Size = new System.Drawing.Size(33, 23);
            this.buttonTPalet.TabIndex = 3;
            this.buttonTPalet.Text = "T";
            this.buttonTPalet.Click += new System.EventHandler(this.buttonTPalet_Click);
            // 
            // buttonKasa
            // 
            this.buttonKasa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonKasa.Location = new System.Drawing.Point(167, 23);
            this.buttonKasa.Name = "buttonKasa";
            this.buttonKasa.Size = new System.Drawing.Size(33, 23);
            this.buttonKasa.TabIndex = 6;
            this.buttonKasa.Text = ">>";
            this.buttonKasa.Click += new System.EventHandler(this.buttonKasa_Click);
            // 
            // buttonTKasa
            // 
            this.buttonTKasa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonTKasa.Location = new System.Drawing.Point(200, 23);
            this.buttonTKasa.Name = "buttonTKasa";
            this.buttonTKasa.Size = new System.Drawing.Size(33, 23);
            this.buttonTKasa.TabIndex = 6;
            this.buttonTKasa.Text = "T";
            this.buttonTKasa.Click += new System.EventHandler(this.buttonTKasa_Click);
            // 
            // textKasa
            // 
            this.textKasa.BackColor = System.Drawing.Color.Khaki;
            this.textKasa.Location = new System.Drawing.Point(49, 23);
            this.textKasa.Name = "textKasa";
            this.textKasa.Size = new System.Drawing.Size(119, 23);
            this.textKasa.TabIndex = 4;
            this.textKasa.TextChanged += new System.EventHandler(this.textKasa_TextChanged);
            this.textKasa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textKasa_KeyUp);
            this.textKasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKasa_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.Text = "Kasa";
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnSeriliBarkod);
            this.listView1.Columns.Add(this.columnIsEmri);
            this.listView1.Columns.Add(this.columnStokKodu);
            this.listView1.Columns.Add(this.columnStokAdi);
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(3, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(232, 189);
            this.listView1.TabIndex = 10;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnSeriliBarkod
            // 
            this.columnSeriliBarkod.Text = "SeriliBarkod";
            this.columnSeriliBarkod.Width = 125;
            // 
            // columnIsEmri
            // 
            this.columnIsEmri.Text = "IsEmri";
            this.columnIsEmri.Width = 60;
            // 
            // columnStokKodu
            // 
            this.columnStokKodu.Text = "StokKodu";
            this.columnStokKodu.Width = 50;
            // 
            // columnStokAdi
            // 
            this.columnStokAdi.Text = "StokAdi";
            this.columnStokAdi.Width = 100;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.Text = "Seri";
            // 
            // textSeri
            // 
            this.textSeri.BackColor = System.Drawing.Color.Khaki;
            this.textSeri.Enabled = false;
            this.textSeri.Location = new System.Drawing.Point(51, 52);
            this.textSeri.Name = "textSeri";
            this.textSeri.Size = new System.Drawing.Size(119, 23);
            this.textSeri.TabIndex = 7;            
            this.textSeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSeri_KeyPress);
            // 
            // buttonSeri
            // 
            this.buttonSeri.Enabled = false;
            this.buttonSeri.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSeri.Location = new System.Drawing.Point(589, 65);
            this.buttonSeri.Name = "buttonSeri";
            this.buttonSeri.Size = new System.Drawing.Size(33, 23);
            this.buttonSeri.TabIndex = 8;
            this.buttonSeri.Text = ">>";
            this.buttonSeri.Click += new System.EventHandler(this.buttonSeri_Click);
            // 
            // buttonTSeri
            // 
            this.buttonTSeri.Enabled = false;
            this.buttonTSeri.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonTSeri.Location = new System.Drawing.Point(589, 94);
            this.buttonTSeri.Name = "buttonTSeri";
            this.buttonTSeri.Size = new System.Drawing.Size(33, 23);
            this.buttonTSeri.TabIndex = 9;
            this.buttonTSeri.Text = "T";
            this.buttonTSeri.Click += new System.EventHandler(this.buttonTSeri_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(185, 262);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(50, 31);
            this.buttonKaydet.TabIndex = 11;
            this.buttonKaydet.Text = "KAPAT";
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "OP. BÝTÝR";
            this.button1.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.textKasa);
            this.panelUst.Controls.Add(this.buttonPalet);
            this.panelUst.Controls.Add(this.buttonTPalet);
            this.panelUst.Controls.Add(this.label2);
            this.panelUst.Controls.Add(this.buttonKasa);
            this.panelUst.Controls.Add(this.label1);
            this.panelUst.Controls.Add(this.textPalet);
            this.panelUst.Controls.Add(this.buttonTKasa);
            this.panelUst.Enabled = false;
            this.panelUst.Location = new System.Drawing.Point(2, 2);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(233, 49);
            // 
            // labelUretimID
            // 
            this.labelUretimID.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelUretimID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelUretimID.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUretimID.Location = new System.Drawing.Point(69, 264);
            this.labelUretimID.Name = "labelUretimID";
            this.labelUretimID.Size = new System.Drawing.Size(75, 28);
            this.labelUretimID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelRows
            // 
            this.labelRows.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelRows.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelRows.ForeColor = System.Drawing.SystemColors.Window;
            this.labelRows.Location = new System.Drawing.Point(144, 263);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(45, 29);
            this.labelRows.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PnlSor
            // 
            this.PnlSor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlSor.Controls.Add(this.button4);
            this.PnlSor.Controls.Add(this.txtSeri1);
            this.PnlSor.Controls.Add(this.label4);
            this.PnlSor.Controls.Add(this.lblKasadakalan);
            this.PnlSor.Controls.Add(this.label7);
            this.PnlSor.Controls.Add(this.button2);
            this.PnlSor.Controls.Add(this.txtDepodanEklenen);
            this.PnlSor.Controls.Add(this.label6);
            this.PnlSor.Controls.Add(this.txtGercekMik);
            this.PnlSor.Controls.Add(this.label5);
            this.PnlSor.Controls.Add(this.lblKala);
            this.PnlSor.Location = new System.Drawing.Point(422, 239);
            this.PnlSor.Name = "PnlSor";
            this.PnlSor.Size = new System.Drawing.Size(203, 189);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "ÇIK";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSeri1
            // 
            this.txtSeri1.BackColor = System.Drawing.Color.Khaki;
            this.txtSeri1.Enabled = false;
            this.txtSeri1.Location = new System.Drawing.Point(44, 134);
            this.txtSeri1.Name = "txtSeri1";
            this.txtSeri1.Size = new System.Drawing.Size(119, 23);
            this.txtSeri1.TabIndex = 20;
            this.txtSeri1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSeri1_KeyUp);
            this.txtSeri1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeri1_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 16);
            this.label4.Text = "Seri";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKasadakalan
            // 
            this.lblKasadakalan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblKasadakalan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblKasadakalan.ForeColor = System.Drawing.Color.White;
            this.lblKasadakalan.Location = new System.Drawing.Point(111, 4);
            this.lblKasadakalan.Name = "lblKasadakalan";
            this.lblKasadakalan.Size = new System.Drawing.Size(85, 19);
            this.lblKasadakalan.Text = "0";
            this.lblKasadakalan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 9);
            this.label7.Text = "-------------------------------------------------------------";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Kaydet";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDepodanEklenen
            // 
            this.txtDepodanEklenen.Location = new System.Drawing.Point(19, 92);
            this.txtDepodanEklenen.Name = "txtDepodanEklenen";
            this.txtDepodanEklenen.Size = new System.Drawing.Size(165, 23);
            this.txtDepodanEklenen.TabIndex = 4;
            this.txtDepodanEklenen.TextChanged += new System.EventHandler(this.txtDepodanEklenen_TextChanged);
            this.txtDepodanEklenen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDepodanEklenen_KeyUp);
            this.txtDepodanEklenen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGercekMik_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 15);
            this.label6.Text = "Depodan Kasaya Eklenen";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGercekMik
            // 
            this.txtGercekMik.Location = new System.Drawing.Point(19, 51);
            this.txtGercekMik.Name = "txtGercekMik";
            this.txtGercekMik.Size = new System.Drawing.Size(165, 23);
            this.txtGercekMik.TabIndex = 2;
            this.txtGercekMik.TextChanged += new System.EventHandler(this.txtGercekMik_TextChanged);
            this.txtGercekMik.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGercekMik_KeyUp);
            this.txtGercekMik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGercekMik_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 16);
            this.label5.Text = "Kasada Kalan Gerçek Miktar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKala
            // 
            this.lblKala.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblKala.ForeColor = System.Drawing.Color.White;
            this.lblKala.Location = new System.Drawing.Point(4, 4);
            this.lblKala.Name = "lblKala";
            this.lblKala.Size = new System.Drawing.Size(112, 20);
            this.lblKala.Text = "Kasada Kalan..:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(171, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 22);
            this.button3.TabIndex = 14;
            this.button3.Text = "Kasa Düz.";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Paketleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PnlSor);
            this.Controls.Add(this.labelUretimID);
            this.Controls.Add(this.panelUst);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOperasyon);
            this.Controls.Add(this.textSeri);
            this.Controls.Add(this.buttonTSeri);
            this.Controls.Add(this.buttonSeri);
            this.Controls.Add(this.labelRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paketleme";
            this.Text = "Paketleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Paketleme_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Paketleme_KeyDown);
            this.panelUst.ResumeLayout(false);
            this.PnlSor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPalet;
        private System.Windows.Forms.TextBox textPalet;
        private System.Windows.Forms.Button buttonOperasyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTPalet;
        private System.Windows.Forms.Button buttonKasa;
        private System.Windows.Forms.Button buttonTKasa;
        private System.Windows.Forms.TextBox textKasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnSeriliBarkod;
        private System.Windows.Forms.ColumnHeader columnIsEmri;
        private System.Windows.Forms.ColumnHeader columnStokKodu;
        private System.Windows.Forms.ColumnHeader columnStokAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSeri;
        private System.Windows.Forms.Button buttonSeri;
        private System.Windows.Forms.Button buttonTSeri;
        private System.Windows.Forms.Button buttonKaydet;
       private System.Windows.Forms.Button button1;
       private System.Windows.Forms.Panel panelUst;
       private System.Windows.Forms.Label labelUretimID;
       private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Panel PnlSor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKala;
        private System.Windows.Forms.TextBox txtGercekMik;
        private System.Windows.Forms.TextBox txtDepodanEklenen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblKasadakalan;
        private System.Windows.Forms.TextBox txtSeri1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
       private System.Windows.Forms.Button button4;
    }
}