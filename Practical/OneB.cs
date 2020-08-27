using System;

namespace Sigma.Practical
{
    class OneB
    {
        static void Main(string[] args)
        {
            string str1 = "", str2 = "DalmiaLionsCollege", new_str = "";
            int n = 0;
            Console.WriteLine("Abhijeet Sharma");
            Console.WriteLine("In Uppercase: "+str2.ToUpper());
            Console.WriteLine("In Lowercase: " + str2.ToLower());
            n = str1.CompareTo(str2);

            if(n==0)
            {
                Console.WriteLine("Both is equal");
            }
            else
            {
                Console.WriteLine("Both is not equal");
            }
            new_str = str2.Replace(" ", "");
            Console.WriteLine(new_str);
        }
        
    }
}