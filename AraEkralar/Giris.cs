#define CASIO
using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Text;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for Giris.
	/// </summary>
	/// 

	public class Giris : System.Windows.Forms.Form
	{
		public	bool sonuc;
		////public Engine Utility.Engine;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonTamam;
		public System.Windows.Forms.ComboBox comboBoxKullaniciID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxParola;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCik;
		private System.Windows.Forms.TextBox textBoxTerminalNo;
		private System.Windows.Forms.Label label5;
        private Label label3;
        private TextBox textBox1;
      public string faturano;
      private CheckBox chckbox_sifre_degis;
      private Panel pnl_sifre_degistir;
      private TextBox yeni_sifre_1;
      private Label lbl_yeni_parola1;
      private TextBox yeni_sifre_2;
      private Label lbl_yeni_parola2;
      public string INDIR = "Flash Disk";
      string Baglanti = "", IP;
      private Label lblIP;

//		protected ImageButton ibOK;

		public Giris()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIP = new System.Windows.Forms.Label();
            this.pnl_sifre_degistir = new System.Windows.Forms.Panel();
            this.yeni_sifre_1 = new System.Windows.Forms.TextBox();
            this.lbl_yeni_parola1 = new System.Windows.Forms.Label();
            this.yeni_sifre_2 = new System.Windows.Forms.TextBox();
            this.lbl_yeni_parola2 = new System.Windows.Forms.Label();
            this.chckbox_sifre_degis = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKullaniciID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTerminalNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.buttonCik = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnl_sifre_degistir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lblIP);
            this.panel2.Controls.Add(this.pnl_sifre_degistir);
            this.panel2.Controls.Add(this.chckbox_sifre_degis);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxKullaniciID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxParola);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxTerminalNo);
            this.panel2.Controls.Add(this.label5);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.GotFocus += new System.EventHandler(this.panel2_GotFocus);
            // 
            // lblIP
            // 
            resources.ApplyResources(this.lblIP, "lblIP");
            this.lblIP.Name = "lblIP";
            // 
            // pnl_sifre_degistir
            // 
            this.pnl_sifre_degistir.Controls.Add(this.yeni_sifre_1);
            this.pnl_sifre_degistir.Controls.Add(this.lbl_yeni_parola1);
            this.pnl_sifre_degistir.Controls.Add(this.yeni_sifre_2);
            this.pnl_sifre_degistir.Controls.Add(this.lbl_yeni_parola2);
            resources.ApplyResources(this.pnl_sifre_degistir, "pnl_sifre_degistir");
            this.pnl_sifre_degistir.Name = "pnl_sifre_degistir";
            // 
            // yeni_sifre_1
            // 
            resources.ApplyResources(this.yeni_sifre_1, "yeni_sifre_1");
            this.yeni_sifre_1.Name = "yeni_sifre_1";
            // 
            // lbl_yeni_parola1
            // 
            resources.ApplyResources(this.lbl_yeni_parola1, "lbl_yeni_parola1");
            this.lbl_yeni_parola1.ForeColor = System.Drawing.Color.Black;
            this.lbl_yeni_parola1.Name = "lbl_yeni_parola1";
            // 
            // yeni_sifre_2
            // 
            resources.ApplyResources(this.yeni_sifre_2, "yeni_sifre_2");
            this.yeni_sifre_2.Name = "yeni_sifre_2";
            // 
            // lbl_yeni_parola2
            // 
            resources.ApplyResources(this.lbl_yeni_parola2, "lbl_yeni_parola2");
            this.lbl_yeni_parola2.ForeColor = System.Drawing.Color.Black;
            this.lbl_yeni_parola2.Name = "lbl_yeni_parola2";
            // 
            // chckbox_sifre_degis
            // 
            resources.ApplyResources(this.chckbox_sifre_degis, "chckbox_sifre_degis");
            this.chckbox_sifre_degis.Name = "chckbox_sifre_degis";
            this.chckbox_sifre_degis.CheckStateChanged += new System.EventHandler(this.chckbox_sifre_degis_CheckStateChanged);
            this.chckbox_sifre_degis.EnabledChanged += new System.EventHandler(this.chckbox_sifre_degis_EnabledChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // comboBoxKullaniciID
            // 
            resources.ApplyResources(this.comboBoxKullaniciID, "comboBoxKullaniciID");
            this.comboBoxKullaniciID.Name = "comboBoxKullaniciID";
            this.comboBoxKullaniciID.SelectedIndexChanged += new System.EventHandler(this.comboBoxKullaniciID_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // textBoxParola
            // 
            this.textBoxParola.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.textBoxParola, "textBoxParola");
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxParola_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // textBoxTerminalNo
            // 
            this.textBoxTerminalNo.BackColor = System.Drawing.Color.Bisque;
            resources.ApplyResources(this.textBoxTerminalNo, "textBoxTerminalNo");
            this.textBoxTerminalNo.Name = "textBoxTerminalNo";
            this.textBoxTerminalNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTerminalNo_KeyPress);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // buttonTamam
            // 
            resources.ApplyResources(this.buttonTamam, "buttonTamam");
            this.buttonTamam.Name = "buttonTamam";
            this.buttonTamam.Click += new System.EventHandler(this.buttonTamam_Click);
            // 
            // buttonCik
            // 
            resources.ApplyResources(this.buttonCik, "buttonCik");
            this.buttonCik.Name = "buttonCik";
            this.buttonCik.Click += new System.EventHandler(this.buttonCik_Click);
            // 
            // Giris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonCik);
            this.Controls.Add(this.buttonTamam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Giris_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Giris_Closing);
            this.panel2.ResumeLayout(false);
            this.pnl_sifre_degistir.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void Yaz()
		{
			try
			{				
				StreamWriter w = new StreamWriter(@"\id.txt",true);
                w.WriteLine(textBoxTerminalNo.Text + "-" + Utility.Engine.KullaniciID + "-" + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + "||");
				w.Flush();
                w.Close();//
                w=null;
			}
			catch(Exception)
			{	
			
			}
		}

		private void Oku()
		{
		
		}

        private void Giris_Load(object sender, System.EventArgs e)
        {
            
            Cursor.Current = Cursors.Default;
            EngineDoldur();
            lblIP.Text = "IP: " + IP;
            this.Text = string.Format("Giriş v{0}", Utility.Versiyon);

            if (!Engine.Connect)
            {
                this.Close(); return;
            }

            Cursor.Current = Cursors.WaitCursor;
#if DEBUG

            Utility.Engine.dat.TInsert("UPDATE tanimlamalar set TanimValue='" + Utility.Versiyon + "' where TanimID='PocketVer'");
#endif

            Utility.Engine.dat.ComboDoldur("SELECT KullaniciID from kullanici_tanim (NOLOCK) WHERE TerminalKullanicisi='E' AND Aktif = 'E' order by KullaniciID", comboBoxKullaniciID);

            textBoxParola.Text = "";
            textBoxTerminalNo.Text = Utility.Engine.CihazID.Trim() == "" ? "00001" : Utility.Engine.CihazID;
            Cursor.Current = Cursors.Default;

            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void buttonTamam_Click(object sender, System.EventArgs e)
        {
            string versiyon = Utility.Engine.dat.TSelectScalar(@"SELECT TanimValue FROM tanimlamalar WHERE TanimID = 'PocketVer'");
            if (!versiyon.Equals(Utility.Versiyon) && !string.IsNullOrEmpty(versiyon))
            {
                if (!Utility.Sor("Uygulama versiyonunuz merkezdeki ile uyuşmuyor, yinede devam etmek ister misiniz?"))
                {
                    //LocalVersiyonIniGucenlle();
                    Application.Exit();
                    return;
                }
            }

            #region Devam Et
            if (comboBoxKullaniciID.Text.Length < 1)
                return;
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("SİCİL NUMARASINI GiRiN ");
                textBox1.Focus();
                return;
            }

#if !DEBUG
            if (textBoxTerminalNo.Text == "")
            {
                MessageBox.Show("TERMiNAL NUMARASINI GiRiN ");
                textBoxTerminalNo.Focus();
                return;
            }
#endif
            String sql;
            sql = "SELECT Parola from kullanici_tanim (NOLOCK) WHERE KOD='";
            sql += textBox1.Text;
            sql += "'";

            string snc = "";

            snc = Utility.Engine.dat.TSelectScalar(sql);


            if (snc != textBoxParola.Text.Trim())
            {
                MessageBox.Show("Hatali Parola");

                return;
            }

            sonuc = true;

            Utility.Engine.KullaniciID = comboBoxKullaniciID.Items[comboBoxKullaniciID.SelectedIndex].ToString();
            Utility.Engine.KullaniciKod = textBox1.Text;

            Yaz();
            if (chckbox_sifre_degis.Checked == true)
            {
                if (yeni_sifre_1.Text != "" && yeni_sifre_2.Text != "")
                {
                    if (yeni_sifre_1.Text == yeni_sifre_2.Text)
                    {

                        if (Utility.Engine.dat.TInsert("Update kullanici_tanim set Parola='" + yeni_sifre_1.Text + "' where KullaniciID='" + comboBoxKullaniciID.Text + "'"))
                        {
                            MessageBox.Show("Şifre Değiştirildi");
                            chckbox_sifre_degis.Checked = false;
                            pnl_sifre_degistir.Visible = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("YENİ ŞİFRELER AYNI OLMALI");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("YENİ ŞİFRELERİ BOŞ GİRMEYİN");
                    return;
                }
            }


            AnaEkran a = new AnaEkran();
            a.ShowDialog();
            #endregion

        }
      
		private void buttonCik_Click(object sender, System.EventArgs e)
		{
           // LocalVersiyonIniGucenlle();
			sonuc=false;
            Utility.Engine.Cikiss = true;
			this.DialogResult=DialogResult.Cancel;       
                  
         this.Close();

		}


		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Yardim yar=new Yardim();
			yar.label1.Text="- Sisteme giriş yapabilmek için kullanici adinizi seçip şifrenizi yazarak TAMAM'i tuşlayabilirsiniz.";
			yar.ShowDialog();

		}

		private void comboBoxKullaniciID_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			textBoxParola.Focus();
			textBoxParola.SelectAll();
			return;
		}

		private void textBoxParola_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
				buttonTamam_Click(null,null);
		}

		private void textBoxTerminalNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			e.Handled = true;
		}

      private void textBox1_KeyDown(object sender, KeyEventArgs e)
      {         
         if (e.KeyValue == 13)
         {
             comboBoxKullaniciID.Text = Utility.Engine.dat.TSelectScalar(@" select TanimID from tanimlamalar (NOLOCK) where TanimValue=N'" + textBox1.Text.Trim() + "'");
            textBoxParola.Focus();
            textBoxParola.SelectAll();
         }
      }

      private void panel2_GotFocus(object sender, EventArgs e)
      {

      }

      private void chckbox_sifre_degis_EnabledChanged(object sender, EventArgs e)
      {
         
      }

      private void chckbox_sifre_degis_CheckStateChanged(object sender, EventArgs e)
      {
          if (chckbox_sifre_degis.Checked == true)
          {
              pnl_sifre_degistir.Visible = true;
             
          }
          else if (chckbox_sifre_degis.Checked == false)
          {
              pnl_sifre_degistir.Visible = false;
          }
      }



      public void EngineDoldur()
      {
          string path = "", db, usr, pass, con;

          try
          {
              path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
          }
          catch { ;}


          path = path.Replace("file:\\", "");
          Utility.AppPath = path;
          path += "\\config.ini";


          //MessageBox.Show(path);

          System.IO.StreamReader sr = new System.IO.StreamReader(path);
          IP = sr.ReadLine();
          db = sr.ReadLine();
          usr = sr.ReadLine();
          pass = sr.ReadLine();

          //MessageBox.Show(ip);
              con = "data source=";
              con += IP;
              con += ";user id=";
              con += usr;
              con += ";password=";
              con += pass;
              con += ";database=" + db + ";Connection Timeout=50;";

              Baglanti = con;


          Utility.Engine = new Engine(Baglanti);
          Utility.Engine.path = path;
      }

      public void LocalVersiyonIniGucenlle()
      {
          string path = "", GlobalIP = "", LocalIP = "", DB = "", Usr = "", Pass = "";
          try
          {
              try
              {
                  path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
              }
              catch { ;}


              path = path.Replace("file:\\", "");
              Utility.AppPath = path;
              path += "\\localVersiyon.ini";

              System.IO.StreamReader sr = new System.IO.StreamReader(path);
              GlobalIP = sr.ReadLine();
              LocalIP = sr.ReadLine();
              DB = sr.ReadLine();
              Usr = sr.ReadLine();
              Pass = sr.ReadLine();
              sr.Close();

              StreamWriter SW = new StreamWriter(path);
              SW.WriteLine(GlobalIP);
              SW.WriteLine(LocalIP);
              SW.WriteLine(DB);
              SW.WriteLine(Usr);
              SW.WriteLine(Pass);
              SW.WriteLine(Utility.Versiyon);
              SW.Close();
          }
          catch (Exception ex)
          {
              Utility.Hata("LocalVersiyon.ini dosyası güncelinirken hata oluştu. " + ex.ToString());
          }

      }

      private void Giris_Closing(object sender, System.ComponentModel.CancelEventArgs e)
      {
          LocalVersiyonIniGucenlle();
      }

        
	}
}
