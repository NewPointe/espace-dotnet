using System;

using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Webhook
    {

        [JsonProperty("Id")]
        public int? Id { get; set; }

        [JsonProperty("Url")]
        public Uri Url { get; set; }

        [JsonProperty("Notes")]
        public string Notes { get; set; }

        [JsonProperty("Events")]
        public WebhookEventType[] Events { get; set; }

    }
}
