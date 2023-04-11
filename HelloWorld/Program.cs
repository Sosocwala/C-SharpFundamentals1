namespace HelloWorld
{
    internal class Program
    {
        public class Greetrings
        {
            public Greetrings()
            {
                Console.WriteLine("Hello, World");
            }
        }
        static void Main(string[] args)
        {
            Greetrings greetrings = new Greetrings();

            Console.Write("What is your Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hello {Name}");
        }
    }
}