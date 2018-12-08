using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;

namespace DevPoint.OnedriveForceSync.src
{
    internal class ShortcutUtil
    {
        /// <summary>
        /// Create Shortcut and copy it to desktop
        /// </summary>
        public static void CreateShortcut()
        {
            var exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var iconPath = $@"{System.IO.Path.GetDirectoryName(exePath)}\resources\forceSync.ico";
            var deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var linkPath = $@"{deskDir}\OnedriveForceSync.lnk";
            WshShell wsh = new WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(linkPath) as IWshRuntimeLibrary.IWshShortcut;
            shortcut.Arguments = "--nogui";
            shortcut.TargetPath = exePath;
            // not sure about what this is for
            shortcut.WindowStyle = 1;
            shortcut.Description = "Force Sync";
            shortcut.WorkingDirectory = System.IO.Path.GetFullPath(exePath);
            shortcut.IconLocation = iconPath;
            shortcut.Save();
        }
    }
}