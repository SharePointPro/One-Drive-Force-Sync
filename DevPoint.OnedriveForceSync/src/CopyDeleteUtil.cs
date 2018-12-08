using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPoint.OnedriveForceSync.src
{
    internal class CopyDeleteUtil
    {
        private static void CreateFile(string[] paths, string fileName)
        {
            foreach (var path in paths)
            {
                if (!string.IsNullOrWhiteSpace(path))
                {
                    try
                    {
                        System.IO.File.WriteAllText($@"{path}\{fileName}.dat", "_");
                    }
                    catch (Exception ex)
                    {
                        //To Do, add logging
                        Console.WriteLine("Error:" + ex.Message);
                    }
                }
            }
        }

        private static void DeleteFile(string[] paths, string fileName)
        {
            foreach (var path in paths)
            {
                if (!string.IsNullOrWhiteSpace(path))
                {
                    try
                    {
                        System.IO.File.Delete($@"{path}\{fileName}.dat");
                    }
                    catch (Exception ex)
                    {
                        //To Do, add logging
                        Console.WriteLine("Error:" + ex.Message);
                    }
                }
            }
        }

        public static void Execute()
        {
            var onedrivePaths = Properties.Settings.Default["OnedrivePaths"]?.ToString().Replace("\r", "");
            if (!string.IsNullOrWhiteSpace(onedrivePaths))
            {
                var fileName = Guid.NewGuid().ToString();
                var paths = onedrivePaths.Split('\n');
                CreateFile(paths, fileName);
                System.Threading.Thread.Sleep(2000);
                DeleteFile(paths, fileName);
            }
        }
    }
}