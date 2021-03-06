﻿using System;
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
            }
            
            barcos[0] = new Lancha();
            barcos[1] = new Fragata();
            barcos[2] = new Buque();
            barcos[3] = new Portaaviones();
        }
     
        private bool PonerBarco(int barco, int fila, int columna, char orientacion)
        {
                        
            // comprobar orientacion correcta
            bool ocupado = false;
            int resultH = COLUMNAS - columna;
            int contadorV = -1;
            int contadorH = -1;
            if (orientacion == 'h')
            {

                // comprueba que el barco no se salga del tablero
                if (columna + barco+1 > COLUMNAS)
                {
                    return false;
                }

                for (int i = columna; i <= columna + barco; i++)
                {
                    if (casillas[fila, i].GetEstado() != 'B')
                    {
                        contadorH++;
                    }
                   
                }

                // si no existen barcos en esa columna se añaden los barcos
                for (int i = columna; i <= columna + barco; i++)
                {
                    if (contadorH == barco)
                    {
                        casillas[fila, i].SetBarco();
                        barcos[barco].CasillasBarco[i - columna] = casillas[fila, i];
                    }
                    else
                    {
                        ocupado = true;
                    }
                }
            }

            // colocacion vertical
            if (orientacion == 'v')
            {
                if (fila + barco+1 > FILAS)
                {
                    return false;
                }

                // comprueba que no exista barcos en esa columna
                for (int i = fila; i <= fila + barco; i++)
                {
                    if (casillas[i, columna].GetEstado() != 'B')
                    {
                        contadorV++;
                    }
                }

                // si no existen barcos en esa columna se añaden los barcos
                for (int i = fila; i <= fila + barco; i++)
                {                   
                    if (contadorV == barco)
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
            }

        }

        public void Generar()
        {
            Random r = new Random();
            int barco, index, fila, columna;
            char[] orientacion = { 'h', 'v' };
            string[] tiposDeBarcos = { "LANCHA", "FRAGATA", "BUQUE", "PORTAAVIONES" };
            bool creado;

            for (int i = 0; i < tiposDeBarcos.Length; i++)
            {

                barco = i;
                fila = r.Next(0, 7);
                columna = r.Next(0, 7);
                index = r.Next(orientacion.Length);
                creado = PonerBarco(barco, fila, columna, orientacion[index]) ? true : false;

                if (!creado)
                {
                    Console.WriteLine("El barco no se ha podido colocar, casillas ocupadas.");
                    i--;
                }
            }
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

        // turnos de juego
        public string Turnos(int fila, int columna, int turno)
        {
            string mensaje = "";
            int contador = 0;

            for (int i = 0; i < barcos.Length; i++)
            {
                for (int j = 0; j < barcos[i].CasillasBarco.Length; j++)
                {
                    if (barcos[i].CasillasBarco[j] == casillas[fila, columna])
                    {
                        casillas[fila, columna].SetTocado();
                        mensaje = "Tocado.";
                        if (barcos[i].EstaHundido())
                        {
                            mensaje = "Tocado y hundido.";
                        }

                    }
                }
                
            }
            // comprueba cuantos barcos hay hundidos
            for (int i = 0; i < barcos.Length; i++)
            {
                if (barcos[i].EstaHundido())
                {
                    contador++;
                }
            }

            // comprobamos victoria
            if (contador == 4)
            {
                mensaje = "Victoria!!!";
            }

            // imprimimos el tablero del ordenador mostrando las casillas que han sido nombradas
            if (turno == 0)
            {
                Console.WriteLine("0 1 2 3 4 5 6 7");
            }
            for (int i = 0; i < FILAS; i++)
            {

                for (int j = 0; j < COLUMNAS; j++)
                {

                    if (casillas[fila, columna].GetEstado() == '.')
                    {
                        casillas[fila, columna].SetEstado('O');
                        mensaje = "Agua";
                    }

                    // no mostrar los barcos del ordenador
                    if (turno == 0)
                    {
                        Console.Write(casillas[i, j].GetEstado() + " ");
                    }
                }
                if (turno == 0)
                {
                    Console.WriteLine("" + i);
                }
            }

            return mensaje;
        }

        // tablero sin mostrar barcos del oponente
        public void TableroOponente(int fila, int columna, char valor)
        {
            Console.WriteLine("0 1 2 3 4 5 6 7");
            for (int i = 0; i < FILAS; i++)
            {

                for (int j = 0; j < COLUMNAS; j++)
                {
                   
                    casillas[i, j].GetEstado();
                    casillas[fila, columna].SetEstado(valor);
                    
                    // no mostrar los barcos del ordenador
                    Console.Write(casillas[i, j].GetEstado() + " ");
                }

                Console.WriteLine("" + i);
            }
        }
    }
}
