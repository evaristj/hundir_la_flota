using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Casilla
    {

        private int file;
        private int column;
        private char state;
        private char water = '.';
        private char ship = 'B';
        private char touched= 'X';

        public Casilla(int file, int column, char state)
        {
            this.file = file;
            this.column = column;
            this.state = water;
        }

        public int ColumnTable
        {
            get
            {
               return column;
            }
            set
            {
                column = value;
            }
        }

        public int FileTable { get => file; set => file = value; }
        public char Water { get => water; set => water = value; }
        public char Ship { get => ship; set => ship = value; }
        public char Touched { get => touched; set => touched = value; }
        public char State { get => state; set => state = value; }
    }
}
