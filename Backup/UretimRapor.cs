using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class UretimRapor : Form
    {
        public UretimRapor()
        {
            InitializeComponent();
        }

        private void UretimRapor_Load(object sender, EventArgs e)
        {
            textBoxPersKOd.Focus();
        }

        private void textBoxPersKOd_GotFocus(object sender, EventArgs e)
        {
            textBoxPersKOd.BackColor = Color.Yellow;
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            string ss = "";
            ss = Utility.Engine.dat.TSelectScalar(@"select AD+' '+SOYAD as [Adi Soyadi]  from SPERSONEL where KOD=N'" + textBoxPersKOd.Text.Trim() + "'");
            label2.Text = ss;

            Utility.Engine.sql = @" exec  uretimrapx N'" + textBoxPersKOd.Text.Trim() + "' ";

            DataTable dt = Utility.Engine.dat.TableDon(Utility.Engine.sql);

            dt.TableName = "rap";

            dataGrid1.DataSource = dt;
            
            
        }

        private void textBoxPersKOd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 || e.KeyValue == 17)
            {
                button1_Click(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}