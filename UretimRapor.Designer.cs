namespace AmbarPPC
{
    partial class UretimRapor
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
            this.textBoxPersKOd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPersKOd
            // 
            this.textBoxPersKOd.Location = new System.Drawing.Point(84, 4);
            this.textBoxPersKOd.Name = "textBoxPersKOd";
            this.textBoxPersKOd.Size = new System.Drawing.Size(125, 23);
            this.textBoxPersKOd.TabIndex = 0;
            this.textBoxPersKOd.GotFocus += new System.EventHandler(this.textBoxPersKOd_GotFocus);
            this.textBoxPersKOd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPersKOd_KeyUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.Text = "Pers. Kodu..:";
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGrid1.Location = new System.Drawing.Point(4, 50);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGrid1.Size = new System.Drawing.Size(234, 211);
            this.dataGrid1.TabIndex = 174;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle2);
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle2.MappingName = "rap";
            // 
            // dataGridTextBoxColumn1
            // 
      
            this.dataGridTextBoxColumn1.HeaderText = "iş Emri No";
            this.dataGridTextBoxColumn1.MappingName = "IsEmri";
            this.dataGridTextBoxColumn1.Width = 60;
            // 
            // dataGridTextBoxColumn2
            // 
          
            this.dataGridTextBoxColumn2.HeaderText = "Stok Adi";
            this.dataGridTextBoxColumn2.MappingName = "StokAdi";
            this.dataGridTextBoxColumn2.Width = 100;
            // 
            // dataGridTextBoxColumn3
            // 
  
            this.dataGridTextBoxColumn3.HeaderText = "Cuval/Koli";
            this.dataGridTextBoxColumn3.MappingName = "Cuval_Koli";
            this.dataGridTextBoxColumn3.Width = 70;
            // 
            // dataGridTextBoxColumn4
            // 
            
            this.dataGridTextBoxColumn4.HeaderText = "Metre/Adet";
            this.dataGridTextBoxColumn4.MappingName = "Metre_Adet";
            this.dataGridTextBoxColumn4.Width = 70;
            // 
            // dataGridTextBoxColumn5
            // 
        
            this.dataGridTextBoxColumn5.HeaderText = "Tarih";
            this.dataGridTextBoxColumn5.MappingName = "Tarih";
            this.dataGridTextBoxColumn5.Width = 60;
            // 
            // dataGridTextBoxColumn6
            // 
 
            this.dataGridTextBoxColumn6.HeaderText = "Personel Kodu";
            this.dataGridTextBoxColumn6.MappingName = "PersonelKodu";
            this.dataGridTextBoxColumn6.Width = 70;
            // 
            // dataGridTextBoxColumn7
            // 
           
            this.dataGridTextBoxColumn7.HeaderText = "Stok Kodu";
            this.dataGridTextBoxColumn7.MappingName = "StokKodu";
            this.dataGridTextBoxColumn7.Width = 90;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 175;
            this.button1.Text = ">>";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 19);
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 21);
            this.button2.TabIndex = 177;
            this.button2.Text = "Tamam";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UretimRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPersKOd);
            this.Name = "UretimRapor";
            this.Text = "Üretim Rapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UretimRapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPersKOd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}