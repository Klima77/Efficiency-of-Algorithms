using BenchmarkDotNet.Attributes;
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

        [Params(10, 1000, 100000)]
        public int ArraySize { get; set; }

        //[Params(10, 20)]
        //public double DisturbancePercent { get; set; } // unused

        //[Params(10, 100, 1000)]
        //public double UniqueValues { get; set; } //unused

        [GlobalSetup]
        public void Setup()
        {
            randomArray = Generators.GenerateRandom(ArraySize, 0, ArraySize);
            sortedArray = Generators.GenerateSorted(ArraySize, 0, ArraySize);
            reversedArray = Generators.GenerateReversed(ArraySize, 0, ArraySize);
            almostSortedArray = Generators.GenerateAlmostSorted(ArraySize, 0, ArraySize, 10 /* DisturbancePercent */);
            fewUniqueArray = Generators.GenerateFewUnique(ArraySize, 0, ArraySize, 10 /* UniqueValues */);
        }

        [Benchmark]
        public void InsertionSort()
        {
            SortingAlgorithms.InsertionSort(randomArray);
            SortingAlgorithms.InsertionSort(sortedArray);
            SortingAlgorithms.InsertionSort(reversedArray);
            SortingAlgorithms.InsertionSort(almostSortedArray);
            SortingAlgorithms.InsertionSort(fewUniqueArray);
        }

        [Benchmark] 
        public void MegaSort()
        {
            SortingAlgorithms.MergeSort(randomArray);
            SortingAlgorithms.MergeSort(sortedArray);
            SortingAlgorithms.MergeSort(reversedArray);
            SortingAlgorithms.MergeSort(almostSortedArray);
            SortingAlgorithms.MergeSort(fewUniqueArray);
        }

        [Benchmark]
        public void QuickSort()
        {
            SortingAlgorithms.QuickSort(randomArray);
            SortingAlgorithms.QuickSort(sortedArray);
            SortingAlgorithms.QuickSort(reversedArray);
            SortingAlgorithms.QuickSort(almostSortedArray);
            SortingAlgorithms.QuickSort(fewUniqueArray);
        }

        [Benchmark]
        public void QuickSortClassic()
        {
            SortingAlgorithms.QuickSortClassic(randomArray);
            SortingAlgorithms.QuickSortClassic(sortedArray);
            SortingAlgorithms.QuickSortClassic(reversedArray);
            SortingAlgorithms.QuickSortClassic(almostSortedArray);
            SortingAlgorithms.QuickSortClassic(fewUniqueArray);
        }
    }
}
