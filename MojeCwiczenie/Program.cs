using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeCwiczenie
{
    enum Miesiace
    {
        styczen = 1,
        luty = 2,
        marzec = 3,
        czerwiec = 6


    }
    
    internal class Program
    {
        enum Tydzien
        {
            Poniedzialek = 1,
            Wtorek = 2,
            Sobota = 6
        }
        static void Main(string[] args)
        {
            

        Czlowiek kamcio = new Czlowiek("Kamilek");
            Console.WriteLine(kamcio.imie);
            //kamcio.imie = "Zosia";
            Console.WriteLine(kamcio.imie);

            kamcio.PrzedstawSie();

            
        Miesiace dzis = (Miesiace)6; 
        Tydzien tydzien = (Tydzien)6;
        Console.WriteLine(dzis);
            Console.WriteLine(tydzien);

            //Console.ReadKey();
        }
    }
}
