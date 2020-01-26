using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Linq.Projections
{
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

    public class Select
    {
        public void Run()
        {

        }

        [Benchmark]
        public void ComplexObjects()
        {
            
        }
    }
}
