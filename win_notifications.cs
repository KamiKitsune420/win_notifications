using System;
using System.IO;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;
using System.Runtime.InteropServices;

namespace Notifier
{
    class Win_notifications
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: notifier.exe \"Title\" \"Message\"");
                return;
            }

            string title = args[0];
            string message = args[1];

            // Get the filename of this exe (without the .exe extension)
            string exeName = Path.GetFileNameWithoutExtension(
                System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName
            );

            // Set AppUserModelID to the executable name (dynamic title in toast)
            NativeMethods.SetCurrentProcessExplicitAppUserModelID(exeName);

            new ToastContentBuilder()
                .AddText(title)
                .AddText(message)
                .Show();
        }

        internal static class NativeMethods
        {
            [DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern int SetCurrentProcessExplicitAppUserModelID(string AppID);
        }
    }
}
