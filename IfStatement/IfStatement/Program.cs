using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number");
            //int userNumber = int.Parse(Console.ReadLine());

            //if(userNumber == 1)
            //{
            //    Console.WriteLine("Your number is one");
            //}else if (userNumber == 2)
            //{
            //    Console.WriteLine("Your number is two");
            //}else if (userNumber == 3)
            //{
            //    Console.WriteLine("Your number is three");
            //}

            //else {
            //    Console.WriteLine("Your number is not between 1 and 3");
            //}

            //Console.WriteLine("Please enter a number");
            //int userNumber = int.Parse(Console.ReadLine());

            //-------------------------------------

            // single | will check both conditions even if the first condition is true
            // Double || will not check the second condition if the first condition is true
            // The same thing with & and &&
            //if (userNumber == 10 || userNumber == 20)
            //{
            //    Console.WriteLine("Your number is 10 or 20");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is not 10 or 20");
            //}

            //switch statements-------------------------------------

            Console.WriteLine("Please enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            switch(userNumber)
            {
                //case 10:
                //    Console.WriteLine("Your number is 10");
                //    break;
                //case 20:
                //    Console.WriteLine("Your number is 20");
                //    break;
                //case 30:
                //    Console.WriteLine("Your number is 30");
                //    break;
                //default:
                //    Console.WriteLine("Your number is not 10, 20 or 30");
                //    break;
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", userNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 or 30");
                    break;

            }
            Console.ReadLine();
        }
    }
}
