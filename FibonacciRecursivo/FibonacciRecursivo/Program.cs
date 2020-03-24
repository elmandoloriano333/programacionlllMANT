using System;

namespace FibonacciRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciRecursivo f = new FibonacciRecursivo();


            
            for (int num=0; num <=9; num++)
            {
                
                Console.WriteLine(f.fibonacci(num));
            }
            Console.ReadKey();
        }
    }
}
