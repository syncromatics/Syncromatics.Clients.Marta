using System.Collections.Generic;
using System.Threading.Tasks;
using Syncromatics.Client.Marta.Api.Models;

namespace Syncromatics.Client.Marta.Api
{
    /// <summary>
    /// Convenience interface for MartaApiClient if you prefer to depend on abstractions
    /// </summary>
    public interface IMartaApiClient
    {
        Task<IList<TrainArrival>> GetRealTimeTrainArrivalsAsync();
    }
}