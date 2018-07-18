using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for Yardim.
	/// </summary>
	public class Yardim : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonCik;
	
		public Yardim()
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
			this.buttonCik = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			// 
			// buttonCik
			// 
			this.buttonCik.Location = new System.Drawing.Point(152, 256);
			this.buttonCik.Size = new System.Drawing.Size(72, 29);
			this.buttonCik.Text = "ÇIK";
			this.buttonCik.Click += new System.EventHandler(this.buttonCik_Click);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Size = new System.Drawing.Size(224, 240);
			this.label1.Text = "- Bu sayfaya ait yardim verisi bulunamadi.";
			// 
			// Yardim
			// 
			this.ClientSize = new System.Drawing.Size(234, 296);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCik);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Text = "Yardim";
			this.Load += new System.EventHandler(this.Yardim_Load);

		}
		#endregion

		private void buttonCik_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Yardim_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
