using System;
using System.Text;

namespace Page46Exercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\tWelcome to Page 46 Exercises!\n");
            Console.WriteLine("What is your first name?");
            string fName = Console.ReadLine();
            Console.WriteLine("\nWhat is your last name?");
            string lName = Console.ReadLine();
            Console.WriteLine("\nWhere are you from?");
            string place = Console.ReadLine();
            place = ("of " + place);
            string threeStrings = (fName + " " + lName + " " + place);
            threeStrings = threeStrings.ToUpper();
            Console.WriteLine("\n\tHello, " + threeStrings + "!");

            StringBuilder paragraph = new StringBuilder("\nYou are " + threeStrings +".");

            Console.WriteLine("What is your favorite food?");
            paragraph.Append(" You like " + Console.ReadLine() + ",");

            Console.WriteLine("\nWhat is your least favorite food?");
            paragraph.Append(" but you don't like " + Console.ReadLine() + ". That's okay!");

            Console.WriteLine("\nWhere would you like to go on vacation if you could go anywhere?");
            paragraph.Append(" Thanks for playing. You have just won a trip to " + Console.ReadLine() + "!!! \nEnter your credit card information below to redeem your prize. Congratulations!");




            Console.WriteLine(paragraph);
            Console.Read();






        }
    }
}
