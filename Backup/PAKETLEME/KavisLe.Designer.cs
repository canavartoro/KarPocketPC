namespace AmbarPPC
{
   partial class KavisLe
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
          this.textMontajMiktar = new System.Windows.Forms.TextBox();
          this.label10 = new System.Windows.Forms.Label();
          this.buttonKaydet = new System.Windows.Forms.Button();
          this.button4 = new System.Windows.Forms.Button();
          this.Birim = new System.Windows.Forms.TextBox();
          this.label7 = new System.Windows.Forms.Label();
          this.StokAdi = new System.Windows.Forms.TextBox();
          this.label8 = new System.Windows.Forms.Label();
          this.StokKodu = new System.Windows.Forms.TextBox();
          this.buttonCak = new System.Windows.Forms.Button();
          this.buttonTPalet = new System.Windows.Forms.Button();
          this.SeriliBarkod = new System.Windows.Forms.TextBox();
          this.label6 = new System.Windows.Forms.Label();
          this.label1 = new System.Windows.Forms.Label();
          this.Miktar = new System.Windows.Forms.TextBox();
          this.YSeri = new System.Windows.Forms.TextBox();
          this.label2 = new System.Windows.Forms.Label();
          this.textBoxPaet = new System.Windows.Forms.TextBox();
          this.label3 = new System.Windows.Forms.Label();
          this.SuspendLayout();
          // 
          // textMontajMiktar
          // 
          this.textMontajMiktar.Location = new System.Drawing.Point(58, 184);
          this.textMontajMiktar.Name = "textMontajMiktar";
          this.textMontajMiktar.Size = new System.Drawing.Size(168, 23);
          this.textMontajMiktar.TabIndex = 130;
          this.textMontajMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMontajMiktar_KeyPress);
          this.textMontajMiktar.TextChanged += new System.EventHandler(this.textMontajMiktar_TextChanged);
          // 
          // label10
          // 
          this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
          this.label10.Location = new System.Drawing.Point(9, 193);
          this.label10.Name = "label10";
          this.label10.Size = new System.Drawing.Size(56, 15);
          this.label10.Text = "Miktar..:";
          // 
          // buttonKaydet
          // 
          this.buttonKaydet.Enabled = false;
          this.buttonKaydet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
          this.buttonKaydet.Location = new System.Drawing.Point(58, 215);
          this.buttonKaydet.Name = "buttonKaydet";
          this.buttonKaydet.Size = new System.Drawing.Size(80, 24);
          this.buttonKaydet.TabIndex = 132;
          this.buttonKaydet.Text = "KAYDET";
          this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
          // 
          // button4
          // 
          this.button4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
          this.button4.Location = new System.Drawing.Point(146, 215);
          this.button4.Name = "button4";
          this.button4.Size = new System.Drawing.Size(80, 24);
          this.button4.TabIndex = 133;
          this.button4.Text = "ÇIK";
          this.button4.Click += new System.EventHandler(this.button4_Click);
          // 
          // Birim
          // 
          this.Birim.BackColor = System.Drawing.Color.Salmon;
          this.Birim.Location = new System.Drawing.Point(58, 90);
          this.Birim.Name = "Birim";
          this.Birim.Size = new System.Drawing.Size(82, 23);
          this.Birim.TabIndex = 127;
          // 
          // label7
          // 
          this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
          this.label7.Location = new System.Drawing.Point(22, 98);
          this.label7.Name = "label7";
          this.label7.Size = new System.Drawing.Size(63, 15);
          this.label7.Text = "Birim..:";
          // 
          // StokAdi
          // 
          this.StokAdi.BackColor = System.Drawing.Color.Salmon;
          this.StokAdi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
          this.StokAdi.Location = new System.Drawing.Point(58, 61);
          this.StokAdi.Multiline = true;
          this.StokAdi.Name = "StokAdi";
          this.StokAdi.Size = new System.Drawing.Size(169, 23);
          this.StokAdi.TabIndex = 128;
          // 
          // label8
          // 
          this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
          this.label8.Location = new System.Drawing.Point(9, 72);
          this.label8.Name = "label8";
          this.label8.Size = new System.Drawing.Size(66, 15);
          this.label8.Text = "StokAdi..:";
          // 
          // StokKodu
          // 
          this.StokKodu.BackColor = System.Drawing.Color.Salmon;
          this.StokKodu.Location = new System.Drawing.Point(58, 32);
          this.StokKodu.Name = "StokKodu";
          this.StokKodu.Size = new System.Drawing.Size(169, 23);
          this.StokKodu.TabIndex = 129;
          // 
          // buttonCak
          // 
          this.buttonCak.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
          this.buttonCak.Location = new System.Drawing.Point(185, 3);
          this.buttonCak.Name = "buttonCak";
          this.buttonCak.Size = new System.Drawing.Size(21, 23);
          this.buttonCak.TabIndex = 124;
          this.buttonCak.Text = ">>";
          this.buttonCak.Click += new System.EventHandler(this.buttonPalet_Click);
          // 
          // buttonTPalet
          // 
          this.buttonTPalet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
          this.buttonTPalet.Location = new System.Drawing.Point(206, 3);
          this.buttonTPalet.Name = "buttonTPalet";
          this.buttonTPalet.Size = new System.Drawing.Size(21, 23);
          this.buttonTPalet.TabIndex = 125;
          this.buttonTPalet.Text = "x";
          this.buttonTPalet.Click += new System.EventHandler(this.buttonTPalet_Click);
          // 
          // SeriliBarkod
          // 
          this.SeriliBarkod.BackColor = System.Drawing.Color.Yellow;
          this.SeriliBarkod.Location = new System.Drawing.Point(58, 3);
          this.SeriliBarkod.Name = "SeriliBarkod";
          this.SeriliBarkod.Size = new System.Drawing.Size(127, 23);
          this.SeriliBarkod.TabIndex = 123;
          this.SeriliBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeriliBarkod_KeyPress);
          // 
          // label6
          // 
          this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
          this.label6.Location = new System.Drawing.Point(0, 42);
          this.label6.Name = "label6";
          this.label6.Size = new System.Drawing.Size(60, 15);
          this.label6.Text = "StokKodu..:";
          // 
          // label1
          // 
          this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
          this.label1.Location = new System.Drawing.Point(26, 13);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(49, 16);
          this.label1.Text = "Seri..:";
          // 
          // Miktar
          // 
          this.Miktar.Location = new System.Drawing.Point(143, 90);
          this.Miktar.Name = "Miktar";
          this.Miktar.Size = new System.Drawing.Size(83, 23);
          this.Miktar.TabIndex = 126;
          // 
          // YSeri
          // 
          this.YSeri.BackColor = System.Drawing.Color.Yellow;
          this.YSeri.Location = new System.Drawing.Point(58, 131);
          this.YSeri.Name = "YSeri";
          this.YSeri.Size = new System.Drawing.Size(168, 23);
          this.YSeri.TabIndex = 139;
          this.YSeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YSeri_KeyPress);
          // 
          // label2
          // 
          this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
          this.label2.Location = new System.Drawing.Point(6, 141);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(56, 16);
          this.label2.Text = "YeniSeri..:";
          // 
          // textBoxPaet
          // 
          this.textBoxPaet.BackColor = System.Drawing.Color.Yellow;
          this.textBoxPaet.Location = new System.Drawing.Point(58, 158);
          this.textBoxPaet.Name = "textBoxPaet";
          this.textBoxPaet.Size = new System.Drawing.Size(168, 23);
          this.textBoxPaet.TabIndex = 147;
          this.textBoxPaet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPaet_KeyPress);
          // 
          // label3
          // 
          this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
          this.label3.Location = new System.Drawing.Point(6, 168);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(56, 16);
          this.label3.Text = "PaletNo..:";
          // 
          // KavisLe
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
          this.BackColor = System.Drawing.Color.Azure;
          this.ClientSize = new System.Drawing.Size(638, 455);
          this.ControlBox = false;
          this.Controls.Add(this.textBoxPaet);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.YSeri);
          this.Controls.Add(this.label2);
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
          this.Controls.Add(this.buttonCak);
          this.Controls.Add(this.buttonTPalet);
          this.Controls.Add(this.SeriliBarkod);
          this.Controls.Add(this.label6);
          this.Controls.Add(this.label1);
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "KavisLe";
          this.Text = "Kavisle";
          this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
          this.Load += new System.EventHandler(this.KavisLe_Load);
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox textMontajMiktar;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Button buttonKaydet;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.TextBox Birim;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox StokAdi;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox StokKodu;
      private System.Windows.Forms.Button buttonCak;
      private System.Windows.Forms.Button buttonTPalet;
      private System.Windows.Forms.TextBox SeriliBarkod;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox Miktar;
      private System.Windows.Forms.TextBox YSeri;
       private System.Windows.Forms.Label label2;
       private System.Windows.Forms.TextBox textBoxPaet;
       private System.Windows.Forms.Label label3;
   }
}