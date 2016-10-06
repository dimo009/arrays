using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Homework_Compare_Char_Arrays_second
{

    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split().Select(char.Parse).ToArray();

            string[] arrays = { new string(firstArr), new string(secondArr) };
            Console.WriteLine(string.Join("\n", arrays.OrderBy(str => str)));


        }
    }
}