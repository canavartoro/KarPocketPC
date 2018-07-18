using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class m : Form
    {
        public m()
        {
            InitializeComponent();
        }

        public string tistex="";

        bool ilk = false;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void m_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 120);
            this.Text = tistex;
        }

        private void m_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                DialogResult = DialogResult.OK;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                if (!ilk) { ilk = true; return; }

                DialogResult = DialogResult.OK;
            }
        }
    }
}