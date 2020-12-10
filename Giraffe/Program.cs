using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=6, a=num++, b=num--;

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Pow(3.8,2));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Max(-40,-20));
            Console.WriteLine(Math.Min(0, -29));
            Console.WriteLine(Math.Round(4.3));
            Console.WriteLine(Math.Round(4.6));

            Console.ReadLine();
        }
    }
}
