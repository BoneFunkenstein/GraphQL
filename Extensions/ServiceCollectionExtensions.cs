using Microsoft.Extensions.DependencyInjection;
using System;

namespace GraphQL.Language.AST.Extensions.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Initializes Dapper and GraphQL with the dependency injection container.
        /// </summary>
        /// <param name="serviceCollection">The service collection container.</param>
        /// <param name="setup">An action used to initialize Dapper and GraphQL with the DI container.</param>
        /// <returns>The service collection container.</returns>
        public static IServiceCollection AddDapperGraphQL(this IServiceCollection serviceCollection, Action<AddRocketFuel> setup)
        {
            var options = new AddRocketFuel(serviceCollection);
            setup(options);

            return serviceCollection;
        }
    }
}