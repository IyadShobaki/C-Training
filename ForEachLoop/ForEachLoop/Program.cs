using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);

               

            }

            //for (int i=1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);

            //    if (i == 10)
            //        break;

            //}
            //int[] numbers = new int[3];

            //numbers[0] = 101;
            //numbers[1] = 102;
            //numbers[2] = 103;

            //foreach(int k in numbers)
            //{
            //    Console.WriteLine(k);
            //}

            //for (int j=0; j<numbers.Length; j++)
            //{
            //    Console.WriteLine(numbers[j]);
            //}

            //int i = 0;
            //while (i < numbers.Length)
            //{
            //    Console.WriteLine(numbers[i]);
            //    i++;
            //}


            Console.ReadLine();
        }
    }
}
