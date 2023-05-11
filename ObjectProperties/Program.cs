using System;

namespace ObjectProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit myFruit = new Fruit();
            myFruit.Kind = "Banana";
            myFruit.Cost = 0.5;
            string newFruit = myFruit.getFruit();
            double totalCost = myFruit.getCost(); 
            Console.WriteLine("The fruit kind is: {0}", newFruit);
            Console.WriteLine("Here is a price for a Dozen: {0:C}", totalCost);

        }
        class Fruit
        {
            private string kind;
            private double cost;
            public string Kind
            {
                get { return kind;  }
                set
                {
                    if (value == "Banana")
                    {
                        kind = "Apple";
                    }
                }
            }
            public double Cost
            {
                get { return cost; }
                set
                {
                    if (cost < 2.6)
                    {
                        cost = 2.6;
                    }
                }
            }
            public string getFruit()
            {
                return kind;
            }
            public double getCost()
            {
                return cost * 12;
            }
        }
    }
}
