﻿using System;

namespace captureUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine(); //read string from console
            Console.WriteLine("You entered {0}", input);
            int num;
            if (int.TryParse(input, out num))
            {
                Console.WriteLine("multyply by a 1000");
                Console.WriteLine(num * 1000);
            }

        }
    }
}