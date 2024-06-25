using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public void Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            T sum = x + y;
            Console.WriteLine($"Result of adding {a} and {b}: {sum}");
        }
        static void Main(string[] args)
        {
            int x = 13;
            int y = 21;
            Console.WriteLine($"Before calling Add metrhod: x={x},y={y}");
            Program obj = new Program();
            obj.Add(x,y);
            Console.WriteLine($"After calling  Add method: x={x}, y={y}");
        }
    }
}
