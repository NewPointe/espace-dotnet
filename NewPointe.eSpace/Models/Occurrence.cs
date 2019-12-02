using System;

using Newtonsoft.Json;

namespace NewPointe.eSpace.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Occurrence {

        /// <summary>
        /// The occurrence id
        /// </summary>
        [JsonProperty("OccurrenceId")]
        public int? OccurrenceId { get; set; }

        /// <summary>
        /// Setup date/time for occurrence
        /// </summary>
        [JsonProperty("SetUpStart")]
        public DateTime? SetUpStart { get; set; }

        /// <summary>
        /// Occurrence Start
        /// </summary>
        [JsonProperty("EventStart")]
        public DateTime? EventStart { get; set; }

        /// <summary>
        /// Occurrence End
        /// </summary>
        [JsonProperty("EventEnd")]
        public DateTime? EventEnd { get; set; }

        /// <summary>
        /// Teardown date/time for occurrence
        /// </summary>
        [JsonProperty("TearDownEnd")]
        public DateTime? TearDownEnd { get; set; }

        /// <summary>
        /// Denotes if occurrence is all-day
        /// </summary>
        [JsonProperty("IsAllDay")]
        public bool? IsAllDay { get; set; }

        /// <summary>
        /// The occurrence status
        /// </summary>
        [JsonProperty("OccurrenceStatus")]
        public string OccurrenceStatus { get; set; }

        [JsonProperty("Items")]
        public OccurrenceItem[] Items { get; set; }

        /// <summary>
        /// The event name
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName { get; set; }

        /// <summary>
        /// The event id
        /// </summary>
        [JsonProperty("EventId")]
        public int? EventId { get; set; }

        /// <summary>
        /// The schedule id
        /// </summary>
        [JsonProperty("ScheduleId")]
        public int? ScheduleId { get; set; }

        /// <summary>
        /// The status of the event
        /// </summary>
        [JsonProperty("EventStatus")]
        public string EventStatus { get; set; }

        /// <summary>
        /// The public image of the event
        /// </summary>
        [JsonProperty("PublicCalendarImageUrl")]
        public Uri PublicCalendarImageUrl { get; set; }

        [JsonProperty("IsPublic")]
        public bool? IsPublic { get; set; }

        [JsonProperty("PublicNotes")]
        public string PublicNotes { get; set; }

        [JsonProperty("PublicHtmlNotes")]
        public string PublicHtmlNotes { get; set; }

    }
}
