using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLogic
{
    public class ArrayInt
    {
        public int[] Values;
        public int Length;
        public bool RepeatExist;
        Random random = new Random();

        public ArrayInt(int n)
        {
            Values = new int[n];
            Length = n;
        }

        public void RandomFill(int minValue, int maxValue)
        {
            for (int i = 0; i < Length; i++)
                Values[i] = random.Next(minValue, maxValue + 1);
            RepeatExist = true;
        }

        public void RandomFillWithoutRepeat(int minValue, int maxValue)
        {
            if (Length > (maxValue - minValue) + 1)
                return;
            List<int> listValues = new List<int>();
            for (int i = minValue; i <= maxValue; i++)
                listValues.Add(i);
            int j;
            for (int i = 0; i < Length; i++)
            {
                j = random.Next(0, listValues.Count);
                Values[i] = listValues[j];
                listValues.RemoveAt(j);
            }
            RepeatExist = false;
        }

        public void Sort()
        {
            Array.Sort(Values);
        }

        void Shuffle(int[] array)
        {
            int index1, index2;
            for (int i = 0; i < Length * Length; i++)
            {
                index1 = random.Next(0, Length);
                index2 = random.Next(0, Length);
                Swap(ref array[index1], ref array[index2]);
            }
        }

        void Swap(ref int val1, ref int val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }

    }
}
