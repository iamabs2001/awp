using System;

namespace Sigma.Practical
{
    class Product
    {
        static void Main(string[] args)
        {
            int num1,num2,num3,num4,prod;
            Console.WriteLine("Abhijeet Sharma");
            Console.Write("Enter the Number 1 : ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the Number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Number 3 : ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Number 4 : ");
            num4 = Convert.ToInt32(Console.ReadLine());
            prod = num1 * num2 * num3 * num4;
            Console.Write("Product of four Number is " + prod);
        }
    }
}
