using System;
using System.Drawing; 
using System.Collections;
using System.Windows.Forms;

namespace AmbarPPC
{
    /// <summary>
    /// Summary description for Hakkimizda.
    /// </summary>
    public class Hakkimizda : System.Windows.Forms.Form
    {
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Button buttonCik;

        public Hakkimizda()
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
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hakkimizda));
            this.buttonCik = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCik
            // 
            this.buttonCik.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCik.Location = new System.Drawing.Point(3, 252);
            this.buttonCik.Name = "buttonCik";
            this.buttonCik.Size = new System.Drawing.Size(233, 32);
            this.buttonCik.TabIndex = 14;
            this.buttonCik.Text = "TAMAM";
            this.buttonCik.Click += new System.EventHandler(this.buttonCik_Click);
            this.buttonCik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonCik_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 40);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(640, 20);
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Hakkimizda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonCik);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hakkimizda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Hakkimizda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonCik_KeyDown);
            this.ResumeLayout(false);

        }
        #endregion

        private void buttonCik_Click(object sender, System.EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            Giris g = new Giris();
            g.ShowDialog();

            //Close();
        }

        private void Hakkimizda_Load(object sender, System.EventArgs e)
        {
            string path = "", ip, db, usr, pass, con;

            label3.Text = string.Format("v{0}", Utility.Versiyon);

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
            ip = sr.ReadLine();
            db = sr.ReadLine();
            usr = sr.ReadLine();
            pass = sr.ReadLine();

            //MessageBox.Show(ip);

            object ob = sr.ReadLine();
            
            if (ob == null) 
            {
                MessageBox.Show("config.ini  dosyasina çikiş şifresi koyulmamiş şifreyi ekleyip uygulamayi tekrar çaliştirin ");
                this.Close();                
            }
            else
            {
                con= "data source=";
                con += ip;
                con += ";user id=";
                con += usr;
                con += ";password=";
                con += pass;
                con += ";database=" + db + ";";
                Utility.Engine = new Engine(con);
                Utility.Engine.sifre = ob.ToString();
                Utility.Engine.path = path;
                Zaman.ZamanKur();
            }


            label2.Text = "";
        }

        private void buttonCik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                label2.Text = "";
                return;
            }

            label2.Text += e.KeyCode.ToString().Replace("D", "");
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ( Utility.Engine == null || Utility.Engine.sifre == null)
                {
                    Utility.Hata("şifre hatali yada boş!");
                    return;
                }
                if (label2.Text.Trim().Length == Utility.Engine.sifre.Length)
                {
                    if (label2.Text == Utility.Engine.sifre)
                    {
                        Application.Exit();
                        Close();
                        return;
                    }

                    label2.Text = "";
                }
            }
            catch (Exception ee)
            {
                Utility.Hata(ee.Message);
                Application.Exit();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AyarAl()
        {
            Utility.Engine.connectionstring = "data source=";
            Utility.Engine.connectionstring += Utility.Engine.STR_IP;
            Utility.Engine.connectionstring += ";user id=";
            Utility.Engine.connectionstring += Utility.Engine.STR_DatabaseUser;
            Utility.Engine.connectionstring += ";password=";
            Utility.Engine.connectionstring += Utility.Engine.STR_DatabasePassword;
            Utility.Engine.connectionstring += ";database=" + Utility.Engine.STR_Database + ";";

            try
            {
                Utility.Engine = new Engine(Utility.Engine.connectionstring);
            }
            catch (Exception exc)
            {
                Utility.Hata("Sistem sunucuya baðlanamadi kapanacak istem yöneticinize bildirin!\n" + exc.Message);
                Application.Exit();
            }
        }
    }
}
