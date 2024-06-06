using System;

namespace Days
{
    class day
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number(less than 8): ");
            int i= int.Parse(Console.ReadLine());
            switch(i)
            {
                case 1: Console.Write("It is a Monday.");
                break;
                case 2: Console.Write("It is a Tuesday.");
                break;
                case 3: Console.Write("It is a Wednesday.");
                break;
                case 4: Console.Write("It is a Thrusday.");
                break;
                case 5: Console.Write("It is a Friday.");
                break;
                case 6: Console.Write("It is a Saturday.");
                break;
                case 7: Console.Write("It is a Sunday.");
                break;
                default: Console.Write("Invalid Input...");
                break;
            }
            
        }
    }
}
