using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ApiResponseFail {

        [JsonProperty("Message")]
        public string Message { get; set; }

    }
}
