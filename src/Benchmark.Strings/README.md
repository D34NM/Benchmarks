# Strings

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.2 (19C57) [Darwin 19.2.0]  
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores  
.NET Core SDK=3.1.101  
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT  
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT  

*Results:*

|                                       Method |      Mean |     Error |    StdDev |
|--------------------------------------------- |----------:|----------:|----------:|
|                   ReadOnly_ToString_Variable |  2.728 ms | 0.0535 ms | 0.0617 ms |
|              ReadOnly_ToString_Interpolation | 21.491 ms | 0.2110 ms | 0.1870 ms |
|                     ReadOnly_ToString_Format | 23.951 ms | 0.6709 ms | 1.9033 ms |
|          ReadOnly_Implicit_Operator_Variable |  3.269 ms | 0.1057 ms | 0.3117 ms |
|                       ReadOnly_Interpolation | 22.936 ms | 0.4465 ms | 0.7701 ms |
|                              ReadOnly_Format | 36.240 ms | 0.7147 ms | 1.6131 ms |
|             ReadWrite_ToString_Interpolation | 22.118 ms | 0.4358 ms | 0.6785 ms |
|                    ReadWrite_ToString_Format | 22.797 ms | 0.4295 ms | 0.7293 ms |
|    ReadWrite_Implicit_Operator_Interpolation | 21.822 ms | 0.4215 ms | 0.6308 ms |
|                      ReadWrite_Interpolation | 20.855 ms | 0.2094 ms | 0.1748 ms |
|                             ReadWrite_Format | 31.152 ms | 0.6200 ms | 1.0012 ms |

**Legend:**  
  *collection : Value of the 'collection' parameter*  
  *Mean       : Arithmetic mean of all measurements*  
  *Error      : Half of 99.9% confidence interval*  
  *StdDev     : Standard deviation of all measurements*  
  *Median     : Value separating the higher half of all measurements (50th percentile)*  
  *1 ns       : 1 Nanosecond (0.000000001 sec)*