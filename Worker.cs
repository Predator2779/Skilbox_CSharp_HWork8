using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    public class Worker
    {
        #region Конструкторы

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="FirstName">Имя</param>
        /// <param name="LastName">Фамилия</param>
        /// <param name="Age">Возрасты</param>
        /// <param name="Department">Отдел</param>
        /// <param name="Salary">Оплата труда</param>
        /// <param name="CountProjects">Количество проектов</param>
        public Worker(int ID, string FirstName, string LastName, int Age, uint Salary, string Department, int CountProjects)
        {
            this.id = ID;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.age = Age;
            this.department = Department;
            this.salary = Salary;
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
        /// ID
        /// </summary>
        public int ID { get { return this.id; } private set { this.id = value; } }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        /// <summary>
        /// Должность
        /// </summary>
        public int Position { get { return this.age; } set { this.age = value; } }

        /// <summary>
        /// Отдел
        /// </summary>
        public string Department { get { return this.department; } set { this.department = value; } }

        /// <summary>
        /// Оплата труда
        /// </summary>
        public uint Salary { get { return this.salary; } set { this.salary = value; } }

        /// <summary>
        /// количество проектов
        /// </summary>
        public int CountProjects { get { return this.countProjects; } set { this.countProjects = value; } }


        #endregion

        #region Поля

        /// <summary>
        /// ID
        /// </summary>
        private int id;

        /// <summary>
        /// Поле "Имя"
        /// </summary>
        private string firstName;

        /// <summary>
        /// Поле "Фамилия"
        /// </summary>
        private string lastName;

        /// <summary>
        /// Поле "Должность"
        /// </summary>
        private int age;

        /// <summary>
        /// Поле "Отдел"
        /// </summary>
        private string department;

        /// <summary>
        /// Поле "Оплата труда"
        /// </summary>
        private uint salary;

        /// <summary>
        /// Количество проектов
        /// </summary>
        private int countProjects;

        #endregion
    }
}
