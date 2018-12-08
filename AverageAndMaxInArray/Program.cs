//Задача 406. Да се въведе едномерен целочислен масив с дължина (брой елементи) в интервала [2,60].
//Да се контролира въвеждането на дължината в този интервал.
//    а) Да се напише метод Аverage(k), който връща средноаритметичното на тези елементи на масива, които принадлежат
//    на интервала [-10,10] и се делят на k без остатък. Да се въведе от клавиатурата цяло положително число k. Да се извика методът за въведения масив и резултатът от него да се отпечата на екрана.
//    б) Да се намерии отпечата на екрана първият максимален елемент на масива и неговият индекс. 

using System;

namespace AverageAndMaxInArray
{
    class Program
    {
        public static void EnterArrayValues(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter value: ");
                int currentElement = int.Parse(Console.ReadLine());
                array[i] = currentElement;

            }
        }
        public static double Avg(int[] array)
        {
            int sum = 0;
            int count = 0;
            Console.Write("Enter value for K: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                int currentElement = array[i];
                if (currentElement >= -10 && currentElement <= 10 && currentElement % k == 0)
                {
                    sum = sum + currentElement;
                    count++;
                }

            }
            double average = count > 0 ? (sum / count) : 0;
            return average;

        }
        public static void MaxElement(int[] array)
        {
            int maxElement = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    index = i;
                }
            }

            Console.WriteLine("Max element: " + maxElement + " with index " + index);
        }
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Enter a number [2,60] ");
                n = int.Parse(Console.ReadLine());

            } while (n < 2 || n > 60);

            int[] arrayA = new int[n];

            EnterArrayValues(arrayA);
            double average = Avg(arrayA);




            Console.WriteLine("Average is: " + average);
            MaxElement(arrayA);



        }
    }
}

