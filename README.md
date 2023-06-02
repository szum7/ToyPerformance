# ToyPerformance

A repository to measure performance of various topics. Topics like span, Entity Framework, linq, multithreading, etc.

Also can have multiple ways to measure performance. The main one is the BenchmarkDotNet nuget package.

To run the benchmark for BenchmarkDotNet:
```
cd to the solution folder
dotnet build -c Release 
dotnet BenchmarkApp\bin\Release\net7.0\BenchmarkApp.dll
```
