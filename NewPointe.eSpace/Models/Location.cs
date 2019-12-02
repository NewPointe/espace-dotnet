using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Location
    {

        /// <summary>
        /// The id of the location.
        /// </summary>
        [JsonProperty("Id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the location.
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// A short code for the location.
        /// </summary>
        [JsonProperty("LocationCode")]
        public string LocationCode { get; set; }

    }
}
