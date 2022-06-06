using AlgorithmsAndDS.Lesson1;
using AlgorithmsAndDS.TasksLib;
using System;
using System.Collections.Generic;

namespace AlgorithmsAndDS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ITask> tasks = new List<ITask>
            {
                new Task11(),
                new Task13(),
            };

            while (true)
            {
                Console.WriteLine("info для получения списка задач");
                Console.WriteLine("exit для выхода");
                Console.WriteLine("Введите задание в формате <№ урока>.<№ задания>");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                else if (input == "info")
                {
                    Info(tasks);
                }
                else
                {
                    IChooseTask task = new ChooseTask(tasks);
                    task.StartTask(input);
                }
            }
        }

        static void Info(List<ITask> tasks)
        {
            Console.WriteLine("Список задач:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task.Name + " " + task.Description);
            }
            Console.WriteLine();
        }
    }
}
