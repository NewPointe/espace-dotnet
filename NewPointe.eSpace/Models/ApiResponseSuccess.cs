using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ApiResponseSuccess<T> {

        [JsonProperty("IsSuccessStatusCode")]
        public bool IsSuccessStatusCode { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Data")]
        public T Data { get; set; }

    }
}
