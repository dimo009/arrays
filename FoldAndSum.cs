using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Homework_Fold_and_Sum
{
    class FoldAndSum
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;


            int[] middleElements = new int[2 * k];

            for (int  i= 0; i < middleElements.Length; i++)
            {
                middleElements[i] = numbers[k + i];
            }

            int[] firstKElements = new int[k];

            for (int i = 0; i < firstKElements.Length; i++)
            {
                firstKElements[i] = numbers[i];
            }
            Array.Reverse(firstKElements);
            

            int[] lastKElements = new int[k];

            for (int i = 0; i < lastKElements.Length; i++)
            {
                lastKElements[i] = numbers[i+3*k];
            }

            
            Array.Reverse(lastKElements);
            

            int[] firstAndLastElements = new int[k * 2];

            for (int i = 0; i < firstAndLastElements.Length; i++)
            {
                if (i<k)
                {
                    firstAndLastElements[i] = firstKElements[1];
                }
                else
                {
                    firstAndLastElements[i] = lastKElements[i-k];
                }
            }
            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] += firstAndLastElements[i];
            }
            Console.WriteLine(string.Join(" ",middleElements));





        }
    }
}
