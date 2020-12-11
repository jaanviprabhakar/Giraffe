using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cube is: "+Cube(n1));
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cube is: " + Factorial(n2));

            Console.ReadLine();
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        //extra-recursive function example
        static int Factorial(int num2)
        {
            int f=1;
            while(num2!=0)
            {
                f *= num2;
                num2--;
                Factorial(num2);

            }
            return f;
        }
    }
}