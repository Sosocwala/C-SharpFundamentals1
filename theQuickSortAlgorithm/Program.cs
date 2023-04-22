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
                for (int z = 0; z < x; z++)
                {
                    if (Sorted[z] == randomNums)
                    {
                        addToArray = false;
                        break;
                    }
                }
                if (addToArray == true)
                {
                    Sorted[x] = randomNums;
                    x++;
                }

            }
            Console.WriteLine(Environment.NewLine + "Unsorted List : " + Environment.NewLine);
            foreach (int i in Sorted)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Pess ENTER");
            Console.ReadLine();

            quickSort(Sorted, 0, Sorted.Length - 1);
            Console.WriteLine("Sorted List : " + Environment.NewLine);
            foreach (int m in Sorted)
            {
                Console.Write("{0} ", m);
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine);       
        }
        public static void quickSort(int[] sortedList, int left, int right)
        {
            int l = left;
            int r = right;
            int pivot = sortedList[(l + r) / 2];

            while (l <= r)
            {
                while (sortedList[l] < pivot)
                {
                    l++;
                }
                while(pivot < sortedList[r])
                {
                    r--;
                }
                if (l <= r)
                {
                    int temp = sortedList[l];
                    sortedList[l] = sortedList[r];
                    sortedList[r] = temp;
                    l++;
                    r--;
                }
                if (left < r)
                {
                    quickSort(sortedList, left, r);
                }
                if (l < right)
                {
                    quickSort(sortedList, l, right);
                }
            }
        }
    }
}
