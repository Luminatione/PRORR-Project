using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRORR.Utility
{
    public class Polynomial
    {
        float[] coefficients;
        float[] exponents;

        public Polynomial(float[] coefficients, float[] exponents)
        {
            if (coefficients.Length != exponents.Length)
            {
                throw new ArgumentException("The number of coefficients must match the number of exponents.");
            }
            this.coefficients = coefficients;
            this.exponents = exponents;
        }

        public float Calculate(float[] variables)
        {
            float result = 0;
            for (int i = 0; i < coefficients.Length; i++)
            {
                result += coefficients[i] * (float)Math.Pow(variables[i], exponents[i]);
            }
            return result;
        }
    }
}
