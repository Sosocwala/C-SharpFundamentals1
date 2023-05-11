
using System;

namespace inheritanceInObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit("Banana", 3);
            Console.WriteLine("Fruit: {0}, cost per dozen: {1:C}", fruit.Kind, fruit.getCost());
        }
        class Apple
        {
            public string Kind { get; protected set; }
            public decimal Cost { get; protected set; }
        }
        class Fruit : Apple
        {
            public Fruit(string k, decimal c)
            {
                Kind = k;
                Cost = c;
            }
            public string getFruit()
            {
                return Kind;
            }
            public decimal getCost()
            {
                return Cost * 12;
            }
        }
    }
}
