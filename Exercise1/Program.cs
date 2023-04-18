using System;
using System.Collections.Generic;  

namespace Exercise1
{
    class Program
    {
        public class Apple
        {
          public double Calc(double amount, double price)
            {
                return amount * price; 
            }
             
            public double Calc(double amount)
            {
                double price = 4.5;
                return amount * price;
            }
        }

        static void Main(string[] args)
        {
            Apple cost = new Apple();
            double total = cost.Calc(12, 6);
            Console.WriteLine("The price of 12 apples will be : {0:C}", total);
            Console.WriteLine("Press Enter to Exit");
        }

    }
}
