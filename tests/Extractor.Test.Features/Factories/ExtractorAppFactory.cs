using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;

namespace Extractor.Test.Features.Factories
{
    public class ExtractorAppFactory<TStartaup> : WebApplicationFactory<TStartaup> where TStartaup : class
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            var builder = Host.CreateDefaultBuilder().ConfigureWebHostDefaults(x => { x.UseStartup<TStartaup>().UseTestServer(); });
            builder.UseEnvironment("Testing");
            return builder;
        }
    }
}
