//Задача 213г: Да се изчисли: √1+√2+√3+...+√49
using System;

namespace SumRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            double sum = 0;


            for (int i = 1; i <= 49; i++)
            {
                sum = sum + Math.Sqrt(i);

            }
            Console.Write("Сумата на корените на числата от 1 до 49 е: ");
            Console.WriteLine(sum);
        }
    }
}
