using System;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int maxHR;


            while (true)
            {
                Console.Write("What is your age? ");

                string s = Console.ReadLine();
                

                if(int.TryParse(s, out number))
                {
                    maxHR = 220 - number;
                    break;
                }

                else
                {
                    Console.WriteLine("That is not a valid entry, please try again");
                }
            }

            Console.WriteLine("Your maximum heart rate should be {0} beats per minute", maxHR);

            double lowerHRZone = maxHR * .5;
            double upperHRZone = maxHR * .85;
            int lower = Convert.ToInt32(lowerHRZone);
            int upper = Convert.ToInt32(upperHRZone);


            Console.WriteLine("Your target HR Zone is {0} - {1} beats per minute", lower, upper);

        }

        

    }
}
