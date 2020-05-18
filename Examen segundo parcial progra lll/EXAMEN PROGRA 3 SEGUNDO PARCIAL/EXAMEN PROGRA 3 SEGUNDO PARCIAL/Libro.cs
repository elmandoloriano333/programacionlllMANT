using EXAMEN_PROGRA_3_SEGUNDO_PARCIAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pila_de_Libros
{
    abstract class Libro: Claseabstracta
    {
      
        public Enciclopedia GetEnciclopedia (string nombre, string editorial , string tema)
        {
            throw new NotImplementedException();
        }
        public Novela GetNovela(string titulo,string autor, string genero)
        {
            throw new NotImplementedException();
        }
       public Revista GetRevista (string titulo , int nmrpagina)
        {
            throw new NotImplementedException();
        }
       


    }
}
