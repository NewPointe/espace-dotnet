namespace NewPointe.eSpace.Models
{
    /// <summary>
    /// Event Canceled (Topic=`event.canceled`)
    ///
    /// Called when an event is canceled
    ///
    /// `EventCanceledWebhook.Data` is a list of Occurrence Ids
    /// </summary>
    public class EventCanceledWebhook : EventWebhook<long[]> { }
}
