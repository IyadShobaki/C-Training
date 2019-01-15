using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Name = null;
            // give an integer/ boolean/... null value by add ? beside int

            //int? i = null;

            //bool? AreYouMajor = null;

            //if (AreYouMajor == true)
            //{
            //    Console.WriteLine("User is Major");
            //}
            //else if (AreYouMajor == false)
            //{
            //    Console.WriteLine("User is Not major");
            //}
            //else
            //{
            //    Console.WriteLine("User is did not answer the question");
            //}

            int? TicketsOnSale = null;
            //int AvailableTickets;
            //if (TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = (int)TicketsOnSale; // this or the next line
            //    //AvailableTickets = TicketsOnSale.Value;
            //}  easier way to do it as following

            int AvailableTickets = TicketsOnSale ?? 0;

            Console.WriteLine("Available tickets = {0}", AvailableTickets);
            Console.ReadLine();
        }
    }
}
