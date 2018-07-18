using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for Sec.
	/// </summary>
	public class Sec : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonCik;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBoxSorgu1;
		private System.Windows.Forms.TextBox textBoxSorgu2;
		private System.Windows.Forms.DataGrid dataGrid1;
		public string tablename;
		public string sql;
		public string sql_orderby,sql_where;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		//public Engine Utility.Engine;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn13;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn15;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn16;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn17;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn18;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn19;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn20;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle6;
		private System.Windows.Forms.DataGridTextBoxColumn siparisno;
		private System.Windows.Forms.DataGridTextBoxColumn cari;
		private System.Windows.Forms.DataGridTextBoxColumn cariadi;
		private System.Windows.Forms.DataGridTextBoxColumn alissatis;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle7;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn25;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn26;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn27;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn28;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn29;
		public  System.Data.DataRow dr;
	
		public Sec()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			sql_orderby="";
			sql_where="";

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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn20 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle4 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle5 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle6 = new System.Windows.Forms.DataGridTableStyle();
            this.siparisno = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cari = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cariadi = new System.Windows.Forms.DataGridTextBoxColumn();
            this.alissatis = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle7 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn25 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn26 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn27 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn28 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn29 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.textBoxSorgu1 = new System.Windows.Forms.TextBox();
            this.textBoxSorgu2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCik
            // 
            this.buttonCik.Location = new System.Drawing.Point(136, 248);
            this.buttonCik.Name = "buttonCik";
            this.buttonCik.Size = new System.Drawing.Size(88, 32);
            this.buttonCik.TabIndex = 5;
            this.buttonCik.Text = "ÇIK";
            this.buttonCik.Click += new System.EventHandler(this.buttonCik_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "TAMAM";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(2, 26);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(230, 214);
            this.dataGrid1.TabIndex = 3;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle2);
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle3);
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle4);
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle5);
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle6);
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle7);
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.MappingName = "StokTanimlari";
            // 
            // dataGridTextBoxColumn1
            // 
             
            this.dataGridTextBoxColumn1.HeaderText = "Ürün Kod";
            this.dataGridTextBoxColumn1.MappingName = "StokKodu";
            this.dataGridTextBoxColumn1.Width = 5;
            // 
            // dataGridTextBoxColumn2
            // 
      
            this.dataGridTextBoxColumn2.HeaderText = "Ürün Ad";
            this.dataGridTextBoxColumn2.MappingName = "StokAdi";
            this.dataGridTextBoxColumn2.Width = 225;
            // 
            // dataGridTextBoxColumn3
            // 
        
            this.dataGridTextBoxColumn3.HeaderText = "Barkod";
            this.dataGridTextBoxColumn3.MappingName = "Barkod";
            this.dataGridTextBoxColumn3.Width = 5;
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle2.MappingName = "CariAdres";
            // 
            // dataGridTextBoxColumn5
            // 
           
            this.dataGridTextBoxColumn5.HeaderText = "Adres1";
            this.dataGridTextBoxColumn5.MappingName = "Adres1";
            this.dataGridTextBoxColumn5.Width = 200;
            // 
            // dataGridTextBoxColumn6
            // 
         
            this.dataGridTextBoxColumn6.HeaderText = "Adres2";
            this.dataGridTextBoxColumn6.MappingName = "Adres2";
            this.dataGridTextBoxColumn6.Width = 200;
            // 
            // dataGridTextBoxColumn7
            // 
           
            this.dataGridTextBoxColumn7.HeaderText = "Adres3";
            this.dataGridTextBoxColumn7.MappingName = "Adres3";
            this.dataGridTextBoxColumn7.Width = 200;
            // 
            // dataGridTextBoxColumn4
            // 
 
            this.dataGridTextBoxColumn4.HeaderText = "CariKod";
            this.dataGridTextBoxColumn4.MappingName = "CariKod";
            this.dataGridTextBoxColumn4.Width = 0;
            // 
            // dataGridTableStyle3
            // 
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn10);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn11);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn12);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn13);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn20);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn21);
            this.dataGridTableStyle3.MappingName = "stok_hareket_ust";
            // 
            // dataGridTextBoxColumn8
            // 
 
            this.dataGridTextBoxColumn8.HeaderText = "BelgeNo";
            this.dataGridTextBoxColumn8.MappingName = "BelgeNo";
            // 
            // dataGridTextBoxColumn9
            // 
 
            this.dataGridTextBoxColumn9.HeaderText = "Çikan Depo";
            this.dataGridTextBoxColumn9.MappingName = "CikanDepo";
            this.dataGridTextBoxColumn9.Width = 70;
            // 
            // dataGridTextBoxColumn10
            // 
 
            this.dataGridTextBoxColumn10.HeaderText = "Giren Depo";
            this.dataGridTextBoxColumn10.MappingName = "GirenDepo";
            this.dataGridTextBoxColumn10.Width = 70;
            // 
            // dataGridTextBoxColumn11
            // 
   ;
            this.dataGridTextBoxColumn11.HeaderText = "Kullanici";
            this.dataGridTextBoxColumn11.MappingName = "KullaniciID";
            this.dataGridTextBoxColumn11.Width = 100;
            // 
            // dataGridTextBoxColumn12
            // 
       
            this.dataGridTextBoxColumn12.HeaderText = "Tarih";
            this.dataGridTextBoxColumn12.MappingName = "Tarih";
            this.dataGridTextBoxColumn12.Width = 80;
            // 
            // dataGridTextBoxColumn13
            // 
 
            this.dataGridTextBoxColumn13.HeaderText = "Saat";
            this.dataGridTextBoxColumn13.MappingName = "Saat";
            // 
            // dataGridTextBoxColumn20
            // 
    
            this.dataGridTextBoxColumn20.HeaderText = "Açiklama 1";
            this.dataGridTextBoxColumn20.MappingName = "Aciklama1";
            this.dataGridTextBoxColumn20.Width = 90;
            // 
            // dataGridTextBoxColumn21
            // 
 
            this.dataGridTextBoxColumn21.HeaderText = "Açiklama 2";
            this.dataGridTextBoxColumn21.MappingName = "Aciklama2";
            this.dataGridTextBoxColumn21.Width = 90;
            // 
            // dataGridTableStyle4
            // 
            this.dataGridTableStyle4.GridColumnStyles.Add(this.dataGridTextBoxColumn14);
            this.dataGridTableStyle4.GridColumnStyles.Add(this.dataGridTextBoxColumn15);
            this.dataGridTableStyle4.GridColumnStyles.Add(this.dataGridTextBoxColumn16);
            this.dataGridTableStyle4.GridColumnStyles.Add(this.dataGridTextBoxColumn17);
            this.dataGridTableStyle4.GridColumnStyles.Add(this.dataGridTextBoxColumn18);
            this.dataGridTableStyle4.GridColumnStyles.Add(this.dataGridTextBoxColumn19);
            this.dataGridTableStyle4.MappingName = "stok_tanim_detay";
            // 
            // dataGridTextBoxColumn14
            // 
            
            
            this.dataGridTextBoxColumn14.HeaderText = "Stok Kodu";
            this.dataGridTextBoxColumn14.MappingName = "StokKodu";
            // 
            // dataGridTextBoxColumn15
            // 
           
            this.dataGridTextBoxColumn15.HeaderText = "Stok Adi";
            this.dataGridTextBoxColumn15.MappingName = "StokAdi";
            this.dataGridTextBoxColumn15.Width = 120;
            // 
            // dataGridTextBoxColumn16
            // 
         
            this.dataGridTextBoxColumn16.HeaderText = "Birim";
            this.dataGridTextBoxColumn16.MappingName = "Birim";
            // 
            // dataGridTextBoxColumn17
            // 
           
            this.dataGridTextBoxColumn17.HeaderText = "Aciklama1";
            this.dataGridTextBoxColumn17.MappingName = "Aciklama1";
            // 
            // dataGridTextBoxColumn18
            // 
            
            this.dataGridTextBoxColumn18.HeaderText = "Diger1";
            this.dataGridTextBoxColumn18.MappingName = "Diger1";
            // 
            // dataGridTextBoxColumn19
            // 
         
            this.dataGridTextBoxColumn19.HeaderText = "Diger2";
            this.dataGridTextBoxColumn19.MappingName = "Diger2";
            // 
            // dataGridTableStyle5
            // 
            this.dataGridTableStyle5.GridColumnStyles.Add(this.dataGridTextBoxColumn22);
            this.dataGridTableStyle5.GridColumnStyles.Add(this.dataGridTextBoxColumn23);
            this.dataGridTableStyle5.MappingName = "cari_tanim";
            // 
            // dataGridTextBoxColumn22
            // 
   
            this.dataGridTextBoxColumn22.HeaderText = "Cari Kodu";
            this.dataGridTextBoxColumn22.MappingName = "CariKodu";
            this.dataGridTextBoxColumn22.Width = 90;
            // 
            // dataGridTextBoxColumn23
            // 
   
            this.dataGridTextBoxColumn23.HeaderText = "Cari Adi";
            this.dataGridTextBoxColumn23.MappingName = "CariAdi";
            this.dataGridTextBoxColumn23.Width = 100;
            // 
            // dataGridTableStyle6
            // 
            this.dataGridTableStyle6.GridColumnStyles.Add(this.siparisno);
            this.dataGridTableStyle6.GridColumnStyles.Add(this.cari);
            this.dataGridTableStyle6.GridColumnStyles.Add(this.cariadi);
            this.dataGridTableStyle6.GridColumnStyles.Add(this.alissatis);
            this.dataGridTableStyle6.GridColumnStyles.Add(this.dataGridTextBoxColumn24);
            this.dataGridTableStyle6.MappingName = "siparisler";
            // 
            // siparisno
            // 
      
            this.siparisno.HeaderText = "SiparisNo";
            this.siparisno.MappingName = "SiparisNo";
            this.siparisno.NullText = "";
            // 
            // cari
            // 
          
            this.cari.HeaderText = "CariKodu";
            this.cari.MappingName = "CariKodu";
            this.cari.NullText = "";
            // 
            // cariadi
            // 
     
            this.cariadi.HeaderText = "CariAdi";
            this.cariadi.MappingName = "CariAdi";
            this.cariadi.NullText = "";
            this.cariadi.Width = 120;
            // 
            // alissatis
            // 

            this.alissatis.HeaderText = "AlisSatis";
            this.alissatis.MappingName = "AlisSatis";
            this.alissatis.NullText = "";
            // 
            // dataGridTextBoxColumn24
            // 

            this.dataGridTextBoxColumn24.HeaderText = "SevkAdresi";
            this.dataGridTextBoxColumn24.MappingName = "SevkAdresi";
            this.dataGridTextBoxColumn24.NullText = "";
            // 
            // dataGridTableStyle7
            // 
            this.dataGridTableStyle7.GridColumnStyles.Add(this.dataGridTextBoxColumn25);
            this.dataGridTableStyle7.GridColumnStyles.Add(this.dataGridTextBoxColumn26);
            this.dataGridTableStyle7.GridColumnStyles.Add(this.dataGridTextBoxColumn27);
            this.dataGridTableStyle7.GridColumnStyles.Add(this.dataGridTextBoxColumn28);
            this.dataGridTableStyle7.GridColumnStyles.Add(this.dataGridTextBoxColumn29);
            this.dataGridTableStyle7.MappingName = "hareket_tanim";
            // 
            // dataGridTextBoxColumn25
            // 
   
            this.dataGridTextBoxColumn25.HeaderText = "HareketKodu";
            this.dataGridTextBoxColumn25.MappingName = "HareketKodu";
            this.dataGridTextBoxColumn25.NullText = "";
            this.dataGridTextBoxColumn25.Width = 70;
            // 
            // dataGridTextBoxColumn26
            // 
           
            this.dataGridTextBoxColumn26.HeaderText = "HareketAdi";
            this.dataGridTextBoxColumn26.MappingName = "HareketAdi";
            this.dataGridTextBoxColumn26.NullText = "";
            this.dataGridTextBoxColumn26.Width = 150;
            // 
            // dataGridTextBoxColumn27
            // 
           
            this.dataGridTextBoxColumn27.HeaderText = "OzelKod";
            this.dataGridTextBoxColumn27.MappingName = "OzelKod";
            this.dataGridTextBoxColumn27.NullText = "";
            this.dataGridTextBoxColumn27.Width = 40;
            // 
            // dataGridTextBoxColumn28
            // 

            this.dataGridTextBoxColumn28.HeaderText = "VarGirisDeposu";
            this.dataGridTextBoxColumn28.MappingName = "VarGirisDeposu";
            this.dataGridTextBoxColumn28.NullText = "";
            // 
            // dataGridTextBoxColumn29
            // 
 
            this.dataGridTextBoxColumn29.HeaderText = "VarCikisDeposu";
            this.dataGridTextBoxColumn29.MappingName = "VarCikisDeposu";
            this.dataGridTextBoxColumn29.NullText = "";
            // 
            // textBoxSorgu1
            // 
            this.textBoxSorgu1.Location = new System.Drawing.Point(3, 2);
            this.textBoxSorgu1.Name = "textBoxSorgu1";
            this.textBoxSorgu1.Size = new System.Drawing.Size(85, 23);
            this.textBoxSorgu1.TabIndex = 2;
            this.textBoxSorgu1.GotFocus += new System.EventHandler(this.textBoxSorgu1_GotFocus);
            this.textBoxSorgu1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSorgu1_KeyUp);
            this.textBoxSorgu1.LostFocus += new System.EventHandler(this.textBoxSorgu1_LostFocus);
            // 
            // textBoxSorgu2
            // 
            this.textBoxSorgu2.Location = new System.Drawing.Point(112, 2);
            this.textBoxSorgu2.Name = "textBoxSorgu2";
            this.textBoxSorgu2.Size = new System.Drawing.Size(104, 23);
            this.textBoxSorgu2.TabIndex = 1;
            this.textBoxSorgu2.TextChanged += new System.EventHandler(this.textBoxSorgu2_TextChanged);
            this.textBoxSorgu2.GotFocus += new System.EventHandler(this.textBoxSorgu2_GotFocus);
            this.textBoxSorgu2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSorgu2_KeyUp);
            this.textBoxSorgu2.LostFocus += new System.EventHandler(this.textBoxSorgu2_LostFocus);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 22);
            this.button2.TabIndex = 0;
            this.button2.Text = "T";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 22);
            this.button3.TabIndex = 6;
            this.button3.Text = "T";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Sec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSorgu2);
            this.Controls.Add(this.textBoxSorgu1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCik);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sec";
            this.Text = "Sec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sec_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void Sec_Load(object sender, System.EventArgs e)
		{
			dataGrid1.RowHeadersVisible=false;
			button1.DialogResult=DialogResult.OK;
			buttonCik.DialogResult=DialogResult.Cancel;
			Utility.Engine.dat.GridDoldur(sql + sql_where + sql_orderby,ref dataGrid1,tablename);
			dataGrid1.Refresh();
			textBoxSorgu1.Focus();
			return;
		}

		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
			try
			{
				dataGrid1.Select(dataGrid1.CurrentRowIndex);
			}
			catch(Exception)
			{
			}

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(dataGrid1.CurrentRowIndex>-1)
				{
					dr=((System.Data.DataTable)dataGrid1.DataSource).NewRow();
	
					for(int i=0;i<dr.ItemArray.Length;i++)
					{
						try
						{
							dr[i]=dataGrid1[dataGrid1.CurrentRowIndex,i].ToString();
						}
						catch(Exception)
						{
						}
					}
				}
			}
			catch(Exception)
			{
			}


			DialogResult=DialogResult.OK;
			Close();

		}

		private void buttonCik_Click(object sender, System.EventArgs e)
		{
			DialogResult=DialogResult.Cancel;
			Close();
		}

		private void textBoxSorgu2_GotFocus(object sender, System.EventArgs e)
		{
			Utility.Engine.KlavyeAc(true);
		}

		private void textBoxSorgu2_LostFocus(object sender, System.EventArgs e)
		{
			Utility.Engine.KlavyeAc(false);
		}

		private void textBoxSorgu1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyData==Keys.Enter || tablename=="CariAdres")
			{
				try
				{
					if(sql_where.Length<1)
						Utility.Engine.dat.GridDoldur(sql + " WHERE " + dataGrid1.TableStyles[tablename].GridColumnStyles[0].MappingName + " LIKE '" + Utility.Engine.SqlTemizle(textBoxSorgu1.Text.ToUpper()) + "%'" + sql_orderby,ref dataGrid1,tablename);
					else
						Utility.Engine.dat.GridDoldur(sql + sql_where + " AND " + dataGrid1.TableStyles[tablename].GridColumnStyles[0].MappingName + " LIKE '%" + Utility.Engine.SqlTemizle(textBoxSorgu1.Text.ToUpper()) + "%'" + sql_orderby,ref dataGrid1,tablename);
				}
				catch(Exception)
				{
				}
			}
		}

		private void textBoxSorgu2_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyData==Keys.Enter)
			{
				try
				{
					if(sql_where.Length<1)
						Utility.Engine.dat.GridDoldur(sql + " WHERE " + dataGrid1.TableStyles[tablename].GridColumnStyles[1].MappingName + " LIKE '%" + Utility.Engine.SqlTemizle(textBoxSorgu2.Text.ToUpper()) + "%'" + sql_orderby,ref dataGrid1,tablename);
					else
						Utility.Engine.dat.GridDoldur(sql + sql_where + " AND " + dataGrid1.TableStyles[tablename].GridColumnStyles[1].MappingName + " LIKE '%" + Utility.Engine.SqlTemizle(textBoxSorgu2.Text.ToUpper()) + "%'" + sql_orderby,ref dataGrid1,tablename);

				}
				catch(Exception)
				{
				}
			}
		}

		private void textBoxSorgu2_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(sql_where.Length<1)
					Utility.Engine.dat.GridDoldur(sql + " WHERE " + dataGrid1.TableStyles[tablename].GridColumnStyles[1].MappingName + " LIKE '%" + Utility.Engine.SqlTemizle(textBoxSorgu2.Text.ToUpper()) + "%'" + sql_orderby,ref dataGrid1,tablename);
				else
					Utility.Engine.dat.GridDoldur(sql + sql_where + " AND " + dataGrid1.TableStyles[tablename].GridColumnStyles[1].MappingName + " LIKE '%" + Utility.Engine.SqlTemizle(textBoxSorgu2.Text.ToUpper()) + "%'" + sql_orderby,ref dataGrid1,tablename);
			}
			catch(Exception)
			{
			}
		}

		private void textBoxSorgu1_GotFocus(object sender, System.EventArgs e)
		{
			if(tablename=="CariAdres")
				Utility.Engine.KlavyeAc(true);
		}

		private void textBoxSorgu1_LostFocus(object sender, System.EventArgs e)
		{
			if(tablename=="CariAdres")
				Utility.Engine.KlavyeAc(false);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBoxSorgu1.Text;
			if(t.ShowDialog() == DialogResult.OK)
				textBoxSorgu1.Text = t.textBox1.Text;
			textBoxSorgu1.Focus();
			textBoxSorgu1.SelectionStart = textBoxSorgu1.Text.Length;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Tus t = new Tus();
			t.textBox1.Text = textBoxSorgu2.Text;
			if(t.ShowDialog() == DialogResult.OK)
				textBoxSorgu2.Text = t.textBox1.Text;
			textBoxSorgu2.Focus();
			textBoxSorgu2.SelectionStart = textBoxSorgu2.Text.Length;
		}
	}
}
