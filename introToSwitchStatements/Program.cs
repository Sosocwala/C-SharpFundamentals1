 using System;

namespace introToSwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            checkColor("purple");
        }
        public static void checkColor(string choice)
        {
            string peakColor;
            switch (choice)
            {
                /*
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
                    return; */


                //Another way of configering a switch statement
                case "red":
                case "pink":
                case "blue":
                case "orange":
                case "purple":
                    peakColor = "We do have the color you looking for";
                    break;
                default:
                    Console.WriteLine("Sorry we dont have the color you looking for");
                    return;


            }
            Console.WriteLine(peakColor);
            //Console.WriteLine("{0}{1}", "We do have the ", peakColor);
        }
    }
}
