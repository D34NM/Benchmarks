# Projections

``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.2 (19C57) [Darwin 19.2.0]
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

|                                     Method |           collection |         Mean |       Error |      StdDev |       Median |
|------------------------------------------- |--------------------- |-------------:|------------:|------------:|-------------:|
|  Select_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] |  51,388.8 us |   739.58 us |   655.62 us |  51,296.0 us |
| Foreach_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] | 117,268.7 us | 3,013.74 us | 8,886.07 us | 117,071.2 us |
|     For_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] | 102,655.1 us | 1,975.60 us | 1,751.32 us | 102,697.1 us |
|          Select_Over_Collection_Of_Numbers |       System.Int32[] |  10,579.5 us |    96.64 us |    85.67 us |  10,573.8 us |
|         Foreach_Over_Collection_Of_Numbers |       System.Int32[] |  25,452.3 us |   560.92 us | 1,645.07 us |  25,407.4 us |
|             For_Over_Collection_Of_Numbers |       System.Int32[] |  25,099.1 us |   501.57 us | 1,267.52 us |  24,551.1 us |
|          Select_Over_Collection_Of_Strings |      System.String[] |     845.6 us |    16.81 us |    23.00 us |     835.3 us |
|         Foreach_Over_Collection_Of_Strings |      System.String[] |     401.1 us |     7.69 us |    19.28 us |     392.0 us |
|             For_Over_Collection_Of_Strings |      System.String[] |     302.4 us |     3.36 us |     2.98 us |     302.5 us |

## * Legends *
  collection : Value of the 'collection' parameter
  Mean       : Arithmetic mean of all measurements
  Error      : Half of 99.9% confidence interval
  StdDev     : Standard deviation of all measurements
  Median     : Value separating the higher half of all measurements (50th percentile)
  Rank       : Relative position of current benchmark mean among all benchmarks (Arabic style)
  1 ns       : 1 Nanosecond (0.000000001 sec)