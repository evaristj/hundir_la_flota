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

        private Casilla[,] casillas = new Casilla[FILAS, COLUMNAS];
        private Barco[] barcos = new Barco[BARCOS];
       
        // en el constructor creamos el tablero
        public Tablero()
        {


            for (int i = 0; i < FILAS; i++)
            {
                for (int j = 0; j < COLUMNAS; j++)
                {
                    casillas[i, j] = new Casilla(i,j);
                }
                // ¿cómo hacer para modificar el estado de una casilla?
                // Console.Write(i);
            }
            
            barcos[0] = new Lancha();
            barcos[1] = new Fragata();
            barcos[2] = new Buque();
            barcos[3] = new Portaaviones();
        }
     
        // metodo para poner barco
        private bool PonerBarco(int barco, int fila, int columna, char orientacion)
        {
            bool existeFila = false;
            bool existeColumna = false;
            bool horizontal = false;
            bool vertical = false;
            Console.WriteLine("entra el metodo ponerBarco");
            // tipos de barco

            // comprobamos que fila y columna existen en tablero
            existeFila = (fila < 8 && !(fila < 0)) ? true : false;


            existeColumna = (columna < 8 && !(columna < 0)) ? true : false;

            // comprobar orientacion correcta
            // en la posicion horizontal, habrá que comprobar que hay hueco en las columnas
            int resultH = COLUMNAS - columna;
            if (orientacion == 'h' && resultH >= barco)
            {
                
                // en este for recorremos el array de casillas barco para que tenga el mismo
                // valor que el array de casillas del tablero
                for (int i = columna; i <= columna + barco; i++)
                {
                    // se coloca el barco en la fila que le hemos pasado, hasta la columna
                    // que le hemos dicho (horizontal)

                    casillas[fila, i].SetBarco();
                    // en casillasBarco se indica que la posicion del barco 
                    // se corresponde con la del tablero
                    barcos[barco].CasillasBarco[i - columna] = casillas[fila, i];

                }
                
            }

            // colocacion vertical
            bool ocupado = false;
            int contador = -1;
            if (orientacion == 'v')
            {
                for (int i = fila; i <= fila + barco; i++)
                {
                    Console.WriteLine(casillas[i, columna].GetEstado() + " :estado antes del for");
                    if (casillas[i, columna].GetEstado() != 'B')
                    {
                        contador++;
                    }
                    Console.WriteLine("contador: {0}", contador);
                    //Console.WriteLine(casillas[i, columna].GetEstado() + " :estado despues del for");
                }

                for (int i = fila; i <= fila + barco; i++)
                {
                    Console.WriteLine("for de contador {0}: ", contador);
                   
                    if (contador == barco)
                    {
                        casillas[i, columna].SetBarco();
                        barcos[barco].CasillasBarco[i - fila] = casillas[i, columna];
                    }
                    else
                    {
                        ocupado = true;
                    }

                }
            }
            if (ocupado)
            {
                Console.WriteLine("El barco NO ha sido colocado.");

                return false;
            }
            Console.WriteLine("El barco ha sido colocado.");
            return true;
        }

        // rellenar tablero
        public void Rellenar()
        {
            int barco;
            int fila;
            int columna;
            char orientacion;
            string[] tiposDeBarcos = { "LANCHA", "FRAGATA", "BUQUE", "PORTAAVIONES" };
            bool creado;

           
            for (int i = 0; i < tiposDeBarcos.Length; i++)
            {
                Console.WriteLine("Rellenando barco: {0}:", tiposDeBarcos[i]);

                barco = i;

                Console.WriteLine("Introduce la fila donde lo quieres colocar:");
                fila = Convert.ToInt16(Console.ReadLine());
                while (fila > 8 || fila < 0)
                {
                    Console.WriteLine("Introduce una fila correcta:");
                    fila = Convert.ToInt16(Console.ReadLine());
                }

                Console.WriteLine("Introduce la columna donde lo quieres colocar:");
                columna = Convert.ToInt16(Console.ReadLine());
                while (columna > 8 || columna < 0)
                {
                    Console.WriteLine("Introduce una columna correcta:");
                    columna = Convert.ToInt16(Console.ReadLine());
                }

                Console.WriteLine("Introduce la orientación del barco, h =>horizontal, v =>vertical:");
                orientacion = Convert.ToChar(Console.ReadLine());
                bool valido = false;
                if (orientacion != 'h' || orientacion != 'v')
                {
                    valido = true;
                }
                while (!valido)
                {
                    Console.WriteLine("Introduce una orientación correcta:");
                    orientacion = Convert.ToChar(Console.ReadLine());
                }

                creado = PonerBarco(barco, fila, columna, orientacion) ? true : false;

                if (!creado)
                {
                    Console.WriteLine("El barco no se ha podido colocar, casillas ocupadas.");
                    i--;
                }
                else
                {
                    MostrarTablero();
                }
                

            }

        }

        public void Generar()
        {

        }

        // mostrar tablero por consola
        public void MostrarTablero()
        {
            Console.WriteLine("0 1 2 3 4 5 6 7");

            for (int i = 0; i < FILAS; i++)
            {
                for (int j = 0; j < COLUMNAS; j++)
                {
                    Console.Write(casillas[i, j].GetEstado() + " ");
                }

                Console.WriteLine("" + i);
            }
        }
    }
}
