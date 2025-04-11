using Microsoft.AspNetCore.Mvc.Testing;

namespace HomeEnergyApi.Tests.Extensions
{
    public class WebApplicationFactoryDefaultApiKey : WebApplicationFactory<Program>
    {
        protected override void ConfigureClient(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("X-Api-Key", "9a3cac68-ae5e-4862-9188-aad397ccc6fb");

            base.ConfigureClient(client);
        }
    }
}