using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Homework_Largest_common_end
{
    public class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] fArr = Console.ReadLine().Split(' ').ToArray();
            string[] sArr = Console.ReadLine().Split(' ').ToArray();

            int smallerArr = Math.Min(fArr.Length, sArr.Length);
            int leftCounter = CountingArrays(fArr, sArr, smallerArr);

            Array.Reverse(fArr);
            Array.Reverse(sArr);

            int rightCounter = CountingArrays(fArr, sArr, smallerArr);

            Console.WriteLine(Math.Max(leftCounter, rightCounter));
        }

        private static int CountingArrays(string[] fArr, string[] sArr, int smallerArr)
        {
            int Counter = 0;
            for (int i = 0; i < smallerArr; i++)
            {
                if (fArr[i] == sArr[i])
                {
                    Counter++;
                }
                else
                {
                    break;
                }

            }

            return Counter;
        }
    }
}
