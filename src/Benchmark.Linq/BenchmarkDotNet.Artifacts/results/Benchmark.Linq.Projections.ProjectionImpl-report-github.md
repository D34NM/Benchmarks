``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.2 (19C57) [Darwin 19.2.0]
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


```
|                                    Method |           collection |            Mean |         Error |        StdDev | Rank |
|------------------------------------------ |--------------------- |----------------:|--------------:|--------------:|-----:|
| **Select_Over_Collection_Of_Complex_Objects** | **Bench(...)ect[] [42]** |     **38,237.4 ns** |     **259.45 ns** |     **242.69 ns** |    **3** |
| Select_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] |    445,573.8 ns |   1,359.07 ns |   1,061.07 ns |    5 |
| Select_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] |  4,668,097.1 ns |  32,893.39 ns |  29,159.13 ns |    7 |
| Select_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] | 49,937,631.8 ns | 641,988.77 ns | 600,516.69 ns |    8 |
|         **Select_Over_Collection_Of_Numbers** | **Syste(...)rator [36]** |              **NA** |            **NA** |            **NA** |    **?** |
|         Select_Over_Collection_Of_Numbers | Syste(...)rator [36] |              NA |            NA |            NA |    ? |
|         Select_Over_Collection_Of_Numbers | Syste(...)rator [36] |              NA |            NA |            NA |    ? |
|         Select_Over_Collection_Of_Numbers | Syste(...)rator [36] |              NA |            NA |            NA |    ? |
|         **Select_Over_Collection_Of_Strings** |      **System.String[]** |        **761.7 ns** |       **2.38 ns** |       **2.11 ns** |    **1** |
|         Select_Over_Collection_Of_Strings |      System.String[] |      6,938.4 ns |      17.01 ns |      15.08 ns |    2 |
|         Select_Over_Collection_Of_Strings |      System.String[] |     67,928.6 ns |     124.67 ns |     116.62 ns |    4 |
|         Select_Over_Collection_Of_Strings |      System.String[] |    829,290.4 ns |   7,521.47 ns |   7,035.59 ns |    6 |

Benchmarks with issues:
  ProjectionImpl.Select_Over_Collection_Of_Numbers: DefaultJob [collection=Syste(...)rator [36]]
  ProjectionImpl.Select_Over_Collection_Of_Numbers: DefaultJob [collection=Syste(...)rator [36]]
  ProjectionImpl.Select_Over_Collection_Of_Numbers: DefaultJob [collection=Syste(...)rator [36]]
  ProjectionImpl.Select_Over_Collection_Of_Numbers: DefaultJob [collection=Syste(...)rator [36]]
