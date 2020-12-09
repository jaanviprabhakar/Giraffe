using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Panda Academy" + " is cool.";
           
            Console.WriteLine("New Line: Giraffe\nAcademy");
            Console.WriteLine("Printing Quuotes: Giraffe\"Academy");
            Console.WriteLine(phrase);
            Console.WriteLine("\nTrying Methods in C#: ");
            Console.WriteLine("The length is: " + phrase.Length );
            Console.WriteLine("In Upper Case: " + phrase.ToUpper());
            Console.WriteLine("In Lower Case: " + phrase.ToLower());
            Console.WriteLine("Does the string contain Academy? " + phrase.Contains("Academy"));
            Console.WriteLine("3rd character: " + phrase[2]);
            Console.WriteLine("To check the index of Acad: " + phrase.IndexOf("Acad"));
            Console.WriteLine("To check the index of a: " + phrase.IndexOf('a'));
            Console.WriteLine("To check the index of z: " + phrase.IndexOf('z'));
            Console.WriteLine("Substring Aca: " + phrase.Substring(6,3) );

            Console.ReadLine();
        }
    }
}
