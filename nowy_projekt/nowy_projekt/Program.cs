using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nowy_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            opiszTyp(5);
            opiszTyp("Hello world");
            opiszTyp(5.0);
            Console.ReadKey();
        }

        public static void opiszTyp(int wartosc)
        {
            Console.WriteLine("Typ int    || wartość: " + wartosc);
        }
        public static void opiszTyp(string wartosc)
        {
            Console.WriteLine("Typ string || wartość: " + wartosc);
        }
        public static void opiszTyp(double wartosc)
        {
            Console.WriteLine("Typ double || wartość: " + wartosc);
        }
    }
}
