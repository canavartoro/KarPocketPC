namespace AmbarPPC
{
   partial class URETIM
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
          this.buttonDurus = new System.Windows.Forms.Button();
          this.button3 = new System.Windows.Forms.Button();
          this.button4 = new System.Windows.Forms.Button();
          this.button5 = new System.Windows.Forms.Button();
          this.button6 = new System.Windows.Forms.Button();
          this.SuspendLayout();
          // 
          // button_1
          // 
          this.button_1.Location = new System.Drawing.Point(22, 3);
          this.button_1.Name = "button_1";
          this.button_1.Size = new System.Drawing.Size(177, 20);
          this.button_1.TabIndex = 0;
          this.button_1.Text = "ÜRETİM GİRİŞİ(1)";
          this.button_1.Click += new System.EventHandler(this.button_1_Click);
          this.button_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // button_2
          // 
          this.button_2.Location = new System.Drawing.Point(22, 26);
          this.button_2.Name = "button_2";
          this.button_2.Size = new System.Drawing.Size(177, 20);
          this.button_2.TabIndex = 2;
          this.button_2.Text = "PALET TRANSFER(2)";
          this.button_2.Click += new System.EventHandler(this.button_2_Click);
          this.button_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // button_0
          // 
          this.button_0.Location = new System.Drawing.Point(22, 190);
          this.button_0.Name = "button_0";
          this.button_0.Size = new System.Drawing.Size(177, 24);
          this.button_0.TabIndex = 4;
          this.button_0.Text = "ÇIK(0)";
          this.button_0.Click += new System.EventHandler(this.button_0_Click);
          this.button_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // button1
          // 
          this.button1.Location = new System.Drawing.Point(22, 49);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(177, 20);
          this.button1.TabIndex = 5;
          this.button1.Text = "KAVİS ÜRETİM(3)";
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // button2
          // 
          this.button2.Location = new System.Drawing.Point(22, 72);
          this.button2.Name = "button2";
          this.button2.Size = new System.Drawing.Size(177, 20);
          this.button2.TabIndex = 6;
          this.button2.Text = "ÜRETİM GİRİŞİ DÜZELTME";
          this.button2.Click += new System.EventHandler(this.button2_Click);
          // 
          // buttonDurus
          // 
          this.buttonDurus.Location = new System.Drawing.Point(22, 140);
          this.buttonDurus.Name = "buttonDurus";
          this.buttonDurus.Size = new System.Drawing.Size(73, 20);
          this.buttonDurus.TabIndex = 6;
          this.buttonDurus.Text = "DURUŞ";
          this.buttonDurus.Click += new System.EventHandler(this.buttonDurus_Click);
          // 
          // button3
          // 
          this.button3.Location = new System.Drawing.Point(126, 140);
          this.button3.Name = "button3";
          this.button3.Size = new System.Drawing.Size(73, 20);
          this.button3.TabIndex = 6;
          this.button3.Text = "HURDA";
          this.button3.Click += new System.EventHandler(this.button3_Click);
          // 
          // button4
          // 
          this.button4.Location = new System.Drawing.Point(22, 95);
          this.button4.Name = "button4";
          this.button4.Size = new System.Drawing.Size(177, 20);
          this.button4.TabIndex = 6;
          this.button4.Text = "OTOMASYON İŞLEMLERİ";
          this.button4.Click += new System.EventHandler(this.button4_Click);
          // 
          // button5
          // 
          this.button5.Location = new System.Drawing.Point(22, 117);
          this.button5.Name = "button5";
          this.button5.Size = new System.Drawing.Size(177, 20);
          this.button5.TabIndex = 6;
          this.button5.Text = "İŞ EMRİ PERSONEL ATAMA";
          this.button5.Click += new System.EventHandler(this.button5_Click);
          // 
          // button6
          // 
          this.button6.Location = new System.Drawing.Point(22, 163);
          this.button6.Name = "button6";
          this.button6.Size = new System.Drawing.Size(177, 20);
          this.button6.TabIndex = 7;
          this.button6.Text = "GENEL ÜRETİM";
          this.button6.Click += new System.EventHandler(this.button6_Click);
          // 
          // URETIM
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
          this.BackColor = System.Drawing.Color.White;
          this.ClientSize = new System.Drawing.Size(638, 455);
          this.Controls.Add(this.button6);
          this.Controls.Add(this.button3);
          this.Controls.Add(this.buttonDurus);
          this.Controls.Add(this.button5);
          this.Controls.Add(this.button4);
          this.Controls.Add(this.button2);
          this.Controls.Add(this.button1);
          this.Controls.Add(this.button_0);
          this.Controls.Add(this.button_2);
          this.Controls.Add(this.button_1);
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "URETIM";
          this.Text = "Üretim";
          this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
          this.Load += new System.EventHandler(this.URETIM_Load);
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button button_2;
      private System.Windows.Forms.Button button_0;
      protected internal System.Windows.Forms.Button button_1;
      private System.Windows.Forms.Button button1;
       private System.Windows.Forms.Button button2;
       private System.Windows.Forms.Button buttonDurus;
       private System.Windows.Forms.Button button3;
       private System.Windows.Forms.Button button4;
       private System.Windows.Forms.Button button5;
       private System.Windows.Forms.Button button6;
   }
}