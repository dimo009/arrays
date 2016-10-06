using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HomeWork_Most_Frequent_Number
{
    class MostFrequentNumber8
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] distinctNumbers = numbers.Distinct().OrderBy(x=>x).ToArray();

            int[] repeats = new int[distinctNumbers.Length];

            for (int i = 0; i < distinctNumbers.Length; i++)
            {
                repeats[i] = numbers.Count(number => number == distinctNumbers[i]);
            }

            Console.WriteLine(distinctNumbers[repeats.ToList().IndexOf(repeats.Max())]);


        }
    }
}
