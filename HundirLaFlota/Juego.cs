using System;

namespace HundirLaFlota
{
    class Juego
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            Tablero tableroJugador = new Tablero();
            Tablero tableroOrdenador = new Tablero();

            //tableroJugador.MostrarTablero();

            // el jugador coloca los barcos
           // tableroJugador.Rellenar();

            // se colocan los barcos del ordenador
            tableroOrdenador.Generar();

            Console.WriteLine("Tablero con el barco:");
            //tableroJugador.MostrarTablero();


            //Console.WriteLine(tableroJugador);

            Console.ReadKey();
        }
    }
}
