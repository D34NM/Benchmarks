using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Benchmark.Linq.Projections
{
    public class Select
    {
        private readonly Fixture _fixture;
        private readonly Consumer _consumer;

        private int[] _collectionOfIntegers;
        private string[] _collectionOfStrings;
        private ComplexObject[] _collectionOfObjects;

        public Select()
        {
            _fixture = new Fixture();
            _consumer = new Consumer();
        }

        [GlobalSetup]
        public void GlobalSetup()
        {
            _collectionOfIntegers = _fixture.CreateMany<int>(100_000).ToArray();
            _collectionOfStrings = _fixture.CreateMany<string>(100_000).ToArray();
            _collectionOfObjects = _fixture.CreateMany<ComplexObject>(100_000).ToArray();
        }

        [Benchmark]
        public void Select_Over_Collection_Of_Numbers()
        {
            _collectionOfIntegers
                .Select(number => $"{number}")
                .Consume(_consumer);
        }

        [Benchmark]
        public void Foreach_Over_Collection_Of_Numbers()
        {
            var result = new List<string>(_collectionOfIntegers.Length);
            foreach (var item in _collectionOfIntegers)
            {
                result.Add($"{item}");
            }
        }

        [Benchmark]
        public void For_Over_Collection_Of_Numbers()
        {
            var result = new string[_collectionOfIntegers.Length];
            for (int i = 0; i < _collectionOfIntegers.Length; i++)
            {
                result[i] = $"{_collectionOfIntegers[i]}";
            }
        }

        [Benchmark]
        public void Select_Over_Collection_Of_Strings()
        {
            _collectionOfStrings
                .Select(str => str.Length <= 4 && str.Length >= 10)
                .Consume(_consumer);
        }

        [Benchmark]
        public void Foreach_Over_Collection_Of_Strings()
        {
            var result = new List<bool>(_collectionOfStrings.Length);
            foreach (var item in _collectionOfStrings)
            {
                result.Add(item.Length <= 4 && item.Length >= 10);
            }
        }

        [Benchmark]
        public void For_Over_Collection_Of_Strings()
        {
            var result = new bool[_collectionOfStrings.Length];
            for (int i = 0; i < _collectionOfStrings.Length; i++)
            {
                var item = _collectionOfStrings[i];
                result[i] = item.Length <= 4 && item.Length >= 10;
            }
        }

        [Benchmark]
        public void Select_Over_Collection_Of_Complex_Objects()
        {
            _collectionOfObjects
                .Select(obj => $"{obj.SomeId} - {obj.SomeString} - {obj.OtherObjects.Count()}")
                .Consume(_consumer);
        }

        [Benchmark]
        public void Foreach_Over_Collection_Of_Complex_Objects()
        {
            var result = new List<string>(_collectionOfObjects.Length);
            foreach (var item in _collectionOfObjects)
            {
                result.Add($"{item.SomeId} - {item.SomeString} - {item.OtherObjects.Count()}");
            }
        }

        [Benchmark]
        public void For_Over_Collection_Of_Complex_Objects()
        {
            var result = new string[_collectionOfObjects.Length];
            for (int i = 0; i < _collectionOfObjects.Length; i++)
            {
                var item = _collectionOfObjects[i];
                result[i] = $"{item.SomeId} - {item.SomeString} - {item.OtherObjects.Count()}";
            }
        }
    }
}
