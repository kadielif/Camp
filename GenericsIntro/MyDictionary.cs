using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<T,Y>
    {
        T[] key;
        Y[] value;
        public MyDictionary()
        {
            key = new T[0];
            value = new Y[0];
        }
        public void Add(T item1,Y item2)
        {
            T[] temp = key;
            Y[] temp2 = value;
            key = new T[key.Length + 1];
            value = new Y[value.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                key[i] = temp[i];
                value[i] = temp2[i];
            }
            key[key.Length - 1] = item1;
            value[value.Length - 1] = item2;
            Console.WriteLine(key.Length);

        }
    }


   
}
