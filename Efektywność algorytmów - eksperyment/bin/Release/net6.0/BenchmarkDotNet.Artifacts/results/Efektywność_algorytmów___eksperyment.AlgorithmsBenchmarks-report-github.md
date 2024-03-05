```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.1555/22H2/2022Update/SunValley2)
Unknown processor
.NET SDK 7.0.400
  [Host]     : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2


```
| Method           | ArraySize | Mean              | Error          | StdDev          | Median            | Allocated |
|----------------- |---------- |------------------:|---------------:|----------------:|------------------:|----------:|
| **InsertionSort**    | **10**        |       **107.2618 ns** |      **2.1777 ns** |       **5.1330 ns** |       **106.1466 ns** |         **-** |
| MegaSort         | 10        |         0.0294 ns |      0.0221 ns |       0.0387 ns |         0.0000 ns |         - |
| QuickSort        | 10        |        88.2985 ns |      0.3082 ns |       0.2883 ns |        88.2141 ns |         - |
| QuickSortClassic | 10        |         0.0187 ns |      0.0243 ns |       0.0270 ns |         0.0008 ns |         - |
| **InsertionSort**    | **1000**      |     **9,822.0168 ns** |    **184.1919 ns** |     **153.8086 ns** |     **9,764.5981 ns** |         **-** |
| MegaSort         | 1000      |         0.0306 ns |      0.0257 ns |       0.0253 ns |         0.0415 ns |         - |
| QuickSort        | 1000      |    25,226.4647 ns |    501.1874 ns |   1,266.5646 ns |    25,201.9974 ns |         - |
| QuickSortClassic | 1000      |         0.0000 ns |      0.0000 ns |       0.0000 ns |         0.0000 ns |         - |
| **InsertionSort**    | **100000**    |   **996,919.6866 ns** | **19,178.8771 ns** |  **23,553.3834 ns** |   **999,418.8965 ns** |       **1 B** |
| MegaSort         | 100000    |         0.0820 ns |      0.0303 ns |       0.0425 ns |         0.0919 ns |         - |
| QuickSort        | 100000    | 4,624,257.7953 ns | 92,079.2201 ns | 258,200.0052 ns | 4,632,751.5625 ns |       5 B |
| QuickSortClassic | 100000    |         0.0094 ns |      0.0101 ns |       0.0145 ns |         0.0000 ns |         - |
