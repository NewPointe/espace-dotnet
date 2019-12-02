using System;

using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    /// <summary>
    /// Occurrence Canceled (Topic=`occurrence.canceled`)
    /// Called when an an occurrence is canceled
    /// </summary>
    public class OccurrenceCanceledWebhook : EventWebhook<OccurrenceCanceledWebhook.Occurrence[]>
    {

        [JsonObject(MemberSerialization.OptIn)]
        public class Occurrence
        {

            [JsonProperty("Id")]
            public long Id { get; set; }

            [JsonProperty("SetUpStart")]
            public DateTime? SetUpStart { get; set; }

            [JsonProperty("EventStart")]
            public DateTime EventStart { get; set; }

            [JsonProperty("EventEnd")]
            public DateTime EventEnd { get; set; }

            [JsonProperty("TearDownEnd")]
            public DateTime? TearDownEnd { get; set; }
        }

    }
}
