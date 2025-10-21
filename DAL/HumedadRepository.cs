using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HumedadRepository
    {
        string ruta;
        public HumedadRepository(string ruta) 
        { 
            this.ruta = ruta;
            if (!File.Exists(ruta))
            {
                File.Create(ruta).Close();
            }
        }
        public string Guardar(List<Humedad> lista)
        {
            StreamWriter sw = new StreamWriter(ruta);
            using (sw)
            {
                foreach (Humedad humedad in lista)
                {
                    sw.WriteLine(humedad.ToString());
                }
                return "Se ha guardado todo en memoria exitosamente";
            }

        }
        public List<Humedad> Obtener()
        {
            List<Humedad> lista=new List<Humedad>();
            StreamReader sr = new StreamReader(ruta);
            using (sr)
            {
                while (!sr.EndOfStream)
                {
                    lista.Add(Mappear(sr.ReadLine()));
                }
                return lista;
            }
        }

        private Humedad Mappear(string v)
        {
            Humedad humedad = new Humedad();
            var aux = v.Split(';');
            DateTime fecha=DateTime.ParseExact(aux[0],"yyyy-MM-dd HH-mm",null);
            float porc = float.Parse(aux[1]);

            humedad.Fecha = fecha;
            humedad.Porcentaje = porc;
            return humedad;
        }
    }
}
