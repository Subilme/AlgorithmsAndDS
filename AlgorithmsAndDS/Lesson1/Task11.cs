using AlgorithmsAndDS.TasksLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDS.Lesson1
{
    internal class Task11 : ITask
    {
        public string Name => "1.1";

        public string Description => "Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.";

        public void Start()
        {
            Console.WriteLine("Программа проверки простого числа");

            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Введенное число меньше 0");
                return;
            }
            if (isPrime(n))
            {
                Console.WriteLine("Введенное число простое");
            }
            else
            {
                Console.WriteLine("Введенное число не является простым");
            }

            Console.WriteLine("Выход из задачи");
        }

        private bool isPrime(int n)
        {
            int d = 0, i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Более оптимизированный алгоритм поиска простого числа
        //private bool isPrime(int n)
        //{
        //    for (int i = 2; i <= Math.Sqrt(n); i += 2)
        //    {
        //        if ((n % i) == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
