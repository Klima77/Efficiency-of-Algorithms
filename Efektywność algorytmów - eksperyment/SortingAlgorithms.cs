using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efektywność_algorytmów___eksperyment
{
    public static class SortingAlgorithms
    {
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1]  = key;
            }
        }

        public static void QuickSort(int[] arr)
        {
            Array.Sort(arr);
        }

        public static void QuickSortClassic(int[] arr)
        {
            //
        }

        public static void MergeSort(int[] arr)
        {
            //
        }
    }
}
