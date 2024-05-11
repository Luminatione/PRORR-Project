using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRORR.Interfaces
{
    public  interface IMutationController
    {
        float GetMutationRate(int iteration);
        void Mutate(Individual individual);
    }
}
