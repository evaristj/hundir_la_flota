using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Lancha : Barco
    {
        Barco[] tamañoLancha = new Barco[1];

        public Lancha(Casilla[] casillas, int tamañoLancha) : base(casillas, tamañoLancha)
        {
        }
    }
}
