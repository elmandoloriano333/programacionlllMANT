using System;
using System.Collections.Generic;
using System.Text;

namespace exaamen_progra_3_segundo_parcial_ejer_3
{
    class compuesto:Farmaciaabstracta
    {
        List<Farmaciaabstracta> ingredientes;
        double suma;
        public compuesto(string nombre, double suma)
        {
            ingredientes = new List<Farmaciaabstracta>();
            this.nombre = nombre;
            this.suma = suma;
        }
        public void ingresarIngredientes(Farmaciaabstracta p)
        {
            ingredientes.Add(p);
        }

        public double getDescuento()
        {
            return suma;
        }
        public override double getPrecio()
        {
            double aux = 0;
            foreach (Farmaciaabstracta elemento in ingredientes)
            {
                aux += elemento.getPrecio();
            }
            aux = suma;
            return aux;
        }
    }
}
