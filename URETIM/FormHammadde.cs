using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class FormHammadde : Form
    {
        private enum Butonlar : int { Kapat = 0, HurdaKayit = 1, Sil = 2 };
        public FormHammadde()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            txtTKod.Text =
            txtTAd.Text =
            txtHKod.Text =  
            txtHAd.Text = "";
            toolBar1.Buttons[(int)Butonlar.HurdaKayit].Enabled = false;
            toolBar1.Buttons[(int)Butonlar.Sil].Enabled = false;
            txtSicil.Focus();
        }
        
        long uretimkayit = 0;

        private void IstasyonAdi()
        {
            if (txtSicil.Text == "")
            {
                MessageBox.Show("Sicil Kodunuzu Okutunuz !", "TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                Temizle();
                txtSicil.Focus();
            }

            txtTKod.Text = Utility.Engine.SqlTemizle(txtTKod.Text).Trim().ToUpper();

            Utility.Engine.sql = string.Format("SELECT * FROM dbo.STEZGAH (NOLOCK) where KOD=(N'{0}')", Utility.Engine.SqlTemizle(txtTKod.Text));
            DataTable dt = new DataTable();
            Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                txtTAd.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                txtTKod.Text = ""; txtTAd.Text = "";
                txtTKod.Focus();
            }
        }

        private void IstasyonDurum()
        {
            try
            {
                txtTKod.Text = Utility.Engine.SqlTemizle(txtTKod.Text).Trim().ToUpper();

                Utility.Engine.sql = string.Format("SELECT h.StokKodu,h.Miktar,s.StokAdi   FROM dbo.hammadde_kullanim h, dbo.stok_tanim_ust s  where h.StokKodu=s.StokKodu AND h.IstasyonKodu=(N'{0}')", Utility.Engine.SqlTemizle(txtTKod.Text));
                DataTable dt = new DataTable();
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
                listView1.Items.Clear();
                if (dt != null && dt.Rows.Count > 0)
                {
                    listView1.BeginUpdate();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = dt.Rows[i][0].ToString();
                        li.SubItems.Add(dt.Rows[i][1].ToString());
                        li.SubItems.Add(dt.Rows[i][2].ToString());
                        listView1.Items.Add(li);
                    }
                    listView1.EndUpdate();

                    //uretimkayit = Convert.ToInt64(dt.Rows[0][0].ToString());
                    //long hurdakayit = Convert.ToInt64(dt.Rows[0][1].ToString());
                    //double topfire = Convert.ToDouble(dt.Rows[0][6].ToString());                    
                    //string hata = dt.Rows[0][3].ToString();

                    //if (uretimkayit < 1)
                    //{
                    //    Utility.Hata("İstasyonda açık operasyon kaydı bulunamadı duruş başlatılamaz!\n" + hata);
                    //    Temizle();
                    //    return;
                    //}

                    //if (hurdakayit > 0)
                    //    toolBar1.Buttons[(int)Butonlar.Sil].Enabled = true;

                    //ListViewItem item = new ListViewItem();
                    //item.Text = dt.Rows[0][7].ToString();
                    //item.SubItems.Add(dt.Rows[0][8].ToString());

                    //toolBar1.Buttons[(int)Butonlar.HurdaKayit].Enabled = true;

                    //Birimler(item.Text.Trim());
                    
                    ////if (txtHKod.Text.Length > 0)
                    ////    textMiktar.Focus();
                    ////else
                    ////    txtHKod.Focus();
                    return;
                }
            }
            catch (Exception ee)
            {
                Utility.Hata("Genel hata:" + ee.Message);
            }
        }

        private void Birimler(string stk)
        {
//            textBoxBirim.Text = textBoxTopBirim.Text = Utility.Engine.dat.TSelectScalar(" SELECT top 1 Birim   FROM [DP2007].[dbo].[stok_tanim_detay] where StokKodu=N'" + stk + "' and AnaBirim='E' ");
        }


        private void TekSil()
        {
            try
            {
                if (!Utility.Sor("İş Emri Hurda kaydı silinecek onaylıyor musunuz?"))
                    return;
                string istasyon = Utility.Engine.SqlTemizle(txtTKod.Text.Trim());

                Utility.Engine.sql = string.Format("EXEC erp.HurdaSil N'{0}'", istasyon);
                DataTable dt = new DataTable();
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show(dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString(), "TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    Temizle();
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

        private void TekKaydet()
        {
            try
            {
                string sicil = Utility.Engine.SqlTemizle(txtSicil.Text.Trim());
                string istasyon = Utility.Engine.SqlTemizle(txtTKod.Text.Trim());
                string hurdakod = Utility.Engine.SqlTemizle(txtHKod.Text.Trim());
                string stokkod = "";
                double hmiktar = 0;
                int ekle = 1;

                    //try { hmiktar = Convert.ToDouble(textMiktar.Text.Trim()); }
                    //catch { }

                    //if (hmiktar <= 0)
                    //{
                    //    Utility.Hata("Hurda miktarı hatalı!");
                    //    return;
                    //}
                if (buttonEkle.Text == "-") ekle = 0;
                else ekle = 1;

                Utility.Engine.sql = string.Format("EXEC dbo.hammadde_islemleri N'{0}', N'{1}', N'{2}',{3}", sicil, istasyon, hurdakod, ekle);
                DataTable dt = new DataTable();
                Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show(dt.Rows[0][0].ToString(), "TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    Temizle();
                    return;
                }
                else
                {
                    Utility.Hata("Sunucu yanıt vermedi!");
                    return;
                }
                buttonEkle.Text = "+";
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
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
//                    IstasyonDurum();
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
                oz.str_ad = "HurdaAdi";
                oz.str_kod = "HurdaKodu";
                oz.str_ozel = "GrupKod";
                oz.tablo = "dbo.hurda_tanim (nolock)  ";
                oz.order_by = " HurdaAdi, HurdaKodu ";
                if (oz.ShowDialog() == DialogResult.OK)
                {
                    txtHKod.Text = oz.kod;
                    txtHAd.Text = oz.ad;
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == toolBar1.Buttons[(int)Butonlar.Kapat])
            {
                this.Close();
            }
            else if (e.Button == toolBar1.Buttons[(int)Butonlar.HurdaKayit])
            {
                TekKaydet();
            }
            else if (e.Button == toolBar1.Buttons[(int)Butonlar.Sil])
            {
                //TekSil();
                panel1.Visible = true;
                panel1.Location = new Point(0, 0);
                panel1.Size = new Size(235, 285);
                panel1.BringToFront();
                string sqlx = " Select ieh.ID,ht.HurdaAdi,ieh.Miktar From dbo.isemri_hurda AS ieh (nolock)  inner join  dbo.hurda_tanim AS ht (nolock) ON ieh.HurdaKod=ht.HurdaKodu   Where UKayitNo=N'" + uretimkayit.ToString() + "' ";
                DataTable dts = Utility.Engine.dat.TableDon(sqlx);
                listView2.Items.Clear();
                listView2.BeginUpdate();
                for (int i = 0; i < dts.Rows.Count; i++)
                {
                    //li.Text = dts.Rows[i][0].ToString();
                    //li.SubItems.Add(dts.Rows[i][1].ToString());
                    //li.SubItems.Add(dts.Rows[i][2].ToString());
                    //listView2.Items.Add(li);
                }
                listView2.EndUpdate();
            }
        }

        private void FormFire_Load(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtTKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                IstasyonAdi();
                IstasyonDurum();
            }
            
        }
        private void txtSicil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    string ukod = Utility.Engine.SqlTemizle(txtSicil.Text);
                    Utility.Engine.sql = string.Format("SELECT AD, SOYAD FROM dbo.SPERSONEL WITH (NOLOCK) WHERE KOD = N'{0}'", ukod);
                    DataTable dth = new DataTable();
                    Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dth);
                    if (dth != null && dth.Rows.Count > 0)
                    {
                        textTSicil.Text = dth.Rows[0][0].ToString() + " " + dth.Rows[0][0].ToString();
                        txtTKod.Focus();
                        return;
                    }
                    else
                    {
                        textTSicil.Text = "";
                        txtSicil.Focus();
                        return;
                    }
                }
                catch (Exception exc)
                {
                    Utility.Hata("Genel Hata:" + exc.Message);
                }
            }

        }

        private void txtHKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSicil.Text == "")
            {
                MessageBox.Show("Sicil Kodunuzu Okutunuz !", "TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                txtSicil.Focus();
            }
            if (txtTKod.Text == "")
            {
                MessageBox.Show("Istasyon Kodunuzu Okutunuz !", "TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                txtTKod.Focus();
            }
            
            if (e.KeyChar == (char)13)
            {
                try
                {
                    string ukod = Utility.Engine.SqlTemizle(txtHKod.Text);
                    Utility.Engine.sql = string.Format("SELECT StokKodu, StokAdi FROM dbo.stok_tanim_ust WITH (NOLOCK) WHERE StokKodu = N'{0}'", ukod);
                    DataTable dth = new DataTable(); 
                    Utility.Engine.dat.TableDoldur(Utility.Engine.sql, ref dth);
                    if (dth != null && dth.Rows.Count > 0)
                    {
                        txtHKod.Text = dth.Rows[0][0].ToString();
                        txtHAd.Text = dth.Rows[0][1].ToString();
                        TekKaydet();
                        IstasyonDurum();
                        return;
                    }
                    else
                    {
                        txtHKod.Text = "";
                        txtHAd.Text = "";
                        txtHKod.Focus();
                        return;
                    }
                }
                catch (Exception exc)
                {
                    Utility.Hata("Genel Hata:" + exc.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            IstasyonDurum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count < 1 || listView2.SelectedIndices == null || listView2.SelectedIndices.Count < 1)
                return;

            int secilen = int.Parse(listView2.SelectedIndices[0].ToString());

            string ID = listView2.Items[secilen].SubItems[0].Text;

            if (Utility.Engine.dat.TInsert("Delete  From  dbo.isemri_hurda  Where ID=N'" + ID + "'  "))
                listView2.Items.Remove(listView2.Items[secilen]);
            else
                MessageBox.Show("Silme Başarısız\n" + Utility.Engine.dat.STR_HataMesaji);

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (buttonEkle.Text == "+") buttonEkle.Text = "-";
            else buttonEkle.Text = "+";

        }

    }
}