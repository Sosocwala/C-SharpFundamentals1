using System;

namespace introToStaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit { Kind = "Apple", Cost = .6, Amount = 12 };
            Console.WriteLine("Fruit : {0} {1}",Fruit.fruitType, fruit.getFruit());
            
        }
        class Fruit
        {
            public static string fruitType
            {
                get { return "Banana"; }
            }



            public string Kind { get; set; }
            public double Cost { get; set; }
            public double Amount { get; set; }


            public string getFruit()
            {
                return this.Kind + " R" + this.Cost  + " each, R" + this.Amount + "per dozen";
            }
        }
    }
}
