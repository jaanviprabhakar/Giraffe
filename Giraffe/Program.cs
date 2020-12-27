using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek","Adam Adamson","Kawai"); //will return NR
            // G, PG, PG-13, R, NR

            Console.WriteLine(avengers.title + ": " + avengers.Rating);
            Console.WriteLine(shrek.title + ": " + shrek.Rating);
            Console.ReadLine();
        }

    }
}