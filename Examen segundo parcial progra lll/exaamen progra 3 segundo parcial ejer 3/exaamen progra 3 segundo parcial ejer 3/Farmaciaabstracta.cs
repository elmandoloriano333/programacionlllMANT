using System;
using System.Collections.Generic;
using System.Text;

namespace exaamen_progra_3_segundo_parcial_ejer_3
{
    abstract class Farmaciaabstracta
    {
        protected string nombre;
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string n)
        {
            nombre = n;
        }
        public abstract double getPrecio();
    }
}
