```
BenchmarkDotNet=v0.12.1, OS=macOS Mojave 10.14.6 (18G95) [Darwin 18.7.0]
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


|                  Method |      Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |----------:|---------:|---------:|------:|------:|------:|----------:|
|         UsingDictionary | 112.42 ns | 0.673 ns | 0.562 ns |     - |     - |     - |         - |
| UsingImmutableHashTable |  27.35 ns | 0.194 ns | 0.181 ns |     - |     - |     - |         - |
```
