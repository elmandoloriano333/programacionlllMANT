using Pila_de_Libros;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EXAMEN_PROGRA_3_SEGUNDO_PARCIAL
{
    class Enciclopedia:Libro
    {
        public Enciclopedia (string nombre, string editorail , string tema)
        {
            Nombre = nombre;
            Editorial = editorail;
            Tema = tema;
        }
        public string Nombre { get; set; }
        public string Editorial { get; set; }
        public string Tema { get; set; }
        public override string ToString()
        {
            return Nombre + "" + Editorial + "" + Tema + "";
        }
    }
}
