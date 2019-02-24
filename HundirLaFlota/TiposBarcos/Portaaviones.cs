using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Portaaviones : Barco
    {
        private static int tamañoPortAv = 4;

        public Portaaviones() : base(tamañoPortAv)
        {
        }
    }
}
