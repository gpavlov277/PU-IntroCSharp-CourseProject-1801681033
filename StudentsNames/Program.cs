//Задача 371. Елементите на масив са имена на студенти (име, презиме, фамилия). Да се съставят методи за:
//    а) Въвеждане на елементите на масива (не повече от 50).
//    б) извеждане на екрана на имената на всички студентки (имената им завършват на "а"), които имат в имената си Иван(иван). 
//Например: Иванка Анева Пелова, Ана Иванова Гогова, Ненка Монева Караиванова.

using System;
using System.Text;

namespace StudentsNames
{
    class Program
    {

        static void Enter()
        {

            int n;
            do
            {
                Console.WriteLine("Enter students count between 1 and 50: ");
                n = int.Parse(Console.ReadLine());

            } while (n < 1 || n > 50);

            string[] studentsNames = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter student " + (i + 1) + " names: ");
                string name = Console.ReadLine();
                studentsNames[i] = name;

            }


            for (int i = 0; i < n; i++)
            {
                int index = studentsNames[i].IndexOf(' ');


                if (studentsNames[i][index - 1] == 'a')
                {



                    if (studentsNames[i].Contains("ivan") || studentsNames[i].Contains("Ivan"))
                    {
                        Console.WriteLine(studentsNames[i]);
                    }

                }

            }
        }









        static void Main(string[] args)
        {



            Enter();


        }
    }
}
