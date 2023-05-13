using System;

namespace usingOverrideAndNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(2.5); //invoking directly on the derived class 
            apple.getCost();
            Fruit fruit = apple; //invoking on  derived class as base class
            fruit.getCost();

        }
        class Fruit // base class
        {
            public double Cost { get; protected set; }
            public virtual void getCost()
            {
                Console.WriteLine("Getting Cost of Fruit...");
            }
        }
        class Apple : Fruit // derived class - apple is Fruit
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
    }
}
