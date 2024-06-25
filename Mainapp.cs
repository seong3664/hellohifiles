using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace _0616_Csh
{
    internal class Mainapp
    {
        static void Main(string[] args)
        {
            #region 명시적 형변환시 일어나는 일
            //long l = long.MaxValue;
            //long m = long.MinValue;
            //WriteLine($"{l},{m}");
            //int i = (int)l;
            //int o = (int)m;
            //WriteLine($"{i},{o}");  // 오버플로가 발생해 데이터 유실
            //double dnum = 33.75678d;
            //int num1 = (int)dnum;
            //WriteLine($"dnum 값:{dnum}\nnum1 값:{num1}");    //소수점 아래가 잘려 데이터를 유실함.
            //int x = 255;
            //byte y = (byte)x;   //0~255까지의 양수만 표현 가능
            //WriteLine($"{x} -> {y}\n{str}");
            //byte b = 255;
            //sbyte c = (sbyte)b;
            //WriteLine(c);
            #endregion
            #region convert를 이용한 형변환
            //double d = 12.34;
            //int i = 1234;

            //d = i;        //64비트 데이터 형식인 double에 32비트 형식인 int를 넣는것임으로 암시적 형변환
            //WriteLine("암시적 형식 변한 = " + d);

            //d = 12.34;
            //i = (int)d;    //int는 소수점 아래를 가지지 못함으로 소수를 떼어낸 정수만을 저장
            //WriteLine("명시적 형변환 = " + i);

            //string s = "";
            //s = Convert.ToString(d);        //convert 클래스의 tostring함수를 통해 double을 string으로 변환
            //WriteLine("형식 변환 = " + s);
            //Write("정수를 입력하세요:");
            //string input = Console.ReadLine();
            //int number  = Convert.ToInt32(input);
            //WriteLine($"{number}-{number.GetType()}");
            //Write("실수를 입력하세요:");
            //string input = ReadLine();
            //double PI = Convert.ToDouble(input);
            //WriteLine(PI);
            //Write("문자를 입력하세요:");
            //string input = ReadLine();
            //char c = Convert.ToChar(input);
            //WriteLine(c);
            //char a = 'a', b = 'b', c = '가', d = '나';
            //WriteLine($"{a},{b},{c},{d}");
            //int num = 256;
            //char f = (char)num;
            //WriteLine(f);
            /*
            데이터 형식
            1.기본 데이터 형식
              1)정수: byte,short,int,long
              2)실수: double,float,decimal
              3)문자: char(정수도 표현가능),string
            2.복합 데이터 형식 종류
              1)클래스 배열
              2)구조체
            3.데이터 형식은 기본 데이터 형식과 복합 데이터 형식으로 분류하는 동시에
            값형식과 참조 형식으로 분류한다.
                1)값 형식은 변수가 값을 담는 데이터 형식을 말한다.
                2)참조 형식은 변수가 값대신에 값의 위치(주소,참조)를 담는 형식이다.
                3)값 형식은 스택에만 존재하고 중괄호를 빠져 나가면 메모리가 사라진다.
                4)참조 형식은 스택에 주소(참조값) 힙에는 값(변수값)을 저장한다.
                  즉 중괄호를 빠져나가도 스택(주소)는 사라지지만 힙에 있는 값은 저장하고 있다.
            5.스택은 중괄호만 벗어나면 메모리를 삭제
              하지만 힙은 개발자가 메모리를 할당 하면 가비지 컬렉터(컴파일러 안에 있는 프로그램
              개발자가 메모리 할당 한 것을 쓰고 있지 않으면 알아서 수거함)
              가 작동하기 전까지 존재함.
            */
            #endregion
            #region 10진수,2진수,8진수,16진수
            //byte a = 240; //10진수 리터럴
            //WriteLine($"a = {a}");
            //byte b = 0b1111_0000;  //2진수 리터럴
            //WriteLine($"b = {b}");
            //byte c = 0XF0;   //16진수 리터럴
            //WriteLine($"c = {c}");
            //uint d = 0x1234_add;   //16진수 리터럴 
            //WriteLine($"d = {d}");
            //byte x = 10;  //0000 1010
            ////x를 2진수로 표현하되, 8자리로 하고 앞부분은 모두 0으로 채운다.
            //WriteLine($"십진수: {x} -> 이진수: {Convert.ToString(x,2).PadLeft(8,'0')}");
            ////'0'적은 이유는 아스키 코드로 인식시켜주기 위해
            //WriteLine($"십진수 10을 이진수로 변경:{Convert.ToString(10,2)}");
            //WriteLine($"이진수 1010을 십진수로 변경:{Convert.ToInt32("1010",2)}");
            #endregion
            #region var 암시적 형식화
            //var str = "Hello";
            //var PI = 3.1415;
            //var ch = '나';
            //WriteLine($"{str},{str.GetType()}\n{PI},{PI.GetType()}\n{ch},{ch.GetType()}");
            ////클래스 생성자 부분에서 var를 쓰면 안된다.
            //var s = ReadLine(); 
            //var c =Convert.ToChar(Read());
            //WriteLine($"{s}:{s.GetType()}\n{c}:{c.GetType()}");
            //WriteLine("아무키나 누르세요");
            //ConsoleKeyInfo cki = Console.ReadKey(true);   //키보드 키 값 입력
            //WriteLine("{0}",cki.Key);           //키
            //WriteLine("{0}",cki.KeyChar);       //유니코드
            //WriteLine("{0}",cki.Modifiers);     //컨트롤,쉬프트,알트 조합
            //if (cki.Key == ConsoleKey.Q)      //조건문 만약 q가 입력되면
            //{
            //    Console.WriteLine("Q를 입력하셨군요...");   //아래 이 구문을 실행
            //}
            //if (cki.Key == ConsoleKey.A)
            //{
            //    Console.WriteLine("A를 입력하셨군요...");
            //}
            /*
            var와 object 차이점
            var는 똑똑한 자료형 대입되는 부분이 어떤 자료형이냐에 따라
            데이터 형식을 자동으로 추론하여 대입함. 하지만 클래스 생성자에는 쓰지 않는다.
            */
            //object a = 123;
            //object b = 3.14151912323232132321m;
            //object c = true;
            //object d = "안녕하세요";
            //WriteLine($"{a},{a.GetType()}\n{b},{b.GetType()}\n{c},{c.GetType()}\n{d},{d.GetType()}");
            /*
             var는 값으로 받지만 object는 참조 형식으로 받는다.
             기본 데이터형 뿐만 아니라 복합 데이터형식(class,배열)으로도 다 받는다.
             그래서 object는 모든 데이터형의 조상 또는 부모로 불린다.
            */
            //int a = 123;
            //object b = (object)a;   //a에 담긴 값을 박싱해서 힙에 저장
            //int c = (int)b;         //b에 담긴 값을 언박싱해서 스택에 저장
            //WriteLine($"{a}\n{b}\n{c}");
            //object d = b;
            //WriteLine(d);
            //object는 박싱 언박싱이 일어나기 때문에 var 보다 느리다.
            //대규모 프로젝트에서는 object보다 var를 선언하고
            //var는 클래스 생성자에서는 쓸 수가 없다.
            //매서드 안에 지역변수로 사용이 많이 된다.
            #endregion
            #region 변수 기본값(default) 설정
            //int i = default;
            //double d = default;
            //char c = default;
            //string s = default;
            //WriteLine($"[{i}],[{d}],[{c == char.MinValue}],[{s == null}]");
            //숫자 데이터는 디폴트 값을 0으로 받고 char은 \0이다 string은 null을 기본값으로 사용
            // int intDefault = default(int);
            // WriteLine(intDefault);
            // bool boolDefault = default(bool);
            // WriteLine(boolDefault);
            // string strDefault = default(string);
            // WriteLine($"[{strDefault}]");
            //StringBuilder sbDefault = default(StringBuilder);
            // WriteLine(sbDefault);
            //var t = (100, 200);
            //WriteLine(t.Item1);
            //WriteLine(t.Item2);
            //var (x, y) = (300, 400);
            //WriteLine($"{x}\n{y}");
            #endregion
            #region 단항-산술 연산자
            //int result = y - x;
            //int i = 0;
            //WriteLine($"{i}");
            //i++;    //다음줄에서 증가
            //WriteLine(i);
            //i--;     // 다음줄에서 감소
            //WriteLine(i);
            //WriteLine(++i);   //즉시 이줄에서 증가
            //WriteLine(i--);
            //WriteLine(i);
            //int num = 1000;
            //int number = num + 1234;
            //WriteLine(number);
            //int num1 = 10;
            //int num2 = (num1--) + 12;
            //WriteLine(num1);
            //WriteLine(num2);
            //bool iscorrect = (1 > 2) ? true : false;  //조건(1>2)이 1항 true가 2항 false가 3항
            ////그래서 삼항연산자.
            //WriteLine(iscorrect);
            //int a = 5, b = 3;
            //WriteLine(a+b);
            //WriteLine(a-b);
            //WriteLine(a*b);
            //WriteLine(a/b);
            //WriteLine($"{a} % {b} = {a % b}");
            //int days = 28;
            //WriteLine("2월달은 " + days + "일입니다.");
            //WriteLine("2월달은 " + days.ToString() + "일입니다.");
            //WriteLine("2월달은 " + Convert.ToString(days) + "일입니다.");
            #endregion
            #region 할당,증감 연산자
            //int b = 30;
            //int result= a = b;     //대입은 왼쪽에 오른쪽을 대입함.
            //WriteLine(result);
            //result += b;        //result = result + b
            //WriteLine(result);
            //result -= b;        //reult = result - b
            //WriteLine(result);
            //result *= b;
            //WriteLine(result);
            //result /= b;
            //WriteLine(result);
            //result %= b;
            //WriteLine(result);int a = 20;
            #endregion
            #region 논리형 연산자
            //WriteLine($"true && true -> {true && true}");
            //WriteLine($"true && false -> {true && false}");
            //WriteLine($"false && true -> {false && true}");
            //WriteLine($"false && false -> {false && false}");

            //int n1 = 10, n2 = 20;
            //WriteLine($"{n1 < 11 && n2 == 20}");
            //WriteLine($"{n1 > 11 && n2 == 20}");

            //WriteLine($"true || true -> {true || true}");
            //WriteLine($"true || false -> {true || false}");
            //WriteLine($"false || true -> {false || true}");
            //WriteLine($"false || false -> {false || false}");

            //double fnum1 = 23.76123456789d;
            //string result = fnum1.ToString("0.00");
            //WriteLine(fnum1.ToString() + 
            //    " 결과 " + result);
            //decimal dnum1 = 3.14156789123456789123m;
            //result = dnum1.ToString("0.000");
            //WriteLine($"{dnum1.ToString()} 결과 {result}");
            //float PI = 3.1415123456789f;
            //result = PI.ToString("0.000000");
            //WriteLine($"{PI.ToString()} 결과 {result}");

            //float fn1, fn2;
            //Write("첫번째 실수 입력:");
            //fn1 = float.Parse(ReadLine());
            //Write("두번째 실수 입력:");
            //fn2 = float.Parse(ReadLine());
            //WriteLine($"첫번째 입력한 실수 출력:{fn1.ToString("n4")}");
            //WriteLine($"두번째 입력한 실수 출력:{fn2.ToString("n6")}");
            //double pi = 3.1415123456789d;
            //string result = pi.ToString("n3");
            //WriteLine($"{pi} 결과 {result}");
            //result = string.Format("{0:n3}", pi);
            //WriteLine(result);
            //float fn1 = 3.1515f;
            //float fn2 = 3.1415f;
            //if(fn1 <= fn2)  //조건문
            //{
            //    WriteLine("fn1이 fn2 보다 크거나 같다");
            //}
            //else
            //{
            //    WriteLine("fn1은 fn2보다 작다");
            //}
            //if (fn1 == 3.1515f || fn2 > 3.1415f)
            //{
            //    WriteLine("OR  실행");
            //}
      
            #endregion


        }
    }
}
