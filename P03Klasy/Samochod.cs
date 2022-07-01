using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Klasy
{
    internal class Samochod : Pojazd
    {
        static private Random rnd = new Random();
        public int IleDrzwi { get; }
        public int przebieg { get; private set; }

        public Samochod() : base("czerwony", "benzyna")
        {
            this.ileKol = 4;
            this.CzySprawny = true;
            this.IleDrzwi =  IleDrzwi;
            this.przebieg = 0;
        }

        public Samochod(int iledrzwi) : this()
        {
            this.IleDrzwi = iledrzwi;
        }

        public void Jedz(int kilometry)
        {
            if (this.CzySprawny)
            {
                while (this.CzySprawny && kilometry >0)
                {
                    int dystans = (kilometry > 100 ? 100 : kilometry);
                    this.przebieg += dystans;
                    kilometry -= dystans;
                    if (rnd.Next(100) < 30)
                        this.CzySprawny = false;
                }
                
                
            }
        }

        public bool Napraw(int kwota)
        {
            if (rnd.Next(100) < kwota)
                this.CzySprawny = true;
            return this.CzySprawny;
        }

        //Zadanie:
        //napisz program ktory przejedzie samochodem 1000 km
        //kto wyda najmniej kilometrow?

        

        
    }
}
