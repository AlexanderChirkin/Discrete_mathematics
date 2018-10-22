using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Search
    {
        public static int IncrementalSearch(int[] array, int value, out int countOfCompare)
        {
            countOfCompare = 0;
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                countOfCompare++;
                if (array[i] == value)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] array, int value, out int countOfCmparee)
        {
            Array.Sort(array);
            countOfCmparee = 0;
            int first = 0;  //индексы
            int last = array.Length - 1;
            if (last == -1)
                return -1;
            int mid = 0;
            if (value < array[0])
                return -1;
            else if (value > array[last])
                return -1;
            else
            {
                while (first <= last)
                {
                    countOfCmparee++;
                    mid = first + (last - first) / 2;
                    if (value <= array[mid])
                        last = mid;
                    else
                        first = mid + 1;
                    if (first == last)
                    {
                        mid = last;
                        break;
                    }
                }
                if (value == array[mid])
                    return mid;
                else
                    return -1;
            }
        }
    }
}
