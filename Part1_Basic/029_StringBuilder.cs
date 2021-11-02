using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
StringBuilder 클래스의 속성과 메소드
속성          동작
Capacity      StringBuilder 객체에 할당된 메모리가 허용하는 최대 문자수를 가져오거나 설정합니다.
Length        StringBuilder 객체의 길이를 가져오거나 설정합니다.

메소드              동작
Append              StringBuilder 객체의 끝에 문자열을 추가합니다.
Clear               StringBuilder 객체의 모든 문자들을 없애줍니다.
CopyTo              string의 일부분을 문자 배열로 복사합니다.
EnsureCapacity      StringBuilder 객체의 용량을 최소한 지정된 값이 되도록 합니다.
Equals              이 객체가 다른 객체와 같은 지를 부울값으로 리턴합니다.
Insert              특정한 위치에 지정한 문자열을 삽입합니다.
Remove              특정 위치에 있는 문자열을 삭제합니다.
Replace             StringBuilder 객체에서 문자 혹은 substring을 다른 문자 혹은 substring으로 대체합니다.
ToString            StringBuilder 객체의 값을 String으로 변환합니다.
*/


namespace Part1_Basic
{
    class _029_StringBuilder
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is a StringBuilder Test.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Clear();
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Append("This is a new string.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Insert(5, "xyz", 2);
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Insert(5,4);
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Replace("xyz","abc");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            Stopwatch time = new Stopwatch();
            string test = string.Empty;
            time.Start();
            for(int i = 0; i< 100000; i++)
            {
                test += i;
            }
            time.Stop();
            Console.WriteLine("String: " + time.ElapsedMilliseconds + "ms");

            StringBuilder test1 = new StringBuilder();
            time.Reset();
            time.Start();
            for(int i = 0; i < 100000; i++)
            {
                test1.Append(i);
            }
            time.Stop();
            Console.WriteLine("StringBuilder: " + time.ElapsedMilliseconds + "ms");
        }
    }
}
