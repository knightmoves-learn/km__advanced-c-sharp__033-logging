using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace HomeEnergyApi.Tests.Extensions
{
    public class WebApplicationFactoryDefaultApiKey : WebApplicationFactory<Program>
    {
        public TestLoggerProvider LoggerProvider { get; } = new();

        protected override void ConfigureClient(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("X-Api-Key", "9a3cac68-ae5e-4862-9188-aad397ccc6fb");

            base.ConfigureClient(client);
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureLogging(logging => {
                logging.ClearProviders();
                logging.AddProvider(LoggerProvider);

                logging.SetMinimumLevel(LogLevel.Debug);
            });
        }
    }
}