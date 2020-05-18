using System;
using System.Collections.Generic;
using System.Text;

namespace exaamen_progra_3_segundo_parcial_ejer_3
{
    class Farmacia:Farmaciaabstracta
    {
        double precio;
        string nombre;
        public Farmacia(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public override double getPrecio()
        {
            return precio;
        }
        public void setPrecio(double p)
        {
            precio = p;
        }
    }
}
