//Задача 14. Да се състави алгоритъм за изчисляване на сумата S на аритметична прогресия със зададен първи член a1, разлика d и брой на членовете n.
using System;

namespace ArithmeticProgressionSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Console.WriteLine("Въведете стойност за а1: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете стойност за d: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете стойност за n: ");
            int n = int.Parse(Console.ReadLine());
            int S = 0;


            for (int i = 1; i <= n; i++)
            {

                S = S + a1;
                a1 = a1 + d;



            }
            Console.WriteLine("Сумата на аритметичната прогресия е: " + S);
        }
    }
}
