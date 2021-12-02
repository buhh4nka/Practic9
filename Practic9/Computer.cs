using System;
using System.Collections.Generic;
using System.Text;

namespace Practic9
{

    struct Computer
    {
        public string Processor { get; set; }
        public int RAM { get; set; }
        public int Memory { get; set; }
        public string GPU { get; set; }

        public Computer(string processor, int ram, int memory, string gpu)//RAM - оператива. gpu - видеокарта
        {
            Processor = processor;
            RAM = ram;
            Memory = memory;
            GPU = gpu;
        }
        
       
    }
}
