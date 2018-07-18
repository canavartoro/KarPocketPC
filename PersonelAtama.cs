using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class PersonelAtama : Form
    {
        public PersonelAtama()
        {
            InitializeComponent();
        }

        private isemri_personel IsEmriPersonel;

        private void IsEmri()
        {
            try
            {
                string isemir = Utility.Engine.SqlTemizle(textIsEmri.Text);
                if (!string.IsNullOrEmpty(isemir))
                {
                    IsEmriPersonel = new isemri_personel(isemir, null);
                    if (IsEmriPersonel.IsEmriOk)
                    {
                        textIsEmri.BackColor = Color.Salmon;
                        textPersonel.BackColor = Color.Yellow;
                        textPersonel.Focus();
                    }
                    else
                    {
                        textIsEmri.Focus();
                        textIsEmri.SelectAll();
                        return;
                    }
                    return;
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void Personel()
        {
            try
            {
                if (!IsEmriPersonel.IsEmriOk)
                {
                    if(!Utility.Sor("İş emri okutulmadı devam edilsin mi?"))
                        return;
                }

                string pers = Utility.Engine.SqlTemizle(textPersonel.Text);
                if (!string.IsNullOrEmpty(pers))
                {
                    IsEmriPersonel.Personel = pers;
                    if (IsEmriPersonel.PersonelOk &&  IsEmriPersonel.SavePersonel())
                    {
                        IsEmriPersonel = new isemri_personel();
                        GetList();
                    }
                    textIsEmri.Text = "";
                    textPersonel.Text = "";
                    textIsEmri.BackColor = Color.Yellow;
                    textPersonel.BackColor = Color.White;
                    textIsEmri.Focus();
                    return;
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void GetList()
        {
            try
            {
                string xquery = "SELECT dbo.isemri.IsEmri, dbo.SPERSONEL.AD + ' ' + dbo.SPERSONEL.SOYAD AS AdiSoyAdi, dbo.isemri.StokAdi, dbo.isemri.StokKodu,  dbo.STEZGAH.AD AS IstasyonAdi, dbo.isemri_operasyonlari.IstasyonKodu, dbo.SPERSONEL.KOD AS PKod FROM dbo.isemri_personel WITH (NOLOCK) INNER JOIN dbo.isemri WITH (NOLOCK) ON dbo.isemri_personel.IsEmri = dbo.isemri.IsEmri INNER JOIN dbo.SPERSONEL WITH (NOLOCK) ON dbo.isemri_personel.Personel = dbo.SPERSONEL.KOD INNER JOIN dbo.isemri_operasyonlari WITH (NOLOCK) ON dbo.isemri.IsEmri = dbo.isemri_operasyonlari.IsEmri INNER JOIN dbo.STEZGAH WITH (NOLOCK) ON dbo.isemri_operasyonlari.IstasyonKodu = dbo.STEZGAH.KOD ORDER BY dbo.isemri.IsEmri, dbo.STEZGAH.AD";
                Utility.Engine.dat.ListDoldur(ref listView1, xquery);
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void buttonIsBul_Click(object sender, EventArgs e)
        {
            try
            {
                Tus t = new Tus();
                t.textBox1.Text = textIsEmri.Text;
                if (t.ShowDialog() == DialogResult.OK)
                {
                    textIsEmri.Text = t.textBox1.Text;
                    IsEmri();
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void PersonelAtama_Load(object sender, EventArgs e)
        {
            GetList();
            textIsEmri.Focus();
            return;
        }

        private void textIsEmri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                IsEmri();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tus t = new Tus();
                t.textBox1.Text = textPersonel.Text;
                if (t.ShowDialog() == DialogResult.OK)
                {
                    textPersonel.Text = t.textBox1.Text;
                    Personel();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void textPersonel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Personel();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0 && listView1.SelectedIndices.Count > 0)
            {
                string isemri = listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
                string pers = listView1.Items[listView1.SelectedIndices[0]].SubItems[6].Text;
                string xquery = string.Format("DELETE FROM dbo.isemri_personel WHERE Personel = N'{0}' AND IsEmri = N'{1}'", pers, isemri);
                Utility.WriteTrace(xquery);
                if (!Utility.Engine.dat.TInsert(xquery))
                {
                    Utility.Hata("Database işleminde hata oluştu:" + xquery);
                }
                GetList();
            }
        }

        private void textCikis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    DataTable dt = null;
                    string xqery = "";
                    int sor = 0;

                soru:

                    if (!Utility.Sor("Personel çıkış işlemini onaylıyor musunuz?"))
                        return;

                    xqery = string.Format(@"EXECUTE dbo.IsEmriPersonel N'', N'{0}', 0, 2", Utility.Engine.SqlTemizle(textCikis.Text).ToUpper());

                    Utility.WriteTrace(xqery);

                    dt = new DataTable();

                    if (Utility.Engine.dat.TableDoldur(xqery, ref dt) && dt != null && dt.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(dt.Rows[0][2].ToString()) > 0)
                        {
                            if (Utility.Sor(dt.Rows[0][1].ToString()))
                            {
                                sor = 1;
                                goto soru;
                            }
                        }
                        if (Convert.ToInt32(dt.Rows[0][0].ToString()) > 0)
                        {
                        }
                        else
                        {
                            Utility.Hata("Sunucu hatası:" + dt.Rows[0][1].ToString());
                        }
                    }
                    else
                    {
                        Utility.Hata("Sunucu yanıt vermedi!" + Utility.Engine.dat.Fault);
                    }
                }
                catch (Exception exc)
                {
                    Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
                }
                textCikis.Text = "";
                textCikis.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Tus t = new Tus();
                t.textBox1.Text = textCikis.Text;
                if (t.ShowDialog() == DialogResult.OK)
                {
                    textCikis.Text = t.textBox1.Text;
                    textCikis_KeyPress(null, new KeyPressEventArgs((char)13));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

      
    }

    class isemri_personel
    {
        private string isemri, personel;
        private string personeladi , personelsoyadi ;
        private string stokadi , stokkodu ;
        private string istasyonadi , istasyonkodu ;
        private int ismiktar , urmiktar ;

        public isemri_personel() 
        {
            istasyonadi = istasyonkodu = stokadi = stokkodu = personeladi = personelsoyadi = isemri = personel = string.Empty;
            ismiktar = urmiktar = 0;
        }

        public isemri_personel(string i, string p)
        {
            isemri = i;
            if (!string.IsNullOrEmpty(isemri))
                LoadWorder();
            personel = p;
        }

        public string IsEmri
        {
            get { return isemri; }
            set { isemri = value; }
        }

        public string Personel
        {
            get { return personel; }
            set 
            { 
                personel = value;
                LoadPersonel();
            }
        }

        public string PersonelAdi
        {
            get { return personeladi; }
            set { personeladi = value; }
        }

        public string PersonelSoyAdi
        {
            get { return personelsoyadi; }
            set { personelsoyadi = value; }
        }

        public string AdiSoyadi
        {
            get { return personeladi + " " + personelsoyadi; }
        }

        public string StokAdi
        {
            get { return stokadi; }
            set { stokadi = value; }
        }

        public string StokKodu
        {
            get { return stokkodu; }
            set { stokkodu = value; }
        }

        public string IstasyonAdi
        {
            get { return istasyonadi; }
            set { istasyonadi = value; }
        }

        public string IstasyonKodu
        {
            get { return istasyonkodu; }
            set { istasyonkodu = value; }
        }

        public int IsMiktar
        {
            get { return ismiktar; }
            set { ismiktar = value; }
        }

        public int UrMiktar
        {
            get { return urmiktar; }
            set { urmiktar = value; }
        }

        public int KalMiktar
        {
            get { return ismiktar - urmiktar; }
        }

        public bool IsReady
        {
            get { return !string.IsNullOrEmpty(isemri) && !string.IsNullOrEmpty(personel); }
        }

        public bool IsEmriOk
        {
            get { return !string.IsNullOrEmpty(isemri); }
        }

        public bool PersonelOk
        {
            get { return !string.IsNullOrEmpty(personel); }
        }

        private void LoadWorder()
        {
            try
            {
                string xqery = string.Format(@"SELECT i.IsEmri, i.StokKodu, i.StokAdi, i.Miktar, ISNULL(SUM(u.Miktar),0) AS Uretilen, o.IstasyonKodu, t.AD AS IstasyonAdi
FROM dbo.isemri i WITH (NOLOCK) INNER JOIN dbo.isemri_operasyonlari o WITH (NOLOCK) ON i.IsEmri = o.IsEmri
INNER JOIN dbo.STEZGAH t WITH (NOLOCK) ON o.IstasyonKodu = t.KOD
LEFT OUTER JOIN dbo.isemri_operasyon u WITH (NOLOCK) ON i.IsEmri = u.IsEmri 
WHERE i.IsEmri = N'{0}'
GROUP BY i.IsEmri, i.StokKodu, i.StokAdi, i.Miktar, o.IstasyonKodu, t.AD", isemri);

                isemri = stokkodu = stokadi = istasyonkodu = istasyonadi = string.Empty;
                ismiktar = urmiktar = 0;
                
                IDataReader dr = Utility.Engine.dat.TSelect(xqery);

                if (dr != null && dr.Read())
                {
                    if (!dr.IsDBNull(0))
                        isemri = dr.GetValue(0).ToString();
                    if (!dr.IsDBNull(1))
                        stokkodu = dr.GetValue(1).ToString();
                    if (!dr.IsDBNull(2))
                        stokadi = dr.GetValue(2).ToString();
                    if (!dr.IsDBNull(3))
                        ismiktar = Convert.ToInt32(dr.GetValue(3));
                    if (!dr.IsDBNull(4))
                        urmiktar = Convert.ToInt32(dr.GetValue(4));
                    if (!dr.IsDBNull(5))
                        istasyonkodu = dr.GetValue(5).ToString();
                    if (!dr.IsDBNull(6))
                        istasyonadi = dr.GetValue(6).ToString();
                }
                if (dr != null)
                    dr.Close();
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        public bool SavePersonel()
        {
            try
            {
                DataTable dt = null;
                string xqery = "";
                int sor = 0;

                if (string.IsNullOrEmpty(isemri)) sor = 1;

                soru:

                xqery = string.Format(@"EXECUTE dbo.IsEmriPersonel N'{0}', N'{1}', {2}, 0", isemri, personel, sor);

                Utility.WriteTrace(xqery);

                dt = new DataTable();

                if (Utility.Engine.dat.TableDoldur(xqery, ref dt) && dt != null && dt.Rows.Count > 0)
                {
                    if (Convert.ToInt32(dt.Rows[0][2].ToString()) > 0)
                    {
                        if (Utility.Sor(dt.Rows[0][1].ToString()))
                        {
                            sor = 1;
                            goto soru;
                        }
                        else
                            return false;
                    }
                    if (Convert.ToInt32(dt.Rows[0][0].ToString()) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        Utility.Hata("Sunucu hatası:" + dt.Rows[0][1].ToString());
                        return false;
                    }
                }
                else
                {
                    Utility.Hata("Sunucu yanıt vermedi!" + Utility.Engine.dat.Fault);
                    return false;
                }
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
                return false;
            }
        }

        private void LoadPersonel()
        {
            try
            {
                string xqery = string.Format(@"SELECT KOD, AD, SOYAD FROM dbo.SPERSONEL WITH (NOLOCK) WHERE KOD = N'{0}'", personel);

                personel = personeladi = personelsoyadi = string.Empty;

                IDataReader dr = Utility.Engine.dat.TSelect(xqery);

                if (dr != null && dr.Read())
                {
                    if (!dr.IsDBNull(0))
                        personel = dr.GetValue(0).ToString();
                    if (!dr.IsDBNull(1))
                        personeladi = dr.GetValue(1).ToString();
                    if (!dr.IsDBNull(2))
                        personelsoyadi = dr.GetValue(2).ToString();
                }
                if (dr != null)
                    dr.Close();
            }
            catch (Exception exc)
            {
                Utility.Hata("Genel Hata:" + exc.Message, "HATA!");
            }
        }        
    }
}