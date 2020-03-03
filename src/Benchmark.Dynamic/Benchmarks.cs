using System.Dynamic;
using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Dynamic
{
    [MValueColumn]
    public class Benchmarks
    {
        private Runner _runner;
        private dynamic _dynamicRunner;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _runner = new Runner();
            _dynamicRunner = new Runner();
        }

        [Benchmark]
        public void Static_Invocation()
        {
            var _ = _runner.Run();
        }

        [Benchmark]
        public void Dynamic_Invocation()
        {
            var _ = _dynamicRunner.Run();
        }

        [Benchmark]
        public void Single_Anonymous_Object_Creation()
        {
            _ = new 
            {
                FirstPropery = Guid.NewGuid(),
                SecondProperty = Guid.NewGuid()
            };
        }

        [Benchmark]
        public void Single_ExpandoObject_AsDictionary_Creation()
        {
            var expandoObject = new ExpandoObject() as IDictionary<string, object>;
            expandoObject.Add("FirstProperty", Guid.NewGuid());
            expandoObject.Add("SecondProperty", Guid.NewGuid());
            _ = (ExpandoObject)expandoObject;
        }

        [Benchmark]
        public void Anonymous_Object_Creation()
        {
            var list = new List<object>(100_000);
            for (var i = 0; i <= 100_000; i++)
            {
                list.Add(new 
                {
                    FirstProperty = Guid.NewGuid(),
                    SecondProperty = i
                });
            }
        }

        [Benchmark]
        public void ExpandoObject_AsDictionary_Creation()
        {
            var list = new List<ExpandoObject>(100_000);
            for (var i = 0; i <= 100_000; i++)
            {
                var expandoObject = new ExpandoObject() as IDictionary<string, object>;
                expandoObject.Add("FirstProperty", Guid.NewGuid());
                expandoObject.Add("SecondProperty", i);
                list.Add((ExpandoObject)expandoObject);
            }
        }

        [Benchmark]
        public void ExpandoObject_Dynamic_Creation()
        {
            var list = new List<ExpandoObject>(100_000);
            for (var i = 0; i <= 100_000; i++)
            {
                dynamic expandoObject = new ExpandoObject();
                expandoObject.FirstProperty = Guid.NewGuid();
                expandoObject.SecondProperty = i;
                list.Add(expandoObject);
            }
        }
    }
}
