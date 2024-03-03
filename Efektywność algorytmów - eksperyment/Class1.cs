using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efektywność_algorytmów___eksperyment
{
    public static class Generators
    {
        public static int[] GenerateRandom(int size, int minVal, int maxVal)
        {
            int[] randomArray = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(minVal, maxVal + 1);
            }
            return randomArray;

        }

        public static int[] GenerateSorted(int size, int minVal, int maxVal)
        {
            int[] sortedArray = GenerateRandom(size, minVal, maxVal);
            Array.Sort(sortedArray);
            return sortedArray;
        }

        public static int[] GenerateReversed(int size, int minVal, int maxVal)
        {
            int[] reversedArray = GenerateRandom(size, minVal, maxVal);
            Array.Reverse(reversedArray);
            return reversedArray;
        }

        public static int[] GenerateAlmostSorted(int size, int minVal, int maxVal, double disturbancePercent)
        {
            int[] almostSortedArray = new int[size]; // probably to edit!
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                almostSortedArray[i] = minVal + i;
            }

            int disturbances = (int)(disturbancePercent / 100 * size);

            for (int i = 0; i < disturbances; i++)
            {
                int index1 = random.Next(0, size);
                int index2 = random.Next(0, size);

                int temp = almostSortedArray[index1];
                almostSortedArray[index1] = almostSortedArray[index2];
                almostSortedArray[index2] = temp;
            }

            return almostSortedArray;
        }

        public static int[] GenerateFewUnique(int size, int minVal, int maxVal, int uniqueValues)
        {
            int[] fewUniqueArray = new int[size]; // probably to edit!
            Random random = new Random();

            for (int i = 0; i < size; i += size / uniqueValues)
            {
                int uniqueValue = random.Next(minVal, maxVal + 1);
                for (int j = i; j < Math.Min(i + size / uniqueValues, size); j++)
                {
                    fewUniqueArray[j] = uniqueValue;
                }
            }

            for (int i = size - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                int temp = fewUniqueArray[i];
                fewUniqueArray[i] = fewUniqueArray[j];
                fewUniqueArray[j] = temp;
            }

            return fewUniqueArray;
        }
    }
}
