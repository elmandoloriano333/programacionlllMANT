using System;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            Pila<Libro> p = new Pila<Libro>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca el Titulo");
                        String Titulo = Console.ReadLine();
                        Console.WriteLine("introduzca Autor");
                        String Autor = Console.ReadLine();
                        Console.WriteLine("introduzca editorial");
                        String Editorial = Console.ReadLine();
                        Console.WriteLine("introduzca Año de publicacion");
                        int Añodepublicacion = int.Parse(Console.ReadLine());

                        Libro x = new Libro( Titulo, Autor, Editorial, Añodepublicacion);
                        p.push(x);
                        break;
                    case 2:
                        Libro y = p.eliminar();
                        Console.WriteLine("El elemento eliminado es {0}", y.ToString());
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }

            }

        }
    }
}
