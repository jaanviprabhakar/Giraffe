using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string color, pluralNoun, celebrity;
            //input
            Console.Write("Enter a color: ");
            color=Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a Celebrity name: ");
            celebrity = Console.ReadLine();
            Console.WriteLine("Roses are "+color);
            Console.WriteLine(pluralNoun+" are blue");
            Console.WriteLine("I Love "+celebrity);

            Console.ReadLine();
        }
    }
}
