using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PANADERIA
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

            // Mostrar el formulario de login primero
            using (Form1 login = new Form1())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Si el login fue exitoso, abrir el menú principal
                    Application.Run(new Form3());
                }
            }
        }
    }
}
