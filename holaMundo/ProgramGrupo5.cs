using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holaMundo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un texto");
            String texto;
            texto = Console.ReadLine();
            Console.WriteLine("El texto introducido es: " + texto);
        }
    }
}
