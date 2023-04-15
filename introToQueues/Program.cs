using System;

namespace introToQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Customer = new string[3, 2] 
            { 
                { "Soso", "Megan" }, 
                {"Mlalo", "Sali" }, 
                {"jhon", "mandy" } };

            Console.WriteLine(Customer[1, 0] + " " + Customer[1, 1]);

            for (int i = 0; i < Customer.GetLength(0); i++)
            {
                int k = 0;
                Console.Write("{0} {1}", Customer[i, k], Customer[i, k + 1]);
                k++;
                Console.WriteLine();
            }



        }
    }
}
