namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //intro to strings
            string x = "hello";
            string z = "World";
            Console.WriteLine(x + z);

            string a = "hello";
            string b = "h";
                b += "ello";
            Console.WriteLine(a == b);
            Console.WriteLine((Object)b == (Object)a);
            Console.WriteLine(a[2]);
            
            //String Literals
           string myString = "My \"so-called\" life"; 
           string myString2 = "Wen i need a new\nline in my program";
           string myString3 = "Navigate to your C:\\ Drivr";
           string myString4 = @"Navigate to your C:\ Drive";


            //using Standarard Numeric Format String
           string myString5 = String.Format("{0} = {1}", "First", "Second");

           string myString6 = String.Format("The amount is {0:C}", 11529.33);
           string myString7 = String.Format("The where {0:N} people in the Stadium", 283773987492);
           string myString8 = String.Format("My pass avarage this summer was {0:P}", 95);
           string myString9 = String.Format("Please call {0:(###) ###-####}", 0617714470);
 
            //string Indexing
           string myString10 = " Ï was born a winner and i always come up top Chicken dinner winner winner ";

            myString10.IndexOf("winner");
            myString10.IndexOfAny(new char[] { 'w', 'd' });
            myString10.LastIndexOf("dinner");
            myString10.LastIndexOfAny(new char[] { 'm' });

            //using Char and strings
            char[] y = new char[4];
            y[0] = myString10[8];
            y[1] = myString10[9];
            y[2] = myString10[10];
            y[3] = myString10[11];

           //Manipulating Strings
           myString10 = myString10.Substring(8, 29);
           myString10 = myString10.ToUpper();
           myString10 = myString10.Replace("born", "raised");
           myString10 = myString10.Remove(20);

            myString10 = String.Format("Length before: {0} -- Lenght after: {1}",
                myString10.Length,
                myString10.Trim().Length);

            //Working with strings on a more effecient manner or use the StringBuilder for this 
            string myString11 = "";
            for (int i = 0; i < 100; i++ )
            {
                myString11 += "--" + i.ToString();
            }

            Console.WriteLine(myString);
            Console.WriteLine(myString2);
            Console.WriteLine(myString3);
            Console.WriteLine(myString4);
            Console.WriteLine(myString5);
            Console.WriteLine(myString6);
            Console.WriteLine(myString7);
            Console.WriteLine(myString8);
            Console.WriteLine(myString9);
            Console.WriteLine(myString10);
            Console.WriteLine(myString11);


        }
    }
}