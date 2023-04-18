using System;

namespace introToIf_ElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            int y = 25;
            if (x < y)
            {
                Console.WriteLine("X is Less then Y");
            }
            else if (x > y)
            {
                Console.WriteLine("X is greater then Y");
            }
           
        }
    }
}
