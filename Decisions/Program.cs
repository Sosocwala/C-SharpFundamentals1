namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Soso's Big Giveawaay");
            Console.WriteLine("Choose a door: Door 1, Door 2 or Door 3");
            Console.Write("Enter Choice here : ");
            string choiceValue = Console.ReadLine();

            if (choiceValue == "1")
            {
                string messege = "You won a Iphone 14 Pro Max";
                Console.WriteLine(messege);
            }
            else if (choiceValue == "2")
            {
                string messege = "You won a Vouchar of R1000.00";
                Console.WriteLine(messege);
            }
            else if (choiceValue == "3")
            {
                string messege = "Sorry you lost, try again next time";
                Console.WriteLine(messege);
            }
            else
            {
                string messege = "Please Enter a correct Number";
                Console.WriteLine(messege);
            }
            Console.WriteLine("PRESS ENTER TO EXIT");
            
        }
    }
}