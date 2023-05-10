using System;

namespace creatingClass
{
    class Program
    {
        static void Main(string[] args)
        {
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
                return kind + "The cost is " + cost;
            }
            public double getCost()
            {
                return cost * ;
            }
        }

        
    }
}
