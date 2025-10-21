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
    public class PlantaService
    {
        List<Planta> lista;
        PlantaRepository plantaRepository;
        public PlantaService() {
            plantaRepository = new PlantaRepository(Utils.ARC_PLANTA);
            lista = plantaRepository.ObtenerTodo();
        }

        public string Agregar(Planta entidad)
        {
            //Validar
            string mensaje = plantaRepository.Agregar(entidad);
            return mensaje;
        }

        public string Guardar()
        {
            return plantaRepository.Guardar();
        }

        public List<Planta> ObtenerTodo()
        {
            return plantaRepository.ObtenerTodo();

           
        }
        public Planta ObtenerPorId(int id)
        {
            return plantaRepository.ObtenerPorId(id);
        }
        public string Eliminar(int id)
        {
            {
                return plantaRepository.Eliminar(id);
            }

        }
    }
}
