using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Editor
    {

        /// <summary>
        /// The id of the editor.
        /// </summary>
        [JsonProperty("Id")]
        public int? Id { get; set; }

        /// <summary>
        /// The first name of the editor.
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the editor.
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName { get; set; }

    }
}
