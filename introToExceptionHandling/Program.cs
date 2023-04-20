using System;

namespace introToExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            try
            {
                num = num / int.Parse("0");
                Console.WriteLine("{0}", num);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
