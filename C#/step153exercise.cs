using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Step153Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Step 153 Exercise!\n\nPlease enter a number.");
            string inText = Console.ReadLine();

            Console.WriteLine("\nWe will now write this number to a text file.");
            File.WriteAllText(@"C:\Users\geoff\Documents\Logs\153.txt", inText);

            Console.WriteLine("\nDone! Now we will pull the number from the text file and show it to you.");
            string outText = File.ReadAllText(@"C:\Users\geoff\Documents\Logs\153.txt");
            Console.WriteLine(outText);

            Console.ReadLine();
        }
    }
}
