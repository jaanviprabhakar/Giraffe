using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine() prints then moves to new line
            //Console.Write() prints and stays on the same line
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello "+name+ ", you are "+age+" years old.");
            Console.ReadLine();
        }
    }
}
