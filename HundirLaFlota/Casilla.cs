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
        }

        public int GetColumna()
        {
               return columna;
        }
        public void SetColumna(int valor)
        {
                columna = valor;
        }

        public int Fila { get => fila; set => fila = value; }
        public char Estado { get => estado; set => estado = value; }
        public char Agua { get => agua; set => agua = value; }
        public char Barco { get => barco; set => barco = value; }
        public char Tocado { get => tocado; set => tocado = value; }
    }
}
