using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Core
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Lanzo el formulario de Login del Sistema
            var fLogin = new Login();
            fLogin.ShowDialog(); // Abrir el formulario

            // verifico si puede o no acceder
            if (fLogin.PuedeAcceder)
            {
                Application.Run(new Principal());
            }
            else
            {
                Application.Exit(); // Cierra la Aplicacion Completa
            }
        }
    }
}
