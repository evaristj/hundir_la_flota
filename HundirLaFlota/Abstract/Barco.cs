using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    abstract class Barco
    {
        private Casilla[] casillasBarco;

        // Un constructor que recibirá como parámetro el tamaño del array de casillas, e
        // internamente inicializará el array con ese tamaño.
        protected Barco(int tamaño)
        {
            casillasBarco = new Casilla[tamaño];
        }

        protected Casilla[] CasillasBarco { get => casillasBarco; set => casillasBarco = value; }

        // comprobamos si el barco ha sido hundido o no
        public bool EstaHundido()
        {
            int contador = 0;

            for (int i = 0; i < casillasBarco.Length; i++)
            {
                if (casillasBarco[i].GetEstado() == 'X')
                {
                    contador++;
                }
            }

            if (contador == casillasBarco.Length)
            {
                return true;
            }
            // este método devolverá un boolenao indicando si el barco  ha sido hundido o no
            // Se deberán recorrer las casillas del barco y ver su estado,
            // para comprobar si todas están tocadas, o si hay alguna que no.
            return false;
        }
    }
}
