using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints the current date and time to the console.
            Console.WriteLine($"Right now it is: {DateTime.Now}");

            // Asks the user for a number.
            bool wholeNumber = true;
            do
            {
                try
                {
                    Console.WriteLine("Please enter a number.");
                    double userInput = Convert.ToDouble(Console.ReadLine());

                    // Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
                    var addUserHours = DateTime.Now.AddHours(userInput);
                    Console.WriteLine($"The date and time will be {addUserHours} after adding {userInput} hours to the current time.");
                    wholeNumber = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, I could not understand your number, please try again and enter a whole number.");
                    Console.WriteLine();
                    wholeNumber = false;
                }

            } while (!wholeNumber);
                
            

            Console.ReadKey();
        }
    }
}
