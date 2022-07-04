using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyMoje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Bill = new Person("Bill", "Wick");
            Person John = new Person("John", "Wick", new DateTime(1989, 12,5));
            Bill.SetDateOfBirht(new DateTime(1988,4,23));
            Bill.ContactNumber = "999-888";
            John.DateOfBirth = (new DateTime(2020,12,4));

            Console.WriteLine(Bill.ContactNumber);
            //Console.WriteLine($"Imię: {Bill.Name} urodzony w: {Bill.GetDateOfBirth()}");
            Bill.SayHi();
            John.SayHi();
            Console.WriteLine($"Objects of class {Person.count}");
        }
    }
}
