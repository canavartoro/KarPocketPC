using System;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace AmbarPPC
{
	/// <summary>
	/// Summary description for Database.
	/// </summary>
	public class Database
	{
      public string INDIR = "BACKUP";
		public string STR_HataMesaji;
		public string STR_ProgramDizini;
        public string Fault = "";      
		public SqlConnection conn;
		public SqlCommand comm;
		public SqlTransaction transaction;
        private string baglanti = "";

        public Database(string connectionstring)
        {
            STR_HataMesaji = "";

            try
            {
                //conn=new SqlConnection(@"packet size=4096;integrated security=SSPI;data source=192.168.0.111\SQLEXPRESS;persist security info=True;initial catalog=DP2007; User ID = sa;");
                baglanti = connectionstring;
                conn = new SqlConnection(connectionstring);
                conn.Open();
                Engine.Connect = true;
            }
            catch (SqlException ex)
            {
                Utility.WriteTrace("Sunucu Baglanma Hatasi..!" + ex.Message);
                MessageBox.Show(ex.Message + @"                 
              " + connectionstring, "Sunucu Baglanma Hatasi..!");
                return;
                //throw new Exception("Data");
            }

            if (conn == null || conn.State != ConnectionState.Open)
                throw new Exception("Data");

            comm = new SqlCommand();
            comm.Connection = conn;
        }

      public void ConClose()
      {
         if (conn.State == ConnectionState.Open)
            conn.Close();         
      }

      public void ConOpen()
      {
          try
          {
              Cursor.Current = Cursors.WaitCursor;
              conn = new System.Data.SqlClient.SqlConnection(baglanti);
              conn.Open();
              if (conn.State == ConnectionState.Closed)
              {
                  Fault = "Bağlantı Hatası(0)\nVerikaynağına bağlantı kurulamadı!";
                  return;
              }
              comm = new SqlCommand("");
              comm.Connection = conn;
              Engine.Connect = true;
          }
          catch (SqlException oe)
          {
              Fault = "Bağlantı Hatası(1)\nVerikaynağına bağlantı kurulamadı!\n" + oe.Message;
              return;
          }
          finally
          {
              Cursor.Current = Cursors.Default;
              CheckConnection();
          }

      }


		public void ListDoldurEkle(ref ListView list,string sql,string PaletID)
		{
			CheckConnection();
			System.Data.IDataReader rd=TSelect(sql);

            for (int j = 0; j < list.Items.Count; j++)
            {
                if (PaletID.Trim() == list.Items[0].ToString().Trim())
                    return;
            }

			//list.Items.Clear();
			int i;

			while(rd!=null && rd.Read())
			{
				ListViewItem row=new ListViewItem();

				if(rd.IsDBNull(0))
					row.Text="";
				else
					row.Text=rd.GetValue(0).ToString();

				for(i=1;i<rd.FieldCount;i++)
				{
					if(rd.IsDBNull(i))
						row.SubItems.Add("");
					else
						row.SubItems.Add(rd.GetValue(i).ToString());
				}
				list.Items.Add(row);
			}
			if(rd!=null)
				rd.Close();
            			
		}

        public void ListDoldur(ref ListView list, string sql)
        {
            CheckConnection();
            System.Data.IDataReader rd = TSelect(sql);

            list.Items.Clear();
            int i;

            while (rd != null && rd.Read())
            {
                ListViewItem row = new ListViewItem();

                if (rd.IsDBNull(0))
                    row.Text = "";
                else
                    row.Text = rd.GetValue(0).ToString();

                for (i = 1; i < rd.FieldCount; i++)
                {
                    if (rd.IsDBNull(i))
                        row.SubItems.Add("");
                    else
                        row.SubItems.Add(rd.GetValue(i).ToString());
                }
                list.Items.Add(row);
            }
            if (rd != null)
                rd.Close();

        }

        public void ListDoldur900(ref ListView list, string sql)
        {
            CheckConnection();
            System.Data.IDataReader rd = TSelect(sql);
                     
            int i;

            while (rd != null && rd.Read())
            {
                if (rd.GetValue(1).ToString().Trim() == "HATA")
                {
                    m mx = new m();
                    mx.tistex = "HATA!";
                    mx.label1.Text = rd.GetValue(0).ToString().Trim();
                    mx.ShowDialog();
                    break;
                }else
                    list.Items.Clear();

                ListViewItem row = new ListViewItem();

                if (rd.IsDBNull(0))
                    row.Text = "";
                else
                    row.Text = rd.GetValue(0).ToString();

                for (i = 1; i < rd.FieldCount; i++)
                {
                    if (rd.IsDBNull(i))
                        row.SubItems.Add("");
                    else
                        row.SubItems.Add(rd.GetValue(i).ToString());
                }
                list.Items.Add(row);
            }


            if (rd != null)
                rd.Close();

        }

        public void satirlarekle(DataTable dt, string sql)
        {

            CheckConnection();

            comm.CommandText = sql;

            SqlDataReader dr = null;

            try
            {
               dr = comm.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Fault = ex.Message;
                Utility.WriteTrace(ex.Message);
                MessageBox.Show(ex.Message);
                dr.Close(); dr = null;
                return;
            }

            if (dr == null)
            {
                MessageBox.Show(Fault);
                dr.Close(); dr = null;
                return;
            }

            while (dr.Read())
            {
                DataRow row = dt.NewRow();

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    row[i] = dr.GetValue(i).ToString();
                }

                dt.AcceptChanges();
            }

            dt.AcceptChanges();
            dr.Close(); dr = null;

        }



        public int satirlarekle1(DataTable dt, string sql)
        {
            CheckConnection();

            comm.CommandText = sql;

            SqlDataReader dr = null;

            try
            {
                dr = comm.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Utility.WriteTrace(ex.Message);
                Fault = ex.Message;
                MessageBox.Show(ex.Message);
                dr.Close(); dr = null;
                return 0;
            }

            if (dr == null)
            {
                MessageBox.Show(Fault);
                dr.Close(); dr = null;
                return 0;
            }
           
            while (dr.Read())
            {
                if (dr.GetValue(0).ToString().Trim() == "-1")
                {
                    MessageBox.Show(dr.GetString(1));
                    dr.Close(); dr = null;
                    return -1;
                }

                if (dr.GetValue(0).ToString().Trim() == "-2")
                {
                    
                    kasadakalan=   dr.GetValue(1).ToString();
                    serimiktari = dr.GetValue(2).ToString();

                    dr.Close(); dr = null;
                    return -2;
                }

                DataRow row = dt.NewRow();
                string sd = "";

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sd = dr.GetValue(i).ToString();
                    row[i] = sd;
                        
                }

                dt.Rows.Add(row);
                dt.AcceptChanges();
            }

            dt.AcceptChanges();
            dr.Close(); dr = null;

            return 1;
        }

        public string kasadakalan = "";
        public string serimiktari = "";   

        public void LDoldur(ref ListView list, string sql)
        {
            CheckConnection();
            list.Items.Clear();
            DataTable dtx = new DataTable();
            TableDoldur(sql, ref dtx);
            if (dtx != null && dtx.Rows.Count > 0)
            {
                if (dtx.Rows[0][1].ToString().ToLower().Equals("hata"))
                {
                    System.Windows.Forms.MessageBox.Show(dtx.Rows[0][0].ToString(), "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
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
                    list.Items.Add(row);
                }
            }

        }

        public void LDoldurx(ref ListView list, string sql,string str)
        {
            CheckConnection();
            list.Items.Clear();


            DataTable dtx = new DataTable();
            TableDoldur(sql, ref dtx);
            if (dtx != null && dtx.Rows.Count > 0)
            {
                if (dtx.Rows[0][1].ToString().ToLower().Equals("hata"))
                {
                    m  mx= new m();
                    mx.tistex="HATA!";
//                    mx.Location = new System.Drawing.Point(50, 120);
                    mx.label1.Text = dtx.Rows[0][0].ToString();
                    
                    if (mx.ShowDialog() != DialogResult.OK)
                        return;
                    

                    dtx.Clear();
                    dtx.Columns.Clear();
                    TableDoldur(@"EXEC dbo.PaletBulUretimYeni1 N'" + str + "'", ref dtx);                   
                }
                                    
                for (int i = 0; i < dtx.Rows.Count; i++)
                {
                    ListViewItem row = new ListViewItem();
                    row.Text = dtx.Rows[i][0].ToString();
                    for (int c = 1; c < dtx.Columns.Count; c++)
                    {
                        row.SubItems.Add(dtx.Rows[i][c].ToString());
                    }
                    list.Items.Add(row);
                }
            }

        }

		public bool GridDoldur(String sql,ref DataGrid grid)
		{
			CheckConnection();
			try
			{
				comm.CommandText = sql;
				DataTable dt=(DataTable)grid.DataSource;
				TableDoldur(sql,ref dt);
			}
			catch(Exception ex)
			{
                Utility.WriteTrace(ex.Message);
				STR_HataMesaji=ex.ToString();
				HataKaydet(sql+" | GridDoldur");
				return false;
			}
			return true;
		}

		public bool TableDoldur(String sql,ref DataTable dt)
		{
			CheckConnection();
         Fault = "";
			try
			{
                Utility.WriteTrace(sql);
				comm.CommandText = sql;
				SqlDataAdapter da=new SqlDataAdapter(comm);
				da.SelectCommand=comm;
				da.Fill(dt);
			}
			catch(SqlException ex)
			{
                Fault = ex.Message;
				STR_HataMesaji=ex.ToString();
				HataKaydet(sql + " <> " + STR_HataMesaji +" | TableDoldur");
				return false;
			}
			return true;
		}


      public bool TableDoldurbb(String sql, ref DataTable dt)
      {
         CheckConnection();
         Fault = "";
         dt.Clear();
         try
         {
             Utility.WriteTrace(sql);
            comm.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.SelectCommand = comm;
            da.Fill(dt);
         }
         catch (SqlException ex)
         {
            Fault = ex.Message;
            STR_HataMesaji = ex.ToString();
            HataKaydet(sql + " <> " + STR_HataMesaji + " | TableDoldur");
            return false;
         }
         return true;
      }

      public DataTable TableDon(String sql)
      {
         CheckConnection();

         DataTable dt = new DataTable();

         Fault = "";
         try
         {
             Utility.WriteTrace(sql);
             comm.CommandText = sql;
             SqlDataAdapter da = new SqlDataAdapter(comm);
             da.SelectCommand = comm;
             da.Fill(dt);             
         }
         catch (SqlException ex)
         {
             Fault = ex.Message;
             STR_HataMesaji = ex.Message;
             HataKaydet(sql + " <> " + STR_HataMesaji + " | TableDoldur");
         }
         catch (Exception ex1)
         {
             if (Fault.Trim() == "")
                 Fault = ex1.Message;
         }

         dt.AcceptChanges();
         return dt;
      }

        public DataSet DataSetDon(String sql)
        {
            CheckConnection();

            DataSet das = new DataSet();

            Fault = "";
            try
            {
                Utility.WriteTrace(sql);
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(das);
            }
            catch (SqlException ex)
            {
                Fault = ex.Message;
                STR_HataMesaji = ex.ToString();
                HataKaydet(sql + " <> " + STR_HataMesaji + " | TableDoldur");
            }
            catch (Exception ex1)
            {
                if (Fault.Trim() == "")
                    Fault = ex1.Message;
            }

            return das;
        }

		public bool GridDoldur(String sql,ref DataGrid grid,string tablename)
		{
			CheckConnection();
			try
			{
                Utility.WriteTrace(sql);
				comm.CommandText = sql;
				DataTable dt=new DataTable(tablename);
				TableDoldur(sql,ref dt);
				grid.DataSource=dt;
			}
			catch(Exception ex)
			{
				STR_HataMesaji=ex.ToString();
				HataKaydet(sql + " | GridDoldur2");
				return false;
			}
			return true;
		}


		public void ComboDoldur(String sql,ComboBox combo)
		{
			CheckConnection();
            Utility.WriteTrace(sql);
			comm.CommandText=sql;
			IDataReader rd=comm.ExecuteReader();
			
			combo.Items.Clear();
			while(rd!=null && rd.Read())
				combo.Items.Add(rd.GetValue(0));

			if(rd!=null)
				rd.Close();
		}

		public SqlDataReader TSelect(string sql)
		{
			CheckConnection();
			try
			{
                Utility.WriteTrace(sql);
				comm.CommandText=sql;
				return comm.ExecuteReader();
			}
			catch(Exception ex)
			{
				STR_HataMesaji=ex.Message;
				HataKaydet(sql + " | TSelect");
				return null;
			}
		}

        public string TSelectScalar(string sql)
        {
            string str;
            try
            {
                Utility.WriteTrace(sql);

                comm.CommandText = sql;
                DataTable dt = new DataTable();
                TableDoldur(sql, ref dt);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0].IsNull(0))
                        str = "";
                    else
                        str = dt.Rows[0][0].ToString();
                }
                else
                {
                    str = "";
                }
            }
            catch (Exception ex)
            {
                STR_HataMesaji = ex.Message;
                Utility.WriteTrace(ex.Message);
                return "";
            }
            return str;
        }

        public void SqlYaz(string file, string sql)
        {
            StreamWriter w = File.CreateText(@"\sqlyaz.txt");
            w.Write(sql + "||");
            w.Flush();
            w.Close();
            w = null;
        }

		public bool TInsert(string sql)
		{
			CheckConnection();
			int val;
			try
			{
                Utility.WriteTrace(sql);
				comm.CommandText=sql;
				val=comm.ExecuteNonQuery();
			}
			catch(SqlException ex)
			{
            Fault = ex.Message;
				STR_HataMesaji=ex.Message;
				HataKaydet(sql + " | TInsert");
				return false;
			}
			if(val>0)
				return true;
			else
				return false;
		}

		public long TCount(string sql)
		{
			CheckConnection();
            Fault = "";
			IDataReader rd;
			try
			{
                Utility.WriteTrace(sql);
				comm.CommandText=sql;
				rd=comm.ExecuteReader();
			}
			catch(Exception ex)
			{
                Fault = ex.Message;
				STR_HataMesaji=ex.Message;
				HataKaydet(sql + " | TCount");
				return -1;
			}

			if(rd!=null && rd.Read()==false)
			{
            STR_HataMesaji = "hat,sql:" + sql;
				HataKaydet(STR_HataMesaji);
				if(rd!=null)
					rd.Close();
				return -1;
			}

			long l;

			try
			{
				double d = Convert.ToDouble(rd.GetValue(0).ToString().Trim());
				l=Convert.ToInt64(d);
			}
			catch(Exception ex)
			{
				STR_HataMesaji=ex.Message;
				HataKaydet(STR_HataMesaji);
				if(rd!=null)
					rd.Close();
				return -1;
			}
			if(rd!=null)
				rd.Close();
			return l;
		}

		public void ComboDoldur(String sql,ref ComboBox combo)
		{
			CheckConnection();
            Utility.WriteTrace(sql);
			comm.CommandText=sql;
			IDataReader rd=comm.ExecuteReader();
			
			combo.Items.Clear();
			while(rd!=null && rd.Read())
				combo.Items.Add(rd.GetValue(0));

			if(rd!=null)
				rd.Close();
		}
		public TreeNode Contains(TreeNode oNode, string Value)
		{
			if (Value == oNode.Text)
				return oNode;

			if (oNode.Nodes.Count < 1)
				return null;

			for (int i = 0; i < oNode.Nodes.Count; i++)
			{
				if (Value == oNode.Nodes[i].FullPath)
					return oNode.Nodes[i];
				if (oNode.Nodes[i].Nodes.Count > 0)
				{
					TreeNode tn1 = Contains(oNode.Nodes[i], Value);

					if (tn1 != null)
						return tn1;
				}
			}

			return null;
		}
		public TreeNode FindInTree(ref TreeView oTree, string Value)
		{
			TreeNode oNode = null;

			if (oTree == null || oTree.Nodes == null)
				return oNode;
			for (int i = 0; i < oTree.Nodes.Count && oNode == null; i++)
			{
				if (oTree.Nodes[i].FullPath==Value)
					return oTree.Nodes[i];
				else
					if (oTree.Nodes[i].Nodes.Count > 0)
					oNode = (TreeNode)Contains(oTree.Nodes[i], Value);
			}
			return oNode;
		}
		public void TreeDoldur(ref TreeView tree, string sql)
		{
			while (conn.State == System.Data.ConnectionState.Broken || conn.State == System.Data.ConnectionState.Closed)
			{
				if (MessageBox.Show("Veri tabani baðlantisi kopuk!\nTekrar denemek istiyor musunuz?", "Baðlanti hatasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) != DialogResult.OK)
				{
					STR_HataMesaji = "Veri tabani baðlantisi kopuk!";
					return;
				}
			}

			string val;
			int index;

			tree.Nodes.Clear();
			System.Data.DataTable dt = new System.Data.DataTable("t1");
			dt.Columns.Add("Col1");
			dt.Columns.Add("Col2");

			comm.CommandText = sql;
			System.Data.IDataReader dr = comm.ExecuteReader();

			bool r;
			while ((r = dr.Read()))
			{
				if (dr.IsDBNull(0) || dr.GetValue(0).ToString() == "")
				{
					val = dr.GetValue(1).ToString();


					TreeNode tno = new TreeNode(val);
					tno.Text = val;

					if ((index = val.LastIndexOf('-')) > 0)
					{
						tno.Text = val.Substring(index + 1, val.Length - index - 1);
					}

					tno.ImageIndex = tno.SelectedImageIndex = GetNodeLevel(tno);
					tree.Nodes.Add(tno);
					continue;
				}


				TreeNode tn;
				if ((tn = FindInTree(ref tree, dr.GetValue(0).ToString())) != null)
				{
					val = dr.GetValue(1).ToString();


					TreeNode tno = new TreeNode(val);
					tno.Text = val;

					if ((index = val.LastIndexOf('-')) > 0)
					{
						tno.Text = val.Substring(index + 1, val.Length - index - 1);
					}			

					tno.ImageIndex = tno.SelectedImageIndex = GetNodeLevel(tno) + 1;
					tn.Nodes.Add(tno);
				}
				else
				{
					object[] rowVals = new object[2];
					rowVals[0] = dr.GetValue(0).ToString();
					rowVals[1] = dr.GetValue(1).ToString();
					dt.Rows.Add(rowVals);
				}

			}
			dr.Close();

			while (dt.Rows.Count > 0)
			{
				Random rn = new Random(DateTime.Now.Millisecond);
				int randnum = rn.Next(dt.Rows.Count);

				if (randnum == 1 && DateTime.Now.Millisecond > 500)
					randnum = 0;

				TreeNode tn;
				if ((tn = FindInTree(ref tree, dt.Rows[randnum][0].ToString())) != null)
				{
					val=dt.Rows[randnum][1].ToString();

                    
					TreeNode tno = new TreeNode(val);
					tno.Text = val;
                    
					if((index=val.LastIndexOf('-'))>0)
					{
						tno.Text=val.Substring(index + 1, val.Length - index - 1);
					}

					tno.ImageIndex = tno.SelectedImageIndex = GetNodeLevel(tno) + 1;
					tn.Nodes.Add(tno);
					dt.Rows[randnum].Delete();
				}
			}
		}
		public int GetNodeLevel(TreeNode tno)
		{
			TreeNode ttmp=tno;
			int jk=0;
			while(ttmp.Parent!=null)
			{
				ttmp=ttmp.Parent;
				jk++;
			}
			return jk;
		}
		public void BeginTransaction()
		{
            TInsert("begin transaction ben");
			//transaction=conn.BeginTransaction();
		}
		public void CommitTransaction()
		{
            TInsert("commit transaction ben");
			//transaction.Commit();
		}
		public void RollbackTransaction()
		{
            TInsert("rollback transaction ben");
			//transaction.Rollback();
		}
		public void CheckConnection()
		{
			if(conn.State==ConnectionState.Broken || conn.State==ConnectionState.Closed)
			{
				if(MessageBox.Show("Ana bilgisayar bağlantisi kesilmiş!\nTekrar bağlanti denensin mi?","Uyari",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1)!=DialogResult.OK)
					return;
                Thread t = new Thread(new ThreadStart(ConOpen));
                t.IsBackground = true;
                t.Start();
			}
		}
		public void HataKaydet(string hata)
		{
			try
			{
                StreamWriter sw = new StreamWriter(Utility.AppPath + @"\sql_hata.txt", true, Encoding.GetEncoding("windows-1254"));
				sw.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm") + " | " + hata+":::::");
				sw.Flush();
				sw.Close();
                sw = null;
			}
			catch(Exception)
			{				
			}
		}

        public void LDoldurxc(ref ListView list, string sql, string str)
        {
            CheckConnection();

            list.Items.Clear();

            DataTable dtx = new DataTable();
            TableDoldur(sql, ref dtx);

            if (dtx.Rows.Count < 1)
                return;

            if (dtx.Rows[0][1].ToString().Trim() == "HATA")
            {
                m mx = new m();
                mx.tistex = "HATA!";
                mx.label1.Text = dtx.Rows[0][0].ToString();             
                mx.ShowDialog();
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
                list.Items.Add(row);
            }
        }


        public void tabledenListDoldur(DataTable dt, ListView li)
        {            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem row = new ListViewItem();
                
                row.Text = dt.Rows[i][0].ToString();
                
                for (int c = 1; c < dt.Columns.Count; c++)
                {
                    row.SubItems.Add(dt.Rows[i][c].ToString());
                }

                li.Items.Add(row);
            }
        }

        public void tabledenListDoldur1(DataTable dt, ListView li)
        {
            li.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem row = new ListViewItem();

                row.Text = dt.Rows[i][0].ToString();

                for (int c = 1; c < dt.Columns.Count; c++)
                {
                    row.SubItems.Add(dt.Rows[i][c].ToString());
                }

                li.Items.Add(row);
            }
        }

        public void ListDoldur2(ref ListView list, string sql)
        {
            CheckConnection();

            SqlDataReader rd = null;

            try
            {
                rd = TSelect(sql);
                if (rd == null) return;

                list.BeginUpdate();
                list.Items.Clear();
                int i;
                

                while (rd != null && rd.Read())
                {
                    ListViewItem row = new ListViewItem();

                    if (rd.IsDBNull(0))
                        row.Text = "";
                    else
                        row.Text = rd.GetValue(0).ToString();

                    for (i = 1; i < rd.FieldCount; i++)
                    {
                        if (rd.IsDBNull(i))
                            row.SubItems.Add("");
                        else
                        {
                            row.SubItems.Add(rd.GetValue(i).ToString().Trim());
                        }
                    }
                    list.Items.Add(row);
                                   
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                Utility.WriteTrace(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (rd != null) rd.Close(); // :)
                list.EndUpdate();
            }
        }
	}
}
