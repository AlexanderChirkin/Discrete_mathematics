using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLibrary;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[0];
            Random rnd = new Random();
            int length = arr.Length;
            for (int a=0;a<length;a++)
                arr[a] = rnd.Next(1, 200);
            foreach (int n in arr)
                Console.Write("{0} ",n);
            Console.WriteLine();
            Console.WriteLine();
            Array.Sort(arr);
            foreach (int n in arr)
                Console.Write("{0} ", n);
            Console.WriteLine();
            int count;
            int f = rnd.Next(1, 200);
            int ans=Search.BinarySearch(arr, f, out count);
            Console.WriteLine(f);
            Console.WriteLine(ans);
            Console.WriteLine(count);
            Console.WriteLine("-------------------------");
           // Console.WriteLine(TestingAlgorithms.TestingSearch(100));
            Console.ReadKey();



            



        }
    }
}
