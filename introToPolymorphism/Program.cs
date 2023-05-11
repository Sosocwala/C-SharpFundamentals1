using System;

namespace introToPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit f1 = new Fruit();
            f1.getCost();
            Fruit f2 = new Apple(3.5);
            f2.getCost();
            Fruit f3 = new Orange(2.5);
            f3.getCost();
            Fruit f4 = new Banana(3);
            f4.getCost();

        }
        class Fruit //base class
        {
            public double Cost { get; protected set; }
            public virtual void getCost()
            {
                Console.WriteLine("Getting Cost of Fruit...");
            }
        }
        class Apple : Fruit
        {
            public Apple(double c)
            {
                Cost = c;
            }
            public override void getCost()
            {
                Console.WriteLine("Apples are {0:C} a dozen", Cost * 12);
            }
        }
        class Orange : Fruit
        {
            public Orange(double c)
            {
                Cost = c;
            }
            public override void getCost()
            {
                Console.WriteLine("Oranges are {0:C} a dozen", Cost * 12);
            }
        }
        class Banana : Fruit
        {
            public Banana(double c)
            {
                Cost = c;
            }
            public override void getCost()
            {
                Console.WriteLine("Bananas are {0:C} a dozen", Cost * 12);
            }
        }
    }
}
