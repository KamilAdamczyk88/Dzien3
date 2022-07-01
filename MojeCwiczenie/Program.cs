using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeCwiczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek kamcio = new Czlowiek();
            Console.WriteLine(kamcio.imie);
            //kamcio.imie = "Zosia";
            Console.WriteLine(kamcio.imie);

            kamcio.PrzedstawSie();
        }
    }
}
