﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    public struct KeyValue<TValue>
    {
        public readonly string Key;

        public TValue Value { get; }
        public KeyValue(string key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}