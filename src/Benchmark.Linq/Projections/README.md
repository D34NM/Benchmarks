# Projections

``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.2 (19C57) [Darwin 19.2.0]
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


|                                    Method |           collection |             Mean |          Error |         StdDev |           Median | Rank |
|------------------------------------------ |--------------------- |-----------------:|---------------:|---------------:|-----------------:|-----:|
| Select_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] | 50,344,598.27 ns | 444,747.363 ns | 371,384.191 ns | 50,336,858.18 ns |   27 |
| Select_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] |    442,208.53 ns |   1,265.990 ns |   1,057.159 ns |    442,220.07 ns |   19 |
| Select_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] |     39,563.77 ns |     786.172 ns |   1,758.387 ns |     38,963.90 ns |   12 |
| Select_Over_Collection_Of_Complex_Objects | Bench(...)ect[] [42] |  4,938,737.38 ns |  64,003.785 ns |  53,446.059 ns |  4,921,642.52 ns |   23 |
|         Select_Over_Collection_Of_Numbers |       System.Int32[] |      9,731.89 ns |     171.609 ns |     152.127 ns |      9,706.14 ns |    9 |
|         Select_Over_Collection_Of_Numbers |       System.Int32[] |     96,412.74 ns |     575.944 ns |     480.940 ns |     96,435.16 ns |   16 |
|         Select_Over_Collection_Of_Numbers |       System.Int32[] | 10,100,297.77 ns | 122,104.098 ns | 114,216.249 ns | 10,086,026.26 ns |   24 |
|         Select_Over_Collection_Of_Numbers |       System.Int32[] |    996,580.62 ns |  20,769.455 ns |  42,892.527 ns |    976,918.57 ns |   21 |
|        Foreach_Over_Collection_Of_Numbers |       System.Int32[] |     89,366.40 ns |     467.479 ns |     414.408 ns |     89,294.41 ns |   15 |
|        Foreach_Over_Collection_Of_Numbers |       System.Int32[] |  1,007,739.66 ns |   7,623.200 ns |   6,757.768 ns |  1,007,443.97 ns |   22 |
|        Foreach_Over_Collection_Of_Numbers |       System.Int32[] | 20,434,887.21 ns | 457,967.095 ns | 405,975.901 ns | 20,441,262.75 ns |   25 |
|        Foreach_Over_Collection_Of_Numbers |       System.Int32[] |      8,729.69 ns |      39.324 ns |      32.838 ns |      8,729.26 ns |    8 |
|            For_Over_Collection_Of_Numbers |       System.Int32[] | 22,648,723.40 ns | 137,118.626 ns | 121,552.090 ns | 22,625,938.73 ns |   26 |
|            For_Over_Collection_Of_Numbers |       System.Int32[] |    972,861.22 ns |   6,515.883 ns |   6,094.961 ns |    970,992.87 ns |   21 |
|            For_Over_Collection_Of_Numbers |       System.Int32[] |     87,906.36 ns |     418.720 ns |     371.184 ns |     87,835.26 ns |   14 |
|            For_Over_Collection_Of_Numbers |       System.Int32[] |      8,596.39 ns |      33.977 ns |      28.372 ns |      8,596.55 ns |    7 |
|         Select_Over_Collection_Of_Strings |      System.String[] |      6,402.72 ns |      25.848 ns |      22.914 ns |      6,398.30 ns |    6 |
|         Select_Over_Collection_Of_Strings |      System.String[] |     67,964.39 ns |     161.916 ns |     143.534 ns |     67,960.47 ns |   13 |
|         Select_Over_Collection_Of_Strings |      System.String[] |        713.16 ns |       2.352 ns |       2.085 ns |        713.36 ns |    3 |
|         Select_Over_Collection_Of_Strings |      System.String[] |    797,729.51 ns |   3,588.576 ns |   2,996.623 ns |    798,150.58 ns |   20 |
|        Foreach_Over_Collection_Of_Strings |      System.String[] |      1,667.82 ns |       7.959 ns |       7.055 ns |      1,667.41 ns |    5 |
|        Foreach_Over_Collection_Of_Strings |      System.String[] |     19,742.85 ns |     391.717 ns |     586.304 ns |     19,856.85 ns |   11 |
|        Foreach_Over_Collection_Of_Strings |      System.String[] |    401,225.73 ns |   4,365.962 ns |   3,645.776 ns |    400,053.39 ns |   18 |
|        Foreach_Over_Collection_Of_Strings |      System.String[] |        173.14 ns |       0.564 ns |       0.471 ns |        173.27 ns |    2 |
|            For_Over_Collection_Of_Strings |      System.String[] |         84.73 ns |       0.240 ns |       0.201 ns |         84.68 ns |    1 |
|            For_Over_Collection_Of_Strings |      System.String[] |        795.27 ns |       2.620 ns |       2.450 ns |        795.10 ns |    4 |
|            For_Over_Collection_Of_Strings |      System.String[] |     15,630.17 ns |     311.479 ns |     358.700 ns |     15,651.54 ns |   10 |
|            For_Over_Collection_Of_Strings |      System.String[] |    303,379.53 ns |   2,024.900 ns |   1,795.021 ns |    303,099.14 ns |   17 |

## * Legends *
  collection : Value of the 'collection' parameter
  Mean       : Arithmetic mean of all measurements
  Error      : Half of 99.9% confidence interval
  StdDev     : Standard deviation of all measurements
  Median     : Value separating the higher half of all measurements (50th percentile)
  Rank       : Relative position of current benchmark mean among all benchmarks (Arabic style)
  1 ns       : 1 Nanosecond (0.000000001 sec)