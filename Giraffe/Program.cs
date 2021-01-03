using System;

namespace Giraffe
{
    class Program
    {

        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();

            chef.MakeSpecialDish();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }

    }
}