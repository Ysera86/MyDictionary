using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary dict = new MyDictionary();
            dict.Add(1, "Merve");
            dict.Add(2, "Taylan");

            for (int i = 0; i < dict.Keys.Length; i++)
            {
                Console.WriteLine("Key : {0} - Value : {1}", dict.Keys[i].ToString(), dict.Values[i].ToString());
            }
        }
    }
    public class MyDictionary
    {
        public int[] Keys { get; set; }
        public object[] Values { get; set; }

        public MyDictionary()
        {
            Keys = new int[0];
            Values = new object[0];
        }
        public void Add(int key, object value)
        {
            int count = Keys.Length + 1;
            int[] keyTemp = new int[count];
            object[] valueTemp = new object[count];

            Keys.CopyTo(keyTemp, 0);
            Values.CopyTo(valueTemp, 0);

            keyTemp[count - 1] = key;
            valueTemp[count - 1] = value;

            Keys = keyTemp;
            Values = valueTemp;
        }

    }
}
