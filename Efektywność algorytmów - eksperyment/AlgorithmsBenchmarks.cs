using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efektywność_algorytmów___eksperyment
{
    public class AlgorithmsBenchmarks
    {
        [Benchmark]
        public void InsertionSortRandom()
        {
            int[] array = Generators.GenerateRandom(1000, 1, 1000);
            SortingAlgorithms.InsertionSort(array);
        }

        [Benchmark]
        public void InsertionSortSorted()
        {
            int[] array = Generators.GenerateSorted(1000, 1, 1000);
            SortingAlgorithms.InsertionSort(array);
        }

        [Benchmark]
        public void InsertionSortReversed()
        {
            int[] array = Generators.GenerateReversed(1000, 1, 1000);
            SortingAlgorithms.InsertionSort(array);
        }

        [Benchmark]
        public void InsertionSortAlmostSorted()
        {
            int[] array = Generators.GenerateAlmostSorted(1000, 1, 1000, 20);
            SortingAlgorithms.InsertionSort(array);
        }

        [Benchmark]
        public void InsertionSortFewUnique()
        {
            int[] array = Generators.GenerateFewUnique(1000, 1, 1000, 3);
            SortingAlgorithms.InsertionSort(array);
        }
    }
}
