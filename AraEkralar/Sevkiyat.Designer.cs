namespace AmbarPPC
{
   partial class Sevkiyat
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
          this.button_1 = new System.Windows.Forms.Button();
          this.button_2 = new System.Windows.Forms.Button();
          this.button_0 = new System.Windows.Forms.Button();
          this.button1 = new System.Windows.Forms.Button();
          this.button2 = new System.Windows.Forms.Button();
          this.button3 = new System.Windows.Forms.Button();
          this.btnBolunmusSevkIptal = new System.Windows.Forms.Button();
          this.btnSerilerArasiTransfer = new System.Windows.Forms.Button();
          this.SuspendLayout();
          // 
          // button_1
          // 
          this.button_1.Location = new System.Drawing.Point(22, 12);
          this.button_1.Name = "button_1";
          this.button_1.Size = new System.Drawing.Size(179, 22);
          this.button_1.TabIndex = 10;
          this.button_1.Text = "PALET TRANSFER(1)";
          this.button_1.Click += new System.EventHandler(this.button_1_Click);
          this.button_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // button_2
          // 
          this.button_2.Location = new System.Drawing.Point(22, 180);
          this.button_2.Name = "button_2";
          this.button_2.Size = new System.Drawing.Size(179, 22);
          this.button_2.TabIndex = 11;
          this.button_2.Text = "SEVK EMİRLERİ(3)";
          this.button_2.Visible = false;
          this.button_2.Click += new System.EventHandler(this.button_2_Click);
          this.button_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // button_0
          // 
          this.button_0.Location = new System.Drawing.Point(22, 210);
          this.button_0.Name = "button_0";
          this.button_0.Size = new System.Drawing.Size(179, 22);
          this.button_0.TabIndex = 12;
          this.button_0.Text = "ÇIK(0)";
          this.button_0.Click += new System.EventHandler(this.button_0_Click);
          this.button_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // button1
          // 
          this.button1.Location = new System.Drawing.Point(22, 97);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(179, 22);
          this.button1.TabIndex = 13;
          this.button1.Text = "SEVK İPTAL(3)";
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // button2
          // 
          this.button2.Location = new System.Drawing.Point(22, 40);
          this.button2.Name = "button2";
          this.button2.Size = new System.Drawing.Size(179, 22);
          this.button2.TabIndex = 14;
          this.button2.Text = "SEVK EMİRLERİ(2)";
          this.button2.Click += new System.EventHandler(this.button2_Click);
          // 
          // button3
          // 
          this.button3.Location = new System.Drawing.Point(22, 152);
          this.button3.Name = "button3";
          this.button3.Size = new System.Drawing.Size(179, 22);
          this.button3.TabIndex = 15;
          this.button3.Text = "SERİ DÜZELTME (5)";
          this.button3.Visible = false;
          this.button3.Click += new System.EventHandler(this.button3_Click);
          // 
          // btnBolunmusSevkIptal
          // 
          this.btnBolunmusSevkIptal.Location = new System.Drawing.Point(22, 125);
          this.btnBolunmusSevkIptal.Name = "btnBolunmusSevkIptal";
          this.btnBolunmusSevkIptal.Size = new System.Drawing.Size(179, 22);
          this.btnBolunmusSevkIptal.TabIndex = 16;
          this.btnBolunmusSevkIptal.Text = "BOLUNMUS SEVK İPTAL(4)";
          this.btnBolunmusSevkIptal.Click += new System.EventHandler(this.btnBolunmusSevkIptal_Click);
          // 
          // btnSerilerArasiTransfer
          // 
          this.btnSerilerArasiTransfer.Location = new System.Drawing.Point(22, 67);
          this.btnSerilerArasiTransfer.Name = "btnSerilerArasiTransfer";
          this.btnSerilerArasiTransfer.Size = new System.Drawing.Size(179, 24);
          this.btnSerilerArasiTransfer.TabIndex = 17;
          this.btnSerilerArasiTransfer.Text = "SERİLER ARASI TRANSFER(2)";
          this.btnSerilerArasiTransfer.Click += new System.EventHandler(this.btnSerilerArasiTransfer_Click);
          // 
          // Sevkiyat
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
          this.BackColor = System.Drawing.Color.White;
          this.ClientSize = new System.Drawing.Size(638, 455);
          this.Controls.Add(this.btnSerilerArasiTransfer);
          this.Controls.Add(this.btnBolunmusSevkIptal);
          this.Controls.Add(this.button3);
          this.Controls.Add(this.button2);
          this.Controls.Add(this.button1);
          this.Controls.Add(this.button_0);
          this.Controls.Add(this.button_2);
          this.Controls.Add(this.button_1);
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "Sevkiyat";
          this.Text = "Sevkiyat";
          this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
          this.Load += new System.EventHandler(this.Sevkiyat_Load);
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button button_1;
      private System.Windows.Forms.Button button_2;
      private System.Windows.Forms.Button button_0;
       private System.Windows.Forms.Button button1;
       private System.Windows.Forms.Button button2;
       private System.Windows.Forms.Button button3;
       private System.Windows.Forms.Button btnBolunmusSevkIptal;
       private System.Windows.Forms.Button btnSerilerArasiTransfer;
   }
}