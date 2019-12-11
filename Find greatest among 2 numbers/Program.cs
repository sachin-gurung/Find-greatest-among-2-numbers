/*
 * C# Program to Find Greatest among 2 numbers
 */
using System;
class prog
{
    public static void Main()
    {
        int a, b;
        Console.WriteLine("Enter the Two Numbers : ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("{0} is the Greatest Number", a);
        }
        else
        {
            Console.WriteLine("{0} is the Greatest Number ", b);
        }
        Console.ReadLine();
    }
}
/*
Enter the Two Numbers :
56
62
62 is the Greatest Number

Press any key to continue . . .
*/
