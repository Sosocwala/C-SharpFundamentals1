using System;
using System.Collections.Generic;

namespace introToLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> customers = new List<string>();
            customers.Add("Soso");
            customers.Add("Yaya");
            customers.Add("Ryan");
            customers.Add("Mogan");
            customers.Add("Beeno");

            
            Console.WriteLine(customers[0]);
            Console.WriteLine(customers.Count);
            customers.Remove("Soso");
            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
