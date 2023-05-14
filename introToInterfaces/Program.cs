using System;

namespace introToInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple grannySmith = new Apple { Amount = 12, Cost = 2.7 };
            Apple novel = new Apple { Amount = 12, Cost = 2.6 };
            int difference = grannySmith.CompareTo(novel); ;
            string results = "";
            if (difference == 0)
            {
                results = "the same price as";
            }
            else if (difference == 1)
            {
                results = "more expensive than the";
            }
            else
            {
                results = "less expensive than the";
            }
            Console.WriteLine("The Granny Smith is {0} Novel",);
        }
        class Fruit
        {
            public double Amount { get; protected set; }
            public double Cost { get; protected set; }
            public void getCost()
            {
                Console.WriteLine("Getting the Cost of Fruit...");
            }
        }
        class Apple : Fruit, IComparable
        {
            public double Amount { get; set; }
            public double Cost { get; set; }
            public double getCost()
            {
                return Amount * Cost;
            }
            public int CompareTo(object fruit)
            {
                Apple toCompare = (Apple)fruit;
                double Compare = this.getCost() - toCompare.getCost();
                if (Compare == 0)
                {
                    return 0;
                }
                else if (Compare > 0)
                {
                    return 1;
                }
                else
                {
                    return - 1;
                }
            }

        }
    }
}
