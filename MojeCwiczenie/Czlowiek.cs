using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeCwiczenie
{
    internal class Czlowiek
    {
        //konstruktor:
        public Czlowiek(string imieKonstruktora)
        {
            imie = imieKonstruktora;
        }
            

        public string imie = "Kamil";

        public void PrzedstawSie()
        {
            Console.WriteLine($"Mam na imie {imie}");
        }
        
    }
}
