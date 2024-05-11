using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRORR.Interfaces
{
    public interface IRandomGenerator
    {
        float Next(float minValue, float maxValue);
        int Next(int minValue, int maxValue);
        int NextWeighted(float[] weights);
        float NextGaussian(float mean, float stdDev);
    }
}
