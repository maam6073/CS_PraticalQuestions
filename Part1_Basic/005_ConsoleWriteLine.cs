﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Basic
{
    class _005_ConsoleWriteLine
    {
        static void Main(string[] args)
        {
            bool b = true;
            char c = 'A';
            decimal d = 1.234m;         //m은 decimal 형의 접미사
            double e = 1.23456789;
            float f = 1.23456789f;      //f는 float 형의 접미사
            int i = 1234;
            string s = "Hello";

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(s);
        }
    }
}
