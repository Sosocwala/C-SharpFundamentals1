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
        public static void quickSort(int[] sorted, int left, int right)
        {
            int r = left;
            int l = right;
            int pivot = sorted[(l + r) / 2];

            while (l <= r)
            {
                while (sorted[l] < pivot)
                {
                    l++;
                }
                while (pivot < sorted[r])
                {
                    r--;
                }
                if (l <= r)
                {
                   int temp = sorted[l];
                    sorted[l] = sorted[r];
                    sorted[r] = temp;
                    l++;
                    r--;
                }
                if (left < r)
                {
                    quickSort(sorted, left, r);
                }
                if (l < right)
                {
                    quickSort(sorted, l, right);
                }
            }
        }
    }
}
