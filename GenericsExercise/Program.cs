using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee class with data type
            Employee<string> stuff = new Employee<string>();
            // Instantiate 'stuff' with Employee property 'List<T> Things'
            stuff.Things = new List<string>();  
            // Add items to List
            stuff.Things.Add("Pencil"); 
            stuff.Things.Add("Pen"); 
            stuff.Things.Add("Paper");

            // Use Print() to display each item in List
            stuff.Things.ForEach(Print);

            Console.WriteLine();

            Employee<int> nums = new Employee<int>();

            nums.Things = new List<int>();
            nums.Things.Add(2);
            nums.Things.Add(8);
            nums.Things.Add(15);

            nums.Things.ForEach(Print);

            Console.ReadKey();
        }

        // PRINT METHOD
        private static void Print<T>(T s)
        {
            Console.WriteLine(s);
        }
    }
}
