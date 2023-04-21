using System;

namespace randomListOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNums = new int[100];
            byte k = 0;
            Random random = new Random();
            bool addArray = true;

            while (k < 100)
            {
                int randomNumbers = random.Next(1, 101);
                addArray = true;
                for (int l = 0; l < k; l++)
                {
                    if (randomNums[l] == randomNumbers)
                    {
                        addArray = false;
                        break;
                    }
                }
                if (addArray == true)
                {
                    randomNums[k] = randomNumbers;
                    k++;
                }     
            }
            Console.WriteLine(Environment.NewLine + "Length : " + randomNums.Length + Environment.NewLine);
            foreach (int i in randomNums)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine);


        }
    }
}
