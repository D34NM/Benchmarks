# Dynamic method invocation benchmarks

*Results:*

|                                     Method |                Mean |             Error |             StdDev |              Median | MValue |
|------------------------------------------- |--------------------:|------------------:|-------------------:|--------------------:|-------:|
|                          Static_Invocation |           0.0123 ns |         0.0084 ns |          0.0075 ns |           0.0101 ns |  2.500 |
|                         Dynamic_Invocation |           8.3539 ns |         0.1027 ns |          0.0910 ns |           8.3101 ns |  2.000 |
|           Single_Anonymous_Object_Creation |         593.2957 ns |         5.2609 ns |          4.9211 ns |         593.2283 ns |  2.000 |
| Single_ExpandoObject_AsDictionary_Creation |         853.5465 ns |        15.0842 ns |         14.1097 ns |         851.2105 ns |  2.000 |
|                  Anonymous_Object_Creation |  37,862,232.6430 ns |   851,088.2702 ns |  2,358,361.5879 ns |  38,854,005.9231 ns |  3.333 |
|        ExpandoObject_AsDictionary_Creation | 147,870,988.9625 ns | 6,936,503.7464 ns | 20,452,437.8000 ns | 143,601,884.1250 ns |  4.429 |
|             ExpandoObject_Dynamic_Creation | 138,879,818.9455 ns | 5,897,493.8405 ns | 17,296,328.5392 ns | 136,042,305.4000 ns |  2.273 |

// * Warnings *  
ZeroMeasurement  
  Benchmarks.Static_Invocation: Default -> The method duration is indistinguishable from the empty method duration  
MultimodalDistribution  
  Benchmarks.ExpandoObject_AsDictionary_Creation: Default -> It seems that the distribution is bimodal (mValue = 3.22)  

  **Legend:**  
  *collection : Value of the 'collection' parameter*  
  *Mean       : Arithmetic mean of all measurements*  
  *Error      : Half of 99.9% confidence interval*  
  *StdDev     : Standard deviation of all measurements*  
  *Median     : Value separating the higher half of all measurements (50th percentile)*  
  *1 ns       : 1 Nanosecond (0.000000001 sec)*
  