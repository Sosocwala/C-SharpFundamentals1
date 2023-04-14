using System;
using System.Collections.Generic;
using System.Linq;

namespace introToLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a list and andding customers to it
            List<string> customers = new List<string>();
            customers.Add("Soso");
            customers.Add("Yaya");
            customers.Add("Ryan");
            customers.Add("Mogan");
            customers.Add("Sindy");
            customers.Add("Beeno");



            Console.WriteLine(customers[0]);
            Console.WriteLine(customers.Count);

            customers.Remove("Beeno");
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
            List<int> numbers1 = new List<int>() { 10, 23, 53, 53, 13, 45, 64, 75, 72, 65, 643 };
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


            Console.WriteLine("-----------------");

            //multidimensional List 
            List<List<int>> studentGrades = new List<List<int>>()
            {
                new List<int>{ 5, 4, 543, 3453 },
                new List<int> { 1, 3, 644, 735},
                new List<int> { 522, 656, 643, 889 } };

           int[] standard = studentGrades[3].ToArray(); //conerting a list to an Array

            foreach (List<int> grades in studentGrades)
            {
                foreach (int grade in grades)
                {
                    Console.Write(grade + "\t");
                }
                Console.WriteLine();
            }

            //Converting an Array to a List 
            int[][] busTickets = 
                {
                new int[]{ 5, 4, 543, 3453 }, 
                new int[]{ 1, 3, 644, 735}, 
                new int[]{ 522, 656, 643, 889 } };

            List<int> ticketNumber = busTickets[2].ToList();// here is the concersion
        }
               
    }

}



