namespace NewPointe.eSpace.Models
{
    /// <summary>
    /// Event Deleted (Topic=`event.deleted`)
    ///
    /// Called when an event is deleted
    ///
    /// `EventDeletedWebhook.Data` is a list of Occurrence Ids
    /// </summary>
    public class EventDeletedWebhook : EventWebhook<long[]> { }
}
