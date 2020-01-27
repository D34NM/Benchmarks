namespace Benchmark.Strings
{
    public class ReadWriteModel
    {
        public string SomeString { get; set; }
        public int SomeInt { get; set; }
        public bool SomeBool { get; set; }

        public static implicit operator string(ReadWriteModel model) => $"{model.SomeString} - {model.SomeInt} - {model.SomeBool}";

        public string ToString_Interpolation() => $"{SomeString} - {SomeInt} - {SomeBool}";
        public string ToString_Format() => string.Format("{0} - {1} - {2}", SomeString, SomeInt, SomeBool);
    }
}
