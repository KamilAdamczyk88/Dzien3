using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //utworzmy nowy obiekt:

            ExcelFile excelFile = new ExcelFile();
            excelFile.FileName = "Excel-file.xls";
            excelFile.CreatedOn = DateTime.Now;

            excelFile.Wykres();

            WordFile wordFile = new WordFile();
            wordFile.FileName = "Word-File.doc";
            wordFile.CreatedOn = DateTime.Now;

            wordFile.Print();
        }
    }
}
