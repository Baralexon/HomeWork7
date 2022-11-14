using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    struct Worker
    {

        #region Конструктор

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="ID">Идентификайионный номер</param>
        /// <param name="FIO">Ф.И.О.</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        /// <param name="Birthday">Дата рождения</param>
        /// <param name="Birthplace">Место рождения</param>
        public Worker(int ID, string FIO, int Age, int Height, DateTime Birthday, string Birthplace)
        {
            this.id = ID;
            this.fio = FIO;
            this.age = Age;
            this.height = Height;
            this.birthday = Birthday;
            this.birthplace = Birthplace;
        }
        #endregion

        #region Метод
        public string Print()
        {
            return $"{this.id, 15}#{DateTime.Now, 20}#{this.fio, 30}#{this.age, 5}#{this.height, 5}#{this.birthday.ToShortDateString(), 12}#{this.birthplace, 15}\n";
        }

        #endregion

        #region Свойства

        /// <summary>
        /// Идентификационный номер
        /// </summary>
        public int ID { get { return this.id; } set { this.id = value; } }
        /// <summary>
        /// Фамилия Имя Отчество
        /// </summary>
        public string FIO { get { return this.fio; } set { this.fio = value; } }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get { return this.age; } set { this.age = value; } }
        /// <summary>
        /// Рост
        /// </summary>
        public int Height { get { return this.height; } set { this.height = value; } }

        /// <summary>
        /// гг.мм.дд дата рождения
        /// </summary>
        public DateTime Birthday { get { return this.birthday; } set { this.birthday = value; } }

        /// <summary>
        /// Место рождения
        /// </summary>
        public string Birthplace { get { return this.birthplace; } set { this.birthplace = value; } }

        #endregion

        #region Поля

        /// <summary>
        /// Идентификационный номер
        /// </summary>
        private int id;
        /// <summary>
        /// Фамилия Имя Отчество
        /// </summary>
        private string fio;
        /// <summary>
        /// Возраст
        /// </summary>
        private int age;
        /// <summary>
        /// Рост
        /// </summary>
        private int height;

        /// <summary>
        /// гг.мм.дд дата рождения
        /// </summary>
        private DateTime birthday;

        /// <summary>
        /// Место рождения
        /// </summary>
        private string birthplace;

        #endregion


    }



}
