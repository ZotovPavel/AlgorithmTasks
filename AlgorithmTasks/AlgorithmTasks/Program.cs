using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTasks
{
    class Program
    {     
        static List<int> GetCombinations(int k, int n)
        {
            var array = GetArrayFilledWithDigits();
            return null;
        }

        static int[] GetArrayFilledWithDigits()
        {
            int[] array = new int[9];
            for (int i = 0; i < 9; i++)
            {
                array[i] = i+1;
            }

            return array;
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

            var array = GetArrayFilledWithDigits();
            PrintArray(array);

            //var result = GetCombinations(k, n);

            Console.Write("---Press any key---");
            Console.ReadKey();
        }
    }
}
