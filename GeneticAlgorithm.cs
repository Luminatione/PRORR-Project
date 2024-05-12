using PRORR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRORR.ProgramConfiguration;

namespace PRORR
{
    public class GeneticAlgorithm
    {
        private Configuration configuration;
        private Population population;

        public GeneticAlgorithm(Configuration configuration)
        {
            this.configuration = configuration;
            population = new Population(configuration.PopulationSize, configuration.ChromosomeLength, configuration.IndividualGenerator);
        }

        public void Run()
        {
            for (int i = 0; i < configuration.MaxGenerations; i++)
            {
                configuration.Evaluator.EvaluatePopulation(population);
                population = configuration.Crossover.Crossover(population);
            }
        }

        public Individual GetBestIndividual()
        {
            return population.Individuals.OrderBy(i => i.Fitness).First();
        }
    }
}
