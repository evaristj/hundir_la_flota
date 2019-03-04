using System;

/*
 * Sanchez García, Evarist Jaume
 * Practica evaluable Tema 7
 * Apartado 1 si
 * Apartado 2 si
 * Apartado 3 si
 * Apartado 4 si 
 */

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
            int[] turno = { 0, 1 }; // 1 jugador, 0 ordenador
            char[] valor = { 'X', 'O' };
            string mensaje = "";
            string continuar = "Pulsa intro para continuar";
            
            Tablero tableroJugador = new Tablero();
            Tablero tableroOrdenador = new Tablero();
            Tablero tableroOponente = new Tablero();

            // el jugador coloca los barcos
            tableroJugador.Rellenar();
            Console.WriteLine("Tu tablero:");
            tableroJugador.MostrarTablero();

            Console.WriteLine("Generando barcos del ordenador...");
            // se colocan los barcos del ordenador
            tableroOrdenador.Generar();
            Console.WriteLine("Tablero ordenador:");
            tableroOrdenador.MostrarTablero();

            Console.WriteLine("Proceso finalizado. Pulsa intro para comenzar!");
            intro = Console.ReadKey(true);
            Console.WriteLine(intro.KeyChar);
            if (intro.KeyChar == 13)
            {
                Console.WriteLine("has pulsado enter.");

                while (!victoria)
                {
                    Console.Clear();
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

                        mensaje = tableroOrdenador.Turnos(fila, columna, turno[1]);

                        if (mensaje == "Agua")
                        {
                            Console.WriteLine(mensaje);
                            tableroOponente.TableroOponente(fila, columna, valor[1]);

                        }
                        else if (mensaje == "Tocado.")
                        {
                            Console.WriteLine(mensaje);
                            tableroOponente.TableroOponente(fila, columna, valor[0]);

                        }
                        else if (mensaje == "Tocado y hundido.")
                        {
                            Console.WriteLine(mensaje);
                            tableroOponente.TableroOponente(fila, columna, valor[0]);
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("error: {0}", e);
                    }

                    if (mensaje == "Victoria!!!")
                    {
                        victoria = true;
                        Console.WriteLine("Victoria del jugador! \nFIN DE JUEGO");
                    }

                    Console.WriteLine(continuar);
                    intro = Console.ReadKey(true);
                    Console.WriteLine(intro.KeyChar);

                    while (intro.KeyChar != 13)
                    {
                        Console.WriteLine(continuar);
                        intro = Console.ReadKey(true);
                    }

                    Console.Clear();
                    Console.WriteLine("Turno del ordenador.");
                    Console.WriteLine("Introduce fila (0 - 7):");
                    fila = r.Next(0, 8);
                    Console.WriteLine("Fila: {0} ", fila);

                    Console.WriteLine("Introduce Columna (0 - 7):");
                    columna = r.Next(0, 8);
                    Console.WriteLine("Columna: {0} ", columna);

                    mensaje = tableroJugador.Turnos(fila, columna, turno[0]);

                    if (mensaje == "Victoria!!!")
                    {
                        victoria = true;
                        Console.WriteLine("Victoria del ordenador! \nFIN DE JUEGO");
                    }

                    Console.WriteLine("Turno ordenador: {0} ", mensaje);

                    Console.WriteLine(continuar);
                    intro = Console.ReadKey(true);
                    Console.WriteLine(intro.KeyChar);

                    while (intro.KeyChar != 13)
                    {
                        Console.WriteLine(continuar);
                        intro = Console.ReadKey(true);
                    }
                }

            }
            else
            {
                Console.WriteLine("NO has pulsado enter.");
            }
            Console.ReadKey();
        }
    }
}
