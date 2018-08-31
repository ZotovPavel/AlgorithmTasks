using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTasks
{
    class Program
    {     
        static List<List<int>> GetCombinations(int k, int n)
        {
            var digitsArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var mask = new int[10];

            var combinationsList = new List<List<int>>();

            while(true)
            {
                var newCombination = new List<int>();

            }

            return combinationsList;
        }

        static void PrintArray(int[] array)
        {
            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("["+array[i] + "] ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //var result = GetCombinations(k, n);

            Console.Write("---Press any key---");
            Console.ReadKey();
        }
    }
}
