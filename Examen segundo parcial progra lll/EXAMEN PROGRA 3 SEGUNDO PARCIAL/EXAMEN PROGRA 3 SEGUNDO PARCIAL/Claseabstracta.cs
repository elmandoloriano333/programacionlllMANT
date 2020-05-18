using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMEN_PROGRA_3_SEGUNDO_PARCIAL
{
    class Claseabstracta
    {
        interface claseAbstracta
        {
            Novela GetNovela(string titulo, string autor, string genero);
            Revista GetRevista(string titulo, int nrmpagina);
            Enciclopedia GetEnciclopedia(string nombre, string editorial, string tema);


        }
    }
}
