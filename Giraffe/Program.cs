using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            for( int i=0; i<3;i++)
            {
                for( int j=0; j<2; j++)
                {
                    Console.WriteLine("Element at row "+i+" column "+j+" : "+numberGrid[i,j]);
                }
                
            }

            string[,] animals = new string[2, 3];
            Console.WriteLine("\nEnter 2 groups of 3 animal names.\n");
            for( int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write("Enter animal name: ");
                    animals[i,j]=Console.ReadLine();
                }
            }

            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(animals[i,j]+ " ");
                   
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}

