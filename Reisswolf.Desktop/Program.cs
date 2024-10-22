using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reisswolf.Desktop
{
    internal static class Program
    {
        public static bool ValidLogin = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("tr-TR");
            Application.CurrentCulture = cultureInfo;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            //if (ValidLogin)
            //{
            //    var df = new Dashboard();
            //    df.Show();
            //    //Application.Run(new Dashboard());
            //}
        }
    }
}
