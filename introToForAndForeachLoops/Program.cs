using System;

namespace introToForAndForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            //foreach loop
            int[] counter = { 10, 20, 30, 40, 50, 55, 60, 65, 70, 75, 80, 85, 90, 100 };
            foreach (int i in counter)
            {
                Console.WriteLine(i);
            }
        }
    }
}
