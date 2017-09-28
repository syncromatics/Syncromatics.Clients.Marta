using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Syncromatics.Clients.Marta.Api.Models;

namespace Syncromatics.Clients.Marta.Api
{
    /// <summary>
    /// Client for interacting with Marta's Api
    /// </summary>
    public class MartaApiClient : IMartaApiClient
    {
        private readonly IMartaApi _client;
        private readonly ClientSettings _settings;

        public MartaApiClient(ClientSettings settings)
        {
            _settings = settings;

            _client = new RestClient(settings.ServerRootUrl)
                .For<IMartaApi>();
        }

        /// <summary>
        /// Returns all upcoming train arrivals
        /// </summary>
        /// <returns></returns>
        public virtual Task<IList<TrainArrival>> GetRealTimeTrainArrivalsAsync()
        {
            return _client.GetRealTimeTrainArrivalsAsync(_settings.ApiKey);
        }
    }
}
