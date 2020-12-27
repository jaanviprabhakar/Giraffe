using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday","Green Day", 200);
            Console.WriteLine(holiday.getSongCount());
            Song kashmir = new Song("Kashmir","Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());
            //static attributes are called with object name.

            Console.WriteLine(holiday.title);
            Console.WriteLine(kashmir.title);

            Console.ReadLine();
        }

    }
}