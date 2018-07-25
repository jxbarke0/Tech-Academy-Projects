using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step161Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const string stepname = "Step 161 Exercise";
            Console.WriteLine("Welcome to the {0}!", stepname);

            var employee = new Employee("Jeff");
            
            Console.WriteLine(employee.FName + " " + employee.LName + " " + employee.ID);

            Console.Read();

        }
    }
    class Employee
    {
        
        public Employee(string first) : this(first, "Not Given", 9999)
        {

        }
        public Employee(string first, string last, int identifier)
        {
            FName = first;
            LName = last;
            ID = identifier;
        }

        public string FName { get; set; }
        public string LName { get; set; }
        public int ID { get; set; }

    }
}
