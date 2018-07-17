using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step111Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Step 111 Exercise!");
            Console.WriteLine("\nPlease enter a number you want to do some arbitrary math operations on.");
            int myEntry = Convert.ToInt32(Console.ReadLine());

            Operations operation1 = new Operations();
            int result = 0;
            result = operation1.NumSquare(myEntry);
            Console.WriteLine(myEntry + " squared is " + result + ".");

            Operations operation2 = new Operations();
            int result2 = 0;
            result2 = operation2.NumTimes(result);
            Console.WriteLine(result + " multiplied by 12 is " + result2 + ".");

            Operations operation3 = new Operations();
            int result3 = 0;
            result3 = operation3.NumPlus(result2);
            Console.WriteLine(result2 + " plus 42 is " + result3 + ".");

            Console.ReadLine();
        }
    }
}
