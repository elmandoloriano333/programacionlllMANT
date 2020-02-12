using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = "", a2 = "";
            Console.WriteLine("Escribe la frase a invertir ");
            a1 = Console.ReadLine();
            for (int i = a1.Length - 1; i >= 0; i--)

            {
                a2 += a1[i];
            }
            Console.WriteLine("frase invertida " + a2);
            Console.ReadKey();
        }
    }
}
