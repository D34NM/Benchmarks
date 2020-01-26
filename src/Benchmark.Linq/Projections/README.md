# Projections

``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.2 (19C57) [Darwin 19.2.0]
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

|                                     Method |           collection |         Mean |       Error |      StdDev |       Median |          Max |          Min |
|------------------------------------------- |--------------------- |-------------:|------------:|------------:|-------------:|-------------:|-------------:|
|  Select_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] |  51,662.1 us | 1,078.38 us | 2,725.20 us |  50,483.5 us |  60,123.5 us |  48,659.3 us |
| Foreach_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] | 102,997.7 us | 1,709.91 us | 1,515.79 us | 103,033.7 us | 105,938.0 us |  99,780.8 us |
|     For_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] | 103,147.8 us | 2,090.84 us | 1,955.77 us | 103,060.4 us | 108,531.8 us | 100,729.5 us |
|          Select_Over_Collection_Of_Numbers |       System.Int32[] |  10,524.5 us |    32.22 us |    28.56 us |  10,521.8 us |  10,560.5 us |  10,466.9 us |
|         Foreach_Over_Collection_Of_Numbers |       System.Int32[] |  25,194.6 us |   667.99 us |   795.20 us |  24,999.6 us |  26,769.9 us |  24,039.0 us |
|             For_Over_Collection_Of_Numbers |       System.Int32[] |  24,886.3 us |   490.88 us |   980.33 us |  24,457.9 us |  27,415.3 us |  23,721.5 us |
|          Select_Over_Collection_Of_Strings |      System.String[] |     803.1 us |     8.01 us |     7.49 us |     802.1 us |     820.6 us |     794.6 us |
|         Foreach_Over_Collection_Of_Strings |      System.String[] |     391.7 us |     2.94 us |     2.61 us |     391.4 us |     398.6 us |     388.2 us |
|             For_Over_Collection_Of_Strings |      System.String[] |     340.5 us |    10.78 us |    31.46 us |     332.7 us |     427.0 us |     303.4 us |

## * Legends *
  collection : Value of the 'collection' parameter
  Mean       : Arithmetic mean of all measurements
  Error      : Half of 99.9% confidence interval
  StdDev     : Standard deviation of all measurements
  Median     : Value separating the higher half of all measurements (50th percentile)
  Rank       : Relative position of current benchmark mean among all benchmarks (Arabic style)
  1 ns       : 1 Nanosecond (0.000000001 sec)
  