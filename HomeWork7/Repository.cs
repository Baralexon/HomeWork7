using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Repository
    {
        
        
        /// <summary>
        /// Чтение из файла и возврат массива считанных экземпляров
        /// </summary>
        /// <returns></returns>
        public Worker[] GetAllWorkers()
        {
            Worker w = new Worker();
            // здесь происходит чтение из файла
            // и возврат массива считанных экземпляров
            string text = File.ReadAllText(@"c:\Users\Александр\source\repos\HomeWork7\employees.txt");
            string [] x = text.Split('#');
            foreach (string line in x)
            {
                return Worker[];
               
            }
            
        }

        /// <summary>
        /// Чтение из файла, возвращается Worker с запрашиваемым ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Worker GetWorkerById(int ID)
        {
            Worker w = new Worker();
            // происходит чтение из файла, возвращается Worker
            // с запрашиваемым ID
            string text = File.ReadAllText(@"employees.txt");
            return w.ID;
        }

        /// <summary>
        /// Удаление Worker по ID
        /// </summary>
        /// <param name="ID"></param>
        public void DeleteWorker(int ID)
        {
            // считывается файл, находится нужный Worker
            // происходит запись в файл всех Worker,
            // кроме удаляемого
        }


        /// <summary>
        /// Добавление нового worker в файл
        /// </summary>
        /// <param name="worker"></param>
        public void AddWorker(Worker worker)
        {
            // присваиваем worker уникальный ID,
            // дописываем нового worker в файл
            
            Console.Write("Введите ID сотрудника: ");
            worker.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Ф.И.О. сотрудника: ");
            worker.FIO = Console.ReadLine();
            Console.Write("Введите возраст сотрудника: ");
            worker.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рост сотрудника (в см): ");
            worker.height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год рождения сотрудника: ");
            worker.birthday = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите место рождения сотрудника: ");
            worker.birthplace = Console.ReadLine();
            

            string TEXT = $"{ID}#{DateTime.Now}#{FIO}#{age}#{height}#{birthday.ToShortDateString()}#{birthplace}";
            File.AppendAllText(@"c:\Users\Александр\source\repos\HomeWork7\employees.txt", TEXT + "\n"); //
            Console.WriteLine();


        }

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            Worker w = new Worker();
            // здесь происходит чтение из файла
            // фильтрация нужных записей
            // и возврат массива считанных экземпляров

            string text = File.ReadAllText(@"employees.txt");

            return text;
        }


    }
}
