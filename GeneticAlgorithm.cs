using PRORR.Implementation;
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
            population = new Population(configuration.PopulationSize, 1, configuration.IndividualGenerator);
        }

        public void Run()
        {
            var minFitnessList = new List<double>(configuration.PopulationSize);
            var maxFitnessList = new List<double>(configuration.PopulationSize);
            var meanFitnessList = new List<double>(configuration.PopulationSize);
            for (int i = 0; i < configuration.MaxGenerations; i++)
            {
                configuration.Evaluator.EvaluatePopulation(population, configuration.Degree);
                minFitnessList.Add(population.Individuals.Min(ind => ind.Fitness));
                maxFitnessList.Add(population.Individuals.Max(ind => ind.Fitness));
                meanFitnessList.Add(population.Individuals.Average(ind => ind.Fitness));
                population = configuration.Crossover.Crossover(population);
            }
            var visualizer = new FitnessVisualizer();
            visualizer.VisualizeFitness(minFitnessList, maxFitnessList, meanFitnessList);
            visualizer.VisualizePolynomial((configuration.Evaluator as PolynomialEvaluator).Polynomial, configuration.FirstRange, configuration.Degree);
        }

        public Individual GetBestIndividual()
        {
            return population.Individuals.OrderByDescending(i => i.Fitness).First();
        }
    }
}
