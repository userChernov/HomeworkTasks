using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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

            string[] eventLog = {
                "1_message_StormRage_1_active",
                "2_message_StormRage_2_active",
                "3_request_Pepe_3_ok",
                "4_request_Pepe_4_fail",
                "5_message_Guffi_6_active",
                "6_message_CatTim_10_ok",
                "7_request_StormRage_7_fail",
                "8_message_StormRage_8_active",
                "9_request_Pepe_5_ok",
                "10_message_Pepe_15_ok"
            };

            Dictionary<string, List<long>> messageTime = new Dictionary<string, List<long>>();
            Dictionary<string, List<long>> requestTime = new Dictionary<string, List<long>>();


            for (int i = 0; i < eventLog.Length; i++)
            {
                string[] parts = eventLog[i].Split("_");

                if (parts.Length != 5)
                    continue;

                string eventType = parts[1];
                string userName = parts[2];
                long deltaTime = Convert.ToInt64(parts[3]);

                switch (eventType)
                {
                    case "message":
                        if (!messageTime.ContainsKey(userName))
                            messageTime.Add(userName, new List<long>());

                        messageTime[userName].Add(deltaTime);
                        break;
                    case "request":
                        if (!requestTime.ContainsKey(userName))
                            requestTime.Add(userName, new List<long>());

                        requestTime[userName].Add(deltaTime);
                        break;
                }
            }

            foreach (var item in messageTime)
            {
                string name = item.Key;
                List<long> times = item.Value.OrderBy(x => x).ToList();

                if (times.Count <2)
                    continue;
                    
                for (int i = 0; i < times.Count - 1; i++)
                {
                    if (times[i + 1] - times[i] < 5)
                    {
                        Program.blockedUsers.Add(item.Key, Program.allUsers[item.Key]);
                        break;
                    }
                }
            }

            foreach (var item in requestTime)
            {
                string name = item.Key;
                List<long> times = item.Value.OrderBy(x => x).ToList();

                if (times.Count <2)
                    continue;
                    
                for (int i = 0; i < times.Count - 1; i++)
                {
                    if (times[i + 1] - times[i] < 2)
                    {
                        Program.blockedUsers.Add(item.Key, Program.allUsers[item.Key]);
                        break;
                    }
                }
            }

            foreach (var item in Program.blockedUsers)
            {
                Console.WriteLine($"{item.Key}_{item.Value.Account}_{item.Value.Surname}_{item.Value.Name}_{item.Value.IP}");
            }

        }
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

