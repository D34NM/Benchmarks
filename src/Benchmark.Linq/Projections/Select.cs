using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Benchmark.Linq.Projections
{
    [MaxColumn]
    [MedianColumn]
    [MinColumn]
    public class Select
    {
        private readonly Fixture _fixture;
        private readonly Consumer _consumer;

        public Select()
        {
            _fixture = new Fixture();
            _consumer = new Consumer();
        }

        [Benchmark]
        [ArgumentsSource(nameof(CollectionOfNumbers))]
        public void Select_Over_Collection_Of_Numbers(int[] collection)
            => collection
            .Select(number => $"{number}")
            .Consume(_consumer);

        [Benchmark]
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
        [ArgumentsSource(nameof(CollectionOfStrings))]
        public void Select_Over_Collection_Of_Strings(string[] collection)
            => collection
            .Select(str => str.Length <= 4 && str.Length >= 10)
            .Consume(_consumer);

        [Benchmark]
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
        [ArgumentsSource(nameof(CollectionOfStrings))]
        public void For_Over_Collection_Of_Strings(string[] collection)
        {
            var result = new bool[collection.Length];
            for (int i = 0; i < collection.Length; i++)
            {
                var item = collection[i];
                result[i] = item.Length <= 4 && item.Length >= 10;
            }
        }

        [Benchmark]
        [ArgumentsSource(nameof(CollectionOfComplexObjects))]
        public void Select_Over_Collection_Of_Complex_Objects(ComplexObject[] collection)
            => collection
            .Select(obj => $"{obj.SomeId} - {obj.SomeString} - {obj.OtherObjects.Count()}")
            .Consume(_consumer);

        [Benchmark]
        [ArgumentsSource(nameof(CollectionOfComplexObjects))]
        public void Foreach_Over_Collection_Of_Complex_Objects(ComplexObject[] collection)
        {
            var result = new List<string>(collection.Length);
            foreach (var item in collection)
            {
                result.Add($"{item.SomeId} - {item.SomeString} - {item.OtherObjects.Count()}");
            }
        }

        [Benchmark]
        [ArgumentsSource(nameof(CollectionOfComplexObjects))]
        public void For_Over_Collection_Of_Complex_Objects(ComplexObject[] collection)
        {
            var result = new string[collection.Length];
            for (int i = 0; i < collection.Length; i++)
            {
                var item = collection[i];
                result[i] = $"{item.SomeId} - {item.SomeString} - {item.OtherObjects.Count()}";
            }
        }

        #region Data
        public IEnumerable<object> CollectionOfNumbers()
        {
            yield return _fixture.CreateMany<int>(100000).ToArray();
        }

        public IEnumerable<object> CollectionOfStrings()
        {
            yield return _fixture.CreateMany<string>(100000).ToArray();
        }

        public IEnumerable<object> CollectionOfComplexObjects()
        {
            yield return _fixture.CreateMany<ComplexObject>(100000).ToArray();
        }
        #endregion
    }
}
