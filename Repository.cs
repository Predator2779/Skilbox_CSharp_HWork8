using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Homework_08
{
    struct Repository
    {
        #region Поля

        /// <summary>
        /// Список отделов.
        /// </summary>
        List<Department> deps;

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private readonly string path;

        /// <summary>
        /// Рандом.
        /// </summary>
        private Random rand;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор репозитория.
        /// </summary>
        /// <param name="Path">Путь к хранению</param>
        public Repository(string Path)
        {
            this.deps = new List<Department>();
            this.path = Path;
            this.rand = new Random();
        }

        #endregion

        #region Методы

        /// <summary>
        /// Создание списка отделовт.
        /// </summary>
        /// <param name="amountDeps"></param>
        private void CreatingListDeps(int amountDeps)
        {
            for (int i = 0; i < amountDeps; i++)
            {
                List<Worker> workers = new List<Worker>();

                workers = CreatingDep();

                Department dep = new Department($"Отдел_{i + 1}", workers);
                dep.CountProj();
                deps.Add(dep);
            }
        }

        /// <summary>
        /// Создание списка сотрудников.
        /// </summary>
        /// <returns></returns>
        private List<Worker> CreatingDep()
        {
            List<Worker> workers = new List<Worker>();

            for (int i = 0; i < 10; i++)
            {
                workers.Add(
                    new Worker(
                        i + 1,
                        $"Имя_{i}",
                        $"Фамилия_{i}",
                        this.rand.Next(20, 51),
                        (uint)this.rand.Next(1000, 2001),
                        this.rand.Next(1, 11)));
            }

            return workers;
        }

        /// <summary>
        /// Вывод на экран информации об отделах.
        /// </summary>
        private void PrintDeps()
        {
            foreach (var dep in deps)
            {
                Console.WriteLine(dep.Name);
                Console.WriteLine($"Проектов в отделе: {dep.CountProjects}");
                Console.WriteLine($"Дата создания отдела: {dep.Date}");

                foreach (var worker in dep.Workers)
                    Console.WriteLine(worker.Print());

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Сохранение в Json.
        /// </summary>
        public void SaveJson()
        {
            CreatingListDeps(3);

            int numDep = 1;

            foreach (var dep in deps)
            {
                string nameJson = "_department" + Convert.ToString(numDep);

                string json = JsonConvert.SerializeObject(dep);
                File.WriteAllText(path + nameJson + ".json", json);

                numDep++;
            }
        }

        /// Создать сохранение XMl, сортировку, добавление изменение сотрудников отдела.

        #endregion
    }
}
