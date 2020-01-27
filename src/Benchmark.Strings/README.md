# Strings

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.2 (19C57) [Darwin 19.2.0]  
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores  
.NET Core SDK=3.1.101  
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT  
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT  

*Results:*

|                                    Method |      Mean |     Error |    StdDev |    Median | MValue |
|------------------------------------------ |----------:|----------:|----------:|----------:|-------:|
|                ReadOnly_ToString_Variable |  2.804 ms | 0.0558 ms | 0.1327 ms |  2.765 ms |  2.424 |
|           ReadOnly_ToString_Interpolation | 21.216 ms | 0.2278 ms | 0.2130 ms | 21.178 ms |  2.000 |
|                  ReadOnly_ToString_Format | 21.699 ms | 0.1931 ms | 0.1806 ms | 21.688 ms |  2.000 |
|       ReadOnly_Implicit_Operator_Variable |  2.835 ms | 0.0567 ms | 0.1244 ms |  2.808 ms |  2.933 |
|                    ReadOnly_Interpolation | 25.191 ms | 0.9723 ms | 2.8515 ms | 24.600 ms |  3.294 |
|                           ReadOnly_Format | 34.890 ms | 0.3197 ms | 0.2834 ms | 34.896 ms |  2.000 |
|          ReadWrite_ToString_Interpolation | 21.126 ms | 0.1092 ms | 0.0968 ms | 21.126 ms |  2.000 |
|                 ReadWrite_ToString_Format | 21.403 ms | 0.3091 ms | 0.2892 ms | 21.326 ms |  2.000 |
| ReadWrite_Implicit_Operator_Interpolation | 21.848 ms | 0.1169 ms | 0.1037 ms | 21.855 ms |  2.000 |
|                   ReadWrite_Interpolation | 21.700 ms | 0.4895 ms | 0.7020 ms | 21.454 ms |  2.000 |
|                          ReadWrite_Format | 30.765 ms | 0.6136 ms | 1.0252 ms | 30.292 ms |  2.250 |

// *Warnings*
MultimodalDistribution  
  **ToString_vs_Interpolation.ReadOnly_Implicit_Operator_Variable: Default -> It seems that the distribution can have several modes (mValue = 2.93)**  
  **ToString_vs_Interpolation.ReadOnly_Interpolation: Default              -> It seems that the distribution is bimodal (mValue = 3.29)**  

**Legend:**  
  *collection : Value of the 'collection' parameter*  
  *Mean       : Arithmetic mean of all measurements*  
  *Error      : Half of 99.9% confidence interval*  
  *StdDev     : Standard deviation of all measurements*  
  *Median     : Value separating the higher half of all measurements (50th percentile)*  
  *1 ns       : 1 Nanosecond (0.000000001 sec)*