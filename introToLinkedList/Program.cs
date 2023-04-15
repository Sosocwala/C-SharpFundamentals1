using System;
using System.Collections.Generic;

namespace introToLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a Linked list 
            LinkedList<string> myLinkedList = new LinkedList<string>();
            myLinkedList.AddLast("Nomah");
            myLinkedList.AddFirst("Sobs");
            myLinkedList.AddLast("Zura");
            myLinkedList.AddFirst("Bongs");

            // Iterating through the Linked list
            foreach (string name in myLinkedList)
            {
                Console.WriteLine(name);

            }

            Console.WriteLine("--------------");
            //Searching for Nodes 
            LinkedListNode<string> myNode = myLinkedList.Find("Nomah");
            myLinkedList.AddBefore(myNode, "Migo");

            //Removing Values in the linked list
            myLinkedList.Remove("Sobs");
            myLinkedList.RemoveLast();

            



        }
    }
}
