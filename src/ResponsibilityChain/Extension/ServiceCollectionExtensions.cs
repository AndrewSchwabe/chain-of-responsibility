using Microsoft.Extensions.DependencyInjection;
using ResponsibilityChain.Base;
using ResponsibilityChain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddChain<TService, TImplementation>(this IServiceCollection serviceCollection)
            where TService : IChain
        {
            serviceCollection.AddTransient(typeof(TService), typeof(TImplementation));
            return serviceCollection;
        }
    }
}
