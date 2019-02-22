using System;

namespace HundirLaFlota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            Buque buque = new Buque(3);
            Casilla casilla = new Casilla(12,2);
          

            Console.WriteLine(buque.EstasHundido() + " : " + buque.GetType());
            

            Console.ReadKey();
        }
    }
}
