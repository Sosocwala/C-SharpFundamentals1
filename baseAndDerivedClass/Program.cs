using System;

namespace baseAndDerivedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Apple", 2.5);
            Console.WriteLine("Fruit: {0}, cost per dozen: {1:C}", apple.Kind, apple.getCost());
            Mango mango = new Mango("Mango", 4.6);
            Console.WriteLine("Fruit: {0}, cost per dozen: {1:C}", mango.Kind, mango.getCost());
            Banana banana = new Banana("Apple", 3.7);
            Console.WriteLine("Fruit: {0}, cost per dozen: {1:C}", banana.Kind, banana.getCost());
            Orange orange = new Orange("Apple", 2.4);
            Console.WriteLine("Fruit: {0}, cost per dozen: {1:C}", orange.Kind, orange.getCost());



        }
        class Fruit // base class
        {
            public string Kind { get; protected set; }
            public double Cost { get; protected set; }
        }
        class Mango : Fruit // derived class
        {
            public Mango(string k, double c)
            {
                Kind = k;
                Cost = c;
            }
            public string getFruit()
            {
                return Kind;
            }
            public double getCost()
            {
                return Cost * 12;
            }
        }
        class Apple : Fruit // derived Class
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
            public double getCost()
            {
                return Cost * 12;
            }
        }
        class Banana : Fruit //derive class
        {
            public Banana(string k, double c)
            {
                Kind = k;
                Cost = c;
            }
            public string getFruit()
            {
                return Kind;
            }
            public double getCost()
            {
                return Cost * 12;
            }
        }
        class Orange : Fruit //derive class
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
            public double getCost()
            {
                return Cost * 12;
            }
        }
    }
}
