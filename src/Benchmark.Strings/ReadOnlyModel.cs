namespace Benchmark.Strings
{
    public class ReadOnlyModel
    {
        private readonly string _stringRepresentation;

        public ReadOnlyModel(string someString, int someInt, bool someBool)
        {
            SomeString = someString;
            SomeInt = someInt;
            SomeBool = someBool;

            _stringRepresentation = $"{someString} - {someInt} - {someBool}";
        }

        public string SomeString { get; }
        public int SomeInt { get; }
        public bool SomeBool { get; }

        public static implicit operator string(ReadOnlyModel model) => model._stringRepresentation;

        public string ToString_Variable() => _stringRepresentation;
        public string ToString_Interpolation() => $"{SomeString} - {SomeInt} - {SomeBool}";
        public string ToString_Format() => string.Format("{0} - {1} - {2}", SomeString, SomeInt, SomeBool);
    }
}
