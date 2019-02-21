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

        public Casilla(int fila, int columna, char estado)
        {
            this.fila = fila;
            this.columna = columna;
            this.estado = agua;
        }

        public int ColumnTable
        {
            get
            {
               return columna;
            }
            set
            {
                columna = value;
            }
        }

        public int FileTable { get => fila; set => fila = value; }
        public char Water { get => agua; set => agua = value; }
        public char Ship { get => barco; set => barco = value; }
        public char Touched { get => tocado; set => tocado = value; }
        public char State { get => estado; set => estado = value; }
    }
}
