using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class Department
    {
        #region Конструкторы

        /// <summary>
        /// Создание департамента
        /// </summary>
        /// <param name="FirstName">Имя</param>
        /// <param name="DateOfCreate">Дата создания</param>
        /// <param name="CountProjects">Количество проектов</param>
        public Department (string FirstName, DateTime Date, int CountProjects)
        {
            this.firstName = FirstName;
            this.date = Date;
            this.countProjects = CountProjects;
        }

        #endregion

        #region Методы

        //public string Print()
        //{
        //    return $"{this.firstName,15} {this.lastName,15} {this.department,15} {this.position,15} {this.salary,10}";
        //}

        #endregion

        #region Свойства

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get { return this.date; } set { this.date = value; } }

        /// <summary>
        /// количество проектов
        /// </summary>
        public int CountProjects { get { return this.countProjects; } set { this.countProjects = value; } }

        #endregion

        #region Поля

        /// <summary>
        /// Поле "Имя"
        /// </summary>
        private string firstName;

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
