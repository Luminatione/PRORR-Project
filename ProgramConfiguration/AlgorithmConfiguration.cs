using Newtonsoft.Json;
using PRORR.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRORR.ProgramConfiguration
{
    public class AlgorithmConfiguration
    {
        public float MutationStdDev { get; set; }
        public float MutationMean { get; set; }
        public float MutationRate { get; set; }
        public int PopulationSize { get; set; }
        public int MaxGenerations { get; set; }

        public static AlgorithmConfiguration? LoadFromJson(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                AlgorithmConfiguration config = JsonConvert.DeserializeObject<AlgorithmConfiguration>(json);
                return config;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to load configuration: {e.Message}");
                return null;
            }

        }
    }
}
