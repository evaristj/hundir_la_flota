using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    abstract class Barco
    {
        protected Casilla[] casillasBarco;

        protected Barco(int tamanyo)
        {
            casillasBarco = new Casilla[tamanyo];        
        }

        public Casilla[] CasillasBarco { get => casillasBarco; set => casillasBarco = value; }

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
            
            return false;
        }
    }
}
