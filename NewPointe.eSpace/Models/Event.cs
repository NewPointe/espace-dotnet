using System;

using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Event {

        [JsonRequired]
        [JsonProperty("EventName")]
        public string EventName { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("SetupStartDate")]
        public DateTime? SetupStartDate { get; set; }

        [JsonProperty("SetupStartTime")]
        public DateTime? SetupStartTime { get; set; }

        [JsonRequired]
        [JsonProperty("EventDate")]
        public DateTime? EventDate { get; set; }

        [JsonProperty("StartTime")]
        public DateTime? StartTime { get; set; }

        [JsonProperty("EventEndDate")]
        public DateTime? EventEndDate { get; set; }

        [JsonProperty("EndTime")]
        public DateTime? EndTime { get; set; }

        [JsonProperty("TeardownEndDate")]
        public DateTime? TeardownEndDate { get; set; }

        [JsonProperty("TearDownEndTime")]
        public DateTime? TearDownEndTime { get; set; }

        [JsonProperty("AdditionalDates")]
        public DateTime[] AdditionalDates { get; set; }

        [JsonProperty("IsPublic")]
        public bool? IsPublic { get; set; }

        [JsonProperty("NumOfPeople")]
        public int? NumOfPeople { get; set; }

        [JsonProperty("IsAllDayEvent")]
        public bool? IsAllDayEvent { get; set; }

        [JsonProperty("IsMultiDayEvent")]
        public bool? IsMultiDayEvent { get; set; }

        [JsonProperty("Categories")]
        public Category[] Categories { get; set; }

        [JsonProperty("AutoApprove")]
        public bool? AutoApprove { get; set; }

        [JsonProperty("OwnerId")]
        public int? OwnerId { get; set; }

        [JsonProperty("PublicNotes")]
        public string PublicNotes { get; set; }

        [JsonProperty("PublicLink")]
        public Uri PublicLink { get; set; }

        [JsonProperty("Locations")]
        public Location[] Locations { get; set; }

        [JsonProperty("PublicLocations")]
        public Location[] PublicLocations { get; set; }

        [JsonProperty("IsOffSite")]
        public bool? IsOffSite { get; set; }

        [JsonProperty("OffsiteLocation")]
        public string OffsiteLocation { get; set; }

        [JsonProperty("Editors")]
        public Editor[] Editors { get; set; }

        [JsonProperty("ScheduleId")]
        public int? ScheduleId { get; set; }

        [JsonProperty("EventId")]
        public int? EventId { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("PublicCalendarImageUrl")]
        public Uri PublicCalendarImageUrl { get; set; }

        [JsonProperty("Contacts")]
        public EventContact[] Contacts { get; set; }
    }
}
