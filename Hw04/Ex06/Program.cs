using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    /*
     * 
     * Создайте класс Human в том же файле и том же namespace, что и класс Program. 
     * Внутри класса Human объявите 3 переменные (lastName, firstName, middleName), которые будут содержать в себе фамилию, имя и отчество. 
     * Тип переменных определите самостоятельно.
     * Реализуйте два метода:
        1) SetNames(), который принимает в качестве параметра 3 строки, содержащие фамилию, имя и отчество человека,
        и записывает их в соответствующие переменные класса;
        2) GetFullName(), который возвращает фамилию, имя и отчество в виде 1 строки через пробел.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            string humanName;

            Human ivan = new Human();

            ivan.SetNames("Иванов", "Иван", "Иванович");

            humanName = ivan.GetFullName();
            Console.WriteLine(humanName);
        }
    }
    /* Добавьте свой код ниже */

    public class Human()
    {
        public string lastName;
        public string firstName;
        public string middleName;

        public void SetNames(string lastName, string firstName, string middleName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
        }

        public string GetFullName()
        {
            return (lastName + " " + firstName + " " + middleName);
        }

    }
}
