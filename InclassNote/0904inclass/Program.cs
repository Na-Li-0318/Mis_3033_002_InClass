﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0904inclass
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            //var future=today.AddDays(27);
            DateTime future = today.AddDays(27);
            Console.WriteLine(today.ToLongDateString());
            Console.WriteLine(future);

            var difference = future - today;
            Console.WriteLine(difference);
            Console.ReadKey();

        }
    }
}
