﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFLIF.Properties;

namespace WinFLIF
{
    public class FlifConverter
    {
        private readonly string binary = Path.Combine(Path.GetTempPath(), "flif.exe");

        public FlifConverter()
        {
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
            
            var flifPath = PathProvider.GetTmpPath("flif");
            
            var convertInfo = new ProcessStartInfo(this.binary, $"-E{effort} -Q{quality} \"{pngPath}\" \"{flifPath}\"")
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
            var pngPath = PathProvider.GetTmpPath("png");

            var convertInfo = new ProcessStartInfo(this.binary, $"\"{flifPath}\" \"{pngPath}\"")
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
