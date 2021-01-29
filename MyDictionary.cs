using System;
using System.Collections.Generic;
using System.Text;

namespace GenericOdev
{
    class MyDictionary<T1, T2>
    {
        T1[] key;
        T2[] value;
        T1[] TempKey;
        T2[] Tempvalue;

        public MyDictionary()
        {
            key = new T1[0];
            value = new T2[0];
        }

        public void Add(T1 keys, T2 values)
        {
            TempKey = key;
            Tempvalue = value;

            key = new T1[key.Length + 1];
            value = new T2[value.Length + 1];

            for (int i = 0; i < TempKey.Length; i++)
            {
                    key[i] = TempKey[i];
                    value[i] = Tempvalue[i];
            }

            key[key.Length - 1] = keys;
            value[value.Length - 1] = values;
        }

        public void Show()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine($"{key[i]}: {value[i]}");
            }
        }

    }
}
