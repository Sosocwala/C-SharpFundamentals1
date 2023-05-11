using System;

namespace castingBetweenTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Object apple = new Apple("Granny Simth", 3);
            Apple granny = (Apple)apple;
            Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", granny.Kind, granny.getCost(), Environment.NewLine);
        }
        abstract class Fruit // base class - top of hierarchy
        {
            public string Kind { get; protected set; }
            public double Cost { get; protected set; }
            abstract public double getCost();
            
        }
        class Apple : Fruit //derived class - apple is also a fruit
        {
            public Apple(string k, double c)
            {
                Kind = k;
                Cost = c;
            }
            public string getFruit()
            {
                return Kind;
            }
            public override double getCost()
            {
                return Cost * 12;
            }

        }
    }
}
