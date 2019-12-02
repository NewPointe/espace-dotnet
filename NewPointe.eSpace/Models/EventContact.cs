using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class EventContact
    {

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Contact First Name
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Contact Last Name
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Contact Email
        /// </summary>
        [JsonProperty("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Contact Phone
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Contact Company
        /// </summary>
        [JsonProperty("Company")]
        public string Company { get; set; }

        /// <summary>
        /// Contact Id
        /// </summary>
        [JsonProperty("ContactId")]
        public string ContactId { get; set; }

    }
}
