using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Buque : Barco
    {
        private static int tamañoBuque = 3;

        public Buque() : base(tamañoBuque)
        {
        }

    }
}
