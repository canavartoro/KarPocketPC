namespace AmbarPPC
{
   partial class MontajIslemleri
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
         this.button_9 = new System.Windows.Forms.Button();
         this.button_0 = new System.Windows.Forms.Button();
         this.button_8 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // button_9
         // 
         this.button_9.Location = new System.Drawing.Point(33, 35);
         this.button_9.Name = "button_9";
         this.button_9.Size = new System.Drawing.Size(168, 24);
         this.button_9.TabIndex = 12;
         this.button_9.Text = "MONTAJ(2)";
         this.button_9.Click += new System.EventHandler(this.button_9_Click);
         this.button_9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmmm);
         // 
         // button_0
         // 
         this.button_0.Location = new System.Drawing.Point(33, 189);
         this.button_0.Name = "button_0";
         this.button_0.Size = new System.Drawing.Size(168, 23);
         this.button_0.TabIndex = 11;
         this.button_0.Text = "ÇIK(0)";
         this.button_0.Click += new System.EventHandler(this.button_0_Click);
         this.button_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmmm);
         // 
         // button_8
         // 
         this.button_8.Location = new System.Drawing.Point(33, 5);
         this.button_8.Name = "button_8";
         this.button_8.Size = new System.Drawing.Size(168, 24);
         this.button_8.TabIndex = 10;
         this.button_8.Text = "KASA AKTARIM(1)";
         this.button_8.Click += new System.EventHandler(this.button_8_Click);
         this.button_8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmmm);
         // 
         // MontajIslemleri
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.AutoScroll = true;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(638, 455);
         this.Controls.Add(this.button_9);
         this.Controls.Add(this.button_0);
         this.Controls.Add(this.button_8);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MontajIslemleri";
         this.Text = "Montaj";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.MontajIslemleri_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button button_9;
      private System.Windows.Forms.Button button_0;
      private System.Windows.Forms.Button button_8;
   }
}