using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Lancha : Barco
    {
        private static int tamañoLancha = 1;

        public Lancha() : base(tamañoLancha)
        {
        }
    }
}
