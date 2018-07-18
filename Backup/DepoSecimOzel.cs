using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for DepoSecimOzel.
	/// </summary>
	public class DepoSecimOzel : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_BARKOD;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label_SECILEN;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button_TAMAM;
		private System.Windows.Forms.Button button_IPTAL;
		private System.Windows.Forms.Panel panel1;

		//public Engine Utility.Engine;
		public string DepoKodu = "";
		private System.Windows.Forms.Button button2;
		public bool Rapor = false,Iade = false;
	
		public DepoSecimOzel()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_BARKOD = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label_SECILEN = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button_TAMAM = new System.Windows.Forms.Button();
			this.button_IPTAL = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBox_BARKOD);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label_SECILEN);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Size = new System.Drawing.Size(224, 48);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular);
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.Text = "Barkod";
			// 
			// textBox_BARKOD
			// 
			this.textBox_BARKOD.BackColor = System.Drawing.Color.Orange;
			this.textBox_BARKOD.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular);
			this.textBox_BARKOD.Location = new System.Drawing.Point(48, 0);
			this.textBox_BARKOD.Size = new System.Drawing.Size(128, 22);
			this.textBox_BARKOD.Text = "";
			this.textBox_BARKOD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_BARKOD_KeyPress);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular);
			this.label2.Location = new System.Drawing.Point(0, 32);
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.Text = "Secilen";
			// 
			// label_SECILEN
			// 
			this.label_SECILEN.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular);
			this.label_SECILEN.Location = new System.Drawing.Point(64, 32);
			this.label_SECILEN.Size = new System.Drawing.Size(152, 16);
			this.label_SECILEN.Text = "????";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular);
			this.button1.Location = new System.Drawing.Point(200, 0);
			this.button1.Size = new System.Drawing.Size(24, 24);
			this.button1.Text = ">>";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.treeView1);
			this.panel2.Location = new System.Drawing.Point(8, 64);
			this.panel2.Size = new System.Drawing.Size(224, 192);
			// 
			// treeView1
			// 
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(0, 8);
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(224, 176);
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Silver;
			this.panel3.Controls.Add(this.button_TAMAM);
			this.panel3.Controls.Add(this.button_IPTAL);
			this.panel3.Location = new System.Drawing.Point(8, 264);
			this.panel3.Size = new System.Drawing.Size(224, 48);
			// 
			// button_TAMAM
			// 
			this.button_TAMAM.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular);
			this.button_TAMAM.Location = new System.Drawing.Point(120, 8);
			this.button_TAMAM.Size = new System.Drawing.Size(104, 32);
			this.button_TAMAM.Text = "TAMAM";
			this.button_TAMAM.Click += new System.EventHandler(this.button_TAMAM_Click);
			// 
			// button_IPTAL
			// 
			this.button_IPTAL.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular);
			this.button_IPTAL.Location = new System.Drawing.Point(0, 8);
			this.button_IPTAL.Size = new System.Drawing.Size(104, 32);
			this.button_IPTAL.Text = "IPTAL";
			this.button_IPTAL.Click += new System.EventHandler(this.button_IPTAL_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular);
			this.button2.Location = new System.Drawing.Point(176, 0);
			this.button2.Size = new System.Drawing.Size(24, 24);
			this.button2.Text = "T";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			// 
			// DepoSecimOzel
			// 
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(240, 320);
			this.ControlBox = false;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.DepoSecimOzel_Load);

		}
		#endregion

		private void Doldur()
		{
			if(Rapor)
			{
				Utility.Engine.sql="SELECT distinct DepoKodu  FROM  depo_tanim where Level_='0'   order by DepoKodu";
			}
			else 
			{
				Utility.Engine.sql="SELECT distinct DepoKodu  FROM  depo_tanim (nolock) where (Level_ = '0') and DepoKodu not in (select AD from haric_depo) order by DepoKodu";
				if(Iade)
					Utility.Engine.sql = Utility.Engine.sql.Replace("not","");
			}


			System.Data.DataTable dt=new System.Data.DataTable();
			if(!Utility.Engine.dat.TableDoldur(Utility.Engine.sql,ref dt))return;
			if(dt!=null&&dt.Rows.Count>0)
			{
				for(int i=0;i<dt.Rows.Count;i++)
				{
					if(dt.Rows[i][0].ToString()!="")
					{
						TreeNode tn=new TreeNode(dt.Rows[i][0].ToString());
						tn.Tag=dt.Rows[i][0].ToString();
						treeView1.Nodes.Add(tn);
					}
				}
			}
		}

		private void DetayDoldur(TreeNode tn)
		{
			tn.Nodes.Clear();
			if(Rapor)
			{
				Utility.Engine.sql=string.Format("SELECT distinct DepoKodu   FROM  depo_tanim  where (UstDepoKodu='{0}')   order by DepoKodu",tn.Tag.ToString());
			}
			else 
			{
				Utility.Engine.sql=string.Format("SELECT distinct DepoKodu   FROM  depo_tanim  where (UstDepoKodu='{0}')  and (DepoKodu not in (Select AD from haric_depo))  order by DepoKodu",tn.Tag.ToString());
				if(Iade)
					Utility.Engine.sql = Utility.Engine.sql.Replace("not","");
			}
			//Utility.Engine.sql=string.Format("SELECT distinct DepoKodu   FROM  depo_tanim  where (UstDepoKodu='{0}')   order by DepoKodu",tn.Tag.ToString());
			System.Data.DataTable dt=new System.Data.DataTable();
			if(!Utility.Engine.dat.TableDoldur(Utility.Engine.sql,ref dt))return;
			if(dt!=null&&dt.Rows.Count>0)
			{
				for(int i=0;i<dt.Rows.Count;i++)
				{
					if(dt.Rows[i][0].ToString()!="")
					{
                  string s=dt.Rows[i][0].ToString(),
                     ss="";
                  int c=s.LastIndexOf('-');
                  if (c != -1)
                  {
                     ss = s.Substring(c + 1, s.Length - (c + 1));
                  }
                  else
                     ss = s;
                  TreeNode tnn = new TreeNode(ss);
                  tnn.Tag = dt.Rows[i][0].ToString();
                  tn.Nodes.Add(tnn);
                  
					}
				}
			}
		
		}
		private void DepoSecimOzel_Load(object sender, System.EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			Doldur();

			textBox_BARKOD.Focus();
			Cursor.Current = Cursors.Default;
			return;
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			DetayDoldur(e.Node);
			label_SECILEN.Text=e.Node.Tag.ToString();
		}

		private void button_TAMAM_Click(object sender, System.EventArgs e)
		{
			if(label_SECILEN.Text!="")
			{
				Utility.Engine.sql=string.Format("SELECT DISTINCT   DepoKodu,Sevk   FROM  depo_tanim WHERE DepoKodu='{0}'  ",label_SECILEN.Text);
				System.Data.DataTable dt=new System.Data.DataTable();
				if(!Utility.Engine.dat.TableDoldur(Utility.Engine.sql,ref dt))
				{
					textBox_BARKOD.Text = "";
					textBox_BARKOD.Focus();
					return;
				}
				if(dt!=null&&dt.Rows.Count>0)
				{
					if(dt.Rows[0][0].ToString()=="")
					{
						MessageBox.Show("Depo Biliglerine Ulasilamadi!!");
						textBox_BARKOD.Text = "";
						textBox_BARKOD.Focus();
						return;
					}
					else if(dt.Rows[0][1].ToString()=="H"&&!Rapor)
					{
						MessageBox.Show("Depo Raporlama Amacli Tanimlanmistir Sevkiyat Yapilamaz!");
						textBox_BARKOD.Text = "";
						textBox_BARKOD.Focus();
						return;
					}
					else if((dt.Rows[0][0].ToString()!=""&&Rapor)||dt.Rows[0][0].ToString()!=""&&dt.Rows[0][1].ToString()=="E")
					{
						DepoKodu=dt.Rows[0][0].ToString();
						this.DialogResult=DialogResult.OK;
					}
					else 
					{
						textBox_BARKOD.Text = "";
						textBox_BARKOD.Focus();
						return;
					}
				}
				else
				{
					textBox_BARKOD.Text = "";
					textBox_BARKOD.Focus();
					return;
				} 
			}
		}

		private void button_IPTAL_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			textBox_BARKOD_KeyPress(null,new KeyPressEventArgs((char)13));
		}

		private void textBox_BARKOD_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
				Utility.Engine.sql=string.Format("SELECT DISTINCT   DepoKodu,Sevk   FROM  depo_tanim WHERE DepoKodu='{0}' and DepoKodu not in (select AD from haric_depo)   ",textBox_BARKOD.Text.ToUpper().Trim());

				if(Iade)
					Utility.Engine.sql = Utility.Engine.sql.Replace("not","");

				System.Data.DataTable dt=new System.Data.DataTable();
				if(!Utility.Engine.dat.TableDoldur(Utility.Engine.sql,ref dt))
				{
					textBox_BARKOD.Text = "";
					textBox_BARKOD.Focus();
					return;
				}
				if(dt!=null&&dt.Rows.Count>0)
				{
					if(dt.Rows[0][0].ToString()=="")
					{
						MessageBox.Show("Depo Biliglerine Ulasilamadi!!");
						textBox_BARKOD.Text = "";
						textBox_BARKOD.Focus();
						return;
					}
					else if(dt.Rows[0][1].ToString()=="H"&&!Rapor)
					{
						MessageBox.Show("Depo Raporlama Amacli Tanimlanmistir Sevkiyat Yapilamaz!");
						textBox_BARKOD.Text = "";
						textBox_BARKOD.Focus();
						return;
					}
					else if((dt.Rows[0][0].ToString()!=""&&Rapor)||dt.Rows[0][0].ToString()!=""&&dt.Rows[0][1].ToString()=="E")
					{
						DepoKodu=dt.Rows[0][0].ToString();
						this.DialogResult=DialogResult.OK;
					}
					else 
					{
						textBox_BARKOD.Text = "";
						textBox_BARKOD.Focus();
						return;
					}
				}
				else
				{
					textBox_BARKOD.Text = "";
					textBox_BARKOD.Focus();
					return;
				} 
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBox_BARKOD.Text;
			if(t.ShowDialog()==DialogResult.OK)
			{
				textBox_BARKOD.Text = t.textBox1.Text;
				textBox_BARKOD_KeyPress(null,new KeyPressEventArgs((char)13));
			}
		}
	}
}
