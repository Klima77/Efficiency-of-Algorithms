using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Efektywność_algorytmów___eksperyment;

namespace Efektywność_algorytmów___eksperyment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<AlgorithmsBenchmarks>();
        }
    }
}