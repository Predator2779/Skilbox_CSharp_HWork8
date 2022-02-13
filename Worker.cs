namespace Homework_08
{
    struct Worker
    {
        #region Конструкторы

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="FirstName">Имя</param>
        /// <param name="LastName">Фамилия</param>
        /// <param name="Age">Возрасты</param>
        /// <param name="Salary">Оплата труда</param>
        /// <param name="CountProjects">Количество проектов</param>
        public Worker(int ID, string FirstName, string LastName, int Age, uint Salary, int CountProjects)
        {
            this.id = ID;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.age = Age;
            this.salary = Salary;
            this.countProjects = CountProjects;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Метод данных о сотруднике на экран.
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{this.id,15} {this.firstName,15} {this.lastName,15} {this.age,15} {this.salary,15} {this.countProjects,10}";
        }

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