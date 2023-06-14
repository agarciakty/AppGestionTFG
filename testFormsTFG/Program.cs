using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using testFormsTFG;

namespace AppGestionTFG
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Principal ppal = new Principal();
            Dashboard dash = new Dashboard();
            //Application.Run(ppal);


            /*if (ppal.user != "")
            {
                Application.Run(dash);
            }*/

            Application.Run(dash);
        }
    }
}
