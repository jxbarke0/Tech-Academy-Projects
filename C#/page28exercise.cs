using System;


namespace DailyReportExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy \r\n-----------------\r\nStudent Daily Report\r\n____________________\r\n");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("\r\nWhat page number?");
            string pageNumber = Console.ReadLine();
            byte pageNo = Convert.ToByte(pageNumber);
            Console.WriteLine("\r\nDo you need help with anything? Please answer \"true\" or \"false\".");
            string helpIndicator = Console.ReadLine();
            bool helpInd = Convert.ToBoolean(helpIndicator);
            Console.WriteLine("\r\nWere there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("\r\nIs there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("\r\nHow many hours did you study today?");
            string hourNumber = Console.ReadLine();
            byte hourNo = Convert.ToByte(hourNumber);

            Console.WriteLine("\r\n__________________________\r\nThank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();



        }
    }
}
