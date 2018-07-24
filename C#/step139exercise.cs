using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step140Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Step 140 Exercise!\nNow the Step 139 Exercise due to course reformatting.");

            var employees = new List<Employees>();
            employees.Add(new Employees
            {
                ID = 1,
                FName = "Joe",
                LName = "Schmo"
            });
            employees.Add(new Employees
            {
                ID = 2,
                FName = "John",
                LName = "Smith"
            });
            employees.Add(new Employees
            {
                ID = 3,
                FName = "Peter",
                LName = "Pettigross"
            });
            employees.Add(new Employees
            {
                ID = 4,
                FName = "Katherine",
                LName = "Potato"
            });
            employees.Add(new Employees
            {
                ID = 5,
                FName = "Joe",
                LName = "Potato"
            });
            employees.Add(new Employees
            {
                ID = 6,
                FName = "Big",
                LName = "Freedia"
            });
            employees.Add(new Employees
            {
                ID = 7,
                FName = "Large",
                LName = "Marge"
            });
            employees.Add(new Employees
            {
                ID = 8,
                FName = "Papa",
                LName = "Smurf"
            });
            employees.Add(new Employees
            {
                ID = 9,
                FName = "Joe",
                LName = "Smurf"
            });
            employees.Add(new Employees
            {
                ID = 10,
                FName = "Jupe",
                LName = "Noir"
            });
            employees.Add(new Employees
            {
                ID = 11,
                FName = "Onze",
                LName = "Reprisado"
            });
            employees.Add(new Employees
            {
                ID = 12,
                FName = "MacQuinoa",
                LName = "Kensyngtyn"
            });
            employees.Add(new Employees
            {
                ID = 13,
                FName = "Pygmy",
                LName = "Circus"
            });
            employees.Add(new Employees
            {
                ID = 14,
                FName = "Joe",
                LName = "Circus"
            });
            employees.Add(new Employees
            {
                ID = 15,
                FName = "Angela",
                LName = "Danza"
            });

            List<Employees> joEmployees = new List<Employees>();
            
            foreach(var i in employees)
            {
                if (i.FName == "Joe")
                {
                    joEmployees.Add(i);
                }
            }

            foreach (Employees j in joEmployees)
            {
                Console.WriteLine(j.ID + " " + j.FName + " " + j.LName);
            }

            List<Employees> joeList = employees.Where(x => x.FName == "Joe").ToList();

            foreach (Employees e in joeList)
            {
                Console.WriteLine(e.ID + " " + e.FName + " " + e.LName);
            }

            List<Employees> fiveList = employees.Where(x => x.ID > 5).ToList();

            foreach (Employees f in fiveList)
            {
                Console.WriteLine(f.ID + " " + f.FName + " " + f.LName);
            }

            Console.Read();



        }
    }
    public class Employees
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int ID { get; set; }

    }
}
