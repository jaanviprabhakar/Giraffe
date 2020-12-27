using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));
            //no need to create instance of math class
            UsefulTools.SayHi("Jaanvi");

            Console.ReadLine();
        }

    }
}