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

public class Example
{
   public static void Main()
   {
      DateTime dat = DateTime.Now;
      Console.WriteLine("The time: {0:d} at {0:t}", dat);
      TimeZoneInfo tz = TimeZoneInfo.Local;
      Console.WriteLine("The time zone: {0}\n", 
                        tz.IsDaylightSavingTime(dat) ?
                           tz.DaylightName : tz.StandardName);
      Console.Write("Press <Enter> to exit... ");
      while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
   }
}
// The example displays output like the following:
//     The time: 11/11/2015 at 4:02 PM:
//     The time zone: Pacific Standard Time
