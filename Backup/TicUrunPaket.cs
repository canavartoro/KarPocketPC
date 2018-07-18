using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
   public partial class TicUrunPaket : Form
   {
      public TicUrunPaket()
      {
         InitializeComponent();
         dt.TableName = "okunanlar";
         dt.Columns.Add("SeriliBarkod");
         dt.Columns.Add("StokKodu");
         dt.Columns.Add("StokAdi");
         dt.Columns.Add("Birim");
         dt.Columns.Add("Deposu");
         dt.AcceptChanges();
      }

      DataTable dt = new DataTable();
      string Palet = "";
      string Seri = "";

      private void TicUrunPaket_Load(object sender, EventArgs e)
      {
         textPalet.Focus();
         dataGrid1.DataSource = dt;         
      }

      private void button2_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void dataGrid1_Click(object sender, EventArgs e)
      {
         if (dataGrid1.VisibleRowCount > 0)
            dataGrid1.Select(dataGrid1.CurrentRowIndex);
      }

      private void textPalet_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == 13)
         {
            buttonPalet_Click(null, null);            
         }
      }

      private void buttonPalet_Click(object sender, EventArgs e)
      {
         Palet = textPalet.Text.Trim().ToUpper();
         Seri = textSeri.Text.Trim().ToUpper();

         if (Palet == "")
         {
            MessageBox.Show("Palet Serisi Okutun..!", "Dikkat..!");
            return;
         }

         Utility.Engine.sql = string.Format(@" 

DECLARE @DEPO NVARCHAR(30)

SELECT @DEPO = TanimValue 
FROM dbo.tanimlamalar (NOLOCK) WHERE (TanimID = N'ambalaj')

update  
palet_tanim
set
PaletMiktar=0,DepoKodu=@DEPO
where 
PaletID=N'{0}' and DepoKodu<>@DEPO

update  
depo_mevcut
set
PaletID=N'' 
where 
PaletID=N'{0}' and DepoKodu<>@DEPO



SELECT     serili_barkodlar.SeriliBarkod, serili_barkodlar.StokKodu, stok_tanim_ust.StokAdi, serili_barkodlar.Birim, depo_mevcut.DepoKodu AS Deposu, 
                      depo_mevcut.PaletID, serili_barkodlar.KullaniciID, serili_barkodlar.VardiyaKodu
FROM         serili_barkodlar INNER JOIN
                      stok_tanim_ust ON serili_barkodlar.StokKodu = stok_tanim_ust.StokKodu INNER JOIN
                      depo_mevcut ON serili_barkodlar.SeriliBarkod = depo_mevcut.SeriliBarkod
WHERE     (depo_mevcut.PaletID = N'{0}')", Palet);

         Utility.Engine.dat.TableDoldurbb(Utility.Engine.sql, ref dt);

         dt.AcceptChanges();

         textSeri.Focus();

         lblAdet.Text = dt.Rows.Count.ToString();
      }

      private void buttonSeri_Click(object sender, EventArgs e)
      {
         Palet = textPalet.Text.Trim().ToUpper();
         Seri = textSeri.Text.Trim().ToUpper();

         if (Palet == "" || Seri=="")
         {
            textSeri.Focus();
            MessageBox.Show("Bilgiler Eksik..!", "Dikkat..!");
            return;
         }

         Utility.Engine.sql = @"exec [dbo].[TicariUrunEkle] N'" + Palet + "',N'" + Seri + "'";

         DataRow dr = dt.NewRow();

         dr = Utility.Engine.dat.TableDon(Utility.Engine.sql).Rows[0];

         if (dr == null)
         {
            MessageBox.Show("Sunucu Yanit Vermedi...>"+Utility.Engine.dat.Fault,"Dikkat..!");
            textSeri.Text = "";
            textSeri.Focus();
            return;
         }

         try
         {
             string ss="";

             ss=dr["x"].ToString();

            MessageBox.Show(ss, "Dikkat..!");
            textSeri.Text = "";
            textSeri.Focus();
            return;
         }
         catch 
         {
            dt.ImportRow(dr);
            dt.AcceptChanges();
            textSeri.Text = "";
            textSeri.Focus();
            lblAdet.Text = dt.Rows.Count.ToString();
         }                
      }

      private void textSeri_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == 13)
         {
            buttonSeri_Click(null, null);
         }
      }

      private void buttonTPalet_Click(object sender, EventArgs e)
      {
         textPalet.Text = "";
      }

      private void button7_Click(object sender, EventArgs e)
      {
         textSeri.Text = "";
      }
    }
}