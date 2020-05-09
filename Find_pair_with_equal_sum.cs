using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 7, 1, 2, 9, 8 };
            Dictionary<string, int> dict = FindPairs(arr);
            //foreach (KeyValuePair<string, int> kv in dict)
            //{
            //    Console.WriteLine(" " + kv.Key + " " + kv.Value);
            //}
        }
        public static string GetPairs(int a, int b)
        {
            return ($"({a}, {b})");
        }

        public static Dictionary<string, int> FindPairs(int[] arr)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string paring = null;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    paring = GetPairs(arr[i], arr[j]);
                    if (!dict.ContainsKey(paring))
                    {
                        dict.Add(paring, sum);
                    }
                }
            }
            var duplicatesValue = dict.GroupBy(x => x.Value).Where(x => x.Count() > 1);
            foreach (var kv in dict)
            {
                foreach(var k in duplicatesValue)
                {
                    if(kv.Value == k.Key)
                    {

                        Console.WriteLine($"{kv.Key} = {kv.Value}");
                    }
                }
                 
                
            }
            return dict;
        }
    }
}
