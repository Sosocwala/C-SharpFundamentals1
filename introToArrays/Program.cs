using System;
using System.Collections.Generic;
using System.Linq;

namespace introToArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {   //creating a Array of strings and integers and indexing the array
            int[] age = { 22, 33, 5, 15, 63, 20 };
            Console.WriteLine(age[3]);
            Console.WriteLine(age[0]);

            string[] cars = { "Volvo", "BMW", "Audi", "Ford", "Toyota", "Haval" };
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[1]);


            int[] FavNumbers = new int[5];
            FavNumbers[0] = 24;
            FavNumbers[1] = 44;
            Console.WriteLine("FavNumber 0 : {0}", FavNumbers[0]);
                  
            string[] customers = { "Soso", "Ryan", "Pual", "Sapho" };



            object[] randomArray = { "Sonwa", 56, 54, 3.77 };
            Console.WriteLine("RandomArray 2 {0}", randomArray[2].GetType());
            Console.WriteLine("Array size : {0}", randomArray.Length);
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array : {0} : Value : {1}", i, randomArray[i]);
            }

            foreach (var random in randomArray)
            {
                Console.Write("{0}", random);
            }

            Console.WriteLine("-----------------------------");

            string[,] custName = new string[3, 2] 
            { { "Roger", "Sindy" }, 
            { "Yaya", "Mandy" }, 
            {"Sali", "Will"} };

            Console.WriteLine( custName[1, 0] + "" + custName[1, 1]);

            for (int i = 0; i < custName.GetLength(0); i++)
            {
                int k = 0;
                Console.Write("{0} {1}", custName[i, k], custName[i, k + 1]);
                k++;
                ConsoleWrite();
            }

        }
    }
}