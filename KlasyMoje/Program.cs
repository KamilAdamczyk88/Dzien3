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
            Person Bill = new Person();
            Bill.Name = "Kamil";
            Bill.LastName = "Adamczyk";
            Bill.SetDateOfBirht(new DateTime(1988,4,23));
            //Console.WriteLine($"Imię: {Bill.Name} urodzony w: {Bill.GetDateOfBirth()}");
            Bill.SayHi();
        }
    }
}
