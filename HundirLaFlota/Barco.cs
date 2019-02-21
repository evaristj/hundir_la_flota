using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    abstract class Barco
    {
        private Casilla[] casillas;

        // Un constructor que recibirá como parámetro el tamaño del array de casillas, e
        // internamente inicializará el array con ese tamaño.
        protected Barco(Casilla[] casillas, int tamaño)
        {
            casillas = new Casilla[tamaño];
        }

        public bool EstasHundido()
        {
            // este método devolverá un boolenao indicando si el barco  ha sido hundido o no
            // Se deberán recorrer las casillas del barco y ver su estado,
            // para comprobar si todas están tocadas, o si hay alguna que no.
            return false;
        }
    }
}
