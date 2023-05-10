using System;

namespace accessingObjectsWithThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit myFruit = new Fruit("Apple", .6);
            string newFruit = myFruit.getFruit();
            double totalCost = myFruit.getCost();
            Console.WriteLine(newFruit);
            Console.WriteLine(totalCost);
        }
        class Fruit
        {
            private string kind;
            private double cost;
            public Fruit(string k, double c)
            {
                this.kind = k;
                this.cost = c;
            }
            public string getFruit()
            {
                return this.kind;
            }
            public double getCost()
            {
                return this.cost * 12;
            }
        }
    }
}
