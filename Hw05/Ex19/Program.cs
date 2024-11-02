using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    /*
     * Измените класс Program таким образом, чтобы вместо публичных переменных класса, класс стал использовать
     * автоматические свойства, с соответствующими именами. Ненужные переменные - удалите.
     * Остальные элементы шаблона изменять нельзя.
     */

    public class Program
    {
        public int Version { get; set; }
        public string Name { get; set; }
        public Human Owner { get; set; }
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
    }

    public class Human
    {
        public string name;
    }
}
