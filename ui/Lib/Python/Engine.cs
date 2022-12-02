using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SeoulTransportationData.Lib.Python
{
    /// <summary>
    /// Python 스크립트를 구동시킬 클래스입니다.
    /// </summary>
    class Engine : IDisposable
    {
        #region Public Variables
        Thread _worker = null;
        Process proc = null;

        public StringBuilder Output { get; set; } = new StringBuilder(null);
        #endregion

        public void Dispose()
        {
        }

        /// <summary>
        /// Python의 버전을 반환합니다.
        /// </summary>
        public string GetVersion()
        {
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                FileName = "python.exe",
                Arguments = "--version"
            };
            proc.Start();

            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
            proc.Dispose();

            return output; 
        }

        /// <summary>
        /// Python 쓰레드의 실행 상태를 반환합니다.
        /// </summary>
        public bool IsRunning()
        {
            if (_worker != null && _worker.IsAlive)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Python 쓰레드를 종료시킵니다.
        /// </summary>
        public void Quit()
        {
            if (IsRunning())
            {
                _worker.Abort();
            }
        }

        /// <summary>
        /// Python 쓰레드를 실행시켜 특정 스크립트 파일을 실행합니다.
        /// </summary>
        /// <param name="scriptFilePath">파이썬 스크립트 파일(.py)입니다.</param>
        public void Run(string scriptFilePath)
        {
            if (!File.Exists(scriptFilePath))
            {
                Program.ShowMsgbox($"불러오고자 하는 파이썬 스크립트 파일이 존재하지 않습니다.\n\n{scriptFilePath}", "오류");
            }

            string dirPath = Path.GetDirectoryName(scriptFilePath);
            string filePath = Path.GetFileName(scriptFilePath);

            if (IsRunning())
            {
                Quit();
            }
            Output.Clear();

            _worker = new Thread(() =>
            {
                ExecuteScript(scriptFilePath);

                using (StreamReader reader = proc.StandardOutput)
                {
                    while (!proc.StandardOutput.EndOfStream)
                    {
                        Output.AppendLine(reader.ReadLine());
                    }

                    proc.WaitForExit();
                }

            });

            _worker.IsBackground = true;
            _worker.Start();

        }


        /// <summary>
        /// Python 모듈을 실행합니다.
        /// </summary>
        private void ExecuteScript(string scriptFilePath)
        {
            string dirPath = Path.GetDirectoryName(scriptFilePath);
            string filePath = Path.GetFileName(scriptFilePath);

            ProcessStartInfo procInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c cd \"{dirPath}\"&python.exe \"{filePath}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                Verb = "runas"
            };

            proc = new Process();
            proc.StartInfo = procInfo;
            proc.Start();
        }

    }
}
