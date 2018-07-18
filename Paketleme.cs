using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class Paketleme : Form
    {
        public Engine en;
        public Paketleme()
        {
            InitializeComponent();
        }

        private string PersonelKodu = "";
        private string PersonelAdi = "";
        private string IsEmri = "";
 
        private long UKayitNo = -1;

        private void Personel()
       {
          try
          {
             en.sql = string.Format("SELECT t.TanimValue,s.KOD,s.AD + ' ' + s.SOYAD AS ISIM FROM tanimlamalar t (NOLOCK) LEFT OUTER JOIN SPERSONEL s (NOLOCK) ON t.TanimValue = s.KOD WHERE t.TanimID = N'{0}' ", en.KullaniciID);
             DataTable dtx = new DataTable();
             en.dat.TableDoldur(en.sql, ref dtx);
             if (dtx != null && dtx.Rows.Count > 0)
             {
                PersonelKodu = dtx.Rows[0]["KOD"].ToString();
                PersonelAdi = dtx.Rows[0]["ISIM"].ToString();
             }
             else
             {
                en.Hata("Kullanýcý ERP Kodu Tanýmsýz Ýþlem Yapýlamaz!");
                Close();
                return;
             }
           
          }
          catch (Exception except)
          {
             en.Hata("Kullanýcý ERP Kodu Bulunamadý Ýþlem Yapýlamaz!");
             Close();
             return;
          }
       }
  
        private void SeriOkusun(bool acik)
       {
          textSeri.Enabled =
          buttonSeri.Enabled =
          buttonTSeri.Enabled = acik;
       }

        private void AcikOperasyon()
       {
          try
          {
             en.sql = string.Format(@"SELECT o.ID FROM isemri_operasyon o (NOLOCK) LEFT OUTER JOIN isemri_iscilik i (NOLOCK) ON i.UKayitNo = o.ID  WHERE ( o.BitTarih IS NULL) AND (i.PersonelKodu = N'{0}') ", PersonelKodu);
             
              UKayitNo = en.dat.TCount(en.sql);
             
              if (UKayitNo > 0)
             {
                buttonOperasyon.Text = "OP. BÝT";
                labelUretimID.Text = UKayitNo.ToString();
                Uretilenler();
                panelUst.Enabled = true;
                textPalet.Focus();
                return;
             }
             else
             {
                buttonOperasyon.Text = "OP. BAÞ";
                labelUretimID.Text = "";
                UKayitNo = 0;
                buttonOperasyon.Focus();
             }
          }
          catch (Exception except)
          {
             en.Hata("Üretim Bilgileri Sorgulanamadý!\n" + except.Message);
             labelUretimID.Text = "";
             buttonOperasyon.Text = "OP. BAÞ";
             UKayitNo = 0;
          }
       }

        string SonSeri = "";

        private void Uretilenler()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                en.sql = string.Format(@"SELECT b.SeriliBarkod,b.IsEmri,b.StokKodu,s.StokAdi FROM  dbo.serili_barkodlar b (NOLOCK) LEFT OUTER JOIN dbo.stok_tanim_ust s (NOLOCK) ON b.StokKodu = s.StokKodu  WHERE ( b.UKayitNo = N'{0}' )", labelUretimID.Text);
                en.dat.ListDoldur(ref listView1, en.sql);
                labelRows.Text = listView1.Items.Count.ToString();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception exc)
            {
                Cursor.Current = Cursors.Default;
                en.Hata("Üretilen Seriler Sorgulanýrken Genel Hata!\n" + exc.Message);
                return;
            }
        }

        private void PaletBul()
        {
            en.SonKasa = textKasa.Text;
            en.SonPaletID = textPalet.Text;
            try
            {
                string barkod = textPalet.Text.Trim();
                en.sql = string.Format("EXEC dbo.PaletBul1 N'{0}'", barkod.ToUpper());
                DataTable dtx = new DataTable();
                en.dat.TableDoldur(en.sql, ref dtx);
                if (dtx != null && dtx.Rows.Count > 0)
                {
                    textPalet.Text = dtx.Rows[0]["PaletID"].ToString();                    
                    return;
                }
                else
                {
                    //en.Hata("Palet Sistemde Bulunamadý!");
                    textPalet.Text = "";
                    textPalet.Focus();
                    return;
                }
            }
            catch (Exception except)
            {
                en.Hata("Palet Sorgulanýrken Hata Olustu!\n" + except.Message);
                return;
            }
        }

        private void KasaBul()
        {
            en.SonKasa =textKasa.Text;
            en.SonPaletID = textPalet.Text;

            try
            {
                string barkod = textKasa.Text.Trim();
                en.sql = string.Format("EXEC dbo.KasaBulPaketleme N'{0}'", barkod.ToUpper());
                DataTable dtx = new DataTable();
                en.dat.TableDoldur(en.sql, ref dtx);
                if (dtx != null && dtx.Rows.Count > 0)
                {
                    double mk = Convert.ToDouble(dtx.Rows[0]["Miktar"].ToString());
                    textKasa.Text = dtx.Rows[0]["SeriliBarkod"].ToString();
                    SeriOkusun(true);
                    textSeri.Focus();
                    return;
                }
                else
                {
                    en.Hata("Kasa Etiketi Sistemde Bulunamadý!");
                    textKasa.Text = "";
                    textKasa.Focus();
                    return;
                }
            }
            catch (Exception except)
            {
                en.Hata("Kasa Barkodu Sorgulanýrken Hata!\n" + except.Message);
                textKasa.Text = "";
                textKasa.Focus();
                return;
            }

            en.sql =string.Format(
                @" [dbo].[SeriBulPaketlemeKontrl] N'{0}',N'{1}',N'{2}',N'{3}' ",                
                textSeri.Text.ToUpper(),textPalet.Text.ToUpper(),textKasa.Text.ToUpper());
            
            DataTable dty=new DataTable();

            en.dat.TableDoldur(en.sql, ref dty);

            if (dty.Columns.Count == 3 && dty.Rows.Count > 0)
            {
                if (dty.Columns[1].ColumnName == "x" && dty.Columns[2].ColumnName == "y")
                {
                    PnlSor.Focus();
                    PnlSor.Location = new Point(ortax, ortay);                    
                    txtGercekMik.Focus();                                                              
                    lblKasadakalan.Text = dty.Rows[0]["SysGoreKasadaKalan"].ToString();
                    txtGercekMik.Text = "0";
                    txtDepodanEklenen.Text = "0";
                    txtSeri1.Text = "";

                    try
                    {
                        KoliMiktari = Convert.ToInt32(dty.Rows[0]["x"]);
                    }
                    catch { MessageBox.Show("Koli Miktarý Hesaplanamdý", "Dikkat..!"); }
                }
            }   

        }

        int KoliMiktari = 0;

        private void SeriliBarkod()
       {           
           en.SonKasa = textKasa.Text;
           en.SonPaletID = textPalet.Text;

          try
          {
             string barkod = textSeri.Text.Trim().ToUpper();
             if (barkod.Length > 0)
             {
                Cursor.Current = Cursors.WaitCursor;
                SonSeri = barkod;

                en.sql = string.Format("exec [dbo].[IsEmriOperasyonMiktarlari1x] N'{0}' ", barkod);
                
                DataTable  sonuc=new DataTable();


                if (!en.dat.TableDoldur(en.sql, ref sonuc))
                {
                   MessageBox.Show("Sunucu Hata Bildirdi..!" + en.dat.Fault, "Dikkat..!");
                   textSeri.Text = "";
                   textSeri.Focus();
                   Cursor.Current = Cursors.Default;
                   return;
                }

                if (buttonOperasyon.Text.Trim() == "OP.BÝT" && listView1.Items.Count > 0)
                {

                   if (sonuc == null || sonuc.Rows.Count < 1)
                   {
                      MessageBox.Show("Sunucu Yanýt Vermedi ");
                      textSeri.Text = "";
                      textSeri.Focus();
                      Cursor.Current = Cursors.Default;
                      return;
                   }

                   string str = sonuc.Rows[0][0].ToString().Trim();

                   if (str != "OK" && str != "T")
                   {
                      MessageBox.Show(str);
                      textSeri.Text = "";
                      textSeri.Focus();
                      Cursor.Current = Cursors.Default;
                      return;
                   }
                }


                Cursor.Current = Cursors.WaitCursor;

                en.sql = string.Format("EXEC dbo.SeriBulPaketleme1 N'{0}',N'{1}',N'{2}','{3}',N'{4}'",
                    barkod,
                   textPalet.Text.Trim().ToUpper(),
                   textKasa.Text.Trim().ToUpper(),
                   labelUretimID.Text, en.KullaniciID);

                DataTable dtx = new DataTable();
                en.dat.TableDoldur(en.sql, ref dtx);                                                
                 if (dtx != null && dtx.Rows.Count > 0)
                {
                   if (dtx.Rows[0][1].ToString().ToUpper() == "HATA")
                   {
                      Cursor.Current = Cursors.Default;
                      en.Hata("Sunucu Hata Bildiridi!\n" + dtx.Rows[0][0].ToString());
                   }
                   else
                   {
                       if (dtx.Columns.Count == 3 && dtx.Rows.Count >0)
                       {
                           if (dtx.Columns[1].ColumnName == "x" && dtx.Columns[2].ColumnName == "y")
                           {                               
                               
                               PnlSor.Location = new Point(ortax, ortay);
                               textSeri.Text = "";
                                                           
                                                              
                               lblKasadakalan.Text = dtx.Rows[0]["SysGoreKasadaKalan"].ToString();
                               try
                               {
                                   KoliMiktari = Convert.ToInt32(dtx.Rows[0]["x"]);
                               }
                               catch { MessageBox.Show("Koli Miktarý Hesaplanamdý","Dikkat..!"); }

                               txtGercekMik.Text = "";
                               txtDepodanEklenen.Text = "";
                               txtSeri1.Text = "";

                               PnlSor.Focus();
                               txtGercekMik.Focus();

                               butonla = false;
                               return;                          
                           }
                       }                                             
                   }
                }

                Uretilenler();
             }
             Cursor.Current = Cursors.Default;             
             textSeri.Text = "";
             textSeri.Focus();
             return;
          }
          catch (Exception except)
          {
             Cursor.Current = Cursors.Default;
             en.Hata("Seri Sorgulanýrken Genel Hata!\n" + except.Message);
             textSeri.Text = "";
             textSeri.Focus();
             return;
          }
       }

        int ortax = 15;
        int ortay = 97;
        
        int gizlex = 424;
        int gizley = 251;

        private void Paketleme_Load(object sender, EventArgs e)
        {
           Personel();
           AcikOperasyon();


           textKasa.Text = en.SonKasa;
           textPalet.Text = en.SonPaletID;

           if (textPalet.Text.Trim() != "" && textKasa.Text.Trim() != "")
           {               
               textSeri.Enabled = true;
           }
           
            return;
        }

        private void buttonTPalet_Click(object sender, EventArgs e)
        {
            Tus t = new Tus();
            t.textBox1.Text = textPalet.Text;
            if (t.ShowDialog() == DialogResult.OK)
                textPalet.Text = t.textBox1.Text;
            textPalet.Focus();
            return;
        }

        private void buttonTKasa_Click(object sender, EventArgs e)
        {
            Tus t = new Tus();
            t.textBox1.Text = textKasa.Text;
            if (t.ShowDialog() == DialogResult.OK)
                textKasa.Text = t.textBox1.Text;
            textKasa.Focus();
            return;
        }

        private void buttonTSeri_Click(object sender, EventArgs e)
        {
            Tus t = new Tus();
            t.textBox1.Text = textSeri.Text;
            if (t.ShowDialog() == DialogResult.OK)
                textSeri.Text = t.textBox1.Text;
            textSeri.Focus();
            return;
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textPalet_KeyUp(object sender, KeyEventArgs e)
        {
           // if (e.KeyCode == Keys.Enter) PaletBul();
        }

        private void buttonPalet_Click(object sender, EventArgs e)
        {
            PaletBul();            
        }

        private void textKasa_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) KasaBul();
        }

        private void buttonKasa_Click(object sender, EventArgs e)
        {
            KasaBul();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
       {
          Close();
       }

     
        private void buttonOperasyon_Click(object sender, EventArgs e)
       {
          try
          {
             if (buttonOperasyon.Text == "OP. BAÞ")
             {
                #region baslat
                if (!en.Sor("Ýþ Emri Operasyon Baþlatýlacak Onaylýyormusunuz?")) return;

                Cursor.Current = Cursors.WaitCursor;

                en.sql = string.Format("EXEC dbo.YeniOperasyonPaketleme N'{0}'", PersonelKodu);
                long uid = en.dat.TCount(en.sql);
                if (uid == -1)
                {
                   Cursor.Current = Cursors.Default;
                   en.Hata("Sunucu Ýsteði Kabul Etmedi!");
                   return;
                }
                if (uid == -2)
                {
                   Cursor.Current = Cursors.Default;
                   en.Hata("Sunucu Ýsteði Gerçekleþtiremedi! Ýþ Emri Operasyon Kaydý Baþlatamadý");
                   return;
                }
                if (uid == -3)
                {
                   Cursor.Current = Cursors.Default;
                   en.Hata("Sunucu Ýsteði Gerçekleþtiremedi! Ýþ Emri Ýþçilik Kaydý Baþlatamadý");
                   return;
                }
                if (uid == -4)
                {
                   Cursor.Current = Cursors.Default;
                   en.Hata("Sunucu Ýsteði Gerçekleþtiremedi! Personel Sicil No Bilinmiyor:" + PersonelKodu);
                   return;
                }
                Cursor.Current = Cursors.Default;
                if (uid > 0)
                {
                   buttonOperasyon.Text = "OP.BÝT";
                   labelUretimID.Text = uid.ToString();
                   panelUst.Enabled = true;
                   Uretilenler();
                   textPalet.Focus();
                   return;
                }
                else
                {
                   en.Hata("Üretim Kaydý Oluþturuluamadý!");
                   labelUretimID.Text = "";
                   listView1.Items.Clear();
                   textKasa.Text = "";
                   textPalet.Text = "";
                   textSeri.Text = "";
                   labelRows.Text = "";
                   buttonTSeri.Enabled = 
                   buttonSeri.Enabled =
                   textSeri.Enabled =
                   panelUst.Enabled = false;
                }
                #endregion
             }
             else
             {
                #region bitir
                if (labelUretimID.Text.Length > 0)
                {
                   if (!en.Sor("Ýþ Emri Operasyon Kaydý Kapatýlacak Onaylýyormusunuz?")) return;
                   en.sql = string.Format("EXEC dbo.OperasyonBitirPaketleme {0} ", labelUretimID.Text);
                   DataTable dtx = new DataTable();
                   en.dat.TableDoldur(en.sql, ref dtx);
                   if (dtx != null && dtx.Rows.Count > 0)
                   {
                      if (dtx.Rows[0][1].ToString().ToUpper() == "HATA")
                      {
                         en.Hata("Sunucu Hatasý:" + dtx.Rows[0][0].ToString());
                      }
                      else
                      {
                         panelUst.Enabled = false;
                         SeriOkusun(false);
                         Uretilenler();
                         buttonOperasyon.Text = "OP. BAÞ";
                         labelUretimID.Text = "";
                         textKasa.Text = "";
                         textPalet.Text = "";
                         textSeri.Text = "";
                         labelRows.Text = "";
                      }
                   }
                   labelUretimID.Text = "";
                   textKasa.Text = "";
                   textPalet.Text = "";
                   textSeri.Text = "";
                   labelRows.Text = "";
                }
                labelUretimID.Text = "";                
                textKasa.Text = "";
                textPalet.Text = "";
                textSeri.Text = "";
                labelRows.Text = "";
                listView1.Items.Clear();
                buttonTSeri.Enabled =
                buttonSeri.Enabled =
                textSeri.Enabled =
                panelUst.Enabled = false;
#endregion
             }
             Cursor.Current = Cursors.Default;
          }
          catch (Exception except)
          {
             Cursor.Current = Cursors.Default;
             en.Hata("Genel Hata!\n" + except.Message);
             return;
          }
       }

        private void buttonSeri_Click(object sender, EventArgs e)
       {

       }

        private void textPalet_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar == 13) { this.PaletBul(); textKasa.Focus(); }            
       }
 
        private void textKasa_KeyPress(object sender, KeyPressEventArgs e)
       {
          if (e.KeyChar == 13) this.KasaBul();
       }

        private void textSeri_KeyPress(object sender, KeyPressEventArgs e)
       {
          if (e.KeyChar == 13) this.SeriliBarkod();
       }

        private void textPalet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textKasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtGercekMik_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!char.IsControl(e.KeyChar))
            {
                if (!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

           if (txtGercekMik.Text.Trim() == "" && txtDepodanEklenen.Text.Trim() == "")
           {
              PnlSor.Location = new Point(gizlex, gizley);
              return; }


            int Depodan = 0;
            int Gercek = 0;
            int Bizdekalan = 0;

            try { Bizdekalan = Convert.ToInt32(lblKasadakalan.Text.Trim().PadLeft(1, '0')); }
            catch { }

            try { Gercek = Convert.ToInt32(txtGercekMik.Text.Trim().PadLeft(1, '0')); }
            catch { }

            try { Depodan = Convert.ToInt32(txtDepodanEklenen.Text.Trim().PadLeft(1, '0')); }
            catch { }


            string seri = "";

            if (SonSeri.Trim() != "")
            {
                seri = SonSeri;
            }
            else if (listView1.Items.Count > 0)
            {
                seri = listView1.Items[0].SubItems[0].Text; 
            }
            else if (txtSeri1.Text.Trim() != "")
            {
                seri = txtSeri1.Text.Trim();
            }
            

            if (KoliMiktari == 0.0)
            {
                string k = "";

                try
                {
                    k = en.dat.TSelectScalar(@" [dbo].[KoliMiktarBul] N'" + seri.Trim() + "'").PadLeft(1, '0');
                }
                catch { }

                try
                {
                    KoliMiktari = Convert.ToInt32(k);
                }
                catch
                {

                    //en.Hata("Koli Miktarý Tespit Edilemedi ..:  " + k);                    
                }
            }


            if (seri.Trim() == "" && butonla)
            {
                string strh = string.Format("exec  [dbo].[KasaSIFIRLA] N'" + textKasa.Text.Trim() + "',N'" + Gercek + "'");

                en.dat.TInsert(strh);

                PnlSor.Location = new Point(gizlex, gizley);

                Uretilenler();

                butonla = false;

                return;
            }


            
            if (Bizdekalan < Gercek && Gercek >= KoliMiktari)
            {
                en.sql =
                   string.Format(
                   @"EXEC [dbo].[ArtanlariAyarla] N'{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'3'",
                       txtSeri1.Text,
                       textPalet.Text.Trim().ToUpper(),
                       textKasa.Text.Trim().ToUpper(),
                       labelUretimID.Text,
                       Gercek,
                       Depodan);

                DataTable dtx = new DataTable();

                en.dat.TableDoldur(en.sql, ref dtx);

                if (dtx != null && dtx.Rows.Count > 0)
                {
                    if (dtx.Rows[0][1].ToString().ToUpper() == "HATA")
                    {
                        Cursor.Current = Cursors.Default;
                        en.Hata("Sunucu Hata Bildiridi!\n" + dtx.Rows[0][0].ToString());
                    }
                }    
            }
            else if (Depodan > 0 && Gercek > 0 && !butonla)
            {
                if (Gercek + Depodan != KoliMiktari)
                {
                    MessageBox.Show("Girilen Deðerlere Göre Bir Koli Oluþturamassýnýz", "Dikkat..!");
                    PnlSor.Location = new Point(gizlex, gizley);
                    return;
                }

                en.sql =
                   string.Format(
                   @"EXEC [dbo].[ArtanlariAyarla] N'{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'2'",
                       txtSeri1.Text,
                       textPalet.Text.Trim().ToUpper(),
                       textKasa.Text.Trim().ToUpper(),
                       labelUretimID.Text,
                       Gercek,
                       Depodan);

                DataTable dtx = new DataTable();

                en.dat.TableDoldur(en.sql, ref dtx);

                if (dtx != null && dtx.Rows.Count > 0)
                {
                    if (dtx.Rows[0][1].ToString().ToUpper() == "HATA")
                    {
                        Cursor.Current = Cursors.Default;
                        en.Hata("Sunucu Hata Bildiridi!\n" + dtx.Rows[0][0].ToString());
                    }
                }
            }
            else if (Gercek > 0 && !butonla)
            {
                               
                en.sql =
                string.Format(
                @"EXEC [dbo].[ArtanlariAyarla] N'{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'1'",
                    SonSeri,
                    textPalet.Text.Trim().ToUpper(),
                    textKasa.Text.Trim().ToUpper(),
                    labelUretimID.Text,
                    Gercek,
                    Depodan);

                DataTable dtx = new DataTable();

                en.dat.TableDoldur(en.sql, ref dtx);

                if (dtx != null && dtx.Rows.Count > 0)
                {
                    if (dtx.Rows[0][1].ToString().ToUpper() == "HATA")
                    {
                        Cursor.Current = Cursors.Default;
                        en.Hata("Sunucu Hata Bildiridi!\n" + dtx.Rows[0][0].ToString());
                    }
                }
            }
            else if (Gercek < Bizdekalan && Bizdekalan >= KoliMiktari)
            {

                //string seri="";

                //if (SonSeri.Trim() != "")
                //{
                //    seri = SonSeri;
                //}
                //else 
                //{
                //    if(listView1.Items.Count >0)
                //    { seri = listView1.Items[0].SubItems[0].Text; }
                //}

                if (Gercek > 0 && Depodan <1)
                {
                    en.sql =
                      string.Format(
                      @"EXEC [dbo].[ArtanlariAyarla] N'{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'1'",
                          seri,
                          textPalet.Text.Trim().ToUpper(),
                          textKasa.Text.Trim().ToUpper(),
                          labelUretimID.Text,
                          Gercek,
                          Depodan);
                }
                else if (Gercek > 0 && Depodan > 0)
                {

                    if (txtSeri1.Text.Trim() == "")
                    {
                        en.Hata("Seri Bilgisi Boþ Gecilemez..!");
                        return;
                    }

                    en.sql =
                       string.Format(
                       @"EXEC [dbo].[ArtanlariAyarla] N'{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'2'",
                           txtSeri1.Text,
                           textPalet.Text.Trim().ToUpper(),
                           textKasa.Text.Trim().ToUpper(),
                           labelUretimID.Text,
                           Gercek,
                           Depodan);
                }

                DataTable dtx = new DataTable();

                en.dat.TableDoldur(en.sql, ref dtx);

                if (dtx != null && dtx.Rows.Count > 0)
                {
                    if (dtx.Rows[0][1].ToString().ToUpper() == "HATA")
                    {
                        Cursor.Current = Cursors.Default;
                        en.Hata("Sunucu Hata Bildiridi!\n" + dtx.Rows[0][0].ToString());
                    }
                }    
            }

            PnlSor.Location = new Point(gizlex, gizley);

            Uretilenler();

            butonla = false;
        }

        private void txtDepodanEklenen_TextChanged(object sender, EventArgs e)
        {
            int Depodan = 0;            

            try { Depodan = Convert.ToInt32(txtDepodanEklenen.Text.Trim().PadLeft(1, '0')); }
            catch { }

            if (Depodan > 0)
            {
                txtSeri1.Enabled = true;
                txtSeri1.BackColor = Color.Gold;
            }
            else 
            {
                txtSeri1.Enabled = false;
                txtSeri1.BackColor = Color.Khaki;
            }
        }

        private void txtGercekMik_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDepodanEklenen.Focus();
                txtDepodanEklenen.SelectAll();
            }
        }

        private void txtDepodanEklenen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSeri1.Focus();
        }

        private void txtSeri1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtSeri1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2_Click(null, null);
        }

        private void Paketleme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                buttonOperasyon_Click(null, null);
        }

        private void buttonOperasyon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                buttonOperasyon_Click(null, null);
        }

        private void txtGercekMik_TextChanged(object sender, EventArgs e)
        {           
            int Gercek = 0;

            try { Gercek = Convert.ToInt32(txtGercekMik.Text.Trim().PadLeft(1, '0')); }
            catch { }
            
            if (Gercek > 0)
            {
                txtSeri1.Enabled = true;
                txtSeri1.BackColor = Color.Gold;
            }
            else
            {
                txtSeri1.Enabled = false;
                txtSeri1.BackColor = Color.Khaki;
            }
        }

        bool butonla = false;

        private void button3_Click(object sender, EventArgs e)
        {
            PnlSor.Focus();
            PnlSor.Location = new Point(ortax, ortay);
            textSeri.Text = "";
            txtGercekMik.Focus();
            txtGercekMik.SelectAll();

            string str = string.Format(@"
            SELECT Miktar FROM dbo.serili_barkodlar (NOLOCK) WHERE( SeriliBarkod =N'{0}')", textKasa.Text.ToUpper().Trim());
            lblKasadakalan.Text = en.dat.TSelectScalar(str);
            
            txtGercekMik.Text = "";
            txtDepodanEklenen.Text = "";
            txtSeri1.Text = "";

            butonla = true;

        }

       private void button4_Click(object sender, EventArgs e)
       {
          PnlSor.Location = new Point(gizlex, gizley); 
       }
    }
}