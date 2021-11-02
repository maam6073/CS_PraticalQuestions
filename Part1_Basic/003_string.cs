using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
연산자     사용예     의미
==         a == b     string a와 b가 같다.
!=         a != b     string a와 b가 같지않다.
+          a + b      string a와 b를 연결한다.
*/
namespace Part1_Basic
{
    class _003_string
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";

            b = b + "ello";
            Console.WriteLine(a == b);
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x;
            Console.WriteLine("c = "+ c);
        }
    }
}
