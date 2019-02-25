using System;

namespace HundirLaFlota
{
    class Juego
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            Tablero tableroJugador = new Tablero();
            //Tablero tableroOrdenador = new Tablero();

            tableroJugador.MostrarTablero();

            //Console.WriteLine(tableroJugador);
            tableroJugador.Rellenar();

            Console.WriteLine("Tablero con el barco:");
            tableroJugador.MostrarTablero();


            Console.WriteLine(tableroJugador);

            Console.ReadKey();
        }
    }
}
