using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>
            {
                //Creates the employees objects and adds them to the List. 
                new Employees(_firstName: "Tricia", _lastName: "Reimche", _id: 9),
                new Employees(_firstName: "Ragnar", _lastName: "Reimche", _id: 2),
                new Employees(_firstName: "Ophelia", _lastName: "Reimche", _id: 10),
                new Employees(_firstName: "Vegas", _lastName: "Reimche", _id: 11),
                new Employees(_firstName: "Sue", _lastName: "Zelez", _id: 23),
                new Employees(_firstName: "Michael", _lastName: "Zelez", _id: 15),
                new Employees(_firstName: "Joe", _lastName: "Zelez", _id: 1),
                new Employees(_firstName: "Shaelynn", _lastName: "Zurcher", _id: 13),
                new Employees(_firstName: "Joe", _lastName: "Smith", _id: 8),
                new Employees(_firstName: "Madilynn", _lastName: "Zurcher", _id: 6)
            };

            //Loop through the List and print out all the items of the List. 
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} has an ID number of {employee.ID}.");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************");

            // ****************************************************************************
            // Create a new empty list
            List<Employees> joe = new List<Employees>();
            // Loop through to find all the 'Joe' and put them in the new list of 'joe'
            foreach (Employees employee in employees)
            {
                if (employee.FirstName.Equals("Joe"))
                {
                    joe.Add(employee);
                }
            }
            // Display on the console
            foreach (Employees j in joe)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************");

            // ****************************************************************************
            // Create a new List through Lambda
            List<Employees> Joe = employees.Where(x => x.FirstName == "Joe").ToList();
            // Display on the console
            foreach (var j in Joe)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************");

            // ****************************************************************************
            // Create a new List through Lambda
            List<Employees> ID5 = employees.Where(x => x.ID > 5).ToList();
            // Display on the console
            foreach (var five in ID5)
            {
                Console.WriteLine(five);
            }




















            Console.ReadKey();
        }

        
    }
}
