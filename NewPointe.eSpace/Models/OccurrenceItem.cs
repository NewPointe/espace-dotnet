using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class OccurrenceItem {

        /// <summary>
        /// The schedulable item id
        /// </summary>
        [JsonProperty("ItemId")]
        public int? ItemId { get; set; }

        /// <summary>
        /// The item type (Space/Resource/Service)
        /// </summary>
        [JsonProperty("ItemType")]
        public string ItemType { get; set; }

        /// <summary>
        /// The name of the schedulable item
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// The qty requested for a inventoried resource
        /// </summary>
        [JsonProperty("Qty")]
        public int? Qty { get; set; }

    }
}
