using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0, k = 100, delete = 0;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            var array = Enumerable.Range(1,101).ToList();

            writeSizeArray(ref n, ref m);

            while ((n * m) > 100)
            {
                Console.WriteLine($"\nНевозможно создать массив, т.к. он содержит более 100 элементов.\n");
                writeSizeArray(ref n, ref m);
            }

            Console.WriteLine($"\nРазмер двумерного массива: {n} x {m}\n");         

            int[,] mass = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    delete = rand.Next(0, k);
                    mass[i, j] = array[delete];
                    array.RemoveAt(delete);
                    k--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mass[i, j]} \t");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }

        static void writeSizeArray(ref int row,ref int colomb)
        {
            Console.WriteLine("Введите количество строк в двумерном массиве:");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в двумерном массиве:");
            colomb = Convert.ToInt32(Console.ReadLine());
        }
    }
}
