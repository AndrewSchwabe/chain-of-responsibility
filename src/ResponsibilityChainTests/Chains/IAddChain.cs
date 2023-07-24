using ResponsibilityChain.Interface;
using ResponsibilityChainTests.Models;

namespace ResponsibilityChainTests.Chains
{
    internal interface IAddChain : IChain<AdditionRequest, AdditionResponse>
    {
    }
}