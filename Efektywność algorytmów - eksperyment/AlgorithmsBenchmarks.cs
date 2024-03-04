using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efektywność_algorytmów___eksperyment
{
    [MemoryDiagnoser]
    public class AlgorithmsBenchmarks
    {
        private int[] randomArray;
        private int[] sortedArray;
        private int[] reversedArray;
        private int[] almostSortedArray;
        private int[] fewUniqueArray;

        [Params(1000)]
        public int ArraySize;

        [GlobalSetup]
        public void Setup()
        {
            randomArray = Generators.GenerateRandom(ArraySize, 0, 1000);
            sortedArray = Generators.GenerateSorted(ArraySize, 0, 1000);
            reversedArray = Generators.GenerateReversed(ArraySize, 0, 1000);
            almostSortedArray = Generators.GenerateAlmostSorted(ArraySize, 0, 1000, 10);
            fewUniqueArray = Generators.GenerateFewUnique(ArraySize, 0, 1000, 5);
        }

        [Benchmark]
        public void InsertionSortRandom() => SortingAlgorithms.InsertionSort(randomArray.Clone() as int[]);

        [Benchmark]
        public void InsertionSortSorted() => SortingAlgorithms.InsertionSort(sortedArray.Clone() as int[]);

        [Benchmark]
        public void InsertionSortReversed() => SortingAlgorithms.InsertionSort(reversedArray.Clone() as int[]);

        [Benchmark]
        public void InsertionSortAlmostSorted() => SortingAlgorithms.InsertionSort(almostSortedArray.Clone() as int[]);

        [Benchmark]
        public void InsertionSortFewUnique() => SortingAlgorithms.InsertionSort(fewUniqueArray.Clone() as int[]);

        [Benchmark]
        public void QuickSortRandom() => SortingAlgorithms.QuickSort(randomArray.Clone() as int[]);

        [Benchmark]
        public void QuickSortSorted() => SortingAlgorithms.QuickSort(sortedArray.Clone() as int[]);

        [Benchmark]
        public void QuickSortReversed() => SortingAlgorithms.QuickSort(reversedArray.Clone() as int[]);

        [Benchmark]
        public void QuickSortAlmostSorted() => SortingAlgorithms.QuickSort(almostSortedArray.Clone() as int[]);

        [Benchmark]
        public void QuickSortFewUnique() => SortingAlgorithms.QuickSort(fewUniqueArray.Clone() as int[]);
    }
}
