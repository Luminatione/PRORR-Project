using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRORR
{
    public class Individual
    {
        public float[] Genes { get; private set; }

        public float Fitness { get; set; }

        public Individual(int geneCount)
        {
            Genes = new float[geneCount];
        }

        public Individual(float[] genes)
        {
            Genes = genes;
        }
    }
}
