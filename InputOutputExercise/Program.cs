using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutputExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number!");
            string userInput = Console.ReadLine();

            // Logging userInput into IOExercise.txt file
            File.WriteAllText(@"E:\Coding\Visual Studio\Projects\The Tech Academy\CSharpCourses\InputOutputExercise\IOExercise.txt", userInput);

            // Reading userInput number from IOExercise.txt file
            string answer = File.ReadAllText(@"E:\Coding\Visual Studio\Projects\The Tech Academy\CSharpCourses\InputOutputExercise\IOExercise.txt");

            // Displaying answer to console
            Console.WriteLine($"Your number was {answer}!");

            Console.ReadKey();
        }
    }
}
