namespace Benchmark.Strings
{
    public class ReadWriteModelFields
    {
        public string SomeString;
        public int SomeInt;
        public bool SomeBool;

        public static implicit operator string(ReadWriteModelFields model) => $"{model.SomeString} - {model.SomeInt} - {model.SomeBool}";

        public string ToString_Interpolation_Fields() => $"{SomeString} - {SomeInt} - {SomeBool}";

        public string ToString_Format_Fields() => string.Format("{0} - {1} - {2}", SomeString, SomeInt, SomeBool);
    }
}
