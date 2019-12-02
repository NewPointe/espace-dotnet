using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    /// <summary>
    /// Event Approved (Topic=`event.approved`)
    /// Called when an event is approved
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class WebhookEvent
    {

        [JsonProperty("Topic")]
        public string Topic { get; set; }

        [JsonProperty("MinistryId")]
        public long MinistryId { get; set; }

        [JsonProperty("MinistryName")]
        public string MinistryName { get; set; }

    }
}
