using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IntegrationDashboard.Providers
{
    class TeamcityProvider
    {
        HttpClient client = new HttpClient();

        internal async Task<JObject> GetBuilds(string project)
        {
            if (string.IsNullOrEmpty(project))
                throw new ArgumentNullException("project");

            string url = "URL here";

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(url);

            return new JObject(await response.Content.ReadAsStringAsync());
        }
    }
}
