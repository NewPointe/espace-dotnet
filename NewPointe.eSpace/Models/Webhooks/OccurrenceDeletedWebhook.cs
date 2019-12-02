using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    /// <summary>
    /// Occurrence Deleted (Topic=`occurrence.deleted`)
    /// Called when an occurrence is deleted
    public class OccurrenceDeletedWebhook : EventWebhook<OccurrenceDeletedWebhook.EventData[]>
    {

        [JsonObject(MemberSerialization.OptIn)]
        public class EventData
        {
            [JsonProperty("Id")]
            public long Id { get; set; }
        }

    }
}
