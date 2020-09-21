using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValues
{
    public struct KeyValue<TValue>
    {
        public readonly string Key;

        public readonly TValue Value;
        public KeyValue(string key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
    public class MyDictionary<TValue>
    {
        KeyValue<TValue>[] keyValueArray = new KeyValue<TValue>[10];
        private int storedValues;

        public TValue this[string key]
        {
            get
            {
                for (int i = 0; i < keyValueArray.Length; i++)
                {
                    if (keyValueArray[i].Key == key)
                        return keyValueArray[i].Value;
                }
                throw new KeyNotFoundException(key);
            }
            set
            {
                for (int i = 0; i < keyValueArray.Length; i++)
                {
                    if (keyValueArray[i].Key == key)
                    {
                        keyValueArray[i] = new KeyValue<TValue>(key, value);
                        return;
                    }
                    if (keyValueArray[i].Key == null)
                    {
                        keyValueArray[i] = new KeyValue<TValue>(key, value);
                        storedValues++;
                        return;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary<object>();
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
            Console.WriteLine($"{d["Cats"]}, {d["Dogs"]}");
        }
    }
}
