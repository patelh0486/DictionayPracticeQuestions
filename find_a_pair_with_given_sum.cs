using System;
using System.Collections.Generic;

namespace Find_a_pair_with_given_sum
{
    class find_a_pair_with_given_sum
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, -2, 1, 0, 5 };
             int sum = 0;
            FindPairs(arr, sum);
        }
        public static void FindPairs(int[] arr, int sum)
        {
            if (arr == null)
            {
                // return sum;
                Console.WriteLine("null array");
            }
            else
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for(int i = 0; i < arr.Length; i++)
                {
                    int temp = sum - arr[i];
                    foreach(var element in arr)
                    {
                        if(element == temp && element!=arr[i] && !dict.ContainsKey(arr[i]))
                        {
                            // dict.Add(arr[i], element);
                            Console.WriteLine($"{arr[i]}");
                        }
                        else
                        {
                            Console.WriteLine($"no valid pairs");
                        }
                    }
                }
                
            }
        }
           
        }
    }

