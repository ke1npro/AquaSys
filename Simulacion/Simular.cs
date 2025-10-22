using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simulacion
{
    public static class Simular
    {

        public static float HumedadPorc=80;
        public static bool regando = false;

        public static async void Temporizador()
        {
            while (true)
            {
                if (regando)
                {
                    HumedadPorc += 0.5f;
                }
                else
                {
                    HumedadPorc -=0.1f;
                }

                await Task.Delay(100);
            }
        }

        public static string Regar()
        {
            regando = true;
            return "Ha iniciado el riego correctamente";
        }

        public static string DetenerRiego()
        {
            regando = false;
            return "Se ha ddetenido el riego";
        }

        public static float ObtenerHumedad()
        {
            return HumedadPorc;
        }
    }
}
