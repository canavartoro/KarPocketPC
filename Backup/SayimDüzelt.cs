using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class SayimDüzelt : Form
    {
        public SayimDüzelt()
        {
            InitializeComponent();
        }


        private void SayimDüzelt_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 120);
            this.Size = new Size(153,110);            
            textBox1.Focus();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            DepoSecimOzel oz = new DepoSecimOzel();
            if (oz.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = oz.DepoKodu.Trim();  
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string raf = "";

            raf = textBox1.Text.Trim().Replace("\r\n", "")
                .Replace("\n", "").Replace("\r", "");

            textBox1.Text = raf;

            raftemizle(raf, checkBox1.Checked ? 1 : 0);

        }

        private void raftemizle(string raf,int i) 
        {
            if (checkBox1.Checked == false)
            {
                if (!Utility.Engine.Sor("İlgili Depo Sayımları Silinecektir Onaylıyormusunuz")) return;
            }
            else
            {
                if (!Utility.Engine.Sor("İlgili Depo Sayıma Açılacaktır Onaylıyormusunuz")) return;
            }


                Utility.Engine.sql = string.Format(@" exec dbo.sayimduzelt N'{0}',N'{1}'", raf, i.ToString());

            string  sonuc="";

            sonuc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();

            if (sonuc != "1")
                MessageBox.Show(sonuc, "Yapılan İşlem Gerçekleşemedi");
            else
                MessageBox.Show("İslem Tamamlandı");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string raf = "";

            raf = textBox1.Text.Trim().Replace("\r\n", "")
                .Replace("\n", "").Replace("\r", "");

            textBox1.Text = raf;

            raftemizle(raf, checkBox1.Checked ? 1 : 0);

            DialogResult = DialogResult.OK;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            checkBox1.Text = checkBox1.Checked ? "Raf Sayıma Aç" : "Sayim Düzelt";
        }      
    }
}