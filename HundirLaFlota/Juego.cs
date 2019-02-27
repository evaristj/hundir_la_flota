using System;

namespace HundirLaFlota
{
    class Juego
    {
        static void Main(string[] args)
        {
            bool victoria = false;
            Random r = new Random();
            ConsoleKeyInfo intro;
            int fila, columna;
            char[] valor = { 'X', 'O' };
            string mensaje = "";
            Console.WriteLine("Hello World!");

            
            Tablero tableroJugador = new Tablero();
            Tablero tableroOrdenador = new Tablero();
            Tablero tableroOponente = new Tablero();

            // el jugador coloca los barcos
            tableroJugador.Generar();

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

                        mensaje = tableroOrdenador.Turnos(fila, columna, 1);

                        if (mensaje == "Agua")
                        {
                            Console.WriteLine(mensaje);
                            tableroOponente.TableroOponente(fila, columna, valor[1]);

                        }else if (mensaje == "Barco tocado." || mensaje == "Tocado y hundido.")
                        {
                            Console.WriteLine(mensaje);
                            tableroOponente.TableroOponente(fila, columna, valor[0]);
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("error: {0}", e);
                    }
                    try
                    {
                        Console.WriteLine("Turno del ordenador.");
                        Console.WriteLine("Introduce fila (0 - 7):");
                        fila = r.Next(0, 7);
                        Console.WriteLine("Fila: {0} ", fila);

                        Console.WriteLine("Introduce Columna (0 - 7):");
                        columna = r.Next(0, 7);
                        Console.WriteLine("Columna: {0} ", columna);

                        mensaje = tableroJugador.Turnos(fila, columna, 0);

                        Console.WriteLine("Turno ordenador: {0} ", mensaje);

                        Console.WriteLine("Pulsa intro para continuar");
                        intro = Console.ReadKey(true);
                        Console.WriteLine(intro.KeyChar);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("error: {0}", e);
                    }
                   
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
