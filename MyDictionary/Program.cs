using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dict = new MyDictionary<int,string>();
            dict.Add(1, "Merve");
            dict.Add(2, "Taylan");

            for (int i = 0; i < dict.Keys.Length; i++)
            {
                Console.WriteLine("Key : {0} - Value : {1}", dict.Keys[i].ToString(), dict.Values[i].ToString());
            }
        }
    }
    public class MyDictionary<KeyType,ValueType>
    {
        public KeyType[] Keys { get; set; }
        public ValueType[] Values { get; set; }

        public MyDictionary()
        {
            Keys = new KeyType[0];
            Values = new ValueType[0];
        }
        public void Add(KeyType key, ValueType value)
        {
            int count = Keys.Length + 1;
            KeyType[] keyTemp = new KeyType[count];
            ValueType[] valueTemp = new ValueType[count];

            Keys.CopyTo(keyTemp, 0);
            Values.CopyTo(valueTemp, 0);

            keyTemp[count - 1] = key;
            valueTemp[count - 1] = value;

            Keys = keyTemp;
            Values = valueTemp;
        }

    }
}
