using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        public class Apple
        {
          public double  Calc(double amount, double price)
            {
                return amount * price;
            }
             
        }

        static void Main(string[] args)
        {
            Apple cost = new Apple();
            double total = cost.Calc(12, 5);
            Console.WriteLine("The amount of 12 Apples : {0:C}", total);
            Console.WriteLine("Press Enter to Exit");

        }

    }
}
