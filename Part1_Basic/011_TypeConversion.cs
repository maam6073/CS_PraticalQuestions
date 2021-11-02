using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Basic
{
    class _011_TypeConversion
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            long bigNum = num;  //암시적 형변환
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;

            a = (int)x;         //명시적 형변환
            Console.WriteLine(a);
        }
    }
}
