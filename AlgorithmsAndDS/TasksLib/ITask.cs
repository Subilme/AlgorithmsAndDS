﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDS.TasksLib
{
    internal interface ITask
    {
        public string Name { get; }
        public string Description { get; }

        public void Start();
    }
}
