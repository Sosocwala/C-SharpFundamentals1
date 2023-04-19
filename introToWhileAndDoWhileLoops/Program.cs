using System;

namespace introToWhileAndDoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 100)
            {
                Console.WriteLine(i);
                i++;
            }
            //Here is a do while loop
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            }
            while (k < 100);
            Console.WriteLine("Press Enter to Exit");
        }
    }
}
