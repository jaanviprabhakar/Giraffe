using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Walter White",65);
            SayHi("Saul",52);
            SayHi("Jesse Pinkman",25);
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello "+name+" you are "+age+" years old.");
        }
    }
}