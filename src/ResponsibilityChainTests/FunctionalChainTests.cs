using Xunit;
using ResponsibilityChainTests.Models;
using ResponsibilityChainTests.TestHandlers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ResponsibilityChainTests.Configuration;
using System;
using Xunit.Sdk;
using ResponsibilityChain.Base;
using System.Threading.Tasks;

namespace ResponsibilityChainTests
{
    public class FunctionalChainTests
    {

        [Fact]
        public void AdditionRequestTest()
        {
            var handler = new IntegerAdditionHandler();

            var response = new AdditionResponse();
            handler?.Execute(
                new AdditionRequest
                {
                    InputOne = 1,
                    InputTwo = 2
                },
                response);

            Assert.Equal(3, response.Value);
        }

        [Fact]
        public async Task ChainAdditionRequestTest()
        {
            var chain = new Chain<AdditionRequest, AdditionResponse>();
            chain.AddHandler(new IntegerAdditionHandler());
            var response = new AdditionResponse();

            await chain.Execute(new AdditionRequest
            {
                InputOne = 2,
                InputTwo = 4
            }, response);

            Assert.Equal(6, response.Value);
        }
    }
}