﻿using System;

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


            //calling function as a condition

            int a = 10;
            int b = 12;
            if (isGreater(a, b))
            {
                Console.WriteLine();
            }
            else if (isGreater(a, b))
            {
                Console.WriteLine("X is Greater then Y");
            }
            else
            {
                Console.WriteLine("X is equal to Y");
            }

            //Nested if else statements
            int i = 10;
            int j = 20;
            if (i != j)
            {
                if (i < j)
                {
                    Console.WriteLine("X is Less then Y");
                }
                else if (i > j)
                {
                    Console.WriteLine("X is greater then Y");
                }
            }
            else
            {
                Console.WriteLine("X is equal to Y");
            }

            //Conditional Operators
            int n = 40;
            int m = 32;
           /* if (n > m && n == m)
            {
                Console.WriteLine("n is greater and m ");

            }*/

            if (n != m || n == m)
            {
                Console.WriteLine("N is greater mthen M or equal to ");
            }

            
            Console.WriteLine("Press Enter to Exit");


        }
        //Functiong to be used as a condition
        static bool isGreater(int a, int b)
        {
            return a < b;  
        
        }

    }
}

