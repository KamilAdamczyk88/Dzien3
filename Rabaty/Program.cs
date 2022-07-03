using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj kwotę za zakup:");
            int kwota = Convert.ToInt32( Console.ReadLine());
            
            if (kwota > 100)
            {
                float Rabat = kwota * 15;
                Console.WriteLine(Rabat);
            }
            else if (kwota < 100 && kwota > 60)
            {
                float Rabat = kwota * 5;
                Console.WriteLine(Rabat);
            }
            else
            {
                Console.WriteLine("Brak rabatu! Kwota do zapłaty: " + kwota);
            }
        }
    }
}
