using System;
using System.Diagnostics;
using System.IO;
using WinFLIF.Properties;

namespace WinFLIF
{
    public static class FlifConverter
    {
        public static readonly string FlifBinary;

        static FlifConverter()
        {
            var dir = PathProvider.GetAppDataDir();
            FlifBinary = Path.Combine(dir, "flif.exe");

            if (!File.Exists(FlifBinary))
            {
                File.WriteAllBytes(FlifBinary, Resources.flif);
            }
        }

        public static string PngToFlif(string pngPath, int effort, int quality, string arguments)
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

            var convertInfo = new ProcessStartInfo(FlifBinary, $"-e -E{effort} -Q{quality} {arguments} \"{pngPath}\" \"{flifPath}\"")
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            var convertProcess = Process.Start(convertInfo);
            convertProcess?.WaitForExit();

            return flifPath;
        }

        public static string FlifToPng(string flifPath)
        {
            var pngPath = PathProvider.ChangeExtension(flifPath, "png");
            pngPath = PathProvider.GetSafePath(pngPath);

            var convertInfo = new ProcessStartInfo(FlifBinary, $"-d \"{flifPath}\" \"{pngPath}\"")
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
