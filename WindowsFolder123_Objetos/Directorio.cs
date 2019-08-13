using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFolder123_Objetos
{
    public class Directorio
    {
        public string Nombre { get; set; }

        public List<Directorio> Directorios { get; set; }
        public List<Archivo> Archivos { get; set; }

        public Directorio(string nombre)
        {
            Nombre = nombre;
            Directorios = new List<Directorio>();
            Archivos = new List<Archivo>();
        }
    }
}
