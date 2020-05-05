using System;
using System.Collections.Generic;
using System.Linq;
namespace AnagramOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "aabbcc";
            string str2 = "cacbac";
            Console.WriteLine($" Are  {str1} : {str2}  words Anagram ? {isAnagram(str1, str2)}");

        }

        static bool isAnagram(string first, string second)
        {
            if(first.Length != second.Length)
            {
                return false;
            }
            if(first == second)
            {
                return true;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(var ch in first.ToCharArray())
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 1);
                }
                else
                {
                    dict[ch]++;
                }
            }
            foreach(var ch in second.ToCharArray())
            {
                if (!dict.ContainsKey(ch)){
                    return false;
                }
                else if(--dict[ch]==0)
                {
                    dict.Remove(ch);
                    
                }
            }
            return dict.Count == 0;
        }
    }
}
