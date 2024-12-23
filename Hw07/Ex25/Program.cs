using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t25
{
    /*
     * На вход в метод Main() подается массив строк, который содержит сведения из некоторого системного журнала логов.
     * Каждая строка - это отдельный лог, событие, которое произошло и было зафиксировано. Нам необходимо вычислить
     * пользователей, которые являются спамерами, и добавить их IP-адрес в список заблокированных.
     *
     * Формат строки лога:
     * ID_EVENT_USER_DATETIME_STATUS, где:
     *      1) ID - число, ID лога;
     *      2) EVENT - строка с типом события (message, act, request);
     *      3) USER - строка с учетной записью пользователя;
     *      4) DATETIME - числовое представление даты создания события;
     *      5) STATUS - строка с информацией о статусе события.
     *
     * Список всех пользователей и их IP-адресов находится переменной allUsers, где ключ это учетная запись пользователя.
     * Список заблокированных пользователей и их IP-адреса должны находится в переменной blockedUsers.
     *
     * Логика определения спамеров должна быть следующая:
     *      1) Если пользователь оправляет сообщение (event - message) чаще чем 1 раз в 5 секунд.
     *      2) Если пользователь отправляет запрос чаще чем 1 раз в 2 секунды.
     *
     * Выведите в консоль всех заблокированных пользователей в формате: "ACCOUNT_SURNAME_NAME - IP" каждое значение с новой строки, где:
     *      ACCOUNT - учетная запись пользователя;
     *      SURNAME - фамилия пользователя;
     *      NAME - имя пользователя;
     *      IP - IP-адрес пользователя.
     * Вся логика работы программы должна быть реализована в методе Main(), остальные элементы шаблона изменять нельзя.
     */

    public class Analyzer
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Clear();

            string[] eventLog = new string[10];
            string[][] newEventLog = new string[eventLog.Length][];

            //EventLogGen(ref eventLog);

            for (int i = 0; i < newEventLog.Length; i++)
            {
                newEventLog[i] = eventLog[i].Split("_");
            }
                
            foreach (var item in Program.allUsers)
            {
                string user = item.Key;
                
                List<long> messageTime = new List<long>();
                List<long> requestTime = new List<long>();

                bool isSpamer = false;

                for (int i = 0; i < newEventLog.Length; i++)
                {
                    if ( newEventLog[i][2] == user && Equals( newEventLog[i][1], "message" ) )
                    {
                        messageTime.Add( Convert.ToInt64(newEventLog[i][3]) );
                    }
                    else if ( newEventLog[i][2] == user && Equals( newEventLog[i][1], "reqest" ) )
                    {
                        requestTime.Add( Convert.ToInt64(newEventLog[i][3]) );
                    }
                }

                messageTime.Sort();
                requestTime.Sort();

                if (messageTime.Count > 1)
                {
                    for (int i = 0; i < messageTime.Count - 1; i++)
                    {
                        if ( Math.Abs( messageTime[i] - messageTime[i+1] ) <= 50000000 )
                        {
                            isSpamer = true;
                        }
                    }
                }

                if (requestTime.Count > 1)
                {
                    for (int i = 0; i < requestTime.Count - 1; i++)
                    {
                        if ( Math.Abs( requestTime[i] - requestTime[i+1] ) <= 20000000 )
                        {
                            isSpamer = true;
                        }
                    }
                }

                if (isSpamer)
                {
                    Program.blockedUsers.Add(item.Key, item.Value);
                }
                
            }
            
        }

        // private static void EventLogGen(ref string[] array)
        // {
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         array[i] = $"{i}_";
        //     }
        // }


        // private static string EventGen()
        // {
        //     Random rand = new Random();
        //     string userEvent = "";

        //     switch (rand.Next(3))
        //         {
        //             case 0:
        //                 userEvent = "message";
        //                 break;
        //             case 1:
        //                 userEvent = "act";
        //                 break;
        //             case 2:
        //                 userEvent = "request";
        //                 break;
        //         }

        //     return userEvent;
        // }

        // private static int dateGen()
        // {
        //     int date = 0;
        //     Random rand = new Random();

        //     return date;
        // }

    }

    public static class Program
    {
        public static Dictionary<string, UserInfo> allUsers = new Dictionary<string, UserInfo>();
        public static Dictionary<string, UserInfo> blockedUsers = new Dictionary<string, UserInfo>();
        static Program()
        {
            allUsers.Add("StormRage", new UserInfo("StormRage", "10.11.12.168", "Рядовой", "Билли"));
            allUsers.Add("Pepe", new UserInfo("Pepe", "192.196.11.21", "Жабка", "Пепе"));
            allUsers.Add("Guffi", new UserInfo("Guffi", "192.11.51.168", "Джон", "Гук"));
            allUsers.Add("CatTim", new UserInfo("CatTim", "33.7.122.225", "Тим", "Кот"));
        }
    }

    public class UserInfo
    {
        public string Account { get; set; }
        public string IP { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public UserInfo(string account, string ip, string name, string surname)
        {
            Account = account;
            IP = ip;
            Name = name;
            Surname = surname;
        }
    }
}

