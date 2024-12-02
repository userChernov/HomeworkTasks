using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    /*
     * Для всех приватных полей класса Flower реализуйте сеттеры и геттеры.
     * Шаблон полей класса изменять нельзя.
     */

    public class Flower
    {
        private string color = "NoColor";
        private string title = "NoTitle";

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }


        //public void GetColor()
        public string GetColor()
        {
            /* Добавьте свой код ниже */
            return this.color;
        }
        public void SetColor(string color)
        {
            /* Добавьте свой код ниже */
            this.color = color;
        }


        //public void GetTitle()
        public string GetTitle()
        {
            /* Добавьте свой код ниже */
            return this.title;
        }

        public void SetTitle(string title)
        {
            /* Добавьте свой код ниже */
            this.title = title;
        }
    }
}
