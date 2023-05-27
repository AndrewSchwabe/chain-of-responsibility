using ResponsibilityChain.Interface;
using ResponsibilityChainTests.Models;
using System.Threading.Tasks;

namespace ResponsibilityChainTests.TestHandlers
{
    public class IntegerAdditionHandler : IHandler<AdditionRequest, AdditionResponse>
    {
        public Task<bool> Execute(AdditionRequest request, AdditionResponse response)
        {
            response.Value = request.InputOne + request.InputTwo;

            return Task.FromResult(true);
        }
    }
}