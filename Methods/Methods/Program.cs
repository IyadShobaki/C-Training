using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // before adding static key wrod to the method
            //Program p = new Program();
            //p.evenNumbers();

            Program.evenNumbers(30);

            Program p = new Program();
            int sum = p.add(10, 20);
            Console.WriteLine("Sum = {0}", sum);


            Console.ReadLine();
        }

        public static void evenNumbers(int Target)
        {
            int start = 0;
            while (start <= Target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
        public int add(int fn, int sn)
        {
            return fn + sn;
        }
    }
}
