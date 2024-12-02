using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    /*
     * Проанализируйте поля класса Cat. Все его поля сейчас являются константами, что не запрещено, но противоречит здравому смыслу.
     * Некоторые заданные значения у полей класса Cat также являются некорректными.
     * Вам необходимо:
     *      1) Подумать и сделать так, чтобы поля класса Cat перестали являться константами там, где в этом нет никакой необходимости.
     *      2) Посмотреть на значения полей класса Cat по умолчанию, определить, какие из значений явно не соответствуют действительности, и поменять их.
     *      3) Если вы решили, что поле не является константой, то его значение по умолчанию необходимо убрать.
     * Количество полей класса Cat изменять нельзя.
     */

    public class Cat
    {
        int catCount;
        string catName;
        const int legsCount = 4;
        string catBreed;
        const int tailCount = 1;
        string catColor;

        public static void Main(string[] args)
        {
        }
    }
}