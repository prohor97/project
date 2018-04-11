using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Sort
    {
        //Сортировка по возрастанию
        public static void SortAscending(ref int[,] array, int row, int columb)
        {
            int[] nums = new int[row * columb];
            int t = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columb; j++)
                {
                    nums[t] = array[i, j];
                    t++;
                }
            }

            int temp;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            t = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columb; j++)
                {
                    array[i, j] = nums[t];
                    t++;
                }
            }

            //int temp = 0;

            //for (int g = 0; g < row * columb; g++)
            //{
            //    for (int i = 0; i < row; i++)
            //    {
            //        for (int j = 0; j < columb - 1; j++)
            //        {
            //            if (array[i, j] > array[i, j + 1])
            //            {
            //                temp = array[i, j];
            //                array[i, j] = array[i, j + 1];
            //                array[i, j + 1] = temp;
            //            }
            //        }
            //    }       
            //}  

            writeSortArray(array, row, columb);

        }

        //Сортировка по убыванию
        public static void SortDescendingly(ref int[,] array, int row, int columb)
        {
            int[] nums = new int[row * columb];
            int t = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columb; j++)
                {
                    nums[t] = array[i, j];
                    t++;
                }
            }

            int temp;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                    
                }               
            }

            t = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columb; j++)
                {
                    array[i, j] = nums[t];
                    t++;
                }
            }

            writeSortArray(array, row, columb);
        }

        //Вывод отсортированного массива на экран
        public static void writeSortArray(int[,] array, int row, int columb)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columb; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}