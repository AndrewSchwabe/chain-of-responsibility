using ResponsibilityChain.Interface;
using ResponsibilityChainTests.Models;

namespace ResponsibilityChainTests.Chains
{
    internal class AddChain : IChain<AdditionRequest, AdditionResponse>, IAddChain
    {
    }
}
