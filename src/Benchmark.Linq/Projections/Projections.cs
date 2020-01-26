using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Benchmark.Linq.Projections
{
    [RankColumn, RPlotExporter]
    public class ProjectionImpl
    {
        private readonly Fixture _fixture;
        private readonly Consumer _consumer;

        public ProjectionImpl()
        {
            _fixture = new Fixture();
            _consumer = new Consumer();
        }

        [Benchmark]
        [BenchmarkCategory("Projections", "Select")]
        [ArgumentsSource(nameof(CollectionOfNumbers))]
        public void Select_Over_Collection_Of_Numbers(int[] collection)
            => collection
            .Select(number => $"{number}")
            .Consume(_consumer);

        [Benchmark]
        [BenchmarkCategory("Projections", "Foreach")]
        [ArgumentsSource(nameof(CollectionOfNumbers))]
        public void Foreach_Over_Collection_Of_Numbers(int[] collection)
        {
            var result = new List<string>(collection.Length);
            foreach (var item in collection)
            {
                result.Add($"{item}");
            }
        }

        [Benchmark]
        [BenchmarkCategory("Projections", "For")]
        [ArgumentsSource(nameof(CollectionOfNumbers))]
        public void For_Over_Collection_Of_Numbers(int[] collection)
        {
            var result = new string[collection.Length];
            for (int i = 0; i < collection.Length; i++)
            {
                result[i] = $"{collection[i]}";
            }
        }

        [Benchmark]
        [BenchmarkCategory("Projections", "Select")]
        [ArgumentsSource(nameof(CollectionOfStrings))]
        public void Select_Over_Collection_Of_Strings(string[] collection)
            => collection
            .Select(str => str.Length <= 4 && str.Length >= 10)
            .Consume(_consumer);

        [Benchmark]
        [BenchmarkCategory("Projections", "Foreach")]
        [ArgumentsSource(nameof(CollectionOfStrings))]
        public void Foreach_Over_Collection_Of_Strings(string[] collection)
        {
            var result = new List<bool>(collection.Length);
            foreach (var item in collection)
            {
                result.Add(item.Length <= 4 && item.Length >= 10);
            }
        }

        [Benchmark]
        [BenchmarkCategory("Projections", "For")]
        [ArgumentsSource(nameof(CollectionOfStrings))]
        public void For_Over_Collection_Of_Strings(string[] collection)
        {
            var result = new bool[collection.Length];
            for (int i = 0; i < collection.Length; i++)
            {
                result[i] = collection[i].Length <= 4 && collection[i].Length >= 10;
            }
        }

        [Benchmark]
        [BenchmarkCategory("Projections", "Select")]
        [ArgumentsSource(nameof(CollectionOfComplexObjects))]
        public void Select_Over_Collection_Of_Complex_Objects(ComplexObject[] collection)
            => collection
            .Select(obj => $"{obj.SomeId} - {obj.SomeString} - {obj.OtherObjects.Count()}")
            .Consume(_consumer);

        // todo SelectMany

        #region Data
        public IEnumerable<object> CollectionOfNumbers()
        {
            yield return Enumerable.Range(0, 100).ToArray();
            yield return Enumerable.Range(0, 1000).ToArray();
            yield return Enumerable.Range(0, 10000).ToArray();
            yield return Enumerable.Range(0, 100000).ToArray();
        }

        public IEnumerable<object> CollectionOfStrings()
        {
            yield return _fixture.CreateMany<string>(100).ToArray();
            yield return _fixture.CreateMany<string>(1000).ToArray();
            yield return _fixture.CreateMany<string>(10000).ToArray();
            yield return _fixture.CreateMany<string>(100000).ToArray();
        }

        public IEnumerable<object> CollectionOfComplexObjects()
        {
            yield return _fixture.CreateMany<ComplexObject>(100).ToArray();
            yield return _fixture.CreateMany<ComplexObject>(1000).ToArray();
            yield return _fixture.CreateMany<ComplexObject>(10000).ToArray();
            yield return _fixture.CreateMany<ComplexObject>(100000).ToArray();
        }
        #endregion
    }

    #region Helper classes
    public class OtherObject
    {
        public string OtherString { get; set; }
        public long OtherLong { get; set; }
    }

    public class ComplexObject
    {
        public Guid SomeId { get; set; }
        public string SomeString { get; set; }
        public int SomeInt { get; set; }
        public IEnumerable<OtherObject> OtherObjects { get; set; }
    }
    #endregion
}
