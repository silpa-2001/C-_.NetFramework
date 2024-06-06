using System;

namespace ArithematicOperators
{
    class operators
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a= int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int b= int.Parse(Console.ReadLine());
            double add= a+b;
            Console.Write($"{a}+{b}={add}\n");
            double sub=a-b;
            Console.Write($"{a}-{b}={sub}\n");
            double mul=a*b;
            Console.Write($"{a}*{b}={mul}\n");
            if(b==0)
            {
                Console.Write("Division by zero is not defined!\n");
            }
            else
            {
                double div=a/b;
                Console.Write($"{a}/{b}={div}\n");
            }
        }
    }
}
