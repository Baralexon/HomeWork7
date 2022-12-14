using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork7
{
    class Repository
    {


        /// <summary>
        /// Чтение из файла и возврат массива считанных экземпляров
        /// </summary>
        /// <returns></returns>
        public void GetAllWorkers()  // Worker[] надо
        {
            // здесь происходит чтение из файла
            // и возврат массива считанных экземпляров
            Worker w = new Worker();
            using (StreamReader sr = new StreamReader("employees.txt"))
            {
                string line = string.Empty;
                Console.WriteLine($"{"ID", 1} {"время", 10} {"ФИО", 11} {"Возраст", 21} {"рост"} {"день рождения"} {"место рождения", 5}");

                while ((line = sr.ReadLine()) != null)
                {
                    string [] x = line.Split('#');
                    foreach (string s in x)
                    Console.Write($"{s} ");
                     
                    w.Print();
                    Console.WriteLine();
                    
                }
                //return ;
            }

        }

        /// <summary>
        /// Чтение из файла, возвращается Worker с запрашиваемым ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public void GetWorkerById(int ID)  // Worker надо
        {
            // происходит чтение из файла, возвращается Worker
            // с запрашиваемым ID
            Worker w = new Worker();
            using (StreamReader sr = new StreamReader("employees.txt"))
            {
                string line = String.Empty;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] x = line.Split('#');
                    foreach (string s in x)
                    //return s;
                    w.Print();
                    //Console.WriteLine(sr.ReadLine());
                }

            }
        }




        ///// <summary>
        ///// Удаление Worker по ID
        ///// </summary>
        ///// <param name="ID"></param>
        //public void DeleteWorker(int ID)
        //{
        //    // считывается файл, находится нужный Worker
        //    // происходит запись в файл всех Worker,
        //    // кроме удаляемого
        //}


        ///// <summary>
        ///// Добавление нового worker в файл
        ///// </summary>
        ///// <param name="worker"></param>
        //public void AddWorker(Worker worker)
        //{
        //    // присваиваем worker уникальный ID,
        //    // дописываем нового worker в файл

        //    Console.Write("Введите ID сотрудника: ");
        //    worker.ID = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Введите Ф.И.О. сотрудника: ");
        //    worker.FIO = Console.ReadLine();
        //    Console.Write("Введите возраст сотрудника: ");
        //    worker.age = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Введите рост сотрудника (в см): ");
        //    worker.height = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Введите год рождения сотрудника: ");
        //    worker.birthday = Convert.ToDateTime(Console.ReadLine());
        //    Console.Write("Введите место рождения сотрудника: ");
        //    worker.birthplace = Console.ReadLine();


        //    string TEXT = $"{ID}#{DateTime.Now}#{FIO}#{age}#{height}#{birthday.ToShortDateString()}#{birthplace}";
        //    File.AppendAllText(@"c:\Users\Александр\source\repos\HomeWork7\employees.txt", TEXT + "\n"); //
        //    Console.WriteLine();


        //}

        //public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        //{
        //    Worker w = new Worker();
        //    // здесь происходит чтение из файла
        //    // фильтрация нужных записей
        //    // и возврат массива считанных экземпляров

        //    string text = File.ReadAllText(@"employees.txt");

        //    return text;
        //}


    }
}
