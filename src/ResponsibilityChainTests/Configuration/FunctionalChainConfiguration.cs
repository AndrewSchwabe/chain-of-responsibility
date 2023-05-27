using Microsoft.Extensions.DependencyInjection;
using ResponsibilityChainTests.TestHandlers;

namespace ResponsibilityChainTests.Configuration
{
    public static class FunctionalChainConfiguration
    {

        public static void ConfigureServices(IServiceCollection services) {

            services.AddTransient<IntegerAdditionHandler>();
        }
    }
}
