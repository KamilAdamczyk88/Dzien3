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
        public static int count = 0;
        private string contactNumber;

        ////Własciwosci:
        public string ContactNumber
        {
            get { return contactNumber; }
            set {
                if (value.Length <9 )
                {
                    Console.WriteLine("Wrong Contact Number");
                }
                else
                {
                    contactNumber = value;
                }
            }
                
        }
        public DateTime DateOfBirth
        { 
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        //Automatycznie zaimplementowana wlascowosc
        //public string ContactNumer { get; set; }

        //Metody:
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
            Console.WriteLine($"Czesc JEstem {Name}, Nazywam się {LastName} i urodziłem sie w {DateOfBirth}");
        }

        //Konstruktor jest motodą uzywana do tworzenia  nowego obiektu dla danego typu przy uzyciu slowa kluczowego NEW!!!
        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Constructor1");
            Name = firstName;
            LastName = lastName;
            count++;
        }

        public Person(string name, string lastName, DateTime dateOfBirth) : this(name, lastName)
        {
            Console.WriteLine("Constructor2");
            this.dateOfBirth = dateOfBirth;
        }
    }
}
