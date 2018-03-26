using System;
using System.IO;

namespace WinFLIF
{
    public static class PathProvider
    {
        public static string GetAppDataDir()
        {
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dir = Path.Combine(appdata, "WinFLIF");

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public static string ChangeExtension(string input, string extension)
        {
            var dir = Path.GetDirectoryName(input);
            var filename = Path.GetFileNameWithoutExtension(input);

            return Path.Combine(dir, filename + "." + extension);
        }

        public static string GetSafePath(string input)
        {
            if (!File.Exists(input))
            {
                return input;
            }

            var index = 1;

            var dir = Path.GetDirectoryName(input);
            var filename = Path.GetFileNameWithoutExtension(input);
            var extension = Path.GetExtension(input);

            while (true)
            {
                var newPath = Path.Combine(dir, $"{filename} ({index++}){extension}");

                if (!File.Exists(newPath))
                {
                    return newPath;
                }
            }
        }
    }
}
