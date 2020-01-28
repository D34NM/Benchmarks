namespace Benchmark.Strings
{
    public class ReadWriteModel
    {
        private string _someString;
        private int _someInt;
        private bool _someBool;

        public string SomeString { get { return _someString; } set { _someString = value; } }
        public int SomeInt { get { return _someInt; } set { _someInt = value; } }
        public bool SomeBool { get { return _someBool; } set { _someBool = value; } }

        public static implicit operator string(ReadWriteModel model) => $"{model.SomeString} - {model.SomeInt} - {model.SomeBool}";

        public string ToString_Interpolation_Properties() => $"{SomeString} - {SomeInt} - {SomeBool}";

        public string ToString_Interpolation_Fields() => $"{_someString} - {_someInt} - {_someBool}";

        public string ToString_Format_Properties() => string.Format("{0} - {1} - {2}", SomeString, SomeInt, SomeBool);

        public string ToString_Format_Fields() => string.Format("{0} - {1} - {2}", _someString, _someInt, _someBool);
    }
}
