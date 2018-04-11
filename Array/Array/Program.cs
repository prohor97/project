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


            Sort.writeSortArray(mass, n, m);

            int number = 0;
            bool flag = true;
           
            Console.WriteLine("\nСортировка массива:");
            Console.WriteLine("- Нажмите 0, что бы отсортировать массив по возрастанию.");
            Console.WriteLine("- Нажмите 1, что бы отсортировать массив по убыванию.");

            while (flag == true)
            {
                Console.WriteLine("Введите номер сортировки:");
                number = Convert.ToInt32(Console.ReadKey().Key);
                if (number == 97 || number == 96 || number == 49 || number == 48)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("\nСортировка под введённым порядковым номером отсутствует");
                }
            }

            if (number == 96 || number == 48)
            {
                Sort.SortAscending(ref mass, n, m);
            }
            else
            {
                Sort.SortDescendingly(ref mass, n, m);
            }



            //Sort.writeSortArray(mass, n, m);

            Console.ReadKey();
        }

        static void writeSizeArray(ref int row,ref int columb)
        {
            Console.WriteLine("Введите количество строк в двумерном массиве:");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в двумерном массиве:");
            columb = Convert.ToInt32(Console.ReadLine());
        }

    }
}
