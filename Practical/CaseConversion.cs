using System;

namespace Sigma.Practical
{
    class CaseConversion
    {
        static void Main(string[] args)
        {
            string str1 = "", str2 = "TechnoLytics",new_str;
            int n;
            Console.WriteLine("In Uppercase: "+str1.ToUpper());
            Console.WriteLine("In Lowercase: " + str1.ToLower());
            n = str1.CompareTo(str2);

            if(n==0)
            {
                Console.WriteLine("Both is equal");
            }
            else
            {
                Console.WriteLine("Both is not equal");
            }
            new_str = str1.Replace("", "");
            Console.WriteLine(new_str);
        }
        
    }
}