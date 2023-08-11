using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        class Fruit
        {
            public double Amount { get; protected set; }
            public double Cost { get; protected set; }
            public virtual void getCost()
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
                return 1
            }
            else
            {
                return -1;
            }
        }
    }
}
