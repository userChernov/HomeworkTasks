using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30
{
    /*
     * Создайте публичный статический класс SupportPrinterClass в том же файле и namespace что и класс Program.
     * Добавьте в созданный класс 4 публичных метода:
     *      1) Printer, который должен принимать в качестве входящего параметра строку и выводить её на экран 1 раз.
     *      2) DoublePrinter, который должен принимать в качестве входящего параметра строку и выводить её на экран 2 раза.
     *      3) TriplePrinter, который должен принимать в качестве входящего параметра строку и выводить её на экран 3 раз.
     *      4) MultiPrinter, который должен принимать в качестве входящего параметра строку и число раз, которое её надо вывести на экран.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            SupportPrinterClass.Printer("Printer");
            Console.WriteLine("=====================");
            SupportPrinterClass.DoublePrinter("DoublePrinter");
            Console.WriteLine("=====================");
            SupportPrinterClass.TriplePrinter("TriplePrinter");
            Console.WriteLine("=====================");
            SupportPrinterClass.MultiPrinter("MultiPrinter", 6);
        }
    }
    /* Добавьте свой код ниже */

    public static class SupportPrinterClass
    {
        public static void Printer(string toPrinter)
        {
            Console.WriteLine(toPrinter);
        }
        public static void DoublePrinter(string toPrinter)
        {
            Console.WriteLine(toPrinter);
            Console.WriteLine(toPrinter);
        }
        public static void TriplePrinter(string toPrinter)
        {
            for (int i = 0; i < 3; i++)
                Console.WriteLine(toPrinter);
        }
        public static void MultiPrinter(string toPrinter, int printCount)
        {
            for (int i = 0; i < printCount; i++)
                Console.WriteLine(toPrinter);
        }

    }
}