using DAL;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ParametroService
    {
        ParametroRepository parametroRepository;
        public ParametroService() 
        {
            parametroRepository = new ParametroRepository(Utils.ARC_PARAMETRO);
        }
        
        public string Guardar(Parametros parametro)
        {
            //validacion
            return parametroRepository.Guardar(parametro);
        }
        public Parametros Obtener()
        {
            return parametroRepository.Obtener();
        }


    }
}
