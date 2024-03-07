```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.1555/22H2/2022Update/SunValley2)
Unknown processor
.NET SDK 7.0.400
  [Host]     : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2


```
| Method           | ArraySize | Mean            | Error         | StdDev        | Gen0       | Gen1      | Gen2      | Allocated  |
|----------------- |---------- |----------------:|--------------:|--------------:|-----------:|----------:|----------:|-----------:|
| **InsertionSort**    | **10**        |        **120.8 ns** |       **2.45 ns** |       **5.81 ns** |          **-** |         **-** |         **-** |          **-** |
| MergeSort        | 10        |      1,202.8 ns |      29.45 ns |      86.37 ns |     0.4959 |         - |         - |     3120 B |
| QuickSort        | 10        |        102.5 ns |       2.22 ns |       6.54 ns |          - |         - |         - |          - |
| QuickSortClassic | 10        |        402.7 ns |       7.99 ns |      15.58 ns |          - |         - |         - |          - |
| **InsertionSort**    | **1000**      |     **10,824.5 ns** |     **215.89 ns** |     **601.82 ns** |          **-** |         **-** |         **-** |          **-** |
| MergeSort        | 1000      |    179,785.7 ns |   3,588.73 ns |   7,725.12 ns |    73.4863 |         - |         - |   461520 B |
| QuickSort        | 1000      |     27,399.2 ns |     541.05 ns |   1,042.42 ns |          - |         - |         - |          - |
| QuickSortClassic | 1000      |  1,351,199.5 ns |  26,919.15 ns |  68,028.12 ns |          - |         - |         - |        1 B |
| **InsertionSort**    | **100000**    |  **1,017,639.2 ns** |  **19,414.26 ns** |  **18,160.11 ns** |          **-** |         **-** |         **-** |        **2 B** |
| MergeSort        | 100000    | 26,874,114.3 ns | 211,721.52 ns | 165,298.24 ns | 10093.7500 | 1218.7500 | 1156.2500 | 60157414 B |
| QuickSort        | 100000    |  4,273,526.0 ns |  84,330.65 ns |  97,115.31 ns |          - |         - |         - |        5 B |
| QuickSortClassic | 100000    |              NA |            NA |            NA |         NA |        NA |        NA |         NA |

Benchmarks with issues:
  AlgorithmsBenchmarks.QuickSortClassic: DefaultJob [ArraySize=100000]
