using System;

namespace introToRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Even Numbers: ");
            evenNums(number);
            Console.WriteLine("Done! ");
        }
        public static void evenNums(int i)
        {
            if (i <= 1000)
            {
                Console.Write("{0} ", i);
                i += 2;
                evenNums(i);
            }
        }
    }
}
