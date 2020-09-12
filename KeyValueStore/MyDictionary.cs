using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
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
}
