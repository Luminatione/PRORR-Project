using PRORR.Interfaces;
using PRORR.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRORR.Implementation
{
    public class PolynomialEvaluator : IEvaluator
    {
        private Polynomial polynomial;
        private int threads = 1;

        public PolynomialEvaluator(int threads, Polynomial polynomial)
        {
            this.threads = threads;
            this.polynomial = polynomial;
        }

        public void EvaluatePopulation(Population population)
        {
            Parallel.ForEach(population.Individuals, new ParallelOptions { MaxDegreeOfParallelism = threads }, individual =>
            {
                individual.Fitness = polynomial.Calculate(individual.Genes);
            });
        }
    }
}
