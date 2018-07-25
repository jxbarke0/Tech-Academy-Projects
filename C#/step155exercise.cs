using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step155Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Step 155 Exercise!\nThe date and time is: " + DateTime.Now);
            Console.WriteLine("\nPlease enter a number. We will tell you the exact time it will be in that many hours.");
            int hourNumber = Convert.ToInt32(Console.ReadLine());

            DateTime now = DateTime.Now;
            DateTime modifiedDateTime = now.AddHours(hourNumber);
            Console.Write("\nIn " + hourNumber + " hours, it will be: ");
            Console.Write(modifiedDateTime);

           

            Console.Read();
        }
    }
}
