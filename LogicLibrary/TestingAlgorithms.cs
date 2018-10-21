using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class TestingAlgorithms
    {
        public delegate int Search(int[] array, int value, out int countOfCompare);
        public static Search _search;

        public static double TestingSearch(int[] array, int countOfTest = 1000)
        {
            int length = array.Length;
            Random random = new Random();
            int TotalCompareCount = 0;
            int TotalCountTest = 0;
            for (int i = 0; i < countOfTest; i++)
            {
                int n = array[random.Next(0, length)];
                int countOfCompare = 0;
                _search(array, n, out countOfCompare);
                TotalCountTest++;
                TotalCompareCount += countOfCompare;
            }

            double MidCountOfCompare = (double)TotalCompareCount / TotalCountTest;
            return MidCountOfCompare;
        }


    }
}
