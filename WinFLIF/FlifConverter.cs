using System;
using System.Diagnostics;
using System.IO;
using WinFLIF.Properties;

namespace WinFLIF
{
    public class FlifConverter
    {
        private readonly string binary;

        public FlifConverter()
        {
            var dir = PathProvider.GetAppDataDir();
            this.binary = Path.Combine(dir, "flif.exe");

            if (!File.Exists(this.binary))
            {
                File.WriteAllBytes(this.binary, Resources.flif);
            }
        }

        public string PngToFlif(string pngPath, int effort = 60, int quality = 100)
        {
            if (effort < 0 || effort > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(effort), effort, "Effort value must be between 0 and 100");
            }

            if (quality < 0 || quality > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(quality), quality, "Quality value must be between 0 and 100");
            }

            var flifPath = PathProvider.ChangeExtension(pngPath, "flif");
            flifPath = PathProvider.GetSafePath(flifPath);

            var convertInfo = new ProcessStartInfo(this.binary, $"-e -E{effort} -Q{quality} \"{pngPath}\" \"{flifPath}\"")
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            var convertProcess = Process.Start(convertInfo);
            convertProcess?.WaitForExit();

            return flifPath;
        }

        public string FlifToPng(string flifPath)
        {
            var pngPath = PathProvider.ChangeExtension(flifPath, "png");
            pngPath = PathProvider.GetSafePath(pngPath);

            var convertInfo = new ProcessStartInfo(this.binary, $"-d \"{flifPath}\" \"{pngPath}\"")
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            var convertProcess = Process.Start(convertInfo);
            convertProcess?.WaitForExit();

            return pngPath;
        }
    }
}
