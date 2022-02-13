using System;
using System.Collections.Generic;

namespace Homework_08
{
    struct Department
    {
        #region Конструкторы

        /// <summary>
        /// Создание департамента
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Workers">Список сотрудников</param>
        public Department(string Name, List<Worker> Workers)
        {
            this.name = Name;
            this.workers = Workers;
            this.date = DateTime.Now;
            this.countProjects = 0;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Метод подсчета общего количества проектов.
        /// </summary>
        /// <param name="workers"></param>
        /// <returns></returns>
        public int CountProj()
        {
            int countProjects = 0;

            foreach (var worker in this.workers)
                countProjects += worker.CountProjects;

            return countProjects;
        }

        /// <summary>
        /// Метод данных об отделе на экран.
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{this.name,15} {this.date,15} {this.countProjects,10}";
        }

        #endregion

        #region Свойства

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get { return this.name; } set { this.name = value; } }

        /// <summary>
        /// Имя
        /// </summary>
        public List<Worker> Workers { get { return this.workers; } set { this.workers = value; } }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get { return this.date; } private set { this.date = value; } }

        /// <summary>
        /// количество проектов
        /// </summary>
        public int CountProjects { get { return CountProj(); } private set { this.countProjects = value; } }

        #endregion

        #region Поля

        /// <summary>
        /// Поле имя
        /// </summary>
        private string name;

        /// <summary>
        /// Поле списка сотрудников
        /// </summary>
        private List<Worker> workers;

        /// <summary>
        /// Поле дата
        /// </summary>
        private DateTime date;

        /// <summary>
        /// Количество проектов
        /// </summary>
        private int countProjects;

        #endregion
    }
}