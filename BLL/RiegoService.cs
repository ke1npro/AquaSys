using DAL;
using Entidad;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class RiegoService
    {
        private static RiegoRepository riegoRepository = new RiegoRepository(Utils.ARC_RIEGO);
        private static List<Riego> lista= riegoRepository.ObtenerTodo();
        
            
         

        public static string Agregar(Riego entidad)
        {
            //validar
            entidad.Id = obtenerUltimoIdMasUno();
            return riegoRepository.Agregar(entidad);
        }

        private static int obtenerUltimoIdMasUno(){

            if (lista == null) { 
                return 1;
            }else{
                int count = lista.Count;
                int consecutivo =(lista.ElementAt(0).Id)+1;
                return consecutivo;
            }
        }

        public static string Guardar()
        {
            return riegoRepository.Guardar();
        }

        public static ReadOnlyCollection<Riego> ObtenerTodo()
        {
            riegoRepository.ObtenerTodo();
            ReadOnlyCollection<Riego> ROC = new ReadOnlyCollection<Riego>(lista);
            return ROC;
        }
    }
}
