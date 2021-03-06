using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class sek_iptal : Form
    {
        public sek_iptal()
        {
            InitializeComponent();
        }

        private void sek_iptal_Load(object sender, EventArgs e)
        {
            textBoxPalet.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPalet.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control();
        }

        void control()
        {
            Utility.Engine.sql = @"  select COUNT(*)  from kasa_transfer  where AtaKasa=N'" + textBoxSeri.Text.Trim() + "'  ";

            if (Utility.Engine.dat.TCount(Utility.Engine.sql) > 0)
            { secim(); }
            else
            { basla(); }
        }

        void secim()
        {

            try
            {
                panel1.Location=new Point(10,10);

                /*Utility.Engine.sql = @"
                            select  0  GMiktar,Birim,Miktar ,d.CariKod,d.IrsaliyeNo,d.BelgeNo,kt.ids
                                from kasa_transfer  kt  inner  join  stok_hareket_ust d
                                    on d.BelgeNo=kt.BelgeNo
                                        where AtaKasa=N'" + textBoxSeri.Text.Trim() + "' ";*/

                Utility.Engine.sql =
                    string.Format(@" select  
	GelenMiktar as GMiktar,
	Birim,
	Miktar ,
	d.CariKod,
	d.IrsaliyeNo,
	d.BelgeNo,
	kt.ids,
	kt.Kasa
from kasa_transfer  kt (nolock) inner  join  stok_hareket_ust d (nolock) on d.BelgeNo=kt.BelgeNo
where AtaKasa=N'{0}'", textBoxSeri.Text.Trim());

                DataTable dt = Utility.Engine.dat.TableDon(Utility.Engine.sql);
                dt.TableName = "kasa";
                dataGrid1.DataSource = dt;
                panel1.Visible = true;
                panel1.BringToFront();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
            
            

        }

        DataTable dt = new DataTable();

        void basla()
        {

            Utility.Engine.alantemizle(textBoxPalet);
            Utility.Engine.alantemizle(textBoxSeri);

            string Plt = "";
            string seri = "";
            string sonuc = "";

            Plt = textBoxPalet.Text;
            seri = textBoxSeri.Text;

            DataTable dtx = null;

            dtx = Utility.Engine.dat.TableDon("exec dbo.sevk_iptal1 N'" + seri + "',N'" + Plt + "'");

            textBoxSeri.Text = "";

            if (dtx == null) return;

            if (dtx.Rows.Count < 1) return;

            sonuc = dtx.Rows[0][0].ToString();

            int bak = sonuc.IndexOf("Hata");

            if (bak > -1)
            {
                MessageBox.Show(sonuc);
                return;
            }

            for (int i = 0; i < dtx.Rows.Count; i++)
            {
                ListViewItem row = new ListViewItem();
                row.Text = dtx.Rows[i][0].ToString();
                for (int c = 1; c < dtx.Columns.Count; c++)
                {
                    row.SubItems.Add(dtx.Rows[i][c].ToString());
                }
                listView1.Items.Add(row);
            }

            labelSatir.Text = listView1.Items.Count.ToString();
            this.Text = listView1.Items.Count.ToString();
            textBoxSeri.Focus();
        }

        private void textBoxSeri_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                control();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxSeri.Text = "";
        }

        private void textBoxPalet_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyValue == 13 || e.KeyValue == 17)
            {
                button4_Click(null, null);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPalet.Text.Trim() == "") return;

                string asd = "EXEC sevk.SevkIptalPalet N'";
                asd += textBoxPalet.Text;
                asd += "', N'";
                asd += Utility.Engine.KullaniciID;
                asd += "'";

                Utility.Engine.sql = asd;

                string xreturn = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);
                if (string.IsNullOrEmpty(xreturn) || !xreturn.Equals("OK"))
                {
                    Utility.Hata(xreturn);
                    textBoxPalet.Text = "";
                    textBoxSeri.Text = "";
                    listView1.Items.Clear();
                    textBoxPalet.Focus();
                    return;
                }
                else
                {
                    textBoxSeri.Focus();
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(368,216);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt =(DataTable)dataGrid1.DataSource;

            if (dt != null)
            {
                MiktarSor mk = new MiktarSor();
                if (mk.ShowDialog() != DialogResult.OK)
                    return;
                int gmiktar = (int)mk.miktar;

                try
                {
                    Utility.Engine.dat.TInsert("begin transaction xx5");

                    try { textBoxSeri.Text = dataGrid1[dataGrid1.CurrentRowIndex, 7].ToString(); }
                    catch (Exception ee) { Utility.WriteTrace(ee.Message); }

                    string xsal = "update  kasa_transfer  set  GelenMiktar = isnull(GelenMiktar,0) + N'" + gmiktar.ToString() + "'  where ids=N'" + dataGrid1[dataGrid1.CurrentRowIndex, 6].ToString() + "'";

                    if (!Utility.Engine.dat.TInsert(xsal))
                    {
                        Utility.Engine.dat.TInsert("rollback transaction xx5");
                        MessageBox.Show("Gelen Miktarlar Kayit Edilirken Hata Oluştu..!  <" + Utility.Engine.dat.STR_HataMesaji + ">");
                        return;
                    }

                    Utility.Engine.dat.TInsert("commit transaction xx5");
                }
                catch (Exception exc)
                {
                    Utility.Engine.dat.TInsert("rollback transaction xx5");
                    MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
                }

                panel1.Location = new Point(368, 216);

                basla();

            }
        }
    }
}