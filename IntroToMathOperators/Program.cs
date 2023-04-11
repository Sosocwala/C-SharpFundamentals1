namespace IntroToMathOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            x = x + 10;
            Console.WriteLine(x);

            int a = 10;
            a++;
            Console.WriteLine(a);

            int b = 10;
            b += 2;
            Console.WriteLine(b);

            int c = 10;
            int d = 11;
            c += d;
            Console.WriteLine(c);

            int e = 10;
            int f = e++;//it performs something deferent when you put the unary operator in front 
            Console.WriteLine(e);
            Console.WriteLine(f);

            int g = 10;
            int h = ++g;//unary operater is realy sensitive 
            Console.WriteLine(g);
            Console.WriteLine(h);

            int i = 20;
            int j = i * (2 + 5);
            Console.WriteLine(j);

            int k = 20;
            int r = k * 2 + 5;
            Console.WriteLine(r);
        }
    }
}