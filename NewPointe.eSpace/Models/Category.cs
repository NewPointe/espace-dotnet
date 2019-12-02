using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Category
    {

        /// <summary>
        /// The category id.
        /// </summary>
        [JsonProperty("Id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// A flag that shows if event is available for public events.
        /// </summary>
        [JsonProperty("IsPublic")]
        public bool? IsPublic { get; set; }

    }
}
