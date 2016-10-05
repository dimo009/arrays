using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _02.Homework_Rotate_and_Sum
    {
        class RotateAndSum
        {
            static void Main()
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int rotations = int.Parse(Console.ReadLine());

                int[] sumOfRotations = new int[numbers.Length];

            

            for (int currentRotations = 0; currentRotations < rotations; currentRotations++)
            {
                int lastElement = numbers[numbers.Length - 1]; //numbers.Length- 1 - последен елемент на масива
                Array.Copy(numbers, 0, numbers, 1, numbers.Length - 1);
                numbers[0] = lastElement;

                //for (int currentElement = numbers.Length - 1; currentElement > 0; currentElement--)
                //{
                //    numbers[currentElement] = numbers[currentElement - 1]; // всяко число е равно на следващото по ред в масива

                //}
                //numbers[0] = lastElement;

                for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
                    {
                        sumOfRotations[currentElement] += numbers[currentElement];
                    }
                }
                Console.WriteLine(string.Join(" ", sumOfRotations));
            }
        }
    }


