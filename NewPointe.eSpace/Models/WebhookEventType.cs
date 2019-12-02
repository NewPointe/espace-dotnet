using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class WebhookEventType
    {

        [JsonProperty("Id")]
        public int? Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

    }
}
