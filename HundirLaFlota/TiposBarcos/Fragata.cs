using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Fragata : Barco
    {
        private static int tamañoFragata = 2;

        public Fragata() : base(tamañoFragata)
        {
        }
    }
}
