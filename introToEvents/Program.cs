using System;

namespace introToEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit myFruit = new Fruit();
            myFruit.NewEvent += new EventHandler(newKind);
            myFruit.Kind = "Apple";
            myFruit.Kind = "Banana";
            myFruit.Kind = "Orange";
            myFruit.Kind = "Cherry";
        }
        static void newKind(object newk, EventArgs e)
        {
            Fruit fruit = (Fruit)newk;
            Console.WriteLine("The fruit has change to : {0}", fruit.Kind);
        }
        class Fruit
        {
            public event EventHandler NewEvent;
            private string kind;
            public string Kind
            {
                get { return kind; }
                set
                {
                    kind = value;
                    NewEvent(this, EventArgs.Empty);
                }

            }
        }

    }
}
