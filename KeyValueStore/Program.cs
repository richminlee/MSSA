using System;

namespace KeyValueStore
{
    struct KeyValue
    {
        public readonly string _Key;
        public readonly object _Value;
        public KeyValue(string key, object value)
        {
            this._Key = key;
            this._Value = value;
        }
    }
    class MyDictionary
    {
        private string _key;
        private object _value;
        public MyDictionary(KeyValue input)
        {
            this._key = input._Key;
            this._value = input._Value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
}
