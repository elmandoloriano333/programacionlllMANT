using Pila_de_Libros;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMEN_PROGRA_3_SEGUNDO_PARCIAL
{
    class Novela : Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        Genero genero;

        public Novela(string titulo, string autor, Genero genero)
        {
            Titulo = titulo;
            Autor =autor;
            this.genero = genero;

        }

    }
    enum Genero
    {
        accion , romance, terror
    }
}
