using System;
using System.Collections.Generic;

namespace Find_whether_an_array_is_subset_of_another_array
{
    class SubsetofArray
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 11, 1, 13, 21, 3, 7 };
            int[] arr2 = { 11, 3, 7, 1 };
            if (isSubset(arr1, arr2))
                Console.Write("arr2[] is subset of arr1[] ");
            else
                Console.Write("arr2[] is not a subset of arr1[]");
        }

        public static bool isSubset(int[] arr1,int[] arr2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i =0; i < arr1.Length; i++)
            {
                int a1 = arr1[i];
                if (dict.ContainsKey(a1))
                {
                    dict[a1] = dict[a1] + 1;
                }
                else
                {
                    dict.Add(a1, 1);
                }
            }
            int flag = 0;
            for(int j = 0; j < arr2.Length; j++)
            {
                int a2 = arr2[j];
                if (!dict.ContainsKey(a2))
                {
                    flag = 1;
                    break;
                }
                else
                {
                    dict[a2] = dict[a2] - 1;
                    if (dict[a2] == 0)
                    {
                        dict.Remove(a2);
                    }
                }
            }

            return (flag == 0);
        }
    }
}
