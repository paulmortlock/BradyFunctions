using System;
using System.Collections.Generic;

namespace BradyFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nProduce the factorial of a given number using Recursion :");
            Console.WriteLine("-------------------------------------------------------");

            Console.Write("Enter a positive number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"\nThe factorial of {number} is : {factorial} ");
            Console.ReadKey();

            Console.WriteLine("\nEncodeToSingleString :");
            Console.WriteLine("-------------------------------------------------------");

            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("Id", "123"));
            list.Add(new KeyValuePair<string, string>("Name", "bob"));
            list.Add(new KeyValuePair<string, string>("Salary", "30000"));
            string s1 = EncodeToSingleString(list);
            Console.WriteLine(s1);
            Console.ReadKey();

            string s2 = "id=123#name=bob#salary=30000";
            Console.WriteLine($"\nDecodeFromSingleString : {s2}");
            Console.WriteLine("-------------------------------------------------------");
            
            List<KeyValuePair<string, string>> a = DecodeFromSingleString(s2);
            foreach(KeyValuePair<string, string> kvp in a)
            {
                Console.WriteLine(kvp.Key + "=" + kvp.Value);  
            }
            Console.ReadKey();

        }

        private static long CalculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * CalculateFactorial(number - 1);
        }

        private static string EncodeToSingleString(List<KeyValuePair<string, string>> kvp)
        {
            string s = "";
            foreach(KeyValuePair<string, string> pair in kvp)
            {
                string key = pair.Key;
                string value = pair.Value;
                s = s + key + "=" + value + "#";

            }
            return s[0..^1];
        }

        private static List<KeyValuePair<string, string>> DecodeFromSingleString(string s)
        {
            List<KeyValuePair<string, string>> a = new List<KeyValuePair<string, string>>();
            string[] splittedArray = s.Split('#');
            for (int i = 0; i < splittedArray.Length; i++)
            {
                string e = splittedArray[i];
                string[] z = e.Split('=');
                string key = z[0];
                string value = z[1];
                a.Add(new KeyValuePair<string, string>(key, value));
            }
            return a;
        }
    }
}
