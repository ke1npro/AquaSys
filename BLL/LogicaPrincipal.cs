using Entidad;
using Simulacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL
{
    public static class LogicaPrincipal
    {
        


        public static float HumedadActual;
        private static float TiempoRiego=120; //segundos
        private static float EsperaRiego=60*60*24; //24h en segundos 
        private static int TiempoElapsado;
        private static float UmbralHumedad;
        private static float HumedadMinima;
        private static float HumedadMaxima;
        private static bool RegandoPorEvento;
        private static DateTime InicioRiego;
        private static DateTime FinRiego;
        public static bool RegarActivo = false;
        public static bool EstaRegando=false;
        public static async void CicloPrincipal()
        {
            
            while (true)
            {
                if (!RegarActivo)
                {
                    await Task.Delay(10000);
                    TiempoElapsado += 10;
                    Console.WriteLine("RIEGO DESACTIVADO!!!");
                    continue;
                }
                EstaRegando = Simular.regando;
                HumedadActual = Simular.HumedadPorc;
                VerificarEstado();
                if (RegandoPorEvento)
                {
                    if (HumedadActual > HumedadMaxima)
                    {
                        DetenerRiego();
                        RegandoPorEvento = false;
                    }
                }
                if(TiempoElapsado>=EsperaRiego)
                {
                    Regar(true);
                    TiempoElapsado = 0;
                }


                await Task.Delay(1000);
                TiempoElapsado += 1;
            
            }
        }




        private static void VerificarEstado()
        {
            //En caso tal de que este muy por debajo de la humedad minima
            if ((HumedadMinima - HumedadActual) > UmbralHumedad)
            {
                Regar(false);
                TiempoRiego *=1.05f;
                RegandoPorEvento = true;
                Console.WriteLine("Regando por humedad baja");
            }
            //En caso tal que exceda mucho la humedad máxima
            if (EstaRegando)
            {
                if ((HumedadActual - HumedadMaxima) > UmbralHumedad)
                {
                    TiempoRiego *= 0.98f;
                    DetenerRiego();
                }
            }


        }

        

        private static async Task Regar(bool temporizado)
        {
            if (temporizado)
            {
                Console.WriteLine("Inicio riego temporizado");
                IniciarRiego();
                await Task.Delay((int)(TiempoRiego * 1000));
                DetenerRiego();
            }
            else
            {
                IniciarRiego(); 
            }
        }

        private static void IniciarRiego()
        {
            InicioRiego = DateTime.Now;
            Simular.Regar();
        }
        
        private static void DetenerRiego()
        {
            Console.WriteLine("Deteniendo riego");
            Simular.DetenerRiego();
            FinRiego = DateTime.Now;
            TimeSpan aux = FinRiego - InicioRiego;

            Riego riego = new Riego();
            riego.Fecha = InicioRiego;
            riego.Tiempo = aux.Seconds;

            RiegoService.Agregar(riego);
            
        }

        public static string EstablecerUmbral(float minimo, float maximo, float umbral)
        {
            HumedadMinima=minimo;
            HumedadMaxima=maximo;
            UmbralHumedad = umbral;
            return "Se ha cambiado los umbrales de humedad exitosamente";
        }

        
        public static string ModificarRiegoManual(int tiempo, int espera)
        {
            TiempoRiego = tiempo;
            EsperaRiego = espera;
            return "Se ha modificado el tiempo de riego exitosamente";
        }


    }
}
