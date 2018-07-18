namespace AmbarPPC
{
   partial class KavisIcin
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
         this.Miktar = new System.Windows.Forms.TextBox();
         this.Birim = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.StokAdi = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.StokKodu = new System.Windows.Forms.TextBox();
         this.buttonPalet = new System.Windows.Forms.Button();
         this.buttonTPalet = new System.Windows.Forms.Button();
         this.SeriliBarkod = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.textMontajMiktar = new System.Windows.Forms.TextBox();
         this.label10 = new System.Windows.Forms.Label();
         this.buttonKaydet = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // Miktar
         // 
         this.Miktar.Location = new System.Drawing.Point(142, 90);
         this.Miktar.Name = "Miktar";
         this.Miktar.Size = new System.Drawing.Size(83, 23);
         this.Miktar.TabIndex = 107;
         // 
         // Birim
         // 
         this.Birim.BackColor = System.Drawing.Color.Salmon;
         this.Birim.Location = new System.Drawing.Point(57, 90);
         this.Birim.Name = "Birim";
         this.Birim.Size = new System.Drawing.Size(82, 23);
         this.Birim.TabIndex = 108;
         // 
         // label7
         // 
         this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
         this.label7.Location = new System.Drawing.Point(21, 98);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(63, 15);
         this.label7.Text = "Birim..:";
         // 
         // StokAdi
         // 
         this.StokAdi.BackColor = System.Drawing.Color.Salmon;
         this.StokAdi.Location = new System.Drawing.Point(57, 61);
         this.StokAdi.Name = "StokAdi";
         this.StokAdi.Size = new System.Drawing.Size(169, 23);
         this.StokAdi.TabIndex = 109;
         // 
         // label8
         // 
         this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
         this.label8.Location = new System.Drawing.Point(8, 72);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(66, 15);
         this.label8.Text = "StokAdi..:";
         // 
         // StokKodu
         // 
         this.StokKodu.BackColor = System.Drawing.Color.Salmon;
         this.StokKodu.Location = new System.Drawing.Point(57, 32);
         this.StokKodu.Name = "StokKodu";
         this.StokKodu.Size = new System.Drawing.Size(169, 23);
         this.StokKodu.TabIndex = 112;
         // 
         // buttonPalet
         // 
         this.buttonPalet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.buttonPalet.Location = new System.Drawing.Point(184, 3);
         this.buttonPalet.Name = "buttonPalet";
         this.buttonPalet.Size = new System.Drawing.Size(21, 23);
         this.buttonPalet.TabIndex = 105;
         this.buttonPalet.Text = ">>";
         this.buttonPalet.Click += new System.EventHandler(this.buttonPalet_Click);
         // 
         // buttonTPalet
         // 
         this.buttonTPalet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.buttonTPalet.Location = new System.Drawing.Point(205, 3);
         this.buttonTPalet.Name = "buttonTPalet";
         this.buttonTPalet.Size = new System.Drawing.Size(21, 23);
         this.buttonTPalet.TabIndex = 106;
         this.buttonTPalet.Text = "x";
         // 
         // SeriliBarkod
         // 
         this.SeriliBarkod.BackColor = System.Drawing.Color.Yellow;
         this.SeriliBarkod.Location = new System.Drawing.Point(57, 3);
         this.SeriliBarkod.Name = "SeriliBarkod";
         this.SeriliBarkod.Size = new System.Drawing.Size(127, 23);
         this.SeriliBarkod.TabIndex = 104;
         this.SeriliBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKasaNo_KeyPress);
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
         this.label1.Location = new System.Drawing.Point(25, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(49, 16);
         this.label1.Text = "Seri..:";
         // 
         // label6
         // 
         this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
         this.label6.Location = new System.Drawing.Point(-1, 42);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(60, 15);
         this.label6.Text = "StokKodu..:";
         // 
         // textMontajMiktar
         // 
         this.textMontajMiktar.Location = new System.Drawing.Point(57, 119);
         this.textMontajMiktar.Name = "textMontajMiktar";
         this.textMontajMiktar.Size = new System.Drawing.Size(168, 23);
         this.textMontajMiktar.TabIndex = 116;
         this.textMontajMiktar.TextChanged += new System.EventHandler(this.textMontajMiktar_TextChanged);
         this.textMontajMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMontajMiktar_KeyPress);
         // 
         // label10
         // 
         this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.label10.Location = new System.Drawing.Point(9, 128);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(56, 15);
         this.label10.Text = "Miktar..:";
         // 
         // buttonKaydet
         // 
         this.buttonKaydet.Enabled = false;
         this.buttonKaydet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.buttonKaydet.Location = new System.Drawing.Point(57, 148);
         this.buttonKaydet.Name = "buttonKaydet";
         this.buttonKaydet.Size = new System.Drawing.Size(80, 27);
         this.buttonKaydet.TabIndex = 117;
         this.buttonKaydet.Text = "KAYDET";
         this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
         // 
         // button4
         // 
         this.button4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.button4.Location = new System.Drawing.Point(146, 148);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(80, 27);
         this.button4.TabIndex = 118;
         this.button4.Text = "ÇIK";
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // KavisIcin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.AutoScroll = true;
         this.BackColor = System.Drawing.Color.Azure;
         this.ClientSize = new System.Drawing.Size(638, 455);
         this.ControlBox = false;
         this.Controls.Add(this.textMontajMiktar);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.buttonKaydet);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.Miktar);
         this.Controls.Add(this.Birim);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.StokAdi);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.StokKodu);
         this.Controls.Add(this.buttonPalet);
         this.Controls.Add(this.buttonTPalet);
         this.Controls.Add(this.SeriliBarkod);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label1);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "KavisIcin";
         this.Text = "Kavis Üret";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.KavisIcin_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox Miktar;
      private System.Windows.Forms.TextBox Birim;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox StokAdi;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox StokKodu;
      private System.Windows.Forms.Button buttonPalet;
      private System.Windows.Forms.Button buttonTPalet;
      private System.Windows.Forms.TextBox SeriliBarkod;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox textMontajMiktar;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Button buttonKaydet;
      private System.Windows.Forms.Button button4;
   }
}