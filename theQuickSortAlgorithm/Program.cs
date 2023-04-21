using System;

namespace theQuickSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Sorted = new int[100];
            byte x = 0;
            Random random = new Random();
            bool addToArray = true;

            while (x < 100)
            {
                int randomNums = random.Next(1, 101);
                addToArray = true;

                for (int y = 0; y < x; y++)
                {
                    if (Sorted[y] == randomNums)
                    {
                        addToArray = false;
                        break;
                    }
                }
            }
        }
    }
}
