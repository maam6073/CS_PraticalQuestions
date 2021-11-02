using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Basic
{
    /*
    형식지정자        이름             정밀도 지정자            사용예
    "C" 또는 "c"      통화             십진자릿수               123.456 ("C") -> \123.46 , 123.456("C3") -> \123.456
    "D" 또는 "d"      십진수(정수)     최소자릿수               1234("D") -> 1234 , -1234("D6") -> 001234
    "E" 또는 "e"      지수(과학)       소수자릿수               1052.0329112756("E") -> 1.052033E+003 , -1052.0329112756("e2") -> -1.05e+003
    "F" 또는 "I"      고정자릿수       소수자릿수               1234.567("F") -> 1234.57 , -123456("F4") -> -1234.5600
    "G" 또는 "g"      일반             유효자릿수               -123.456 ("G") -> -123.456 , 123.4546("G4") -> 123.5
    "N" 또는 "n"      천단위 구분      소수자릿수               1234.567("N") -> 1,234,57
                      기호 숫자                                 -1234.56 ("N3") -> -1,234,560
    "P" 또는 "p"      퍼센트           소수자릿수               1("P") -> 100.00% , -0.39678 ("P1") -> -39.7%
    "R" 또는 "r"      라운드트립       무시됨                   1234567.12345("R") -> 1234567.12345
    "X" 또는 "x"      16진수           자릿수                   255("X") -> FF , 255("x4") -> 00ff
    */

    class _008_ConsoleFormat
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency: . . . . . . . . {0:C}\n" +
                "(D) Decimal: . . . . . . . . {0:D}\n" +
                "(E) Scientific: . . . . . . . . {1:E}\n" +
                "(F) Fixed point: . . . . . . . . {1:F}\n" +
                "(G) General: . . . . . . . . {0:G}\n" +
                "(N) Number: . . . . . . . . {0:N}\n" +
                "(P) Percent: . . . . . . . . {1:P}\n" +
                "(R) Round-trip: . . . . . . . . {1:R}\n" +
                "(X) Hexadecimal: . . . . . . . . {0:X}\n",
                -12345678, -1234.5678f);
        }
    }
}
