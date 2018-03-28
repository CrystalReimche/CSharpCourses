using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = new DayOfWeek();
            dayOfWeek.WhatDay();
            
            Console.ReadKey();
        }
    }
}
