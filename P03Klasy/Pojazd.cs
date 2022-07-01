using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Klasy
{
    internal class Pojazd
    {
        //fields:
        public int ileKol;
        //string naped;
        //public string kolor;
        int miejsca;
        //private bool czySprawny;
        DateTime dataProdukcji;

        //recznie pisane Property:
        private string _Chip;
        public string get_Chip()
        {
            //czy masz uprawnienia?
            //czy moje dane sa gotowe?
            return this._Chip;
        }

        public void set_Chip(string Chip)
        {
            //czy masz uprawnienia?
            //Czy nowa wartosc jest poprawna?
            this._Chip = Chip;

        }

        //Property:
        public string Kolor { get; set; } //mozna czytac, mozna nadpisywac

        public string Naped { get; }
        public bool CzySprawny { get ; protected set; }// tylko klasa i podklasy moga modyfikowac

        //Konstruktory:

        //stworz prywatny konstruktor bez parametrow
        private Pojazd()
        {
            this.dataProdukcji = DateTime.UtcNow;
        }
        //konstruktor domyslny bezargumentowy istnieje dopóki nie napisze pierwszego
        //konstruktora jawnego
        //Konstruktor z jednym parametrem
        public Pojazd(string kolor) : this()
        {
            this.Kolor = kolor;
            this.ileKol = 4;
            this.Naped = "nogi";
        }

       

        //konsktrutor musi nazywac sie tak samo jak klasa
        //stworz konstruktor z podaniem koloru i napedu
        //tu z wywolaniem konstruktora z jednym parametrem string
        public Pojazd(string kolor, string naped) : this(kolor)
        {
            this.Kolor = kolor;
            this.Naped = naped;

        }
        //metody:
         
        public override string ToString()
        {
            return $"Jestem Pojazd i mam {this.ileKol} koła. ";
        }
    }
}
