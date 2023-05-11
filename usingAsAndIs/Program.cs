using System;

namespace usingAsAndIs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Object apple = new Orange("Navel", 3.5);
            Orange navel = (Orange)apple;*/

            object apple = new Apple("Apple", 3.3);
            if (apple is Apple)
            {
                //Apple navel = (Apple)apple;
                Apple navel = apple as Apple;
                Console.WriteLine("Fruit: {0}, cost per dozen: {1}{2}", navel.Kind, navel.getCost(), Environment.NewLine);
            }
            else
            {
                Console.WriteLine("This is not an Apple!");
            }
        }
        abstract class Fruit
        {
            public string Kind { get; protected set; }
            public double Cost { get; protected set; }
            abstract public double getCost();
        }
        class Apple : Fruit
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
        class Orange : Fruit
        {
            public Orange(string k, double c)
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
