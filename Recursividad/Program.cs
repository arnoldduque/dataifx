using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir(1);

            Console.WriteLine("--Presiona una tecla...--");
            Console.ReadKey();
        }

        public static void Imprimir(int i)
        {
            if (i > 100)
                return;
            else
            {
                Console.WriteLine(i);
                Imprimir(i + 1);
            }
        }
    }
}
