using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SrBolo_Prototype1.View;
using System.Globalization;

namespace SrBolo_Prototype1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);
            Application.Run(new Splash());
            
        }
    }
}
