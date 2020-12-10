using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert->TypeCast
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number:\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Remainder");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:Console.WriteLine("The sum is:"+num1 + num2);
                    break;
                case 2: Console.WriteLine("The difference is:" + (num1-num2));
                    break;
                case 3:Console.WriteLine("The product is:" + num1*num2);
                    break;
                case 4:Console.WriteLine("The quotient is:" + num1/num2);
                    break;
                case 5: Console.WriteLine("The remainder is:" + num1%num2);
                    break;
                default: Console.WriteLine("Invalid Input.");
                    break;
            }


            Console.ReadLine();
        }
    }
}
