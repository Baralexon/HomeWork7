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
       /// <summary>
       /// Идентификационный номер
       /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Фамилия Имя Отчество
        /// </summary>
        public string FIO { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public int age { get; set; } 
        /// <summary>
        /// Рост
        /// </summary>
        public int height { get; set; }
        
        /// <summary>
        /// гг.мм.дд дата рождения
        /// </summary>
        public DateTime birthday;

        /// <summary>
        /// Место рождения
        /// </summary>
        public string birthplace { get; set; }

        public string Print()
        {
            return $"{ID}#{DateTime.Now}#{FIO}#{age}#{height}#{birthday.ToShortDateString()}#{birthplace}";
        }


        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="ID">Идентификайионный номер</param>
        /// <param name="FIO">Ф.И.О.</param>
        /// <param name="age">Возраст</param>
        /// <param name="height">Рост</param>
        /// <param name="birthday">Дата рождения</param>
        /// <param name="birthplace">Место рождения</param>
        public Worker(int ID, string FIO, int age, int height, DateTime birthday, string birthplace) 
             //this(ID, FIO, age, height, birthday, birthplace)
        {
            this.ID = ID;
            this.FIO = FIO;
            this.age = age;
            this.height = height;
            this.birthday = birthday;
            this.birthplace = birthplace;
        }
    }
}
