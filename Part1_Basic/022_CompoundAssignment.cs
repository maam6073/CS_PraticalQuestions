﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Basic
{
    class _022_CompoundAssignment
    {
        static void Main(string[] args)
        {
            int x = 32;

            Console.WriteLine(x += 2);
            Console.WriteLine(x -= 8);
            Console.WriteLine(x *= 3);
            Console.WriteLine(x /= 2);
            Console.WriteLine(x++);
            Console.WriteLine(--x);
        }
    }
}