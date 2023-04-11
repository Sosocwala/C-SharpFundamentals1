namespace introToArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 22, 33, 5, 15, 63, 20 };
            Console.WriteLine(age[3]);
            Console.WriteLine(age[0]);

            string[] cars = { "Volvo", "BMW", "Audi", "Ford", "Toyota", "Haval" };
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[1]);

            int[] FavNumbers = new int[5];
            FavNumbers[0] = 24;
            FavNumbers[1] = 44;
            Console.WriteLine("FavNumber 0 : {0}", FavNumbers[0]);

            string[] customers = { "Soso", "Ryan", "Pual", "Sapho" };



            object[] randomArray = { "Sonwa", 56, 54, 3 };
            Console.WriteLine("RandomArray 2 {0}", randomArray[2].GetType());
            Console.WriteLine("Array size : {0}", randomArray.Length);
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array : {0} : Value : {1}", i, randomArray[i]);
            }

            Console.WriteLine("-----------------------------");

            string[,] custName = new string[2, 2] { { "Roger", "Sindy" }, { "Yaya", "Mandy" } };
            Console.WriteLine("MD Value : {0}", custName[0, 1]);
        }
    }
}