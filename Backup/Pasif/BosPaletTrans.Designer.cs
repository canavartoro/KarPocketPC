namespace AmbarPPC
{
    partial class BosPaletTrans
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonBarkodSil = new System.Windows.Forms.Button();
            this.textDepo = new System.Windows.Forms.TextBox();
            this.buttonYeniPalet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(229, 219);
            this.listView1.TabIndex = 3;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PaletID";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "BulunduðuYer";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.textBoxBarkod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonBarkodSil);
            this.panel1.Controls.Add(this.textDepo);
            this.panel1.Controls.Add(this.buttonYeniPalet);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 64);
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.BackColor = System.Drawing.Color.Yellow;
            this.textBoxBarkod.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.textBoxBarkod.Location = new System.Drawing.Point(56, 0);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(100, 19);
            this.textBoxBarkod.TabIndex = 1;
            this.textBoxBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkod_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.Text = "Palet";
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonOK.Location = new System.Drawing.Point(154, 0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(30, 19);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = ">>";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click_1);
            // 
            // buttonBarkodSil
            // 
            this.buttonBarkodSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonBarkodSil.Location = new System.Drawing.Point(184, 0);
            this.buttonBarkodSil.Name = "buttonBarkodSil";
            this.buttonBarkodSil.Size = new System.Drawing.Size(32, 19);
            this.buttonBarkodSil.TabIndex = 4;
            this.buttonBarkodSil.Text = "X";
            this.buttonBarkodSil.Click += new System.EventHandler(this.buttonBarkodSil_Click_1);
            // 
            // textDepo
            // 
            this.textDepo.BackColor = System.Drawing.Color.Salmon;
            this.textDepo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.textDepo.Location = new System.Drawing.Point(96, 25);
            this.textDepo.Name = "textDepo";
            this.textDepo.Size = new System.Drawing.Size(120, 19);
            this.textDepo.TabIndex = 6;
            // 
            // buttonYeniPalet
            // 
            this.buttonYeniPalet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonYeniPalet.Location = new System.Drawing.Point(0, 25);
            this.buttonYeniPalet.Name = "buttonYeniPalet";
            this.buttonYeniPalet.Size = new System.Drawing.Size(90, 20);
            this.buttonYeniPalet.TabIndex = 9;
            this.buttonYeniPalet.Text = "Gireceði Depo";
            this.buttonYeniPalet.Click += new System.EventHandler(this.buttonYeniPalet_Click);
            // 
            // BosPaletTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(236, 455);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BosPaletTrans";
            this.Text = "Boş PaletTransferi";
            this.Load += new System.EventHandler(this.BosPaletTrans_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonBarkodSil;
        private System.Windows.Forms.TextBox textDepo;
        private System.Windows.Forms.Button buttonYeniPalet;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}