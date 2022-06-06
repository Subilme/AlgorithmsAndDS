using AlgorithmsAndDS.TasksLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDS.Lesson1
{
    internal class Task13 : ITask
    {
        public string Name => "1.3";

        public string Description => "Требуется реализовать функцию вычисления числа Фибоначчи";

        public void Start()
        {
            Console.WriteLine("Программма вычисления числа Фибоначчи");
            Console.Write("Введите порядковый номер числа в последовательности: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Введенное число меньше 0");
                return;
            }
            Console.WriteLine("Вычислено через рекурсию: " + Fibb(n));
            Console.WriteLine("Вычислено через цикл: " + FibbCycle(n));

            Console.WriteLine("Выход из задачи");
        }

        //Рекурсия
        private int Fibb(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return Fibb(n - 2) + Fibb(n - 1);
        }

        //Цикл
        private int FibbCycle(int n)
        {
            int first = 0, second = 1, fibb = 0;
            if (n == 1)
            {
                fibb = second;
            }

            for (int i = 0; i < n - 1; i++)
            {
                fibb = first + second;
                first = second;
                second = fibb;
            }

            return fibb;
        }
    }
}
