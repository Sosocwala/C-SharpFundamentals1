using System;
using System.Collections.Generic;
using System.Linq;

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
            customers.Insert(3, "Bravo");
            customers.IndexOf("Mogan");
            customers.Contains("Beeno");
            if (customers.Contains("Beeno"))
            {
                Console.WriteLine("Found");
            }

            if (customers.IndexOf("Mogan") == 2)
            {
                Console.WriteLine("true");
            }

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            //comparing values of two links
            List<int> numbers1 =  new List<int>() {10, 23, 53, 53, 13, 45, 64, 75, 72, 65, 643};
            List<int> numbers2 = new List<int>() { 10, 23, 53, 53, 13, 45, 64, 75, 72, 65, 643 };
            if (numbers1.SequenceEqual(numbers2))
            {
                Console.WriteLine("It is Equal");
            }

            //iterating through a list
            for (int i = 0; i < numbers1.Count; i++)
            {
                //numbers1[i] *= 2;
                Console.WriteLine(numbers1[i]);
            }

            foreach (int number in numbers1)
            {
                Console.WriteLine(number);
            }
                
        }

    }
}
