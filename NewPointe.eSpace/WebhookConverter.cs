using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NewPointe.eSpace.Models
{
    public class WebhookConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(WebhookEvent).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            string type = jObject["Topic"].ToString();

            object result;
            switch (type)
            {
                case "event.submitted":
                    result = new EventSubmittedWebhook();
                    break;
                case "event.approved":
                    result = new EventApprovedWebhook();
                    break;
                case "event.deleted":
                    result = new EventDeletedWebhook();
                    break;
                case "event.canceled":
                    result = new EventCanceledWebhook();
                    break;
                case "event.declined":
                    result = new EventDeclinedWebhook();
                    break;
                case "event.draft":
                    result = new EventInDraftWebhook();
                    break;
                case "event.updated":
                    result = new EventUpdatedWebhook();
                    break;
                case "eventdates.updated":
                    result = new EventWebhook<object>();
                    break;
                case "item.created":
                    result = new ItemCreatedWebhook();
                    break;
                case "item.updated":
                    result = new ItemUpdatedWebhook();
                    break;
                case "item.deleted":
                    result = new ItemDeletedWebhook();
                    break;
                case "occurrence.deleted":
                    result = new OccurrenceDeletedWebhook();
                    break;
                case "scheduledItem.updated":
                    result = new WebhookEvent();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            serializer.Populate(jObject.CreateReader(), result);

            return result;

        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer,
            object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
