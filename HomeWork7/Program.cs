using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository r = new Repository();

            if (File.Exists(@"employees.txt") == true) // проверка существования файла "employees.txt"
            {
                Console.WriteLine("Если хотите посмотреть список сотрудников нажмите - 1\n" +
                "Если хотите вывести данные о Worker по заданному ID нажмите - 2\n" +
                "Если хотите удалить данные о Worker по заданному ID нажмите - 3\n" +
                "Если хотите добавить нового worker в файл нажмите - 4\n" +
                "Если хотите отфильтровать нужные записи нажмите - 5");
                string N = Console.ReadLine();// выбор номера метода: от 1 до 5
                switch (N)
                {
                    case "1":
                        r.GetAllWorkers();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Введите номер ID");
                        int ID = int.Parse(Console.ReadLine());
                        r.GetWorkerById(ID);
                        Console.ReadKey();
                        break;
                    //case "3":
                    //    Console.WriteLine("Введите номер ID");
                    //    int ID = int.Parse(Console.ReadLine());
                    //    r.DeleteWorker(ID);
                    //    break;
                    //case "4":
                    //    r.AddWorker();
                    //    break;
                    //case "5":
                    //    r.GetWorkersBetweenTwoDates();
                    //    break;

                    default:
                        Console.WriteLine("Введено неверно!");
                        Console.ReadKey();
                        break;
                }
            }

            else
            {
                Console.WriteLine("Похоже, что справочник «Сотрудники» еще не существует и сейчас он будет создан");
                Console.ReadKey();
                //        r.AddWorker(Worker worker);
                //}       Console.ReadKey();

            }

        }

    }
}
