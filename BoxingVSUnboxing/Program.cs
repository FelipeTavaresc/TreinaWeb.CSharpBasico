﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingVSUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing
            int inteiro1 = 10;
            object objeto1 = inteiro1;
            //Console.WriteLine("Object = {0}", objeto1);
            //Console.ReadKey();

            //Unboxing
            int inteiro2 = (int)objeto1;
            Console.WriteLine("Inteiro2 = {0}", inteiro2);
            Console.ReadKey();
        }
    }
}
