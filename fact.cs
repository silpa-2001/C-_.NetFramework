using System;

namespace Fact
{
    class factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n= int.Parse(Console.ReadLine());
            int i,fact=1;
            for(i=1;i<=n;i++)
            {
                fact=fact*i;
            }
            Console.Write($"The factorial of {n} is {fact}");
        }
    }
}
