``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Threshold 1 (10.0.10240)
Processor=Intel Core i7-3770 CPU 3.40GHz (Ivy Bridge), ProcessorCount=8
Frequency=3312789 Hz, Resolution=301.8605 ns, Timer=TSC
.NET Core SDK=2.0.0
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT DEBUG
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
 |                  Method |     Mean |     Error |    StdDev |
 |------------------------ |---------:|----------:|----------:|
 |           DapperInsert0 | 5.202 ms | 0.1031 ms | 0.1936 ms |
 |               EfInsert0 | 3.577 ms | 0.0549 ms | 0.0459 ms |
 |           DapperSelect0 | 5.106 ms | 0.0953 ms | 0.0979 ms |
 |               EfSelect0 | 3.810 ms | 0.0747 ms | 0.1119 ms |
 | DapperSelectWithFilter0 | 5.252 ms | 0.1028 ms | 0.1100 ms |
 |     EfSelectWithFilter0 | 3.919 ms | 0.0775 ms | 0.1008 ms |
