﻿namespace Efektywność_algorytmów___eksperyment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = Generators.GenerateRandom(20, 1, 100);

            Console.WriteLine("Random Array:");
            foreach (int number in randomNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            int[] sortedNumbers = Generators.GenerateSorted(20, 1, 100);

            Console.WriteLine("Sorted Array:");
            foreach (int number in sortedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            int[] reversedNumbers = Generators.GenerateReversed(20, 1, 100);

            Console.WriteLine("Reversed Array:");
            foreach (int number in reversedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            int[] almostSortedNumbers = Generators.GenerateAlmostSorted(20, 1, 100, 10);

            Console.WriteLine("Almost Sorted Array:");
            foreach (int number in almostSortedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            int[] fewUniqueNumbers = Generators.GenerateFewUnique(20, 1, 10, 3);

            Console.WriteLine("Few Unique Values Array:");
            foreach (int number in fewUniqueNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}