namespace ClassConstructorMethods
{
    internal class Program
    {
        public class cost
        {
            public double amount;
            public double price;
            public cost(double a, double p)
            {
                this.amount = a;
                this.price = p;
            }
            public cost(double a)
            {
                this.amount = a;
                this.price = .35;
            }
            public double getAmount()
            {
                return amount * price
            }

        }
        static void Main(string[] args)
        {
            
            cost eggs = new cost(12, 23);
            double Cost = eggs.getAmount();
            Console.WriteLine("Cost of 12 eggs: R{0}", Cost);
            Console.WriteLine("Press Enter to exit");

        }
    }
}