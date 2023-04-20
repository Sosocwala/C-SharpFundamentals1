using System;

namespace introToRandomization
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string fruit;
            for (int i = 0; i < 10; i++)
            {
                int randomNums = random.Next(0, 4);
                switch (randomNums)
                {
                    case 0:
                        fruit = "a Orange";
                        break;
                    case 1:
                        fruit = "an Apple";
                        break;
                    case 2:
                        fruit = "a Mango";
                        break;
                    case 3:
                        fruit = " an Grape ";
                        break;
                    default:
                        fruit = "Nothing";
                        return;
                }
                Console.WriteLine("You should have {0}", fruit);
            }
        }
    }
}
