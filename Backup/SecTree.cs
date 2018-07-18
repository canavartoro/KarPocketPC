using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for SecTree.
	/// </summary>
	public class SecTree : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button buttonTamam;
		private System.Windows.Forms.Button buttonCik;
		public string sql;
		//public Engine Utility.Engine;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelSecilen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxBarkod;
		public string selected;

	
		public SecTree()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			selected="";

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
			this.buttonCik = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.buttonTamam = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.labelSecilen = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxBarkod = new System.Windows.Forms.TextBox();
			// 
			// buttonCik
			// 
			this.buttonCik.Location = new System.Drawing.Point(136, 256);
			this.buttonCik.Size = new System.Drawing.Size(80, 32);
			this.buttonCik.Text = "ÇIK";
			this.buttonCik.Click += new System.EventHandler(this.buttonCik_Click);
			// 
			// treeView1
			// 
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(1, 48);
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(232, 200);
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// buttonTamam
			// 
			this.buttonTamam.Location = new System.Drawing.Point(16, 256);
			this.buttonTamam.Size = new System.Drawing.Size(88, 32);
			this.buttonTamam.Text = "TAMAM";
			this.buttonTamam.Click += new System.EventHandler(this.buttonTamam_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 27);
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.Text = "Seçilen:";
			// 
			// labelSecilen
			// 
			this.labelSecilen.Location = new System.Drawing.Point(56, 27);
			this.labelSecilen.Size = new System.Drawing.Size(168, 16);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.Text = "Barkod:";
			// 
			// textBoxBarkod
			// 
			this.textBoxBarkod.Location = new System.Drawing.Point(53, 5);
			this.textBoxBarkod.Size = new System.Drawing.Size(171, 20);
			this.textBoxBarkod.Text = "";
			this.textBoxBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecTree_KeyDown);
			this.textBoxBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBarkod_KeyUp);
			// 
			// SecTree
			// 
			this.ClientSize = new System.Drawing.Size(234, 296);
			this.ControlBox = false;
			this.Controls.Add(this.textBoxBarkod);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelSecilen);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonTamam);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.buttonCik);
			this.Text = "SecTree";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecTree_KeyDown);
			this.Load += new System.EventHandler(this.SecTree_Load);

		}
		#endregion

		/*SELECT     DepoKodu, DepoAdi, Sevk, Eksi, UstDepoKodu
FROM         depo_tanim
WHERE     (UstDepoKodu = N'CIKIS')
ORDER BY DepoKodu*/

		private void Doldur()
		{
			Utility.Engine.sql = "SELECT DepoKodu, DepoAdi, Sevk FROM  depo_tanim WHERE  (Level_ = 0) ORDER BY DepoKodu ";
			try
			{
				System.Data.IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);

				if(dr != null)
				{
					while(dr.Read())
					{
						string s=dr.GetValue(0).ToString(),
							ss="";
						int c=s.LastIndexOf('-');
						ss=s.Substring(c+1,s.Length-c);

						TreeNode tn = new TreeNode();
						tn.Text = ss;
						tn.Tag = dr.GetValue(2).ToString();
						treeView1.Nodes.Add(tn);
					}
				}
				if(dr != null)dr.Close();
			}
			catch(Exception exc)
			{
				MessageBox.Show("DEPO TANIMLARINDA HATA VAR OKUNAMIYOR!!","DiKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
				return;
			}
		}

		private void Doldur(TreeNode tnt)
		{
			tnt.Nodes.Clear();

			Utility.Engine.sql = "SELECT DepoKodu, DepoAdi, Sevk FROM  depo_tanim WHERE  (UstDepoKodu = N'" + tnt.Text + "') ORDER BY DepoKodu ";
			try
			{
				System.Data.IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);

				if(dr != null)
				{
					while(dr.Read())
					{
						TreeNode tn = new TreeNode();
						tn.Text = dr.GetValue(0).ToString();
						tn.Tag = dr.GetValue(2).ToString();
						tnt.Nodes.Add(tn);
					}
				}
				if(dr != null)dr.Close();
			}
			catch(Exception exc)
			{
				MessageBox.Show("DEPO TANIMLARINDA HATA VAR OKUNAMIYOR!!","DiKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
				return;
			}
		}

		private void SecTree_Load(object sender, System.EventArgs e)
		{
			treeView1.PathSeparator="-";
			//Utility.Engine.dat.TreeDoldur(ref treeView1,sql);
			Doldur();
		}

		private void buttonCik_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void buttonTamam_Click(object sender, System.EventArgs e)
		{
			if(labelSecilen.Text.Length>0)
			{
				selected=treeView1.SelectedNode.FullPath;
				Close();
			}
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if(treeView1.SelectedNode!=null)
			{
				labelSecilen.Text=treeView1.SelectedNode.FullPath;
				Doldur(treeView1.SelectedNode);
			}
		}

		private void textBoxBarkod_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				TreeNode tn;
				if((tn=Utility.Engine.dat.FindInTree(ref treeView1,Utility.Engine.SqlTemizle(textBoxBarkod.Text.Replace("*",""))))!=null)
				{
					treeView1.SelectedNode=tn;
					treeView1.Focus();
				}
				else
				{
					textBoxBarkod.SelectAll();
					textBoxBarkod.Focus();
				}
			}
		}

		private void SecTree_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Multiply)
			{
				textBoxBarkod.SelectAll();
				textBoxBarkod.Focus();
			}
		}
	}
}
