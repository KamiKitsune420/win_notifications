using System;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;
using System.Runtime.InteropServices;
namespace Notifier
{
    class Program
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
            // Set a unique AppUserModelID
            string appId = "NVGT.NotifierApp";
            NativeMethods.SetCurrentProcessExplicitAppUserModelID(appId);
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
