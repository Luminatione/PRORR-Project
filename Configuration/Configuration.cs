using PRORR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRORR.ProgramConfiguration
{
    public class Configuration
    {
        public int PopulationSize { get; set; }
        public int ChromosomeLength { get; set; }
        public int MaxGenerations { get; set; }
        public IIndividualGenerator IndividualGenerator { get; set; }
        public IEvaluator Evaluator { get; set; }
        public ICrossover Crossover { get; set; }
        public IMutationController MutationController { get; set; }
        public IRandomGenerator RandomGenerator { get; set; }
    }
}
