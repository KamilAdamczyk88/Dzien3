using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02Funkcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 30;
            //ctrl + . podpowiada rozwiazania np nowa funkcja
            int wynik = dodaj(a, b);
            Console.WriteLine(wynik);

            //Zadanie:
            //Napisz funkcje liczaca BMI:
            //waga / (wzrost) ^ 2
            //waga kg / wzrost m ^ 2 ==> 15-45
            //Console.WriteLine("Podaj Wagę:");
            //var waga = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Podaj Wzrost:");
            //var wzrost = Convert.ToDouble(Console.ReadLine());

            //double BMI = dzialanie(waga, wzrost);
            //Console.WriteLine(BMI);

            //Zadania:
            //Napisz funkcje ktora w podanym zdaniu policzy slowa z litera 'a'

            //Console.WriteLine("Podaj zdanie:");
            //string zdanie = Console.ReadLine();
            //string szukaj = "a";
            //Console.WriteLine("Liczenie1");
            //int wynik1 = liczenie(zdanie, szukaj);
            //Console.WriteLine(wynik1);


            //char znak = 'a';
            //bool caseSensitive = true;
            //Console.WriteLine("Liczenie2");
            //int wynik2 = liczenie2(zdanie, znak, caseSensitive);
            //Console.WriteLine(wynik2);


            //najdluzsze slowo w zdaniu
            Console.WriteLine("Podaj zdanie:");
            string zdanie = Console.ReadLine();

            Console.WriteLine(liczNajdluzszeZdanie(zdanie));


            CiezkaPraca();



        }
        private static string liczNajdluzszeZdanie(string zdanie)
        {

            string[] slowa = zdanie.Split(' ', ',', '.', '/', '\n', '-', ':');
            string najdluzsze = "";
            foreach (var slowo in slowa)
            {
                if (slowo.Length > najdluzsze.Length) najdluzsze = slowo;
            }

            return najdluzsze;

        }

        private static int liczenie(string zdanie, string szukaj = "a", bool caseSensitive = true)
        {
            int licznik = 0;
            if(!caseSensitive)
            {
                zdanie = zdanie.ToUpper();
                szukaj = szukaj.ToUpper();
            }
            foreach (var slowo in zdanie.Split(' '))
            {
                if (slowo.Contains(szukaj))
                    licznik++;
            }
            return licznik;
            

        }
        private static int liczenie2(string zdanie, char znak = 'a', bool caseSensitive = true)
        {

            return zdanie.Count(x => (x == znak) ||(caseSensitive &&(x==char.ToUpper(znak))));


        }

        private static double dzialanie(double waga, double wzrost)
        {
            return Math.Round (waga / Math.Pow(wzrost,2), 2);
        }

        //metoda: Dodaj
        private static int dodaj(int a, int b)
        {
            //bardzo skomplikowana logika:
            return a + b;

        }
        
        private static void CiezkaPraca()
        {
            Console.WriteLine("robie...");
            Console.WriteLine("Skonczone");

            Console.ReadKey(); 

        }
        



    }
}
