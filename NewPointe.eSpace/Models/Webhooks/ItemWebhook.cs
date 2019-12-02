using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemWebhook: WebhookEvent
    {

        [JsonProperty("ItemId")]
        public long ItemId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Type")]
        public ItemType Type { get; set; }

        [JsonProperty("LocationName")]
        public string LocationName { get; set; }

        [JsonProperty("LocationId")]
        public long? LocationId { get; set; }

        [JsonProperty("ParentName")]
        public string ParentName { get; set; }

        [JsonProperty("ParentId")]
        public long? ParentId { get; set; }

    }
}
