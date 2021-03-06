using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }



        private void Ekle_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            t.BackColor = Color.Gold;
        }

        private void textBox3_LostFocus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            t.BackColor = Color.AntiqueWhite;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void getir()
        {

            if (textBox2.Text.Trim() == "")
                return;

            try
            {

                Utility.Engine.sql = string.Format("EXEC  [dbo].[seribilgigetir1] N'{0}'", Utility.Engine.SqlTemizle(textBox2.Text.Trim()));

                //ilkinin iş emri vardaiya personel = olursa aktara bilsin

                DataTable dtx = new DataTable();

                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dtx);

                if (dtx != null && dtx.Rows.Count > 0)
                {
                                        
                    textKasaStokKodu.Text = dtx.Rows[0]["StokKodu"].ToString();
                    textKasaStokAdi.Text = dtx.Rows[0]["StokAdi"].ToString();
                    textKasaBirim.Text = dtx.Rows[0]["Birim"].ToString();
                    textKMiktar.Text = Convert.ToDecimal(dtx.Rows[0]["Miktar"].ToString()).ToString();
                    textBoxKasa.Focus();
                    return;
                }
                else
                {
                    Temizle();
                    Utility.Engine.Hata("Seri Bilgisi Sistemde Bulunamadi!");
                    textBox2.Focus();
                    return;
                }
            }
            catch (Exception exc)
            {
                Utility.Engine.Hata("Seri Sorgulanamadi.");
                textBoxKasa.Focus();
                textBoxKasa.SelectAll();
                return;
            }

            
        }

        private void ekle()
        {
            Utility.Engine.sql=@"exec hEkle N'" 
                + textBoxKasa.Text.Trim() + "',N'" 
                + textBox2.Text.Trim() + "',N'" 
                + textMiktar.Text.Trim() + "',N'0'";
            

            string snc="";

            snc=Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();

            if (snc == "Bu Seri Daha Önce okutulmuştur Deistirilsinmi")
            {

                if (Utility.Engine.Sor(snc))
                {
                    snc = "";

                    Utility.Engine.sql = @"exec hEkle N'"
                    + textBoxKasa.Text.Trim() + "',N'"
                    + textBox2.Text.Trim() + "',N'"
                    + textMiktar.Text.Trim() + "',N'1'";

                    snc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();

                    MessageBox.Show(snc, "işlem Sonucu");


                    Temizle();
                    return;
                }

                return;
            }

            MessageBox.Show(snc, "işlem Sonucu");

            Temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxKasa.Text = "";
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            ekle();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                if (!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void Temizle()
        {
            textBox2.Text = "";
            textKMiktar.Text =
            textMiktar.Text =
            textBoxKasa.Text = "";
            textKasaBirim.Text = "";
            textKasaStokAdi.Text = "";
            textKasaStokKodu.Text = "";                        
            textBox2.Focus();
            return;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                getir();
            }  
        }

        private void textBoxKasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
                textMiktar.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

 

     

 
    }
}