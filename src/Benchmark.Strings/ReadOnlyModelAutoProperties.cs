namespace Benchmark.Strings
{
    public class ReadOnlyModelAutoProperties
    {
        private readonly string _stringRepresentation;

        public ReadOnlyModelAutoProperties(string someString, int someInt, bool someBool)
        {
            SomeString = someString;
            SomeInt = someInt;
            SomeBool = someBool;

            _stringRepresentation = $"{someString} - {someInt} - {someBool}";
        }

        public string SomeString { get; }
        public int SomeInt { get; }
        public bool SomeBool { get; }

        public static implicit operator string(ReadOnlyModelAutoProperties model) => model._stringRepresentation;
        public string ToString_With_String_Representation_Field() => _stringRepresentation;
        public string ToString_Interpolation_Properties() => $"{SomeString} - {SomeInt} - {SomeBool}";
        public string ToString_Format_Properties() => string.Format("{0} - {1} - {2}", SomeString, SomeInt, SomeBool);
    }
}
