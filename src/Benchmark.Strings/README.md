# Strings

*Results:*

|                                                           Method |      Mean |     Error |    StdDev | MValue |
|----------------------------------------------------------------- |----------:|----------:|----------:|-------:|
|               ReadOnly_ToString_With_String_Representation_Field |  2.790 ms | 0.0530 ms | 0.0414 ms |  2.000 |
|                       ReadOnly_ToString_Interpolation_Properties | 21.379 ms | 0.1463 ms | 0.1297 ms |  2.000 |
|                           ReadOnly_ToString_Interpolation_Fields | 21.154 ms | 0.1564 ms | 0.1387 ms |  2.000 |
|                              ReadOnly_ToString_Format_Properties | 21.088 ms | 0.1406 ms | 0.1174 ms |  2.000 |
|                                  ReadOnly_ToString_Format_Fields | 22.888 ms | 0.1889 ms | 0.1675 ms |  2.000 |
|                              ReadOnly_Implicit_Operator_Variable |  2.750 ms | 0.0574 ms | 0.0537 ms |  2.000 |
|                                           ReadOnly_Interpolation | 21.312 ms | 0.1416 ms | 0.1255 ms |  2.000 |
|                                                  ReadOnly_Format | 33.896 ms | 0.2542 ms | 0.2123 ms |  2.000 |
| ReadOnlyAutoProperties_ToString_With_String_Representation_Field |  2.695 ms | 0.0534 ms | 0.0636 ms |  2.000 |
|         ReadOnlyAutoProperties_ToString_Interpolation_Properties | 21.732 ms | 0.2205 ms | 0.1954 ms |  2.000 |
|                ReadOnlyAutoProperties_ToString_Format_Properties | 21.569 ms | 0.1284 ms | 0.1138 ms |  2.000 |
|                ReadOnlyAutoProperties_Implicit_Operator_Variable |  2.674 ms | 0.0497 ms | 0.0464 ms |  2.000 |
|                             ReadOnlyAutoProperties_Interpolation | 22.122 ms | 0.1969 ms | 0.1746 ms |  2.000 |
|                                    ReadOnlyAutoProperties_Format | 36.648 ms | 0.7317 ms | 1.2621 ms |  2.000 |
|                          ReadWrite_ToString_Interpolation_Fields | 22.506 ms | 0.1329 ms | 0.1110 ms |  2.000 |
|                      ReadWrite_ToString_Interpolation_Properties | 22.849 ms | 0.2010 ms | 0.1880 ms |  2.000 |
|                                 ReadWrite_ToString_Format_Fields | 21.941 ms | 0.1453 ms | 0.1288 ms |  2.000 |
|                             ReadWrite_ToString_Format_Properties | 22.811 ms | 0.5532 ms | 0.6149 ms |  2.154 |
|                        ReadWrite_Implicit_Operator_Interpolation | 22.430 ms | 0.1710 ms | 0.1516 ms |  2.000 |
|                                          ReadWrite_Interpolation | 22.505 ms | 0.4324 ms | 0.3611 ms |  2.000 |
|                                                 ReadWrite_Format | 30.370 ms | 0.5692 ms | 0.5324 ms |  2.000 |
|                    ReadWriteFields_ToString_Interpolation_Fields | 23.369 ms | 0.4739 ms | 0.9997 ms |  2.952 |
|                           ReadWriteFields_ToString_Format_Fields | 22.553 ms | 0.5418 ms | 0.4803 ms |  2.000 |
|                  ReadWriteFields_Implicit_Operator_Interpolation | 22.910 ms | 0.3919 ms | 0.3666 ms |  2.000 |
|                                    ReadWriteFields_Interpolation | 22.442 ms | 0.4304 ms | 0.4026 ms |  2.000 |
|                                           ReadWriteFields_Format | 31.107 ms | 0.6064 ms | 0.8300 ms |  2.000 |

// * Warnings *  
MultimodalDistribution  
  ToString_vs_Interpolation.ReadWriteFields_ToString_Interpolation_Fields: Default -> It seems that the distribution can have several modes (mValue = 2.95)  

// * Hints *  
Outliers  
  ToString_vs_Interpolation.ReadOnly_ToString_With_String_Representation_Field: Default               -> 3 outliers were removed (2.96 ms..3.20 ms)  
  ToString_vs_Interpolation.ReadOnly_ToString_Interpolation_Properties: Default                       -> 1 outlier  was  removed (22.70 ms)  
  ToString_vs_Interpolation.ReadOnly_ToString_Interpolation_Fields: Default                           -> 1 outlier  was  removed (22.13 ms)  
  ToString_vs_Interpolation.ReadOnly_ToString_Format_Properties: Default                              -> 2 outliers were removed (21.71 ms, 21.75 ms)  
  ToString_vs_Interpolation.ReadOnly_ToString_Format_Fields: Default                                  -> 1 outlier  was  removed (23.83 ms)  
  ToString_vs_Interpolation.ReadOnly_Interpolation: Default                                           -> 1 outlier  was  removed (22.61 ms)  
  ToString_vs_Interpolation.ReadOnly_Format: Default                                                  -> 2 outliers were removed, 3 outliers were detected (33.51 ms, 34.69 ms, 36.36 ms)  
  ToString_vs_Interpolation.ReadOnlyAutoProperties_ToString_With_String_Representation_Field: Default -> 2 outliers were removed (3.06 ms, 3.19 ms)  
  ToString_vs_Interpolation.ReadOnlyAutoProperties_ToString_Interpolation_Properties: Default         -> 1 outlier  was  removed (22.56 ms)  
  ToString_vs_Interpolation.ReadOnlyAutoProperties_ToString_Format_Properties: Default                -> 1 outlier  was  removed (23.08 ms)  
  ToString_vs_Interpolation.ReadOnlyAutoProperties_Interpolation: Default                             -> 1 outlier  was  removed (23.07 ms)  
  ToString_vs_Interpolation.ReadWrite_ToString_Interpolation_Fields: Default                          -> 2 outliers were removed (22.98 ms, 23.18 ms)  
  ToString_vs_Interpolation.ReadWrite_ToString_Format_Fields: Default                                 -> 1 outlier  was  removed (22.71 ms)  
  ToString_vs_Interpolation.ReadWrite_Implicit_Operator_Interpolation: Default                        -> 1 outlier  was  removed (23.45 ms)  
  ToString_vs_Interpolation.ReadWrite_Interpolation: Default                                          -> 2 outliers were removed (24.09 ms, 24.52 ms)  
  ToString_vs_Interpolation.ReadWriteFields_ToString_Interpolation_Fields: Default                    -> 3 outliers were removed (26.73 ms..27.37 ms)  
  ToString_vs_Interpolation.ReadWriteFields_ToString_Format_Fields: Default                           -> 1 outlier  was  removed (24.52 ms)  
  ToString_vs_Interpolation.ReadWriteFields_Format: Default                                           -> 2 outliers were removed (34.74 ms, 38.11 ms)  

**Legend:**  
  *collection : Value of the 'collection' parameter*  
  *Mean       : Arithmetic mean of all measurements*  
  *Error      : Half of 99.9% confidence interval*  
  *StdDev     : Standard deviation of all measurements*  
  *Median     : Value separating the higher half of all measurements (50th percentile)*  
  *1 ns       : 1 Nanosecond (0.000000001 sec)*
  