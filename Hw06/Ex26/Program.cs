using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t26
{
    /*
     * В том же файле и namespace что и класс Program создайте:
     *      1) Новую публичную структуру ColoredSquare.
     *      2) Новое публичное перечисление Color с тремя значениями: Red, Green, Yellow.
     * Для структуры ColoredSquare:
     *      1) Объявите приватное поле  length - отвечающее за длину стороны квадрата, тип поля определите самостоятельно.
     *      2) Объявите приватное поле pic - отвечающее за картинку квадрата с использованием псевдографики, тип поля определите самостоятельно.
     *      3) Объявите приватное поле color - отвечающее за цвет отрисовки картинки квадрата с использованием псевдографики, тип поля определите самостоятельно.
     * Объявите приватный статический метод MakeFigurePic() в структуре ColoredSquare, который принимает длину стороны квадрата,
     * а возвращает картинку квадрата с использованием псевдографики, на основе следующей логики:
     *      1) Отрисовывается только внешний контур квадрата, символ для отрисовки единицы длины - "+".
     *      2) Внутренние элементы квадрата - пробельные символы.
     *      3) Каждый из символов отрисовки должен иметь дополнительный пробельный символ, чтобы фигура получилась ровной.
     * Объявите публичный метод PrintFigure() в структуре ColoredSquare, который:
     *      1) Ничего не возвращает.
     *      2) Отвечает за отрисовку экземпляра структуры в консоли.
     *      3) Устанавливает цвет отрисовываемой фигуры, путем установки соответствующего значения в свойство консоли.
     * Объявите конструктор для структуры ColoredSquare, который принимает длину стороны квадрата и его цвет, а устанавливает длину, цвет и картинку.
     * Внутри метода Main() создайте три экземпляра структуры ColoredSquare c длинной стороны 5 и цветами: красным, желтым и зеленым, после чего
     * отрисуйте все 3 созданных экземпляра в консоли.
     */

    public class Program
    {
        public static void Main(string[] args)
        {   
            ColoredSquare colorRed = new ColoredSquare(24, Color.red);
            ColoredSquare colorGreen = new ColoredSquare(10, Color.green);
            ColoredSquare colorYellow = new ColoredSquare(14, Color.yellow);

            colorRed.PrintFigure();
            colorGreen.PrintFigure();
            colorYellow.PrintFigure();
        }
    }

    /* Добавьте свой код ниже */

    public struct ColoredSquare
    {
        private int length;
        private string pic;
        private Color color;

        public ColoredSquare(int l, Color c) //Конструктор (для задания параметров)
        {
            this.length = l;
            this.color = c;
            this.pic = "+";
        }

        public void PrintFigure() //Выводим в консоль с учетом полученного цвета отрисовки! Отсюда мы обращаемся к созданию фигуры на основе данных экземпляра
        {
            int l = this.length;
            string pic = this.pic;
            Color color = this.color;

            string[,] figure = MakeFigurePic(l, pic);
            
            switch (color)
            {
                case Color.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;   
                case Color.yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;                 
                default:
                    break;
            }

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                    Console.Write(figure[i,j]);
                Console.WriteLine();
            }
        }

        private static string[,] MakeFigurePic(int len, string symbol) //Создаем квадрат из полученных: размер квадрата, символ отрисовки! ВСПОМОГАТЕЛНЬЫЙ ВНУТРЕННИЙ МЕТОД
        {
            string[,] figurePic = new string[len,len];

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (i == 0 || j == 0 || i == len - 1 || j == len - 1)
                        figurePic[i,j] = $"{symbol} ";
                    else
                        figurePic[i,j] = "  ";
                }
            }

            return figurePic;
        }

    }

    public enum Color
    {
        red,
        green,
        yellow
    }
}
