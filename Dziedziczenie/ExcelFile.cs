using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    internal class ExcelFile : File
    {
        

        public void Wykres()
        {
            string prop = ProtectedProp;
            Console.WriteLine(FileName + " Showing...");
        }
    }
}
