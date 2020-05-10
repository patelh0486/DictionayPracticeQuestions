using System;
using System.Collections.Generic;

namespace Find_the_largest_subarray_with_0_sum
{
    class find_the_largest_subarray_with_0_sum
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, -2, 2, -8, 1, 7, 10, 23 };
            // int[] arr = { 0, 2, 3 };
           // int[] arr = { 1, 2, 3 };
            int maxlength = maxLengthSubarraySumToZero(arr);
            Console.WriteLine($" largest subarray length with 0 sum is: " + maxlength);
        }
        public static int maxLengthSubarraySumToZero(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int sum = 0;
            int maxlen = 0;
            for(int i = 0; i< arr.Length; i++)
            {
                sum = sum + arr[i];
                if(sum == 0)
                {
                    if(maxlen < i+1)
                        maxlen = i+1;
                }
                else if(dict.ContainsKey(sum))
                {
                    if (maxlen < i + dict[sum])
                    {
                        maxlen = i + dict[sum];
                    }
                }
                else
                {
                    dict.Add(sum, i);
                }
            }
            return maxlen;
        }
    }
}
