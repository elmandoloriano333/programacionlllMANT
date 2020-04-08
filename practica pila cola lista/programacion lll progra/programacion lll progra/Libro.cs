using System;
using System.Collections.Generic;
using System.Text;

namespace Pila
{
    class Libro
    {
        public Libro(string titulo, string autor, string editorial, int añodepublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Añodepublicacion = añodepublicacion;

        }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int  Añodepublicacion { get; set; }
         override public string ToString  ()
        {
            return Titulo+"  "+Autor+ " " + Editorial+ " " + Añodepublicacion;
        }
    }
}
