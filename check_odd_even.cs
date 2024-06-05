using Sytem;
namespace Check
{
    class Function
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number: ");
            i=int.Parse(Console.ReadLine());
            if(i%2==0)
            {
                Console.Write("It is an Even Number!");
                Console.ReadKey();
            }
            else
            {
                Console.Write("It is an Odd Number!");
                Console.ReadKey();
            }
        }
    }
}