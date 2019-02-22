using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Fragata : Barco
    {

        public Fragata(int tamañoFragata) : base(tamañoFragata)
        {
            tamañoFragata = 2;
        }
    }
}
