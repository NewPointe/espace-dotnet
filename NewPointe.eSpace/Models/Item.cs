using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Item
    {
        [JsonProperty("ItemId")]
        public int? ItemId { get; set; }

        [JsonProperty("ItemType")]
        public ItemType? ItemType { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("LocationName")]
        public string LocationName { get; set; }

        [JsonProperty("LocationId")]
        public int? LocationId { get; set; }

        [JsonProperty("Parent_id")]
        public int? Parent_id { get; set; }

        [JsonProperty("ParentName")]
        public string ParentName { get; set; }

        [JsonProperty("IsSchedulable")]
        public bool? IsSchedulable { get; set; }
    }
}
