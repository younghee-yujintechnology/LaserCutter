using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using DaekhonSystem;

namespace LaserCutter
{
    static class Program
    {
        private static Mutex hMutex = null;

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            if (ExistPrevInstance())
            {
                // 실행 중인 이전 인스턴스를 종료
                KillPrevInstance();

                Application.Restart();
                return;
            }

            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmMain());

            // 프로그램이 종료될 때 뮤텍스를 해제합니다.
            if (hMutex != null)
            {
                hMutex.ReleaseMutex();
            }
        }

        private static bool ExistPrevInstance()
        {
            bool createdNew = false;
            hMutex = new Mutex(true, "DaekhonCorporation.System.LaserCutter", out createdNew);

            if (!createdNew)
            {
                return true; // 기존 인스턴스 존재
            }

            return false; // 기존 인스턴스 없음
        }

        private static void KillPrevInstance()
        {
            string currentProcessName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            var processes = Process.GetProcessesByName(currentProcessName);

            foreach (var process in processes)
            {
                if (process.Id != Process.GetCurrentProcess().Id) // 현재 프로세스는 제외
                {
                    try
                    {
                        process.Kill(); // 이전 인스턴스 강제 종료
                        process.WaitForExit(); // 종료 대기
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"이전 인스턴스를 종료하지 못했습니다: {ex.Message}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            //We dont' care about System Assembies and so on...
            //if (!args.Name.ToLower().StartsWith("Test")) return null;

            var thisAssembly = Assembly.GetExecutingAssembly();

            //Get the Name of the AssemblyFile
            var name = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";

            //Load form Embedded Resources - This Function is not called if the Assembly is in the Application Folder
            var resources = thisAssembly.GetManifestResourceNames().Where(s => s.EndsWith(name));
            if (resources.Count() > 0)
            {
                var resourceName = resources.First();
                using (Stream stream = thisAssembly.GetManifestResourceStream(resourceName))
                {
                    if (stream == null) return null;
                    var block = new byte[stream.Length];
                    stream.Read(block, 0, block.Length);
                    return Assembly.Load(block);
                }
            }
            return null;
        }

        public static System.Windows.Forms.DialogResult Warning(string MessageBoxText, string Caption)
        {
            return System.Windows.Forms.MessageBox.Show(MessageBoxText, Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
