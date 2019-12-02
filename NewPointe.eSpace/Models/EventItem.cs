using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class EventItem
    {

        /// <summary>
        /// The Item Id
        /// </summary>
        [JsonProperty("ItemId")]
        public int? ItemId { get; set; }

        [JsonProperty("ParentId")]
        public int? ParentId { get; set; }

        [JsonProperty("IsSchedulable")]
        public bool? IsSchedulable { get; set; }

        [JsonProperty("HasScheduledChildren")]
        public bool? HasScheduledChildren { get; set; }

        [JsonProperty("ChildrenIds")]
        [JsonConverter(typeof(CsvIntConverter))]
        public int[] ChildrenIds { get; set; }

        [JsonProperty("IsScheduled")]
        public bool? IsScheduled { get; set; }

        [JsonProperty("HasSchedualbleChildren")]
        public bool? HasSchedualbleChildren { get; set; }

        [JsonProperty("LocCode")]
        public string LocCode { get; set; }

        [JsonProperty("Capacity")]
        public int? Capacity { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Children")]
        public EventItem[] Children { get; set; }

        [JsonProperty("HasChildren")]
        public bool? HasChildren { get; set; }

        [JsonProperty("IsDraftConflicted")]
        public bool? IsDraftConflicted { get; set; }

        [JsonProperty("IsInventoriedItem")]
        public bool? IsInventoriedItem { get; set; }

        [JsonProperty("CurrentQtyOnHand")]
        public int? CurrentQtyOnHand { get; set; }

        [JsonProperty("OriginalQty")]
        public int? OriginalQty { get; set; }

        [JsonProperty("ShortageCount")]
        public int? ShortageCount { get; set; }

        [JsonProperty("ItemType")]
        public ItemType? ItemType { get; set; }

        [JsonProperty("IsAvailabilityScheduleConflicted")]
        public bool? IsAvailabilityScheduleConflicted { get; set; }

        [JsonProperty("IsClosureConflicted")]
        public bool? IsClosureConflicted { get; set; }

    }
}
