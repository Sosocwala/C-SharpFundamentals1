namespace IntroToVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int x;
            int y;

            x = 20;
            y = x * 5;
            Console.WriteLine(y);
           */

            string myFristName;
            myFristName = "Soso";
            Console.WriteLine(myFristName);


            var FirstName = "Lalo";
            Console.WriteLine("First name is {0}", FirstName);

            int x = 7;
            string y = "8";
            string myFirdtTry = x.ToString() + y;

            int mySecondTry = x + int.Parse(y);

            Console.WriteLine(myFirdtTry);
            Console.WriteLine(mySecondTry);


        }
    }
}