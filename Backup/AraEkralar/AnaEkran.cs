#define USUN1
#define CASIO
using System;
using System.Windows.Forms;
using System.Data;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class AnaEkran : System.Windows.Forms.Form
	{

		private System.Windows.Forms.Button button_0;
		private System.Windows.Forms.Button button_1;
      private System.Windows.Forms.Button button_2;
		private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Label labelVerisyon;
        private Button button_4;
        private Button button2;
        private Button button1;//"BACKUP";
#if CASIO


#endif
        //public Engine Utility.Engine;

		public AnaEkran()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.labelVerisyon = new System.Windows.Forms.Label();
            this.button_4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_0
            // 
            resources.ApplyResources(this.button_0, "button_0");
            this.button_0.Name = "button_0";
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            this.button_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaEkran_KeyDown);
            // 
            // button_1
            // 
            resources.ApplyResources(this.button_1, "button_1");
            this.button_1.Name = "button_1";
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            this.button_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaEkran_KeyDown);
            // 
            // button_2
            // 
            resources.ApplyResources(this.button_2, "button_2");
            this.button_2.Name = "button_2";
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            this.button_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaEkran_KeyDown);
            // 
            // button_3
            // 
            resources.ApplyResources(this.button_3, "button_3");
            this.button_3.Name = "button_3";
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            this.button_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaEkran_KeyDown);
            // 
            // labelVerisyon
            // 
            resources.ApplyResources(this.labelVerisyon, "labelVerisyon");
            this.labelVerisyon.ForeColor = System.Drawing.Color.Brown;
            this.labelVerisyon.Name = "labelVerisyon";
            // 
            // button_4
            // 
            resources.ApplyResources(this.button_4, "button_4");
            this.button_4.Name = "button_4";
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            this.button_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaEkran_KeyDown);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaEkran_KeyDown);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AnaEkran
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.labelVerisyon);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_2);
            this.Name = "AnaEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaEkran_KeyDown);
            this.ResumeLayout(false);

		}
		#endregion


      private void AnaEkran_Load(object sender, System.EventArgs e)
      {
          this.Text = string.Format("Depo Otomasyonu v{0}", Utility.Versiyon);   

         Utility.Engine.sql = @"select TanimValue from tanimlamalar where TanimID=N'mesaj'";

          if (Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim() == "H")
             Utility.Engine.mesajlar = false;
          else
              Utility.Engine.mesajlar = true;

          Utility.HELPME = new Help();

         Utility.Engine.KullaniciyaGoreModulAc(this);
      }

		private void buttonCik_Click(object sender, System.EventArgs e)
		{

            if (Utility.Engine.mesajlar)
            {
                if (MessageBox.Show("Programdan Çikmak istediniz!\nOnay Veriyor musunuz?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    Application.Exit();
            }
				
            
            Application.Exit();
			
		}

      private void button_0_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void button_1_Click(object sender, EventArgs e)
      {
         Stok st = new Stok();
         st.ShowDialog();

      }

      private void button_2_Click(object sender, EventArgs e)
      {
         URETIM u = new URETIM();
         
         u.ShowDialog();
      }

      private void button_3_Click(object sender, EventArgs e)
      {
         Sevkiyat s = new Sevkiyat();
         
         s.ShowDialog();
      }

      private void button_4_Click(object sender, EventArgs e)
      {
         StokD sd = new StokD();
         
         sd.ShowDialog();
      }

      private void mmm(object sender, KeyEventArgs e)
      {
          if (e.KeyValue == 48)
          {
              button_0_Click(null, null);
          }
          else if (e.KeyValue == 49)
          {
              button_1_Click(null, null);
          }
          else if (e.KeyValue == 50)
          {
              button_2_Click(null, null);
          }
          else if (e.KeyValue == 51)
          {
              button_3_Click(null, null);
          }
          else if (e.KeyValue == 52)
          {
              button_4_Click(null, null);
          }
          else if (e.KeyValue == 53)
          {
              button1_Click(null, null);
          }
          else if (e.KeyValue == 57)
          {
              Utility.HELPME.Show("AnaEkran");
          }
      }

        private void button1_Click(object sender, EventArgs e)
        {
            UretimRapor ur = new UretimRapor();
            
            ur.ShowDialog();
        }

        private void AnaEkran_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D9)
            { 
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utility.HELPME.Show("AnaEkran");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SeriIzleForm ser = new SeriIzleForm();
            ser.ShowDialog();
        }

        //private void AnaEkran_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //                if(e.KeyCode == Keys.D0)
        //        buttonCik_Click(null,null);
        //    else if(e.KeyCode == Keys.D3)
        //        buttonAyarlar_Click(null,null);
        //    else if(e.KeyCode == Keys.D2)
        //        button2_Click(null,null);
        //    else if(e.KeyCode == Keys.D1)
        //        button1_Click(null,null);
        //}

                       
	}
}
