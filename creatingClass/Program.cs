using System;

namespace creatingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit myFruit = new Fruit("Banana", .6, 12);
            string newFruit = myFruit.getFruit();
            double totalCost = myFruit.getCost();
            Console.WriteLine("The kind of fruit:{0} ", newFruit);
            Console.WriteLine("The Cost of a doxen is: {0:C} ", totalCost);

          
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
                return kind + " The cost for each is : " + cost;
            }
            public double getCost()
            {
                return cost * amount;
            }
        }

        
    }
}
