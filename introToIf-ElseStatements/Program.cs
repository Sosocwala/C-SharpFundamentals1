using System;

namespace introToIf_ElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 26;
            int y = 25;
            if (x < y)
            {
                Console.WriteLine("X is Less then Y");
            }
            else if (x > y)
            {
                Console.WriteLine("X is greater then Y");
            }
            else
            {
                Console.WriteLine("X is equal to Y");
            }
            Console.WriteLine("Press Enter to Exit");


            //calling function as a condition

            int a = 10;
            int b = 12;
            if (isGreater(a, b))
            {
                Console.WriteLine("X is Less then Y");
            }
            else if (isGreater(a, b))
            {
                Console.WriteLine("X is Greater then Y");
            }
            else
            {
                Console.WriteLine("X is equal to Y");
            }
        }
        static bool isGreater(int a, int b)
        {
            return a < b;  
        
        }

    }
}

