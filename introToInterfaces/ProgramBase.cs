namespace introToInterfaces
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            Apple grannySmith = new Apple { Amount = 12, Cost = 2.7 };
            Apple novel = new Apple { Amount = 12, Cost = 2.6 };
            int difference = grannySmith.CompareTo(novel); ;
            string results = "";
            if (difference == 0)
            {
                results = "the same price as";
            }
            else if (difference == 1)
            {
                results = "more expensive than the";
            }
            else
            {
                results = "less expensive than the";
            }
            Console.WriteLine("The Granny Smith is {0} Novel", results);
    }
}