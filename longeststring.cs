using System;
using System.Collections.Generic;
using System.Linq;
/*Given a string S and a set of words D, find the longest word in D that is a subsequence of S.

Word W is a subsequence of S if some number of characters, possibly zero, can be deleted from S to form W, without reordering the remaining characters.

Note: D can appear in any format (list, hash table, prefix tree, etc.

For example, given the input of S = "abppplee" and D = {"able", "ale", "apple", "bale", "kangaroo"} the correct output would be "apple"

The words "able" and "ale" are both subsequences of S, but they are shorter than "apple".
The word "bale" is not a subsequence of S because even though S has all the right letters, they are not in the right order.
The word "kangaroo" is the longest word in D, but it isn't a subsequence of S.*/

namespace longeststring
{
    class longeststring
    {
        static void Main(string[] args)
        {
            // string[] D = { "pintu", "geeksfor", "geeksgeeks", " forgeek" };
            // string S = "geeksforgeeks";
            // string[] D = { "ale", "apple", "monkey", "plea" };
            //string S = "abpcplea";
            string[] D = { "able", "ale", "apple", "bale", "kangaroo" };
            string S = "abppplee";
            string longeststr = Longest(D, S);
            Console.WriteLine(longeststr + " is longest string.");
            
           
        }
        public static string Longest(string[] strArray, string givenstring)
        {
                        Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < strArray.Length; i++)
            {
                string current = strArray[i];
                int currentlength = strArray[i].Length;
                if (isSubSequence(strArray[i], givenstring) && !dict.ContainsKey(strArray[i]) && current!=null)
                {
                    dict.Add(strArray[i], strArray[i].Length);
                }
            }
            Console.WriteLine($"given string: {givenstring} ");
            Console.WriteLine($"Words that are subsequence of given string are:");
            foreach (KeyValuePair<string, int> kv in dict)
            {

                Console.WriteLine(kv.Key + ":" + kv.Value);
            }
            // var maxvalue = newDict.Values.Max();
            var maximumkey = MaxKey(dict);
          
            return maximumkey;
        }
           public static bool isSubSequence(string str1, string str2)
            {
                int s1 = str1.Length;
                int s2 = str2.Length;
                int s1Index = 0;
                for(int i =0; i<s2 && s1Index < s1; i++)
                {
                    if (str1[s1Index] == str2[i])
                    {
                        s1Index++;
                    }
                }
                return (s1Index == s1);
            }
        public static string MaxKey(Dictionary<string,int> dict)
        {
            KeyValuePair<string, int> max = new KeyValuePair<string, int>();
            foreach (var kvp in dict)
            {
                if (kvp.Value > max.Value)
                    max = kvp;
            }
            return max.Key;
        }
        }
    }

