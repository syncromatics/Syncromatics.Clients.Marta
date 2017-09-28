using System.Collections.Generic;
using System.Threading.Tasks;
using Syncromatics.Clients.Marta.Api.Models;

namespace Syncromatics.Clients.Marta.Api
{
    /// <summary>
    /// Convenience interface for MartaApiClient if you prefer to depend on abstractions
    /// </summary>
    public interface IMartaApiClient
    {
        Task<IList<TrainArrival>> GetRealTimeTrainArrivalsAsync();
    }
}