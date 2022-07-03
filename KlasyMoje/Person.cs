using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyMoje
{
    internal class Person
    {
        public string Name;
        public string LastName;
        private DateTime dateOfBirth;

        public void SetDateOfBirht(DateTime Date)
        {
            if (Date > DateTime.Now)
            {
                Console.WriteLine("Wrong");
            }
            else
            {
                dateOfBirth = Date;
                Console.WriteLine("Wsjo OK");
            }
        }

        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }

        public void SayHi()
        {
            Console.WriteLine($"Czesc JEstem {Name} i urodziłem sie w {dateOfBirth}");
        }
    }
}
