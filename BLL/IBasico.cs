using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IBasico<T>
    {
        string Agregar(T entidad);
        string Guardar();
        ReadOnlyCollection<T> ObtenerTodo();
    }
}
