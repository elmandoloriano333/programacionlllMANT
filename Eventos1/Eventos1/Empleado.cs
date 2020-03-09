using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos1
{

    public delegate void ActualizacionEventHandler(string msg);

    public class multiplo
        {
        //atributo
        private int numero;

            //declaración del evento
            public event ActualizacionEventHandler NombreCambiado;

            public multiplo(int numero)
            {
                this.numero = numero;
            }

            public void setnumero(int  s)
            {
                //actualizar el atributo
               int numeroera = this.numero;
                this.numero = s;

            //lanzar el evento
             n = 4;
            if  (s/n)
             if (this.multiploes != null)
                    this.multiploes("el numero Era " + numeroera + " el resultado de su multiplo es "+this.numero);
            }

        }
   }


