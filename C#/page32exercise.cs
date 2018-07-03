using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page32exercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\r\n\r\n   Welcome to Some Math Exercises\r\n    ...where we take your input and perform some arbitrary arithmetic operations to it!");
            Console.WriteLine("\r\n1) Please enter a number. We will multiply it by 50.");
            string question1 = Console.ReadLine();
            long ques1 = 50 * Convert.ToInt64(question1);
            Console.WriteLine("You now have "+ ques1);

            Console.WriteLine("\r\n2) Please enter a number. We will add 25 to it.");
            string question2 = Console.ReadLine();
            int ques2 = 25 + Convert.ToInt32(question2);
            Console.WriteLine("You now have " + ques2);

            Console.WriteLine("\r\n3) Please enter another number. We will divide it by 12.5.");
            string question3 = Console.ReadLine();
            double ques3 = Convert.ToInt32(question3) / 12.5;
            Console.WriteLine("You now have " + ques3);

            Console.WriteLine("\r\n4) Please enter another number. We will tell you whether it is greater than 50.");
            string question4 = Console.ReadLine();
            bool ques4 = Convert.ToInt32(question4) > 50;
            Console.WriteLine(ques4);

            Console.WriteLine("\r\n5) For our final trick, we will divide your number by 7 and give you the remainder. Please enter your final number.");
            string question5 = Console.ReadLine();
            int ques5 = Convert.ToInt32(question5) % 7;
            Console.WriteLine("Your remainder is: " + ques5);

            Console.WriteLine("\r\n--That's all, folks. Have a nice day!--");
            Console.Read();

        }
    }
}
