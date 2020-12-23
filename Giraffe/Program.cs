using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book
            {
                title = "The Sun Is Also A Star",
                author = "Nicola Yoon",
                pages = 384
            }; //book object

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.pages);
            Console.WriteLine(book1.author+"\n");

            Book book2 = new Book(); //book object
            book2.title = "The Secret";
            book2.author = "Rhonda Byrne";
            book2.pages = 198;

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.pages);
            Console.WriteLine(book2.author);

            Console.ReadLine();
        }

    }
}

