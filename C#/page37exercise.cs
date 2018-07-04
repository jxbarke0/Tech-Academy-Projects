using System;

namespace Page37Exercise1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\r\n-Acme Car Insurance Approval Console-");

            Console.WriteLine("\r\nWhat is your age?");
            string userAge = Console.ReadLine();
            int age = Convert.ToInt32(userAge);

            Console.WriteLine("\r\nHave you ever had a DUI? Enter \"True\" or \"False\".");
            string duiCheck = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiCheck);

            Console.WriteLine("\r\nHow many speeding tickets have you received?");
            string ticketCheck = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketCheck);

            Console.WriteLine("\r\nAre you qualified to receive car insurance through Acme?");
            bool qualified = age > 15 && dui == false && tickets < 3;
            Console.WriteLine(qualified + "...thank you for applying!");

            Console.ReadLine();

            // int favNum = Convert.ToInt32(Console.ReadLine());




        }
    }
}
