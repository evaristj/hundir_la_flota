using System;

namespace HundirLaFlota
{
    class Juego
    {
        static void Main(string[] args)
        {
            bool victoria = false;
            ConsoleKeyInfo intro;
            int fila, columna;
            char[] valor = { 'X', 'O' };
            string mensaje = "";
            Console.WriteLine("Hello World!");

            
            Tablero tableroJugador = new Tablero();
            Tablero tableroOrdenador = new Tablero();
            Tablero tableroOponente = new Tablero();

            // el jugador coloca los barcos
            //tableroJugador.Rellenar();

            Console.WriteLine("Generando barcos del ordenador...");
            // se colocan los barcos del ordenador
            tableroOrdenador.Generar();
            tableroOrdenador.MostrarTablero();

            Console.WriteLine("Proceso finalizado. Pulsa intro para comenzar!");
            intro = Console.ReadKey(true);
            Console.WriteLine(intro.KeyChar);
            if (intro.KeyChar == 13)
            {
                Console.WriteLine("has pulsado enter.");

                while (!victoria)
                {
                    // Console.Clear();
                    Console.WriteLine("Turno del jugador.");
                    Console.WriteLine("Introduce fila (0 - 7):");
                    try
                    {
                        fila = Convert.ToInt16(Console.ReadLine());
                        while (fila > 8 || fila < 0)
                        {
                            Console.WriteLine("Introduce una fila correcta:");
                            fila = Convert.ToInt16(Console.ReadLine());
                        }

                        Console.WriteLine("Introduce columna (0 - 7):");
                        columna = Convert.ToInt16(Console.ReadLine());
                        while (columna > 8 || columna < 0)
                        {
                            Console.WriteLine("Introduce una columna correcta:");
                            columna = Convert.ToInt16(Console.ReadLine());
                        }

                        mensaje = tableroOrdenador.TocadoHundidoJugador(fila, columna);

                        if (mensaje == "Agua")
                        {
                            tableroOponente.TableroOponente(fila, columna, valor[1]);

                        }else if (mensaje == "Barco tocado." || mensaje == "Tocado y hundido.")
                        {
                            tableroOponente.TableroOponente(fila, columna, valor[0]);
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("error: {0}", e);
                    }
                    Console.WriteLine("{0} ", mensaje);

                    Console.WriteLine("Pulsa intro para continuar");
                    //intro = Console.Read();
                }

            }
            else
            {
                Console.WriteLine("NO has pulsado enter.");

            }

            Console.WriteLine("Tablero con el barco:");
            //tableroJugador.MostrarTablero();


            //Console.WriteLine(tableroJugador);

            Console.ReadKey();
        }
    }
}
