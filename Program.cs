using System;

namespace HomeWoksSubarrayRepeatsNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int repeatNumber = 0;
            int maxNumberRepetitions = 0;
            int countRepeat = 1;
            int minValue = 6;
            int maxValue = 9;
            int arraySize = 30;
            int[] numbers = new int[arraySize];

            Random random = new Random();

            Console.Write("{");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + " ");
            }

            Console.Write("\b}");

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (countRepeat > maxNumberRepetitions)
                {
                    repeatNumber = numbers[i];
                    maxNumberRepetitions = countRepeat;
                }
                if (numbers[i] == numbers[i + 1])
                {
                    countRepeat++;
                }
                else
                {
                    countRepeat = 1;
                }
            }

            Console.WriteLine($" The number {repeatNumber} is repeated {maxNumberRepetitions} times");
        }
    }
}
