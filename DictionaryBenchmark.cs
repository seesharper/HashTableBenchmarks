using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace HashTableBenchmarks
{
    [MemoryDiagnoser]
    public class DictionaryBenchmark
    {
        private Dictionary<Type, Func<object>> dictionary = new Dictionary<Type, Func<object>>();

        private ImmutableHashTable<Type, Func<object>> immutableHashTable = ImmutableHashTable<Type, Func<object>>.Empty;

        [GlobalSetup]
        public void Setup()
        {
            dictionary.Add(typeof(Class1), () => new Class1());
            dictionary.Add(typeof(Class2), () => new Class2());
            dictionary.Add(typeof(Class3), () => new Class3());
            dictionary.Add(typeof(Class4), () => new Class4());
            dictionary.Add(typeof(Class5), () => new Class5());

            immutableHashTable = immutableHashTable.Add(typeof(Class1), () => new Class1());
            immutableHashTable = immutableHashTable.Add(typeof(Class2), () => new Class2());
            immutableHashTable = immutableHashTable.Add(typeof(Class3), () => new Class3());
            immutableHashTable = immutableHashTable.Add(typeof(Class4), () => new Class4());
            immutableHashTable = immutableHashTable.Add(typeof(Class5), () => new Class5());
        }


        [Benchmark]
        public void UsingDictionary()
        {
            var value1 = dictionary.GetValueOrDefault(typeof(Class1));
            var value2 = dictionary.GetValueOrDefault(typeof(Class2));
            var value3 = dictionary.GetValueOrDefault(typeof(Class3));
            var value4 = dictionary.GetValueOrDefault(typeof(Class4));
            var value5 = dictionary.GetValueOrDefault(typeof(Class5));
        }

        [Benchmark]
        public void UsingImmutableHashTable()
        {
            var value1 = immutableHashTable.Search(typeof(Class1));
            var value2 = immutableHashTable.Search(typeof(Class2));
            var value3 = immutableHashTable.Search(typeof(Class3));
            var value4 = immutableHashTable.Search(typeof(Class4));
            var value5 = immutableHashTable.Search(typeof(Class5));
        }
    }


    public class Class1
    {

    }


    public class Class2
    {

    }

    public class Class3
    {

    }

    public class Class4
    {

    }


    public class Class5
    {

    }
}