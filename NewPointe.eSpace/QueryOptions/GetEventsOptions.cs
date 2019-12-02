using System;
using NewPointe.Util.QueryString;

namespace NewPointe.eSpace
{
    [Serializable]
    public class GetEventsOptions
    {

        /// <summary>
        /// Retrieve events for next X days.
        /// </summary>
        [QueryStringProperty("nextDays")]
        public int? NextDays { get; set; }

        /// <summary>
        /// Retrieve event by name.
        /// </summary>
        [QueryStringProperty("eventName")]
        public string EventName { get; set; }

        /// <summary>
        /// Retrieve all events that start on/after date
        /// </summary>
        [QueryStringProperty("startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Retrieve all events that end on/before date
        /// </summary>
        [QueryStringProperty("endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Retrieve all events by category ids
        /// </summary>
        [QueryStringProperty("categoryIds")]
        public int[] CategoryIds { get; set; }

        /// <summary>
        /// Retrieve all events by location ids
        /// </summary>
        [QueryStringProperty("locationIds")]
        public int[] LocationIds { get; set; }

        /// <summary>
        /// Retrieve all events by category names
        /// </summary>
        [QueryStringProperty("categoryNames")]
        public string[] CategoryNames { get; set; }

        /// <summary>
        /// Retrieve all events by location codes
        /// </summary>
        [QueryStringProperty("locCodes")]
        public string[] LocCodes { get; set; }

        /// <summary>
        /// Retrieve next X events
        /// </summary>
        [QueryStringProperty("topX")]
        public int? TopX { get; set; }

        /// <summary>
        /// Set to true to only retrieve public events
        /// </summary>
        [QueryStringProperty("publicOnly")]
        public bool? PublicOnly { get; set; }

    }
}
