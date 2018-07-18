using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for OzelSecim.
	/// </summary>
	public class OzelSecim : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button_IPTAL;
		public System.Windows.Forms.TextBox textBox_KOD;
		public System.Windows.Forms.TextBox textBox_AD;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button button_TAMAM;
		public string str_ad = "",
			str_kod = "",
			str_ozel = "",
			ad = "", 
			kod = "" ,
			ozel = "",
			tablo = "",
			order_by = "";
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button1;
	
		public OzelSecim()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.textBox_KOD = new System.Windows.Forms.TextBox();
            this.textBox_AD = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.button_IPTAL = new System.Windows.Forms.Button();
            this.button_TAMAM = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_KOD
            // 
            this.textBox_KOD.BackColor = System.Drawing.Color.White;
            this.textBox_KOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_KOD.Location = new System.Drawing.Point(0, 8);
            this.textBox_KOD.Name = "textBox_KOD";
            this.textBox_KOD.Size = new System.Drawing.Size(92, 21);
            this.textBox_KOD.TabIndex = 2;
            this.textBox_KOD.TextChanged += new System.EventHandler(this.textBox_KOD_TextChanged);
            this.textBox_KOD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KOD_KeyUp);
            // 
            // textBox_AD
            // 
            this.textBox_AD.BackColor = System.Drawing.Color.White;
            this.textBox_AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_AD.Location = new System.Drawing.Point(108, 8);
            this.textBox_AD.Name = "textBox_AD";
            this.textBox_AD.Size = new System.Drawing.Size(116, 21);
            this.textBox_AD.TabIndex = 3;
            this.textBox_AD.TextChanged += new System.EventHandler(this.textBox_AD_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 224);
            this.listView1.TabIndex = 1;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KOD";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AD";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "OZEL";
            this.columnHeader3.Width = 10;
            // 
            // button_IPTAL
            // 
            this.button_IPTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_IPTAL.Location = new System.Drawing.Point(0, 260);
            this.button_IPTAL.Name = "button_IPTAL";
            this.button_IPTAL.Size = new System.Drawing.Size(120, 32);
            this.button_IPTAL.TabIndex = 6;
            this.button_IPTAL.Text = "IPTAL";
            this.button_IPTAL.Click += new System.EventHandler(this.button_IPTAL_Click);
            // 
            // button_TAMAM
            // 
            this.button_TAMAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_TAMAM.Location = new System.Drawing.Point(124, 260);
            this.button_TAMAM.Name = "button_TAMAM";
            this.button_TAMAM.Size = new System.Drawing.Size(116, 32);
            this.button_TAMAM.TabIndex = 5;
            this.button_TAMAM.Text = "TAMAM";
            this.button_TAMAM.Click += new System.EventHandler(this.button_TAMAM_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(224, 8);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(16, 22);
            this.button10.TabIndex = 0;
            this.button10.Text = "T";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "T";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OzelSecim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.button10);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox_KOD);
            this.Controls.Add(this.textBox_AD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_TAMAM);
            this.Controls.Add(this.button_IPTAL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OzelSecim";
            this.Text = "????? Secin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OzelSecim_Load);
            this.ResumeLayout(false);

		}
		#endregion

		//public Engine Utility.Engine;

		private void button_IPTAL_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}

		private void OzelSecim_Load(object sender, System.EventArgs e)
		{
            Utility.Engine.sql = "SELECT " + str_kod + " ," + str_ad + " ," + str_ozel + " FROM " + tablo + " ORDER BY " + order_by;
			Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
			textBox_KOD.Focus();
			textBox_KOD.SelectAll();
			return;
		}

		private void textBox_KOD_TextChanged(object sender, System.EventArgs e)
		{
			if(this.tablo.Equals("stok_tanim_ust"))
			{
				textBox_KOD.Text = textBox_KOD.Text.Replace("."," ");
			}
            if (tablo.ToUpper().IndexOf("WHERE") == -1)
                tablo += " where 1 = 1 ";
            Utility.Engine.sql = "SELECT " + str_kod + " ," + str_ad + " ," + str_ozel + " FROM " + tablo + " AND " + str_kod + " LIKE '" + Utility.Engine.SqlTemizle(textBox_KOD.Text.ToUpper()) + "%' ORDER BY " + order_by;
			Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
		}

		private void textBox_AD_TextChanged(object sender, System.EventArgs e)
		{
            if (tablo.ToUpper().IndexOf("WHERE") == -1)
                tablo += " where 1 = 1 ";
            Utility.Engine.sql = "SELECT " + str_kod + " ," + str_ad + " ," + str_ozel + " FROM " + tablo + " AND UPPER(" + str_ad + ") LIKE '" + Utility.Engine.SqlTemizle(textBox_AD.Text.ToUpper()) + "%' ORDER BY " + order_by;
			Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
		}

		private void button_TAMAM_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(listView1.Items.Count > 0 && listView1.SelectedIndices.Count > 0)
				{
					int i = this.listView1.Items[listView1.SelectedIndices[0]].Index;
					this.kod = this.listView1.Items[i].SubItems[0].Text;
					this.ad = this.listView1.Items[i].SubItems[1].Text;
					this.ozel = this.listView1.Items[i].SubItems[2].Text;
					if(this.str_kod != "" && this.str_ad != "")
					{
						this.DialogResult = DialogResult.OK;
						Close();
					}
					return;
				}
				return;
			}
			catch(Exception exc)
			{
				return;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBox_KOD.Text;
			if(t.ShowDialog() == DialogResult.OK)
			{
				textBox_KOD.Text = t.textBox1.Text;
			}
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBox_AD.Text;
			if(t.ShowDialog() == DialogResult.OK)
			{
				textBox_AD.Text = t.textBox1.Text;
			}
		}

		private void textBox_KOD_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)textBox_KOD_TextChanged(null,null);
		}
	}
}
