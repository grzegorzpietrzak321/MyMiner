using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace MyMiner
{
    class ProcessManager
    {
        [STAThread]
        public static void StartTask(string miner, string param)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = miner,
                Arguments = param
            };

            try
            {
                Process.Start(startInfo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void EndTask()
        {
            var names = new[] { "EthDcrMiner64", "miner", "gominer" };

            foreach (var name in names)
            {
                var proccesses = Process.GetProcesses().Where(pr => pr.ProcessName == name);
                foreach (var process in proccesses)
                {
                    process.Kill();
                }
            }
        }
    }
}
