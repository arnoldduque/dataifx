using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFolder123_Objetos;

namespace WindowsFolders123
{
    public class AdministracionCarpetas
    {
        public static Directorio Raiz { get; set; }

        public static void CrearDirectorioRaiz(string nombre)
        {
            Raiz = new Directorio(nombre);
        }

        public static Directorio ObtenerDirectorio(Directorio directorio, string directorioBusqueda)
        {
            if (directorio.Nombre == directorioBusqueda)
                return directorio;
            else if (directorio.Directorios.Count > 0)
                foreach (Directorio d in directorio.Directorios)
                {
                    Directorio retorno = ObtenerDirectorio(d, directorioBusqueda);
                    if (retorno != null)
                        return retorno;
                }
            return null;
        }

        public static void CrearSubdirectorio(string nombre, string directorioPadre)
        {
            Directorio padre = ObtenerDirectorio(Raiz, directorioPadre);

            if (padre != null)
                padre.Directorios.Add(new Directorio(nombre));
        }

        public static void CrearArchivo(string nombre, string directorio)
        {
            Directorio padre = ObtenerDirectorio(Raiz, directorio);

            if (padre != null)
                padre.Archivos.Add(new Archivo(nombre));
        }

        public static void MostrarExtructura(Directorio directorio, int i)
        {
            string tabuladores = "";
            for (int x = 0; x <= i; x++)
                tabuladores += " ";
            Console.WriteLine(tabuladores + "->" + directorio.Nombre);

            tabuladores = "";
            for (int x = 0; x <= i + directorio.Nombre.Length + 2; x++)
                tabuladores += " ";

            foreach (Archivo a in directorio.Archivos)
                Console.WriteLine(tabuladores + "->" + a.Nombre);

            foreach (Directorio d in directorio.Directorios)
                MostrarExtructura(d, i + directorio.Nombre.Length + 2);
        }

        public static void MostrarCarpetas(Directorio directorio, int i)
        {
            string tabuladores = "";
            for (int x = 0; x <= i; x++)
                tabuladores += " ";
            Console.WriteLine(tabuladores + "->" + directorio.Nombre);            

            foreach (Directorio d in directorio.Directorios)
                MostrarCarpetas(d, i + directorio.Nombre.Length + 2);
        }

        public static void MostrarArchivos(Directorio directorio)
        {
            foreach (Archivo a in directorio.Archivos)
                Console.WriteLine(a.Nombre);            
        }
    }
}
