using System;

namespace Eventos1
{
    class Program
    {
        public static void Notificarmultiplo(int msg)
        {
            //imprimos mensaje aviso.
            Console.WriteLine("Es multiplo de 4!");
            Console.WriteLine(msg);
        }

        public static void Main(string[] args)
        {
           multiplo Mimultiplo = new multiplo("Ramiro");
            Mimultiplo.multiploes +=Notificarmultiploes; //suscribiendo
            Console.Write("el numero es ");
            MiEmpleado.setNombre(Console.ReadLine());

            Console.Write("Pulsa cualquier tecla para continuar . . . ");
            Console.ReadKey(true);
        }
    }
}
