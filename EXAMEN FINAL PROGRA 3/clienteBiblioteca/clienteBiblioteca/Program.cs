using ClienteSincrono;
using System;

namespace Examen_final_prograBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            int o;
            int opcion = 0;





            do
            {
                Console.WriteLine("1. Iniciar");
                Console.WriteLine("1. Ingresar");

                Console.WriteLine("3. mostrar");

              


                opcion = int.Parse(Console.ReadLine());


                string a;


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca titulo de llibro");
                        String titulodellibro = Console.ReadLine();
                 

                        Console.WriteLine("Introduzca autor");
                        String autor = Console.ReadLine();


                        Console.WriteLine("introduzca editorial");
                        int editorial= int.Parse(Console.ReadLine());

                        a = ClienteSincrono.GetInstancia().lista(titulodellibro, autor, editorial);
                        Console.ReadKey();
                        break;
                    case 2:
                        break;
                    case 3:

                        break;

                }

            } while (opcion != 4);

        }
    }