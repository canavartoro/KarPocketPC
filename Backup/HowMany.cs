using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class HowMany : Form
    {
        public HowMany()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                i = int.Parse(textBox1.Text.PadLeft(1, '0'));
            }
            catch { i = 0; }

            DialogResult = DialogResult.OK;
        }

        public  int i = 0;

        private void HowMany_Load(object sender, EventArgs e)
        {
            
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(null, null);  
            }

            if (!char.IsControl(e.KeyChar))
            {
                if (!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

      
    }
}