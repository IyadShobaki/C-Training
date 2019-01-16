using System;

namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCoffeeCost = 0;
            Start:
            Console.WriteLine("Please select your coffe size: \n1 - Small \n2 - Medium \n3 - Large");
            int userChoice = int.Parse(Console.ReadLine());
            //Label
            
            switch (userChoice)
            {
                case 1:
                    totalCoffeeCost += 1;
                    break;
                case 2:
                    totalCoffeeCost += 2;
                    break;

                case 3:
                    totalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", userChoice);
                    goto Start;


            }
            //Label
            Decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No?");
            string userDecision = Console.ReadLine();
            switch(userDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Please try again..", userDecision);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill amount = {0}", totalCoffeeCost);

            Console.ReadLine();
        }
    }
}
