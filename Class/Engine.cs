using System;
using System.Data.Common;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace AmbarPPC
{
   /// <summary>
   /// 
   /// </summary>
    public class Engine
    {
        public string STR_HataMesaji, sql;

        private string logdosyayolu = @"\sqllog.txt";
        public System.Globalization.NumberFormatInfo cfi, nfi;
        public bool Cikiss = false;
        public string KullaniciID, KullaniciAdi,KullaniciKod;
        public Database dat;
        public String CariKod, CariAd, GrupKod, FaturaTipi, FaturaTipi_StokAdi, GrupAd;
        public double IskYuzde1, IskYuzde2, IskYuzde3;
        public string FaturaAdres1, FaturaAdres2, FaturaAdres3, SehirAd, VergiDairesi, VergiNo, FaturaAltBilgi;
        public string MCariAd, MFaturaAdres1, MFaturaAdres2, MFaturaAdres3, MSehirAd, MVergiDairesi, MVergiNo;
        public string FaturaNo, IrsaliyeNo;
        public string MerkezCariKod;
        public string CihazID = "";
        public System.IO.StreamWriter printfile;
        public bool tofile;
        public bool pccompile;
        public string FiyatGrupKodu;
        public bool EksiStokOlmasin = true;
        public string STR_ConnectionString, STR_ProgramDizini;
        public string SonPaletID, SonKasa, OpNo = "";
        public string PaletNo = "";
        public string STR_IP, STR_Port, STR_DatabaseUser, STR_DatabasePassword, STR_Database = "", path = "", connectionstring = "", sifre = "";

        public Engine(string connectionstring)
        {
            tofile = false;

            sifre = "";

            STR_HataMesaji = "";
            sql = "";
            FiyatGrupKodu = "";


            try
            {
                CihazID = new TWinApi().GetIdValid();
            }
            catch { }

            try
            {
                dat = new Database(connectionstring);                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            int[] numberformatseperator = { 3, 3, 3, 3, 3, 3, 3, 3, 3 };

            cfi = new System.Globalization.CultureInfo("en-US", true).NumberFormat;
            cfi.CurrencyDecimalDigits = 2;
            cfi.CurrencyDecimalSeparator = ".";
            cfi.CurrencyGroupSeparator = ",";
            cfi.CurrencyGroupSizes = numberformatseperator;
            cfi.CurrencySymbol = "";
            cfi.CurrencySymbol = "TL";

            cfi.NumberDecimalDigits = 2;
            cfi.NumberDecimalSeparator = ".";
            cfi.NumberGroupSeparator = ",";
            cfi.NumberGroupSizes = numberformatseperator;

            nfi = new System.Globalization.CultureInfo("en-US", true).NumberFormat;
            nfi.CurrencyDecimalDigits = 3;
            nfi.CurrencyDecimalSeparator = ".";
            nfi.CurrencyGroupSeparator = ",";
            nfi.CurrencyGroupSizes = numberformatseperator;
            nfi.CurrencySymbol = "";
            nfi.CurrencySymbol = "";

            nfi.NumberDecimalDigits = 3;
            nfi.NumberDecimalSeparator = ".";
            nfi.NumberGroupSeparator = ",";
            nfi.NumberGroupSizes = numberformatseperator;


            if (!Connect) return;

        }

        ~Engine()
        {
        }

        public bool mesajlar;

        public string SqlTemizle(string str)
        {
            string s;
            s = str.Replace("\'", "");
            s = s.Replace("\"", "");
            s = s.Replace("%", "");
            return s;
        }

        public string Basamakla(string str)
        {
            String s, s1, kusurat = "";
            s = "";
            s1 = "";
            int i;
            bool eksi;
            eksi = false;

            if ((i = str.IndexOf(",")) >= 0)
            {
                kusurat = str.Substring(i, str.Length - i);
                str = str.Substring(0, i);
            }


            if (str.Length < 4)
                return str + kusurat;

            if (str[0] == '-')
            {
                str = str.Remove(0, 1);
                eksi = true;
            }

            for (i = str.Length - 1; i >= 0; i--)
                s += str[i];

            int count = 0;

            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    break;
                if (count == 0 && i != 0)
                {
                    s1 += '.';
                }
                s1 += s[i];
                count = (count + 1) % 3;
            }

            str = "";
            for (i = s1.Length - 1; i >= 0; i--)
                str += s1[i];

            if (eksi == true)
                str = str.Insert(0, "-");

            return str + kusurat;
        }

        public string Turkcele(String s)
        {
            s = s.Replace('Ç', 'C');
            s = s.Replace('ç', 'c');
            s = s.Replace('i', 'i');
            s = s.Replace('i', 'I');

            s = s.Replace('ð', 'g');
            s = s.Replace('Ð', 'G');

            s = s.Replace('ö', 'o');
            s = s.Replace('Ö', 'O');

            s = s.Replace('ü', 'u');
            s = s.Replace('Ü', 'U');

            s = s.Replace('ş', 's');
            s = s.Replace('ş', 'S');


            return s;
        }

        public void KlavyeAc(bool mode)
        {
            //	WinApi.TShellExecute(dat.STR_ProgramDizini + "\\VKBD.exe");
            //if (mode)
            //   WinApi.Klavye(1);
            //else
            //   WinApi.Klavye(0);
        }

        public string GetFieldFromCsv(string source, int count, char delimeter)
        {
            String str;
            str = "";
            int i;

            if (source.Length == 0)
                return str;

            for (i = 0; i < source.Length && count > 0; i++)
                if (source[i] == delimeter)
                    count--;

            if (i == source.Length)
                return str;

            while (i < source.Length && source[i] != delimeter)
            {
                str += source[i];
                i++;
            }

            str = str.Replace("\"", "");
            str = str.Replace("\'", "");
            str = str.Trim();
            return str;
        }

        public void IadeDoldur(ref ListView list, string stokkodu)
        {
            #region FATURA EDiLMişLERi AL
            sql = @"SELECT     FaturaDetay.FaturaNo, FaturaDetay.Miktar, FaturaDetay.Fiyat, FaturaUst.Tarih, FaturaUst.Saat, FaturaUst.IskontoOran
					FROM         FaturaUst INNER JOIN
                    FaturaDetay ON FaturaUst.FaturaNo = FaturaDetay.FaturaNo
					WHERE     (FaturaDetay.StokKodu = '";
            sql += stokkodu;
            sql += "') AND (FaturaUst.CariKod = '";
            sql += CariKod;
            sql += "')";
            sql += " ORDER BY FaturaUst.Tarih DESC";

            dat.ListDoldur(ref list, sql);
            #endregion
            #region IADELERi DÜş
            sql = @"SELECT     IadeDetay.FaturaNo,IadeDetay.Miktar
					FROM         IadeDetay INNER JOIN
                    FaturaUst ON IadeDetay.FaturaNo = FaturaUst.FaturaNo
					WHERE     (FaturaUst.CariKod = '";
            sql += CariKod;
            sql += "') AND (IadeDetay.StokKodu='";
            sql += stokkodu;
            sql += "')";

            IDataReader rd = dat.TSelect(sql);

            while (rd != null && rd.Read())
            {
                for (int i = 0; i < list.Items.Count; i++)
                {
                    if (list.Items[i].SubItems[0].Text == rd.GetValue(rd.GetOrdinal("FaturaNo")).ToString())
                    {
                        list.Items[i].SubItems[1].Text = Convert.ToString(Convert.ToDouble(list.Items[i].SubItems[1].Text, cfi) - Convert.ToDouble(rd.GetValue(rd.GetOrdinal("Miktar")).ToString(), cfi), cfi);
                        if (list.Items[i].SubItems[1].Text == "0")
                        {
                            list.Items.RemoveAt(i);
                            i--;
                        }
                        break;
                    }
                }
            }
            if (rd != null)
                rd.Close();
            #endregion
        }

        public bool Sor(string soru)
        {
            return MessageBox.Show(soru, "DiKKAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;
        }

        public void Hata(string mesaj)
        {
            MessageBox.Show(mesaj, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1); return;
        }
        public void Uyari(string mesaj)
        {
            MessageBox.Show(mesaj, "DIKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1); return;
        }
        public void Tamam(string tmm)
        {
            if (mesajlar)
                MessageBox.Show(tmm, "TAMAM.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); return;
        }
        public void SqlYaz(string file)
        {
            StreamWriter w = File.CreateText(@"\" + file + "");
            w.Write(sql);
            w.Flush();
            w.Close();
        }

        public double DegisimMiktariAl(string stokkodu)
        {
            double miktar = 0;
            IDataReader rd;

            #region FATURA EDiLMiş MiKTARI AL
            sql = @"SELECT     SUM(FaturaDetay.Miktar)
					FROM         FaturaUst INNER JOIN
                    FaturaDetay ON FaturaUst.FaturaNo = FaturaDetay.FaturaNo
					WHERE     (FaturaDetay.StokKodu = '";
            sql += stokkodu;
            sql += "') AND (FaturaUst.CariKod = '";
            sql += CariKod;
            sql += "')";

            rd = dat.TSelect(sql);
            if (rd != null && rd.Read() && !rd.IsDBNull(0))
            {
                miktar = Convert.ToDouble(rd.GetValue(0));
            }
            else
                miktar = 0;

            if (rd != null)
                rd.Close();
            #endregion
            #region iADE ALINMIş MiKTARI DÜş
            sql = @"SELECT     SUM(Iade.Miktar)
					FROM     Iade INNER JOIN
                    FaturaUst ON Iade.FaturaNo = FaturaUst.FaturaNo
					WHERE     (FaturaUst.CariKod = '";
            sql += CariKod;
            sql += "') AND (Iade.StokKodu='";
            sql += stokkodu;
            sql += "')";

            rd = dat.TSelect(sql);
            if (rd != null && rd.Read() && !rd.IsDBNull(0))
            {
                miktar -= Convert.ToDouble(rd.GetValue(0));
            }
            if (rd != null)
                rd.Close();
            #endregion
            #region DEÐişiMDE GERi ALINMIş MiKTARI DÜş
            sql = @"SELECT     SUM(Miktar)
					FROM     Degisim
					WHERE     (CariKod = '";
            sql += CariKod;
            sql += "') AND (StokKodu='";
            sql += stokkodu;
            sql += "')";

            rd = dat.TSelect(sql);
            if (rd != null && rd.Read() && !rd.IsDBNull(0))
            {
                miktar -= Convert.ToDouble(rd.GetValue(0));
            }
            if (rd != null)
                rd.Close();
            #endregion
            #region DEÐişiMDE VERiLMiş MiKTARI EKLE
            sql = @"SELECT     SUM(Miktar)
					FROM     Degisim 
					WHERE     (CariKod = '";
            sql += CariKod;
            sql += "') AND (StokKodu2='";
            sql += stokkodu;
            sql += "')";

            rd = dat.TSelect(sql);
            if (rd != null && rd.Read() && !rd.IsDBNull(0))
            {
                miktar += Convert.ToDouble(rd.GetValue(0));
            }
            if (rd != null)
                rd.Close();
            #endregion
            return miktar;
        }

        private string SayiOku(char i)
        {
            if (i == '0')
                return "";
            else if (i == '1')
                return "Bir";
            else if (i == '2')
                return "Iki";
            else if (i == '3')
                return "Uç";
            else if (i == '4')
                return "Dort";
            else if (i == '5')
                return "Bes";
            else if (i == '6')
                return "Alti";
            else if (i == '7')
                return "Yedi";
            else if (i == '8')
                return "Sekiz";
            else if (i == '9')
                return "Dokuz";
            else
                return "";
        }

        private string SayiOku10(char i)
        {
            if (i == '0')
                return "";
            else if (i == '1')
                return "On";
            else if (i == '2')
                return "Yirmi";
            else if (i == '3')
                return "Otuz";
            else if (i == '4')
                return "Kirk";
            else if (i == '5')
                return "Elli";
            else if (i == '6')
                return "Atmis";
            else if (i == '7')
                return "Yetis";
            else if (i == '8')
                return "Seksen";
            else if (i == '9')
                return "Doksan";
            else
                return "";
        }
        public string Okunus(double d, bool tip)
        {
            String sayi;
            String okunus = "";
            string ondalik = "";
            bool YTLvar = false, YKRvar = false;

            sayi = d.ToString("N", cfi);

            int index;
            if ((index = sayi.IndexOf(".")) > -1)
            {
                ondalik = sayi.Substring(index, sayi.Length - index);
                sayi = sayi.Remove(index, sayi.Length - index);
                ondalik = ondalik.Replace(".", "");
            }

            int i = 0;

            if (Convert.ToDouble(sayi, cfi) >= 100000000000)
            {
                if (sayi[0] == '1')
                    okunus += "Yuz";
                else
                {
                    okunus += SayiOku(sayi[0]);
                    okunus += "Yuz";
                }

                sayi = sayi.Remove(0, 1);
                okunus += SayiOku10(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += "Milyar";
                YTLvar = true;
            }

            else if (Convert.ToDouble(sayi, cfi) >= 10000000000)
            {
                okunus += SayiOku10(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += "Milyar";
                YTLvar = true;
            }

            else if (Convert.ToDouble(sayi, cfi) >= 1000000000)
            {
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += "Milyar";
                YTLvar = true;
            }

            sayi = Convert.ToDouble(sayi, cfi).ToString("N", cfi).Replace(",", "");

            if (sayi.IndexOf(".") >= 0)
                sayi = sayi.Remove(sayi.IndexOf("."), sayi.Length - sayi.IndexOf("."));

            ///
            if (Convert.ToDouble(sayi, cfi) >= 100000000)
            {
                if (sayi[0] == '1')
                    okunus += "Yuz";
                else if (sayi[i] != '0')
                {
                    okunus += SayiOku(sayi[0]);
                    okunus += "Yuz";
                }

                sayi = sayi.Remove(0, 1);
                okunus += SayiOku10(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += "Milyon";
                YTLvar = true;
            }

            else if (Convert.ToDouble(sayi, cfi) >= 10000000)
            {
                okunus += SayiOku10(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += "Milyon";
                YTLvar = true;
            }

            else if (Convert.ToDouble(sayi, cfi) >= 1000000)
            {
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += "Milyon";
                YTLvar = true;
            }


            sayi = Convert.ToDouble(sayi, cfi).ToString("N", cfi).Replace(",", "");

            if (sayi.IndexOf(".") >= 0)
                sayi = sayi.Remove(sayi.IndexOf("."), sayi.Length - sayi.IndexOf("."));

            if (Convert.ToDouble(sayi, cfi) >= 100000)
            {
                if (sayi[0] == '1')
                    okunus += "Yuz";
                else if (sayi[i] != '0')
                {
                    okunus += SayiOku(sayi[0]);
                    okunus += "Yuz";
                }

                sayi = sayi.Remove(0, 1);
                okunus += SayiOku10(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += "Bin";
                YTLvar = true;
            }

            else if (Convert.ToDouble(sayi, cfi) >= 10000)
            {
                okunus += SayiOku10(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += "Bin";
                YTLvar = true;
            }
            else if (Convert.ToDouble(sayi, cfi) >= 1000)
            {
                if (sayi[i] != '1')
                {
                    okunus += SayiOku(sayi[0]);
                }
                sayi = sayi.Remove(0, 1);
                okunus += "Bin";
                YTLvar = true;
            }

            sayi = Convert.ToDouble(sayi, cfi).ToString("N", cfi).Replace(",", "");

            if (sayi.IndexOf(".") >= 0)
                sayi = sayi.Remove(sayi.IndexOf("."), sayi.Length - sayi.IndexOf("."));



            if (Convert.ToDouble(sayi, cfi) >= 100)
            {
                if (sayi[0] == '1')
                    okunus += "Yuz";
                else if (sayi[i] != '0')
                {
                    okunus += SayiOku(sayi[0]);
                    okunus += "Yuz";
                }

                sayi = sayi.Remove(0, 1);
                okunus += SayiOku10(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                YTLvar = true;
            }
            else if (Convert.ToDouble(sayi, cfi) >= 10)
            {
                okunus += SayiOku10(sayi[0]);
                sayi = sayi.Remove(0, 1);
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                YTLvar = true;
            }
            else if (Convert.ToDouble(sayi, cfi) >= 1)
            {
                okunus += SayiOku(sayi[0]);
                sayi = sayi.Remove(0, 1);
                YTLvar = true;
            }


            if (YTLvar)
            {
                if (tip == false)
                    okunus += " TL ";
                else
                    okunus += " YTL ";
            }

            if (tip == true)
            {
                if (Convert.ToDouble(ondalik) >= 10)
                {
                    okunus += SayiOku10(ondalik[0]);
                    YKRvar = true;
                }
                ondalik = ondalik.Remove(0, 1);

                if (Convert.ToDouble(ondalik) >= 1)
                {
                    okunus += SayiOku(ondalik[0]);
                    ondalik = ondalik.Remove(0, 1);
                    YKRvar = true;
                }

                if (YKRvar)
                    okunus += " YKR ";
            }

            if (tip == true)
            {
                if (!YKRvar && !YTLvar)
                    okunus += "SIFIR YTL";
            }
            else
            {
                if (!YKRvar && !YTLvar)
                    okunus += "SIFIR TL";
            }

            return okunus;
        }

        public bool FaturaIptal(string faturano)
        {
            dat.TInsert("BEGIN TRANSACTION TR");
            string depokodu = dat.TSelectScalar("SELECT DISTINCT DepoKodu From DepoMevcut (NOLOCK)");


            sql = "SELECT StokKodu,Birim,Miktar From FaturaDetay Where FaturaNo='";
            sql += faturano;
            sql += "'";

            DataTable dt = new DataTable();
            dat.TableDoldur(sql, ref dt);

            string depomiktar;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (FaturaTipi == "F" || FaturaTipi == "IF")
                {
                    sql = @"SELECT DepoMevcut.Miktar
							FROM         StokTanimlariUst INNER JOIN
							DepoMevcut ON StokTanimlariUst.StokKodu = DepoMevcut.StokKodu
							WHERE  StokTanimlariUst.StokKodu='";
                    sql += dt.Rows[i]["StokKodu"].ToString();
                    sql += "'";
                }

                depomiktar = dat.TSelectScalar(sql);
                if (depomiktar == null || depomiktar == "")
                    depomiktar = "0";


                sql = "UPDATE DepoMevcut Set Miktar='";
                sql += Convert.ToString(Convert.ToDouble(depomiktar, cfi) + Convert.ToDouble(dt.Rows[i]["Miktar"].ToString(), cfi), cfi);
                sql += "' WHERE StokKodu='";
                sql += dt.Rows[i]["StokKodu"].ToString();
                sql += "'";

                if (dat.TInsert(sql) == false)
                {
                    sql = "INSERT INTO DepoMevcut(DepoKodu,StokKodu,Miktar) VALUES('";
                    sql += depokodu + "','";
                    sql += dt.Rows[i]["StokKodu"].ToString() + "','";
                    sql += dt.Rows[i]["Miktar"].ToString() + "')";

                    dat.TInsert(sql);
                }

            }

            sql = "DELETE FROM FaturaDetay WHERE FaturaNo='";
            sql += faturano;
            sql += "'";

            if (dat.TInsert(sql) == false)
            {
                MessageBox.Show("Insert Hatasi.Fatura iptal Edilemedi");
                dat.TInsert("ROLLBACK TRANSACTION TR");
                return false;
            }

            sql = "DELETE FROM FaturaUst WHERE FaturaNo='";
            sql += faturano;
            sql += "'";

            if (dat.TInsert(sql) == false)
            {
                MessageBox.Show("Insert Hatasi.Fatura iptal Edilemedi");
                dat.TInsert("ROLLBACK TRANSACTION TR");
                return false;
            }

            dat.TInsert("COMMIT TRANSACTION TR");
            return true;
        }

        public bool IadeIptal(string faturano)
        {
            dat.TInsert("BEGIN TRANSACTION TR");
            string depokodu = dat.TSelectScalar("SELECT DISTINCT DepoKodu From DepoMevcut (NOLOCK)");


            sql = "SELECT StokKodu,Birim,Miktar From IadeDetay Where IadeFaturaNo='";
            sql += faturano;
            sql += "'";

            DataTable dt = new DataTable();
            dat.TableDoldur(sql, ref dt);

            string depomiktar;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (FaturaTipi == "F" || FaturaTipi == "IF")
                {
                    sql = @"SELECT DepoMevcut.Miktar
							FROM         StokTanimlariUst INNER JOIN
							DepoMevcut ON StokTanimlariUst.StokKodu = DepoMevcut.StokKodu
							WHERE  StokTanimlariUst.StokKodu='";
                    sql += dt.Rows[i]["StokKodu"].ToString();
                    sql += "'";
                }

                depomiktar = dat.TSelectScalar(sql);
                if (depomiktar == null || depomiktar == "")
                    depomiktar = "0";


                sql = "UPDATE DepoMevcut Set Miktar='";
                sql += Convert.ToString(Convert.ToDouble(depomiktar, cfi) - Convert.ToDouble(dt.Rows[i]["Miktar"].ToString(), cfi), cfi);
                sql += "' WHERE StokKodu='";
                sql += dt.Rows[i]["StokKodu"].ToString();
                sql += "'";

                if (dat.TInsert(sql) == false)
                {
                    sql = "INSERT INTO DepoMevcut(DepoKodu,StokKodu,Miktar) VALUES('";
                    sql += depokodu + "','";
                    sql += dt.Rows[i]["StokKodu"].ToString() + "','-";
                    sql += dt.Rows[i]["Miktar"].ToString() + "')";

                    dat.TInsert(sql);
                }

            }

            sql = "DELETE FROM IadeDetay WHERE IadeFaturaNo='";
            sql += faturano;
            sql += "'";

            if (dat.TInsert(sql) == false)
            {
                MessageBox.Show("Insert Hatasi.Iade iptal Edilemedi");
                dat.TInsert("ROLLBACK TRANSACTION TR");
                return false;
            }

            sql = "DELETE FROM IadeUst WHERE IadeFaturaNo='";
            sql += faturano;
            sql += "'";

            if (dat.TInsert(sql) == false)
            {
                MessageBox.Show("Insert Hatasi.Iade iptal Edilemedi");
                dat.TInsert("ROLLBACK TRANSACTION TR");
                return false;
            }

            dat.TInsert("COMMIT TRANSACTION TR");
            return true;
        }
        public string YeniBarkodSeriNoAL(string prefix)
        {
            string serino, chars = "";

            sql = "SELECT MAX(SeriliBarkod) From serili_barkodlar (NOLOCK)";
            if (prefix.Length > 0)
            {
                sql += " WHERE SeriliBarkod >= N'";
                sql += prefix;
                sql += "'";
            }

            serino = dat.TSelectScalar(sql);

            if (serino == null || serino == "")
            {
                serino = "1";
            }
            else
                prefix = "";

            for (int i = 0; i < serino.Length; i++)
            {
                if (Char.IsDigit(serino[i]) == false)
                {
                    chars += serino[i];
                    serino = serino.Remove(i--, 1);
                }
                else
                    break;
            }

            serino = Convert.ToString(Convert.ToInt64(serino) + 1);
            return prefix + chars + serino.PadLeft(10 - prefix.Length, '0');

        }

        public string YeniBelgeNoAl(string bno)
        {
            string belgeno, chars = "";

            if (bno.Length == 0)
            {
                sql = "SELECT BelgeNo From stok_hareket_ust (NOLOCK) ORDER BY Tarih DESC,Saat DESC";
                belgeno = dat.TSelectScalar(sql);
            }
            else
                belgeno = bno;

            if (belgeno == null || belgeno == "")
            {
                belgeno = "1";
                return belgeno;
            }

            for (int i = 0; i < belgeno.Length; i++)
            {
                if (Char.IsDigit(belgeno[i]) == false)
                {
                    chars += belgeno[i];
                    belgeno = belgeno.Remove(i--, 1);
                }
                else
                    break;
            }

            belgeno = Convert.ToString(Convert.ToInt64(belgeno) + 1);
            return chars + belgeno;
        }

        public bool SayimAcik()
        {
            try
            {
                sql = "select count(*) as vars from tanimlamalar (nolock) where TanimID = 'Sayim' and TanimValue = 'E'";
                return (dat.TCount(sql) > 0);
            }
            catch (Exception exc)
            {
                Hata("Sayim Sorgulanirken Hata :" + exc.Message); return false;
            }
        }

        public bool DataTabledeAra(ref DataTable dt, string KolonAdi, string Str)
        {
            bool don = false;

            try
            {
                foreach (DataRow r in dt.Rows)
                {
                    if (r[KolonAdi].ToString().Trim() == Str.Trim())
                    {
                        don = true;
                        break;
                    }
                }

            }
            catch { don = false; }

            return don;
        }

        public void KullaniciyaGoreModulAc(Form frm)
        {
            string s =
           @"select ModulAdi  from   Modul_Yetki  (NOLOCK) where KullaniciID=N'" + KullaniciID + "'";

            DataTable dt = new DataTable();

            dat.TableDoldur(s, ref dt);

            if (dt.Rows.Count < 1) return;

            foreach (Control c in frm.Controls)
            {
                if (c.GetType().ToString() == "System.Windows.Forms.Button")
                {
                    Button b = (Button)c;

                    b.Visible = DataTabledeAra(ref dt, "ModulAdi", b.Text);
                }
                //else if (c.GetType().ToString() == "AmbarPPC.ImageButton")
                //{
                //    ImageButton img = (ImageButton)c;

                //    img.Enabled = DataTabledeAra(ref dt, "ModulAdi", img.Text);
                //}
            }
        }

        public void DatatableedenEkle(ref DataTable dt, ref ListView list, string Unik, string GirenDEpo)
        {
            if (dt.Rows.Count < 1) return;

            if (dt.Columns.Count < 2) return;

            for (int j = 0; j < list.Items.Count; j++)
            {
                if (dt.Rows[0][Unik].ToString().Trim() == list.Items[j].SubItems[0].Text.Trim())
                    return;
            }

            ListViewItem row = new ListViewItem();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                row.Text = dt.Rows[i]["PaletID"].ToString();
                row.SubItems.Add(dt.Rows[i]["DepoKodu"].ToString());
                list.Items.Add(row);
                sql = @"EXEC dbo.PaletSevk N'" + dt.Rows[i]["PaletID"].ToString() + "',N'" + GirenDEpo + "',N'" + KullaniciKod + "',N'" + CihazID + "'";

                if (!dat.TInsert(sql))
                    MessageBox.Show(
                        dt.Rows[i]["PaletID"].ToString() +
                        "  Nolu Paletin Transferi Sirasinda Bir Hata Oluştu işlem Gerçekleşememiş Olabilir"
                        , "Dikkat");
            }
        }

        public static bool Connect = false;

        public int sayList(ListView list, int kolonno)
        {
            int don = 0;
            string ss = "";

            for (int i = 0; i < list.Items.Count; i++)
            {
                ss = list.Items[i].SubItems[kolonno].Text.Trim().PadLeft(1, '0');

                try { don += int.Parse(ss); }
                catch { }
            }


            return don;
        }

        public void yaz(string path, string str)
        {
            try
            {
                System.IO.StreamWriter sw = new StreamWriter(@"\" + path + "", true);

                sw.WriteLine(str.Trim()); sw.Flush();

                sw.Close(); sw = null;
            }
            catch (System.IO.IOException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }

        public string alantemizle(string str, TextBox t)
        {
            t.Text = "";

            str = str.Trim();

            str = str.Replace("\r", "").Replace("\n", "")
                .Replace("\r\n", "").Replace("\n\r", "")
                .Replace("%", "").Replace("'", "").Replace(",", "");


            t.Text = str;

            return str;
        }

        public string alantemizleY(TextBox t)
        {
            string str = "";
            str = t.Text;
            t.Text = "";

            str = str.Replace("\r", "").Replace("\n", "")
                .Replace("\r\n", "").Replace("\n\r", "")
                .Replace("%", "").Replace("'", "").Replace(",", "").Replace(" ", "");


            t.Text = str;

            return str;
        }

        public string alantemizleSql(TextBox t)
        {
            string str = "";
            str = t.Text;
            t.Text = "";

            str = str.
                Replace("%", "").
                Replace("'", "").
                Replace(",", "").
                Replace(".", "").
                Replace("\\r", "").
                Replace("\\n", "").
                Replace("\r", "").
                Replace("\n", "").
                Replace(" ", "");


            t.Text = str;

            return str;
        }

        public void alantemizle(TextBox t)
        {

            string str = "";
            str = t.Text;

            t.Text = "";

            str = str.Replace("\r", "").Replace("\n", "")
                .Replace("\r\n", "").Replace("\n\r", "")
                .Replace("%", "").Replace("'", "").Replace(",", "");


            t.Text = str.Trim();
        }

    }
}