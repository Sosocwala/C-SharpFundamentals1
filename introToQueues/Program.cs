using System;
using System.Collections.Generic;

namespace introToQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a Queue and manipulating it
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(50);
            myQueue.Enqueue(30);
            myQueue.Enqueue(222);
            myQueue.Enqueue(40);
            myQueue.Enqueue(99);

            //Cheking the values in the Queue
            foreach (int i in myQueue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------");
            //Coping a queue int an Array
            int[] myArray = new int[myQueue.Count];
            myQueue.CopyTo(myArray, 0); //copy queue to array
            foreach (int k in myArray)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("---------");
            //deletinmg an item in the queue and its FIFO
            myQueue.Dequeue();
            Console.WriteLine("Remove : {0}", 
                myQueue.Dequeue());//another way of deleting
            Console.WriteLine("40 in the Queue : {0}", 
                myQueue.Contains(40)); //checking if a value is present in a queue
            Console.WriteLine("peek 1 : {0}", myQueue.Peek());


            foreach (int i in myQueue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------");
            //Seaching for a value in a queue
            if (myQueue.Contains(99))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            myQueue.Clear(); // Removing everything in the queue
        }
    }
}