//Задача 37-4: Ако със знаковете  ¬, ∨ и ∧ означим съответно операциите отрицание, логическо събиране (дизюнкция)
//и логическо умножение (конюнкция), да се запишат на C# следните изрази:
//¬(s∨t)∧s∨¬t.
using System;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool s = true;
                bool t = true;

                bool expression = !(s || t) && s || !t;

                Console.WriteLine(expression);
            }
        }
    }
}