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
      public string INDIR = "Flash Disk";

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
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
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
            this.textBoxParola.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxParola_KeyUp);
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
            this.panel2.ResumeLayout(false);
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

            this.Text = string.Format("Giriş v{0}", Utility.Versiyon);

            if (!Engine.Connect)
            {
                this.Close(); return;
            }

            Cursor.Current = Cursors.WaitCursor;

            Utility.Engine.dat.ComboDoldur("SELECT KullaniciID from kullanici_tanim (NOLOCK) WHERE TerminalKullanicisi='E' AND Aktif = 'E' order by KullaniciID", comboBoxKullaniciID);

            textBoxParola.Text = "";
            textBoxTerminalNo.Text = Utility.Engine.CihazID.Trim() == "" ? "00001" : Utility.Engine.CihazID;
            Cursor.Current = Cursors.Default;

            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void buttonTamam_Click(object sender, System.EventArgs e)
        {
            if (comboBoxKullaniciID.Text.Length < 1)
                return;

#if !DEBUG
            if (textBoxTerminalNo.Text == "")
            {
                MessageBox.Show("TERMiNAL NUMARASINI GiRiN ");
                textBoxTerminalNo.Focus();
                return;
            }
#endif
            String sql;
            sql = "SELECT Parola from kullanici_tanim (NOLOCK) WHERE KullaniciID='";
            sql += comboBoxKullaniciID.Text;
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

            Yaz();

            AnaEkran a = new AnaEkran();
            a.ShowDialog();
        }
      
		private void buttonCik_Click(object sender, System.EventArgs e)
		{
			sonuc=false;
            Utility.Engine.Cikiss = true;
			this.DialogResult=DialogResult.Cancel;       
                  
         this.Close();

		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			Hakkimizda hk=new Hakkimizda();
			hk.ShowDialog();
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

		private void textBoxParola_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
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
            comboBoxKullaniciID.Text = Utility.Engine.dat.TSelectScalar(@" select TanimID from tanimlamalar where TanimValue=N'" + textBox1.Text.Trim() + "' ");

            textBox1.Text = "";

            textBox1.Focus();
            textBox1.SelectAll();
         }
      }


        
	}
}
