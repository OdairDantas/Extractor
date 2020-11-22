using Extractor.API;
using Extractor.Test.Features.Factories;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using Xunit;

namespace Extractor.Test.Features.Features
{
    [CollectionDefinition(nameof(IntegrationTestsFixture))]
    public class IntegrationTestsFixture : ICollectionFixture<IntegrationTestsFixture<Startup>> { }
    public class IntegrationTestsFixture<TStartup> : IDisposable where TStartup : class
    {
        public readonly ExtractorAppFactory<TStartup> Factory;
        public HttpClient Client;
        public IntegrationTestsFixture()
        {
            var clientOptions = new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = true,
                BaseAddress = new Uri("http://localhost")

            };

            Factory = new ExtractorAppFactory<TStartup>();
            Client = Factory.CreateClient(clientOptions);
        }

        public void Dispose()
        {
            Client?.Dispose();
            Factory?.Dispose();
        }
    }
}
