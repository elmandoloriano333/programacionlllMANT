using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, num = 0;
            Console.WriteLine("Cuantos numeros va ingresar");
            int numeros = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Digite un numero: ");
                num = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    a = num;
                    b = num;
                }
                if (num > a) { a = num; }

                num = 0;
            }

            Console.WriteLine(" numero mayor es: " + a);

            Console.ReadKey();
        }
    }
}
