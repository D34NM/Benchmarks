namespace Benchmark.Strings
{
    public class ReadOnlyModel
    {
        private readonly string _stringRepresentation;

        private readonly string _someString;
        private readonly int _someInt;
        private readonly bool _someBool;

        public ReadOnlyModel(string someString, int someInt, bool someBool)
        {
            _someString = someString;
            _someInt = someInt;
            _someBool = someBool;

            _stringRepresentation = $"{someString} - {someInt} - {someBool}";
        }

        public string SomeString { get { return _someString; } }
        public int SomeInt { get { return _someInt; } }
        public bool SomeBool { get { return _someBool; } }
        
        public static implicit operator string(ReadOnlyModel model) => model._stringRepresentation;
        public string ToString_With_String_Representation_Field() => _stringRepresentation;
        public string ToString_Interpolation_Properties() => $"{SomeString} - {SomeInt} - {SomeBool}";
        public string ToString_Interpolation_Fields() => $"{_someString} - {_someInt} - {_someBool}";
        public string ToString_Format_Properties() => string.Format("{0} - {1} - {2}", SomeString, SomeInt, SomeBool);
        public string ToString_Format_Fields() => string.Format("{0} - {1} - {2}", _someString, _someInt, _someBool);
    }
}
