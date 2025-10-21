using BLL;
using Simulacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Thread hiloSimular = new Thread(SimularThread);
            Thread hiloLogica = new Thread(LogicaThread);

            // Iniciar los hilos
            hiloSimular.Start();
            hiloLogica.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());    

        }
        private static void SimularThread()
        {
            Simulacion.Simular.Temporizador();
        }

        private static void LogicaThread()
        {
            BLL.LogicaPrincipal.CicloPrincipal();
        }
    }
}
