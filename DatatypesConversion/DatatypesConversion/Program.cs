using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 100;
            //float f = i;
            //Console.WriteLine(f);   implicit conversion

            //float f = 123.45F; // explicit conversion

            //int i = (int)f; // or int i = Convert.ToInt32(f);

            //Console.WriteLine(i);

            //Console.ReadLine();


            //string strNumber = "100";

            //int i = int.Parse(strNumber);
            //Console.WriteLine(i);

            string strNumber = "100TG";
            int Result = 0;

            bool IsConversionSuccessful = int.TryParse(strNumber, out Result);
            if (IsConversionSuccessful)
            {
                Console.WriteLine(Result);

            }
            else
            {
                Console.WriteLine("Please enter a valid number");

            }

            Console.ReadLine();


        }
    }
}
