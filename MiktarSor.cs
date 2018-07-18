using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class MiktarSor : Form
    {
        public MiktarSor()
        {
            InitializeComponent();
        }


        public double miktar = 0;
        public string metin = "";

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.Text.IndexOf("Miktar") > -1)
                    miktar = double.Parse(textBox1.Text.Trim().PadLeft(1, '0'));
                else
                    metin = textBox1.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Düzgun Formatta Girilmedi");
                miktar = 0;
                textBox1.Focus();
                return;                
            }


            DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiktarSor_Load(object sender, EventArgs e)
        {
              this.Location = new Point(50, 120);

            this.Size = new Size(153, 92);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }

        


    }
}