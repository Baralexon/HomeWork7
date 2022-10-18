using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Worker w = new Worker();
            Random random = new Random();
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[,] y = new int[N,M];
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    y[i,j] = random.Next(10);
                    Console.WriteLine(y[i,j]);
                    Console.ReadKey();
                    

                }
            }

   
        }
    }
}
