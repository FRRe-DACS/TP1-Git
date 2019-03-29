using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holaMundo
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("hola mundo");

            Console.ReadKey();
            
            System.Console.WriteLine("seguimos vivos");

            Console.ReadKey();

            Console.ReadKey();
Console.Write("Press <Enter> to exit... ");
      while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
        }
    }
}
