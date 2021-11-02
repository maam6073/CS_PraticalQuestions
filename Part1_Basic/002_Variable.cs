using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Basic
/*
부호있는 정수
형식      크기      표현할 수 있는 수의 범위
sbyte     8bit          -128 ~ 127
short     16bit         -32,768 ~ 32,767
int       32bit         -2,147,483 ~ 2,147,483,647
long      64bit         -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
-------------------------------------------------------------------------------
부호없는 정수
형식      크기      표현할 수 있는 수의 범위
byte      8bit           0 ~ 255
ushort    16bit          0 ~ 65,535
uint:     32bit          4,294,967,295
ulong     64bit          0 ~ 18,446,744,073,709,551,615
-------------------------------------------------------------------------------
부동 소수점
형식      크기      표현할 수 있는 수의 범위
float     32bit          1.5 X 10 -45승 - 3.4 X 10 38승,전체 자릿수 7자리
double    64bit          5.0 X 10 -324승 -1.7 X 10 308승,전체 자릿수 15자리
-------------------------------------------------------------------------------
Decimal
형식      크기      표현할 수 있는 수의 범위
decimal  128bit          -7.9 X 10 -28승 -7.9 X 10 28승,전체 자릿수 28자리 이상
*/
{
    class _002_Variable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력하세요: ");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("키를 입력하세요(cm): ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는 ");
            Console.Write(height);
            Console.WriteLine("cm 이군요!");
        }
    }
}
