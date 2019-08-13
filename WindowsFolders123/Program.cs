using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFolder123_Objetos;

namespace WindowsFolders123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Creando Directorios--");
            AdministracionCarpetas.CrearDirectorioRaiz("C");

            AdministracionCarpetas.CrearSubdirectorio("Carpeta", "C");
            AdministracionCarpetas.CrearSubdirectorio("Subcarpeta", "Carpeta");
            AdministracionCarpetas.CrearArchivo("Archivo Prueba 1.txt", "Carpeta");
            AdministracionCarpetas.CrearArchivo("Archivo Prueba 2.txt", "Subcarpeta");
            AdministracionCarpetas.CrearArchivo("Archivo Prueba 3.txt", "Subcarpeta");

            AdministracionCarpetas.CrearSubdirectorio("Windows", "C");
            AdministracionCarpetas.CrearSubdirectorio("Program Files", "C");
            AdministracionCarpetas.CrearSubdirectorio("Users", "C");
            AdministracionCarpetas.CrearSubdirectorio("Code", "C");

            AdministracionCarpetas.CrearSubdirectorio("System32", "Windows");

            AdministracionCarpetas.CrearArchivo("host.config", "System32");
            AdministracionCarpetas.CrearArchivo("local.config", "System32");
            AdministracionCarpetas.CrearArchivo("web.config", "System32");

            AdministracionCarpetas.CrearArchivo("Juan.txt", "Users");
            AdministracionCarpetas.CrearArchivo("Pedro.txt", "Users");

            AdministracionCarpetas.CrearArchivo("Programa.sql", "Code");

            AdministracionCarpetas.MostrarExtructura(AdministracionCarpetas.Raiz, 0);

            Console.WriteLine("--Presiona una tecla...--");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("--Mostrar SubCarpetas--");
            Console.WriteLine();
            Console.WriteLine("--SubCarpetas de Windows--");
            Directorio d1 = AdministracionCarpetas.ObtenerDirectorio(AdministracionCarpetas.Raiz, "Windows");
            AdministracionCarpetas.MostrarCarpetas(d1, 0);
            Console.WriteLine();
            Console.WriteLine("--SubCarpetas de Users--");
            Directorio d2 = AdministracionCarpetas.ObtenerDirectorio(AdministracionCarpetas.Raiz, "Users");
            AdministracionCarpetas.MostrarCarpetas(d2, 0);
            Console.WriteLine();
            Console.WriteLine("--SubCarpetas de C--");
            Directorio d3 = AdministracionCarpetas.ObtenerDirectorio(AdministracionCarpetas.Raiz, "C");
            AdministracionCarpetas.MostrarCarpetas(d3, 0);

            Console.WriteLine("--Presiona una tecla...--");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("--Mostrar Archivos--");
            Console.WriteLine();
            Console.WriteLine("--Archivos de Windows--");
            Directorio da1 = AdministracionCarpetas.ObtenerDirectorio(AdministracionCarpetas.Raiz, "Windows");
            AdministracionCarpetas.MostrarArchivos(da1);
            Console.WriteLine();
            Console.WriteLine("--Archivos de System32--");
            Directorio da2 = AdministracionCarpetas.ObtenerDirectorio(AdministracionCarpetas.Raiz, "System32");
            AdministracionCarpetas.MostrarArchivos(da2);
            Console.WriteLine();
            Console.WriteLine("--Archivos de Users--");
            Directorio da3 = AdministracionCarpetas.ObtenerDirectorio(AdministracionCarpetas.Raiz, "Users");
            AdministracionCarpetas.MostrarArchivos(da3);

            Console.WriteLine("--Presiona una tecla...--");
            Console.ReadKey();
        }
    }
}
