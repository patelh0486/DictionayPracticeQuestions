
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalExamReview
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            String uname = Console.ReadLine();
            Console.WriteLine("Enter password:");
            String password = Console.ReadLine();
            if (LoginInfo.ContainsKey(uname))
            { 
                if(LoginInfo[uname]==password)
                {
                    Console.WriteLine($" {uname} is loggedin.");
                }
            else
                {
                    Console.WriteLine("the assword entered is incorrect");
                }
            }
            else
            {

                Console.WriteLine($" {uname} user not found.");
            }
            foreach(var kvp in LoginInfo)
            {
                Console.WriteLine($"{kvp.Key,10} {kvp.Value}");
            }

            string[] keys = new string[LoginInfo.Count];
            LoginInfo.Keys.CopyTo(keys, 0);
            for(int i = 0; i< keys.Length; i++)
            {
                Console.WriteLine($"{keys[i],10}");
            }
        }

        static Program()
        {
            LoginInfo["hinal"] = "patel";
            LoginInfo["michael"] = "wu";
            LoginInfo["gunjan"] = "pabreja";
        }

        private static readonly Dictionary<string, string> LoginInfo = new Dictionary<string, string>
        { 
               {"hinal", "patel"},
               {"kevin", "patel"},
               {"binjal", "patel"},

            };
    }
}
