using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Klasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klasy przechowuja dane
            //c# struct vs class
            //do struct wrzucamy dane. nie umie nic poza przechowywanie danych
            Pojazd mojsamochod = new Pojazd("Czerwony");
            Pojazd rower = new Pojazd("Niebieski");
            rower.ileKol = 2;
            mojsamochod.ileKol = 4;
            mojsamochod.Kolor = "Red";
            Console.WriteLine(mojsamochod.ileKol);

            Console.WriteLine(mojsamochod);
            Console.WriteLine(rower);

            Samochod Ferrari = new Samochod(2);
            Console.WriteLine($"Na przejechanie 1000km wydano {JazdaTestowa(Ferrari, 50)} PLN");

        }

        public static int JazdaTestowa(Samochod autko, int naprawa = 100, int dystans = 1000)
        {
            int fundusze = 0;
            int kilometry = autko.przebieg + dystans;

            while (autko.przebieg < kilometry)
            {
                autko.Jedz(500);
                while (!autko.CzySprawny)
                {
                    fundusze += naprawa;
                    autko.Napraw(naprawa);
                }
            }
            return fundusze;
            
        }
    }
}
