using System;
using System.Data;
using System.Runtime.InteropServices;

namespace AmbarPPC
{    
    internal class Zaman
    {        
        [DllImport("coredll.dll")]
        internal static extern bool SetLocalTime(ref SYSTEMTIME _objST);

        [StructLayout(LayoutKind.Sequential)]
        internal struct SYSTEMTIME
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;
        }

		internal static void ZamanKur()
		{
			try
			{
				Zaman.SYSTEMTIME systemtime;
				string str = ZamanGetir();
				systemtime.wYear = Convert.ToUInt16(str.Substring(0, 4));
				systemtime.wMonth = Convert.ToUInt16(str.Substring(5, 2));
				systemtime.wDayOfWeek = 1;
				systemtime.wDay = Convert.ToUInt16(str.Substring(8, 2));
				systemtime.wHour = Convert.ToUInt16(str.Substring(11, 2));
				systemtime.wMinute = Convert.ToUInt16(str.Substring(14, 2));
				systemtime.wSecond = Convert.ToUInt16(str.Substring(0x11, 2));
				systemtime.wMilliseconds = 0;
				Zaman.SetLocalTime(ref systemtime);
			}
			catch (Exception)
			{
			}
		}

		private static string ZamanGetir()
		{
			string str = ReturnNow();
			try
			{
                DataTable dt = new DataTable();
                Utility.Engine.dat.TableDoldur("SELECT CONVERT(VARCHAR, GETDATE(), 20)",ref dt);
				if(dt != null && dt.Rows.Count > 0)
				{
                    return dt.Rows[0][0].ToString();
				}
				return ReturnNow();
			}
			catch (Exception)
			{
				return ReturnNow();
			}
		}

		internal static string ReturnNow()
		{
			return (DateTime.Now.Day.ToString().PadLeft(2, '0') + "." + DateTime.Now.Month.ToString().PadLeft(2, '0') + "." + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Second.ToString().PadLeft(2, '0'));
		}
    }
}

