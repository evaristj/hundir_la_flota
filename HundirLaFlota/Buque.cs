using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Buque : Barco
    {

        Barco[] tamBuque = new Barco[3];

        public Buque(Casilla[] casillas, int tamañoBuque) : base(casillas, tamañoBuque)
        {

        }
    }
}
