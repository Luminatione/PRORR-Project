﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRORR.Interfaces
{
    public interface ICrossover
    {
        Population Crossover(Population population);
    }
}