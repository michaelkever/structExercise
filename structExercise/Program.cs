﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structExercise
{
    class Program
    {
        public struct Number
        {
            public decimal Amount;
        }
          
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 1;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
         

    }
}
