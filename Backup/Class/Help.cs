using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace AmbarPPC
{
    public sealed class Help
    {
        private string _path = "";
        private string _name = "";

        private DataSet moduller = new DataSet("HELP");

        public Help()
        {
            Path = AppPath;
            Open();
        }

        public Help(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                _path = dir.FullName;
                _name = dir.Name;
            }
        }

        public string Path
        {
            get { return _path; }
            set 
            {
                DirectoryInfo dir = new DirectoryInfo(value);
                if (dir.Exists)
                {
                    _path = dir.FullName;
                    _name = dir.Name;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                moduller = new DataSet(value);
                _name = value; 
            }
        }

        public int Count
        {
            get { return this.moduller != null ? this.moduller.Tables.Count : 0; }
        }

        public string AppPath
        {
            get
            {
                return
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            }
        }

        public DataTableCollection Moduller
        {
            get { return this.moduller != null ? this.moduller.Tables : null; }
        }

        public DataTable this[string key]
        {
            get
            {
                return this.moduller.Tables[key];
            }
        }

        public DataTable this[int index]
        {
            get
            {
                return this.moduller.Tables[index];
            }
        }

        public void Add(DataTable modul)
        {
            this.moduller.Tables.Add(modul);
        }

        public void Remove(DataTable modul)
        {
            this.moduller.Tables.Remove(modul);
        }

        public void Clear()
        {
            this.moduller.Tables.Clear();
        }

        public void Save()
        {
            DirectoryInfo dir = new DirectoryInfo(_path);
            if (!dir.Exists)
            {
                //MessageBox.Show("Proje yolunu kontrol edin dosya yolu bulunamadi kaydedilemez!");
                return;
            }

            string proje_path = dir.FullName + "\\help";
            string modul_path = "";

            Directory.CreateDirectory(proje_path);

            this.moduller.WriteXml(proje_path + "\\" + this.Name + ".xml");


        }

        public void Open()
        {
            DirectoryInfo dir = new DirectoryInfo(_path);
            if (!dir.Exists)
            {
                //MessageBox.Show("Proje yolunu kontrol edin dosya yolu bulunamadi kaydedilemez!");
                return;
            }

            string proje_path = dir.FullName + "\\help";

            if (!Directory.Exists(proje_path))
            {
                //MessageBox.Show("Proje yolunu kontrol edin dosya yolu bulunamadi kaydedilemez!");
                return;
            }

            string file = proje_path + "\\" + this.Name + ".xml";

            if(File.Exists(file))
                this.moduller.ReadXml(file);            
        }

        public void Show(string modulAdi)
        {
            try
            {
                if (Count > 0)
                {
                    DataTable modul = this[modulAdi];
                    if (modul != null)
                    {
                        FormHelp hlp = new FormHelp();
                        hlp.Modul = modul;
                        hlp.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Yardim modülü yüklenemedi bu modul için yardim yüklenmemiş.", "HATA!");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Yardim modülü yüklenirken hata oluştu:" + exc.Message, "HATA!");
            }
        }

        public static DataTable Modul(string name)
        {
            DataTable xTable = new DataTable(name);
            xTable.Columns.Add("LABEL", typeof(System.String));
            xTable.Columns.Add("SQLPROC", typeof(System.String));
            xTable.Columns.Add("DEFIN", typeof(System.String));
            return xTable;

        }
    }
}
