using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class MontajYap : Form
    {
        public MontajYap()
        {
            InitializeComponent();

            dt.Columns.Add("KasaNo", typeof(string));
            dt.Columns.Add("ÜrünSerisi", typeof(string));
            dt.Columns.Add("KasaMiktar", typeof(double));
            dt.Columns.Add("MontMiktar", typeof(double));
            dt.Columns.Add("DepoKodu", typeof(string));
            dt.Columns.Add("StokKodu", typeof(string));
            dt.Columns.Add("StokAdi", typeof(string));
            dt.Columns.Add("Birim", typeof(string));
            dt.TableName = "okunanlar";
            dt.AcceptChanges();

            dataGrid1.DataSource = dt;
        }

        DataTable dt = new DataTable();

        private void MontajYap_Load(object sender, EventArgs e)
        {          
            textKasaNo.Focus();
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


            ((DataTable)dataGrid1.DataSource).Rows.Clear();
            ((DataTable)dataGrid1.DataSource).AcceptChanges();

            textKasaNo.Focus();
        }

        private void buttonPalet_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dataGrid1.VisibleRowCount > 0)
                {

                    DataTable df = (DataTable)dataGrid1.DataSource;
               
                    if (Utility.Engine.DataTabledeAra(ref df,"KasaNo", Utility.Engine.alantemizleSql(textKasaNo).ToUpper()))
                    {
                        textKasaNo.Text = "";
                        textKasaNo.Focus();
                        return;
                    }
                }

                Utility.Engine.sql = string.Format(@"EXEC dbo.KasaBulKasaTransfer4 N'{0}'
                                                ", Utility.Engine.alantemizleSql(textKasaNo).ToUpper());


                DataTable dtx = Utility.Engine.dat.TableDon(Utility.Engine.sql);

                if (dtx == null) return;

                if (dtx.Rows.Count < 1)
                {
                    MessageBox.Show("Kasa Bulunamdi ");
                    textKasaNo.Text = "";
                    textKasaNo.Focus();
                    return;
                }

                if (dtx.Rows.Count == 1)
                {
                    KasaSec(dtx.Rows[0]);
                    return;
                }
                else
                {
                    listView1.Items.Clear();
                    listView1.Tag = dtx;
                    for (int x = 0; x < dtx.Rows.Count; x++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = dtx.Rows[x][6].ToString();          //Stok Adi
                        item.SubItems.Add(dtx.Rows[x][2].ToString());   //Kasa Miktar
                        item.SubItems.Add(dtx.Rows[x][5].ToString());   //Stok Kodu
                        item.SubItems.Add(dtx.Rows[x][1].ToString());   //Ürün Seri
                        item.SubItems.Add(dtx.Rows[x][0].ToString());   //Kasa No
                        item.SubItems.Add(dtx.Rows[x][3].ToString());   //Montaj Miktar
                        item.SubItems.Add(dtx.Rows[x][4].ToString());   //Depo Kodu
                        item.SubItems.Add(dtx.Rows[x][7].ToString());   //Birim
                        listView1.Items.Add(item);
                    }
                    panel1.Location = new Point(0, 0);
                    panel1.BringToFront();
                    panel1.Visible = true;
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   
        }

        private void textMontajMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonKaydet.Focus();
                return;
            }

            if (!char.IsControl(e.KeyChar))
            {
                if (!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textKasaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonPalet_Click(null, null);
            }
        }

        private void textBMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
     
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textYEniSeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button6_Click(null, null);         
            }
        }
        
        private void textYeniKasaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button3_Click_1(null, null);              
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Gizle();
        }

        private void Gizle()
        {
            pnlSor.Location = new Point(429, 250);
        }

        private void Getir(int km)
        {
            lblKalanMiktar.Text = km.ToString();
            txtGercekMiktar.Text = "";
            txtDepodanEklenen.Text = "";
            pnlSor.Location = new Point(32, 98);
            pnlSor.BringToFront();
            txtGercekMiktar.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (dataGrid1.VisibleColumnCount < 1) return;

            if (dataGrid1.CurrentRowIndex < 0) return;


            int idxx = dataGrid1.CurrentRowIndex;

            Utility.Engine.sql = @" exec [erp].[Montajla] ";
            Utility.Engine.sql += "N'";
            Utility.Engine.sql += dt.Rows[idxx][0].ToString().ToUpper() + "',";
            Utility.Engine.sql += "N'0',";
            Utility.Engine.sql += "N'" + dt.Rows[idxx][1].ToString() + "',";
            Utility.Engine.sql += "N'0',";
            Utility.Engine.sql += "N'0',";
            Utility.Engine.sql += "N'0',";
            Utility.Engine.sql += "N'" + Utility.Engine.alantemizleSql(txtDepodanEklenen) + "',N'" + Utility.Engine.alantemizleSql(txtGercekMiktar) + "',N'0'";

            Utility.Engine.dat.BeginTransaction();

            string snc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();

            int j = snc.IndexOf("Hata");

            if (j > -1)
            {
                Utility.Engine.dat.RollbackTransaction();
                MessageBox.Show(snc);
            }
            else
            {
                Utility.Engine.dat.CommitTransaction();
            }

            Gizle();
        }

        private void KasaSec(DataRow dr)
        {
            try
            {
                int mk = 0;                 
                HowMany h = new HowMany();
                h.Location = new Point(30, 50);
                h.Text = dr["KasaMiktar"].ToString();//dtx.Rows[0]["KasaMiktar"].ToString();
                if (h.ShowDialog() == DialogResult.OK)
                {
                    int km = 0;
                    try
                    {
                        km = int.Parse(h.Text.PadLeft(1, '0'));
                    }
                    catch { ; }

                    if (km < h.i)
                    {                        
                        ;
                        //MessageBox.Show("Kasa Miktari Yetersiz");
                        //dr["MontMiktar"] = 0;//dtx.Rows[0]["MontMiktar"] = 0;
                    }
                    else
                        dr["MontMiktar"] = h.i;
                        //dtx.Rows[0]["MontMiktar"] = h.i;                   
                }

                //dtx.AcceptChanges();

                dt.ImportRow(dr);//dtx.Rows[0]);
                dt.AcceptChanges();
                dataGrid1.DataSource = dt;
                textKasaNo.Text = "";
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int incxx = dataGrid1.CurrentRowIndex;


            HowMany h = new HowMany();
            h.Text = dt.Rows[incxx]["KasaMiktar"].ToString();
            h.Location = new Point(30, 50);
            if (h.ShowDialog() == DialogResult.OK)
            {

                int km = 0;
                try
                {
                    km = int.Parse(h.Text.PadLeft(1, '0'));
                }
                catch { ; }

                if (km < h.i)
                {
                    MessageBox.Show("Kasa Miktari Yetersiz");

                    dt.Rows[incxx]["MontMiktar"] = 0;
                }
                else
                    dt.Rows[incxx]["MontMiktar"] = h.i;               


                dt.AcceptChanges();
                dataGrid1.DataSource = dt;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGrid1.VisibleRowCount > 0)
            {
                ((DataTable)dataGrid1.DataSource).Rows.RemoveAt(dataGrid1.CurrentRowIndex);
            }
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            if (dataGrid1.VisibleRowCount > 0)
                dataGrid1.Select(dataGrid1.CurrentRowIndex);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int indduz=dataGrid1.CurrentRowIndex;

            if (indduz < 0) return;

            int ddc = 0;

            try
            {
                ddc = int.Parse(dataGrid1[indduz,2].ToString().PadLeft(1, '0'));
            }
            catch { }

            Getir(ddc);
        }

        private void buttonTPalet_Click(object sender, EventArgs e)
        {
            textKasaNo.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Utility.Engine.sql = string.Format(@" select count(*)  from  serili_barkodlar where SeriliBarkod=N'{0}' ", Utility.Engine.alantemizleSql(textYEniSeri).ToUpper());

            if (Utility.Engine.dat.TCount(Utility.Engine.sql) > 0)
            {
                textMontajMiktar.Focus();
            }
            else
                MessageBox.Show("Bu Seri Bulunamdi..! " + Utility.Engine.sql);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGrid1.VisibleColumnCount < 1)
            {
                MessageBox.Show("Montajlanacak Kasa Okutulmalidir  ");
                return;
            }


            if (textYeniKasaNo.Text.Trim() == "")
            {
                MessageBox.Show("Yeni Kasa Okutulmalidir  ");
                return;
            }



            if (textYEniSeri.Text.Trim() == "")
            {
                MessageBox.Show("Yeni Seri Okutulmalidir  ");
                return;
            }

            int mkkk = 0;

            try
            {

                mkkk = int.Parse(textMontajMiktar.Text.Trim().PadLeft(1, '0'));
            }
            catch
            {
                mkkk = 0;

            }


            if (mkkk < 1) {

                MessageBox.Show("Montajlanan Miktar sifirdan buyuk olmalidir");
                return;
            }

            int j = 100;

            Cursor.Current = Cursors.WaitCursor;

            Utility.Engine.dat.BeginTransaction();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Utility.Engine.sql = @" exec [erp].[Montajla] ";
                Utility.Engine.sql += "N'" + dt.Rows[i]["KasaNo"].ToString() + "',";
                Utility.Engine.sql += "N'" + Utility.Engine.alantemizleSql(textYEniSeri).ToUpper() + "',";
                Utility.Engine.sql += "N'" + dt.Rows[i]["ÜrünSerisi"].ToString() + "',";
                Utility.Engine.sql += "N'" + Utility.Engine.alantemizleSql(textYeniKasaNo).ToUpper() + "',";
                Utility.Engine.sql += "N'" + dt.Rows[i]["MontMiktar"].ToString() + "',";
                Utility.Engine.sql += "N'" + Utility.Engine.alantemizleSql(textMontajMiktar) + "',";
                Utility.Engine.sql += "N'0',N'0',N'1'";

                string snc = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql).Trim();

                j = snc.IndexOf("Hata");

                if (j > -1)
                {
                    Utility.Engine.dat.RollbackTransaction();
                    MessageBox.Show(snc);
                    break;
                }                
            }


            if (j < 0)
            {
                Utility.Engine.dat.CommitTransaction();
                Temizle();
            }

            Cursor.Current = Cursors.Default;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Utility.Engine.sql = string.Format(@" select count(*)  from  palet_tanim where PaletID=N'{0}' ", Utility.Engine.alantemizleSql(textYeniKasaNo).ToUpper());

            if (Utility.Engine.dat.TCount(Utility.Engine.sql) > 0)
            {
                textYEniSeri.Focus();
            }
            else
                MessageBox.Show("Bu Kasa Bulunamdi..! " + Utility.Engine.sql);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            listView1.Items.Clear();
            listView1.Tag = null;
            textKasaNo.Text = "";
            textKasaNo.Focus();
            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0 && listView1.SelectedIndices.Count > 0)
                {
                    DataTable dtx = (DataTable)listView1.Tag;
                    KasaSec(dtx.Rows[listView1.SelectedIndices[0]]);
                    panel1.Visible = false;
                    listView1.Items.Clear();
                    textKasaNo.Text = "";
                    textKasaNo.Focus();
                    return;
                }
                
            }
            catch (Exception ee)
            {
                Utility.Hata("Genel hata:" + ee.Message);
            }
        }
    }
}