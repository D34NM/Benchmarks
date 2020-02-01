# Dynamic method invocation benchmarks

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.2 (19C57) [Darwin 19.2.0]  
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores  
.NET Core SDK=3.1.101  
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT  
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT  


|             Method |      Mean |     Error |    StdDev |    Median | MValue |
|------------------- |----------:|----------:|----------:|----------:|-------:|
|  Static_Invocation | 0.0001 ns | 0.0003 ns | 0.0003 ns | 0.0000 ns |  2.000 |
| Dynamic_Invocation | 9.2572 ns | 0.1236 ns | 0.1156 ns | 9.1970 ns |  2.000 |

// * Warnings *  
ZeroMeasurement  
  Benchmarks.Static_Invocation: Default -> The method duration is indistinguishable from the empty method duration  