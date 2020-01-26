using System;
using System.Collections.Generic;

namespace Benchmark.Linq.Projections
{
    public class ComplexObject
    {
        public Guid SomeId { get; set; }
        public string SomeString { get; set; }
        public int SomeInt { get; set; }
        public IEnumerable<OtherObject> OtherObjects { get; set; }
    }
}
