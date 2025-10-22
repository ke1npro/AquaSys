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
    public static class HumedadService
    {
        
        public static HumedadRepository humedadRepository = new HumedadRepository(Utils.ARC_HUMEDAD);
        static List<Humedad> lista = humedadRepository.Obtener();
        const int MaximosRegistros = 10;
        


        public static void Agregar(Humedad humedad)
        {
            int count = lista.Count;
            if (count >= MaximosRegistros)
            {
                lista.RemoveAt(0);
                lista.Add(humedad);
                humedadRepository.Guardar(lista);
            }
            else
            {
                lista.Add(humedad);
                humedadRepository.Agregar(humedad);
            }
        }
 
        public static ReadOnlyCollection<Humedad> Obtener()
        {
            lista = humedadRepository.Obtener();
            ReadOnlyCollection<Humedad> ROC = new ReadOnlyCollection<Humedad>(lista);
            return ROC;
        }
    }
}
