using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;
            int a = 5, b = 3, c = 2;
            
            // && is used for AND
            if (isMale!=true && isTall==false) 
            {
                Console.WriteLine("You are a petit female.");
            }
            else
            {
                Console.WriteLine("You are male or tall or both.");
            }

            // || is used for OR 
            if (isMale == true || isTall == false)
            {
                Console.WriteLine("You are male or small or both.");
            }
            else
            {
                Console.WriteLine("You are female or tall or both.");
            }


            //else-if example
            if(a%2==0 && b%2==0 && c%2==0) //all even
            {
                Console.WriteLine("Block 1: All three numbers are even.");
            }
            else
            if(a%2==0||b%2==0)
            {
                Console.WriteLine("Block 2: One of first two numbers is even.");
            }
            else
            {
                Console.WriteLine("Block 3: One of last two numbers is even.");
            }

        }
    }
}