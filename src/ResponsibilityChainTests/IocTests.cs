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
using System.ComponentModel.DataAnnotations;
using ResponsibilityChain.Extension;
using ResponsibilityChainTests.Chains;

namespace ResponsibilityChainTests
{
    public class IocTests
    {

        [Fact]
        public void TestAddChain()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddChain<IAddChain, AddChain>();

            Assert.True(serviceCollection.Count == 1);
        }

    }
}