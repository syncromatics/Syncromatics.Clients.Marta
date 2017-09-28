using System;
using Newtonsoft.Json;

namespace Syncromatics.Clients.Marta.Api.Models
{
    /// <summary>
    /// An upcoming or current arrival of a train at a station
    /// </summary>
    public class TrainArrival
    {
        /// <summary>
        /// The train's destination. Can be empty.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// The compass direction the train is traveling, i.e. N, S, E, W
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// The time for this update. The Kind property of this field will be Unspecified as offset information is not provided by the api.
        /// </summary>
        [JsonProperty("EVENT_TIME")]
        public DateTime EventTime { get; set; }

        public string Line { get; set; }

        /// <summary>
        /// The time the next arrival will occur, "08:40:16 PM"
        /// </summary>
        [JsonProperty("NEXT_ARR")]
        public string NextArrival { get; set; }

        public string Station { get; set; }

        [JsonProperty("TRAIN_ID")]
        public string TrainId { get; set; }

        /// <summary>
        /// The wait time until arrival. Can be negative if the train has already arrived
        /// </summary>
        [JsonProperty("WAITING_SECONDS")]
        public int WaitingSeconds { get; set; }

        /// <summary>
        /// The wait time expressed as a string. i.e. 4 min, Arriving, Arrived, Boarding
        /// </summary>
        [JsonProperty("WAITING_TIME")]
        public string WaitingTime { get; set; }

    }
}
