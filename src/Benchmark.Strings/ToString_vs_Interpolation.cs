using AutoFixture;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System.Collections.Generic;
using System.Linq;

namespace Benchmark.Strings
{
    public class ToString_vs_Interpolation
    {
        private readonly Fixture _fixture;
        private readonly Consumer _consumer;

        private ReadOnlyModel[] _readOnlyCollection;
        private ReadWriteModel[] _readWriteCollection;

        public ToString_vs_Interpolation()
        {
            _fixture = new Fixture();
            _consumer = new Consumer();
        }

        [GlobalSetup]
        public void GlobalSetup()
        {
            _readOnlyCollection = _fixture.CreateMany<ReadOnlyModel>(100_000).ToArray();
            _readWriteCollection = _fixture.CreateMany<ReadWriteModel>(100_000).ToArray();
        }

        [Benchmark]
        public void ReadOnly_ToString_Variable()
        {
            _readOnlyCollection
                .Select(item => item.ToString_Variable())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnly_ToString_Interpolation()
        {
            _readOnlyCollection
                .Select(item => item.ToString_Interpolation())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnly_ToString_Format()
        {
            _readOnlyCollection
                .Select(item => item.ToString_Format())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnly_Implicit_Operator_Variable()
        {
            _readOnlyCollection
                .Select<ReadOnlyModel, string>(item => item)
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnly_Interpolation()
        {
            _readOnlyCollection
                .Select(item => $"{item.SomeString} - {item.SomeInt} - {item.SomeBool}")
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnly_Format()
        {
            _readOnlyCollection
                .Select(item => string.Format($"{0} - {1} - {2}", item.SomeString, item.SomeInt, item.SomeBool))
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWrite_ToString_Interpolation()
        {
            _readWriteCollection
                .Select(item => item.ToString_Interpolation())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWrite_ToString_Format()
        {
            _readWriteCollection
                .Select(item => item.ToString_Format())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWrite_Implicit_Operator_Interpolation()
        {
            _readWriteCollection
                .Select<ReadWriteModel, string>(item => item)
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWrite_Interpolation()
        {
            _readWriteCollection
                .Select(item => $"{item.SomeString} - {item.SomeInt} - {item.SomeBool}")
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWrite_Format()
        {
            _readWriteCollection
                .Select(item => string.Format($"{0} - {1} - {2}", item.SomeString, item.SomeInt, item.SomeBool))
                .Consume(_consumer);
        }
    }
}
