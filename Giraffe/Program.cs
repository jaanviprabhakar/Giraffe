using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        { 
            Book book1 = new Book("The Sun Is Also A Star", "Nicola Yoon", 384);
            Book book2 = new Book("The Secret", "Rhonda Byrne", 198);

            //update
            book1.title = "The Hobbit";

            //print
            Console.WriteLine("Name: " + book1.title + " Author: " + book1.author + " Pages: " + book1.pages);
            Console.WriteLine("Name: "+book2.title+" Author: "+book2.author + " Pages: " + book2.pages);

            Console.ReadLine();
        }

    }
}