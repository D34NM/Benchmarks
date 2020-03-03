# Dynamic method invocation benchmarks

*Results:*

|                              Method |                Mean |             Error |             StdDev |              Median | MValue |
|------------------------------------ |--------------------:|------------------:|-------------------:|--------------------:|-------:|
|                   Static_Invocation |           0.0024 ns |         0.0096 ns |          0.0090 ns |           0.0000 ns |  2.000 |
|                  Dynamic_Invocation |           8.4476 ns |         0.1180 ns |          0.1104 ns |           8.4089 ns |  2.000 |
|           Anonymous_Object_Creation |  33,580,412.5750 ns |   178,479.0986 ns |    166,949.4596 ns |  33,570,692.0625 ns |  2.000 |
| ExpandoObject_AsDictionary_Creation | 120,913,178.1515 ns | 2,353,843.0130 ns |  3,733,444.4559 ns | 120,952,371.2000 ns |  2.000 |
|      ExpandoObject_Dynamic_Creation | 126,463,547.3811 ns | 5,013,008.1636 ns | 14,383,260.1417 ns | 121,362,129.2000 ns |  2.552 |

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
  