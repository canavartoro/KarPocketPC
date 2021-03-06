//	14:18 28.07.2004


using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AmbarPPC
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	public class SHELLEXECUTEEX
	{
		public UInt32 cbSize; 
		public UInt32 fMask; 
		public IntPtr hwnd; 
		public IntPtr lpVerb; 
		public IntPtr lpFile; 
		public IntPtr lpParameters; 
		public IntPtr lpDirectory; 
	
		public int nShow; 
		public IntPtr hInstApp; 
		
		public IntPtr lpIDList; 
		public IntPtr lpClass; 
		public IntPtr hkeyClass; 
		public UInt32 dwHotKey; 
		public IntPtr hIcon; 
		public IntPtr hProcess; 
	}

	[Flags]
	public enum PlaySoundFlags : int 
	{
		SND_SYNC = 0x0000,  /* play synchronously (default) */
		SND_ASYNC = 0x0001,  /* play asynchronously */
		SND_NODEFAULT = 0x0002,  /* silence (!default) if sound not found */
		SND_MEMORY = 0x0004,  /* pszSound points to a memory file */
		SND_LOOP = 0x0008,  /* loop the sound until next sndPlaySound */
		SND_NOSTOP = 0x0010,  /* don't stop any currently playing sound */
		SND_NOWAIT = 0x00002000, /* don't wait if the driver is busy */
		SND_ALIAS = 0x00010000, /* name is a registry alias */
		SND_ALIAS_ID = 0x00110000, /* alias is a predefined ID */
		SND_FILENAME = 0x00020000, /* name is file name */
		SND_RESOURCE = 0x00040004  /* name is resource name or atom */
	}

	public class PROCESS_INFORMATION 
	{
        public IntPtr hProcess;  
		public IntPtr hThread;  
		public UInt32 dwProcessId;  
		public UInt32 dwThreadId;
	}

	public class TWinApi
	{
		public const uint INFINITE = 0xFFFFFFFF;
		public const int  WAIT_ABANDONED = 128;
		public const int  WAIT_OBJECT_0 = 0;
		public const int  WAIT_TIMEOUT = 258;
		
		[DllImport("cdll.dll",EntryPoint="ZibidiAc")]
		static extern int ZibidiAc(string FileName);

		[DllImport("CoreDll.dll")]
		extern static System.Int32 WaitForSingleObject(System.IntPtr Handle, System.Int32 Wait);

		[DllImport("Coredll")]
		static extern UInt32 KernelIoControl(UInt32 dwIoControlCode, IntPtr lpInBuf, UInt32 nInBufSize, byte[] buf, UInt32 nOutBufSize, [In, Out] uint lpBytesReturned);

		[DllImport("coredll")]
		extern static public int ShellExecuteEx( SHELLEXECUTEEX ex );

		[DllImport("coredll")]
		extern static IntPtr LocalAlloc( int flags, int size );

		[DllImport("coredll")]
		extern static void LocalFree( IntPtr ptr );

		[DllImport("coredll")]
		extern static IntPtr FindWindow(String lpClass ,String lpTitle );

		[DllImport("coredll")]
		public static extern bool PlaySound( string szSound, IntPtr hMod, PlaySoundFlags flags );

		[DllImport("coredll.dll", EntryPoint="CreateFileW", SetLastError = true)]
		private static extern IntPtr CECreateFileW(
			String lpFileName, UInt32 dwDesiredAccess, UInt32 dwShareMode,
			IntPtr lpSecurityAttributes, UInt32 dwCreationDisposition, UInt32 dwFlagsAndAttributes,
			IntPtr hTemplateFile);

		[DllImport("coredll.dll", EntryPoint="WriteFile", SetLastError = true)]
		private static extern int CEWriteFile(IntPtr hFile, byte[] lpBuffer, UInt32 nNumberOfBytesToRead, ref Int32 lpNumberOfBytesRead, IntPtr lpOverlapped);	

		[DllImport("coredll.dll", EntryPoint="CloseHandle", SetLastError = true)]
		private static extern int CECloseHandle(IntPtr hObject);

		[ DllImport("coredll.dll")]
		public static extern bool SipShowIM(int dwFlag);

		[DllImport("coredll",EntryPoint="SetForegroundWindow")]
		private static extern bool SetForegroundWindow(IntPtr hWnd);

        public TWinApi()
		{
			
        }

        public static string Ayarlar (string FileName, string param)
        {
            string don = "";

            try
            {
                StreamReader sr = new StreamReader(FileName);
                if (param.ToLower() == "ip")
                {
                    don = sr.ReadLine();
                }
                else
                if (param.ToLower() == "user")
                {
                    sr.ReadLine();
                    don = sr.ReadLine();
                }
                else
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    don = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {
                don = "";
            }

            return don;
        }
        
        public static bool TShellExecute(string FileName)
		{
			int nSize = FileName.Length * 2 + 2;
			
			IntPtr pData = LocalAlloc(0x40, nSize);
			Marshal.Copy(Encoding.Unicode.GetBytes(FileName), 0, pData, nSize - 2);

			SHELLEXECUTEEX see = new SHELLEXECUTEEX();
			see.cbSize = 60;
			see.dwHotKey = 0;
			see.fMask = 0;
			see.hIcon = IntPtr.Zero;
			see.hInstApp = IntPtr.Zero;
			see.hProcess = IntPtr.Zero;;
			see.lpClass = IntPtr.Zero;
			see.lpDirectory = IntPtr.Zero;
			see.lpIDList = IntPtr.Zero;
			see.lpParameters = IntPtr.Zero;
			see.lpVerb = IntPtr.Zero;
			see.nShow = 0;
			see.lpFile = pData;

			if(ShellExecuteEx(see)==0)
			{
				LocalFree(pData);
				return false;
			}
			//Waitforsingleobject
			LocalFree(pData);

            return true;
		}
								   
		public bool TFindWindow(string WindowName)
		{
			IntPtr ip;
			ip=FindWindow(null,WindowName);
			if(ip.ToInt32()==0)
				return false;

            return true;
		}

		public bool TekDefa(string str)
		{
			// Texto de la Forma 
			IntPtr nWnd = TFindWindow2(str);

			if(nWnd.Equals(new System.IntPtr(0)))
			{
				return false;
			}
			else
			{
				//SetForegroundWindow(nWnd);
				return true;
			}			
		}
		
		public static int ZipAc(string FileName)
		{
			return ZibidiAc(FileName);
		}

		public IntPtr TFindWindow2(string WindowName)
		{
			return FindWindow(WindowName,null);
		}

		public void TSetForegroundWindow(IntPtr ipp)
		{
			SetForegroundWindow(ipp);
		}


		public bool TPlaySound(string filename)
		{
			PlaySound( filename, IntPtr.Zero, PlaySoundFlags.SND_FILENAME | PlaySoundFlags.SND_ASYNC );
			
            return true;
		}

        public bool IsIdValid()
        {
            byte[] uuid = new byte[16];
            bool useFix = false;

            uint len = 256;
            uint cb = 0; //For some reason this is very important
            byte[] buffer = new byte[256];
            buffer[0] = 0;
            buffer[1] = 1;
            uint ret;

            try
            {
                ret = KernelIoControl(0x1010054, //Win32API.IOCTL_HAL_GET_DEVICEID
                    IntPtr.Zero, 0, buffer, len, cb);

                Int32 dwPresetIDOffset = BitConverter.ToInt32(buffer, 4);
                Int32 dwPlatformIDOffset = BitConverter.ToInt32(buffer, 0xc);
                Int32 dwPlatformIDSize = BitConverter.ToInt32(buffer, 0x10);

                for (int i = 0; i < 10; i++)
                {
                    uuid[i] = buffer[dwPresetIDOffset + i];
                }

                //  Our ID is 16 bytes and we already have 10 of them...
                if (useFix)
                {
                    int diff = Math.Max(0, dwPlatformIDSize - 6);

                    dwPlatformIDOffset += diff;
                }

                dwPlatformIDSize = Math.Min(dwPlatformIDSize, 6);

                for (int i = dwPlatformIDOffset; i < dwPlatformIDOffset + dwPlatformIDSize; i++)
                {
                    uuid[(i - dwPlatformIDOffset) + 10] = buffer[i];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Program Bu Cihazda Çaliştirilamaz. Programi Aldiðiniz şirketle Baðlantiya Geçiniz...");
                return false;
            }

            string result = null;
            if (uuid != null)
            {
                string format0 = "{0:X2}{1:X2}-";
                string format1 = "{0:X2}{1:X2}";

                StringBuilder sb = new StringBuilder();

                sb.Append(string.Format(format0, uuid[0], uuid[1]));
                sb.Append(string.Format(format0, uuid[2], uuid[3]));
                sb.Append(string.Format(format0, uuid[4], uuid[5]));
                sb.Append(string.Format(format1, uuid[6], uuid[7]));
                sb.Append("\n");
                sb.Append(string.Format(format0, uuid[8], uuid[9]));
                sb.Append(string.Format(format0, uuid[10], uuid[11]));
                sb.Append(string.Format(format0, uuid[12], uuid[13]));
                sb.Append(string.Format(format1, uuid[14], uuid[15]));

                result = sb.ToString();
            }
            if (result != "4D00-6900-6300-7200\n6F00-4E4B-4E6F-4B69")//===>Emulator
            {
                if (result != "FFFF-FFFF-FFFF-FFFF\nFFFF-FFFF-FFFF-FFFF")//------>>
                {
                    MessageBox.Show(result + "\nProgram Bu Cihazda Çaliştirilamaz. Programi Aldiðiniz şirketle Baðlantiya Geçiniz...::");
                    return false;
                }
            }
            return true;
        }

        public string GetIdValid()
        {
            byte[] uuid = new byte[16];
            bool useFix = false;

            uint len = 256;
            uint cb = 0; //For some reason this is very important
            byte[] buffer = new byte[256];
            buffer[0] = 0;
            buffer[1] = 1;
            uint ret;

            try
            {
                ret = KernelIoControl(0x1010054, //Win32API.IOCTL_HAL_GET_DEVICEID
                    IntPtr.Zero, 0, buffer, len, cb);

                Int32 dwPresetIDOffset = BitConverter.ToInt32(buffer, 4);
                Int32 dwPlatformIDOffset = BitConverter.ToInt32(buffer, 0xc);
                Int32 dwPlatformIDSize = BitConverter.ToInt32(buffer, 0x10);

                for (int i = 0; i < 10; i++)
                {
                    uuid[i] = buffer[dwPresetIDOffset + i];
                }

                //  Our ID is 16 bytes and we already have 10 of them...
                if (useFix)
                {
                    int diff = Math.Max(0, dwPlatformIDSize - 6);

                    dwPlatformIDOffset += diff;
                }

                dwPlatformIDSize = Math.Min(dwPlatformIDSize, 6);

                for (int i = dwPlatformIDOffset; i < dwPlatformIDOffset + dwPlatformIDSize; i++)
                {
                    uuid[(i - dwPlatformIDOffset) + 10] = buffer[i];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Program Bu Cihazda Çaliştirilamaz. Programi Aldiðiniz şirketle Baðlantiya Geçiniz...");
                return null;
            }

            string result = null;
            if (uuid != null)
            {
                string format0 = "{0:X2}{1:X2}-";
                string format1 = "{0:X2}{1:X2}";

                StringBuilder sb = new StringBuilder();

                sb.Append(string.Format(format0, uuid[0], uuid[1]));
                sb.Append(string.Format(format0, uuid[2], uuid[3]));
                sb.Append(string.Format(format0, uuid[4], uuid[5]));
                sb.Append(string.Format(format1, uuid[6], uuid[7]));
                sb.Append("\n");
                sb.Append(string.Format(format0, uuid[8], uuid[9]));
                sb.Append(string.Format(format0, uuid[10], uuid[11]));
                sb.Append(string.Format(format0, uuid[12], uuid[13]));
                sb.Append(string.Format(format1, uuid[14], uuid[15]));

                result = sb.ToString();
            }
            /*if (result != "4D00-6900-6300-7200\n6F00-4E4B-4E6F-4B69")//===>Emulator
            {
                if (result != "FFFF-FFFF-FFFF-FFFF\nFFFF-FFFF-FFFF-FFFF")//------>>
                {
                    MessageBox.Show(result + "\nProgram Bu Cihazda Çaliştirilamaz. Programi Aldiðiniz şirketle Baðlantiya Geçiniz...::");
                    return null;
                }
            }*/

            string ss = result.Substring(result.IndexOf('\n') - 4, 4);
            ss += result.Substring(result.IndexOf('\n') + 1, 4);

            return ss; ;
        }

        public void Klavye(int mode)
        {
            try
            {
				SipShowIM(mode);
            }
            catch (Exception)
            {
            }
        }

       

	}
}

