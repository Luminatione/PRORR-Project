﻿using PRORR.Interfaces;
using PRORR.Utility;

namespace PRORR.Implementation
{
    public class PolynomialEvaluator : IEvaluator
    {
        public Polynomial Polynomial => polynomial;

        private Polynomial polynomial;
        private int threads = 1;

        public PolynomialEvaluator(int threads, Polynomial polynomial)
        {
            this.threads = threads;
            this.polynomial = polynomial;
        }

        public void EvaluatePopulation(Population population, int degree)
        {
            Parallel.ForEach(population.Individuals, new ParallelOptions { MaxDegreeOfParallelism = threads }, individual =>
            { 
                individual.Fitness = polynomial.Calculate(Enumerable.Repeat(individual.Genes[0], degree).ToArray());
            });
        }
    }
}
