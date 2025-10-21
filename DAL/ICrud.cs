using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICrud<T>
    {
        string Guardar();
        string Agregar(T entity);
        List<T> ObtenerTodo();
    }
}
