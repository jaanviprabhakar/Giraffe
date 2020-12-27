using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jaanvi","CSE",9.6);
            Student student2 = new Student("Tanvi","GD",9.3);

            Console.WriteLine(student1.name+": "+ student1.hasHonors());
            Console.WriteLine(student2.name+": "+ student2.hasHonors());

            Console.ReadLine();
        }

    }
}