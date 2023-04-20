using System;

namespace captureUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer : ");
            string input = Console.ReadLine(); //read string from console
            Console.WriteLine("You entered {0}", input);
            int num;
            if (int.TryParse(input, out num)) //Try to parse the string as integer
            {
                Console.Write("multiply that with 1000 : ");
                Console.WriteLine(num * 1000);
            }
            else
            {
                Console.WriteLine("This is not an integer");
            }
        }
    }
}
