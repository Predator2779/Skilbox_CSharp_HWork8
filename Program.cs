using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_08
{
    class Program
    {
        /// Создать прототип информационной системы, в которой есть возможность работать со структурой организации
        /// В структуре присутствуют департаменты и сотрудники
        /// Каждый департамент может содержать не более 1_000_000 сотрудников.
        /// У каждого департамента есть поля: наименование, дата создания,
        /// количество сотрудников числящихся в нём*
        /// (можно добавить свои пожелания)
        /// 
        /// У каждого сотрудника есть поля: Фамилия, Имя, Возраст, департамент в котором он числится, 
        /// уникальный номер, размер оплаты труда, количество проектов закрепленных за ним.*
        ///
        /// В данной информаиционной системе должна быть возможность 
        /// - импорта и экспорта всей информации в xml и json
        /// Добавление, удаление, редактирование сотрудников и департаментов
        /// 
        /// * Реализовать возможность упорядочивания сотрудников в рамках одно департамента 
        /// по нескольким полям, например возрасту и оплате труда
        /// 
        ///  №     Имя       Фамилия     Возраст     Департамент     Оплата труда    Количество проектов
        ///  1   Имя_1     Фамилия_1          23         Отдел_1            10000                      3 
        ///  2   Имя_2     Фамилия_2          21         Отдел_2            20000                      3 
        ///  3   Имя_3     Фамилия_3          22         Отдел_1            20000                      3 
        ///  4   Имя_4     Фамилия_4          24         Отдел_1            10000                      3 
        ///  5   Имя_5     Фамилия_5          22         Отдел_2            20000                      3 
        ///  6   Имя_6     Фамилия_6          22         Отдел_1            10000                      3 
        ///  7   Имя_7     Фамилия_7          23         Отдел_1            20000                      3 
        ///  8   Имя_8     Фамилия_8          23         Отдел_1            30000                      3 
        ///  9   Имя_9     Фамилия_9          21         Отдел_1            30000                      3 
        /// 10  Имя_10    Фамилия_10          21         Отдел_2            10000                      3 
        /// 
        /// 
        /// Упорядочивание по одному полю возраст
        /// 
        ///  №     Имя       Фамилия     Возраст     Департамент     Оплата труда    Количество проектов
        ///  2   Имя_2     Фамилия_2          21         Отдел_2            20000                      3 
        /// 10  Имя_10    Фамилия_10          21         Отдел_2            10000                      3 
        ///  9   Имя_9     Фамилия_9          21         Отдел_1            30000                      3 
        ///  3   Имя_3     Фамилия_3          22         Отдел_1            20000                      3 
        ///  5   Имя_5     Фамилия_5          22         Отдел_2            20000                      3 
        ///  6   Имя_6     Фамилия_6          22         Отдел_1            10000                      3 
        ///  1   Имя_1     Фамилия_1          23         Отдел_1            10000                      3 
        ///  8   Имя_8     Фамилия_8          23         Отдел_1            30000                      3 
        ///  7   Имя_7     Фамилия_7          23         Отдел_1            20000                      3 
        ///  4   Имя_4     Фамилия_4          24         Отдел_1            10000                      3 
        /// 
        ///
        /// Упорядочивание по полям возраст и оплате труда
        /// 
        ///  №     Имя       Фамилия     Возраст     Департамент     Оплата труда    Количество проектов
        /// 10  Имя_10    Фамилия_10          21         Отдел_2            10000                      3 
        ///  2   Имя_2     Фамилия_2          21         Отдел_2            20000                      3 
        ///  9   Имя_9     Фамилия_9          21         Отдел_1            30000                      3 
        ///  6   Имя_6     Фамилия_6          22         Отдел_1            10000                      3 
        ///  3   Имя_3     Фамилия_3          22         Отдел_1            20000                      3 
        ///  5   Имя_5     Фамилия_5          22         Отдел_2            20000                      3 
        ///  1   Имя_1     Фамилия_1          23         Отдел_1            10000                      3 
        ///  7   Имя_7     Фамилия_7          23         Отдел_1            20000                      3 
        ///  8   Имя_8     Фамилия_8          23         Отдел_1            30000                      3 
        ///  4   Имя_4     Фамилия_4          24         Отдел_1            10000                      3 
        /// 
        /// 
        /// Упорядочивание по полям возраст и оплате труда в рамках одного департамента
        /// 
        ///  №     Имя       Фамилия     Возраст     Департамент     Оплата труда    Количество проектов
        ///  9   Имя_9     Фамилия_9          21         Отдел_1            30000                      3 
        ///  6   Имя_6     Фамилия_6          22         Отдел_1            10000                      3 
        ///  3   Имя_3     Фамилия_3          22         Отдел_1            20000                      3 
        ///  1   Имя_1     Фамилия_1          23         Отдел_1            10000                      3 
        ///  7   Имя_7     Фамилия_7          23         Отдел_1            20000                      3 
        ///  8   Имя_8     Фамилия_8          23         Отдел_1            30000                      3 
        ///  4   Имя_4     Фамилия_4          24         Отдел_1            10000                      3 
        /// 10  Имя_10    Фамилия_10          21         Отдел_2            10000                      3 
        ///  2   Имя_2     Фамилия_2          21         Отдел_2            20000                      3 
        ///  5   Имя_5     Фамилия_5          22         Отдел_2            20000                      3 
        /// 

        static void Main(string[] args)
        {
            char contin = 'y';

            while (contin == 'y')
            {
                Console.WriteLine(
                    $"[1] Задание 1. Работа с листом.\n" +
                    $"[2] Задание 2. Телефонная книга.\n" +
                    $"[3] Задание 3. Проверка повторов.\n" +
                    $"[4] Задание 4. Записная книжка.\n");

                int n;

                if (Int32.TryParse(Console.ReadLine(), out n))
                    switch (n)
                    {
                        case 1:
                            TaskOne();
                            break;
                        case 2:
                            TaskTwo();
                            break;
                        case 3:
                            TaskThree();
                            break;
                        case 4:
                            TaskFour();
                            break;
                    }

                Console.WriteLine("Продолжить? y/n");
                contin = Convert.ToChar(Console.ReadLine());
            }
        }

        #region Задание 1

        /// <summary>
        /// Создание пустого списка.
        /// </summary>
        static List<int> numbers = new List<int>();

        /// <summary>
        /// Выполнение методов первого задания.
        /// </summary>
        static void TaskOne()
        {
            CreationNumbers();
            PrintNumbers();
            RemoveNumber();
            PrintNumbers();
            SortingNumbers();
            PrintNumbers();
        }

        /// <summary>
        /// Генерация случайных чисел от 0 до 100.
        /// </summary>
        static void CreationNumbers()
        {
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                int randNumber = rand.Next(0, 101);
                numbers.Add(randNumber);
            }
        }

        /// <summary>
        /// Удаление чисел в диапазоне от 25 до 50.
        /// </summary>
        static void RemoveNumber()
        {
            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] > 25 && numbers[i] < 50)
                {
                    numbers.RemoveAt(i);
                    /// Шаг назад, т.к. размер списка изменился и список сдвинулся.
                    i--;
                }
        }

        /// <summary>
        /// Вывод списка на экран.
        /// </summary>
        static void PrintNumbers()
        {
            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i] + " ");

            Console.WriteLine(); Console.WriteLine("count = " + numbers.Count); Console.WriteLine();
        }

        /// <summary>
        /// Сортировка списка.
        /// </summary>
        static void SortingNumbers()
        {
            numbers.Sort();
        }

        #endregion

        #region Задание 2

        /// <summary>
        /// Создание пустого словаря.
        /// </summary>
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();

        /// <summary>
        /// Выполнение методов второго задания.
        /// </summary>
        static void TaskTwo()
        {
            Input();
            Searching();
        }

        /// <summary>
        /// Метод ввода данных.
        /// </summary>
        static void Input()
        {
            char contin = 'y';

            while (contin == 'y')
            {
                Console.WriteLine("\nВведите ФИО владельца номера телефона:");
                string name = Console.ReadLine();

                bool conti = true;

                while (conti)
                {
                    Console.WriteLine("\nВведите номер телефона:");
                    string number = Console.ReadLine();

                    if (number != "")
                    {
                        if (!dictionary.ContainsKey(number))
                            dictionary.Add(number, name);
                        else
                            Console.WriteLine("\nДанный номер уже есть в базе.");
                    }
                    else
                        conti = false;
                }

                Console.WriteLine("Продолжить? y/n");
                contin = Convert.ToChar(Console.ReadLine());
            }
        }

        /// <summary>
        /// Метод поиска по номеру.
        /// </summary>
        static void Searching()
        {
            string name;

            char contin = 'y';

            while (contin == 'y')
            {
                Console.WriteLine("\nПоиск по номеру телефона. Введите номер:");
                string number = Console.ReadLine();
                if (dictionary.TryGetValue(number, out name))
                    Console.WriteLine(name);
                else
                    Console.WriteLine("\nНомер не существует.\n");

                Console.WriteLine("Продолжить? y/n");
                contin = Convert.ToChar(Console.ReadLine());
            }
        }

        #endregion

        #region Задание 3

        /// <summary>
        /// Создание пустого множества.
        /// </summary>
        static HashSet<int> hashSet = new HashSet<int>();

        /// <summary>
        /// Выполнение методов третьего задания.
        /// </summary>
        static void TaskThree()
        {
            AddNumber();
        }

        /// <summary>
        /// Метод добавление числа.
        /// </summary>
        static void AddNumber()
        {
            char contin = 'y';

            while (contin == 'y')
            {
                Console.WriteLine("\nВведите число:");

                if (hashSet.Add(Convert.ToInt32(Console.ReadLine())))
                    Console.WriteLine("\nЧисло успешно сохранено.");
                else
                    Console.WriteLine("\nЧисло уже есть в списке.");

                Console.WriteLine("Продолжить? y/n");
                contin = Convert.ToChar(Console.ReadLine());
            }
        }

        #endregion

        #region Задание 4

        /// <summary>
        /// Выполнение методов четвертого задания.
        /// </summary>
        static void TaskFour()
        {
            CreateXML();

            Console.WriteLine("Вывести на экран? y/n");

            if (Convert.ToChar(Console.ReadLine()) == 'y')
                ReadXML();
        }

        /// <summary>
        /// Метод создания xml.
        /// </summary>
        static void CreateXML()
        {
            XElement ListPerson = new XElement("ListPerson");

            char contin = 'y';

            while (contin == 'y')
            {
                Console.WriteLine("Введите ФИО:");
                XAttribute name = new XAttribute("name", Console.ReadLine());

                Console.WriteLine("Введите улицу:");
                XElement Street = new XElement("street", Console.ReadLine());

                Console.WriteLine("Введите номер дома:");
                XElement HouseNumber = new XElement("HouseNumber", Console.ReadLine());

                Console.WriteLine("Введите номер квартиры:");
                XElement FlatNumber = new XElement("FlatNumber", Console.ReadLine());

                Console.WriteLine("Введите номер мобильного телефонао:");
                XElement MobilePhone = new XElement("MobilePhone", Console.ReadLine());

                Console.WriteLine("Введите номер домашнего телефона:");
                XElement FlatPhone = new XElement("FlatPhone", Console.ReadLine());

                XElement Person = new XElement("Person");
                XElement Address = new XElement("Address");
                XElement Phones = new XElement("Phones");

                Phones.Add(MobilePhone); Phones.Add(FlatPhone);
                Address.Add(Street); Address.Add(HouseNumber); Address.Add(FlatNumber); 
                Person.Add(name); Person.Add(Address); Person.Add(Phones);

                ListPerson.Add(Person);

                Console.WriteLine("Продолжить? y/n");
                contin = Convert.ToChar(Console.ReadLine());
            }

            ListPerson.Save("_ListPerson.xml");
        }

        /// <summary>
        /// Метод чтения xml.
        /// </summary>
        static void ReadXML()
        {
            string xml = System.IO.File.ReadAllText("_ListPerson.xml");

            Console.WriteLine(xml);
        }

        #endregion
    }
}
