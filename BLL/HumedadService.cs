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
    public class HumedadService
    {
        List<Humedad> lista;
        HumedadRepository humedadRepository;
        const int MaximosRegistros = 120;
        public HumedadService()
        {
            humedadRepository = new HumedadRepository(Utils.ARC_HUMEDAD);
            lista = humedadRepository.Obtener();
        }


        public void Agregar(Humedad humedad)
        {
            int count = lista.Count;
            if (count >= MaximosRegistros)
            {
                lista.RemoveAt(0);
                lista.Add(humedad);
                Guardar();
            }
        }

        public string Guardar()
        {
            return humedadRepository.Guardar(lista);
        }
        public ReadOnlyCollection<Humedad> Obtener()
        {
            lista = humedadRepository.Obtener();
            ReadOnlyCollection<Humedad> ROC = new ReadOnlyCollection<Humedad>(lista);
            return ROC;
        }
    }
}
