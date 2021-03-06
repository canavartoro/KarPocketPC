using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class DepodanKasaya : Form
    {
        public DepodanKasaya()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            Temizle();
            return;
        }

        private void DepodanKasaya_Load(object sender, EventArgs e)
        {
            textBoxKasa.Focus();
            textBoxKasa.SelectAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DepoSecimOzel oz = new DepoSecimOzel();
            oz.Rapor = true;
            if (oz.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = oz.DepoKodu;
                textKMiktar.Focus();
                textKMiktar.SelectAll();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxKasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button2_Click(null, null);
                textMiktar.Focus();
                textMiktar.SelectAll();
            }
        }

        private void Temizle()
        {
            textKMiktar.Text =
            textMiktar.Text =
            textBoxKasa.Text = "";
            textKasaBirim.Text = "";
            textKasaStokAdi.Text = "";
            textKasaStokKodu.Text = "";
            textBox1.Text = "";
            textDepo.Text = "";
            textBoxKasa.Focus();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int mkt = 0;

                try
                {
                    mkt = Convert.ToInt32(textMiktar.Text.PadLeft(1, '0').Replace(",", ".").Trim());
                }
                catch { mkt = 0; }

                if (mkt == 0)
                {
                    Utility.Engine.Hata("Miktar Alninda Hata ..!");
                    return;
                }

                if (textBox1.Text.Trim() == "")
                {
                    Utility.Engine.Hata("Gireceði Depoyu Seçmelesiniz ..!");
                    return;
                }

                Utility.Engine.sql = string.Format(@"
                    exec dbo.ArtanUrunTransfer
                    N'{0}',N'{1}',N'{2}',
                    N'{3}',N'{4}',N'{5}',
                    N'{6}',N'1'
                            ",
                                 textBoxKasa.Text,
                                 textKasaStokKodu.Text,
                                 textDepo.Text,
                                 textBox1.Text,
                                   mkt.ToString(),
                                   Utility.Engine.KullaniciID, Utility.Engine.CihazID);

                string sn = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);

                if (sn.Trim() != "")
                { MessageBox.Show("Sunucnu hata Bildirdi ..: " + sn, "Dikkat..!"); return; }

               if(Utility.Engine.mesajlar) MessageBox.Show("işlem Tamamlandi");

                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Genel Hata..!")
                ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}