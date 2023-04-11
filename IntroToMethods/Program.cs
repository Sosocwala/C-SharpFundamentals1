namespace IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddNum(10);
        }
        public static void AddNum(int x)
        {
            x = x * 5;
            Console.WriteLine(x);
        }
    }
}