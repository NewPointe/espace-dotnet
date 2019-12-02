using System;

using NewPointe.Util.QueryString;

namespace NewPointe.eSpace
{
    [Serializable]
    public class GetEventOccurrencesOptions: GetEventsOptions
    {

        /// <summary>
        /// Retrieve occurrences by event id.
        /// </summary>
        [QueryStringProperty("eventId")]
        public long? EventId { get; set; }

        /// <summary>
        /// Retrieve occurrences by occurrence id.
        /// </summary>
        [QueryStringProperty("occurrenceId")]
        public long? OccurrenceId { get; set; }

    }
}
