namespace AmbarPPC
{
    partial class PersonelAtama
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
            this.label1 = new System.Windows.Forms.Label();
            this.textIsEmri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPersonel = new System.Windows.Forms.TextBox();
            this.buttonIsBul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.textCikis = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.Text = "İş Emri";
            // 
            // textIsEmri
            // 
            this.textIsEmri.Location = new System.Drawing.Point(77, 29);
            this.textIsEmri.Name = "textIsEmri";
            this.textIsEmri.Size = new System.Drawing.Size(137, 23);
            this.textIsEmri.TabIndex = 2;
            this.textIsEmri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIsEmri_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.Text = "Per. Giriş";
            // 
            // textPersonel
            // 
            this.textPersonel.Location = new System.Drawing.Point(77, 54);
            this.textPersonel.Name = "textPersonel";
            this.textPersonel.Size = new System.Drawing.Size(137, 23);
            this.textPersonel.TabIndex = 2;
            this.textPersonel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPersonel_KeyPress);
            // 
            // buttonIsBul
            // 
            this.buttonIsBul.Location = new System.Drawing.Point(214, 29);
            this.buttonIsBul.Name = "buttonIsBul";
            this.buttonIsBul.Size = new System.Drawing.Size(25, 23);
            this.buttonIsBul.TabIndex = 19;
            this.buttonIsBul.Text = "T";
            this.buttonIsBul.Click += new System.EventHandler(this.buttonIsBul_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "T";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 25);
            this.button2.TabIndex = 22;
            this.button2.Text = "Kapat";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 25);
            this.button3.TabIndex = 22;
            this.button3.Text = "Seçileni Sil";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İş Emri";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı Soyadı";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stok Adı";
            this.columnHeader3.Width = 60;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stok Kodu";
            this.columnHeader4.Width = 60;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İst Adı";
            this.columnHeader5.Width = 60;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İst Kodu";
            this.columnHeader6.Width = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.Columns.Add(this.columnHeader4);
            this.listView1.Columns.Add(this.columnHeader5);
            this.listView1.Columns.Add(this.columnHeader6);
            this.listView1.Columns.Add(this.columnHeader7);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 192);
            this.listView1.TabIndex = 0;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PKod";
            this.columnHeader7.Width = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.Text = "Per. Çıkış";
            // 
            // textCikis
            // 
            this.textCikis.BackColor = System.Drawing.Color.PowderBlue;
            this.textCikis.Location = new System.Drawing.Point(77, 79);
            this.textCikis.Name = "textCikis";
            this.textCikis.Size = new System.Drawing.Size(137, 23);
            this.textCikis.TabIndex = 2;
            this.textCikis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCikis_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(214, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "T";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PersonelAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonIsBul);
            this.Controls.Add(this.textCikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPersonel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIsEmri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelAtama";
            this.Text = "PersonelAtama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersonelAtama_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIsEmri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPersonel;
        private System.Windows.Forms.Button buttonIsBul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCikis;
        private System.Windows.Forms.Button button4;
    }
}