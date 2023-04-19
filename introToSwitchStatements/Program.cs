 using System;

namespace introToSwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            checkColor("pink");
        }
        public static void checkColor(string choice)
        {
            string peakColor;
            switch (choice)
            {
                case "red":
                    peakColor = "Color red";
                    break;
                case "blue":
                    peakColor = "Color blue";
                    break;
                case "pink":
                    peakColor = "Color pink";
                    break;
                case "purple":
                    peakColor = "Color purple";
                    break;
                default:
                    Console.WriteLine("Sorry we dont have the colur you looking for");
                    return;
            }
            Console.WriteLine("{0}{1}", "We do have the ", peakColor);
        }
    }
}
