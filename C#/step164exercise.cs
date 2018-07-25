using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step164Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Step 164 Exercise!");
            try
            {
                bool isAgeValid = false;
                int userAge = 0;
                while (!isAgeValid)
                {
                    Console.WriteLine("\nPlease enter your age.");
                    isAgeValid = int.TryParse(Console.ReadLine(), out userAge);
                    if (!isAgeValid) throw new Exception();
                }
                if (userAge > 120 || userAge < 0) throw new ArgumentOutOfRangeException();
                if (userAge == 0) throw new ArgumentException();
                DateTime currentYear = DateTime.Now;
                int birthYear = currentYear.Year - userAge;
                Console.WriteLine("If you have had your birthday this year, you were born in {0}. \nIf you have not already had your birthday, you were born in {1}.", birthYear, birthYear - 1);

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please enter a value between 1 and 120.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("This game is not for babies!");
                Console.Read();
                return;
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter a valid nonzero integer.");
            };
            Console.ReadLine();
            
        }
    }
}
