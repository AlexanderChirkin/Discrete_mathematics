using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingLibrary;

namespace TectingSortingsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a1 = 5;
            //int a2 = 2;
            //Console.WriteLine(a1 / a2);
            int[] array = new int[1000];
            Random random = new Random();

            for (int w = 0; w < 10; w++)
            {
                for (int i = 0; i < 1000; i++)
                {
                    array[i] = random.Next(1, 10000);
                }
                int compare = 0;
                Array.Sort(array);
                //Array.Reverse(array);
                //Print(array);
                SortingLibrary.Sortings.QuickSort(array,0,array.Length-1, ref compare);
               // Print(array);
                Console.WriteLine(compare);
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
