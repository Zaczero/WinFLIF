using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFLIF
{
    public static class PathProvider
    {
        private static readonly Random Rng = new Random();

        public static string GetFileName(int length = 8)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                sb.Append((char) Rng.Next(0x61, 0x7A + 1));
            }

            return sb.ToString();
        }

        public static string GetTmpPath(string extension = "tmp")
        {
            var tmpDir = Path.GetTempPath();
            var tmpFilename = GetFileName();

            return Path.Combine(tmpDir, "WinFLIF_" + tmpFilename + "." + extension);
        }
    }
}
