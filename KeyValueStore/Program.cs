using System;

namespace KeyValueStore
{
    struct KeyValue
    {
        public readonly string Key;
        public readonly object Value;
        public KeyValue(string key, object value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
    class MyDictionary
    {
        public KeyValue[] 
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
