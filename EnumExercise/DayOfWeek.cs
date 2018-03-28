using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    public class DayOfWeek
    {
        public void WhatDay()
        {
            // Ask the user a question
            Console.Write("What day of the week is it? ");
            // Store answer in variable, all lowercase
            string userInput = Console.ReadLine().ToLower();
            
            // Set up try/catch
            try
            {
                // Check if userInput string can be parsed into DaysOfTheWeek enum ie: is there an enum that matches what the user typed in
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                // Convert that enum string name into its underlying value
                int dayValue = (int)day;
                // Display it to console
                Console.WriteLine($"The underlying value for {day} is: {dayValue}");
            }
            catch (Exception)
            {
                Console.WriteLine("FAILED");
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }

    public enum DaysOfTheWeek
    {
        unknown = 0,
        monday = 1,
        tuesday = 2,
        wednesday = 3,
        thursday = 4,
        friday = 5,
        saturday = 6,
        sunday = 7
    }
}
