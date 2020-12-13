using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number corresponding to the day of the week: ");
            int day=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The day is: "+GetDay(day));

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                case 7:
                    dayName = "Sunday";
                    break;

                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
    }
}