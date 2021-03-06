using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for DepoStok.
	/// </summary>
	public class DepoStok : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.ComboBox comboBoxRaporTipi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxStokKodu;
		private System.Windows.Forms.TextBox textBoxDepoKodu;
		private System.Windows.Forms.Button buttonStokKoduSec;
		private System.Windows.Forms.Button buttonDepoKoduSec;
		private System.Windows.Forms.RadioButton radioButtonDetayBazinda;
		private System.Windows.Forms.RadioButton radioButtonStokBazinda;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn13;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn15;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn16;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn17;
		private System.Windows.Forms.CheckBox checkBox_Barkod;
		private System.Windows.Forms.MenuItem menuItem_Bilgi;
        private ComboBox comboBox1;
        private System.Windows.Forms.MenuItem menuItem3;
		//public Engine Utility.Engine;
	
		public DepoStok()
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.comboBoxRaporTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStokKodu = new System.Windows.Forms.TextBox();
            this.textBoxDepoKodu = new System.Windows.Forms.TextBox();
            this.buttonStokKoduSec = new System.Windows.Forms.Button();
            this.buttonDepoKoduSec = new System.Windows.Forms.Button();
            this.radioButtonDetayBazinda = new System.Windows.Forms.RadioButton();
            this.radioButtonStokBazinda = new System.Windows.Forms.RadioButton();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem_Bilgi = new System.Windows.Forms.MenuItem();
            this.checkBox_Barkod = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(0, 24);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(232, 160);
            this.dataGrid1.TabIndex = 9;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle2);
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle3);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.MappingName = "SeriliDepoMevcut";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Stok Kodu";
            this.dataGridTextBoxColumn1.MappingName = "StokKodu";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Stok Adi";
            this.dataGridTextBoxColumn2.MappingName = "StokAdi";
            this.dataGridTextBoxColumn2.Width = 100;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Birim";
            this.dataGridTextBoxColumn3.MappingName = "Birim";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Miktar";
            this.dataGridTextBoxColumn4.MappingName = "Miktar";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Seri No";
            this.dataGridTextBoxColumn5.MappingName = "SeriliBarkod";
            this.dataGridTextBoxColumn5.Width = 70;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Depo Kodu";
            this.dataGridTextBoxColumn6.MappingName = "DepoKodu";
            this.dataGridTextBoxColumn6.Width = 70;
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn10);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn11);
            this.dataGridTableStyle2.MappingName = "SerisizDepoMevcut";
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "Stok Kodu";
            this.dataGridTextBoxColumn7.MappingName = "StokKodu";
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "Stok Adi";
            this.dataGridTextBoxColumn8.MappingName = "StokAdi";
            this.dataGridTextBoxColumn8.Width = 100;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.HeaderText = "Birim";
            this.dataGridTextBoxColumn9.MappingName = "Birim";
            // 
            // dataGridTextBoxColumn10
            // 
            this.dataGridTextBoxColumn10.Format = "";
            this.dataGridTextBoxColumn10.FormatInfo = null;
            this.dataGridTextBoxColumn10.HeaderText = "Miktar";
            this.dataGridTextBoxColumn10.MappingName = "Miktar";
            // 
            // dataGridTextBoxColumn11
            // 
            this.dataGridTextBoxColumn11.Format = "";
            this.dataGridTextBoxColumn11.FormatInfo = null;
            this.dataGridTextBoxColumn11.HeaderText = "Depo Kodu";
            this.dataGridTextBoxColumn11.MappingName = "DepoKodu";
            this.dataGridTextBoxColumn11.Width = 80;
            // 
            // dataGridTableStyle3
            // 
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn12);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn13);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn14);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn15);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn16);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn17);
            this.dataGridTableStyle3.MappingName = "DepoMevcut";
            // 
            // dataGridTextBoxColumn12
            // 
            this.dataGridTextBoxColumn12.Format = "";
            this.dataGridTextBoxColumn12.FormatInfo = null;
            this.dataGridTextBoxColumn12.HeaderText = "Stok Kodu";
            this.dataGridTextBoxColumn12.MappingName = "StokKodu";
            // 
            // dataGridTextBoxColumn13
            // 
            this.dataGridTextBoxColumn13.Format = "";
            this.dataGridTextBoxColumn13.FormatInfo = null;
            this.dataGridTextBoxColumn13.HeaderText = "Stok Adi";
            this.dataGridTextBoxColumn13.MappingName = "StokAdi";
            this.dataGridTextBoxColumn13.Width = 100;
            // 
            // dataGridTextBoxColumn14
            // 
            this.dataGridTextBoxColumn14.Format = "";
            this.dataGridTextBoxColumn14.FormatInfo = null;
            this.dataGridTextBoxColumn14.HeaderText = "Birim";
            this.dataGridTextBoxColumn14.MappingName = "Birim";
            // 
            // dataGridTextBoxColumn15
            // 
            this.dataGridTextBoxColumn15.Format = "";
            this.dataGridTextBoxColumn15.FormatInfo = null;
            this.dataGridTextBoxColumn15.HeaderText = "Miktar";
            this.dataGridTextBoxColumn15.MappingName = "Miktar";
            // 
            // dataGridTextBoxColumn16
            // 
            this.dataGridTextBoxColumn16.Format = "";
            this.dataGridTextBoxColumn16.FormatInfo = null;
            this.dataGridTextBoxColumn16.HeaderText = "Seri No";
            this.dataGridTextBoxColumn16.MappingName = "SeriliBarkod";
            // 
            // dataGridTextBoxColumn17
            // 
            this.dataGridTextBoxColumn17.Format = "";
            this.dataGridTextBoxColumn17.FormatInfo = null;
            this.dataGridTextBoxColumn17.HeaderText = "Depo Kodu";
            this.dataGridTextBoxColumn17.MappingName = "DepoKodu";
            this.dataGridTextBoxColumn17.Width = 75;
            // 
            // comboBoxRaporTipi
            // 
            this.comboBoxRaporTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.comboBoxRaporTipi.Items.Add("Tüm Stoklar");
            this.comboBoxRaporTipi.Items.Add("Serili Stoklar");
            this.comboBoxRaporTipi.Items.Add("Serisiz Stoklar");
            this.comboBoxRaporTipi.Location = new System.Drawing.Point(120, 200);
            this.comboBoxRaporTipi.Name = "comboBoxRaporTipi";
            this.comboBoxRaporTipi.Size = new System.Drawing.Size(112, 19);
            this.comboBoxRaporTipi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.Text = "Depo Kodu \'%\':";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.Text = "Stok Kodu:";
            // 
            // textBoxStokKodu
            // 
            this.textBoxStokKodu.Location = new System.Drawing.Point(120, 224);
            this.textBoxStokKodu.Name = "textBoxStokKodu";
            this.textBoxStokKodu.Size = new System.Drawing.Size(80, 23);
            this.textBoxStokKodu.TabIndex = 6;
            this.textBoxStokKodu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStokKodu_KeyUp);
            // 
            // textBoxDepoKodu
            // 
            this.textBoxDepoKodu.Location = new System.Drawing.Point(120, 248);
            this.textBoxDepoKodu.Name = "textBoxDepoKodu";
            this.textBoxDepoKodu.Size = new System.Drawing.Size(80, 23);
            this.textBoxDepoKodu.TabIndex = 7;
            // 
            // buttonStokKoduSec
            // 
            this.buttonStokKoduSec.Location = new System.Drawing.Point(200, 224);
            this.buttonStokKoduSec.Name = "buttonStokKoduSec";
            this.buttonStokKoduSec.Size = new System.Drawing.Size(32, 20);
            this.buttonStokKoduSec.TabIndex = 3;
            this.buttonStokKoduSec.Text = "...";
            this.buttonStokKoduSec.Click += new System.EventHandler(this.buttonStokKoduSec_Click);
            // 
            // buttonDepoKoduSec
            // 
            this.buttonDepoKoduSec.Location = new System.Drawing.Point(200, 248);
            this.buttonDepoKoduSec.Name = "buttonDepoKoduSec";
            this.buttonDepoKoduSec.Size = new System.Drawing.Size(32, 20);
            this.buttonDepoKoduSec.TabIndex = 2;
            this.buttonDepoKoduSec.Text = "...";
            this.buttonDepoKoduSec.Click += new System.EventHandler(this.buttonDepoKoduSec_Click);
            // 
            // radioButtonDetayBazinda
            // 
            this.radioButtonDetayBazinda.Location = new System.Drawing.Point(8, 200);
            this.radioButtonDetayBazinda.Name = "radioButtonDetayBazinda";
            this.radioButtonDetayBazinda.Size = new System.Drawing.Size(104, 16);
            this.radioButtonDetayBazinda.TabIndex = 0;
            this.radioButtonDetayBazinda.Text = "Detay Bazinda";
            // 
            // radioButtonStokBazinda
            // 
            this.radioButtonStokBazinda.Location = new System.Drawing.Point(8, 184);
            this.radioButtonStokBazinda.Name = "radioButtonStokBazinda";
            this.radioButtonStokBazinda.Size = new System.Drawing.Size(104, 16);
            this.radioButtonStokBazinda.TabIndex = 1;
            this.radioButtonStokBazinda.Text = "Stok Bazinda";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem_Bilgi);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItem3);
            this.menuItem2.Text = "Sorgula";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Depo Sorgula";
            this.menuItem3.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Çikiş";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem_Bilgi
            // 
            this.menuItem_Bilgi.Text = "0";
            // 
            // checkBox_Barkod
            // 
            this.checkBox_Barkod.Location = new System.Drawing.Point(8, 216);
            this.checkBox_Barkod.Name = "checkBox_Barkod";
            this.checkBox_Barkod.Size = new System.Drawing.Size(64, 20);
            this.checkBox_Barkod.TabIndex = 10;
            this.checkBox_Barkod.Text = "Barkod";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(130, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 23);
            this.comboBox1.TabIndex = 11;
            // 
            // DepoStok
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(234, 449);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButtonDetayBazinda);
            this.Controls.Add(this.radioButtonStokBazinda);
            this.Controls.Add(this.buttonDepoKoduSec);
            this.Controls.Add(this.buttonStokKoduSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStokKodu);
            this.Controls.Add(this.textBoxDepoKodu);
            this.Controls.Add(this.comboBoxRaporTipi);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.checkBox_Barkod);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "DepoStok";
            this.Text = "Depo Stok";
            this.Load += new System.EventHandler(this.DepoStok_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void DepoStok_Load(object sender, System.EventArgs e)
		{
            Utility.Engine.dat.ComboDoldur(@"select * from
(
select N'TÜMÜ' as grup
union all
select ISNULL(RaporGrup,'') from depo_tanim (nolock) group by RaporGrup 
) tbl order by grup", comboBox1);
			comboBoxRaporTipi.SelectedIndex=0;
			radioButtonStokBazinda.Checked=true;
		}

		private void buttonStokKoduSec_Click(object sender, System.EventArgs e)
		{
			Sec s=new Sec();
            s.sql = "SELECT TOP 20 StokKodu,StokAdi,StokAdi2,Diger1,Diger2 FROM stok_tanim_ust (nolock) ";
			s.tablename="StokTanimlari";
			s.sql_where = string.Format(" WHERE ( 1 = 1 ) ");
			
			if(s.ShowDialog()!=DialogResult.OK)
				return;

			if(s.dr["StokKodu"]!=DBNull.Value)
			{
				textBoxStokKodu.Text=s.dr["StokKodu"].ToString();
			
				//				if(s.dr["StokAdi"]!=DBNull.Value)
				//				{
				//					labelUrunAdi.Text=s.dr["StokAdi"].ToString();
				//				}
			}
		}

		private void buttonDepoKoduSec_Click(object sender, System.EventArgs e)
		{
			DepoSecimOzel oz = new DepoSecimOzel();
			oz.Rapor = true;
			if(oz.ShowDialog() == DialogResult.OK)
			{
				textBoxDepoKodu.Text = oz.DepoKodu;
			}
//			SecTree st=new SecTree();
//			st.Utility.Engine=Utility.Engine;
//			st.sql="SELECT UstDepoKodu,DepoKodu FROM depo_tanim";
//			st.ShowDialog();
//			if(st.selected!="")
//				textBoxDepoKodu.Text=st.selected;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
            bool SayimGoster = false;
			if(comboBoxRaporTipi.SelectedIndex<0)
				return;

            if (textBoxStokKodu.Text.Trim() == "" && textBoxDepoKodu.Text.Trim() == "")
            {
                MessageBox.Show("Stok veya Depo Alanlarindan Birini Doldurunuz..!");
                return;
            }

            if (Utility.Sor("SAYIM depodaki malzemeler gösterilsin mi?"))
            {
                SayimGoster = true;
            }

			#region serili Stoklar
			if(comboBoxRaporTipi.Items[comboBoxRaporTipi.SelectedIndex].ToString()=="Serili Stoklar")
			{
				if(radioButtonDetayBazinda.Checked==true)
				{
                    Utility.Engine.sql = @"SELECT depo_mevcut.DepoKodu,depo_mevcut.SeriliBarkod,depo_mevcut.StokKodu,stok_tanim_ust.StokAdi,depo_mevcut.Birim,depo_mevcut.Miktar FROM depo_mevcut  (nolock) 
						LEFT OUTER JOIN stok_tanim_ust (nolock) ON depo_mevcut.StokKodu=stok_tanim_ust.StokKodu 
						WHERE SeriliBarkod<>'' AND depo_mevcut.Miktar > 0 and depo_mevcut.DepoKodu not in (select AD from haric_depo (nolock) ) ";
				}
				else
				{
					Utility.Engine.sql= @"SELECT depo_mevcut.StokKodu,stok_tanim_ust.StokAdi,depo_mevcut.Birim,SUM(depo_mevcut.Miktar) AS Miktar FROM depo_mevcut (nolock)
						LEFT OUTER JOIN stok_tanim_ust (nolock) ON depo_mevcut.StokKodu=stok_tanim_ust.StokKodu 
						WHERE SeriliBarkod<>'' AND depo_mevcut.Miktar > 0 and depo_mevcut.DepoKodu not in (select AD from haric_depo (NOLOCK))  ";
				}

				if(textBoxStokKodu.Text.Length>0)
				{
					if(textBoxStokKodu.Text.IndexOf("%") != -1)
					{
						Utility.Engine.sql+=" AND UPPER(depo_mevcut.StokKodu) LIKE UPPER('";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
						Utility.Engine.sql+="%')";
					}
					else
					{
						Utility.Engine.sql+=" AND UPPER(depo_mevcut.StokKodu) = UPPER('";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
						Utility.Engine.sql+="')";
					}
				}

                if (!SayimGoster)
                {
                    Utility.Engine.sql += " AND DepoKodu not in ('SAYIM')";
                }

				if(textBoxDepoKodu.Text.Length>0)
				{
					if(textBoxDepoKodu.Text.IndexOf("%") != -1)
					{
						Utility.Engine.sql+=" AND depo_mevcut.DepoKodu LIKE '";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
						Utility.Engine.sql+="%'";
					}
					else
					{
						Utility.Engine.sql+=" AND depo_mevcut.DepoKodu = '";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
						Utility.Engine.sql+="'";
					}
					
				}

				if(radioButtonStokBazinda.Checked==true)
				{
					Utility.Engine.sql+=" GROUP BY depo_mevcut.StokKodu ";
				}

				Utility.Engine.dat.GridDoldur(Utility.Engine.sql,ref dataGrid1,"SeriliDepoMevcut");
				
				try{menuItem_Bilgi.Text = ((System.Data.DataTable)dataGrid1.DataSource).Rows.Count.ToString();}
				catch{}
			}
			#endregion

			#region serisiz Stoklar
			if(comboBoxRaporTipi.Items[comboBoxRaporTipi.SelectedIndex].ToString()=="Serisiz Stoklar")
			{
                Utility.Engine.sql = @"SELECT depo_mevcut.DepoKodu,depo_mevcut.SeriliBarkod,depo_mevcut.StokKodu,stok_tanim_ust.StokAdi,depo_mevcut.Birim,depo_mevcut.Miktar FROM depo_mevcut (nolock)
						LEFT OUTER JOIN stok_tanim_ust (nolock) ON depo_mevcut.StokKodu=stok_tanim_ust.StokKodu 
						WHERE SeriliBarkod='' AND depo_mevcut.Miktar > 0 and depo_mevcut.DepoKodu not in (select AD from haric_depo (NOLOCK))  ";

				if(textBoxStokKodu.Text.Length>0)
				{
					if(textBoxStokKodu.Text.IndexOf("%") != -1)
					{
						Utility.Engine.sql+=" AND UPPER(depo_mevcut.StokKodu) LIKE UPPER('";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
						Utility.Engine.sql+="%')";
					}
					else
					{
						Utility.Engine.sql+=" AND UPPER(depo_mevcut.StokKodu) = UPPER('";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
						Utility.Engine.sql+="')";
					}
				}

                if (!SayimGoster)
                {
                    Utility.Engine.sql += " AND DepoKodu not in ('SAYIM')";
                }

				if(textBoxDepoKodu.Text.Length>0)
				{
					if(textBoxDepoKodu.Text.IndexOf("%") != -1)
					{
						Utility.Engine.sql+=" AND depo_mevcut.DepoKodu LIKE '";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
						Utility.Engine.sql+="%'";
					}
					else
					{
						Utility.Engine.sql+=" AND depo_mevcut.DepoKodu = '";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
						Utility.Engine.sql+="'";
					}
				}

				//Utility.Engine.sql += " GROUP BY depo_mevcut.DepoKodu, depo_mevcut.SeriliBarkod, depo_mevcut.StokKodu, stok_tanim_ust.StokAdi, depo_mevcut.Birim, depo_mevcut.Miktar";

				Utility.Engine.dat.GridDoldur(Utility.Engine.sql,ref dataGrid1,"SerisizDepoMevcut");

				try{menuItem_Bilgi.Text = ((System.Data.DataTable)dataGrid1.DataSource).Rows.Count.ToString();}
				catch{}
			}
			#endregion

			#region Tüm Stoklar
			if(comboBoxRaporTipi.Items[comboBoxRaporTipi.SelectedIndex].ToString()=="Tüm Stoklar")
			{
                Utility.Engine.sql = @"SELECT depo_mevcut.DepoKodu,depo_mevcut.SeriliBarkod,depo_mevcut.StokKodu,stok_tanim_ust.StokAdi,depo_mevcut.Birim,depo_mevcut.Miktar FROM depo_mevcut (nolock)
						LEFT OUTER JOIN stok_tanim_ust (nolock) ON depo_mevcut.StokKodu=stok_tanim_ust.StokKodu 
						WHERE 1=1 AND depo_mevcut.Miktar > 0 and depo_mevcut.DepoKodu not in (select AD from haric_depo (NOLOCK))  ";

				if(textBoxStokKodu.Text.Length>0)
				{
					if(textBoxStokKodu.Text.IndexOf("%") != -1)
					{
						Utility.Engine.sql+=" AND UPPER(depo_mevcut.StokKodu) LIKE UPPER('";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
						Utility.Engine.sql+="%')";
					}
					else
					{
						Utility.Engine.sql+=" AND UPPER(depo_mevcut.StokKodu) = UPPER('";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
						Utility.Engine.sql+="')";
					}
				}

                if (!SayimGoster)
                {
                    Utility.Engine.sql += " AND DepoKodu not in ('SAYIM')"; 
                }

				if(textBoxDepoKodu.Text.Length>0)
				{
					if(textBoxDepoKodu.Text.IndexOf("%") != -1)
					{
						Utility.Engine.sql+=" AND depo_mevcut.DepoKodu LIKE '";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
						Utility.Engine.sql+="%'";
					}
					else
					{
						Utility.Engine.sql+=" AND depo_mevcut.DepoKodu = '";
						Utility.Engine.sql+=Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
						Utility.Engine.sql+="'";
					}
				}

				Utility.Engine.dat.GridDoldur(Utility.Engine.sql,ref dataGrid1,"DepoMevcut");

				try{menuItem_Bilgi.Text = ((System.Data.DataTable)dataGrid1.DataSource).Rows.Count.ToString();}
				catch{}

			}
			#endregion
		}

		private void textBoxStokKodu_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter && checkBox_Barkod.Checked)
			{
                Utility.Engine.sql = " SELECT StokKodu FROM  stok_barkod (nolock) WHERE (Barkod = N'";
				Utility.Engine.sql += textBoxStokKodu.Text;
				Utility.Engine.sql += "')";
				textBoxStokKodu.Text = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);
			}
		}

        private void menuItem4_Click(object sender, System.EventArgs e)
        {
            if (comboBoxRaporTipi.SelectedIndex < 0)
                return;

            if (textBoxStokKodu.Text.Trim() == "" && textBoxDepoKodu.Text.Trim() == "")
            {
                MessageBox.Show("Stok veya Depo Alanlarindan Birini Doldurunuz..!");
                return;
            }

            #region serili Stoklar
            if (comboBoxRaporTipi.Items[comboBoxRaporTipi.SelectedIndex].ToString() == "Serili Stoklar")
            {
                if (radioButtonDetayBazinda.Checked == true)
                {
                    Utility.Engine.sql = @"SELECT depo_mevcut.DepoKodu,depo_mevcut.SeriliBarkod,depo_mevcut.StokKodu,stok_tanim_ust.StokAdi,depo_mevcut.Birim,depo_mevcut.Miktar FROM depo_mevcut (nolock) 
						LEFT OUTER JOIN stok_tanim_ust (nolock) ON depo_mevcut.StokKodu=stok_tanim_ust.StokKodu 
						WHERE SeriliBarkod<>'' AND depo_mevcut.Miktar > 0 and depo_mevcut.DepoKodu not in (select AD from haric_depo (NOLOCK)) ";
                }
                else
                {
                    Utility.Engine.sql = @"SELECT depo_mevcut.StokKodu,stok_tanim_ust.StokAdi,depo_mevcut.Birim,SUM(depo_mevcut.Miktar) AS Miktar FROM depo_mevcut (nolock) 
						LEFT OUTER JOIN stok_tanim_ust (nolock) ON depo_mevcut.StokKodu=stok_tanim_ust.StokKodu 
						WHERE SeriliBarkod<>'' AND depo_mevcut.Miktar > 0 and depo_mevcut.DepoKodu not in (select AD from haric_depo (NOLOCK))  ";
                }

                if (textBoxStokKodu.Text.Length > 0)
                {
                    if (textBoxStokKodu.Text.IndexOf("%") != -1)
                    {
                        Utility.Engine.sql += " AND UPPER(depo_mevcut.StokKodu) LIKE UPPER('";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
                        Utility.Engine.sql += "%')";
                    }
                    else
                    {
                        Utility.Engine.sql += " AND UPPER(depo_mevcut.StokKodu) = UPPER('";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
                        Utility.Engine.sql += "')";
                    }
                }

                if (textBoxDepoKodu.Text.Length > 0)
                {
                    if (textBoxDepoKodu.Text.IndexOf("%") != -1)
                    {
                        Utility.Engine.sql += " AND depo_mevcut.DepoKodu LIKE '";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
                        Utility.Engine.sql += "%'";
                    }
                    else
                    {
                        Utility.Engine.sql += " AND depo_mevcut.DepoKodu = '";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
                        Utility.Engine.sql += "'";
                    }

                }

                if (radioButtonStokBazinda.Checked == true)
                {
                    Utility.Engine.sql += " GROUP BY depo_mevcut.StokKodu ";
                }

                Utility.Engine.dat.GridDoldur(Utility.Engine.sql, ref dataGrid1, "SeriliDepoMevcut");
                menuItem_Bilgi.Text = dataGrid1.VisibleRowCount.ToString();
            }
            #endregion

            #region serisiz Stoklar
            if (comboBoxRaporTipi.Items[comboBoxRaporTipi.SelectedIndex].ToString() == "Serisiz Stoklar")
            {
                Utility.Engine.sql = @"SELECT depo_mevcut.DepoKodu,depo_mevcut.SeriliBarkod,depo_mevcut.StokKodu,stok_tanim_ust.StokAdi,depo_mevcut.Birim,depo_mevcut.Miktar FROM depo_mevcut (nolock)
						LEFT OUTER JOIN stok_tanim_ust (nolock) ON depo_mevcut.StokKodu=stok_tanim_ust.StokKodu 
						WHERE SeriliBarkod='' AND depo_mevcut.Miktar > 0 and depo_mevcut.DepoKodu not in (select AD from haric_depo (NOLOCK))  ";

                if (textBoxStokKodu.Text.Length > 0)
                {
                    if (textBoxStokKodu.Text.IndexOf("%") != -1)
                    {
                        Utility.Engine.sql += " AND UPPER(depo_mevcut.StokKodu) LIKE UPPER('";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
                        Utility.Engine.sql += "%')";
                    }
                    else
                    {
                        Utility.Engine.sql += " AND UPPER(depo_mevcut.StokKodu) = UPPER('";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
                        Utility.Engine.sql += "')";
                    }
                }

                if (textBoxDepoKodu.Text.Length > 0)
                {
                    if (textBoxDepoKodu.Text.IndexOf("%") != -1)
                    {
                        Utility.Engine.sql += " AND depo_mevcut.DepoKodu LIKE '";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
                        Utility.Engine.sql += "%'";
                    }
                    else
                    {
                        Utility.Engine.sql += " AND depo_mevcut.DepoKodu = '";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
                        Utility.Engine.sql += "'";
                    }
                }

                //Utility.Engine.sql += " GROUP BY depo_mevcut.DepoKodu, depo_mevcut.SeriliBarkod, depo_mevcut.StokKodu, stok_tanim_ust.StokAdi, depo_mevcut.Birim, depo_mevcut.Miktar";

                Utility.Engine.dat.GridDoldur(Utility.Engine.sql, ref dataGrid1, "SerisizDepoMevcut");
                menuItem_Bilgi.Text = dataGrid1.VisibleRowCount.ToString();
            }
            #endregion

            #region Tüm Stoklar
            if (comboBoxRaporTipi.Items[comboBoxRaporTipi.SelectedIndex].ToString() == "Tüm Stoklar")
            {
                Utility.Engine.sql = @"SELECT depo_mevcut.DepoKodu,depo_mevcut.StokKodu,stok_tanim_ust.StokAdi,depo_mevcut.Birim,SUM(depo_mevcut.Miktar) as Miktar FROM depo_mevcut (nolock)
						LEFT OUTER JOIN stok_tanim_ust (nolock) ON depo_mevcut.StokKodu=stok_tanim_ust.StokKodu 
						WHERE 1=1 AND depo_mevcut.Miktar > 0 and depo_mevcut.DepoKodu not in (select AD from haric_depo (NOLOCK))  ";

                if (textBoxStokKodu.Text.Length > 0)
                {
                    if (textBoxStokKodu.Text.IndexOf("%") != -1)
                    {
                        Utility.Engine.sql += " AND UPPER(depo_mevcut.StokKodu) LIKE UPPER('";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
                        Utility.Engine.sql += "%')";
                    }
                    else
                    {
                        Utility.Engine.sql += " AND UPPER(depo_mevcut.StokKodu) = UPPER('";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxStokKodu.Text);
                        Utility.Engine.sql += "')";
                    }
                }

                if (textBoxDepoKodu.Text.Length > 0)
                {
                    if (textBoxDepoKodu.Text.IndexOf("%") != -1)
                    {
                        Utility.Engine.sql += " AND depo_mevcut.DepoKodu LIKE '";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
                        Utility.Engine.sql += "%'";
                    }
                    else
                    {
                        Utility.Engine.sql += " AND depo_mevcut.DepoKodu = '";
                        Utility.Engine.sql += Utility.Engine.SqlTemizle(textBoxDepoKodu.Text);
                        Utility.Engine.sql += "'";
                    }
                }

                Utility.Engine.sql += " GROUP BY depo_mevcut.DepoKodu,depo_mevcut.StokKodu,stok_tanim_ust.StokAdi,depo_mevcut.Birim ";
                Utility.Engine.sql += " ORDER BY depo_mevcut.DepoKodu,depo_mevcut.StokKodu,stok_tanim_ust.StokAdi,depo_mevcut.Birim ";

                Utility.Engine.dat.GridDoldur(Utility.Engine.sql, ref dataGrid1, "DepoMevcut");
                menuItem_Bilgi.Text = dataGrid1.VisibleRowCount.ToString();

            }
            #endregion

        }
	}
}
