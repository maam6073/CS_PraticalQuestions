﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Basic
{
    class _001_Console
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("World!");
            Console.Write("이름을 입력하세요: ");

            string name = Console.ReadLine(); //이름을 입력받습니다.
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");
        }
    }
}
