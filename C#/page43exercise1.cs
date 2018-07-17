using System;

namespace Page43Exercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess my age. Enter a number.");
            int myAge = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = myAge == 34;

            do
            {
                switch (myAge)
                {
                    case 40:
                        Console.WriteLine("Be nice.");
                        Console.WriteLine("Guess my age. Enter a number.");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 25:
                        Console.WriteLine("You are so sweet. Sweet and wrong.");
                        Console.WriteLine("Guess my age. Enter a number.");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 33:
                        Console.WriteLine("So close!");
                        Console.WriteLine("Guess my age. Enter a number.");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 35:
                        Console.WriteLine("So close!");
                        Console.WriteLine("Guess my age. Enter a number.");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 34:
                        Console.WriteLine("You got it! How did you know?");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect. Please guess some more.");
                        Console.WriteLine("Guess my age. Enter a number.");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);
            {
                
            }
            



            Console.ReadLine();
        }
    }
}
