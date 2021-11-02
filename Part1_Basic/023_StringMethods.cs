using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
String 클래스의 메소드
메소드         동작
Insert        string 안의 특정 위치에 string을 삽입합니다.
Contains      특정 문자 또는 문자열을 포함하는지 true/false로 리턴합니다.
CompareTO     string을 비교해서 작은면 -값, 같으면 0, 크면 +값을 리턴합니다.
IndexOf       string에서 특정 문자 또는 문자열이 처음으로 나오는 index를 리턴합니다.
LastindexOf   string에서 특정 문자 또는 문자열이 마지막으로 나오는 index를 리턴합니다.
PadLeft       string 앞에 특정문자를 삽입하여 글자 수를 맞춥니다.
PadRight      string 뒤에 특정문자를 삽입하여 글자 수를 맞춥니다.
Remove        string에서 substring을 삭제합니다.
Replace       string에서 문자 혹은 substring을 다른 문자 혹은 substring으로 대체합니다.
ToLower       string의 문자를 소문자로 변환합니다.
ToUpper       string의 문자를 대문자로 변환합니다.
Trim          string에서 앞뒤의 공백문자 또는 특정 문자를 제거합니다.
TrimEnd       string의 뒤의 공백문자 또는 특정 문자를 제거합니다.
TrimStart     string의 앞의 공백문자 혹은 특정 문자를 제거합니다.
Split         string에서 substring을 추출하여 새로운 string 배열을 리턴합니다.
CopyTO        string의 일부분을 문자 배열로 복샇바니다.
Substring     string에서 특정 문자에서 끝까지의 substring을 추출합니다.

String 클래스의 정적 메소드
스태틱 메소드         동작
Concat               한 개 이상의 substring을 합쳐서 새로운 string을 만듭니다.
Compare              두 개의 string을 비교해서 상대적인 위치를 리턴합니다.
Copy                 현재 string을 복사하여 새로운 string을 만듭니다.
Format               문자열을 포맷에 맞추어 변경합니다.
Join                 배열이나 컬렉션의 멤버들을 모아서 새로운 string을 만듭니다. 이때 멤버 사이에 구분자를 삽입합니다.
*/


namespace Part1_Basic
{
    class _023_StringMethods
    {
        static void Main(string[] args)
        {
            string s = "Hello, World!";
            string t;

            Console.WriteLine(s.Length);
            Console.WriteLine(s[8]);
            Console.WriteLine(s.Insert(8, "c# "));
            Console.WriteLine(s.PadLeft(20, '.'));
            Console.WriteLine(s.PadRight(20,'.'));
            Console.WriteLine(s.Remove(6));
            Console.WriteLine(s.Remove(6,7));
            Console.WriteLine(s.Replace('1','m'));
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.Trim() + '/');
            Console.WriteLine('/' + s.TrimStart() + '/');
            Console.WriteLine('/' + s.TrimEnd() + '/');

            string[] a = s.Split(',');
            foreach (var i in a)
                Console.WriteLine('/' + i + '/');

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 6);
            Console.WriteLine(destination);

            Console.WriteLine('/' + s.Substring(8) + '/');
            Console.WriteLine('/' + s.Substring(8,5) + '/');

            Console.WriteLine(s.Contains("11"));
            Console.WriteLine(s.IndexOf('o'));
            Console.WriteLine(s.LastIndexOf('o'));
            Console.WriteLine(s.CompareTo("abc"));

            Console.WriteLine(String.Concat("Hi~", s));
            Console.WriteLine(String.Concat("abc", s));
            Console.WriteLine(t = String.Copy(s));

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(", ", val);
            Console.WriteLine(result);
        }
    }
}
