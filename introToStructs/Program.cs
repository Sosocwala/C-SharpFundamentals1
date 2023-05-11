using System;

namespace introToStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Coords C1 = new Coords();
            C1.Y = 200;
            C1.X = 400;
            Coords C2 = C1;
            Console.WriteLine(C2.X + C2.Y);
            
        }
        public struct Coords
        {
            public double X, Y;
        }
    }
}
