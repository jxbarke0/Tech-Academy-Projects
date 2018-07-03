using System;

namespace Page33Exercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\r\n\r\n  Anonymous Income Comparison Program");
            Console.WriteLine("\r\nPerson 1:\r\nEnter hourly rate.");
            string ratePerson1 = Console.ReadLine();
            decimal rate1 = Convert.ToDecimal(ratePerson1);
            Console.WriteLine("Enter hours worked per week.");
            string hourPerson1 = Console.ReadLine();
            decimal hour1 = Convert.ToDecimal(hourPerson1);

            Console.WriteLine("\r\nPerson 2:\r\nEnter hourly rate.");
            string ratePerson2 = Console.ReadLine();
            decimal rate2 = Convert.ToDecimal(ratePerson2);
            Console.WriteLine("Enter hours worked per week.");
            string hourPerson2 = Console.ReadLine();
            decimal hour2 = Convert.ToDecimal(hourPerson2);

            Console.WriteLine("\r\nAnnual salary of Person 1:\r\n" + (rate1 * hour1 * 52));
            Console.WriteLine("\r\nAnnual salary of Person 2:\r\n" + (rate2 * hour2 * 52));
            Console.WriteLine("\r\nDoes Person 1 make more money than Person 2?");
            bool incCompare = (rate1 * hour1 * 52) > (rate2 * hour2 * 52);
            Console.WriteLine(incCompare);

            Console.Read();







        }
    }
}
