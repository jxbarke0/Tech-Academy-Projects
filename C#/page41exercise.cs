using System;


namespace Page41Exercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\r\n-Welcome to Package Express. Please follow the instructions below.-");
            Console.WriteLine("\r\nPlease enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter the package width.");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the package height.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the package length.");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\r\nYour total cost is: $" + (packageWidth * packageHeight * packageLength * packageWeight / 100) +".00.");
                    Console.ReadLine();
                }
            }
        }
    }
}
