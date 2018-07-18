using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class PersonelDevir : Form
    {
        public PersonelDevir()
        {
            InitializeComponent();
        }
        private void Devir()
        {
            try
            {

                Utility.Engine.dat.TInsert(@" exec dbo.DevirPersonel '00008' , '00007'");
               

                
                if (textPersonel.Text!="" && textDevir.Text!="" )
                {
                   
                    

                    textDevir.Text = "";
                    textPersonel.Text = "";
                    textDevir.BackColor = Color.Yellow;
                    textPersonel.BackColor = Color.White;
                    textDevir.Focus();
                    return;
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textCikis_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textPersonel_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textPersonel_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string sqll = @"SELECT  count(*) FROM [dbo].[SPERSONEL] where KOD = '" + textPersonel.Text + "'";
                long say =Utility.Engine.dat.TCount(sqll);
                if (say > 0)
                {
                    button4.Enabled = true;
                    textDevir.BackColor = Color.Yellow;
                    textPersonel.BackColor = Color.White;
                    textDevir.Focus();
                }
                else
                {
                    button4.Enabled = false;
                    button3.Enabled = false;
                }
            }
        }
        private void textDevir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string sqll = @"SELECT  count(*) FROM [dbo].[SPERSONEL] where KOD = '" + textDevir.Text + "'";
                long say = Utility.Engine.dat.TCount(sqll);
                if (say > 0)
                {
                    button3.Enabled = true;
                    textDevir.BackColor = Color.White;
                    button3.Focus();
                }
                else
                {
                    button3.Enabled = false;
                }
            }
        }

        private void textPersonel_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void PersonelDevir_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            textPersonel.BackColor = Color.Yellow;
            textDevir.BackColor = Color.White;
            textPersonel.Focus();
            button3.Enabled = false;
            button4.Enabled = false;
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                Utility.Engine.dat.TInsert(@" exec dbo.DevirPersonel '" + textPersonel.Text + "' , ''");
                textPersonel.Text = "";
                textPersonel.BackColor = Color.Yellow;
                textDevir.BackColor = Color.White;
                button4.Enabled = false;
                textPersonel.Focus();
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }

        } 
        private void button3_Click(object sender, EventArgs e)
        {string sqll;
            try
            {
                sqll=@" exec dbo.DevirPersonel '" + textPersonel.Text + "' , '" + textDevir.Text + "'";

                DataTable dtx = new DataTable();
                Utility.Engine.dat.TableDoldur(sqll, ref dtx);
                if (dtx != null && dtx.Rows.Count > 0)
                {
                    if (dtx.Rows[0][1].ToString() == "HATA")
                    {
                        Utility.Engine.Hata(dtx.Rows[0][0].ToString());
                    }
                }
                
                textPersonel.Text = "";
                textDevir.Text = "";
                textPersonel.BackColor = Color.Yellow;
                textDevir.BackColor = Color.White;
                button4.Enabled = false;
                button3.Enabled = false;
                textPersonel.Focus();
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textPersonel.Text = "";
            textPersonel.BackColor = Color.Yellow;
            textDevir.BackColor = Color.White;
            button4.Enabled = false;
            textPersonel.Focus();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textDevir.Text = "";
            textDevir.BackColor = Color.Yellow;
            textPersonel.BackColor = Color.White;
            button3.Enabled = false;
            textDevir.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

       

    }
}