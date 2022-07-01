using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01DataCzas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime);

            //dateTime = new DateTime(30, 12, 10);
            //dateTime = new DateTime();
            //Console.WriteLine(dateTime.AddDays(7));
            //Console.ReadLine();

            //W jaki dzien rozpoczela sie nasza ERa
            DateTime data = new DateTime();
            Console.WriteLine("Dzien w ktorym rozpoczela sie Era:");
            Console.WriteLine(data);
            Console.WriteLine(data.DayOfWeek);

            //ile dni uplynelo dni od twoich urodzin?
            
            DateTime dayOfbirth = new DateTime(1988, 04, 23);
            TimeSpan timeSpan = DateTime.Now - dayOfbirth;
            Console.WriteLine("ile dni uplynelo dni od moich urodzin?:");

            Console.WriteLine(timeSpan.Days);
            //kiedy skonczysz 90 lat?
            DateTime dayOfbirth1 = new DateTime(1988, 04, 23);

            DateTime dateSpan = dayOfbirth1.AddYears(90);
            Console.WriteLine("kiedy skonczysz 90 lat?:");
            Console.WriteLine(dateSpan.ToShortDateString());
            //wystawiasz dzis fakture z 90 dniwiym terminem platnosci, kiedy bedzie przelew?
            DateTime FVdat = DateTime.Now;
            DateTime termin = FVdat.AddDays(90);
            Console.WriteLine("wystawiasz dzis fakture z 90 dniwiym terminem platnosci, kiedy bedzie przelew?:");
            Console.WriteLine(termin.ToShortDateString());
            //jaka jest teraz godzina w czasie UTC?
            DateTime UTCNow = DateTime.UtcNow;
            Console.WriteLine("jaka jest teraz godzina w czasie UTC?:");
            Console.WriteLine(UTCNow);

        }
    }
}
