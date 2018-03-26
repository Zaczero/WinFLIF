using System;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable 4014

namespace WinFLIF
{
    public static class ConvertProvider
    {
        public static async Task Convert(ProgressBar progress, string[] paths)
        {
            const int step = 5;

            progress.Maximum = paths.Length * step;
            progress.Value = 0;

            var flifConverter = new FlifConverter();

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
                        flifConverter.FlifToPng(path);

                        finished[0]++;
                        usedCores[0]--;
                    });
                }

                if (IsPng(path))
                {
                    usedCores[0]++;

                    Task.Run(() =>
                    {
                        flifConverter.PngToFlif(path);

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

            UpdateProgress(progress, step, finished[0]);
            SystemSounds.Beep.Play();
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
    }
}
