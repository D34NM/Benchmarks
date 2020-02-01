# Dynamic method invocation benchmarks

*Results:*

|             Method |      Mean |     Error |    StdDev |    Median | MValue |
|------------------- |----------:|----------:|----------:|----------:|-------:|
|  Static_Invocation | 0.0001 ns | 0.0003 ns | 0.0003 ns | 0.0000 ns |  2.000 |
| Dynamic_Invocation | 9.2572 ns | 0.1236 ns | 0.1156 ns | 9.1970 ns |  2.000 |

// * Warnings *  
ZeroMeasurement  
  Benchmarks.Static_Invocation: Default -> The method duration is indistinguishable from the empty method duration  

  **Legend:**  
  *collection : Value of the 'collection' parameter*  
  *Mean       : Arithmetic mean of all measurements*  
  *Error      : Half of 99.9% confidence interval*  
  *StdDev     : Standard deviation of all measurements*  
  *Median     : Value separating the higher half of all measurements (50th percentile)*  
  *1 ns       : 1 Nanosecond (0.000000001 sec)*
  