using IntegrationDashboard.Model;
using IntegrationDashboard.Providers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntegrationDashboard.Controllers
{
    class TeamcityController
    {
        public async Task<Dictionary<User, int>> GetTopBuildersBreakers(string project)
        {
            if (string.IsNullOrEmpty(project))
                throw new ArgumentException(project);

            TeamcityProvider provider = new TeamcityProvider();
            JObject value = await provider.GetBuilds(project);

            Dictionary<User, int> topBuilder = new Dictionary<User, int>();

            return topBuilder;
        }

        private Dictionary<User,int> BuildTopBuilderBreakers(JObject response)
        {
            //TODO

            return new Dictionary<User, int>();
        }
    }
}
