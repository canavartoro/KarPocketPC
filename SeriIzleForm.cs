using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class SeriIzleForm : Form
    {
        public SeriIzleForm()
        {
            InitializeComponent();
        }

        private void SeriBul()
        {
            try
            {
                string bar = Utility.Engine.SqlTemizle(textSeri.Text).Trim();
                DataTable dt = new DataTable();
                if ( !string.IsNullOrEmpty(bar) && Utility.Engine.dat.TableDoldur(string.Format("EXEC dbo.EtiketRapor N'{0}'", bar), ref dt) && dt != null && dt.Rows.Count > 0)
                {
                    dataGrid1.DataSource = dt;
                }
                textSeri.Text = "";
                textSeri.Focus();
                return;
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textSeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SeriBul();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeriBul();
        }
    }
}