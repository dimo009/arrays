using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_Compare_Char_Arrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int smallerArr = Math.Min(firstArr.Length, secondArr.Length);
            bool areEqual = false;

            for (int i = 0; i < smallerArr; i++)
            {
                if (firstArr[i]==secondArr[i])
                {
                    continue;
                }
                else
                {
                    if (firstArr[i]<secondArr[i])
                    {
                        Console.WriteLine( firstArr);
                        Console.WriteLine(secondArr);
                    }
                    else
                    {
                        Console.WriteLine(secondArr);
                        Console.WriteLine(firstArr);
                    }
                    areEqual = true;
                    break;
                }
            }
            if (!areEqual)
            {
                if (firstArr.Length<=secondArr.Length)
                {
                    Console.WriteLine(firstArr);
                    Console.WriteLine(secondArr);
                }
                else
                {
                    Console.WriteLine(secondArr);
                    Console.WriteLine(firstArr);
                }
            }
        }
    }
}
