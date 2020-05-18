using System;

namespace exaamen_progra_3_segundo_parcial_ejer_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Farmacia Paracetamol = new Farmacia("Paracetamol", 2);
            Farmacia Mentisan = new Farmacia("Mentisan", 3);
            Farmacia Digestan = new Farmacia("Digestan", 4);
       





            compuesto tiradeparacetamol = new compuesto("tira de paracetamol de 10 unidames", (10*2));
           tiradeparacetamol.ingresarIngredientes(Paracetamol);
           
            compuesto cajadementisan = new compuesto("cajadementisan de 5 unidades", (5*3));
            cajadementisan.ingresarIngredientes(Mentisan);
            

            compuesto paquetededisgestan = new compuesto("paquetededigestan de 5 unidades", (5*4));
            paquetededisgestan.ingresarIngredientes(Digestan);


            
            Console.WriteLine("la tira paracetamols  de 10 unidades cuesta  " + tiradeparacetamol.getPrecio());
            tiradeparacetamol.ingresarIngredientes(Paracetamol);
            Console.WriteLine("la caja mentisanes de 5 unidades cuesta" + cajadementisan.getPrecio());
            Console.WriteLine("el paquete digestanes de 5 unidades  cuesta " + paquetededisgestan.getPrecio());
           

            Console.ReadKey();
        }
    }
}
