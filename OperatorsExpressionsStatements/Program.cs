namespace OperatorsExpressionsStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment Operator
            int x, y, a, b;

            x = 3;
            y = 4;
            a = 6;
            b = 2;

            //There are many mathematical operators ...

            //Addition operator
            x = 1 + 3;

            //Subtraction operator
            x = 4 - 2;

            //Multiplication operator
            x = 10 * 2;

            //Division operator
            x = 10 / 5;

            //Modulus operator
            x = 11 % 3;

            //There are many operators used to evaluate values ...

            //Equality operator
            if (x == y)
            {
            }

            //Greater than operator
            if (x > y)
            {
            }

            // Less than operator
            if (x < y)
            {
            }

            //Greater or equal to operator
            if (x >= y)
            {
            }

            //Less than or equal to opperator 
            if (x <= y)
            {
            }

            /* There are two "conditional" operators as well that can be used to expand / enhance an evaluation ....
             * ...and they can be combined together multiple times. */

            //Conditional AND operator
            if ((x > y) && (a > b))
            {
            }

            //Conditional OR operator
            if ((x > y) || (a > b))
            {
            }

            //Also here is a in-line conditional operator
            string messege = (x == 1) ? "Car" : "Boat";

        }
    }
}