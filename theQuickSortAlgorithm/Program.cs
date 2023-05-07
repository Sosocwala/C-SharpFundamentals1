using System;

namespace theQuickSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomList = new int[100];
            byte x = 0;
            Random random = new Random();
            bool addToArray = true;

            while (x < 100)
            {
                int randomNums = random.Next(1, 101);
                addToArray = true;
                for (int z = 0; z < x; z++)
                {
                    if (randomList[z] == randomNums)
                    {
                        addToArray = false;
                            break;
                    }
                }
                if (addToArray == true)
                {
                    randomList[x] = randomNums;
                    x++;
                }
            }
            Console.WriteLine(Environment.NewLine + "UnSorted List : " + Environment.NewLine);
            foreach (int i in randomList)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Press ENTER");
            Console.ReadLine();

            quickSort(randomList, 0, randomList.Length - 1);
            Console.WriteLine("Sorted List: " + Environment.NewLine + Environment.NewLine);
            foreach (int k in randomList)
            {
                Console.Write("{0} ", k);
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine);

        }
        public static void quickSort(int[] sortedList, int left, int right)
        {
            int l = left;
            int r = right;
            int pivot = sortedList[(l + r) / 2];

            while (l <= r) //loop l until is equal to r
            {
                while (sortedList[l] < pivot) //move the l up one 
                {
                    l++;
                }
                while (pivot < sortedList[r]) //move the r down one
                {
                    r--;
                }
                if (l <= r) //swaping numbers
                {
                    int temp = sortedList[l];
                    sortedList[l] = sortedList[r];
                    sortedList[r] = temp;
                    l++;
                    r--;
                }
                if (left < r)
                {
                    quickSort(sortedList, left, r); // call quicksort, Recursion
                }
                if (l < right)
                {
                    quickSort(sortedList, lright), ;
                }
            }
        }
    }
}
