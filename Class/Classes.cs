using System;
using System.Data;
using AmbarPPC;

namespace AmbarPC
{
	/// <summary>
	/// Summary description for Classes.
	/// </summary>
	
	public class Fis
	{
		public int BelgeNo=-1;
		public string CikanDepo="";
		public string GirenDepo="";
		public string KullaniciID="";
		public string Tarih;
		public string Saat="";
		public string Aciklama1="";
		public string Aciklama2="";
		public string HareketTipi="";
		public string CariKod="";
		public string IrsaliyeNo="";
		public string IrsaliyeTarih="";
		public string HareketKodu="";
      public string PaletID = "";
		public DataTable detaylar;
		public bool  SiparisIliski = false;
		public string HareketOzel = "";

		public string HataMesaji;

		public Fis()
		{
			Tarih=DateTime.Now.ToString("yyyy-MM-dd");
			Saat=DateTime.Now.ToString("HH:mm:ss");
			detaylar=new DataTable();

			detaylar.Columns.Add("StokKodu");
			detaylar.Columns.Add("Birim");
			detaylar.Columns.Add("Miktar");
			detaylar.Columns.Add("SeriliBarkod");
			detaylar.Columns.Add("GirenDepo");
			detaylar.Columns.Add("CikanDepo");
			detaylar.Columns.Add("Durum");

			HataMesaji="";
		}

		public bool FisKaydet()
		{
			#region KONTROLLER

			if(detaylar.Rows.Count < 1)
			{
				HataMesaji = "Boş Bir Belge Kaydedilemez";
				return false;
			}

			if(IrsaliyeNo.Length>0)
			{
				if(HareketTipi.Length<0)
				{
					HataMesaji="irsaliye Hareketi Yapiyorsaniz Hareket Tipi Girmelisiniz";
					return false;
				}
				if(CariKod.Length<1)
				{
					HataMesaji="irsaliye Hareketi Yapiyorsaniz Cari Kod Seçmelisiniz";
					return false;
				}
			}

			#region CIKAN DEPO KONTROLU
			if(CikanDepo.Length>0)
			{
                Utility.Engine.sql = "SELECT COUNT(*) FROM depo_tanim (NOLOCK) WHERE DepoKodu= N'";
				Utility.Engine.sql+=Utility.Engine.SqlTemizle(CikanDepo);
				Utility.Engine.sql+="'";

				if(Utility.Engine.dat.TCount(Utility.Engine.sql)<1)
				{
					HataMesaji="Çikan Depo Sistemde Tanimli Deðil";
					return false;
				}
			}

			#endregion
			#region GiREN DEPO KONTROLU
			if(GirenDepo.Length>0)
			{
                Utility.Engine.sql = "SELECT COUNT(*) FROM depo_tanim (NOLOCK) WHERE DepoKodu= N'";
				Utility.Engine.sql+=Utility.Engine.SqlTemizle(GirenDepo);
				Utility.Engine.sql+="'";

				if(Utility.Engine.dat.TCount(Utility.Engine.sql)<1)
				{
					HataMesaji="Giren Depo Sistemde Tanimli Deðil";
					return false;
				}
			}
			else
			{
				HataMesaji="Giren Depo Boş Geçilemez";
				return false;
			}
			#endregion
			#endregion

			if(BelgeNo==-1)
				return Yeni();
			else
				return Duzenle();
		}

		private bool Yeni2()
		{
			//Utility.Engine.dat.BeginTransaction();
			#region insert stok_hareket_ust 

			Utility.Engine.sql = 
				string.Format(@"INSERT INTO stok_hareket_ust
                      (KullaniciID, Tarih, Saat, Aciklama1, Aciklama2, HareketTipi, CariKod, IrsaliyeNo, IrsaliyeTarih, HareketKodu)
VALUES     (N'{0}',GETDATE(),'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}','{7}',N'{8}') SELECT @@IDENTITY AS YENIBELGE",
				Utility.Engine.KullaniciID,
				Saat,
				Utility.Engine.SqlTemizle(Aciklama1),
				Utility.Engine.SqlTemizle(Aciklama2),
				HareketTipi,
				Utility.Engine.SqlTemizle(CariKod),
				IrsaliyeNo,
				IrsaliyeTarih,
				HareketKodu);

			string belgeno = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);

			try
			{
				int b = Convert.ToInt32(belgeno.Trim());
			}
			catch(Exception ex)
			{
				HataMesaji = "Ust Bilgiler Yazilamadi\nYeni BelgeNo Alinamadi!!";
				return false;
			}

			#endregion


			#region insert stok_hareket_detay 
			for(int i=0;i<detaylar.Rows.Count;i++)
			{
				#region siparis
				string master = "", detay = "";
				
				if (SiparisIliski)
				{
                    Utility.Engine.sql = "SELECT TOP 1 MasterNo, DetayNo FROM  siparisler (NOLOCK) ";
					Utility.Engine.sql += " WHERE     (SiparisNo = '";
					Utility.Engine.sql += IrsaliyeNo;
					Utility.Engine.sql += "') AND (StokKodu = N'";
					Utility.Engine.sql += detaylar.Rows[i]["StokKodu"].ToString();
					Utility.Engine.sql += "') ";

					IDataReader dor = Utility.Engine.dat.TSelect(Utility.Engine.sql);

					if (dor != null)
					{
						if (dor.Read())
						{
							if (!dor.IsDBNull(0))
							{
								master = dor.GetValue(0).ToString();
							}
							if (!dor.IsDBNull(1))
							{
								detay = dor.GetValue(1).ToString();
							}
						}
						if (dor != null) dor.Close();
					}
					if (dor != null) dor.Close();
				}
				#endregion

				Utility.Engine.sql="INSERT INTO stok_hareket_detay(BelgeNo,StokKodu,Birim,Miktar,SeriliBarkod,GirenDepo,CikanDepo,MasterNo,DetayNo) VALUES('";
				Utility.Engine.sql+=belgeno + "','";
				Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString() + "','";
				Utility.Engine.sql+=detaylar.Rows[i]["Birim"].ToString() + "','";
				Utility.Engine.sql+=detaylar.Rows[i]["Miktar"].ToString() + "','";
				Utility.Engine.sql+=detaylar.Rows[i]["SeriliBarkod"].ToString() + "','";
				Utility.Engine.sql += detaylar.Rows[i]["GirenDepo"].ToString() + "','";
				Utility.Engine.sql += detaylar.Rows[i]["CikanDepo"].ToString() + "','";
				Utility.Engine.sql += master + "','" + detay + "')";

				if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
				{
					HataMesaji=Utility.Engine.dat.STR_HataMesaji + Utility.Engine.sql;
					Utility.Engine.dat.RollbackTransaction();
					return false;
				}

				if(HareketTipi=="Serili Stok Transferi")
				{
					#region DEPO MEVCUT DEGISTIR SERILI
                    if (Utility.Engine.dat.TCount("SELECT COUNT(*) FROM depo_mevcut (NOLOCK) WHERE SeriliBarkod= N'" + detaylar.Rows[i]["SeriliBarkod"].ToString() + "'") < 1)
					{
						Utility.Engine.sql="INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod,IslemTarihi) VALUES('";
						Utility.Engine.sql+=detaylar.Rows[i]["GirenDepo"].ToString() + "','";
						Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString() + "','"; 
						Utility.Engine.sql+=detaylar.Rows[i]["Birim"].ToString() + "','";
						Utility.Engine.sql+=detaylar.Rows[i]["Miktar"].ToString() + "','";
						Utility.Engine.sql+=detaylar.Rows[i]["SeriliBarkod"].ToString()+ "','";
						Utility.Engine.sql+=Tarih + "')";

						if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
						{
						}
					}
					else
					{
						Utility.Engine.sql="UPDATE depo_mevcut SET DepoKodu='";
						Utility.Engine.sql+=detaylar.Rows[i]["GirenDepo"].ToString();
						Utility.Engine.sql+="',IslemTarihi='";
						Utility.Engine.sql+=Tarih;
						Utility.Engine.sql+="' WHERE SeriliBarkod='";
						Utility.Engine.sql+=detaylar.Rows[i]["SeriliBarkod"].ToString();
						Utility.Engine.sql+="'";

						if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
						{
							HataMesaji=Utility.Engine.dat.STR_HataMesaji + Utility.Engine.sql;
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
					#endregion
				}
				
				else if(HareketTipi=="Serisiz Stok Transferi")
				{
					#region DEPO MEVCUT DEGISTIR SERISIZ

					#region KAYNAK DEPOYU DÜşÜR NORMAL

                    Utility.Engine.sql = "SELECT Miktar From depo_mevcut (NOLOCK) Where DepoKodu= N'";
					Utility.Engine.sql += detaylar.Rows[i]["CikanDepo"].ToString();
					Utility.Engine.sql+="' AND StokKodu='";
					Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
					Utility.Engine.sql+="'";

					System.Data.IDataReader rd=Utility.Engine.dat.TSelect(Utility.Engine.sql);

					if(rd.Read())
					{
						Utility.Engine.sql="UPDATE depo_mevcut SET Miktar=";
						Utility.Engine.sql+=(rd.GetDouble(0) - Convert.ToDouble(detaylar.Rows[i]["Miktar"].ToString(),Utility.Engine.nfi)).ToString(Utility.Engine.nfi);
						Utility.Engine.sql+=" WHERE DepoKodu='";
						Utility.Engine.sql += detaylar.Rows[i]["CikanDepo"].ToString();
						Utility.Engine.sql+="' AND StokKodu='";
						Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql+="'";
					
						rd.Close();
						if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
						{
							HataMesaji=Utility.Engine.dat.STR_HataMesaji + Utility.Engine.sql;
							rd.Close();
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
					else
					{
						Utility.Engine.sql="INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod) VALUES('";
						Utility.Engine.sql += detaylar.Rows[i]["CikanDepo"].ToString();
						Utility.Engine.sql+="','";
						Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql+="','";
						Utility.Engine.sql+=detaylar.Rows[i]["Birim"].ToString();
						Utility.Engine.sql+="',-";
						Utility.Engine.sql+=Convert.ToDouble(detaylar.Rows[i]["Miktar"].ToString(),Utility.Engine.nfi).ToString(Utility.Engine.nfi);
						Utility.Engine.sql+=",'')";
					
						rd.Close();
						if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
						{
							HataMesaji=Utility.Engine.dat.STR_HataMesaji + Utility.Engine.sql;
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
					#endregion

					#region HEDEF DEPOYU ARTTIR
                    Utility.Engine.sql = "SELECT Miktar From depo_mevcut (NOLOCK) Where DepoKodu= N'";
					Utility.Engine.sql += Utility.Engine.SqlTemizle(detaylar.Rows[i]["GirenDepo"].ToString());
					Utility.Engine.sql+="' AND StokKodu='";
					Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
					Utility.Engine.sql+="'";

					rd=Utility.Engine.dat.TSelect(Utility.Engine.sql);

					if(rd.Read())
					{
						Utility.Engine.sql="UPDATE depo_mevcut SET Miktar=";
						Utility.Engine.sql+=(rd.GetDouble(0) + Convert.ToDouble(detaylar.Rows[i]["Miktar"].ToString(),Utility.Engine.nfi)).ToString(Utility.Engine.nfi);
						Utility.Engine.sql+=" WHERE DepoKodu='";
						Utility.Engine.sql += Utility.Engine.SqlTemizle(detaylar.Rows[i]["GirenDepo"].ToString());
						Utility.Engine.sql+="' AND StokKodu='";
						Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql+="'";
					
						rd.Close();
						if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
						{
							HataMesaji=Utility.Engine.dat.STR_HataMesaji + Utility.Engine.sql;
							rd.Close();
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
					else
					{
						Utility.Engine.sql="INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod) VALUES('";
						Utility.Engine.sql += Utility.Engine.SqlTemizle(detaylar.Rows[i]["GirenDepo"].ToString());
						Utility.Engine.sql+="','";
						Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql+="','";
						Utility.Engine.sql+=detaylar.Rows[i]["Birim"].ToString();
						Utility.Engine.sql+="','";
						Utility.Engine.sql+=detaylar.Rows[i]["Miktar"].ToString();
						Utility.Engine.sql+="','')";
					
						rd.Close();
						if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
						{
							HataMesaji=Utility.Engine.dat.STR_HataMesaji + Utility.Engine.sql;
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
					#endregion
					
					#endregion
				}	
				else if(HareketTipi == "Serisiz Stok Sayim")
				{
					#region DEPO MEVCUT DEGISTIR SERISIZ

					#region KAYNAK DEPOYU DÜşÜR NORMAL

                    Utility.Engine.sql = "SELECT Miktar From depo_mevcut (NOLOCK) Where DepoKodu= N'";
					Utility.Engine.sql += detaylar.Rows[i]["CikanDepo"].ToString();
					Utility.Engine.sql+="' AND StokKodu='";
					Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
					Utility.Engine.sql+="'";

					System.Data.IDataReader rd=Utility.Engine.dat.TSelect(Utility.Engine.sql);

					if(rd.Read())
					{
						Utility.Engine.sql="UPDATE depo_mevcut SET Miktar=";
						Utility.Engine.sql+=(rd.GetDouble(0) - Convert.ToDouble(detaylar.Rows[i]["Miktar"].ToString(),Utility.Engine.nfi)).ToString(Utility.Engine.nfi);
						Utility.Engine.sql+=" WHERE DepoKodu='";
						Utility.Engine.sql += detaylar.Rows[i]["CikanDepo"].ToString();
						Utility.Engine.sql+="' AND StokKodu='";
						Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql+="'";
					
						rd.Close();
						if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
						{
							HataMesaji=Utility.Engine.dat.STR_HataMesaji + Utility.Engine.sql;
							rd.Close();
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
					else
					{
						Utility.Engine.sql="INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod) VALUES('";
						Utility.Engine.sql += detaylar.Rows[i]["CikanDepo"].ToString();
						Utility.Engine.sql+="','";
						Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql+="','";
						Utility.Engine.sql+=detaylar.Rows[i]["Birim"].ToString();
						Utility.Engine.sql+="',-";
						Utility.Engine.sql+=Convert.ToDouble(detaylar.Rows[i]["Miktar"].ToString(),Utility.Engine.nfi).ToString(Utility.Engine.nfi);
						Utility.Engine.sql+=",'')";
					
						rd.Close();
						if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
						{
							HataMesaji=Utility.Engine.dat.STR_HataMesaji + Utility.Engine.sql;
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
					#endregion

					#region HEDEF DEPOYU ARTTIR
					Utility.Engine.sql=" Miktar From depo_mevcut Where DepoKodu='";
					Utility.Engine.sql += Utility.Engine.SqlTemizle(detaylar.Rows[i]["GirenDepo"].ToString());
					Utility.Engine.sql+="' AND StokKodu='";
					Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
					Utility.Engine.sql+="'";

					rd=Utility.Engine.dat.TSelect(Utility.Engine.sql);

					if(rd.Read())
					{
						Utility.Engine.sql="UPDATE depo_mevcut SET Miktar=";
						Utility.Engine.sql+=(rd.GetDouble(0) + Convert.ToDouble(detaylar.Rows[i]["Miktar"].ToString(),Utility.Engine.nfi)).ToString(Utility.Engine.nfi);
						Utility.Engine.sql+=" WHERE DepoKodu='";
						Utility.Engine.sql += Utility.Engine.SqlTemizle(detaylar.Rows[i]["GirenDepo"].ToString());
						Utility.Engine.sql+="' AND StokKodu='";
						Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql+="'";
					
						rd.Close();
						if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
						{
							HataMesaji=Utility.Engine.dat.STR_HataMesaji + Utility.Engine.sql;
							rd.Close();
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
					else
					{
						Utility.Engine.sql="INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod) VALUES('";
						Utility.Engine.sql += Utility.Engine.SqlTemizle(detaylar.Rows[i]["GirenDepo"].ToString());
						Utility.Engine.sql+="','";
						Utility.Engine.sql+=detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql+="','";
						Utility.Engine.sql+=detaylar.Rows[i]["Birim"].ToString();
						Utility.Engine.sql+="','";
						Utility.Engine.sql+=detaylar.Rows[i]["Miktar"].ToString();
						Utility.Engine.sql+="','')";
					
						rd.Close();
						if(Utility.Engine.dat.TInsert(Utility.Engine.sql)==false)
						{
							HataMesaji=Utility.Engine.dat.STR_HataMesaji + Utility.Engine.sql;
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
					#endregion
					
					#endregion
				}
			}
			#endregion
			Utility.Engine.dat.CommitTransaction();
			
			BelgeNo=Convert.ToInt32(belgeno);

			return true;
		}

		private bool Duzenle()
		{
			return true;
		}

		public bool AmbarSayim()
		{
			return true;
		}

		private bool Yeni()
		{
			Utility.Engine.sql = string.Format("INSERT INTO stok_hareket_ust (KullaniciID, Tarih, Saat, Aciklama1, Aciklama2, HareketTipi, CariKod, IrsaliyeNo, IrsaliyeTarih, HareketKodu, CihazID,FLAG_C, FLAG_U ) VALUES     (N'{0}',GETDATE(),'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}','{7}',N'{8}',N'{9}','E','H') SELECT @@IDENTITY AS YENIBELGE", new object[] { Utility.Engine.KullaniciID, this.Saat, Utility.Engine.SqlTemizle(this.Aciklama1), Utility.Engine.SqlTemizle(this.Aciklama2), this.HareketTipi, Utility.Engine.SqlTemizle(this.CariKod), this.IrsaliyeNo, this.IrsaliyeTarih, (this.HareketOzel.Length > 0) ? this.HareketOzel : this.HareketKodu, Utility.Engine.CihazID });
			string str = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);
			try
			{
				int num = Convert.ToInt32(str.Trim());
			}
			catch (Exception)
			{
				this.HataMesaji = "Ust Bilgiler Yazilamadi\nYeni BelgeNo Alinamadi!!";
				return false;
			}
			for (int i = 0; i < this.detaylar.Rows.Count; i++)
			{
				string str2 = "";
				string str3 = "";
				if (this.SiparisIliski)
				{
                    Utility.Engine.sql = "SELECT TOP 1 MasterNo, DetayNo FROM  siparisler (NOLOCK)";
					Utility.Engine.sql = Utility.Engine.sql + " WHERE     (SiparisNo = '";
					Utility.Engine.sql = Utility.Engine.sql + this.IrsaliyeNo;
					Utility.Engine.sql = Utility.Engine.sql + "') AND (StokKodu = N'";
					Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
					Utility.Engine.sql = Utility.Engine.sql + "') ";
					IDataReader reader = Utility.Engine.dat.TSelect(Utility.Engine.sql);
					if (reader != null)
					{
						if (reader.Read())
						{
							if (!reader.IsDBNull(0))
							{
								str2 = reader.GetValue(0).ToString();
							}
							if (!reader.IsDBNull(1))
							{
								str3 = reader.GetValue(1).ToString();
							}
						}
						if (reader != null)
						{
							reader.Close();
						}
					}
					if (reader != null)
					{
						reader.Close();
					}
				}
            Utility.Engine.sql = "INSERT INTO stok_hareket_detay(BelgeNo,StokKodu,Birim,Miktar,SeriliBarkod,PaletID,GirenDepo,CikanDepo,MasterNo,DetayNo) VALUES('";
				Utility.Engine.sql +=  str + "',N'";
				Utility.Engine.sql +=  this.detaylar.Rows[i]["StokKodu"].ToString() + "',N'";
				Utility.Engine.sql +=  this.detaylar.Rows[i]["Birim"].ToString() + "','";
				Utility.Engine.sql +=  this.detaylar.Rows[i]["Miktar"].ToString() + "',N'";
				Utility.Engine.sql +=  this.detaylar.Rows[i]["SeriliBarkod"].ToString() + "','";
            Utility.Engine.sql += PaletID + "',N'";
				Utility.Engine.sql +=  this.detaylar.Rows[i]["GirenDepo"].ToString() + "',N'";
				Utility.Engine.sql +=  this.detaylar.Rows[i]["CikanDepo"].ToString() + "','";

				string sql = Utility.Engine.sql;
				Utility.Engine.sql = sql + str2 + "','" + str3 + "')";
				if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					this.HataMesaji = Utility.Engine.dat.STR_HataMesaji;
					Utility.Engine.dat.RollbackTransaction();
					return false;
				}
				if (this.HareketTipi == "Serili Stok Transferi")
				{
                    if (Utility.Engine.dat.TCount("SELECT COUNT(*) FROM depo_mevcut (NOLOCK) WHERE SeriliBarkod= N'" + this.detaylar.Rows[i]["SeriliBarkod"].ToString() + "'") < 1L)
					{
						Utility.Engine.sql = "INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod,IslemTarihi) VALUES(N'";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["GirenDepo"].ToString() + "',N'";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString() + "',N'";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["Birim"].ToString() + "','";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["Miktar"].ToString() + "',N'";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["SeriliBarkod"].ToString() + "','";
						Utility.Engine.sql = Utility.Engine.sql + this.Tarih + "')";

						if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
						{
						}
					}
					else
					{
						Utility.Engine.sql = "UPDATE depo_mevcut SET DepoKodu = N'";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["GirenDepo"].ToString();
						Utility.Engine.sql = Utility.Engine.sql + "',IslemTarihi='";
						Utility.Engine.sql = Utility.Engine.sql + this.Tarih;
						Utility.Engine.sql += "' WHERE SeriliBarkod = N'";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["SeriliBarkod"].ToString();
						Utility.Engine.sql = Utility.Engine.sql + "'";
						if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
						{
							this.HataMesaji = Utility.Engine.dat.STR_HataMesaji;
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
				}
				else
				{
					IDataReader reader2;
					if (this.HareketTipi == "Serisiz Stok Transferi")
					{
                        Utility.Engine.sql = "SELECT Miktar From depo_mevcut (NOLOCK) Where DepoKodu= N'";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["CikanDepo"].ToString();
						Utility.Engine.sql = Utility.Engine.sql + "' AND StokKodu='";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql += "' ";

						reader2 = Utility.Engine.dat.TSelect(Utility.Engine.sql);
						if (reader2.Read())
						{
							Utility.Engine.sql = "UPDATE depo_mevcut SET Miktar = Miktar - ";
							Utility.Engine.sql = Utility.Engine.sql + Convert.ToDouble(this.detaylar.Rows[i]["Miktar"].ToString(), Utility.Engine.nfi).ToString(Utility.Engine.nfi);
							Utility.Engine.sql += " WHERE DepoKodu='";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["CikanDepo"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "' AND StokKodu='";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
							Utility.Engine.sql += "'";

							reader2.Close();
							if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
							{
								this.HataMesaji = Utility.Engine.dat.STR_HataMesaji;
								reader2.Close();
								Utility.Engine.dat.RollbackTransaction();
								return false;
							}
						}
						else
						{
							Utility.Engine.sql = "INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod) VALUES('";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["CikanDepo"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "','";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "','";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["Birim"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "',-";
							Utility.Engine.sql = Utility.Engine.sql + Convert.ToDouble(this.detaylar.Rows[i]["Miktar"].ToString(), Utility.Engine.nfi).ToString(Utility.Engine.nfi);
							Utility.Engine.sql = Utility.Engine.sql + ",'')";

							reader2.Close();
							if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
							{
								this.HataMesaji = Utility.Engine.dat.STR_HataMesaji;
								Utility.Engine.dat.RollbackTransaction();
								return false;
							}
						}
                        Utility.Engine.sql = "SELECT Miktar From depo_mevcut (NOLOCK) Where DepoKodu= N'";
						Utility.Engine.sql = Utility.Engine.sql + Utility.Engine.SqlTemizle(this.detaylar.Rows[i]["GirenDepo"].ToString());
						Utility.Engine.sql = Utility.Engine.sql + "' AND StokKodu='";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql += "'";
						reader2 = Utility.Engine.dat.TSelect(Utility.Engine.sql);
						if (reader2.Read())
						{
							Utility.Engine.sql = "UPDATE depo_mevcut SET Miktar = Miktar + ";
							Utility.Engine.sql = Utility.Engine.sql + Convert.ToDouble(this.detaylar.Rows[i]["Miktar"].ToString(), Utility.Engine.nfi).ToString(Utility.Engine.nfi);
							Utility.Engine.sql = Utility.Engine.sql + " WHERE DepoKodu='";
							Utility.Engine.sql = Utility.Engine.sql + Utility.Engine.SqlTemizle(this.detaylar.Rows[i]["GirenDepo"].ToString());
							Utility.Engine.sql = Utility.Engine.sql + "' AND StokKodu='";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
							Utility.Engine.sql += "'";
							reader2.Close();
							if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
							{
								this.HataMesaji = Utility.Engine.dat.STR_HataMesaji;
								reader2.Close();
								Utility.Engine.dat.RollbackTransaction();
								return false;
							}
						}
						else
						{
							Utility.Engine.sql = "INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod) VALUES('";
							Utility.Engine.sql = Utility.Engine.sql + Utility.Engine.SqlTemizle(this.detaylar.Rows[i]["GirenDepo"].ToString());
							Utility.Engine.sql = Utility.Engine.sql + "','";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "','";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["Birim"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "','";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["Miktar"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "','')";
							reader2.Close();
							if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
							{
								this.HataMesaji = Utility.Engine.dat.STR_HataMesaji;
								Utility.Engine.dat.RollbackTransaction();
								return false;
							}
						}
					}
					else if (this.HareketTipi == "Serisiz Stok Sayim")
					{
                        Utility.Engine.sql = "SELECT Miktar From depo_mevcut (NOLOCK) Where DepoKodu= N'";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["CikanDepo"].ToString();
						Utility.Engine.sql = Utility.Engine.sql + "' AND StokKodu='";
						Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
						Utility.Engine.sql += "' ";
						reader2 = Utility.Engine.dat.TSelect(Utility.Engine.sql);
						if (reader2.Read())
						{
							Utility.Engine.sql = "UPDATE depo_mevcut SET Miktar=";
							Utility.Engine.sql = Utility.Engine.sql + ((reader2.GetDouble(0) - Convert.ToDouble(this.detaylar.Rows[i]["Miktar"].ToString(), Utility.Engine.nfi))).ToString(Utility.Engine.nfi);
							Utility.Engine.sql = Utility.Engine.sql + " WHERE DepoKodu='";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["CikanDepo"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "' AND StokKodu='";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
							Utility.Engine.sql += "'";
							reader2.Close();
							if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
							{
								this.HataMesaji = Utility.Engine.dat.STR_HataMesaji;
								reader2.Close();
								Utility.Engine.dat.RollbackTransaction();
								return false;
							}
						}
						else
						{
							Utility.Engine.sql = "INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod) VALUES('";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["CikanDepo"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "','";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "','";
							Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["Birim"].ToString();
							Utility.Engine.sql = Utility.Engine.sql + "',-";
							Utility.Engine.sql = Utility.Engine.sql + Convert.ToDouble(this.detaylar.Rows[i]["Miktar"].ToString(), Utility.Engine.nfi).ToString(Utility.Engine.nfi);
							Utility.Engine.sql = Utility.Engine.sql + ",'')";
							reader2.Close();
							if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
							{
								this.HataMesaji = Utility.Engine.dat.STR_HataMesaji;
								Utility.Engine.dat.RollbackTransaction();
								return false;
							}
						}

						//Utility.Engine.sql = string.Format("DELETE FROM depo_mevcut WHERE DepoKodu = '{0}' AND StokKodu = '{1}' ", Utility.Engine.SqlTemizle(this.detaylar.Rows[i]["GirenDepo"].ToString()), this.detaylar.Rows[i]["StokKodu"].ToString());
                        //Utility.Engine.sql = Utility.Engine.sql + " ; INSERT INTO depo_mevcut(DepoKodu,StokKodu,Birim,Miktar,SeriliBarkod) VALUES('";
                        //Utility.Engine.sql = Utility.Engine.sql + Utility.Engine.SqlTemizle(this.detaylar.Rows[i]["GirenDepo"].ToString());
                        //Utility.Engine.sql = Utility.Engine.sql + "','";
                        //Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["StokKodu"].ToString();
                        //Utility.Engine.sql = Utility.Engine.sql + "','";
                        //Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["Birim"].ToString();
                        //Utility.Engine.sql = Utility.Engine.sql + "','";
                        //Utility.Engine.sql = Utility.Engine.sql + this.detaylar.Rows[i]["Miktar"].ToString();
                        //Utility.Engine.sql = Utility.Engine.sql + "','')";
						
                        reader2.Close();
						if (!Utility.Engine.dat.TInsert(Utility.Engine.sql))
						{
							this.HataMesaji = Utility.Engine.dat.STR_HataMesaji;
							Utility.Engine.dat.RollbackTransaction();
							return false;
						}
					}
				}
			}
			Utility.Engine.dat.CommitTransaction();
			this.BelgeNo = Convert.ToInt32(str);
			return true;
		}


		public bool PaletTransfer(string palet,string cdepo,string gdepo)
		{
			try	
			{
				HareketTipi = "Serili Stok Transferi";
				HareketKodu = "TRANSFER";
				Aciklama1 = "Palet Transferi " + gdepo;
				Aciklama2 = palet + " " + gdepo;

				Utility.Engine.sql = " if (select count(*) from palet_tanim (nolock) where PaletID = ";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += " ) < 1 begin select 'HATALI PALET <palet tanimsiz>' return end else begin ";
				Utility.Engine.sql += " update palet_tanim set DepoKodu = '";
				Utility.Engine.sql += gdepo;
				Utility.Engine.sql += "' where PaletID = ";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += " ; update depo_mevcut set DepoKodu = '";
				Utility.Engine.sql += gdepo;
				Utility.Engine.sql += "' where SeriliBarkod in ";
				Utility.Engine.sql += "(select SeriliBarkod from serili_barkodlar (nolock) where PaletID = ";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += " ) end ";
 
				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit Hatasi:" + Utility.Engine.dat.STR_HataMesaji);
					return false;
				}
	

				Utility.Engine.sql = string.Format("INSERT INTO stok_hareket_ust (KullaniciID, Tarih, Saat, Aciklama1, Aciklama2, HareketTipi, CariKod, IrsaliyeNo, IrsaliyeTarih, HareketKodu, CihazID, FLAG_C, FLAG_U ) VALUES     (N'{0}',GETDATE(),'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}','{7}',N'{8}',N'{9}','E','H') SELECT @@IDENTITY AS YENIBELGE", 
					new object[] { Utility.Engine.KullaniciID, this.Saat, Utility.Engine.SqlTemizle(this.Aciklama1), Utility.Engine.SqlTemizle(this.Aciklama2), this.HareketTipi, Utility.Engine.SqlTemizle(this.CariKod), this.IrsaliyeNo, this.IrsaliyeTarih, (this.HareketOzel.Length > 0) ? this.HareketOzel : this.HareketKodu, Utility.Engine.CihazID });
				string str = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);
				int num = 0;
				try
				{
					num = Convert.ToInt32(str.Trim());
				}
				catch (Exception)
				{
					this.HataMesaji = "Ust Bilgiler Yazilamadi\nYeni BelgeNo Alinamadi!!";
					return false;
				}

				Utility.Engine.sql = "insert into stok_hareket_detay select ";
				Utility.Engine.sql += num.ToString();
				Utility.Engine.sql += " as BelgeNo,StokKodu,Birim,Miktar,SeriliBarkod,'";
				Utility.Engine.sql += cdepo;
				Utility.Engine.sql += "' AS  GirenDepo, '";
				Utility.Engine.sql += gdepo;
				Utility.Engine.sql += "' as CikanDepo,0 as MasterNo,0 as DetayNo,0 as SMasterNo , 0 as SDetayNo,'*' as Durum ";
				Utility.Engine.sql += " from serili_barkodlar (nolock) where PaletID = ";
				Utility.Engine.sql += palet;

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit hatasi:" + Utility.Engine.dat.STR_HataMesaji);
					return false;
				}

				return true;

			}
			catch(Exception exc)
			{
				HataMesaji = exc.Message;
				return false;
			}
		}


		public bool MalKabul(string palet,string depo)
		{
			try
			{
				Utility.Engine.sql = string.Format("INSERT INTO stok_hareket_ust (KullaniciID, Tarih, Saat, Aciklama1, Aciklama2, HareketTipi, CariKod, IrsaliyeNo, IrsaliyeTarih, HareketKodu, CihazID, FLAG_C, FLAG_U ) VALUES     (N'{0}',GETDATE(),'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}','{7}',N'{8}',N'{9}','E','H') SELECT @@IDENTITY AS YENIBELGE", 
					new object[] { Utility.Engine.KullaniciID, this.Saat, Utility.Engine.SqlTemizle(this.Aciklama1), Utility.Engine.SqlTemizle(this.Aciklama2), this.HareketTipi, Utility.Engine.SqlTemizle(this.CariKod), this.IrsaliyeNo, this.IrsaliyeTarih, (this.HareketOzel.Length > 0) ? this.HareketOzel : this.HareketKodu, Utility.Engine.CihazID });
				string str = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);
				int num = 0;
				try
				{
					num = Convert.ToInt32(str.Trim());
				}
				catch (Exception)
				{
					this.HataMesaji = "Ust Bilgiler Yazilamadi\nYeni BelgeNo Alinamadi!!";
					return false;
				}

				Utility.Engine.sql = "insert into stok_hareket_detay select ";
				Utility.Engine.sql += num.ToString();
				Utility.Engine.sql += " as BelgeNo,StokKodu,Birim,Miktar,'";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += "' as SeriliBarkod,'" + depo + "' AS  GirenDepo, 'GIRIS-MONTAJ DEPO' as CikanDepo,0 as MasterNo,0 as DetayNo,0 as SMasterNo, 0 AS SDetayNo'*' as Durum ";
				Utility.Engine.sql += " from serili_barkodlar (nolock) where SeriliBarkod = '";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += "'";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit hatasi<Fis Detay>:" + Utility.Engine.dat.STR_HataMesaji);
					return false;
				}


				Utility.Engine.sql = "insert into depo_mevcut select '";
				Utility.Engine.sql += depo;
				Utility.Engine.sql += "' as DepoKod,StokKodu,Birim,Miktar,'";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += "' as SeriliBarkod,GETDATE() as IslemTarihi ";
				Utility.Engine.sql += " from serili_barkodlar (nolock) where SeriliBarkod = '";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += "'";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit hatasi<Fis Detay>:" + Utility.Engine.dat.STR_HataMesaji);
					return false;
				}

				BelgeNo = num;

				return true;
			}
			catch(Exception exc)
			{
				HataMesaji = exc.Message;
				return false;
			}
		}
 

		public bool UretimCikis(string palet)
		{
			try
			{
				Utility.Engine.sql = string.Format("INSERT INTO stok_hareket_ust (KullaniciID, Tarih, Saat, Aciklama1, Aciklama2, HareketTipi, CariKod, IrsaliyeNo, IrsaliyeTarih, HareketKodu, CihazID, FLAG_C, FLAG_U ) VALUES     (N'{0}',GETDATE(),'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}','{7}',N'{8}',N'{9}','E','H') SELECT @@IDENTITY AS YENIBELGE", 
					new object[] { Utility.Engine.KullaniciID, this.Saat, Utility.Engine.SqlTemizle(this.Aciklama1), Utility.Engine.SqlTemizle(this.Aciklama2), this.HareketTipi, Utility.Engine.SqlTemizle(this.CariKod), this.IrsaliyeNo, this.IrsaliyeTarih, (this.HareketOzel.Length > 0) ? this.HareketOzel : this.HareketKodu, Utility.Engine.CihazID });
				string str = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);
				
				try
				{
					BelgeNo = Convert.ToInt32(str.Trim());
				}
				catch (Exception)
				{
					this.HataMesaji = "Ust Bilgiler Yazilamadi\nYeni BelgeNo Alinamadi!!";
					return false;
				}

				Utility.Engine.sql = "insert into stok_hareket_detay select ";
				Utility.Engine.sql += BelgeNo.ToString();
				Utility.Engine.sql += " as BelgeNo,StokKodu,Birim,Miktar,SeriliBarkod,'";
				Utility.Engine.sql += GirenDepo;
				Utility.Engine.sql += "' AS  GirenDepo, '";
				Utility.Engine.sql += CikanDepo;
				Utility.Engine.sql += "' as CikanDepo,0 as MasterNo,0 as DetayNo,0 as SMasterNo,0 as SDetayNo,'*' as Durum ";
				Utility.Engine.sql += " from serili_barkodlar (nolock) where SeriliBarkod = '";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += "'";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit hatasi<Fis Detay>:" + Utility.Engine.dat.STR_HataMesaji);
					return false;
				}

				Utility.Engine.sql = "update depo_mevcut set DepoKodu = '";
				Utility.Engine.sql += GirenDepo;
				Utility.Engine.sql += "' WHERE ( SeriliBarkod = '";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += "') ";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit hatasi<Depo Mevcut>:" + Utility.Engine.dat.STR_HataMesaji);
					return false;
				}

				return true;
			}
			catch(Exception exc)
			{
				HataMesaji = exc.Message;
				return false;
			}
		}
 

		public bool MaulEtiket(string palet,string marka,string stok)
		{
			try
			{
				Utility.Engine.sql = string.Format("INSERT INTO stok_hareket_ust (KullaniciID, Tarih, Saat, Aciklama1, Aciklama2, HareketTipi, CariKod, IrsaliyeNo, IrsaliyeTarih, HareketKodu, CihazID, FLAG_C, FLAG_U ) VALUES     (N'{0}',GETDATE(),'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}','{7}',N'{8}',N'{9}','E','H') SELECT @@IDENTITY AS YENIBELGE", 
					new object[] { Utility.Engine.KullaniciID, this.Saat, Utility.Engine.SqlTemizle(this.Aciklama1), Utility.Engine.SqlTemizle(this.Aciklama2), this.HareketTipi, Utility.Engine.SqlTemizle(this.CariKod), this.IrsaliyeNo, this.IrsaliyeTarih, (this.HareketOzel.Length > 0) ? this.HareketOzel : this.HareketKodu, Utility.Engine.CihazID });
				string str = Utility.Engine.dat.TSelectScalar(Utility.Engine.sql);
				
				try
				{
					BelgeNo = Convert.ToInt32(str.Trim());
				}
				catch (Exception)
				{
					this.HataMesaji = "Ust Bilgiler Yazilamadi\nYeni BelgeNo Alinamadi!!";
					return false;
				}

				Utility.Engine.sql = "insert into stok_hareket_detay select ";
				Utility.Engine.sql += BelgeNo.ToString();
				Utility.Engine.sql += " as BelgeNo,'";
				Utility.Engine.sql += stok;
				Utility.Engine.sql += "' AS StokKodu,Birim,Miktar,SeriliBarkod,'";
				Utility.Engine.sql += GirenDepo;
				Utility.Engine.sql += "' AS  GirenDepo, '";
				Utility.Engine.sql += CikanDepo;
				Utility.Engine.sql += "' as CikanDepo,0 as MasterNo,0 as DetayNo,0 AS SMasterNo,0 AS SDetayNo,'*' as Durum ";
				Utility.Engine.sql += " from serili_barkodlar (nolock) where SeriliBarkod = '";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += "'";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit hatasi<Fis Detay>:" + Utility.Engine.dat.STR_HataMesaji);
					return false;
				}

				Utility.Engine.sql = "update depo_mevcut set DepoKodu = '";
				Utility.Engine.sql += GirenDepo;
				Utility.Engine.sql += "',StokKodu = '";
				Utility.Engine.sql += stok;
				Utility.Engine.sql += "' WHERE SeriliBarkod = '";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += "'";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit hatasi<Depo Mevcut>:" + Utility.Engine.dat.STR_HataMesaji);
					return false;
				}

				Utility.Engine.sql = "update serili_barkodlar set StokKodu = '";
				Utility.Engine.sql += stok;
				Utility.Engine.sql += "',OzelKod = '";
				Utility.Engine.sql += marka;
				Utility.Engine.sql += "',CariKodu = '";
				Utility.Engine.sql += CariKod;
				Utility.Engine.sql += "' WHERE SeriliBarkod = '";
				Utility.Engine.sql += palet;
				Utility.Engine.sql += "'";

				if(!Utility.Engine.dat.TInsert(Utility.Engine.sql))
				{
					Utility.Engine.Hata("Kayit hatasi<Depo Mevcut>:" + Utility.Engine.dat.STR_HataMesaji);
					return false;
				}

				return true;
			}
			catch(Exception exc)
			{
				HataMesaji = exc.Message;
				return false;
			}
		}
 

	}
}
