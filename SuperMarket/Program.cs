using System;
using System.Windows.Forms;

namespace SuperMarket
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash()); // we change the object from From1 to splash to start from it
        }
    }
}
