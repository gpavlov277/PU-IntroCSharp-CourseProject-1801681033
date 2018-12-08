//Тест 3 3-II.  Да се дефинира метод F(n)=1+(4√2)+(4√3)+...+(4√n)
//    Да се състави програма, която въвежда 2 цели положителни числа
//    a и b и изчислява F(a+b)+F(|a-b|).
using System;

namespace FourthRootsCalculations
{
    class Program
    {

        static double method(double a, double b, int n)
        {
            double f = 0.0;

            for (int i = 1; i <= n; i++)
            {
                f = f + Math.Pow(i, 1.0 / 4);
            }
            return f * (a + b) + f * (Math.Abs(a - b));


        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int A = 0;
            int B = 0;
            do
            {
                Console.WriteLine("Въведете цели положителни числа");
                Console.Write("A =  "); A = int.Parse(Console.ReadLine());
                Console.Write("B =  "); B = int.Parse(Console.ReadLine());
            } while (A < 0.0 || B < 0.0);

            double res = method(A, B, n);


            Console.WriteLine("F(A+B)+F(|A-B|) = " + res);

        }
    }
}
