using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    /// <summary>
    /// Event Submitted (Topic=`event.submitted`)
    ///
    /// Called when an event is submitted
    /// </summary>
    public class EventSubmittedWebhook : EventWebhook<EventSubmittedWebhook.EventDetails>
    {
        [JsonObject(MemberSerialization.OptIn)]
        public class EventDetails
        {

            [JsonProperty("RecurrenceType")]
            public string RecurrenceType { get; set; }

            [JsonProperty("IsPublic")]
            public bool IsPublic { get; set; }

            [JsonProperty("Description")]
            public string Description { get; set; }

            [JsonProperty("NumberOfPeople")]
            public int? NumberOfPeople { get; set; }

            [JsonProperty("PublicNotes")]
            public string PublicNotes { get; set; }

            [JsonProperty("PublicLink")]
            public string PublicLink { get; set; }

            [JsonProperty("IsOffsite")]
            public bool IsOffsite { get; set; }

            [JsonProperty("OffsiteLocations")]
            public string OffsiteLocations { get; set; }

            [JsonProperty("Owner")]
            public User Owner { get; set; }

            [JsonProperty("Locations")]
            public EventLocation[] Locations { get; set; }

            [JsonProperty("Categories")]
            public EventCategory[] Categories { get; set; }

            [JsonProperty("Contacts")]
            public User[] Contacts { get; set; }

        }

        [JsonObject(MemberSerialization.OptIn)]
        public class EventLocation
        {

            [JsonProperty("Id")]
            public long Id { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

        }

        [JsonObject(MemberSerialization.OptIn)]
        public class EventCategory
        {

            [JsonProperty("Id")]
            public long Id { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

        }

        [JsonObject(MemberSerialization.OptIn)]
        public class User
        {

            [JsonProperty("FirstName")]
            public string FirstName { get; set; }

            [JsonProperty("LastName")]
            public string LastName { get; set; }

            [JsonProperty("Email")]
            public string Email { get; set; }

        }
    }
}
