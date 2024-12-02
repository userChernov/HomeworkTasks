using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    /*
     * Для класса Program создайте:
     *      1) 3 произвольных автоматических свойства, доступные только на чтение.
     *      2) 2 произвольных автоматических свойства, доступные только на запись.
     * Тип, модификаторы и имена свойств придумайте самостоятельно.
     */

    public class Program
    {
        public string Read1 { get; private set; }
        public int Read2 { get; private set; }
        public string Read3 { get; private set; }

        public int Write1 { set; private get; }
        public string Write2 { set; private get; }
        public int Write3 { set; private get; }
        
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
    }
}
