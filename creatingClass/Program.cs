using System;

namespace creatingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit("Banana", .23, 12);
            string newFruit = fruit.getFruit();
            double total = fruit.getCost();
            Console.WriteLine("kind of fruit : {0} ",);
            Console.WriteLine(total);
        }
        class Fruit
        {
            private string kind;
            private double cost;
            private double amount;

            public Fruit(string k, double c, double a)
            {
                kind = k;
                cost = c;
                amount = a;
            }
            public string getFruit()
            {
                return kind + " The cost: " + cost;
            }
            public double getCost()
            {
                return cost * amount;
            }
        }
        
    }
}
