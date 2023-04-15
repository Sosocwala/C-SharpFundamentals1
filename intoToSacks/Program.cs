using System;
using System.Collections.Generic;
using System.Linq;

namespace intoToSacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a Stack and pushing values inside it and here it a LIFO
            Stack<int> myStack = new Stack<int>();
            myStack.Push(10);
            myStack.Push(30);
            myStack.Push(50);
            myStack.Push(70);
            myStack.Push(90);

            //Cycling through the stack
            foreach (int i in myStack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------");
            //Coping the stack in a Array
            int[] myArray = new int[myStack.Count];
            myStack.CopyTo(myArray, 0); //copy the stack to in a Array
            foreach (int Array in myArray)
            {
                Console.WriteLine(Array);
            }

            Console.WriteLine("------------");
            // Operations that can be used in  Stacks
            Console.WriteLine("The number of are {0}", 
                myStack.Count());

            Console.WriteLine("Is 90 in the Stack : {0}",
                myStack.Contains(90));

            Console.WriteLine("Remove : {0}", 
                myStack.Pop());// when deleting and item and LIFO 
            myStack.Clear();





        }
    }
}
