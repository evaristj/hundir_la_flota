using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Fragata : Barco
    {
        Barco[] tamFragata = new Barco[2];

        public Fragata(Casilla[] casillas, int tamañoFragata) : base(casillas, tamañoFragata)
        {
        }
    }
}
