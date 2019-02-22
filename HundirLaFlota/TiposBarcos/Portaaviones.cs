using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Portaaviones : Barco
    {

        public Portaaviones(int tamañoPortAv) : base(tamañoPortAv)
        {
            tamañoPortAv = 4;
        }
    }
}
