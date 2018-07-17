using System;
using System.Collections.Generic;

namespace Page49Exercise
{
    class Program
    {
        static void Main()
        {
            //string[] strArray = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //Console.WriteLine("Please select an array index number 0-6.");
            //int daySelect = Convert.ToInt32(Console.ReadLine());
            //if (daySelect > 6)
            //    Console.WriteLine("You have selected an invalid value.");
            //else
            //    Console.WriteLine("You have selected " + strArray[daySelect] + ".");

            //int[] intArray = { 4, 8, 15, 16, 23, 42 };
            //Console.WriteLine("\nPlease select an array index number 0-5.");
            //int numSelect = Convert.ToInt32(Console.ReadLine());
            //if (numSelect > 5)
            //    Console.WriteLine("You have selected an invalid value.");
            //else 
            //    Console.WriteLine("You have selected " + intArray[numSelect] + ".");
            //Console.Read();

            string[] strArray = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("Please select an array index number 0-6.");
            int daySelect = Convert.ToInt32(Console.ReadLine());
            while (daySelect > 6)
            {
                Console.WriteLine("You have selected an invalid value.");
                Console.WriteLine("Please select an array index number 0-6.");
                daySelect = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have selected " + strArray[daySelect] + ".");

            int[] intArray = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine("\nPlease select an array index number 0-5.");
            int numSelect = Convert.ToInt32(Console.ReadLine());
            while (numSelect > 5)
            {
                Console.WriteLine("You have selected an invalid value.");
                Console.WriteLine("Please select an array index number 0-5.");
                numSelect = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have selected " + intArray[numSelect] + ".");

            List<string> strList = new List<string>();
            strList.Add("Water Bottle");
            strList.Add("Mobile Device");
            strList.Add("Rotary Phone");
            strList.Add("Compass");
            strList.Add("Margarine");
            Console.WriteLine("\nPlease select an array index number 0-4");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            while (listSelect > 4)
            {
                Console.WriteLine("You have selected an invalid value.");
                Console.WriteLine("\nPlease select an array index number 0-4");
                listSelect = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have selected " + strList[listSelect] + ".");

            Console.Read();
        }
    }
}
