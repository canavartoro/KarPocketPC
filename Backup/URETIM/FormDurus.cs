using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{//0;92
    public partial class FormDurus : Form
    {
        private enum Butonlar : int { Kapat = 0, TekBaslat = 1, TekBitir = 2, Duzelt = 3, Sil = 4, TopBaslat = 5, TopBitir = 6 };
        public FormDurus()
        {
            InitializeComponent();
        }

        private void IstasyonDurum(bool yoksabaslat)
        {
            try
            {
                txtTKod.Text = Utility.Engine.SqlTemizle(txtTKod.Text).Trim().ToUpper();
                int bag = chkBag.Checked ? 0 : 1;

                Utility.Engine.sql = string.Format("EXECUTE erp.IstasyonDurus N'{0}', {1}, {2}", Utility.Engine.SqlTemizle(txtTKod.Text), yoksabaslat == true ? "1" : "0", bag);
                DataTable dt = new DataTable();
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    if (dt.Columns.Count == 1)
                    {
                        Utility.Hata("Sunucu hata bildirdi:" + dt.Rows[0][0].ToString());
                        return;
                    }
                    long uretimkayit = Convert.ToInt64(dt.Rows[0][0].ToString());
                    long duruskayit = Convert.ToInt64(dt.Rows[0][1].ToString());
                    string hata = dt.Rows[0][2].ToString();
                    txtTAd.Text = dt.Rows[0][3].ToString();
                    txtDKod.Text = dt.Rows[0][4].ToString();
                    txtDAd.Text = dt.Rows[0][5].ToString();                    

                    if (uretimkayit > 0)
                    {
                        if (duruskayit > 0)
                        {
                            butBaslat.Enabled = false;
                            butBitir.Enabled = true;
                            butDuzelt.Enabled = true;
                            //butSil.Enabled = true;

                            try { textBas.Text = Convert.ToDateTime(dt.Rows[0][6].ToString()).ToString("HH:mm"); }
                            catch { }
                            try
                            {
                                int sure = Convert.ToInt32(dt.Rows[0][7].ToString());
                                int dk = 0, st = 0;
                                st = sure / 60;
                                dk = sure - (st * 60);
                                txtSure.Text = st + " st " + dk + " dk";
                            }
                            catch
                            {
                                
                            }
                        }
                        else
                        {
                            butBitir.Enabled = false;
                            butBaslat.Enabled = true;
                            butDuzelt.Enabled = false;
                            //butSil.Enabled = false;
                        }
                    }
                    else
                    {
                        if (chkBag.Checked)
                        {
                            butBitir.Enabled = false;
                            butBaslat.Enabled = true;
                            butDuzelt.Enabled = false;
                        }
                        else
                        {
                            if (!Utility.Sor(string.Format("İstasyonda açık operasyon bulunamadı başlatılsın mı?")))
                                return;
                            IstasyonDurum(true);
                            return;
                        }
                    }

                }
            }
            catch (Exception ee)
            {
                Utility.Hata("Genel hata:" + ee.Message);
            }
        }

        private void Temzile()
        {
            txtTKod.Text =
            txtTAd.Text =
            txtDKod.Text =
            txtSure.Text = 
            txtDAd.Text = "";
            checkBitis.Checked = true;
            butBaslat.Enabled = false;
            butBitir.Enabled = false;
            butDuzelt.Enabled = false;
            //butSil.Enabled = false;
            textBas.Text = DateTime.Now.ToString("HH:mm");
            textBit.Text = DateTime.Now.ToString("HH:mm");
            txtTKod.Focus();            
        }

        private void TekBaslat()
        {
            try
            {
                if (textBas.Text.Length < 5)
                {
                    Utility.Hata("Başlangıç saatini girin!");
                    textBas.Focus();
                    return;
                }
                int bag = (chkBag.Checked == true) ? 1 : 0;
                string istasyon = Utility.Engine.SqlTemizle(txtTKod.Text.Trim());
                string durus = Utility.Engine.SqlTemizle(txtDKod.Text.Trim());
                string bitis = "NULL";

                DateTime dbas = new DateTime(DateTime.Now.Year,
                    DateTime.Now.Month, DateTime.Now.Day,
                    Convert.ToInt32(textBas.Text.Substring(0, 2)),
                    Convert.ToInt32(textBas.Text.Substring(3, 2)), 0);

                if (checkBitis.Checked)
                    bitis = string.Format("N'{0}'", textBit.Text);

                Utility.Engine.sql = string.Format("EXEC erp.DurusBaslat N'{0}', N'{1}', '{2}', {3}, {4}",
                    istasyon, durus, dbas.ToString("HH:mm"), bag, bitis);
                DataTable dt = new DataTable();
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show(dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString(),"TAMAM",MessageBoxButtons.OK,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
                    Temzile();
                    return;
                }
                else
                {
                    Utility.Hata("Sunucu yanıt vermedi!");
                    return;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void TekBitir()
        {
            try
            {
                if (!Utility.Sor("İş Emri Duruş kaydı kapatılacak onaylıyor musunuz?"))
                    return;
                if (textBas.Text.Length < 5)
                {
                    Utility.Hata("Başlangıç saatini girin!");
                    textBas.Focus();
                    return;
                }
                string istasyon = Utility.Engine.SqlTemizle(txtTKod.Text.Trim());
                
                DateTime dbit = new DateTime(DateTime.Now.Year,
                   DateTime.Now.Month, DateTime.Now.Day,
                   Convert.ToInt32(textBit.Text.Substring(0, 2)),
                   Convert.ToInt32(textBit.Text.Substring(3, 2)), 0);

                Utility.Engine.sql = string.Format("EXEC erp.DurusBitir N'{0}', '{1}'",
                    istasyon, dbit.ToString("HH:mm"));
                DataTable dt = new DataTable();
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show(dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString(), "TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    Temzile();
                    return;
                }
                else
                {
                    Utility.Hata("Sunucu yanıt vermedi!");
                    return;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void TekDuzelt()
        {
            try
            {
                if (!Utility.Sor("İş Emri Duruş kaydı değiştirilecek onaylıyor musunuz?"))
                    return;
                int bag = (chkBag.Checked == true) ? 1 : 0;
                string istasyon = Utility.Engine.SqlTemizle(txtTKod.Text.Trim());
                string durus = Utility.Engine.SqlTemizle(txtDKod.Text.Trim());

                DateTime dbas = new DateTime(DateTime.Now.Year,
                    DateTime.Now.Month, DateTime.Now.Day,
                    Convert.ToInt32(textBas.Text.Substring(0, 2)),
                    Convert.ToInt32(textBas.Text.Substring(3, 2)), 0);
                
                Utility.Engine.sql = string.Format("EXEC erp.DurusDuzelt N'{0}', N'{1}', '{2}', {3}",
                    istasyon, durus, dbas.ToString("HH:mm"), bag);
                DataTable dt = new DataTable();
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show(dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString(), "TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    Temzile();
                    return;
                }
                else
                {
                    Utility.Hata("Sunucu yanıt vermedi!");
                    return;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void TekSil()
        {
            try
            {
                if (!Utility.Sor("İş Emri Duruş kaydı silinecek onaylıyor musunuz?"))
                    return;
                string istasyon = Utility.Engine.SqlTemizle(txtTKod.Text.Trim());

                Utility.Engine.sql = string.Format("EXEC erp.DurusSil N'{0}'", istasyon);
                DataTable dt = new DataTable();
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show(dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString(), "TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    Temzile();
                    return;
                }
                else
                {
                    Utility.Hata("Sunucu yanıt vermedi!");
                    return;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonIstasyon_Click(object sender, EventArgs e)
        {
            try
            {
                OzelSecim oz = new OzelSecim();
                oz.str_ad = "AD";
                oz.str_kod = "KOD";
                oz.str_ozel = "'' AS OZEL";
                oz.tablo = "dbo.STEZGAH (nolock) ";
                oz.order_by = " KOD, AD ";
                if (oz.ShowDialog() == DialogResult.OK)
                {
                    txtTKod.Text = oz.kod;
                    txtTAd.Text = oz.ad;
                    IstasyonDurum(false);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void buttonDurus_Click(object sender, EventArgs e)
        {
            try
            {
                OzelSecim oz = new OzelSecim();
                oz.str_ad = "DurusTanimi";
                oz.str_kod = "DurusKodu";
                oz.str_ozel = "DurusDurumu";
                oz.tablo = "dbo.durus_tanim (nolock)  ";//where DurusDurumu = N'Plansız'
                oz.order_by = " DurusKodu, DurusTanimi ";
                if (oz.ShowDialog() == DialogResult.OK)
                {
                    txtDKod.Text = oz.kod;
                    txtDAd.Text = oz.ad;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void txtTKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                IstasyonDurum(false);
                txtDKod.Text = "";
                txtDKod.Focus();
                return;
            }
        }

        private void txtDKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtDKod.Text = Utility.Engine.SqlTemizle(txtDKod.Text.Trim()).ToUpper();
                txtDAd.Text = Utility.Engine.dat.TSelectScalar(string.Format("SELECT TOP 1 ISNULL(DurusTanimi,'') FROM dbo.durus_tanim WITH (NOLOCK) WHERE DurusKodu = N'{0}'", txtDKod.Text));
                textBas.Focus();
                textBas.SelectAll();
                return;
            }
        }
      
        private void FormDurus_Load(object sender, EventArgs e)
        {
            Temzile();
            try
            {
                textBit.Text = 
                textBas.Text = Utility.Engine.dat.TSelectScalar("SELECT CONVERT(CHAR(5), GETDATE(), 108)");
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (panelDuruslar.Visible == false)
                {
                    Duruslar();
                }
                else
                {
                    panelDuruslar.Visible = false;
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message);
            }
            //TekSil();
        }

        private void Duruslar()
        {
            Utility.Engine.sql = string.Format(@"SELECT D.DurusKodu, D.BasTarih, D.BitTarih, DATEDIFF(MINUTE,D.BasTarih, D.BitTarih) AS SURE, T.DurusTanimi, D.ID FROM dbo.isemri_durus D WITH (NOLOCK) LEFT OUTER JOIN dbo.durus_tanim T WITH (NOLOCK) ON D.DurusKodu = T.DurusKodu WHERE D.FLAG = N'H' AND D.IstasyonKodu = N'{0}'", Utility.Engine.SqlTemizle(txtTKod.Text));
            DataTable dt = new DataTable();
            if (Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt) && dt != null && dt.Rows.Count > 0)
            {
                listView1.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item =
                        new ListViewItem();
                    item.Text = dr[0].ToString();
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    item.SubItems.Add(dr[3].ToString());
                    item.SubItems.Add(dr[4].ToString());
                    item.SubItems.Add(dr[5].ToString());
                    listView1.Items.Add(item);
                }

                panelDuruslar.Location = new Point(0, 92);
                panelDuruslar.Visible = true;
                panelDuruslar.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TekBitir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TekBaslat();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TekDuzelt();
        }

        private void textBas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox t = sender as TextBox;
                if (t != null)
                {
                    if (!char.IsNumber(e.KeyChar))
                    {
                        if (!char.IsControl(e.KeyChar))
                        {
                            e.Handled = true;
                        }
                    }                    
                    if (t.Text.Length > 5)
                    {
                        t.Text = t.Text.Substring(5);
                    }
                    if (t.Text.IndexOf(':') != 2)
                    {
                        t.Text = t.Text.Replace(":", "");
                        if (t.Text.Length > 2)
                        {
                            string text = t.Text.Substring(0, 2);
                            text += ":";
                            text += t.Text.Substring(2, t.Text.Length - 2);
                            t.Text = text;
                        }
                    }
                    t.Focus();
                t.SelectionStart = t.Text.Length;
                    //t.Select(t.Text.Length - 1, 1);
                }
                
            }
            catch 
            {
                
            }
        }

        private void checkBitis_CheckStateChanged(object sender, EventArgs e)
        {
            textBit.Enabled = checkBitis.Checked;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelDuruslar.Visible = false;
            listView1.Items.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ist = Utility.Engine.SqlTemizle(txtTKod.Text).Trim();
                if (listView1.Items.Count > 0 && Utility.Sor("Duruş bilgileri silinecek onaylıyor musunuz?"))
                {
                    Utility.Engine.sql = string.Format(@"DELETE FROM dbo.isemri_durus WHERE FLAG = N'H' AND IstasyonKodu = N'{0}'", ist);
                    if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
                    {
                        Utility.Hata("Kayıt silinemedi:" + Utility.Engine.dat.Fault);
                        return;
                    }
                    Duruslar();
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ist = Utility.Engine.SqlTemizle(txtTKod.Text).Trim();
                if (listView1.Items.Count > 0 && Utility.Sor("Seçilen duruş bilgileri silinecek onaylıyor musunuz?"))
                {
                    string id = "";
                    for (int loop = 0; loop < listView1.Items.Count; loop++)
                    {
                        if (listView1.Items[loop].Checked)
                        {
                            id = listView1.Items[loop].SubItems[5].Text;
                            Utility.Engine.sql = string.Format(@"DELETE FROM dbo.isemri_durus WHERE FLAG = N'H' AND ID = {0}", id);
                            if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
                            {
                                Utility.Hata("Kayıt silinemedi:" + Utility.Engine.dat.Fault);
                                return;
                            }
                            Duruslar();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message);
            }
        }
    }
}