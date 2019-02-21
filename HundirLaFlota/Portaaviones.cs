using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Portaaviones : Barco
    {
        Barco[] tamPortaaviones = new Barco[4];

        public Portaaviones(Casilla[] casillas, int tamañoPortAv) : base(casillas, tamañoPortAv)
        {

        }
    }
}
