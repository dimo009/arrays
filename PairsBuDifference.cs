using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Homework_PairsByDifference
{
    class PairsBuDifference
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
                {
                    if (numbers[i]-numbers[currentElement]==difference)
                    {
                        counter++;
                    }
                    else
                    {
                        continue;
                    }
                }
               
            }
            Console.WriteLine(counter);

        }
    }
}
