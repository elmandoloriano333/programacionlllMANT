using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, a1, b1;
            Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
            a1 = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (int i = 0; i < a1; i++)
            {
                b1 = a;
                a = b;
                b = b1 + a;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
