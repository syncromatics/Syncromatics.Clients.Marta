﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RestEase;
using Syncromatics.Clients.Marta.Api.Models;

//required for RestEase to use internal interfaces
[assembly: InternalsVisibleTo(RestClient.FactoryAssemblyName)]

namespace Syncromatics.Clients.Marta.Api
{
    /// <summary>
    /// RestEase interface for consuming Marta api
    /// </summary>
    internal interface IMartaApi
    {
        [Get("/RealtimeTrain/RestServiceNextTrain/GetRealtimeArrivals")]
        Task<IList<TrainArrival>> GetRealTimeTrainArrivalsAsync(string apikey);
    }
}