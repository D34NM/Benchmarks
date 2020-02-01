# Projections

*Results:*

|                                     Method |         Mean |       Error |      StdDev |       Median |
|------------------------------------------- |-------------:|------------:|------------:|-------------:|
|          Select_Over_Collection_Of_Numbers |  10,730.7 us |   126.33 us |   111.98 us |  10,728.0 us |
|         Foreach_Over_Collection_Of_Numbers |  30,518.9 us |   586.33 us |   697.98 us |  30,590.4 us |
|             For_Over_Collection_Of_Numbers |  30,296.0 us |   573.18 us |   562.94 us |  30,417.7 us |
|          Select_Over_Collection_Of_Strings |     823.1 us |     6.06 us |     5.38 us |     823.1 us |
|         Foreach_Over_Collection_Of_Strings |     480.1 us |     4.75 us |     4.21 us |     478.7 us |
|             For_Over_Collection_Of_Strings |     438.9 us |     8.40 us |     7.85 us |     435.8 us |
|  Select_Over_Collection_Of_Complex_Objects |  51,091.2 us | 1,163.61 us | 1,592.76 us |  50,690.1 us |
| Foreach_Over_Collection_Of_Complex_Objects | 102,018.8 us | 1,814.51 us | 1,608.52 us | 101,842.2 us |
|     For_Over_Collection_Of_Complex_Objects | 106,280.9 us | 2,111.98 us | 5,781.50 us | 104,329.4 us |

**Legend:**  
  *collection : Value of the 'collection' parameter*  
  *Mean       : Arithmetic mean of all measurements*  
  *Error      : Half of 99.9% confidence interval*  
  *StdDev     : Standard deviation of all measurements*  
  *Median     : Value separating the higher half of all measurements (50th percentile)*  
  *1 ns       : 1 Nanosecond (0.000000001 sec)*
  