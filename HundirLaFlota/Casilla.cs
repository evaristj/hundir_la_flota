using System;
using System.Collections.Generic;
using System.Text;

namespace HundirLaFlota
{
    class Casilla
    {

        private int file;
        private int column;
        private char water;
        private char ship;
        private char touched;

        public Casilla(int file, int column, char water, char ship, char touched)
        {
            this.file = file;
            this.column = column;
            this.water = water;
            this.ship = ship;
            this.touched = touched;
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
    }
}
