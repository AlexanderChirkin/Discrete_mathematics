
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary
{
    public class Sortings
    {
        public static void InsertionSort(int[] array,out int countOfNumber)
        {
            countOfNumber = 0;
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (++countOfNumber == countOfNumber && j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[++j] = key;
            }
        }

        public static void InsertionSortWithBinarySearch(int[] array,out int countOfNumber)
        {
            countOfNumber = 0;
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                int first = 0;
                int last = i;
                while (first != last)
                {
                    countOfNumber++;
                    int mid = (first + last) / 2;
                    if (array[i] > array[mid])
                        first = mid + 1;
                    else
                        last = mid;
                }
                int temp = array[i];
                for (int k = i; k > first; k--)
                {
                    array[k] = array[k - 1];
                }
                array[first] = temp;
            }
        }


        public static void MergeSort(int[] array, ref int countOfCompare)
        {
            int length = array.Length;
            if (length == 1)
                return;
            int[] array1 = new int[length / 2];
            int[] array2 = new int[length - length / 2];
            for (int i = 0; i < length / 2; i++)
                array1[i] = array[i];
            int j = 0;
            for (int i = length / 2; i < length; i++)
                array2[j++] = array[i];
            MergeSort(array1, ref countOfCompare);
            MergeSort(array2, ref countOfCompare);
            // merge 2 arrays in 1//
            int index1 = 0, index2 = 0, index = 0;
            while (index1 != array1.Length && index2 != array2.Length)
            {
                countOfCompare++;
                if (array1[index1] < array2[index2])
                    array[index++] = array1[index1++];
                else
                    array[index++] = array2[index2++];
            }
            if (index1 == array1.Length)
                while (index2 != array2.Length)
                    array[index++] = array2[index2++];
            else if (index2 == array2.Length)
                while (index1 != array1.Length)
                    array[index++] = array1[index1++];
        }


        public static void QuickSort(int[] array, int firstIndex, int lastIndex, ref int countOfCompare)
        {
            int i = firstIndex;
            int j = lastIndex;
            int mid = array[i + (j-i) / 2];
            //int mid = array[i];
            while (i <= j)
            {
                while (array[i] < mid && i <= lastIndex)
                {
                    i++;
                    countOfCompare++;
                }
                while (array[j] > mid && j >= firstIndex)
                {
                    j--;
                    countOfCompare++;
                }

                if (i <= j)
                    swap(ref array[i++], ref array[j--]);
            }
            if (j > firstIndex) QuickSort(array, firstIndex, j,ref countOfCompare);
            if (lastIndex > i) QuickSort(array, i, lastIndex,ref countOfCompare);
        }


        private static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
