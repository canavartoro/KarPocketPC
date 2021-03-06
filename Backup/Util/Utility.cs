using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

//=====================================================================  
//using /*سْــــــــــــــــــــــمِ اﷲِارَّحْمَنِ ارَّحِيم */
//=====================================================================  

namespace AmbarPPC
{
    /// <summary>
    /// Sistem Yapılandırmaları ve genel işlemler
    /// </summary>
    public static class Utility
    {
        #region message

        /// <summary>
        /// Hata Mesajı 
        /// </summary>
        /// <param name="str">Gösterilecek Mesaj</param>
        public static void Hata(string str)
        {
            MessageBox.Show(str, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            WriteTrace(str);
        }

        public static void Hata(string str, string title)
        {
            MessageBox.Show(str, title, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            WriteTrace(str);
        }

        /// <summary>
        /// Uyarı Mesajı
        /// </summary>
        /// <param name="str">Gösterilecek Uyarı Mesajı</param>
        public static void Dikkat(string str)
        {
            MessageBox.Show(str, "DİKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            WriteTrace(str);
        }

        public static void MsgBox(string str)
        {
            MessageBox.Show(str, "TAMAM!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            WriteTrace(str);
        }

        /// <summary>
        /// Doğrulama Mesajı
        /// </summary>
        /// <param name="str">Soru</param>
        /// <returns>Yanıt</returns>
        public static bool Sor(string str)
        {
            return MessageBox.Show(str, "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;
        }

        #endregion
        
        #region trace

        public static void AddListener()
        {
            try
            {
                TextWriterTraceListener listener = new TextWriterTraceListener();

#if !DEBUG

                //System.Diagnostics.Debug.Listeners.Clear();

#endif

                System.Diagnostics.Debug.Listeners.Add(listener);

                System.Diagnostics.Debug.WriteLine("Başladı");
            }
            catch(Exception exc)
            {
                Utility.Hata("Uygulama geçici belleği açılamadı uygulama kapancak!\n" + exc.Message);
                Application.Exit();
            }
        }

        public static void WriteTrace(string str)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine(str);
            }
            catch
            {
                ;
            }
        }

        public static void WriteTrace(string str,string konum,string detay)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine(str + "\nKonum:" + konum + "\n:Detay:" + detay);
            }
            catch
            {
                ;
            }
        }

        /// <summary>
        /// Trace'e Log Yazmak İçin
        /// </summary>
        /// <param name="obj">Yazılacak Nesne</param>
        public static void WriteObject(object obj)
        {
            try
            {
                System.Diagnostics.Debug.Write(obj);
            }
            catch //(Exception exc)
            {
                //Hata("Trace Error:" + exc.Message);
            }
        }

        #endregion

        public static Help HELPME;

        public static Engine Engine;

        public static string AppPath = "";

        public static string Versiyon
        {
            get
            {
                Assembly entryPoint = Assembly.GetExecutingAssembly();

                // Get the name of the assembly.
                AssemblyName entryPointName = entryPoint.GetName();

                // Get the version.
                Version entryPointVersion = entryPointName.Version;

                return entryPointVersion.ToString();
            }
        }

        static void Main()
        {
            
            //AddListener();
            
            Application.Run(new Hakkimizda());
            

        }
    }
}