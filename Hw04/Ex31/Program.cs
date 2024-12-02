using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31
{
    /*
     * Создайте статический метод GetClothes(), который принимает показатель температуры и в
     * зависимости от него указывает, что необходимо надеть для похода на улицу:
     *      1)  Если на улице 20 градусов – "Надеваем футболку, джемпер и джинсы".
     *      2)	Если на улице 25 градусов – "Надеваем футболку и джинсы".
     *      3)	Если на улице 27 градусов – "Надеваем футболку и шорты".
     *      4)	Если на улице 30 градусов – "Надеваем футболку, шорты и кепку".
     *      5)	Если на улице 31 градус – "Надеваем шорты и кепку".
     *      6)  Во всех остальных случаях – "Сидим дома...я не знаю, что надеть".
     * Состав гардероба необходимо вывести на экран. При реализации используйте конструкцию "switch-case-default".
     * Внутри метода Main() вызовите метод GetClothes(), предоставив пользователю возможность
     * ввести с клавиатуры температурные показатели.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Console.Write("Введите температуру: ");
            int degree = Convert.ToInt32(Console.ReadLine());

            GetClothes(degree);
        }

        /* Добавьте свой код ниже */

        public static void GetClothes(int degree)
        {
            switch (degree)
            {
                case 20:
                    Console.WriteLine("Надеваем футболку, джемпер и джинсы");
                break;
                case 25:
                    Console.WriteLine("Надеваем футболку и джинсы");
                break;
                case 27:
                    Console.WriteLine("Надеваем футболку и шорты");
                break;
                case 30:
                    Console.WriteLine("Надеваем футболку, шорты и кепку");
                break;
                case 31:
                    Console.WriteLine("Надеваем шорты и кепку");
                break;
                default:
                    Console.WriteLine("Сидим дома...я не знаю, что надеть");
                break;
            }

        }
    }
}
