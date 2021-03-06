using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for StokTransferEkBilgi.
	/// </summary>
	public class StokTransferEkBilgi : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox textBoxAciklama1;
		private System.Windows.Forms.Button buttonAciklama1Sil;
		public System.Windows.Forms.TextBox textBoxAciklama2;
		private System.Windows.Forms.Button buttonAciklama2Sil;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox textBoxCariKod;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCariKodSec;
		private System.Windows.Forms.Button buttonIrsaliyeNoSil;
		public System.Windows.Forms.TextBox textBoxIrsaliyeNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelTarih;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonCariKodSil;
		private System.Windows.Forms.Button buttonHareketKoduSil;
		private System.Windows.Forms.Button buttonCik;        
		public System.Windows.Forms.ComboBox comboBoxHareketTipi;
		public System.Windows.Forms.Label label_HAREKET;
		private System.Windows.Forms.Label label7;
		//public Engine Utility.Engine;
		private System.Windows.Forms.Label labelCariAdi;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelSevk;
		public bool SiparisIliski = false;
		public string VAR_GIREN_DEPO = "",VAR_CIKAN_DEPO = "";
		public bool iade = false;//pratik cozum
	
		public StokTransferEkBilgi()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            //m_picker1 = new TOLGA.DateTimePicker();
            //m_picker1.Location = labelTarih.Location;
            //m_picker1.Size = labelTarih.Size;
            //labelTarih.Parent.Controls.Add(m_picker1);
            //labelTarih.Parent.Controls.Remove(labelTarih);
            //m_picker1.Format=TOLGA.DateTimePickerFormat.Short;

			textBoxAciklama1.Text="";
			textBoxAciklama2.Text="";
			textBoxCariKod.Text="";
			comboBoxHareketTipi.SelectedIndex=-1;
			textBoxIrsaliyeNo.Text="";
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
			this.textBoxAciklama1 = new System.Windows.Forms.TextBox();
			this.buttonAciklama1Sil = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxAciklama2 = new System.Windows.Forms.TextBox();
			this.buttonAciklama2Sil = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxCariKod = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonCariKodSec = new System.Windows.Forms.Button();
			this.buttonIrsaliyeNoSil = new System.Windows.Forms.Button();
			this.textBoxIrsaliyeNo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelTarih = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonCariKodSil = new System.Windows.Forms.Button();
			this.buttonHareketKoduSil = new System.Windows.Forms.Button();
			this.buttonCik = new System.Windows.Forms.Button();
			this.comboBoxHareketTipi = new System.Windows.Forms.ComboBox();
			this.label_HAREKET = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.labelCariAdi = new System.Windows.Forms.Label();
			this.labelSevk = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			// 
			// textBoxAciklama1
			// 
			this.textBoxAciklama1.Location = new System.Drawing.Point(72, 0);
			this.textBoxAciklama1.Size = new System.Drawing.Size(128, 20);
			this.textBoxAciklama1.Text = "";
			// 
			// buttonAciklama1Sil
			// 
			this.buttonAciklama1Sil.Location = new System.Drawing.Point(208, 0);
			this.buttonAciklama1Sil.Size = new System.Drawing.Size(24, 20);
			this.buttonAciklama1Sil.Text = "X";
			this.buttonAciklama1Sil.Click += new System.EventHandler(this.buttonAciklama1Sil_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(0, 8);
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.Text = "Açiklama 1:";
			// 
			// textBoxAciklama2
			// 
			this.textBoxAciklama2.Location = new System.Drawing.Point(72, 24);
			this.textBoxAciklama2.Size = new System.Drawing.Size(128, 20);
			this.textBoxAciklama2.Text = "";
			// 
			// buttonAciklama2Sil
			// 
			this.buttonAciklama2Sil.Location = new System.Drawing.Point(208, 24);
			this.buttonAciklama2Sil.Size = new System.Drawing.Size(24, 20);
			this.buttonAciklama2Sil.Text = "X";
			this.buttonAciklama2Sil.Click += new System.EventHandler(this.buttonAciklama2Sil_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 24);
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.Text = "Açiklama 2:";
			// 
			// textBoxCariKod
			// 
			this.textBoxCariKod.Enabled = false;
			this.textBoxCariKod.Location = new System.Drawing.Point(72, 48);
			this.textBoxCariKod.Size = new System.Drawing.Size(104, 20);
			this.textBoxCariKod.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 48);
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.Text = "Cari Kod:";
			// 
			// buttonCariKodSec
			// 
			this.buttonCariKodSec.Location = new System.Drawing.Point(183, 48);
			this.buttonCariKodSec.Size = new System.Drawing.Size(24, 20);
			this.buttonCariKodSec.Text = "...";
			this.buttonCariKodSec.Click += new System.EventHandler(this.buttonCariKodSec_Click);
			// 
			// buttonIrsaliyeNoSil
			// 
			this.buttonIrsaliyeNoSil.Location = new System.Drawing.Point(208, 128);
			this.buttonIrsaliyeNoSil.Size = new System.Drawing.Size(24, 20);
			this.buttonIrsaliyeNoSil.Text = "X";
			this.buttonIrsaliyeNoSil.Click += new System.EventHandler(this.buttonIrsaliyeNoSil_Click);
			// 
			// textBoxIrsaliyeNo
			// 
			this.textBoxIrsaliyeNo.Location = new System.Drawing.Point(72, 128);
			this.textBoxIrsaliyeNo.Size = new System.Drawing.Size(128, 20);
			this.textBoxIrsaliyeNo.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 128);
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.Text = "irsaliye No:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(0, 152);
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.Text = "irsaliye Tarih:";
			// 
			// labelTarih
			// 
			this.labelTarih.Location = new System.Drawing.Point(72, 152);
			this.labelTarih.Size = new System.Drawing.Size(160, 20);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(0, 184);
			this.label5.Size = new System.Drawing.Size(83, 16);
			this.label5.Text = "Hareket Tipi:";
			// 
			// buttonCariKodSil
			// 
			this.buttonCariKodSil.Location = new System.Drawing.Point(208, 48);
			this.buttonCariKodSil.Size = new System.Drawing.Size(24, 20);
			this.buttonCariKodSil.Text = "X";
			this.buttonCariKodSil.Click += new System.EventHandler(this.buttonCariKodSil_Click);
			// 
			// buttonHareketKoduSil
			// 
			this.buttonHareketKoduSil.Location = new System.Drawing.Point(208, 184);
			this.buttonHareketKoduSil.Size = new System.Drawing.Size(24, 20);
			this.buttonHareketKoduSil.Text = "X";
			this.buttonHareketKoduSil.Click += new System.EventHandler(this.buttonHareketKoduSil_Click);
			// 
			// buttonCik
			// 
			this.buttonCik.Location = new System.Drawing.Point(128, 240);
			this.buttonCik.Size = new System.Drawing.Size(96, 32);
			this.buttonCik.Text = "ÇIK";
			this.buttonCik.Click += new System.EventHandler(this.buttonCik_Click);
			// 
			// comboBoxHareketTipi
			// 
			this.comboBoxHareketTipi.Location = new System.Drawing.Point(72, 176);
			this.comboBoxHareketTipi.Size = new System.Drawing.Size(128, 21);
			this.comboBoxHareketTipi.SelectedIndexChanged += new System.EventHandler(this.comboBoxHareketTipi_SelectedIndexChanged);
			// 
			// label_HAREKET
			// 
			this.label_HAREKET.Location = new System.Drawing.Point(72, 216);
			this.label_HAREKET.Size = new System.Drawing.Size(128, 20);
			this.label_HAREKET.ParentChanged += new System.EventHandler(this.label_HAREKET_ParentChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(0, 216);
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.Text = "Hareket Ozel:";
			// 
			// labelCariAdi
			// 
			this.labelCariAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
			this.labelCariAdi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelCariAdi.Location = new System.Drawing.Point(0, 72);
			this.labelCariAdi.Size = new System.Drawing.Size(232, 20);
			this.labelCariAdi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelSevk
			// 
			this.labelSevk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
			this.labelSevk.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelSevk.Location = new System.Drawing.Point(0, 104);
			this.labelSevk.Size = new System.Drawing.Size(232, 24);
			this.labelSevk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelSevk.ParentChanged += new System.EventHandler(this.labelSevk_ParentChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
			this.panel1.Location = new System.Drawing.Point(0, 96);
			this.panel1.Size = new System.Drawing.Size(384, 5);
			// 
			// StokTransferEkBilgi
			// 
			this.ClientSize = new System.Drawing.Size(498, 455);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.labelCariAdi);
			this.Controls.Add(this.label_HAREKET);
			this.Controls.Add(this.comboBoxHareketTipi);
			this.Controls.Add(this.buttonCik);
			this.Controls.Add(this.buttonHareketKoduSil);
			this.Controls.Add(this.buttonCariKodSil);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelTarih);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonIrsaliyeNoSil);
			this.Controls.Add(this.textBoxIrsaliyeNo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonCariKodSec);
			this.Controls.Add(this.textBoxCariKod);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxAciklama2);
			this.Controls.Add(this.buttonAciklama2Sil);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxAciklama1);
			this.Controls.Add(this.buttonAciklama1Sil);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.labelSevk);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Text = "Stok Transfer Ek Bilgi";
			this.Load += new System.EventHandler(this.StokTransferEkBilgi_Load);

		}
		#endregion

		private void StokTransferEkBilgi_Load(object sender, System.EventArgs e)
		{
		}

		private void buttonAciklama1Sil_Click(object sender, System.EventArgs e)
		{
			textBoxAciklama1.Text="";
		}

		private void buttonAciklama2Sil_Click(object sender, System.EventArgs e)
		{
			textBoxAciklama2.Text="";
		}

		private void buttonCariKodSil_Click(object sender, System.EventArgs e)
		{
			textBoxCariKod.Text="";
		}

		private void buttonIrsaliyeNoSil_Click(object sender, System.EventArgs e)
		{
			textBoxIrsaliyeNo.Text="";
		}

		private void buttonHareketKoduSil_Click(object sender, System.EventArgs e)
		{
			comboBoxHareketTipi.SelectedIndex=-1;
		}

		private void buttonCik_Click(object sender, System.EventArgs e)
		{
			if(SiparisIliski && textBoxIrsaliyeNo.Text == "")
			{
				if(MessageBox.Show("iRSALiYE KODUNU GiRMEDEN işLEM YAPILAMAZ!\nÇIKMAK iSTiYORMUSUNUZ?","DiKKAT!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)Close();
				else textBoxIrsaliyeNo.Focus();
				return;
			}
			Close();
		}

		private void buttonCariKodSec_Click(object sender, System.EventArgs e)
		{
			if(SiparisIliski)
			{
				Sec s=new Sec();
				s.sql="SELECT DISTINCT TOP 10 siparisler.SiparisNo, siparisler.CariKodu, cari_tanim.CariAdi, siparisler.AlisSatis, siparisler.SevkAdresi FROM siparisler INNER JOIN cari_tanim ON siparisler.CariKodu = cari_tanim.CariKodu";
				s.sql_orderby=" ORDER BY siparisler.SiparisNo";
				s.tablename="siparisler";
				
				s.ShowDialog();
				if(s.dr!=null)
				{
					textBoxCariKod.Text=s.dr["CariKodu"].ToString();
					textBoxIrsaliyeNo.Text = s.dr["SiparisNo"].ToString();
					labelCariAdi.Text = s.dr["CariAdi"].ToString();
					labelSevk.Text = s.dr["SevkAdresi"].ToString();
				}
			}
			else
			{
				Sec s=new Sec();
				s.sql="SELECT TOP 10 CariKodu,CariAdi FROM cari_tanim (NOLOCK)";
				s.sql_orderby=" ORDER BY CariKodu";
				s.tablename="cari_tanim";
				
				s.ShowDialog();
				if(s.dr!=null)
				{
					textBoxCariKod.Text=s.dr["CariKodu"].ToString();
					labelCariAdi.Text = s.dr["CariAdi"].ToString();
				}
			}
		}

		private void comboBoxHareketTipi_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				VAR_CIKAN_DEPO =
				VAR_GIREN_DEPO = 
				label_HAREKET.Text = "";
				SiparisIliski = false;
				if(comboBoxHareketTipi.SelectedItem != null)
				{
					iade = comboBoxHareketTipi.SelectedItem.ToString().Equals("IADE");
					Utility.Engine.sql = string.Format("SELECT OzelKod,VarGirisDeposu,VarCikisDeposu FROM hareket_tanim (NOLOCK) WHERE  (SiparisIliski = 'E') AND (HareketKodu = N'{0}')",comboBoxHareketTipi.SelectedItem.ToString());

					System.Data.IDataReader dr = Utility.Engine.dat.TSelect(Utility.Engine.sql);

					if (dr != null && dr.Read())
					{
						if (dr["OzelKod"] != DBNull.Value)
						{
							label_HAREKET.Text = dr["OzelKod"].ToString();
							SiparisIliski = true;
							buttonCariKodSec_Click(null,null);
						}

						if (dr["VarGirisDeposu"] != DBNull.Value)
						{
							VAR_GIREN_DEPO = dr["VarGirisDeposu"].ToString();
						}
						if (dr["VarCikisDeposu"] != DBNull.Value)
						{
							VAR_CIKAN_DEPO = dr["VarCikisDeposu"].ToString();
						}
					}
					if (dr != null) dr.Close();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("HAREKET ÖZEL KODU SUNUCUDAN SORGULANIRKEN HATA OLUşTU","DiKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
				return;
			}
		}

		private void label_HAREKET_ParentChanged(object sender, System.EventArgs e)
		{
		
		}

		private void labelSevk_ParentChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
