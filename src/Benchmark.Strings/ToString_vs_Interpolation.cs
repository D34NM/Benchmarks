using AutoFixture;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System.Linq;

namespace Benchmark.Strings
{
    [MValueColumn]
    public class ToString_vs_Interpolation
    {
        private readonly Fixture _fixture;
        private readonly Consumer _consumer;

        private ReadOnlyModel[] _readOnlyCollection;
        private ReadOnlyModelAutoProperties[] _readOnlyModelWithAutoProperties;
        private ReadWriteModel[] _readWriteCollection;
        private ReadWriteModelFields[] _readWriteCollectionWithFields;

        public ToString_vs_Interpolation()
        {
            _fixture = new Fixture();
            _consumer = new Consumer();
        }

        [GlobalSetup]
        public void GlobalSetup()
        {
            _readOnlyCollection = _fixture.CreateMany<ReadOnlyModel>(100_000).ToArray();
            _readOnlyModelWithAutoProperties = _fixture.CreateMany<ReadOnlyModelAutoProperties>(100_000).ToArray();
            _readWriteCollection = _fixture.CreateMany<ReadWriteModel>(100_000).ToArray();
            _readWriteCollectionWithFields = _fixture.CreateMany<ReadWriteModelFields>(100_000).ToArray();
        }

        #region ReadOnly
        [Benchmark]
        public void ReadOnly_ToString_With_String_Representation_Field()
        {
            _readOnlyCollection
                .Select(item => item.ToString_With_String_Representation_Field())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnly_ToString_Interpolation_Properties()
        {
            _readOnlyCollection
                .Select(item => item.ToString_Interpolation_Properties())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnly_ToString_Interpolation_Fields()
        {
            _readOnlyCollection
                .Select(item => item.ToString_Interpolation_Fields())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnly_ToString_Format_Properties()
        {
            _readOnlyCollection
                .Select(item => item.ToString_Format_Properties())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnly_ToString_Format_Fields()
        {
            _readOnlyCollection
                .Select(item => item.ToString_Format_Fields())
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
        #endregion

        #region ReadOnlyModelAutoProperties
        [Benchmark]
        public void ReadOnlyAutoProperties_ToString_With_String_Representation_Field()
        {
            _readOnlyModelWithAutoProperties
                .Select(item => item.ToString_With_String_Representation_Field())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnlyAutoProperties_ToString_Interpolation_Properties()
        {
            _readOnlyModelWithAutoProperties
                .Select(item => item.ToString_Interpolation_Properties())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnlyAutoProperties_ToString_Format_Properties()
        {
            _readOnlyModelWithAutoProperties
                .Select(item => item.ToString_Format_Properties())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnlyAutoProperties_Implicit_Operator_Variable()
        {
            _readOnlyModelWithAutoProperties
                .Select<ReadOnlyModelAutoProperties, string>(item => item)
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnlyAutoProperties_Interpolation()
        {
            _readOnlyModelWithAutoProperties
                .Select(item => $"{item.SomeString} - {item.SomeInt} - {item.SomeBool}")
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadOnlyAutoProperties_Format()
        {
            _readOnlyModelWithAutoProperties
                .Select(item => string.Format($"{0} - {1} - {2}", item.SomeString, item.SomeInt, item.SomeBool))
                .Consume(_consumer);
        }

        #endregion

        #region ReadWrite
        [Benchmark]
        public void ReadWrite_ToString_Interpolation_Fields()
        {
            _readWriteCollection
                .Select(item => item.ToString_Interpolation_Fields())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWrite_ToString_Interpolation_Properties()
        {
            _readWriteCollection
                .Select(item => item.ToString_Interpolation_Properties())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWrite_ToString_Format_Fields()
        {
            _readWriteCollection
                .Select(item => item.ToString_Format_Fields())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWrite_ToString_Format_Properties()
        {
            _readWriteCollection
                .Select(item => item.ToString_Format_Properties())
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
        #endregion

        #region ReadWriteModelFields
        [Benchmark]
        public void ReadWriteFields_ToString_Interpolation_Fields()
        {
            _readWriteCollectionWithFields
                .Select(item => item.ToString_Interpolation_Fields())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWriteFields_ToString_Format_Fields()
        {
            _readWriteCollectionWithFields
                .Select(item => item.ToString_Format_Fields())
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWriteFields_Implicit_Operator_Interpolation()
        {
            _readWriteCollectionWithFields
                .Select<ReadWriteModelFields, string>(item => item)
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWriteFields_Interpolation()
        {
            _readWriteCollectionWithFields
                .Select(item => $"{item.SomeString} - {item.SomeInt} - {item.SomeBool}")
                .Consume(_consumer);
        }

        [Benchmark]
        public void ReadWriteFields_Format()
        {
            _readWriteCollectionWithFields
                .Select(item => string.Format($"{0} - {1} - {2}", item.SomeString, item.SomeInt, item.SomeBool))
                .Consume(_consumer);
        }
        #endregion
    }
}
