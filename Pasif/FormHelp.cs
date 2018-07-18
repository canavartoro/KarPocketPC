using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmbarPPC
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private DataTable modul = new DataTable();

        public DataTable Modul
        {
            get
            {
                return modul;
            }

            set
            {
                modul = value;
            }
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == toolBar1.Buttons[0])
            {
                Close();
            }
            else if (e.Button == toolBar1.Buttons[1])
            {
                string modulAdi = "";
                    
                    if (comboMetod.SelectedItem != null)
                        modulAdi = comboMetod.SelectedItem.ToString();

                DataTable dt = new DataTable();

                Utility.Engine.dat.TableDoldur(string.Format("sp_helptext N'{0}'", modulAdi), ref dt);

                if (dt != null && dt.Rows.Count > 0)
                {
                    txtSqlProc.Text = "";
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtSqlProc.Text += dr[0].ToString() + "\n";                        
                    }
                    panelProc.Location = new Point(3, 27);
                    panelProc.Visible = true;
                    panelProc.BringToFront();
                }

                
            }
            else
            {
                if (txtLabel.Text.Length > 0)
                {
                    SaveFileDialog sv = new SaveFileDialog();
                    if (sv.ShowDialog() != DialogResult.OK)
                        return;
                    
                    string modulAdi = "";
                    
                    if (comboMetod.SelectedItem != null)
                        modulAdi = comboMetod.SelectedItem.ToString();

                    StreamWriter Writer = new StreamWriter(sv.FileName, false, System.Text.Encoding.GetEncoding("windows-1254"));
                    Writer.WriteLine(modulAdi);
                    Writer.WriteLine(txtLabel.Text);
                    Writer.WriteLine(txtProc.Text);
                    Writer.WriteLine(txtDefin.Text);
                    Writer.Flush();
                    Writer.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSqlProc.Text = "";
            panelProc.Visible = false;
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
            try
            {
                if (modul != null && modul.Rows.Count > 0)
                {
                    foreach (DataRow dr in modul.Rows)
                    {
                        comboMetod.Items.Add(dr[0].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }

        private void comboMetod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string iLabel = "";
                if (comboMetod.SelectedItem != null)
                    iLabel = comboMetod.SelectedItem.ToString();

                txtLabel.Text = "";
                txtProc.Text = "";
                txtDefin.Text = "";

                if (iLabel != "")
                {
                    if (modul != null && modul.Rows.Count > 0)
                    {
                        foreach (DataRow dr in modul.Rows)
                        {
                            if (dr[0].ToString().Equals(iLabel))
                            {
                                txtLabel.Text = dr[0].ToString();
                                txtProc.Text = dr[1].ToString();
                                txtDefin.Text = dr[2].ToString();
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Genel Hata:" + exc.Message, "HATA!");
            }
        }
    }
}