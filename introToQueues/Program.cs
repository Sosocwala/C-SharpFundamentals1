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

            //Coping a queue int an Array
            int[] myArray = new int[myQueue.Count];
            myQueue.CopyTo(myArray, 0); //copy queue to array
            foreach (int k in myArray)
            {
                Console.WriteLine(k);
            }
        }
    }
}