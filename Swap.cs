using System;

namespace HelloWorld
{
    class Swap
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int i=int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int j=int.Parse(Console.ReadLine());
            Console.Write($"Before Swapping: i={i} and j={j}\n");
            Console.Write("After Swapping: ");
            int k=i;
            i=j;
            j=k;
            Console.Write($"i= {i} and j= {j}");
        }
    }
}
