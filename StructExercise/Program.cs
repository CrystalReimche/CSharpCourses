﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 9.99M;

            Console.WriteLine(num.Amount);

            Console.ReadKey();
        }
    }
}
