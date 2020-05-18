using Pila_de_Libros;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EXAMEN_PROGRA_3_SEGUNDO_PARCIAL
{
    class Revista : Libro
    {
        public Revista(string titulo, int nmrpagina)
        {
            Titulo = titulo;
            Nmrpagina = nmrpagina;
        }

        public string Titulo { get; set; }
        public string Autor { get; set; }

        public string  Editorial {get;set;}
        public int Nmrpagina { get; set; }
        public override string ToString()
        {
            return Titulo + "" + Nmrpagina + "";
        }
    }
}
