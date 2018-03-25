using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable 4014

namespace WinFLIF
{
    public static class ConvertProvider
    {
        private const string SaveDir = "WinFLIF_output";

        public static async Task Convert(ProgressBar progress, string[] paths)
        {
            const int step = 10;

            progress.Maximum = paths.Length * step - step;
            progress.Value = 0;

            var flifConverter = new FlifConverter();

            if (!Directory.Exists(SaveDir))
            {
                Directory.CreateDirectory(SaveDir);
            }

            var cores = Environment.ProcessorCount;
            int[] usedCores = {0};
            int[] finished = {0};
            
            foreach (var path in paths)
            {
                UpdateProgress(progress, step, finished[0]);

                while (usedCores[0] >= cores)
                {
                    UpdateProgress(progress, step, finished[0]);
                    await Task.Delay(50);
                }

                if (!File.Exists(path))
                {
                    finished[0]++;
                    continue;
                }

                if (IsFlif(path))
                {
                    usedCores[0]++;

                    Task.Run(() =>
                    {
                        var png = flifConverter.FlifToPng(path);
                        Move(png, path, SaveDir);

                        finished[0]++;
                        usedCores[0]--;
                    });
                }

                if (IsPng(path))
                {
                    usedCores[0]++;

                    Task.Run(() =>
                    {
                        var flif = flifConverter.PngToFlif(path);
                        Move(flif, path, SaveDir);

                        finished[0]++;
                        usedCores[0]--;
                    });
                }
            }

            while (usedCores[0] > 0)
            {
                UpdateProgress(progress, step, finished[0]);
                await Task.Delay(50);
            }

            var myPath = Process.GetCurrentProcess().MainModule.FileName;
            var myDir = Path.GetDirectoryName(myPath);
            Process.Start(Path.Combine(myDir, SaveDir));
        }

        private static void Move(string inputPath, string originalPath, string targetDir)
        {
            var originalFileName = Path.GetFileNameWithoutExtension(originalPath);
            var inputExtension = Path.GetExtension(inputPath);
            var targetPath = Path.Combine(targetDir, originalFileName + inputExtension);

            var index = 1;

            while (File.Exists(targetPath))
            {
                targetPath = Path.Combine(targetDir, originalFileName + $" ({index++})" + inputExtension);
            }

            File.Move(inputPath, targetPath);
        }

        private static void UpdateProgress(ProgressBar progress, int step, int value)
        {
            var newValue = value * step;
            if (newValue <= progress.Maximum)
            {
                progress.Value = newValue;
            }
        }

        private static bool IsFlif(string filename)
        {
            var extension = Path.GetExtension(filename);
            return extension == ".flif";
        }

        private static bool IsPng(string filename)
        {
            var extension = Path.GetExtension(filename);
            return extension == ".png";
        }

        private static void Message(string title, string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
    }
}
