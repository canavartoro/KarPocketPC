using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

//=====================================================================  
//using /*سْــــــــــــــــــــــمِ اﷲِارَّحْمَنِ ارَّحِيم */
//=====================================================================  

namespace AmbarPPC
{
    public class TextWriterTraceListener : System.Diagnostics.TraceListener
    {
        private StreamWriter Writer;

        public TextWriterTraceListener()
        {
            try
            {
                string filex = DateTime.Now.ToString("ddMMyy");
                string domanename = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);//"\\Backup\\CihazKur\\";//System.AppDomain.CurrentDomain.FriendlyName.Replace(".exe", "");

                if (!Directory.Exists(domanename))
                    Directory.CreateDirectory(domanename);

                string trace = domanename + "\\" + filex + "_trace.txt";

                Writer = new System.IO.StreamWriter(trace, true, System.Text.Encoding.GetEncoding("windows-1254"));

                Writer.AutoFlush = true;
            }
            catch (Exception exc)
            {
                Utility.Hata("Hata dosyası açılamadı:" + exc.Message);
            }
        }

        ~TextWriterTraceListener()
        {
            try
            {
                if (Writer != null)
                    Writer.Close();
                System.Diagnostics.Debug.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Uygulama dinleyicisi kapatılamadı", e);
            }
        }

        public override void Write(string message)
        {
            try
            {
                Writer.Write("-> " + DateTime.Now.ToString() + "\t" + message);
            }
            catch (Exception exc)
            {
                Utility.Hata("Hata dosyasına yazılamadı:" + exc.Message);
            }
        }

        public override void WriteLine(string message)
        {
            try
            {
                Writer.WriteLine("-> " + DateTime.Now.ToString() + "\t" + message);
            }
            catch (Exception exc)
            {
                Utility.Hata("Hata kaydedilemedi:" + exc.Message);
            }
        }
    }
}
