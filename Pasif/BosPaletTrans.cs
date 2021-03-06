using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class BosPaletTrans : Form
    {
        public BosPaletTrans()
        {
            InitializeComponent();
        }



        private void comboBoxEkleSil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                if (textBoxBarkod.Text.Length < 1)
                {
                    Utility.Engine.Hata("Palet Barkodunu Okutun!");
                    textBoxBarkod.Text = "";
                    textBoxBarkod.Focus();
                    return;
                }

                if (textDepo.Text.Trim() == "")
                {

                    MessageBox.Show("Önce Gireceði Depoyu Seçiniz (Okutuðunuz Paletler Seçili Depoya Eklenecektir)","Dikkat..!");
                    return;
                }

                Utility.Engine.sql = string.Format(@"

     if  not exists (select *  from palet_tanim where PaletID=N'{0}')  begin
     select -1 as sonuc
     end
     else begin
     declare @miktar float
     select @miktar=PaletMiktar  from palet_tanim where PaletID=N'{0}'
     if @miktar <> 0 begin 
     select 0 as sonuc 
     end else 
     begin
     select PaletID,DepoKodu,ID   from palet_tanim where PaletID=N'{0}'
     end
     end
", textBoxBarkod.Text.ToUpper());

                DataTable dt=new DataTable();
                
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);

                

                if (dt.Rows[0][0].ToString().Trim() == "-1")
                {
                    MessageBox.Show("Bu Palet  Tanimli Deil", "Dikkar..!");
                    textBoxBarkod.Text = "";
                    textBoxBarkod.Focus();
                    return;
                }
                else if (dt.Rows[0][0].ToString().Trim() == "0")
                {
                    MessageBox.Show("Bu Boş  Tanimli Deil", "Dikkar..!");
                    textBoxBarkod.Text = "";
                    textBoxBarkod.Focus();
                    return;
                }
                else 
                {

                    Utility.Engine.DatatableedenEkle(ref dt, ref listView1, "PaletID",textDepo.Text);
                    this.Text = listView1.Items.Count.ToString() + " Satir";
                }
                
                textBoxBarkod.Text = "";
                textBoxBarkod.Focus();
            }
        }
        

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonBarkodSil_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSeriliBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonSeriliBarkod_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeriliBarkodSil_Click(object sender, EventArgs e)
        {

        }

        private void buttonYeniPalet_Click(object sender, EventArgs e)
        {
            if (textBoxBarkod.Text == "") return;

                 DepoSecimOzel oz = new DepoSecimOzel();
                 oz.Rapor = true;
                 if (oz.ShowDialog() == DialogResult.OK)
                 {
                     textDepo.Text = oz.DepoKodu;
                 }
           
        }

        private void BosPaletTrans_Load(object sender, EventArgs e)
        {            
            textBoxBarkod.Focus();
            return;
        }

        private void buttonBarkodSil_Click_1(object sender, EventArgs e)
        {
            textBoxBarkod.Text = "";
            textBoxBarkod.Focus();            
            listView1.Items.Clear();
            textDepo.Text = "";
            this.Text = "Palet Transfer";
            textBoxBarkod.Focus();
            return;
        }

        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            textBoxBarkod_KeyPress(textBoxBarkod, new System.Windows.Forms.KeyPressEventArgs((char)13));
            return;
        }
    }
}