namespace AmbarPPC
{
   partial class StokD
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
          this.button_3 = new System.Windows.Forms.Button();
          this.button_4 = new System.Windows.Forms.Button();
          this.button_0 = new System.Windows.Forms.Button();
          this.SuspendLayout();
          // 
          // button_1
          // 
          this.button_1.Location = new System.Drawing.Point(24, 9);
          this.button_1.Name = "button_1";
          this.button_1.Size = new System.Drawing.Size(180, 24);
          this.button_1.TabIndex = 8;
          this.button_1.Text = "SERiSiZ TRANSFER(1)";
          this.button_1.Click += new System.EventHandler(this.button_1_Click);
          this.button_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // button_2
          // 
          this.button_2.Location = new System.Drawing.Point(24, 39);
          this.button_2.Name = "button_2";
          this.button_2.Size = new System.Drawing.Size(180, 24);
          this.button_2.TabIndex = 9;
          this.button_2.Text = "SERİLİ TRANSFER(2)";
          this.button_2.Click += new System.EventHandler(this.button_2_Click);
          this.button_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // button_3
          // 
          this.button_3.Location = new System.Drawing.Point(24, 69);
          this.button_3.Name = "button_3";
          this.button_3.Size = new System.Drawing.Size(180, 24);
          this.button_3.TabIndex = 10;
          this.button_3.Text = "AMBAR SAYIM(3)";
          this.button_3.Click += new System.EventHandler(this.button_3_Click);
          this.button_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // button_4
          // 
          this.button_4.Location = new System.Drawing.Point(24, 99);
          this.button_4.Name = "button_4";
          this.button_4.Size = new System.Drawing.Size(180, 24);
          this.button_4.TabIndex = 11;
          this.button_4.Text = "DEPO(4)";
          this.button_4.Click += new System.EventHandler(this.button_4_Click);
          this.button_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // button_0
          // 
          this.button_0.Location = new System.Drawing.Point(24, 148);
          this.button_0.Name = "button_0";
          this.button_0.Size = new System.Drawing.Size(180, 24);
          this.button_0.TabIndex = 12;
          this.button_0.Text = "ÇIK(0)";
          this.button_0.Click += new System.EventHandler(this.button_0_Click);
          this.button_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmm);
          // 
          // StokD
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
          this.BackColor = System.Drawing.Color.White;
          this.ClientSize = new System.Drawing.Size(638, 455);
          this.Controls.Add(this.button_0);
          this.Controls.Add(this.button_4);
          this.Controls.Add(this.button_1);
          this.Controls.Add(this.button_2);
          this.Controls.Add(this.button_3);
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "StokD";
          this.Text = "Stok";
          this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
          this.Load += new System.EventHandler(this.StokD_Load);
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button button_1;
      private System.Windows.Forms.Button button_2;
      private System.Windows.Forms.Button button_3;
      private System.Windows.Forms.Button button_4;
      private System.Windows.Forms.Button button_0;
   }
}