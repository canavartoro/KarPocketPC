using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class KavisLe : Form
    {
        public KavisLe()
        {
            InitializeComponent();
        }


        bool seribilgileri = false;
        string seri = "";

        private void KavisLe_Load(object sender, EventArgs e)
        {
            SeriliBarkod.Focus();
        }

        private void buttonPalet_Click(object sender, EventArgs e)
        {
            seri = SeriliBarkod.Text.Trim().ToUpper();

            if (seri == "") return;

            Utility.Engine.sql = @"
                     select top 1 r.*,s.StokAdi  
                     from  serili_barkodlar r (NOLOCK) inner join stok_tanim_ust s (NOLOCK)
                     on s.StokKodu=r.StokKodu
                     where SeriliBarkod=N'" + seri + "'  order by IDS   ";


            DataTable dt = Utility.Engine.dat.TableDon(Utility.Engine.sql);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                        {
                            TextBox t = (TextBox)c;

                            if (t.Name == dt.Columns[i].ColumnName)
                            {
                                t.Text = dt.Rows[0][i].ToString().Trim();
                            }
                        }
                    }
                }
            }


            if (
               SeriliBarkod.Text.Trim() == "" ||
               StokKodu.Text.Trim() == "" ||
               StokAdi.Text.Trim() == "" ||
               Birim.Text.Trim() == "" ||
               Miktar.Text.Trim() == ""
               )
            {
                seribilgileri = false;
            }
            else
            {
                seribilgileri = true;
                YSeri.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YSeri.Text = "";
        }

        private void buttonTPalet_Click(object sender, EventArgs e)
        {
            SeriliBarkod.Text = "";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textMontajMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                if (!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textMontajMiktar_TextChanged(object sender, EventArgs e)
        {
            double m = 0;

            try
            {
                m = double.Parse(textMontajMiktar.Text.Trim().Replace(",", "."));
            }
            catch
            {
                m = 0;
            }


            if (m > 0 && seribilgileri && YSeri.Text.Trim() != "")
            { buttonKaydet.Enabled = true; return; }
            else
            { buttonKaydet.Enabled = false; return; }
        }



        private void Temizle()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    c.Text = "";
                }
            }
            buttonKaydet.Enabled = false;
        }

        private void SeriliBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonPalet_Click(null, null);
            }
        }

        private void YSeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (YSeri.Text.Trim() == "")
                    return;

                textBoxPaet.Focus();
            }
        }

        private void textBoxPaet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxPaet.Text.Trim() == "")
                    return;

                textMontajMiktar.Focus();
            }

        }



        private void buttonKaydet_Click(object sender, EventArgs e)
        {

            if (YSeri.Text.Trim() == "") return;

            Utility.Engine.sql = @"exec [erp].[KavisLe1] N'" + seri + "',N'" + YSeri.Text.Trim().ToUpper() + "',N'"
                + textMontajMiktar.Text.Trim() + "',N'" + Utility.Engine.KullaniciID + "',N'" + Utility.Engine.CihazID + "',N'" + textBoxPaet.Text.Trim().ToUpper() + "'";


            DataTable dt = Utility.Engine.dat.TableDon(Utility.Engine.sql);

            if (dt == null || dt.Rows.Count < 1)
            {
                MessageBox.Show("Sunucun Yanit Vermedi..:" + Utility.Engine.dat.Fault, "Dikkat..!");
                return;
            }

            string str = dt.Rows[0][0].ToString().Trim();

            if (str != "OK")
            {
                MessageBox.Show("Sunucun Hata Bildirdi..:" + str + " __" + Utility.Engine.dat.Fault, "Dikkat..!");
                return;
            }

            Utility.Engine.Tamam("işlemler Tamamlandi..");

            Temizle();

        }
    }
}