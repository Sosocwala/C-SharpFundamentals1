using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAndSealedClassess
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit("Mango", .7);
            Console.WriteLine("Type: {0}, cost per dozen: {1}", fruit.Kind, fruit.getCost());
        }
        abstract class Apple //base class; abstract cannot be instantiated
        {
            public string Kind { get; protected set; }
            public double Cost { get; protected set; }
            abstract public double getCost();
        }
        sealed class Fruit : Apple //derived class; sealed cannot be used for base classes
        {
           
            public Fruit(string k, double c)
            {
                Kind = k;
                Cost = c;
            }
            public string getFrurit()
            { 
                return Kind;
            } 
            sealed public override double getCost()
            {
                return Cost * 12;
            }
        }
    }
}
