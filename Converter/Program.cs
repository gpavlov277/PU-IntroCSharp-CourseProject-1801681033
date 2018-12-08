using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 2033;
            string binary = Convert.ToString(value, 2);
            string octal = Convert.ToString(value, 8);
            string hex = Convert.ToString(value, 16);
            Console.WriteLine("2033=" + binary + "(2)");
            Console.WriteLine("2033=" + octal + "(8)");
            Console.WriteLine("2033=" + hex + "(16)");
        }
    }
}
