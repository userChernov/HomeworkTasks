using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t8
{
    /*
     * Внутри метода Main() дан список строк list. Реализуйте следующую логику работы со списком:
     *      1) Удалите из списка все слова, содержащие букву Т.
     *      2) Все слова содержащие букву Б сделайте в ВЕРХНЕМ РЕГИСТРЕ.
     *      3) Во всех словах, содержащих букву Р - замените её на букву Л.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "собака", "улыбака", "мурка", "кот", "бурка", "Сивка", "баркаc" };
            /* Добавьте свой код ниже */
            string item;

            List<string> correctList = new List<string>();


            foreach (string word in list)
            {
                string element = word;
                bool shouldWeAdd = true;

                if (element.Contains('Т') || element.Contains('т'))
                {
                    shouldWeAdd = false;
                }
                else
                {
                    if (element.Contains('Б') || element.Contains('б'))
                    {
                        element = element.ToUpper();
                    }
                    if (element.Contains('Р') || element.Contains('р'))
                    {
                        char[] letters = element.ToCharArray();

                        for (int i = 0; i < letters.Length; i++)
                        {
                            if (letters[i] == 'Р')
                                letters[i] = 'Л';
                            if (letters[i] == 'р')
                                letters[i] = 'л';
                        }

                        element = new string(letters);
                    }
                }

                if (shouldWeAdd)
                    correctList.Add(element);
                
            }


            // for (int i = 0; i < list.Count; i++)
            // {
            //     if (list[i].Contains('Т') || list[i].Contains('т'))
            //     {
            //         list.RemoveAt(i);
            //     }
            //     if (list[i].Contains('Б') || list[i].Contains('б'))
            //     {
            //         list[i] = list[i].ToUpper();
            //     }
            //     if (list[i].Contains('Р') || list[i].Contains('р'))
            //     {
            //         char[] letters = list[i].ToCharArray();

            //         for (int j = 0; j < letters.Length; j++)
            //         {
            //             if (letters[j] == 'Р')
            //                 letters[j] = 'Л';
            //             if (letters[j] == 'р')
            //                 letters[j] = 'л';
            //         }

            //         list[i] = new string(letters);
            //     }
            // }



            foreach (var str in correctList)
            {
                Console.WriteLine(str);
            }
        }
    }
}

