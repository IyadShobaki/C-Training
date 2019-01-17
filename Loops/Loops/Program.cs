using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //// while loop
            //Console.WriteLine("Please enter your target?");
            //int userTarget = int.Parse(Console.ReadLine());
            //int start = 0;


            //while (start <= userTarget)
            //{
            //    Console.Write(start + " ");
            //    start += 2;
            //}

            // Do while loop

            //string userChoice = ""; or
            string userChoice = string.Empty;
            do
            {
                
                Console.WriteLine("Please enter your target?");
                int userTarget = int.Parse(Console.ReadLine());
                int start = 0;
                while (start <= userTarget)
                {
                    Console.Write(start + " ");
                    start += 2;
                }

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Do you want to continue - Yes or No?");
                    userChoice = Console.ReadLine().ToUpper();
                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, Please say Yes or No");
                    }
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");
            Console.ReadLine();
        }
       

    }
}
