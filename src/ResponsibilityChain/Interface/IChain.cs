using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain.Interface
{
    public interface IChain<TIn, TOut> : IChain
    {
    }
    public interface IChain
    { 
    }
}
