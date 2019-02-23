using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Casilla
    {

        private int fila;
        private int columna;
        private char estado;
        private char agua = '.';
        private char barco = 'B';
        private char tocado= 'X';

        public Casilla(int fila, int columna)
        {
            this.fila = fila;
            this.columna = columna;
            estado = agua;
            Console.Write(estado);
        }

        public int GetColumna()
        {
               return columna;
        }
        public void SetColumna(int valor)
        {
                columna = valor;
        }

        public int GetFila()
        {
            return fila;
        }
        public void SetFila(int valor)
        {
            fila = valor;
        }

        public char GetEstado()
        {
            return estado;
        }

        public void SetEstado(char newEstado)
        {
            estado = newEstado;
        }

        public char GetAgua()
        {
            return agua;
        }

        public void SetAgua()
        {
            estado = agua;
        }

        public char GetBarco()
        {
            return barco;
        }
        public void SetBarco()
        {
            estado = barco;
        }

        public char GetTocado()
        {
            return tocado;
        }
        public void SetTocado()
        {
            estado = tocado;
        }
       
    }
}
