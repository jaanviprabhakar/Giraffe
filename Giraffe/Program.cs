using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring arrays
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Ken";
            friends[1] = "Barbie";
            for (int i = 2; i < 5; i++)
            {
                friends[i] = "Kendall";
            }
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Friend "+i+" = "+friends[i]);
            }
            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine( luckyNumbers[2] );
            
            Console.ReadLine();
        }
    }
}