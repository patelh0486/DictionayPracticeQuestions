using System;
using System.Collections.Generic;

namespace Count_distinct_elements_in_every_window_of_size_k
{
    class count_distinct_elements_in_every_window_of_size_k
    {
        static void Main(string[] args)
        {
             int[] arr = { 1, 2, 1, 3, 4, 2, 3 };
            int k = 4;
            //int[] arr = { 1, 2, 4, 4 };
            //int k = 2;
            countDistinct(arr, k);
        }

        public static void countDistinct(int[] arr, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int dis_count = 0;
            for(int i=0; i < k; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    
                    dict.Add(arr[i], 1);
                    dis_count++;
                }
                else
                {
                    dict[arr[i]] += 1;
                    //int count = dict[arr[i]];
                    //dict.Remove(arr[i]);
                    //dict.Add(arr[i], count + 1);
                }
            }
            foreach(var kv in dict)
            {
                Console.WriteLine($"{kv.Key} : {kv.Value}");
            }
            Console.WriteLine(" dictint values in 1st window are: " + dis_count);

            for (int i = k; i < arr.Length; i++)
            {
                if(dict[arr[i-k]] == 1)
                {
                    dict.Remove(arr[i - k]);
                    dis_count--;
                }
                else
                {
                    dict[arr[i-k]] -= 1;
                    //int count = dict[arr[i - k]];
                    //dict.Remove(arr[i - k]);
                    //dict.Add(arr[i - k], count - 1);
                }
                if (!dict.ContainsKey(arr[i]))
                {

                    dict.Add(arr[i], 1);
                    dis_count++;
                }
                else
                {
                    dict[arr[i]] += 1;
                    //int count = dict[arr[i]];
                    //dict.Remove(arr[i]);
                    //dict.Add(arr[i], count + 1);
                }
                foreach (var kv in dict)
                {
                    Console.WriteLine($"{kv.Key} : {kv.Value}");
                }
                Console.WriteLine(" dictint values in this window " + dis_count);
            }
            
            
        }

    }
} 
