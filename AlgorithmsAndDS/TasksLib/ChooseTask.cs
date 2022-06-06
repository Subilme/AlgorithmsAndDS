using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDS.TasksLib
{
    internal class ChooseTask : IChooseTask
    {
        private readonly List<ITask> _tasks;

        public ChooseTask(List<ITask> tasks)
        {
            _tasks = tasks;
        }

        public void StartTask(string input)
        {
            ITask task = _tasks.Find(x => x.Name == input);
            task.Start();
            Console.WriteLine();
        }
    }
}
