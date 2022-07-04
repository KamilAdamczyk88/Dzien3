using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    internal class PowerPointFile : File //dziedziczenie!
    {
        

        public void Presenting()
        {
            Console.WriteLine(FileName + " Presenting...");
        }
    }
}
