using System;

namespace HundirLaFlota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            Buque buque = new Buque(3);

            Tablero tablero = new Tablero();

            //tablero.InitTablero(); 
            //Casilla casilla = new Casilla();
            
            Console.WriteLine(tablero);
            

            Console.ReadKey();
        }
    }
}
