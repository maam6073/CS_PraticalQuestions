using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
연산자의 종류

연산자 분류          연산자
산술 연산자          +,-,*,/,%
논리 연산자          !,~,&&,||
비트 연산자          &,!,^,<<,>>
증감 연산자          ++,--
관계 연산자          ==,!=,<,>,<=,>=
문자열연결 연산자    +
대입 및 복합 연산자  =,+=,-=,*=,/=,%=,<<=,>>=,&=,!=,^=
멤버 연산자          .
인덱싱 연산자        []
형변환 연산자        ()
조건 연산자          ?:
포인터 및 주소 연산자 *,->,&
Linq 연산자         => 
*/
namespace Part1_Basic
{
    class _014__Operators
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + 4 * 5);
            Console.WriteLine((3 + 4) * 5);
            Console.WriteLine(3 + 4 / 5);
            Console.WriteLine(4 / 5 * 3);

            int a = 10, b = 20, c;
            Console.WriteLine(c = a + b);
        }
    }
}
