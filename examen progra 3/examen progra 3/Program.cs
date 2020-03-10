using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_progra_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear un arreglo de int, double 
            int[] intArray = { 2, 3, 4 };
            double[] doubleArray = { 3.1, 4.6, 2.3 };
            int[] array2 = { -4, -3, 2, 6 };
            Console.WriteLine("intArray contiene:");
            int length1 = intArray.Length;


            for (int i = 0; i < length1; i++)
            {
                intArray[i] = intArray[i] ;
            }
            MuestraArreglo(intArray);
            Console.WriteLine("doubleArray contiene:");
            int length2 = intArray.Length;


            for (int i = 0; i < length2; i++)
            {
                doubleArray[i] = doubleArray[i] * doubleArray[i];
            }
            MuestraArreglo(doubleArray);
            Console.WriteLine("intArray contiene:");
            int length3 = intArray.Length;


            for (int i = 0; i < length3; i++)
            {
                array2[i] = array2[i] * array2[i];
            }
            MuestraArreglo(array2);
            Console.ReadKey();
        }
        // método genérico para mostrar un arreglo
        private static void MuestraArreglo<T>(T[] arreglo)
        {
            foreach (T elemento in arreglo)
                Console.Write(elemento + " ");
            Console.WriteLine("\n");
        }
    }
    
}
