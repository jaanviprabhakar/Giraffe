using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday","Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmmir = new Song("Kashmir","Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            //static attributes are called with class name and not object name.

            Console.WriteLine(holiday.title);
            Console.WriteLine(kashmmir.title);

            Console.ReadLine();
        }

    }
}