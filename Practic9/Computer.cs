using System;
using System.Collections.Generic;
using System.Text;

namespace Practic9
{

    struct Computer
    {
        string Processor { get; set; }
        int RAM { get; set; }
        int Memory { get; set; }
        string GPU { get; set; }

        public Computer(string processor, int ram, int memory, string gpu)//RAM - оператива. gpu - видеокарта
        {
            Processor = processor;
            RAM = ram;
            Memory = memory;
            GPU = gpu;
        }
        
       
    }
}
