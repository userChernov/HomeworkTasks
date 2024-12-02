using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22
{
    /*
     * Реализуйте класс Student таким образом, чтобы он содержал 3 свойства:
     *      1) Имя.
     *      2) Возраст.
     *      3) Кафедра (Cathedra).
     * Добавьте в класс Student конструктор, который принимает имя и возраст, а кафедру укажите любую.
     * Сделайте так, чтобы в случае если переданный возраст объекта был меньше 17 или больше 70, то
     * ему бы присваивалось значение 20, а в остальных случаях - переданное значение.
     */

    public class Student
    {
        /* Добавьте свой код ниже */
        public string Name { set; get; }
        public int Age { set; get; }
        public string Cathedra { set; get; }

        public Student(string name, int age)
        {
            this.Name = name;

            if (age < 17 || age > 70)
                this.Age = 20;
            else
                this.Age = age;
            
            this.Cathedra = "Право";
        }

        public override string ToString()
        {
            return $"{this.Name} : {this.Age} : {this.Cathedra}";
        }


        public static void Main(string[] args)
        {
            Student first = new Student("Георгий", 23);
            Student second = new Student("Роман", 15);

            Console.WriteLine(first);
            Console.WriteLine(second);

        }
    }
}
