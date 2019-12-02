using System;

using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    /// <summary>
    /// Event Approved (Topic=`event.approved`)
    /// Called when an event is approved
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EventWebhook<T>: WebhookEvent
    {

        [JsonProperty("DateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("EventId")]
        public long EventId { get; set; }

        [JsonProperty("EventName")]
        public string EventName { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Data")]
        public T Data { get; set; }

        [JsonProperty("DateTimeUpdated")]
        public bool DateTimeUpdated { get; set; }

    }
}
