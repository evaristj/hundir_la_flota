using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Tablero
    {

        private const int FILAS = 8;
        private const int COLUMNAS = 8;
        private const int BARCOS = 4;

        private Casilla[,] casilla;
        private Barco[] barcos;

        // en el constructor creamos el tablero
        public Tablero()
        {
            casilla = new Casilla[FILAS, COLUMNAS];
            Console.WriteLine("0 1 2 3 4 5 6 7");

            for (int i = 0; i < FILAS; i++)
            {
                for (int j = 0; j < COLUMNAS; j++)
                {
                    casilla[i, j] = new Casilla(FILAS, COLUMNAS);

                    Console.Write(" ");
                }
                Console.Write(i);

                Console.WriteLine("");
            }


            barcos = new Barco[BARCOS];
        }
        /*
        // iniciamos el tablero
        public void InitTablero()
        {
            for (int i = 0; i < casilla.Length; i++)
            {
                for (int j = 0; j < casilla.Length; j++)
                {
                    casilla[i, j] = new Casilla(FILAS, COLUMNAS);
                    
                    Console.Write(casilla[i, j]);
                }
                Console.WriteLine("##");
            }
        }
        */

        /*
        // lo mostramos
        public void MostrarTablero()
        {
            for (int i = 0; i < casilla.Length; i++)
            {
                for (int j = 0; j < casilla.Length; j++)
                {
                    casilla[i, j] = new Casilla();
                }
            }
        }
        */
    }
}
