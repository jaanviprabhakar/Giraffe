using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 6, index2 = 1;

            Console.WriteLine("Do While Loop:");
            do
            {
                Console.WriteLine(index);
                index++;

            } while (index <= 5);

            Console.WriteLine("While Loop:");
            while(index2 <= 5)
            {
                Console.WriteLine(index2);
                index2++;
            }
             Console.ReadLine();
        }
    }
}

