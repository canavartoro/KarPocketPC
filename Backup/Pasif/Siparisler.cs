using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for Siparisler.
	/// </summary>
	public class Siparisler : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.TextBox textBoxSiparisNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxCariKodu;
		private System.Windows.Forms.TextBox textBoxCariAdi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Panel panelAra;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.RadioButton radioButtonSatis;
		private System.Windows.Forms.RadioButton radioButtonAlis;
		private System.Windows.Forms.Panel panel2;
	
		public Siparisler()
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

		//public Engine Utility.Engine;

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelAra = new System.Windows.Forms.Panel();
            this.radioButtonSatis = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSiparisNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCariKodu = new System.Windows.Forms.TextBox();
            this.textBoxCariAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.radioButtonAlis = new System.Windows.Forms.RadioButton();
            this.panelAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(0, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 8);
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.Columns.Add(this.columnHeader4);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 8);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 200);
            this.listView1.TabIndex = 3;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SiparisNo";
            this.columnHeader1.Width = 60;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CariAdi";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CariKodu";
            this.columnHeader3.Width = 60;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adres";
            this.columnHeader4.Width = 60;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "CIK (0)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "ARA (3)";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "SEC (2)";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelAra
            // 
            this.panelAra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelAra.Controls.Add(this.radioButtonSatis);
            this.panelAra.Controls.Add(this.label1);
            this.panelAra.Controls.Add(this.textBoxSiparisNo);
            this.panelAra.Controls.Add(this.label2);
            this.panelAra.Controls.Add(this.textBoxCariKodu);
            this.panelAra.Controls.Add(this.textBoxCariAdi);
            this.panelAra.Controls.Add(this.label3);
            this.panelAra.Controls.Add(this.button6);
            this.panelAra.Controls.Add(this.button5);
            this.panelAra.Controls.Add(this.button4);
            this.panelAra.Controls.Add(this.button7);
            this.panelAra.Controls.Add(this.radioButtonAlis);
            this.panelAra.Location = new System.Drawing.Point(8, 24);
            this.panelAra.Name = "panelAra";
            this.panelAra.Size = new System.Drawing.Size(240, 184);
            this.panelAra.Visible = false;
            // 
            // radioButtonSatis
            // 
            this.radioButtonSatis.Checked = true;
            this.radioButtonSatis.Location = new System.Drawing.Point(16, 16);
            this.radioButtonSatis.Name = "radioButtonSatis";
            this.radioButtonSatis.Size = new System.Drawing.Size(88, 16);
            this.radioButtonSatis.TabIndex = 0;
            this.radioButtonSatis.Text = "Sevk Satis";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.Text = "Sip No";
            // 
            // textBoxSiparisNo
            // 
            this.textBoxSiparisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular);
            this.textBoxSiparisNo.Location = new System.Drawing.Point(64, 48);
            this.textBoxSiparisNo.Name = "textBoxSiparisNo";
            this.textBoxSiparisNo.Size = new System.Drawing.Size(144, 23);
            this.textBoxSiparisNo.TabIndex = 2;
            this.textBoxSiparisNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSiparisNo_KeyUp);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.Text = "Ca. No";
            // 
            // textBoxCariKodu
            // 
            this.textBoxCariKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular);
            this.textBoxCariKodu.Location = new System.Drawing.Point(64, 80);
            this.textBoxCariKodu.Name = "textBoxCariKodu";
            this.textBoxCariKodu.Size = new System.Drawing.Size(144, 23);
            this.textBoxCariKodu.TabIndex = 4;
            this.textBoxCariKodu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCariKodu_KeyUp);
            // 
            // textBoxCariAdi
            // 
            this.textBoxCariAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular);
            this.textBoxCariAdi.Location = new System.Drawing.Point(64, 112);
            this.textBoxCariAdi.Name = "textBoxCariAdi";
            this.textBoxCariAdi.Size = new System.Drawing.Size(144, 23);
            this.textBoxCariAdi.TabIndex = 5;
            this.textBoxCariAdi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCariAdi_KeyUp);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.Text = "Ca Ad";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(208, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 24);
            this.button6.TabIndex = 7;
            this.button6.Text = "T";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(208, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 24);
            this.button5.TabIndex = 8;
            this.button5.Text = "T";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(208, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 24);
            this.button4.TabIndex = 9;
            this.button4.Text = "T";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.button7.Location = new System.Drawing.Point(16, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(216, 32);
            this.button7.TabIndex = 10;
            this.button7.Text = "GiZLE ";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // radioButtonAlis
            // 
            this.radioButtonAlis.Enabled = false;
            this.radioButtonAlis.Location = new System.Drawing.Point(144, 16);
            this.radioButtonAlis.Name = "radioButtonAlis";
            this.radioButtonAlis.Size = new System.Drawing.Size(88, 16);
            this.radioButtonAlis.TabIndex = 11;
            this.radioButtonAlis.Text = "Sevk Alis";
            // 
            // Siparisler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.panelAra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Siparisler";
            this.Text = "Sipariş Seçin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Siparisler_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Siparisler_KeyUp);
            this.panelAra.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Siparisler_Load(object sender, System.EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				Utility.Engine.sql = string.Format(@"SELECT top 20 s.SiparisNo,c.CariAdi,c.CariKodu,s.SevkAdresi    from siparisler s,cari_tanim c
where s.CariKodu = c.CariKodu and s.AlisSatis = 'Satis'
group by s.SiparisNo,c.CariAdi,c.CariKodu,s.SevkAdresi
order by s.SiparisNo , c.CariAdi");
				Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
			}
			catch(Exception ex)
			{
				Utility.Engine.Hata("Siparisler Sorgulanirken Hata:" + ex.Message);
				Cursor.Current = Cursors.Default;
				return;
			}

			Cursor.Current = Cursors.Default;
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			Gizle(false);
		}

		private void Gizle(bool goster)
		{
			textBoxSiparisNo.Text = 
				textBoxCariKodu.Text = 
				textBoxCariAdi.Text = "";
			panelAra.Visible = goster;
		}

		private void textBoxSiparisNo_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				Cursor.Current = Cursors.WaitCursor;

				try
				{
					Utility.Engine.sql = string.Format(@"SELECT top 20 s.SiparisNo,c.CariAdi,c.CariKodu,s.SevkAdresi    from siparisler s,cari_tanim c
where s.CariKodu = c.CariKodu and s.AlisSatis = 'Satis' and UPPER(s.SiparisNo) like '{0}%' 
group by s.SiparisNo,c.CariAdi,c.CariKodu,s.SevkAdresi
order by s.SiparisNo , c.CariAdi",textBoxSiparisNo.Text.ToUpper());
					Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
				}
				catch(Exception exc)
				{
					Utility.Engine.Hata("Siparisler Sorgulanirken Hata:" + exc.Message);
				}

				Cursor.Current = Cursors.Default;
				Gizle(false);
			}
		}

		private void textBoxCariKodu_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				Cursor.Current = Cursors.WaitCursor;

				try
				{
					Utility.Engine.sql = string.Format(@"SELECT top 20 s.SiparisNo,c.CariAdi,c.CariKodu,s.SevkAdresi    from siparisler s,cari_tanim c
where s.CariKodu = c.CariKodu and s.AlisSatis = 'Satis' and UPPER(c.CariKodu) like '{0}%' 
group by s.SiparisNo,c.CariAdi,c.CariKodu,s.SevkAdresi
order by s.SiparisNo , c.CariAdi",textBoxCariKodu.Text.ToUpper());
					Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
				}
				catch(Exception ex)
				{
					Utility.Engine.Hata("Siparisler Sorgulanriken Hata:" + ex.Message);
				}

				Cursor.Current = Cursors.Default;
				Gizle(false);
			}
		}

		private void textBoxCariAdi_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				Cursor.Current = Cursors.WaitCursor;

				try
				{
					
					Utility.Engine.sql = string.Format(@"SELECT top 20 s.SiparisNo,c.CariAdi,c.CariKodu,s.SevkAdresi    from siparisler s,cari_tanim c
where s.CariKodu = c.CariKodu and s.AlisSatis = 'Satis' and UPPER(c.CariAdi) like '{0}%' 
group by s.SiparisNo,c.CariAdi,c.CariKodu,s.SevkAdresi
order by s.SiparisNo , c.CariAdi",textBoxCariAdi.Text.ToUpper());
					Utility.Engine.dat.ListDoldur(ref listView1,Utility.Engine.sql);
				}
				catch(Exception exc)
				{
					Utility.Engine.Hata("Siparisler Sorgulanriken Hata:" + exc.Message);
				}

				Cursor.Current = Cursors.Default;
				Gizle(false);
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Gizle(true);
			textBoxCariAdi.Focus();
			return;
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBoxSiparisNo.Text;
			if(t.ShowDialog()==DialogResult.OK)
			{
				textBoxSiparisNo.Text = t.textBox1.Text;
				textBoxSiparisNo_KeyUp(null,new KeyEventArgs(Keys.Enter));
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBoxCariKodu.Text;
			if(t.ShowDialog()==DialogResult.OK)
			{
				textBoxCariKodu.Text = t.textBox1.Text;
				textBoxCariKodu_KeyUp(null,new KeyEventArgs(Keys.Enter));
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBoxCariAdi.Text;
			if(t.ShowDialog()==DialogResult.OK)
			{
				textBoxCariAdi.Text = t.textBox1.Text;
				textBoxCariAdi_KeyUp(null,new KeyEventArgs(Keys.Enter));
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if(listView1.Items.Count > 0 && listView1.SelectedIndices.Count > 0)
			{
				DetayliSevk dt = new DetayliSevk();
				dt.SiparisNo = listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
				dt.CariAdi = listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text;
				dt.Cari = listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text;
				dt.SevkAdresi = listView1.Items[listView1.SelectedIndices[0]].SubItems[3].Text;
				dt.ShowDialog();
			}
		}

		private void Siparisler_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.D0)Close();
			else if(e.KeyCode == Keys.D2)
				button3_Click(null,null);
			else if(e.KeyCode == Keys.D3)
				button2_Click(null,null);

		}
	}
}
