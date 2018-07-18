//	14:18 28.07.2004


using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;



namespace TOLGA
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


	public class TWinApi
	{
		[DllImport("Coredll")]
		public static extern UInt32 KernelIoControl(UInt32 dwIoControlCode, IntPtr lpInBuf, UInt32 nInBufSize, byte[] buf, UInt32 nOutBufSize, [In, Out] uint lpBytesReturned);

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

		[ DllImport("scandll.dll",EntryPoint="OpenSCAN",CharSet=CharSet.Auto,SetLastError = true)]
		public static extern void OpenSCAN(char [] path);

		[ DllImport("scandll.dll",EntryPoint="VersionSCAN",CharSet=CharSet.Auto, SetLastError = true)]
		public static extern void VersionSCAN(char [] path);

		[ DllImport("scandll.dll",EntryPoint="ReadSCAN",CharSet=CharSet.Auto, SetLastError = true)]
		public static extern char ReadSCAN(char c,byte [] buffer, byte [] s);
	
		[ DllImport("scandll.dll",EntryPoint="CloseSCAN",CharSet=CharSet.Auto, SetLastError = true)]
		public static extern void CloseSCAN();


		public TWinApi()
		{
			
		}
		public bool TShellExecute(string FileName)
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

			LocalFree(pData);
			return true;
		}
		public bool TDialUpInternet()
		{
			string str;
			int size;
			
			str="rnaapp.exe";
			size = str.Length * 2 + 2;
			IntPtr pfilename = LocalAlloc(0x40, size);
			Marshal.Copy(Encoding.Unicode.GetBytes(str), 0, pfilename, size - 2);

			str="-e \"My Conection\" -m";
			size = str.Length * 2 + 2;
			IntPtr pparametres = LocalAlloc(0x40, size);
			Marshal.Copy(Encoding.Unicode.GetBytes(str), 0, pparametres, size - 2);

			str="\\windows";
			size = str.Length * 2 + 2;
			IntPtr pdirectory = LocalAlloc(0x40, size);
			Marshal.Copy(Encoding.Unicode.GetBytes(str),0, pdirectory, size - 2);


			SHELLEXECUTEEX see = new SHELLEXECUTEEX();
			see.cbSize = 60;
			see.dwHotKey = 0;
			see.fMask = 0x40 ;/*SEE_MASK_NOCLOSEPROCESS*/
			see.hIcon = IntPtr.Zero;
			see.hInstApp = IntPtr.Zero;
			see.hProcess = IntPtr.Zero;;
			see.lpClass = IntPtr.Zero;
			see.lpDirectory = pdirectory;
			see.lpIDList = IntPtr.Zero;
			see.lpParameters = pparametres;
			see.lpVerb = IntPtr.Zero;
			see.nShow = 0;
			see.lpFile = pfilename;

			if(ShellExecuteEx(see)==0)
				return false;
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

		public bool TPlaySound(string filename)
		{
			PlaySound( filename, IntPtr.Zero, PlaySoundFlags.SND_FILENAME | PlaySoundFlags.SND_ASYNC );
			return true;
		}

		public bool IsIdValid()
		{
			byte[] uuid = new byte[16];
			bool useFix=false;

			uint len = 256;
			uint cb = 0; //For some reason this is very important
			byte [] buffer = new byte[256];
			buffer[0] = 0;
			buffer[1] = 1;
			uint ret;

			try
			{
				ret = KernelIoControl (0x1010054, //Win32API.IOCTL_HAL_GET_DEVICEID
					IntPtr.Zero, 0, buffer, len, cb);

				Int32 dwPresetIDOffset   = BitConverter.ToInt32 (buffer, 4);
				Int32 dwPlatformIDOffset = BitConverter.ToInt32 (buffer, 0xc);
				Int32 dwPlatformIDSize   = BitConverter.ToInt32 (buffer, 0x10);

				for (int i = 0; i < 10; i++)
				{
					uuid [i] = buffer [dwPresetIDOffset+i];
				}

				//  Our ID is 16 bytes and we already have 10 of them...
				if (useFix)
				{
					int diff = Math.Max (0, dwPlatformIDSize - 6);

					dwPlatformIDOffset += diff;
				}

				dwPlatformIDSize = Math.Min (dwPlatformIDSize, 6);

				for (int i = dwPlatformIDOffset; i < dwPlatformIDOffset + dwPlatformIDSize; i++)
				{
					uuid [(i-dwPlatformIDOffset)+10] = buffer[i];
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Program Bu Cihazda Çalýþtýrýlamaz. Programý Aldýðýnýz Þirketle Baðlantýya Geçiniz...");
				return false;
			}
			
			string result = null;
			if (uuid != null)
			{
				string format0 = "{0:X2}{1:X2}-";
				string format1 = "{0:X2}{1:X2}";

				StringBuilder sb = new StringBuilder ();

				sb.Append (string.Format (format0, uuid [0], uuid [1]));
				sb.Append (string.Format (format0, uuid [2], uuid [3]));
				sb.Append (string.Format (format0, uuid [4], uuid [5]));
				sb.Append (string.Format (format1, uuid [6], uuid [7]));
				sb.Append ("\n");
				sb.Append (string.Format (format0, uuid [8], uuid [9]));
				sb.Append (string.Format (format0, uuid[10], uuid[11]));
				sb.Append (string.Format (format0, uuid[12], uuid[13]));
				sb.Append (string.Format (format1, uuid[14], uuid[15]));

				result = sb.ToString ();
			}
			if(result=="4900-6E00-7400-6500\n6C00-4E4B-4E6F-4B69" )
			{
				return true;
			}
			if(result=="0309-1403-2F0B-4051\n2800-0050-BF7A-660C" )
			{
				return true;
			}
			if(result=="2194-7A39-3284-5161\n2800-0050-BF19-77E0")
			{
				return true;
			}
			if(result=="2D25-080E-0304-0341\n0800-0050-BF19-77E0")
			{
				return true;
			}
			if(result=="076F-0100-4010-4071\n0800-0040-056A-0E9D")
			{
				return true;
			}
			if(result=="1B01-09E2-D031-D8D1\n3800-0050-BF3F-5173")
			{
				return true;
			}
			if(result=="D73A-0300-4010-4071\n0800-0040-056A-0E9D")
			{
				return true;
			}
									
			if(result=="9D00-0D6C-6C99-68D1\n3800-0050-BF3F-5173" )
			{
				return true;
			}

			if(result=="1801-0718-D668-D6D1\n3800-0050-BF3F-5173" )
			{
				return true;
			}

			if(result=="D600-024F-6565-EED1\n3800-0050-BF3F-5173" )
			{
				return true;
			}

			if(result=="7900-0669-2525-A0A1\n3800-0050-BF3F-5173" )
			{
				return true;
			}

			if(result=="6A00-0E1D-42A0-68D1\n3800-0050-BF3F-5173" )
			{
				return true;
			}

			if(result=="5200-0200-D63E-AB81\n4800-0050-BF3F-5173" )
			{
				return true;
			}

			if(result=="D600-0A4F-F465-EED1\n3800-0050-BF3F-5173" )
			{
				return true;
			}

			if(result=="4300-4500-5000-4300\n0000-4E6B-4E6F-4B69" )
			{
				return true;
			}

			if(result=="4300-4500-5000-4300\n0000-4E4B-4E6F-4B69" )
			{
				return true;
			}


			MessageBox.Show(result+"\nProgram Bu Cihazda Çalýþtýrýlamaz. Programý Aldýðýnýz Þirketle Baðlantýya Geçiniz...");
			return false;
		}

		public string GetIdValid()
		{
			byte[] uuid = new byte[16];
			bool useFix=false;

			uint len = 256;
			uint cb = 0; //For some reason this is very important
			byte [] buffer = new byte[256];
			buffer[0] = 0;
			buffer[1] = 1;
			uint ret;

			try
			{
				ret = KernelIoControl (0x1010054, //Win32API.IOCTL_HAL_GET_DEVICEID
					IntPtr.Zero, 0, buffer, len, cb);

				Int32 dwPresetIDOffset   = BitConverter.ToInt32 (buffer, 4);
				Int32 dwPlatformIDOffset = BitConverter.ToInt32 (buffer, 0xc);
				Int32 dwPlatformIDSize   = BitConverter.ToInt32 (buffer, 0x10);

				for (int i = 0; i < 10; i++)
				{
					uuid [i] = buffer [dwPresetIDOffset+i];
				}

				//  Our ID is 16 bytes and we already have 10 of them...
				if (useFix)
				{
					int diff = Math.Max (0, dwPlatformIDSize - 6);

					dwPlatformIDOffset += diff;
				}

				dwPlatformIDSize = Math.Min (dwPlatformIDSize, 6);

				for (int i = dwPlatformIDOffset; i < dwPlatformIDOffset + dwPlatformIDSize; i++)
				{
					uuid [(i-dwPlatformIDOffset)+10] = buffer[i];
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Program Bu Cihazda Çalýþtýrýlamaz. Programý Aldýðýnýz Þirketle Baðlantýya Geçiniz...");
				return "";
			}
			
			string result = null;
			if (uuid != null)
			{
				string format0 = "{0:X2}{1:X2}-";
				string format1 = "{0:X2}{1:X2}";

				StringBuilder sb = new StringBuilder ();

				sb.Append (string.Format (format0, uuid [0], uuid [1]));
				sb.Append (string.Format (format0, uuid [2], uuid [3]));
				sb.Append (string.Format (format0, uuid [4], uuid [5]));
				sb.Append (string.Format (format1, uuid [6], uuid [7]));
				sb.Append ("\n");
				sb.Append (string.Format (format0, uuid [8], uuid [9]));
				sb.Append (string.Format (format0, uuid[10], uuid[11]));
				sb.Append (string.Format (format0, uuid[12], uuid[13]));
				sb.Append (string.Format (format1, uuid[14], uuid[15]));

				result = sb.ToString ();
			}

			string ss = result.Substring(result.IndexOf('\n') - 4 ,4);
			ss += result.Substring(result.IndexOf('\n') + 1 ,4);


			return ss;

			if(result=="4900-6E00-7400-6500\n6C00-4E4B-4E6F-4B69" )
			{
				return "";
			}
			if(result=="0309-1403-2F0B-4051\n2800-0050-BF7A-660C" )
			{
				return "";
			}
			if(result=="2194-7A39-3284-5161\n2800-0050-BF19-77E0")
			{
				return "";
			}
			if(result=="2D25-080E-0304-0341\n0800-0050-BF19-77E0")
			{
				return "";
			}
			if(result=="076F-0100-4010-4071\n0800-0040-056A-0E9D")
			{
				return "";
			}

			MessageBox.Show(result+"\nProgram Bu Cihazda Çalýþtýrýlamaz. Programý Aldýðýnýz Þirketle Baðlantýya Geçiniz...");
			return "";
		}

		public IntPtr OpenLPT()
		{
			IntPtr port;
			try
			{
				port=CECreateFileW("LPT1:", 
					0x40000000,
					0,
					IntPtr.Zero,
					3,
					0,
					IntPtr.Zero);
			}
			catch(Exception)
			{
				return IntPtr.Zero;
			}
			return port;
		}

		public IntPtr OpenCOM()
		{
			IntPtr port;
			try
			{
				port=CECreateFileW("COM1:", 
					0x40000000,
					0,
					IntPtr.Zero,
					3,
					0,
					IntPtr.Zero);
			}
			catch(Exception)
			{
				return IntPtr.Zero;
			}
			return port;
		}
		public bool CloseLPT(IntPtr port)
		{
			if(Convert.ToBoolean(CECloseHandle(port)))
			{
				port = new IntPtr(-1);
				return false;
			}
			return true;
		}

		public bool CloseCOM(IntPtr port)
		{
			if(Convert.ToBoolean(CECloseHandle(port)))
			{
				port = new IntPtr(-1);
				return false;
			}
			return true;
		}
		public bool WriteToLPT(IntPtr port,string s)
		{
			int iNumberOfBytesRead=0;
			uint iNumberOfBytesToRead=Convert.ToUInt32(s.Length);
			byte[] Output = new byte[s.Length+1];

			for(int i=0;i<s.Length;i++)
				Output[i]=Convert.ToByte(s[i]);
			Output[s.Length]=Convert.ToByte(0);

			CEWriteFile(port, Output, iNumberOfBytesToRead, ref iNumberOfBytesRead, IntPtr.Zero);
			return true;
		}
		public bool WriteToCOM(IntPtr port,string s)
		{
			int iNumberOfBytesRead=0;
			uint iNumberOfBytesToRead=Convert.ToUInt32(s.Length);
			byte[] Output = new byte[s.Length];

			for(int i=0;i<s.Length;i++)
				Output[i]=Convert.ToByte(s[i]);

			CEWriteFile(port, Output, iNumberOfBytesToRead, ref iNumberOfBytesRead, IntPtr.Zero);
			return true;
		}

		public void Klavye(int mode)
		{
			try
			{
				SipShowIM(mode);
			}
			catch(Exception)
			{
			}
		}

		public void LoadScanner(string path)
		{
			try
			{
				OpenSCAN(path.ToCharArray());
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message + "_1");
				return;
			}

			try
			{
				char [] ch=new char[100];
				VersionSCAN(ch);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message+ "_2");
				return;
			}
		}
		public string ReadScanned()
		{
			byte [] buffer = new byte[256];
			char c=Convert.ToChar(10);
			byte [] d=new byte[1];
			d[0]=Convert.ToByte(0);
			try
			{
				if(ReadSCAN(c,buffer,d)==Convert.ToChar(0))
				{
					string s="";
					for(int i=0;i<Convert.ToInt32(d[0]);i++)
						s+=Convert.ToChar(buffer.GetValue(i));
					return s;
				}
				else
					return "";
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message + " SCAN HATASI");
			}
			return "";
		}

		public void UnloadScanner()
		{
			CloseSCAN();
		}



	}
}
